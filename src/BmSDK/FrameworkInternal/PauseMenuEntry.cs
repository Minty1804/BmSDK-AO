using BmSDK.BmGame;
using BmSDK.GFxUI;

namespace BmSDK.Framework;

/// <summary>
/// BmSDK-AO: entries of our own in the pause menu, right after RESUME: MODS (the MODS screen, or the options menu) and
/// any entry a mod adds with <see cref="PauseMenu.AddEntry"/> (2026-11-09: Ultimate Suit Selector's SUITS).
/// </summary>
/// <remarks>
/// The pause list (Pause2.PM_MainMenu, class WBMtl.as.frontend.ListWrapper) asks the script for its entries with
/// ExternalInterface <c>RequestMenuData(path of the list)</c>. The script has already filled its arrays
/// (ButtonIds, ButtonStates, ButtonIconNames, ButtonIconPkgNames, ButtonStringRefs) with
/// <see cref="RGFxMovieUI.AddGridItem"/> in Init, and RequestMenuData only copies them into the list
/// (SetVariable*Array; bytecode read from BmGame.upk, 2026-11-05). So the entries go into those arrays right before
/// the original runs, moved right after RESUME (above EXIT until 2026-11-08). Flash shows each entry as the loc key
/// <c>$Menus.&lt;part after the last dot of the item name&gt;</c> (section [Menus] of GFxUI.int), which has nothing
/// for ours: each row's text is set from <see cref="RGFxMovieUI.OnTick"/>, which the list calls every frame. A click
/// calls <see cref="RGFxMovieUI_Pause.OnClicked"/> (the pause menu's own override) with the entry's id.
/// </remarks>
internal static class PauseMenuEntry
{
    private const int ModsId = 9400; // far from the game's ids (1-12 in the list's debug data); mod entries follow

    private sealed class Entry
    {
        public int Id;
        public string Key = ""; // who added it, to replace it when that mod adds it again (reload)
        public Func<string> Label = () => "";
        public Action<RGFxMovieUI_Pause> Click = _ => { };
        public int Index = -1; // its row in the list, -1 until found
        public FString LabelText;
        public string LabelShown = "";
        public readonly HashSet<int> LabelRows = []; // renderers whose label is already ours (this opening)
        public bool Logged;
    }

    private static readonly List<Entry> s_entries =
    [
        new Entry
        {
            Id = ModsId,
            Key = "BmSDK.Mods",
            Label = () => "MODS",
            Click = pause =>
            {
                // The MODS screen; the F10 menu when no mod has an option that screen can show
                if (!PauseModScreen.Open(pause))
                {
                    Debug.Log("[pause menu] MODS: nothing for the MODS screen, opening the options menu");
                    NativeMenu.SetOpen(true);
                }
            },
        },
    ];

    private static FString s_listPath;
    private static IntPtr s_listMovie;
    private static bool s_entriesLogged;

    private static readonly FString ButtonIds = new("ButtonIds");
    private static readonly FString Length = new("length");
    private static readonly FString List = new("sl");
    private static readonly FString Container = new("container");
    private static readonly FString DataProvider = new("dataProvider");
    private static readonly FString TextField = new("textField");
    private static readonly FString LabelMember = new("label");
    private static readonly FString Index = new("index");
    private static readonly FString DetailsAlpha = new("_root.ScreenRoot.TheScreen.DetailsItem._alpha");
    private static readonly Dictionary<int, FString> s_rendererNames = [];

    private static bool Enabled => NativeMenu.CanOpen;

    /// <summary>
    /// Adds (or replaces, same key) an entry. Mod entries go before MODS, in the order added, so the list reads
    /// RESUME, the mods' entries, MODS (user, 2026-11-09: "Suits second after Resume, then Mods"). Game thread.
    /// </summary>
    internal static void Add(string key, Func<string> label, Action<RGFxMovieUI_Pause> click)
    {
        var e = s_entries.FirstOrDefault(x => x.Key == key);
        if (e == null)
        {
            e = new Entry { Id = ModsId + s_entries.Count, Key = key };
            s_entries.Insert(s_entries.Count - 1, e); // MODS stays last
        }
        e.Label = label;
        e.Click = click;
        Debug.Log($"[pause menu] entry {label()} added by {key}");
    }

