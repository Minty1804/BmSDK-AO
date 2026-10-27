namespace BmSDK.Framework;

/// <summary>
/// Declares a static field or property of a mod as a user option (BmSDK-AO addition).
/// BmSDK shows it in the in-game options menu (one tab per mod), loads and saves it in the mod's
/// <c>options.ini</c>, and calls <see cref="Script.OnOptionChanged"/> on the mod's scripts when the user changes it.
/// </summary>
/// <remarks>
/// Supported types and how they show in the menu:
/// <list type="bullet">
/// <item><see cref="bool"/>: checkbox.</item>
/// <item><see cref="int"/>, <see cref="float"/>, <see cref="double"/>: slider from <see cref="Min"/> to <see cref="Max"/>.</item>
/// <item>an enum, or an <see cref="int"/> with <see cref="Choices"/>: radio buttons (up to 5 choices) or a drop-down.</item>
/// <item><see cref="int"/> with <see cref="Color"/>: colour picker, value 0xRRGGBB.</item>
/// <item><see cref="string"/>: text field.</item>
/// </list>
/// The default value is the member's initial value. The ini key is the member's name.
/// If the mod's own code changes the member, the menu and the ini follow.
/// Texts ending in <c>Es</c> are the Spanish versions, used when the menu language is Spanish.
/// </remarks>
/// <example>
/// [Option("Strength", Min = 0, Max = 1, Help = "How much the lips move")]
/// public static float Strength = 0.6f;
/// </example>
/// <param name="label">Text shown in the menu.</param>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = false)]
public sealed class OptionAttribute(string label) : Attribute
{
    public string Label { get; } = label;
    public string? LabelEs { get; init; }

    /// <summary>Lowest value (int and float options).</summary>
    public double Min { get; init; } = 0;

    /// <summary>Highest value (int and float options).</summary>
    public double Max { get; init; } = 1;

    /// <summary>Tooltip shown in the menu.</summary>
    public string? Help { get; init; }
    public string? HelpEs { get; init; }

    /// <summary>Inner tab inside the mod's tab. Options without one go above the inner tabs.</summary>
    public string? Section { get; init; }
    public string? SectionEs { get; init; }

    /// <summary>Title line drawn above the first option of each group.</summary>
    public string? Group { get; init; }
    public string? GroupEs { get; init; }

    /// <summary>Choice names (int options; enums use their member names unless this is set).</summary>
    public string[]? Choices { get; init; }
    public string[]? ChoicesEs { get; init; }

    /// <summary>Tooltip of each choice, same order as the choices.</summary>
    public string[]? ChoiceHelp { get; init; }
    public string[]? ChoiceHelpEs { get; init; }

    /// <summary>An int option edited with a colour picker (0xRRGGBB, saved as RRGGBB).</summary>
    public bool Color { get; init; }

    /// <summary>Slider format, printf style ("x%.2f", "%.0f %%").</summary>
    public string? Format { get; init; }

    /// <summary>Shown inside the section's collapsed "Advanced" node.</summary>
    public bool Advanced { get; init; }

    /// <summary>Name of a bool option of the same mod: this one is indented and disabled while that one is off.</summary>
    public string? DependsOn { get; init; }

    /// <summary>Saved in the ini but not shown in the menu (state the mod keeps between sessions).</summary>
    public bool Hidden { get; init; }
}

/// <summary>Colour of an option's status line in the menu (BmSDK-AO addition).</summary>
public enum OptionStatus
{
    /// <summary>Grey; shown only with "Show option status" on.</summary>
    Info,

    /// <summary>Green; shown only with "Show option status" on.</summary>
    Ok,

    /// <summary>Yellow; always shown.</summary>
    Warning,

    /// <summary>Red; always shown.</summary>
    Error,
}

/// <summary>The in-game options menu, for mods (BmSDK-AO addition).</summary>
public static class OptionsMenu
{
    /// <summary>Menu language: "en" or "es". Mods that build their own texts (status lines) follow it.</summary>
    public static string Language => OptionsManager.Language;

    /// <summary>True when the menu language is Spanish.</summary>
    public static bool Spanish => OptionsManager.Language == "es";

    /// <summary>True while the menu is open.</summary>
    public static bool IsOpen => NativeMenu.IsOpen();

    /// <summary>
    /// Sets the status line under one of the mod's options (empty text removes it). Cheap to call every tick: the
    /// menu is only updated when the text or the status changes.
    /// </summary>
    public static void SetStatus(Mod mod, string memberName, string text, OptionStatus status = OptionStatus.Info) =>
        OptionsManager.SetStatus(mod, memberName, text, status);

    /// <summary>
    /// Replaces the choices of an int option declared with <see cref="OptionAttribute.Choices"/>, for lists only known
    /// at run time (BmSDK-AO addition). The value is kept inside the new range and the menu is rebuilt, so call it
    /// only when the list changes (it does nothing when the list is the same). Choice tooltips are dropped.
    /// The ini value is read before the mod can call this, against the declared choices: keep the real state in
    /// another member (a string, for example) and set the index from it.
    /// </summary>
    public static void SetChoices(Mod mod, string memberName, string[] choices, string[]? choicesEs = null) =>
        OptionsManager.SetChoices(mod, memberName, choices, choicesEs);

    /// <summary>English or Spanish text, following the menu language.</summary>
    public static string T(string en, string es) => Spanish ? es : en;
}
