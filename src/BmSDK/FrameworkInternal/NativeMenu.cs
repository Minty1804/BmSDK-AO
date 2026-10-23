using System.Runtime.InteropServices;

namespace BmSDK.Framework;

/// <summary>
/// Calls into the in-game options menu exported by BmSDK.Host.asi (Framework/options_menu.h, BmSDK-AO addition).
/// Every call is a no-op when the Host does not export the menu (an older Host).
/// </summary>
internal static unsafe partial class NativeMenu
{
    private const int ExpectedApiVersion = 3;

    public const int TypeBool = 0, TypeInt = 1, TypeFloat = 2, TypeChoice = 3, TypeColor = 4, TypeText = 5;
    public const int FlagAdvanced = 1;

    /// <summary>Same layout as BmSDK_MenuOptionDesc (options_menu.h): 56 bytes before the doubles.</summary>
    [StructLayout(LayoutKind.Sequential)]
    private struct OptionDesc
    {
        public byte* Tab, Section, Group, Label, Help, Choices, Format, Text, DefaultText;
        public int Type, Flags, ParentId, Reserved0, Reserved1;
        public double Min, Max, DefaultValue, Value;
    }

    /// <summary>What a mod's option looks like in the menu (strings already in the menu language).</summary>
    public sealed record OptionSpec(
        string Tab,
        string Section,
        string Group,
        string Label,
        string Help,
        string Choices,
        string Format,
        int Type,
        int Flags,
        int ParentId,
        double Min,
        double Max,
        double Default,
        double Value,
        string Text,
        string DefaultText
    );

    private static delegate* unmanaged[Cdecl]<int, int> s_install;
    private static delegate* unmanaged[Cdecl]<int, void> s_setKey;
    private static delegate* unmanaged[Cdecl]<OptionDesc*, int> s_addOptionEx;
    private static delegate* unmanaged[Cdecl]<byte*, void> s_removeTab;
    private static delegate* unmanaged[Cdecl]<uint> s_generation;
    private static delegate* unmanaged[Cdecl]<int, double> s_getValue;
    private static delegate* unmanaged[Cdecl]<int, double, void> s_setValue;
    private static delegate* unmanaged[Cdecl]<int, byte*, int, int> s_getText;
    private static delegate* unmanaged[Cdecl]<int, byte*, void> s_setText;
    private static delegate* unmanaged[Cdecl]<int, byte*, int, void> s_setStatus;
    private static delegate* unmanaged[Cdecl]<int, void> s_setShowStatus;
    private static delegate* unmanaged[Cdecl]<int*, double*, int, int> s_pollChanges;
    private static delegate* unmanaged[Cdecl]<int> s_activeOption;
    private static delegate* unmanaged[Cdecl]<int> s_isOpen;
    private static delegate* unmanaged[Cdecl]<int, byte*, void> s_setUiText;

    public static bool Available { get; private set; }

    [LibraryImport("kernel32.dll", EntryPoint = "GetModuleHandleW", StringMarshalling = StringMarshalling.Utf16)]
    private static partial IntPtr GetModuleHandle(string name);

    public static bool Init()
    {
        var host = GetModuleHandle("BmSDK.Host.asi");
        if (host == IntPtr.Zero || !NativeLibrary.TryGetExport(host, "BmSDK_Menu_ApiVersion", out var versionFn))
        {
            return false;
        }
        var version = ((delegate* unmanaged[Cdecl]<int>)versionFn)();
        if (version != ExpectedApiVersion)
        {
            Debug.LogWarning($"BmSDK.Host.asi menu API is v{version}, expected v{ExpectedApiVersion}: options menu off");
            return false;
        }

        IntPtr Get(string name) => NativeLibrary.GetExport(host, name);
        s_install = (delegate* unmanaged[Cdecl]<int, int>)Get("BmSDK_Menu_Install");
        s_setKey = (delegate* unmanaged[Cdecl]<int, void>)Get("BmSDK_Menu_SetKey");
        s_addOptionEx = (delegate* unmanaged[Cdecl]<OptionDesc*, int>)Get("BmSDK_Menu_AddOptionEx");
        s_removeTab = (delegate* unmanaged[Cdecl]<byte*, void>)Get("BmSDK_Menu_RemoveTab");
        s_generation = (delegate* unmanaged[Cdecl]<uint>)Get("BmSDK_Menu_Generation");
        s_getValue = (delegate* unmanaged[Cdecl]<int, double>)Get("BmSDK_Menu_GetValue");
        s_setValue = (delegate* unmanaged[Cdecl]<int, double, void>)Get("BmSDK_Menu_SetValue");
        s_getText = (delegate* unmanaged[Cdecl]<int, byte*, int, int>)Get("BmSDK_Menu_GetText");
        s_setText = (delegate* unmanaged[Cdecl]<int, byte*, void>)Get("BmSDK_Menu_SetText");
        s_setStatus = (delegate* unmanaged[Cdecl]<int, byte*, int, void>)Get("BmSDK_Menu_SetStatus");
        s_setShowStatus = (delegate* unmanaged[Cdecl]<int, void>)Get("BmSDK_Menu_SetShowStatus");
        s_pollChanges = (delegate* unmanaged[Cdecl]<int*, double*, int, int>)Get("BmSDK_Menu_PollChanges");
        s_activeOption = (delegate* unmanaged[Cdecl]<int>)Get("BmSDK_Menu_ActiveOption");
        s_isOpen = (delegate* unmanaged[Cdecl]<int>)Get("BmSDK_Menu_IsOpen");
        s_setUiText = (delegate* unmanaged[Cdecl]<int, byte*, void>)Get("BmSDK_Menu_SetUiText");
        Available = true;
        return true;
    }

