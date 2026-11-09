using System.Runtime.CompilerServices;

namespace BmSDK.Framework;

/// <summary>
/// Stops UObject::ProcessEvent from freeing optional string/array arguments of script functions
/// before the call runs.
/// </summary>
/// <remarks>
/// ProcessEvent copies the caller's parameters into the call's frame, then evaluates the default
/// value of every optional parameter into the CALLER's buffer (EX_DefaultParmValue with the
/// "evaluate" flag set). For a parameter that owns memory, that assignment frees the value the
/// caller passed, which the frame still points at, so the function reads freed memory (e.g.
/// SplitString's delimiter arrived as one garbage character). The default never reaches the
/// frame anyway, so skipping that pass changes nothing else.
/// <para/>
/// While suspended, the function's optional parameters lose CPF_OptionalParm, so ProcessEvent
/// skips the pass. The script function then meets its default-value block at the top of its body
/// and skips it (EX_DefaultParmValue without the flag jumps over its expression). Only functions
/// where a real default would be assigned over a string, array, map or struct are touched;
/// anything unexpected in the block leaves the function untouched (stock behaviour).
/// <para/>
/// Natives are never touched: their bytecode is the default-value block followed by the reads of
/// their parameters, so skipping the pass would also need their script pointer moved past the
/// block.
/// <para/>
/// Ported from XeTrinityz/BmSDK-AK (Arkham Knight, 64-bit). BmSDK-AO: in Arkham Origins (32-bit, UStruct of 108
/// bytes) the Script array is at +68, right after PropertiesSize and MinAlignment (two WORDs at +64 and +66), but it
/// is not a plain TArray: its count and capacity are two WORDs at +72 and +74 (BmSDK.log memory dump, 2026-11-08:
/// Core.Object:Subtract_LinearColorLinearColor has 0x00720072 there, and its export in Core.upk says 0x72 bytes of
/// script; FindDeltaAngle 0x73, GetPackageName 0x53). Until then +68 was read as {data, int Num, int Max} and never
/// passed. The layout is still checked once per session on a sample of script functions (readable bytecode, 0 < Num
/// <= Max in at least 80 % of them); if it does not hold, the whole mechanism stays off for the session (logged
/// once, with a memory dump) and every call behaves as before.
/// </remarks>
internal static unsafe class OptionalParms
{
    // BmSDK-AO: Script = { byte* Data at +68, WORD Num at +72, WORD Max at +74 } (see remarks)
    private const int ScriptData = 68;
    private const int ScriptNum = 72;
    private const int ScriptMax = 74;
    private const int ProbeSample = 40;

    private const byte EX_Nothing = 0x0B;
    private const byte EX_DefaultParmValue = 0x49;

    /// <summary>BmSDK-AO: whether the Script offset has been looked for (null) and found.</summary>
    private static bool? s_layoutOk;

    [DllImport("kernel32.dll")]
    private static extern nuint VirtualQuery(IntPtr address, out MemoryBasicInformation buffer, nuint length);

    [StructLayout(LayoutKind.Sequential)]
    private struct MemoryBasicInformation
    {
        public IntPtr BaseAddress;
        public IntPtr AllocationBase;
        public uint AllocationProtect;
        public nuint RegionSize;
        public uint State;
        public uint Protect;
        public uint Type;
    }

    /// <summary>Whether [address, address + length) is committed, readable memory.</summary>
    private static bool IsReadable(IntPtr address, int length)
    {
        const uint MEM_COMMIT = 0x1000;
        const uint PAGE_NOACCESS = 0x01;
        const uint PAGE_GUARD = 0x100;
        var end = (nuint)address + (nuint)length;
        for (var p = (nuint)address; p < end; )
        {
            if (VirtualQuery((IntPtr)p, out var info, (nuint)sizeof(MemoryBasicInformation)) == 0
                || info.State != MEM_COMMIT
                || (info.Protect & (PAGE_NOACCESS | PAGE_GUARD)) != 0)
            {
                return false;
            }
            p = (nuint)info.BaseAddress + info.RegionSize;
        }
        return true;
    }

