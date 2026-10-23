using System.Globalization;
using System.Reflection;
using System.Text;
using BmSDK.Engine;
using Tomlyn.Model;

namespace BmSDK.Framework;

/// <summary>
/// Options declared with <see cref="OptionAttribute"/> (BmSDK-AO addition): loads and saves each mod's
/// <c>options.ini</c>, fills the in-game menu (<see cref="NativeMenu"/>, one tab per mod) and applies the user's
/// changes to the mod's static members on the game thread, then calls <see cref="Script.OnOptionChanged"/>.
/// BmSDK's own settings (menu key, language, status lines) are a tab of their own, saved in
/// <c>Binaries\Win32\BmSDK.ini</c>.
/// </summary>
/// <remarks>
/// Menu changes are polled from the engine tick, which also runs while the game is paused: they apply and are
/// saved there too (the game tick stops in the pause menu).
/// </remarks>
internal static class OptionsManager
{
    private const string IniFileName = "options.ini";
    private const string SettingsFileName = "BmSDK.ini";
    private const string SdkTab = "BmSDK";
    private static readonly TimeSpan SaveDelay = TimeSpan.FromMilliseconds(400); // a slider drag is one save
    private static readonly TimeSpan InstallDelay = TimeSpan.FromSeconds(1);

    // While a slider is dragged its member follows every frame, but OnOptionChanged runs at most this often (a mod
    // may do real work there); it runs once more with the final value on release.
    private static readonly TimeSpan DragNotifyInterval = TimeSpan.FromMilliseconds(100);

    private enum Kind
    {
        Bool,
        Int,
        Float,
        Double,
        Choice,
        Color,
        Text,
    }

    private sealed class Entry(MemberInfo member, Type type, OptionAttribute attr, Kind kind)
    {
        public MemberInfo Member { get; } = member;
        public Type Type { get; } = type;
        public OptionAttribute Attr { get; } = attr;
        public Kind Kind { get; } = kind;
        public Array? EnumValues { get; init; } // enum choices, in declaration order
        public double Default { get; set; }
        public string DefaultText { get; set; } = "";
        public int Id { get; set; }
        public double Last { get; set; } // value last seen in the member and the menu
        public string LastText { get; set; } = "";
        public string Name => Member.Name;
        public ModOptions? Owner { get; set; }
        public bool NotifyPending { get; set; }
        public DateTime LastNotify { get; set; } = DateTime.MinValue;
        public string StatusText { get; set; } = "";
        public OptionStatus Status { get; set; }
    }

    private sealed class ModOptions(Mod mod, string iniPath, List<Entry> entries, List<Script> scripts)
    {
        public Mod Mod { get; } = mod;
        public string IniPath { get; } = iniPath;
        public List<Entry> Entries { get; } = entries;
        public List<Script> Scripts { get; } = scripts;
        public DateTime SaveAt { get; set; } = DateTime.MaxValue;
        public Action<string>? OnChanged { get; init; } // BmSDK's own settings

        // Options changed in the menu since the last save, logged once with their final value (a slider drag
        // changes the value every frame)
        public HashSet<Entry> MenuChanges { get; } = [];
    }

    /// <summary>BmSDK's own settings: tab "BmSDK", saved in Binaries\Win32\BmSDK.ini.</summary>
    private static class SdkSettings
    {
        public enum MenuLanguage
        {
            Auto,
            English,
            Spanish,
        }

        [Option(
            "Menu language",
            LabelEs = "Idioma del menú",
            Choices = ["Auto", "English", "Español"],
            ChoiceHelp = ["The language of Windows (Spanish or English).", "", ""],
            ChoiceHelpEs = ["El idioma de Windows (español o inglés).", "", ""]
        )]
        public static MenuLanguage Language = MenuLanguage.Auto;

        [Option(
            "Show option status",
            LabelEs = "Mostrar el estado de cada opción",
            Help = "A line under each option that says what it is doing (for testing). Problems always show.",
            HelpEs = "Una línea bajo cada opción que dice qué está haciendo (para pruebas). Los problemas se ven siempre."
        )]
        public static bool ShowStatus = false;