    /// <summary>
    /// A new FString with the same text. BmSDK passes only the FString's pointer on, so the original function and
    /// the script that called it would share (and free) one buffer (Ultimate UI AO, crash on Restart, 2026-10-27).
    /// </summary>
    private static FString Copy(FString s) => s.ToString() is { } text ? new FString(text) : default;

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.RequestMenuData))]
    private static int RequestMenuData(RGFxMovieUI self, FString TargetBasePath)
    {
        if (self is RGFxMovieUI_Pause && Enabled)
        {
            try
            {
                AddEntries(self);
            }
            catch (Exception e)
            {
                Debug.LogWarning($"[pause menu] could not add our entries: {e.Message}");
            }
            s_listPath = new FString(TargetBasePath.ToString() ?? "");
            s_listMovie = self.Ptr;
            foreach (var e in s_entries)
            {
                e.Index = -1;
                e.LabelRows.Clear();
                e.Logged = false;
            }
        }
        return self.RequestMenuData(Copy(TargetBasePath));
    }

    private static void AddEntries(RGFxMovieUI self)
    {
        var names = self.ButtonIconNames;
        // Ours go right after RESUME (from the second row on); without RESUME, above EXIT
        var exit = -1;
        var resume = -1;
        var pkg = "PauseMenuIcons";
        for (var i = 0; i < names.Count; i++)
        {
            var name = names[i].ToString() ?? "";
            var dot = name.LastIndexOf('.');
            var item = name[(dot + 1)..];
            if (resume < 0 && item.EndsWith("Resume_Resume", StringComparison.OrdinalIgnoreCase))
            {
                resume = i;
            }
            if (exit < 0 && item.EndsWith("Exit_Exit", StringComparison.OrdinalIgnoreCase))
            {
                exit = i;
                if (dot > 0)
                {
                    pkg = name[..dot];
                }
            }
        }
        if (!s_entriesLogged)
        {
            s_entriesLogged = true;
            var ids = self.ButtonIds;
            var list = string.Join(", ", Enumerable.Range(0, names.Count).Select(i => $"{(i < ids.Count ? ids[i] : 0)} {names[i]}"));
            Debug.Log($"[pause menu] game entries: {list}");
        }
        var place = resume >= 0 ? resume + 1 : exit;
        foreach (var e in s_entries)
        {
            if (self.ButtonIds.Contains(e.Id))
            {
                place = place < 0 ? place : place + 1;
                continue; // arrays kept from an earlier opening
            }
            var label = e.Label();
            self.AddGridItem(e.Id, new FString($"{pkg}.BmSDK_Entry{e.Id}"), new FString(pkg), new FString(label), false, false, false);

            // AddGridItem appends to all five arrays: move the new last element up to its place
            var idArr = self.ButtonIds;
            var count = idArr.Count;
            if (place < 0 || idArr[count - 1] != e.Id)
            {
                Debug.Log($"[pause menu] {label} added at the end (neither RESUME nor EXIT found)");
                continue;
            }
            var stateArr = self.ButtonStates;
            var iconArr = self.ButtonIconNames;
            var pkgArr = self.ButtonIconPkgNames;
            var refArr = self.ButtonStringRefs;
            if (stateArr.Count != count || iconArr.Count != count || pkgArr.Count != count || refArr.Count != count)
            {
                Debug.Log($"[pause menu] arrays of different lengths: {label} stays at the end");
                continue;
            }
            MoveUp(idArr.AsSpan(), place);
            MoveUp(stateArr.AsSpan(), place);
            MoveUp(iconArr.AsSpan(), place); // FStrings move as they are: no string is copied or freed
            MoveUp(pkgArr.AsSpan(), place);
            MoveUp(refArr.AsSpan(), place);
            Debug.Log($"[pause menu] {label} added as entry {place} of {count}, {(resume >= 0 ? "after RESUME" : "above EXIT")}");
            place++;
        }
    }

    // Moves the last element to index `to`, shifting the rest down by one
    private static void MoveUp<T>(Span<T> items, int to)
    {
        var last = items[^1];
        items[to..^1].CopyTo(items[(to + 1)..]);
        items[to] = last;
    }

    [Redirect(typeof(RGFxMovieUI_Pause), nameof(RGFxMovieUI_Pause.OnClicked))]
    private static void OnClicked(RGFxMovieUI_Pause self, int inID)
    {
        if (s_entries.FirstOrDefault(e => e.Id == inID) is { } entry)
        {
            try
            {
                entry.Click(self);
            }
            catch (Exception e)
            {
                Debug.LogWarning($"[pause menu] {entry.Label()}: {e.Message}");
            }
            return;
        }
        self.OnClicked(inID);
    }

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.OnTick))]
    private static void OnTick(RGFxMovieUI self)
    {
        self.OnTick();
        if (self is RGFxMovieUI_Pause && self.Ptr == s_listMovie)
        {
            try
            {
                // The box under the list that describes the selected entry stays where the game put it, so with our
                // rows the last ones went over it (issue #1, 2026-11-10): it is always hidden. _alpha, not _visible:
                // the movie sets noInvisibleAdvance and a hidden clip would stop advancing.
                self.SetVariableNumber(DetailsAlpha, 0f);
                FixLabels(self);
            }
            catch (Exception e)
            {
                s_listMovie = IntPtr.Zero; // stop trying for this menu
                Debug.LogWarning($"[pause menu] could not set our entries' labels: {e.Message}");
            }
        }
    }

    // Each row's text is set again every frame: the list's intro and its selection effect (WBMtl DecryptingText) put
    // back the text the row had when they started. The row's own label (CLIK Button.label, taken from the dataProvider
    // when the row was drawn) is set too: a state change (rollover, selection) redraws the text from it, and with the
    // loc key still there "?INT?GFxUI.Menus.BmSDK_Mods?" showed for a frame (user, 2026-11-08).
    private static void FixLabels(RGFxMovieUI movie)
    {
        if (movie.GetVariableObject(s_listPath) is not { } list || list.GetObject(List) is not { } sl)
        {
            return;
        }
        foreach (var e in s_entries)
        {
            var label = e.Label();
            if (label != e.LabelShown)
            {
                e.LabelShown = label;
                e.LabelText = new FString(label);
                e.LabelRows.Clear();
                e.Index = -1;
            }
            if (e.Index < 0)
            {
                e.Index = FindIndex(list, e.Id);
                if (e.Index < 0)
                {
                    continue;
                }
                // Rows drawn later (scrolling) take their text from here
                sl.GetObject(DataProvider)?.SetElementString(e.Index, e.LabelText);
            }
        }
        if (sl.GetObject(Container) is not { } container)
        {
            return;
        }
        for (var i = 0; i < 32; i++)
        {
            if (container.GetObject(RendererName(i)) is not { } row)
            {
                break;
            }
            // CLIK renderers know their row (index); without it, renderer i is row i (the list does not scroll)
            var rowIndex = row.GetFloat(Index);
            var at = float.IsNaN(rowIndex) ? i : (int)rowIndex;
            var e = s_entries.FirstOrDefault(x => x.Index == at);
            if (e == null || row.GetObject(TextField) is not { } text)
            {
                continue;
            }
            var shown = text.GetText().ToString() ?? "";
            if (!e.Logged)
            {
                e.Logged = true;
                Debug.Log($"[pause menu] {e.LabelShown} is row {e.Index} (renderer{i}), the game showed \"{shown}\"");
            }
            // Once per row drawn (not read back every frame: each GetString returns a new string), and again whenever
            // the text was put back
            if (shown != e.LabelShown || e.LabelRows.Add(i))
            {
                row.SetString(LabelMember, e.LabelText);
                text.SetText(e.LabelText);
            }
        }
    }

    private static int FindIndex(GFxObject list, int id)
    {
        if (list.GetObject(ButtonIds) is not { } ids)
        {
            return -1;
        }
        var count = (int)ids.GetFloat(Length);
        for (var i = 0; i < count && i < 64; i++)
        {
            if ((int)ids.GetElementFloat(i) == id)
            {
                return i;
            }
        }
        return -1;
    }

    private static FString RendererName(int i)
    {
        if (!s_rendererNames.TryGetValue(i, out var n))
        {
            n = new FString($"renderer{i}");
            s_rendererNames[i] = n;
        }
        return n;
    }
}
