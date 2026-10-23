namespace BmSDK.Framework;

internal static partial class Loader
{
    private static GameFunctions.EngineTickDelegate? _BringUpTickDetourBase = null;
    private static int s_bringUpTicks = 0;

    /// <summary>
    /// Arkham Origins port, bring-up mode (GameDefine.SupportsFullRuntime is false).
    /// Skips class init, scripts and redirectors. Checks the address table against the live game:
    /// byte guards now (at PreInit), and a few side-effect-free engine calls once the engine runs.
    /// </summary>
    private static void BringUpMain()
    {
        Debug.Log("Bring-up mode (no scripts, no redirectors)");
        CheckGuards();

        _BringUpTickDetourBase = DetourUtil.NewDetour<GameFunctions.EngineTickDelegate>(
            GameDefine.Current.EngineTick,
            BringUpTickDetour
        );
        Debug.Log("EngineTick detour attached");
    }

    private static IntPtr BringUpTickDetour(IntPtr self)
    {
        var tick = ++s_bringUpTicks;
        if (tick == 1)
        {
            RunGuarded(() => Debug.Log($"EngineTick #1: {DescribeObjectTables()}"));
        }
        else if (tick == 600)
        {
            RunGuarded(() =>
            {
                Debug.Log($"EngineTick #600: {DescribeObjectTables()}");
                CheckEngineCalls();
            });
        }

        return _BringUpTickDetourBase!.Invoke(self);
    }

    private static unsafe void CheckGuards()
    {
        if (GameDefine.Current is not GameDefineAO)
        {
            return;
        }

        int ok = 0;
        foreach (var (name, rva, guard) in GameDefineAO.Guards)
        {
            var code = MemUtil.GetPointer<byte>(rva);
            var live = Convert.ToHexString(new ReadOnlySpan<byte>(code, guard.Length / 2)).ToLowerInvariant();
            if (live == guard || (name == "EngineLoopPreInit" && code[0] == 0xE9))
            {
                // PreInit is expected to be patched: BmSDK.Host detours it to start .NET
                ok++;
            }
            else if (code[0] == 0xE9)
            {
                Debug.LogWarning($"Guard {name} @0x{rva:X}: already hooked by another mod (jmp)");
            }
            else
            {
                Debug.LogError($"Guard {name} @0x{rva:X}: MISMATCH, live {live}");
            }
        }

        Debug.Log($"Guards: {ok}/{GameDefineAO.Guards.Length} match");
    }

    // Side-effect-free calls through the new table entries (game thread, engine running)
    private static unsafe void CheckEngineCalls()
    {
        // GError is a pointer to the error output device
        var gError = *MemUtil.GetPointer<IntPtr>(GameDefine.Current.GError);
        Debug.Log($"GError -> 0x{gError:X}");

        // FName::Init with FNAME_Find (0): looks the name up without adding it
        var name = new FName();
        fixed (char* text = "InitGame")
        {
            GameFunctions.NameInit((IntPtr)(&name), (IntPtr)text, 0, 0, 0);
        }
        var expected = FindNameIndex("InitGame");
        Debug.Log($"NameInit(InitGame, Find) -> {name.Index}; GNames scan -> {expected}: "
            + (name.Index == expected && expected > 0 ? "OK" : "FAIL"));

        // UClass::GetDefaultObject + UObject::FindFunction on Engine.GameInfo
        var gameInfoClass = FindObject("GameInfo", "Class");
        if (gameInfoClass == 0)
        {
            Debug.LogError("Class GameInfo not found in GObjObjects");
            return;
        }

        var cdo = GameFunctions.GetDefaultObject(gameInfoClass, 0);
        var cdoName = cdo == 0 ? "null" : NameOf(cdo);
        Debug.Log($"GetDefaultObject(GameInfo) -> 0x{cdo:X} '{cdoName}': "
            + (cdoName == "Default__GameInfo" ? "OK" : "FAIL"));
        if (cdo == 0)
        {
            return;
        }

        var func = GameFunctions.FindFunction(cdo, name, 0);
        var funcName = func == 0 ? "null" : NameOf(func);
        var funcClass = func == 0 ? "null" : NameOf(*(IntPtr*)(func + GameDefine.MemberOffsets.Object__Class));
        Debug.Log($"FindFunction(Default__GameInfo, InitGame) -> 0x{func:X} '{funcClass} {funcName}': "
            + (funcName == "InitGame" && funcClass == "Function" ? "OK" : "FAIL"));
    }

    // GNames and GObjObjects are TArrays: { Data, Num, Max }
    private static unsafe string DescribeObjectTables()
    {
        var names = MemUtil.GetPointer<int>(GameDefine.Current.GNames);
        var objects = MemUtil.GetPointer<int>(GameDefine.Current.GObjObjects);
        return $"GNames.Num={names[1]}, GObjObjects.Num={objects[1]}";
    }

    // AO's FNameEntry keeps the ANSI name at +12 (City: UTF-16 at +16)
    private static unsafe string? NameAt(int index)
    {
        var names = MemUtil.GetPointer<IntPtr>(GameDefine.Current.GNames);
        var data = (IntPtr*)names[0];
        var num = ((int*)names)[1];
        if (index < 0 || index >= num || data[index] == 0)
        {
            return null;
        }

        return Marshal.PtrToStringAnsi(data[index] + 12);
    }

    private static unsafe int FindNameIndex(string text)
    {
        var num = MemUtil.GetPointer<int>(GameDefine.Current.GNames)[1];
        for (var i = 0; i < num; i++)
        {
            if (NameAt(i) == text)
            {
                return i;
            }
        }

        return -1;
    }

    private static unsafe string NameOf(IntPtr obj) =>
        NameAt(*(int*)(obj + GameDefine.MemberOffsets.Object__Name)) ?? "?";

    private static unsafe IntPtr FindObject(string objName, string className)
    {
        var objects = MemUtil.GetPointer<IntPtr>(GameDefine.Current.GObjObjects);
        var data = (IntPtr*)objects[0];
        var num = ((int*)objects)[1];
        for (var i = 0; i < num; i++)
        {
            var obj = data[i];
            if (obj == 0 || NameOf(obj) != objName)
            {
                continue;
            }

            var cls = *(IntPtr*)(obj + GameDefine.MemberOffsets.Object__Class);
            if (cls != 0 && NameOf(cls) == className)
            {
                return obj;
            }
        }

        return 0;
    }
}