        [Option(
            "Menu key",
            LabelEs = "Tecla del menú",
            Advanced = true,
            Help = "A key name (F10, Insert, Home, Scroll...) or Auto: F10, or Insert while Ultimate UI AO is installed as an .asi.",
            HelpEs = "Un nombre de tecla (F10, Insert, Home, Scroll...) o Auto: F10, o Insert si Ultimate UI AO está instalado como .asi."
        )]
        public static string Key = "Auto";
    }

    private static readonly Dictionary<string, ModOptions> s_mods = new(StringComparer.OrdinalIgnoreCase);
    private static readonly Dictionary<int, Entry> s_byId = [];
    private static readonly List<Entry> s_pending = [];
    private static ModOptions[] s_modList = []; // s_mods.Values, rebuilt when a mod comes or goes
    private static readonly int[] s_pollIds = new int[64];
    private static readonly double[] s_pollValues = new double[64];
    private static bool s_nativeTried;
    private static uint s_lastGeneration;
    private static DateTime s_firstGameTick = DateTime.MinValue;
    private static bool s_installStarted;
    private static volatile int s_installResult = -1; // set by the install worker, logged on the game thread
    private static Keys s_key = Keys.F10;
    private static bool s_inputHeld;
    private static PlayerController? s_heldController;

    /// <summary>"en" or "es".</summary>
    public static string Language { get; private set; } = "en";

    private static bool Es => Language == "es";

    /// <summary>Reads a mod's options, applies its ini and adds its tab to the menu. Game thread.</summary>
    public static void RegisterMod(Mod mod, Assembly asm, List<Script> scripts)
    {
        EnsureNative();
        var entries = FindOptions(asm.GetTypes(), mod.Name);
        if (entries.Count > 0)
        {
            Register(new ModOptions(mod, Path.Combine(mod.DirectoryPath, IniFileName), entries, scripts));
        }
    }

    private static void Register(ModOptions options)
    {
        options.Entries.ForEach(e => e.Owner = options);
        ApplyIni(options.Entries, ReadIni(options.IniPath), options.Mod.Name, Path.GetFileName(options.IniPath));
        if (!File.Exists(options.IniPath))
        {
            Save(options);
        }
        s_mods[options.IniPath] = options;
        s_modList = [.. s_mods.Values];
        AddTab(options);
        Debug.Log($"[{options.Mod.Name}] {options.Entries.Count} option(s) from .\\{Path.GetRelativePath(FileUtils.GetBasePath(), options.IniPath)}");
    }

    private static void ApplyIni(List<Entry> entries, Dictionary<string, string> ini, string modName, string fileName)
    {
        foreach (var e in entries)
        {
            if (ini.TryGetValue(e.Name, out var text))
            {
                try
                {
                    if (e.Kind == Kind.Text)
                    {
                        SetMemberText(e, text);
                    }
                    else if (TryParse(text, e, out var value))
                    {
                        SetMember(e, value);
                    }
                    else
                    {
                        Debug.LogWarning($"[{modName}] {fileName}: bad value {e.Name}={text}, default kept");
                    }
                }
                catch (Exception ex)
                {
                    // A bad value must not stop the mod from loading: keep the default
                    Debug.LogWarning($"[{modName}] {fileName}: could not apply {e.Name}={text}: {ex.Message}");
                }
            }
            e.Last = GetMember(e);
            e.LastText = e.Kind == Kind.Text ? GetMemberText(e) : "";
        }
    }

    /// <summary>Saves pending changes and removes the mod's tab. Game thread.</summary>
    public static void UnregisterMod(Mod mod)
    {
        var options = s_modList.FirstOrDefault(o => o.Mod == mod);
        if (options == null)
        {
            return;
        }
        s_mods.Remove(options.IniPath);
        s_modList = [.. s_mods.Values];
        if (options.SaveAt != DateTime.MaxValue)
        {
            Save(options);
        }
        RemoveTab(options);
    }

    public static void SetStatus(Mod mod, string memberName, string text, OptionStatus status)
    {
        var options = s_modList.FirstOrDefault(o => o.Mod == mod);
        var e = options?.Entries.FirstOrDefault(x => x.Name == memberName);
        if (e == null || (e.StatusText == text && e.Status == status))
        {
            return;
        }
        e.StatusText = text;
        e.Status = status;
        if (e.Id != 0)
        {
            NativeMenu.SetStatus(e.Id, text, (int)status);
        }
    }

