using BmSDK.BmGame;

namespace BmSDK;

/// <summary>
/// BmSDK-AO: the game's pause menu (2026-11-09).
/// </summary>
public static class PauseMenu
{
    /// <summary>
    /// Adds an entry to the pause menu, between RESUME and MODS. <paramref name="label"/> is asked for its text each
    /// time the menu is drawn (so it can follow the menu language, see <see cref="OptionsMenu.T(string, string, string)"/>);
    /// <paramref name="onClick"/> runs on the game thread when the entry is picked, with the pause menu's movie. The
    /// same <paramref name="key"/> again replaces the entry (a mod reloaded). Takes effect the next time the menu opens.
    /// </summary>
    public static void AddEntry(string key, Func<string> label, Action<RGFxMovieUI_Pause> onClick) =>
        Framework.PauseMenuEntry.Add(key, label, onClick);
}