    /// <summary>
    /// BmSDK-AO: the bytecode of <paramref name="func"/>, or null if the Script offset could not be found (looked for
    /// once per session, then trusted).
    /// </summary>
    private static byte* ReadScript(Function func, out int length)
    {
        length = 0;
        s_layoutOk ??= CheckLayout();
        if (s_layoutOk == false)
        {
            return null;
        }

        length = *(ushort*)(func.Ptr + ScriptNum);
        return *(byte**)(func.Ptr + ScriptData);
    }

    /// <summary>Whether <paramref name="func"/> holds plausible bytecode at the AO layout.</summary>
    private static bool HasScript(Function func)
    {
        var code = *(byte**)(func.Ptr + ScriptData);
        int num = *(ushort*)(func.Ptr + ScriptNum);
        int max = *(ushort*)(func.Ptr + ScriptMax);
        return code != null && num > 0 && max >= num && IsReadable((IntPtr)code, num);
    }

    private static bool CheckLayout()
    {
        var sample = new List<Function>(ProbeSample);
        try
        {
            foreach (var f in Game.FindObjects<Function>())
            {
                if (f.IsValid && !f.FunctionFlags.HasFlag(Function.EFunctionFlags.FUNC_Native))
                {
                    sample.Add(f);
                    if (sample.Count == ProbeSample)
                    {
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"Optional parameters: no script functions to look at ({ex.Message})");
        }

        var hits = sample.Where(HasScript).ToList();
        if (sample.Count >= 10 && hits.Count * 5 >= sample.Count * 4)
        {
            var f = hits[0];
            var code = *(byte**)(f.Ptr + ScriptData);
            int num = *(ushort*)(f.Ptr + ScriptNum);
            var tail = string.Join(" ", Enumerable.Range(Math.Max(0, num - 8), Math.Min(8, num)).Select(i => code[i].ToString("X2")));
            Debug.Log($"Optional parameters: bytecode layout checked on {hits.Count} of {sample.Count} script functions "
                + $"({f.GetPathName()}: {num} bytes, ends {tail})");
            return true;
        }

        Debug.LogWarning(
            $"Optional parameters: bytecode not where expected (+{ScriptData}, WORD count at +{ScriptNum}) in "
                + $"{sample.Count - hits.Count} of {sample.Count} script functions; optional string/array arguments of script "
                + "functions keep the stock behaviour."
        );
        try
        {
            LogDiagnostics(sample);
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"Optional parameters: diagnostics failed ({ex.Message})");
        }
        return false;
    }

    // BmSDK-AO (2026-11-08): what found the WORD count above. Logged once per session if the check fails: which functions were sampled, every offset that holds a plausible
    // array (readable data, 0 < Num <= Max) whatever its last bytes, and the raw memory of the first functions.
    private const int DiagLast = 220;

    private static void LogDiagnostics(List<Function> sample)
    {
        var usable = sample.Where(f => IsReadable(f.Ptr, DiagLast + 12)).ToList();
        Debug.Log(
            $"Optional parameters (diagnostics): {usable.Count} of {sample.Count} functions readable up to +{DiagLast + 12}; sample: "
                + string.Join(", ", sample.Take(8).Select(f => $"{f.GetPathName()} flags 0x{(uint)f.FunctionFlags:X}"))
        );

        var arrays = new List<(int Offset, int Hits, string Example)>();
        for (var offset = 0; offset <= DiagLast; offset += 4)
        {
            var hits = 0;
            var example = "";
            foreach (var f in usable)
            {
                var code = *(byte**)(f.Ptr + offset);
                var num = *(int*)(f.Ptr + offset + IntPtr.Size);
                var max = *(int*)(f.Ptr + offset + 2 * IntPtr.Size);
                if (code == null || num <= 0 || num > 1 << 20 || max < num || max > 1 << 20 || !IsReadable((IntPtr)code, num))
                {
                    continue;
                }
                hits++;
                if (example.Length == 0)
                {
                    var tail = string.Join(" ", Enumerable.Range(Math.Max(0, num - 8), Math.Min(8, num)).Select(i => code[i].ToString("X2")));
                    example = $"{f.GetPathName()} num {num} max {max} last bytes {tail}";
                }
            }
            if (hits > 0)
            {
                arrays.Add((offset, hits, example));
            }
        }
        Debug.Log(
            arrays.Count == 0
                ? "Optional parameters (diagnostics): no plausible array at any offset"
                : "Optional parameters (diagnostics): plausible arrays: "
                    + string.Join("; ", arrays.OrderByDescending(a => a.Hits).Take(6).Select(a => $"+{a.Offset} in {a.Hits} ({a.Example})"))
        );

        foreach (var f in usable.Take(3))
        {
            var words = Enumerable.Range(0, (DiagLast + 12) / 4).Select(i => (*(uint*)(f.Ptr + i * 4)).ToString("X8"));
            Debug.Log($"Optional parameters (diagnostics): {f.GetPathName()} at 0x{f.Ptr:X}: {string.Join(" ", words)}");
        }
    }

    private sealed class Plan
    {
        public required Property[] Optional;
        public int Depth;
    }

    private static readonly ConditionalWeakTable<Function, Plan?> s_plans = [];

    /// <summary>
    /// Suspends the optional parameters of the script function <paramref name="func"/> for one
    /// call. Pass the result to <see cref="Resume"/> after the call.
    /// </summary>
    public static object? Suspend(Function func)
    {
        var plan = s_plans.GetValue(func, MakePlan);
        if (plan is null)
        {
            return null;
        }

        // A nested call of the same function (made while it runs) finds it already suspended.
        if (plan.Depth++ > 0)
        {
            return plan;
        }

        foreach (var prop in plan.Optional)
        {
            prop.PropertyFlags &= ~Property.EPropertyFlags.CPF_OptionalParm;
        }

        return plan;
    }

    public static void Resume(Function func, object? token)
    {
        if (token is not Plan plan || --plan.Depth > 0)
        {
            return;
        }

        foreach (var prop in plan.Optional)
        {
            prop.PropertyFlags |= Property.EPropertyFlags.CPF_OptionalParm;
        }
    }

    private static Plan? MakePlan(Function func)
    {
        if (func.FunctionFlags.HasFlag(Function.EFunctionFlags.FUNC_Native))
        {
            return null;
        }

        var optional = func.EnumerateParams()
            .Where(p => p.PropertyFlags.HasFlag(Property.EPropertyFlags.CPF_OptionalParm))
            .ToArray();
        if (optional.Length == 0)
        {
            return null;
        }

        // Walk the default-value block exactly as ProcessEvent's pass would: one entry per
        // optional parameter, either EX_Nothing or EX_DefaultParmValue <u16 size> <size bytes>.
        var code = ReadScript(func, out var length);
        if (s_layoutOk == false)
        {
            return null;
        }
        if (code is null || length <= 0)
        {
            return Reject(func, "no bytecode");
        }

        var pos = 0;
        var harmful = false;
        foreach (var prop in optional)
        {
            if (pos >= length)
            {
                return Reject(func, "default-value block runs past the bytecode");
            }

            if (code[pos] == EX_Nothing)
            {
                pos += 1;
            }
            else if (code[pos] == EX_DefaultParmValue && pos + 3 <= length)
            {
                pos += 3 + *(ushort*)(code + pos + 1);

                // Only a real default assigned over a value that owns memory frees anything.
                harmful |= OwnsMemory(prop);
            }
            else
            {
                return Reject(func, $"unexpected opcode 0x{code[pos]:X2} in default-value block");
            }
        }

        if (pos > length)
        {
            return Reject(func, "default-value block runs past the bytecode");
        }

        // Nothing would be freed: leave the call exactly as it was.
        return harmful ? new Plan { Optional = optional } : null;
    }

    /// <summary>
    /// Strings, arrays and maps own memory; a struct may hold one, so it counts too.
    /// </summary>
    private static bool OwnsMemory(Property prop) =>
        prop.Class.Name.ToString() is "StrProperty" or "ArrayProperty" or "MapProperty" or "StructProperty";

    private static Plan? Reject(Function func, string reason)
    {
        Debug.LogWarning(
            $"Optional parameters of {func.GetPathName()} left as is ({reason}); "
                + "optional string/array arguments may be freed before the call runs."
        );
        return null;
    }
}
