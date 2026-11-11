#if BMSDK_AOO
using BmSDK.BmGame;

namespace BmSDK.Framework;

// Arkham Origins Online build: the pause menu's MODS entry and screen (PauseMenuEntry.cs, PauseModScreen.cs) hook
// SinglePlayer's Flash menus and functions that AO Online's RGFxMovieUI doesn't have, so they are left out of this
// build (BmSDK.csproj). Same API, doing nothing: mods still build and run, and their options stay in the F10 menu.

internal static class PauseMenuEntry
{
    private static bool s_logged;

    internal static void Add(string key, Func<string> label, Action<RGFxMovieUI_Pause> click)
    {
        if (!s_logged)
        {
            s_logged = true;
            Debug.Log($"PauseMenu.AddEntry('{key}'): no pause menu entries on AO Online yet (options are in F10)");
        }
    }
}

internal static class PauseModScreen
{
    public static bool Open(RGFxMovieUI_Pause pause) => false;

    public static void Tick() { }
}
#endif