    // ---- menu tabs ----

    private static string TabName(ModOptions options) => options.OnChanged != null ? SdkTab : options.Mod.Name;

    private static void AddTab(ModOptions options)
    {
        var tab = TabName(options);
        var ids = new Dictionary<string, int>();
        foreach (var e in options.Entries)
        {
            e.Id = 0;
            if (e.Attr.Hidden)
            {
                continue;
            }
            var parent = e.Attr.DependsOn != null && ids.TryGetValue(e.Attr.DependsOn, out var p) ? p : 0;
            e.Id = NativeMenu.AddOption(Spec(e, tab, parent));
            if (e.Id == 0)
            {
                continue;
            }
            ids[e.Name] = e.Id;
            s_byId[e.Id] = e;
            if (e.StatusText.Length > 0)
            {
                NativeMenu.SetStatus(e.Id, e.StatusText, (int)e.Status);
            }
        }
    }

    private static void RemoveTab(ModOptions options)
    {
        foreach (var e in options.Entries)
        {
            s_byId.Remove(e.Id);
            e.Id = 0;
        }
        s_pending.RemoveAll(e => e.Owner == options);
        NativeMenu.RemoveTab(TabName(options));
    }

    // Every tab again, in the current language
    private static void RebuildMenu()
    {
        foreach (var options in s_modList)
        {
            RemoveTab(options);
        }
        foreach (var options in s_modList)
        {
            AddTab(options);
        }
        SetUiTexts();
    }

    private static string L(string en, string? es) => Es && !string.IsNullOrEmpty(es) ? es : en;

    private static NativeMenu.OptionSpec Spec(Entry e, string tab, int parentId)
    {
        var a = e.Attr;
        var type = e.Kind switch
        {
            Kind.Bool => NativeMenu.TypeBool,
            Kind.Int => NativeMenu.TypeInt,
            Kind.Float or Kind.Double => NativeMenu.TypeFloat,
            Kind.Choice => NativeMenu.TypeChoice,
            Kind.Color => NativeMenu.TypeColor,
            _ => NativeMenu.TypeText,
        };
        var choices = ChoiceNames(e);
        var help = (Es ? a.ChoiceHelpEs : null) ?? a.ChoiceHelp ?? [];
        var choiceText = string.Join(
            "\n",
            choices.Select((c, i) => i < help.Length && !string.IsNullOrEmpty(help[i]) ? $"{c}\t{help[i]}" : c)
        );
        var (min, max) = e.Kind == Kind.Choice ? (0, choices.Length - 1) : (a.Min, a.Max);
        return new NativeMenu.OptionSpec(
            tab,
            L(a.Section ?? "", a.SectionEs),
            L(a.Group ?? "", a.GroupEs),
            L(a.Label, a.LabelEs),
            L(a.Help ?? "", a.HelpEs),
            choiceText,
            a.Format ?? "",
            type,
            a.Advanced ? NativeMenu.FlagAdvanced : 0,
            parentId,
            min,
            max,
            e.Default,
            e.Last,
            e.LastText,
            e.DefaultText
        );
    }

    private static string[] ChoiceNames(Entry e)
    {
        if (e.Kind != Kind.Choice)
        {
            return [];
        }
        var names = (Es ? e.Attr.ChoicesEs : null) ?? e.Attr.Choices;
        if (names != null)
        {
            return names;
        }
        return e.EnumValues != null ? [.. e.EnumValues.Cast<object>().Select(v => v.ToString()!)] : [];
    }

    private static void SetUiTexts()
    {
        NativeMenu.SetUiText(
            0,
            Es
                ? $"{s_key}: abrir/cerrar  |  se guarda en el {IniFileName} de cada mod"
                : $"{s_key}: open/close  |  saved in each mod's {IniFileName}"
        );
        NativeMenu.SetUiText(1, Es ? "Valores por defecto" : "Reset to defaults");
        NativeMenu.SetUiText(2, Es ? "Ningún mod cargado tiene opciones." : "No loaded mod declares options.");
        NativeMenu.SetUiText(3, Es ? "Avanzado" : "Advanced");
    }