    public static bool Install(int keyVk) => Available && s_install(keyVk) != 0;

    public static void SetKey(int keyVk)
    {
        if (Available)
        {
            s_setKey(keyVk);
        }
    }

    public static int AddOption(OptionSpec o)
    {
        if (!Available)
        {
            return 0;
        }
        var strings = new[] { o.Tab, o.Section, o.Group, o.Label, o.Help, o.Choices, o.Format, o.Text, o.DefaultText };
        var ptrs = strings.Select(Utf8).ToArray();
        try
        {
            var d = new OptionDesc
            {
                Tab = (byte*)ptrs[0],
                Section = (byte*)ptrs[1],
                Group = (byte*)ptrs[2],
                Label = (byte*)ptrs[3],
                Help = (byte*)ptrs[4],
                Choices = (byte*)ptrs[5],
                Format = (byte*)ptrs[6],
                Text = (byte*)ptrs[7],
                DefaultText = (byte*)ptrs[8],
                Type = o.Type,
                Flags = o.Flags,
                ParentId = o.ParentId,
                Min = o.Min,
                Max = o.Max,
                DefaultValue = o.Default,
                Value = o.Value,
            };
            return s_addOptionEx(&d);
        }
        finally
        {
            foreach (var p in ptrs)
            {
                Marshal.FreeCoTaskMem(p);
            }
        }
    }

    public static void RemoveTab(string tab) => WithUtf8(tab, t => s_removeTab(t));

    public static uint Generation() => Available ? s_generation() : 0;

    /// <summary>Options the user changed since the last call (id, latest value), each once.</summary>
    public static int PollChanges(Span<int> ids, Span<double> values)
    {
        if (!Available)
        {
            return 0;
        }
        fixed (int* i = ids)
        fixed (double* v = values)
        {
            return s_pollChanges(i, v, Math.Min(ids.Length, values.Length));
        }
    }

    /// <summary>Id of the option whose slider is being dragged, 0 if none.</summary>
    public static int ActiveOption() => Available ? s_activeOption() : 0;

    public static bool IsOpen() => Available && s_isOpen() != 0;

    public static double GetValue(int id) => Available ? s_getValue(id) : double.NaN;

    public static void SetValue(int id, double value)
    {
        if (Available)
        {
            s_setValue(id, value);
        }
    }

    public static string GetText(int id)
    {
        if (!Available)
        {
            return "";
        }
        var buffer = stackalloc byte[1024];
        var n = s_getText(id, buffer, 1024);
        return n <= 0 ? "" : Marshal.PtrToStringUTF8((IntPtr)buffer) ?? "";
    }

    public static void SetText(int id, string text) => WithUtf8(text, t => s_setText(id, t));

    public static void SetStatus(int id, string text, int state) => WithUtf8(text, t => s_setStatus(id, t, state));

    public static void SetShowStatus(bool show)
    {
        if (Available)
        {
            s_setShowStatus(show ? 1 : 0);
        }
    }

    /// <summary>The menu's own texts: 0 footer, 1 reset button, 2 "no options", 3 "Advanced".</summary>
    public static void SetUiText(int which, string text) => WithUtf8(text, t => s_setUiText(which, t));

    private delegate void Utf8Action(byte* text);

    private static void WithUtf8(string text, Utf8Action action)
    {
        if (!Available)
        {
            return;
        }
        var t = Utf8(text);
        try
        {
            action((byte*)t);
        }
        finally
        {
            Marshal.FreeCoTaskMem(t);
        }
    }

    private static IntPtr Utf8(string s) => Marshal.StringToCoTaskMemUTF8(s ?? "");
}
