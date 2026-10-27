using System.Reflection;
using System.Runtime.InteropServices;

namespace BmSDK.Framework;

/// <summary>
/// BmSDK-AO addition: tells BmSDK.Host.asi which script or redirect is running, so its crash log (crash_log.cpp)
/// can name it next to a native crash. Writes one pointer into a slot the host exports; the UTF-8 labels are made
/// once per script method or redirect and never freed. Does nothing when the host has no crash log.
/// </summary>
internal static unsafe partial class CrashContext
{
    // [0] running now, [1] last started
    private static IntPtr* s_slot;

    private static readonly Dictionary<(string, MethodInfo), IntPtr> s_labels = [];
    private static readonly object s_lock = new();

    [LibraryImport("kernel32.dll", EntryPoint = "GetModuleHandleW", StringMarshalling = StringMarshalling.Utf16)]
    private static partial IntPtr GetModuleHandle(string name);

    public static void Init()
    {
        var host = GetModuleHandle("BmSDK.Host.asi");
        if (host != IntPtr.Zero && NativeLibrary.TryGetExport(host, "BmSDK_Crash_ContextSlot", out var fn))
        {
            s_slot = ((delegate* unmanaged[Cdecl]<IntPtr*>)fn)();
        }
    }

    /// <summary>Marks <paramref name="method"/> of <paramref name="owner"/> as running. Pass the result to <see cref="Leave"/>.</summary>
    public static IntPtr Enter(string owner, MethodInfo method)
    {
        if (s_slot == null)
        {
            return IntPtr.Zero;
        }
        var label = Label(owner, method);
        var prev = s_slot[0];
        s_slot[0] = label;
        s_slot[1] = label;
        return prev;
    }

    public static void Leave(IntPtr prev)
    {
        if (s_slot != null)
        {
            s_slot[0] = prev;
        }
    }

    private static IntPtr Label(string owner, MethodInfo method)
    {
        lock (s_lock)
        {
            if (!s_labels.TryGetValue((owner, method), out var p))
            {
                var type = method.DeclaringType?.FullName ?? "?";
                p = Marshal.StringToCoTaskMemUTF8($"{owner}: {type}.{method.Name}");
                s_labels[(owner, method)] = p;
            }
            return p;
        }
    }
}