    // ---- ticks ----

    /// <summary>Called on every game tick (RGameInfo.Tick): only notes that the game is running.</summary>
    public static void Tick()
    {
        if (s_firstGameTick == DateTime.MinValue)
        {
            s_firstGameTick = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Called on every engine tick, also while the game is paused. Cheap when nothing changed: a few native calls
    /// plus a read of each member.
    /// </summary>
    public static void EngineTick()
    {
        EnsureNative();
        if (!NativeMenu.Available)
        {
            return;
        }
        var now = DateTime.UtcNow;
        InstallWhenReady(now);
        HoldInput();

        // Values changed in the menu: only those options, not the whole table
        var generation = NativeMenu.Generation();
        if (generation != s_lastGeneration)
        {
            s_lastGeneration = generation;
            int n;
            do
            {
                n = NativeMenu.PollChanges(s_pollIds, s_pollValues);
                for (var i = 0; i < n; i++)
                {
                    if (s_byId.TryGetValue(s_pollIds[i], out var e))
                    {
                        ApplyFromMenu(e, s_pollValues[i], now);
                    }
                }
            } while (n == s_pollIds.Length);
        }
        NotifyPending(now);

        foreach (var options in s_modList)
        {
            // Changed by the mod's own code: the menu and the ini follow
            foreach (var e in options.Entries)
            {
                if (e.Kind == Kind.Text)
                {
                    var text = GetMemberText(e);
                    if (text != e.LastText)
                    {
                        e.LastText = text;
                        NativeMenu.SetText(e.Id, text);
                        options.SaveAt = now + SaveDelay;
                    }
                    continue;
                }
                var current = GetMember(e);
                if (current != e.Last)
                {
                    e.Last = current;
                    NativeMenu.SetValue(e.Id, current);
                    options.SaveAt = now + SaveDelay;
                }
            }
            if (now >= options.SaveAt)
            {
                Save(options);
            }
        }
    }

    private static void ApplyFromMenu(Entry e, double value, DateTime now)
    {
        if (e.Kind == Kind.Text)
        {
            var text = NativeMenu.GetText(e.Id);
            if (text == e.LastText)
            {
                return;
            }
            SetMemberText(e, text);
            e.LastText = GetMemberText(e);
        }
        else
        {
            if (value == e.Last)
            {
                return;
            }
            SetMember(e, value);
            e.Last = GetMember(e);
        }
        e.Owner!.MenuChanges.Add(e);
        e.Owner.SaveAt = now + SaveDelay;
        if (!e.NotifyPending)
        {
            e.NotifyPending = true;
            s_pending.Add(e);
        }
    }

    // OnOptionChanged: right away for a click, at most every DragNotifyInterval while a slider is held, and once
    // more when it is released.
    private static void NotifyPending(DateTime now)
    {
        if (s_pending.Count == 0)
        {
            return;
        }
        var active = NativeMenu.ActiveOption();
        List<Entry>? due = null;
        for (var i = s_pending.Count - 1; i >= 0; i--)
        {
            var e = s_pending[i];
            if (e.Id == active && now - e.LastNotify < DragNotifyInterval)
            {
                continue;
            }
            s_pending.RemoveAt(i);
            e.NotifyPending = false;
            e.LastNotify = now;
            (due ??= []).Add(e);
        }
        // Called after the loop: a callback may rebuild the menu (language), which edits s_pending
        foreach (var e in due ?? [])
        {
            if (e.Owner!.OnChanged != null)
            {
                e.Owner.OnChanged(e.Name);
                continue;
            }
            foreach (var script in e.Owner.Scripts)
            {
                // A mod's error here is logged, not fatal: a click in the menu should not close the game
                Debug.RunWithSender(
                    script.Name,
                    () =>
                    {
                        try
                        {
                            script.OnOptionChanged(e.Name);
                        }
                        catch (Exception ex)
                        {
                            Debug.LogError($"OnOptionChanged({e.Name}): {ex}");
                        }
                    }
                );
            }
        }
    }

    // While the menu is open the camera and Batman stay still: the game may read the mouse outside window messages.
    // bIgnoreLookInput/bIgnoreMoveInput are counters (IgnoreLookInput(true) adds 1): the menu adds its own 1 and
    // takes it back on close. Restoring a saved value instead would undo what the game did meanwhile (Ultimate UI
    // AO, LIVE 2026-10-20: Batman stuck after a cinematic that ended with the menu open).
    private static void HoldInput()
    {
        var open = NativeMenu.IsOpen();
        if (open == s_inputHeld)
        {
            return;
        }
        s_inputHeld = open;
        try
        {
            if (open)
            {
                var pc = Game.GetPlayerController();
                if (pc.bIgnoreLookInput < 255)
                {
                    pc.bIgnoreLookInput++;
                }
                if (pc.bIgnoreMoveInput < 255)
                {
                    pc.bIgnoreMoveInput++;
                }
                s_heldController = pc;
            }
            else if (s_heldController is { IsValid: true } pc)
            {
                if (pc.bIgnoreLookInput > 0)
                {
                    pc.bIgnoreLookInput--;
                }
                if (pc.bIgnoreMoveInput > 0)
                {
                    pc.bIgnoreMoveInput--;
                }
                s_heldController = null;
            }
        }
        catch (Exception)
        {
            // no player controller (main menu, loading): nothing to hold
            s_heldController = null;
        }
    }

    private static void EnsureNative()
    {
        if (s_nativeTried)
        {
            return;
        }
        s_nativeTried = true;
        if (!NativeMenu.Init())
        {
            Debug.LogWarning("BmSDK.Host.asi has no options menu: options still load and save from each options.ini");
            return;
        }

        // BmSDK's own tab. Its ini is read first, so the menu comes up in the right language with the right key.
        var binaries = FileUtils.GetBinariesPath();
        var path = Path.Combine(binaries, SettingsFileName);
        var entries = FindOptions([typeof(SdkSettings)], SdkTab);
        ApplyIni(entries, ReadIni(path), SdkTab, SettingsFileName);
        ApplyLanguage();
        s_key = ReadMenuKey();
        NativeMenu.SetShowStatus(SdkSettings.ShowStatus);
        SetUiTexts();
        Register(new ModOptions(new Mod(SdkTab, binaries, new TomlTable()), path, entries, []) { OnChanged = OnSdkSettingChanged });
    }

    private static void OnSdkSettingChanged(string name)
    {
        switch (name)
        {
            case nameof(SdkSettings.Language):
                ApplyLanguage();
                RebuildMenu();
                break;
            case nameof(SdkSettings.ShowStatus):
                NativeMenu.SetShowStatus(SdkSettings.ShowStatus);
                break;
            case nameof(SdkSettings.Key):
                s_key = ReadMenuKey();
                NativeMenu.SetKey((int)s_key);
                SetUiTexts();
                Debug.Log($"Menu key: {s_key}");
                break;
        }
    }

    private static void ApplyLanguage()
    {
        Language = SdkSettings.Language switch
        {
            SdkSettings.MenuLanguage.English => "en",
            SdkSettings.MenuLanguage.Spanish => "es",
            _ => CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "es" ? "es" : "en",
        };
    }

    private static void InstallWhenReady(DateTime now)
    {
        // The dummy D3D11 device that finds Present must not be created during start-up (crashes with ReShade,
        // Ultimate UI AO RE_NOTES.md): only once the game ticks. Created off the game thread so it does not hitch.
        if (!s_installStarted && s_firstGameTick != DateTime.MinValue && now - s_firstGameTick >= InstallDelay)
        {
            s_installStarted = true;
            var vk = (int)s_key;
            Task.Run(() => s_installResult = NativeMenu.Install(vk) ? 1 : 0);
        }
        if (s_installResult >= 0)
        {
            Debug.Log(
                s_installResult == 1
                    ? $"Options menu ready ({s_key}, language {Language})"
                    : "Options menu could not hook DX11: see BmSDK.Host.log"
            );
            s_installResult = -2;
        }
    }

    // ---- menu key ----

    private static Keys ReadMenuKey()
    {
        var text = SdkSettings.Key.Trim();
        if (!text.Equals("Auto", StringComparison.OrdinalIgnoreCase) && text.Length > 0)
        {
            if (System.Enum.TryParse<Keys>(text, ignoreCase: true, out var key) && (int)key is > 0 and < 256)
            {
                return key;
            }
            Debug.LogWarning($"{SettingsFileName}: unknown menu key '{text}', using Auto");
        }
        return NativeModuleLoaded("UltimateUI.asi") ? Keys.Insert : Keys.F10;
    }

    private static bool NativeModuleLoaded(string name) =>
        System.Diagnostics.Process.GetCurrentProcess().Modules.Cast<System.Diagnostics.ProcessModule>()
            .Any(m => m.ModuleName.Equals(name, StringComparison.OrdinalIgnoreCase));

    // ---- reflection ----

    private static List<Entry> FindOptions(IEnumerable<Type> types, string modName)
    {
        const BindingFlags flags = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly;
        var entries = new List<Entry>();
        foreach (var type in types)
        {
            // Declaration order (fields, then properties)
            foreach (var member in type.GetMembers(flags).OrderBy(m => m.MetadataToken))
            {
                var attr = member.GetCustomAttribute<OptionAttribute>();
                if (attr == null)
                {
                    continue;
                }
                var valueType = member switch
                {
                    FieldInfo f when !f.IsInitOnly && !f.IsLiteral => f.FieldType,
                    PropertyInfo p when p.CanRead && p.CanWrite => p.PropertyType,
                    _ => null,
                };
                Kind? kind = valueType switch
                {
                    null => null,
                    _ when valueType == typeof(bool) => Kind.Bool,
                    _ when valueType == typeof(int) && attr.Color => Kind.Color,
                    _ when valueType == typeof(int) && attr.Choices != null => Kind.Choice,
                    _ when valueType == typeof(int) => Kind.Int,
                    _ when valueType == typeof(float) => Kind.Float,
                    _ when valueType == typeof(double) => Kind.Double,
                    _ when valueType.IsEnum => Kind.Choice,
                    _ when valueType == typeof(string) => Kind.Text,
                    _ => null,
                };
                if (kind == null)
                {
                    Debug.LogWarning(
                        $"[{modName}] [Option] {type.Name}.{member.Name}: needs a writable static bool, int, float, double, enum or string"
                    );
                    continue;
                }
                var e = new Entry(member, valueType!, attr, kind.Value)
                {
                    EnumValues = valueType!.IsEnum ? System.Enum.GetValues(valueType) : null,
                };
                e.Default = GetMember(e);
                e.Last = e.Default;
                e.DefaultText = kind == Kind.Text ? GetMemberText(e) : "";
                e.LastText = e.DefaultText;
                entries.Add(e);
            }
        }
        return entries;
    }

    private static object? GetRaw(Entry e) =>
        e.Member is FieldInfo f ? f.GetValue(null) : ((PropertyInfo)e.Member).GetValue(null);

    private static void SetRaw(Entry e, object? value)
    {
        if (e.Member is FieldInfo f)
        {
            f.SetValue(null, value);
        }
        else
        {
            ((PropertyInfo)e.Member).SetValue(null, value);
        }
    }

    private static double GetMember(Entry e)
    {
        var value = GetRaw(e);
        if (e.EnumValues != null && value != null)
        {
            return Array.IndexOf(e.EnumValues, value);
        }
        return value switch
        {
            bool b => b ? 1 : 0,
            int i => i,
            float fl => fl,
            double d => d,
            _ => 0,
        };
    }

    private static string GetMemberText(Entry e) => GetRaw(e) as string ?? "";

    private static void SetMemberText(Entry e, string text) => SetRaw(e, text);

    private static void SetMember(Entry e, double v)
    {
        if (e.Kind is Kind.Int or Kind.Float or Kind.Double)
        {
            v = Math.Clamp(v, Math.Min(e.Attr.Min, e.Attr.Max), Math.Max(e.Attr.Min, e.Attr.Max));
        }
        // Each value boxed with its own type: reflection does not convert double to float or int when setting it.
        object? value = e.Kind switch
        {
            Kind.Bool => v != 0,
            Kind.Float => (float)v,
            Kind.Double => v,
            Kind.Color => (int)((long)Math.Round(v) & 0xFFFFFF),
            Kind.Choice when e.EnumValues != null => e.EnumValues.GetValue(
                Math.Clamp((int)Math.Round(v), 0, e.EnumValues.Length - 1)
            ),
            Kind.Choice => Math.Clamp((int)Math.Round(v), 0, Math.Max(0, ChoiceCount(e) - 1)),
            _ => (int)Math.Round(v),
        };
        SetRaw(e, value);
    }

    private static int ChoiceCount(Entry e) => e.EnumValues?.Length ?? e.Attr.Choices?.Length ?? 0;

    // ---- ini ----

    private static Dictionary<string, string> ReadIni(string path)
    {
        var values = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        if (!File.Exists(path))
        {
            return values;
        }
        foreach (var raw in File.ReadAllLines(path))
        {
            var line = raw.Trim();
            if (line.Length == 0 || line[0] is ';' or '#' or '[')
            {
                continue;
            }
            var eq = line.IndexOf('=');
            if (eq > 0)
            {
                values[line[..eq].Trim()] = line[(eq + 1)..].Trim();
            }
        }
        return values;
    }

    private static bool TryParse(string text, Entry e, out double value)
    {
        switch (e.Kind)
        {
            case Kind.Bool:
                var ok = text is "1" or "0" || bool.TryParse(text, out _);
                value = text == "1" || (bool.TryParse(text, out var b) && b) ? 1 : 0;
                return ok;
            case Kind.Color:
                var parsed = int.TryParse(text.TrimStart('#'), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var rgb);
                value = rgb;
                return parsed;
            case Kind.Choice when e.EnumValues != null:
                if (System.Enum.TryParse(e.Type, text, ignoreCase: true, out var enumValue))
                {
                    value = Array.IndexOf(e.EnumValues, enumValue);
                    return value >= 0;
                }
                break;
        }
        return double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out value);
    }

    private static string Format(Entry e, double v) =>
        e.Kind switch
        {
            Kind.Bool => v != 0 ? "true" : "false",
            Kind.Color => ((int)v & 0xFFFFFF).ToString("X6", CultureInfo.InvariantCulture),
            Kind.Choice when e.EnumValues != null && v >= 0 && v < e.EnumValues.Length => e.EnumValues.GetValue((int)v)!.ToString()!,
            Kind.Int or Kind.Choice => ((int)v).ToString(CultureInfo.InvariantCulture),
            Kind.Float => ((float)v).ToString(CultureInfo.InvariantCulture),
            _ => v.ToString("R", CultureInfo.InvariantCulture),
        };

    private static string FormatValue(Entry e) => e.Kind == Kind.Text ? e.LastText : Format(e, e.Last);

    private static string Range(Entry e) =>
        e.Kind switch
        {
            Kind.Bool => "true/false",
            Kind.Color => "colour RRGGBB",
            Kind.Text => "text",
            Kind.Choice when e.EnumValues != null => string.Join(", ", e.EnumValues.Cast<object>()),
            Kind.Choice => $"0 to {ChoiceCount(e) - 1}: {string.Join(", ", e.Attr.Choices ?? [])}",
            _ => $"{Format(e, e.Attr.Min)} to {Format(e, e.Attr.Max)}",
        };

    private static void Save(ModOptions options)
    {
        options.SaveAt = DateTime.MaxValue;
        foreach (var e in options.MenuChanges)
        {
            Debug.Log($"[{options.Mod.Name}] {e.Name} = {FormatValue(e)} (menu)");
        }
        options.MenuChanges.Clear();
        var sb = new StringBuilder();
        sb.Append($"; Options of {options.Mod.Name}. Change them in the in-game menu ({s_key}) or here with the game closed.\r\n");
        sb.Append("[Options]\r\n");
        foreach (var e in options.Entries)
        {
            var def = e.Kind == Kind.Text ? e.DefaultText : Format(e, e.Default);
            sb.Append($"; {e.Attr.Label} ({Range(e)}, default {def})");
            if (!string.IsNullOrEmpty(e.Attr.Help))
            {
                sb.Append($": {e.Attr.Help}");
            }
            sb.Append($"\r\n{e.Name}={FormatValue(e)}\r\n");
        }
        try
        {
            File.WriteAllText(options.IniPath, sb.ToString());
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"[{options.Mod.Name}] could not save {Path.GetFileName(options.IniPath)}: {ex.Message}");
        }
    }
}
