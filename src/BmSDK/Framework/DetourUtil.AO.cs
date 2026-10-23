using System.Globalization;
using System.Runtime.Loader;
using Windows.Win32;
using PInvokeDetours = Microsoft.Detours.PInvoke;

namespace BmSDK.Framework;

/// <summary>
/// BmSDK-AO addition: native hooks that mods can remove. A hook made by a mod with <see cref="Hook{T}"/> is removed
/// when the mod unloads or reloads (a changed .cs), so the game never calls into code that is gone.
/// Create and remove hooks on the game thread (Main, OnLoad, OnUnload...).
/// </summary>
public static partial class DetourUtil
{
    private static readonly List<NativeHook> s_hooks = [];

    /// <summary>A native function hooked with <see cref="Hook{T}"/>.</summary>
    public abstract class NativeHook : IDisposable
    {
        internal IntPtr Trampoline;
        internal Delegate Detour = null!;
        public IntPtr Offset { get; internal set; }
        public bool Active => Trampoline != IntPtr.Zero;

        /// <summary>Removes the hook. Safe to call more than once.</summary>
        public void Dispose() => Remove(this);
    }

    /// <summary>A hook whose <see cref="Original"/> calls the game's function.</summary>
    public sealed class NativeHook<T> : NativeHook
        where T : Delegate
    {
        public T Original { get; internal set; } = null!;
    }

    /// <summary>
    /// Hooks the game function at <paramref name="funcOffset"/> (offset from the exe base) with
    /// <paramref name="detour"/>. Keep the result: call <c>Original</c> inside the detour to run the game's code.
    /// </summary>
    public static unsafe NativeHook<T> Hook<T>(IntPtr funcOffset, T detour)
        where T : Delegate
    {
        void* target = MemUtil.GetPointer(funcOffset);
        void* managed = Marshal.GetFunctionPointerForDelegate(detour).ToPointer();
        Guard.Require(PInvokeDetours.DetourTransactionBegin() == 0);
        Guard.Require(PInvokeDetours.DetourUpdateThread(PInvoke.GetCurrentThread()) == 0);
        var attach = PInvokeDetours.DetourAttach(&target, managed);
        if (attach != 0)
        {
            PInvokeDetours.DetourTransactionAbort();
            throw new InvalidOperationException($"DetourAttach failed at +0x{funcOffset:X} (error {attach})");
        }
        Guard.Require(PInvokeDetours.DetourTransactionCommit() == 0);

        var hook = new NativeHook<T>
        {
            Offset = funcOffset,
            Trampoline = (IntPtr)target,
            Detour = detour, // also keeps the delegate alive
            Original = Marshal.GetDelegateForFunctionPointer<T>((IntPtr)target),
        };
        s_hooks.Add(hook);
        return hook;
    }

    /// <summary>
    /// True if the code at <paramref name="offset"/> starts with <paramref name="hex"/> ("83ec28 55 8b6c2430",
    /// spaces ignored, "??" matches any byte). Check it before hooking: another game build moves the functions.
    /// </summary>
    public static unsafe bool BytesMatch(IntPtr offset, string hex)
    {
        hex = hex.Replace(" ", "");
        var p = (byte*)MemUtil.GetPointer(offset);
        for (var i = 0; i + 1 < hex.Length; i += 2)
        {
            var pair = hex.AsSpan(i, 2);
            if (pair is "??")
            {
                continue;
            }
            if (!byte.TryParse(pair, NumberStyles.HexNumber, null, out var want) || p[i / 2] != want)
            {
                return false;
            }
        }
        return true;
    }

    private static unsafe void Remove(NativeHook hook)
    {
        if (!hook.Active)
        {
            return;
        }
        void* trampoline = hook.Trampoline.ToPointer();
        void* managed = Marshal.GetFunctionPointerForDelegate(hook.Detour).ToPointer();
        var ok =
            PInvokeDetours.DetourTransactionBegin() == 0
            && PInvokeDetours.DetourUpdateThread(PInvoke.GetCurrentThread()) == 0
            && PInvokeDetours.DetourDetach(&trampoline, managed) == 0;
        if (!ok)
        {
            PInvokeDetours.DetourTransactionAbort();
            Debug.LogWarning($"Could not remove the hook at +0x{hook.Offset:X}");
            return;
        }
        Guard.Require(PInvokeDetours.DetourTransactionCommit() == 0);
        hook.Trampoline = IntPtr.Zero;
        s_hooks.Remove(hook);
    }

    /// <summary>Removes the hooks whose detour lives in a mod's assembly (it is unloading).</summary>
    internal static void RemoveHooksOf(AssemblyLoadContext alc)
    {
        foreach (var hook in s_hooks.ToList())
        {
            var asm = hook.Detour.Method.DeclaringType?.Assembly;
            if (asm != null && AssemblyLoadContext.GetLoadContext(asm) == alc)
            {
                Remove(hook);
                Debug.Log($"Removed native hook at +0x{hook.Offset:X} (mod unloaded)");
            }
        }
    }
}
