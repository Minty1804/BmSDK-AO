using BmSDK.BmGame;
using BmSDK.GFxUI;

namespace BmSDK.Framework;

/// <summary>
/// BmSDK-AO: the MODS screen of the pause menu, built from the game's own Game Options screen (Pause2.PM_OptionsGame)
/// so it looks, sounds and controls like the rest of the pause menu. Phase 2 of the in-game mod menu.
/// </summary>
/// <remarks>
/// The MODS entry (<see cref="PauseMenuEntry"/>) opens Game Options as the game would (its id 3) with this screen
/// active. The PC version of that screen (Screen_PC) has 8 fixed rows: ButtonId 1-7 are rs.ui.ListItem rows (a label,
/// a list of value names, a State index) bound to the script functions Get/Set/GetDefault + GameVariable below, and 8
/// is the Brightness slider, whose GetGamma/SetGamma are native (no redirect): hidden. While the screen is active
/// those script functions are redirected for this movie: Get/GetDefault answer 0, Set never reaches the game (the
/// game's own settings stay as they are) and tells us the row's new State instead. The rows themselves are rewritten
/// through GFx from the engine tick (it also runs while paused; the options screens call no OnTick): row 1 picks the
/// mod, row 2 the section when a mod's options do not all fit, the rest are options. Once the intro is over, one more
/// row (the screen's own List_Template symbol, ButtonId 9, bound to a spare Set function) goes in the hidden slider's
/// place, for 8 in all; the title and rows stay where the game puts them. A section longer than the rows
/// scrolls: on its last (first) row, down (up) links the row to itself, so the screen only sets the focus again and
/// calls SetToolTip for the row it already had focused (the OnFocus of the last move said so), and the window moves by
/// one. Back leaves as usual; the screen is off once that movie is closed.
/// </remarks>
internal static class PauseModScreen
{
    private const int OptionsGameId = 3; // the pause menu's Game Options entry
    private const int GameRows = 7;      // the screen's ListItem rows, ButtonId 1-7
    private const int SliderRow = 8;     // Brightness: hidden
    // Rows added below them: one, in the hidden slider's place. Until 2026-11-08 there were 6 and the title and rows
    // went up 3 rows to make room; with fewer options the user wants the screen as the game lays it out, and longer
    // lists scroll.
    private const int ExtraRows = 1;     // ButtonId 9
    private const int MaxId = SliderRow + ExtraRows;
    private const int ShiftRows = 0;     // the title and the rows stay where the game puts them
    private const double MouseQuietSeconds = 0.2; // a mouse rollover also focuses rows: no scroll while it moves

    // GameVariable of each row (index = ButtonId); Hints focuses with its AltHint "Hints2". The added rows use script
    // functions of RGFxMovieUI that no pause screen uses (Set<Var>(bool, int), redirected like the others); Gamma is
    // the hidden slider.
    private static readonly string[] Vars =
    [
        "", "InvertLook", "InvertRotation", "InvertGlide", "InvertBatarang", "CameraAssist", "Hints", "Vibration",
        "Gamma", "SixAxis", "ControlType", "Intensity3D", "EyeInversion3D", "Render3D", "Tutorial",
    ];

    private static readonly FString RowSymbol = new("List_Template"); // the ListItem symbol the screen imports
    private static readonly FString TitleMember = new("TitleName");
    private static readonly FString YMember = new("_y");
    private static readonly FString GameVariableMember = new("GameVariable");
    private static readonly FString AltHintMember = new("AltHint");
    private static readonly FString ButtonIdMember = new("ButtonId");
    private static readonly FString FlagsMember = new("flags");
    private static readonly FString ObjectClass = new("Object");
    private static readonly FString Empty = new("");
    private static readonly FString CurrentFrameMember = new("_currentframe");
    private const int IntroFrames = 10;
    private static bool s_rowsAdded;

    // The rows in screen order: 1-7, then the added ones that could be made
    private static List<int> s_rowIds = [.. Enumerable.Range(1, GameRows)];

    private enum RowKind
    {
        None,
        Mod,
        Page,
        Option,
    }

    private sealed record Page(string Title, List<OptionsManager.ScreenItem> Items);

    private static bool s_active;
    private static bool s_seenOpen;
    private static bool s_ready;
    private static bool s_dirty;
    private static bool s_rendering;
    private static bool s_leaving; // Back was pressed: the screen is closing
    private static DateTime s_startAt;
    private static List<OptionsManager.ScreenTab> s_tabs = [];
    private static List<Page> s_pages = [];
    private static int s_tab;
    private static int s_page;   // the section shown
    private static int s_offset; // its first option shown
    private static int s_focus;  // row of the screen's last OnFocus
    private static bool s_scrolled;
    private static (int X, int Y) s_mouse;
    private static DateTime s_mouseMovedAt;
    private static int s_lastTab; // the mod shown last time, shown first next time
    private static readonly RowKind[] s_kind = new RowKind[MaxId + 1];
    private static readonly OptionsManager.ScreenItem?[] s_item = new OptionsManager.ScreenItem?[MaxId + 1];
    private static readonly int[] s_state = new int[MaxId + 1];
    private static readonly string[] s_help = new string[MaxId + 1];

    // Values picked on the screen, applied once the option has stayed on the same value for ApplyAfterSeconds (keyed
    // by the option's entry), also while the menu is open: going through the suits one by one does not load each of
    // them, and the one picked starts loading while the player is still in the menu. Anything still waiting when the
    // screen closes goes in then.
    private static readonly Dictionary<object, (OptionsManager.ScreenItem Item, int Index, DateTime At)> s_pendingValues = [];
    private const double ApplyAfterSeconds = 0.5;

    private static readonly FString ScreenPath = new("_root.ScreenRoot.TheScreen");
    private static readonly FString InputArray = new("InputArray");
    private static readonly FString ObjectMember = new("object");
    private static readonly FString LabelMember = new("Label");
    private static readonly FString LabelNameMember = new("LabelName");
    private static readonly FString TextMember = new("Text");
    private static readonly FString ItemTextMember = new("ItemText");
    private static readonly FString LeftClickerMember = new("LeftClicker");
    private static readonly FString XMember = new("_x");
    private static readonly FString WidthMember = new("_width");
    private static readonly FString TextWidthMember = new("textWidth");
    private static readonly FString NamesMember = new("Names");
    private static readonly FString StateMember = new("State");
    private static readonly FString InitialMember = new("Initial");
    private static readonly FString DefaultMember = new("Default");
    private static readonly FString UpMember = new("up");
    private static readonly FString DownMember = new("down");
    private static readonly FString FocusIndexMember = new("FocusIndex");
    private static readonly FString UpdateMethod = new("Update");
    private static readonly FString SetFocusMethod = new("SetFocus");
    private static readonly TArray<GFxMoviePlayer.FASValue> s_noArgs = new(0);

    private static string T(string en, string es, string pt) => OptionsManager.T(en, es, pt);

    public static bool Active => s_active;

    /// <summary>MODS was picked: opens Game Options as this screen. False when no mod has options to show.</summary>
    public static bool Open(RGFxMovieUI_Pause pause)
    {
        s_tabs = OptionsManager.ScreenTabs();
        if (s_tabs.Count == 0)
        {
            return false;
        }
        s_tab = Math.Clamp(s_lastTab, 0, s_tabs.Count - 1);
        s_page = 0;
        s_offset = 0;
        s_focus = 0;
        s_rowsAdded = false;
        s_rowIds = [.. Enumerable.Range(1, GameRows)];
        s_active = true;
        s_seenOpen = false;
        s_leaving = false;
        s_ready = false;
        s_dirty = true;
        s_startAt = DateTime.UtcNow;
        Debug.Log($"[mods screen] opening: {s_tabs.Count} mod(s): {string.Join(", ", s_tabs.Select(t => $"{t.Name} ({t.Items.Count})"))}");
        pause.OnClicked(OptionsGameId);
        return true;
    }

    private static void Close(string why)
    {
        if (s_active)
        {
            Debug.Log($"[mods screen] closed ({why})");
        }
        s_active = false;
        s_ready = false;
        s_tabs = [];
        s_pages = [];
        Array.Clear(s_item);
    }

    /// <summary>Engine tick: finds the open screen and rewrites its rows when needed.</summary>
    public static void Tick()
    {
        ApplySettled(force: !s_active);
        if (!s_active)
        {
            return;
        }
        var movie = Game.FindObjects<RGFxMovieUI_PauseOptionsGame>()
            .FirstOrDefault(m => m.IsValid && !m.IsClassDefaultObject && m.bMovieIsOpen);
        if (movie == null)
        {
            if (s_seenOpen)
            {
                Close("screen closed");
            }
            else if (DateTime.UtcNow - s_startAt > TimeSpan.FromSeconds(5))
            {
                Close("the Game Options screen never opened");
            }
            return;
        }
        s_seenOpen = true;
        // Flash is only touched to find the rows once and to redraw them. Reading them every tick crashed the game on
        // Back: the screen's clips are freed while the movie still counts as open, and GFxObject.GetObject on one of
        // them reads a null object (BatmanOrigins.exe+0xC16673, 2026-11-05). Nothing at all once Back was pressed.
        if (s_leaving)
        {
            return;
        }
        if (GetCursorPos(out var p) && (p.X, p.Y) != s_mouse)
        {
            s_mouse = (p.X, p.Y);
            s_mouseMovedAt = DateTime.UtcNow;
        }
        if (s_ready && !s_dirty && s_rowsAdded)
        {
            return;
        }
        // Looked up again each time: GFx objects are not kept between frames (Ultimate UI AO, crash on closing a menu)
        if (movie.GetVariableObject(ScreenPath) is not { } screen || screen.GetObject(InputArray) is not { } input)
        {
            return;
        }
        var rows = new GFxObject[MaxId + 1];
        var entries = new GFxObject[MaxId + 1];
        for (var id = 1; id <= SliderRow; id++)
        {
            if (input.GetElementObject(id) is not { } entry || entry.GetObject(ObjectMember) is not { } row)
            {
                return; // not built yet
            }
            entries[id] = entry;
            rows[id] = row;
        }
        // The title from the very first frame and on every frame of the intro, whose text effect puts GAME OPTIONS
        // back (it used to be set only once the intro was over: about a second of GAME OPTIONS, user 2026-11-09)
        if (!s_rowsAdded)
        {
            SetTitle(screen);
        }
        if (!s_ready)
        {
            s_ready = true;
            rows[SliderRow].SetVisible(false);
            s_rowIds = [.. Enumerable.Range(1, GameRows)];
            Debug.Log($"[mods screen] rows found (row 1 had the label \"{rows[1].GetString(LabelNameMember)}\")");
        }
        // The intro (frames 1-10 of Screen_PC) fades the rows in from the timeline: moving them before it ends could
        // leave them at its first, faded colour
        if (!s_rowsAdded && screen.GetFloat(CurrentFrameMember) >= IntroFrames)
        {
            s_rowsAdded = true;
            try
            {
                AddRows(movie, screen, input, rows);
            }
            catch (Exception e)
            {
                Debug.LogWarning($"[mods screen] could not add rows: {e.Message}");
            }
            Debug.Log($"[mods screen] {s_rowIds.Count} rows");
            s_dirty = true;
        }
        for (var id = SliderRow + 1; id <= MaxId; id++)
        {
            if (s_rowIds.Contains(id))
            {
                if (input.GetElementObject(id) is not { } entry || entry.GetObject(ObjectMember) is not { } row)
                {
                    return;
                }
                entries[id] = entry;
                rows[id] = row;
            }
        }
        if (s_dirty)
        {
            s_dirty = false;
            Render(movie, screen, rows, entries);
            SetTitle(screen);
        }
    }

    // The screen's title says GAME OPTIONS (its TitleName, set by the timeline at the intro): MODS here, on every
    // frame of the intro and on every redraw (user, 2026-11-09). TitleName is either the text field itself or a clip with
    // one inside; which one is logged once.
    private static readonly FString TitleText = new("MODS");
    private static readonly FString TextFieldMember = new("textField");
    private static bool s_titleLogged;

    private static void SetTitle(GFxObject screen)
    {
        try
        {
            if (screen.GetObject(TitleMember) is not { } title)
            {
                return;
            }
            var field = title.GetObject(TextMember) ?? title.GetObject(TextFieldMember) ?? title.GetObject(LabelMember)?.GetObject(TextMember);
            (field ?? title).SetText(TitleText);
            if (!s_titleLogged)
            {
                s_titleLogged = true;
                Debug.Log($"[mods screen] title set on {(field == null ? "TitleName itself" : "a text field inside TitleName")}");
            }
        }
        catch (Exception e)
        {
            Debug.LogWarning($"[mods screen] could not set the title: {e.Message}");
        }
    }

    // Applies the values that have not changed for ApplyAfterSeconds (all of them once the screen is closed). Only
    // the options change: Flash is not touched here.
    private static void ApplySettled(bool force)
    {
        if (s_pendingValues.Count == 0)
        {
            return;
        }
        var now = DateTime.UtcNow;
        var ready = s_pendingValues
            .Where(p => force || (now - p.Value.At).TotalSeconds >= ApplyAfterSeconds)
            .ToList();
        foreach (var (key, (item, index, _)) in ready)
        {
            s_pendingValues.Remove(key);
            try
            {
                OptionsManager.ScreenSet(item, index);
            }
            catch (Exception e)
            {
                Debug.LogWarning($"[mods screen] could not apply {item.Label}: {e.Message}");
            }
        }
    }

    // More rows: copies of the screen's own row (its imported List_Template symbol) under the last one, each one an
    // entry of the screen's InputArray like the game's rows. Done once the intro is over (the timeline only fades the
    // rows in and later removes them), so moving the title and the rows up does not fight the animation.
    private static void AddRows(GFxMoviePlayer movie, GFxObject screen, GFxObject input, GFxObject[] rows)
    {
        var y1 = rows[1].GetFloat(YMember);
        var gap = rows[2].GetFloat(YMember) - y1;
        var lastY = rows[GameRows].GetFloat(YMember);
        var x = rows[GameRows].GetFloat(XMember);
        if (!float.IsFinite(gap) || gap <= 0 || !float.IsFinite(lastY) || !float.IsFinite(x))
        {
            Debug.Log($"[mods screen] rows at unexpected places (gap {gap}): no rows added");
            return;
        }
        var shift = ShiftRows * gap;
        for (var k = 1; k <= ExtraRows; k++)
        {
            var id = SliderRow + k;
            using var name = new FString($"BmSDK_Row{id}");
            var clip = screen.GetObject(name) ?? screen.AttachMovie(RowSymbol, name, 1000 + id);
            if (clip == null)
            {
                Debug.Log($"[mods screen] {RowSymbol} could not be attached: {s_rowIds.Count} rows");
                break;
            }
            clip.SetFloat(XMember, x);
            clip.SetFloat(YMember, lastY + k * gap - shift);
            using (var variable = new FString(Vars[id]))
            {
                clip.SetString(GameVariableMember, variable);
            }
            clip.SetString(AltHintMember, Empty);
            clip.SetFloat(ButtonIdMember, id);
            var entry = movie.CreateObject(ObjectClass);
            entry.SetObject(ObjectMember, clip);
            entry.SetFloat(FlagsMember, 0);
            input.SetElementObject(id, entry);
            s_rowIds.Add(id);
        }
        if (s_rowIds.Count == GameRows)
        {
            return;
        }
        for (var id = 1; id <= GameRows; id++)
        {
            rows[id].SetFloat(YMember, rows[id].GetFloat(YMember) - shift);
        }
        if (screen.GetObject(TitleMember) is { } title)
        {
            title.SetFloat(YMember, title.GetFloat(YMember) - shift);
        }
    }

    private static void BuildPages()
    {
        var items = s_tabs[s_tab].Items;
        s_pages = [];
        if (items.Count <= s_rowIds.Count - 1)
        {
            s_pages.Add(new Page("", items));
            return;
        }
        // One page per section; a long one scrolls
        foreach (var group in items.GroupBy(i => i.Section))
        {
            s_pages.Add(new Page(group.Key.Length > 0 ? group.Key : "General", group.ToList()));
        }
    }

    // Option rows on screen: all but MOD, and SECTION when there is one
    private static int WindowRows => s_rowIds.Count - (s_pages.Count > 1 || s_pages[0].Title.Length > 0 ? 2 : 1);


    private static void Render(GFxMoviePlayer movie, GFxObject screen, GFxObject[] rows, GFxObject[] entries)
    {
        BuildPages();
        s_page = Math.Clamp(s_page, 0, s_pages.Count - 1);
        var paged = s_pages.Count > 1 || s_pages[0].Title.Length > 0;
        var window = WindowRows;
        var all = s_pages[s_page].Items;
        s_offset = Math.Clamp(s_offset, 0, Math.Max(0, all.Count - window));
        Array.Clear(s_kind);
        Array.Clear(s_item);
        var slot = 0;
        s_kind[s_rowIds[slot++]] = RowKind.Mod;
        if (paged)
        {
            s_kind[s_rowIds[slot++]] = RowKind.Page;
        }
        var firstOption = s_rowIds[slot];
        var lastOption = firstOption;
        foreach (var item in all.Skip(s_offset).Take(window))
        {
            lastOption = s_rowIds[slot];
            s_item[lastOption] = item;
            s_kind[s_rowIds[slot++]] = RowKind.Option;
        }

        s_rendering = true;
        try
        {
            var visible = new List<int>();
            foreach (var id in s_rowIds)
            {
                var row = rows[id];
                if (s_kind[id] == RowKind.None)
                {
                    row.SetVisible(false);
                    continue;
                }
                visible.Add(id);
                row.SetVisible(true);
                string label;
                string[] names;
                int state, def;
                switch (s_kind[id])
                {
                    case RowKind.Mod:
                        label = "MOD";
                        names = [.. s_tabs.Select(t => t.Name)];
                        state = def = s_tab;
                        s_help[id] = T(
                            "Pick a mod. Left/right to change. Each change applies and saves half a second after you pick it.",
                            "Elige el mod. Izquierda/derecha para cambiar. Cada cambio se aplica y se guarda medio segundo después de elegirlo.",
                            "Escolha o mod. Esquerda/direita para mudar. Cada mudança é aplicada e salva meio segundo depois de escolhida."
                        );
                        break;
                    case RowKind.Page:
                        label = T("SECTION", "SECCIÓN", "SEÇÃO");
                        names = [.. s_pages.Select(p => p.Title)];
                        state = def = s_page;
                        s_help[id] = T(
                            "This mod's options, by section. Long sections scroll when you press down on their last row.",
                            "Las opciones de este mod, por secciones. Las secciones largas bajan pulsando abajo en su última fila.",
                            "As opções deste mod, por seção. As seções longas descem ao apertar para baixo na última linha."
                        );
                        break;
                    default:
                        var item = s_item[id]!;
                        state = OptionsManager.ScreenIndex(item); // also fills Values and Names
                        def = OptionsManager.ScreenDefaultIndex(item);
                        if (s_pendingValues.TryGetValue(item.Handle, out var pending))
                        {
                            state = Math.Clamp(pending.Index, 0, item.Names.Length - 1);
                        }
                        label = item.Label;
                        names = item.Names;
                        s_help[id] = item.Help;
                        break;
                }
                s_state[id] = state;
                SetRow(movie, row, label, names, state, def);
            }

            // Up/down only through the rows shown, wrapping around like the game's screen; the edge rows of a section
            // that goes on link to themselves (that press scrolls it, see Scroll)
            for (var k = 0; k < visible.Count; k++)
            {
                var v = visible[k];
                var up = v == firstOption && s_offset > 0 ? v : visible[(k - 1 + visible.Count) % visible.Count];
                var down = v == lastOption && s_offset + window < all.Count ? v : visible[(k + 1) % visible.Count];
                entries[v].SetFloat(UpMember, up);
                entries[v].SetFloat(DownMember, down);
            }
            var focus = (int)screen.GetFloat(FocusIndexMember);
            if (!visible.Contains(focus))
            {
                FocusRow(screen, rows[visible[0]], visible[0]);
            }
            else if (s_scrolled)
            {
                FocusRow(screen, rows[focus], focus); // the tooltip of the option now on that row
            }
            s_scrolled = false;
        }
        finally
        {
            s_rendering = false;
        }
        Debug.Log($"[mods screen] {s_tabs[s_tab].Name}: section {s_page + 1}/{s_pages.Count}, options {s_offset + 1}-{Math.Min(s_offset + window, all.Count)} of {all.Count}");
    }

    private static void SetRow(GFxMoviePlayer movie, GFxObject row, string label, string[] names, int state, int def)
    {
        // The row's label clip changes with its focus state (UI_Components.UI_ListItem: up/over/down are different
        // clips), and each one's first frame copies the row's LabelName into its text: both are set
        using (var text = new FString(label))
        {
            row.SetString(LabelNameMember, text);
            if (LabelText(row) is { } labelText)
            {
                labelText.SetText(text);
            }
        }
        FitValue(row, names);
        var array = movie.CreateArray();
        for (var i = 0; i < names.Length; i++)
        {
            using var name = new FString(names[i]);
            array.SetElementString(i, name);
        }
        row.SetObject(NamesMember, array);
        row.SetFloat(StateMember, state);
        row.SetFloat(InitialMember, state);
        row.SetFloat(DefaultMember, def);
        row.Invoke(UpdateMethod, s_noArgs); // redraws the value and the arrows (and calls Set, which we skip)
    }

    // Label.Text in the plain label clip, Label.Label.Text in the animated ones
    private static GFxObject? LabelText(GFxObject row)
    {
        if (row.GetObject(LabelMember) is not { } clip)
        {
            return null;
        }
        return clip.GetObject(TextMember) ?? clip.GetObject(LabelMember)?.GetObject(TextMember);
    }

    private const float LabelGap = 16; // between the end of the label and the left arrow, in the row's units

    // The value's text field (ItemText.ItemText) holds about 11 letters ("KNIGHT SOUN"). When a value is longer, the
    // field grows to the left, the left arrow with it, into the room the label leaves; its right edge and the right
    // arrow stay where the game put them. Computed from the current positions, so redrawing gives the same result.
    private static void FitValue(GFxObject row, string[] names)
    {
        if (row.GetObject(ItemTextMember) is not { } clip || clip.GetObject(ItemTextMember) is not { } field
            || row.GetObject(LeftClickerMember) is not { } left)
        {
            return;
        }
        var clipX = clip.GetFloat(XMember);
        var fieldX = field.GetFloat(XMember);
        var width = field.GetFloat(WidthMember);
        var leftX = left.GetFloat(XMember);
        if (!float.IsFinite(clipX) || !float.IsFinite(fieldX) || !float.IsFinite(width) || !float.IsFinite(leftX) || width <= 0)
        {
            return;
        }
        var right = clipX + fieldX + width;      // the field's right edge in row units
        var arrowGap = clipX + fieldX - leftX;   // left arrow to field
        // The game's width: the narrowest seen (all rows start alike; one of ours may already be wider)
        s_baseWidth = Math.Min(s_baseWidth ?? width, width);

        // Widest value (the text is put back by Update right after)
        float needed = 0;
        foreach (var name in names)
        {
            using var s = new FString(name);
            field.SetText(s);
            var w = field.GetFloat(TextWidthMember);
            if (float.IsFinite(w))
            {
                needed = Math.Max(needed, w + 8);
            }
        }

        // Room left by the label
        var room = float.MaxValue;
        if (row.GetObject(LabelMember) is { } labelClip && LabelText(row) is { } labelText)
        {
            var labelX = labelClip.GetFloat(XMember);
            var textX = labelText.GetFloat(XMember);
            var labelW = labelText.GetFloat(TextWidthMember);
            if (float.IsFinite(labelX) && float.IsFinite(textX) && float.IsFinite(labelW))
            {
                room = right - (labelX + textX + labelW + LabelGap + arrowGap);
            }
        }

        var target = Math.Max(s_baseWidth.Value, Math.Min(needed, room));
        if (Math.Abs(target - width) < 0.5f)
        {
            return;
        }
        var newFieldX = right - clipX - target;
        field.SetFloat(WidthMember, target);
        field.SetFloat(XMember, newFieldX);
        left.SetFloat(XMember, clipX + newFieldX - arrowGap);
    }

    private static float? s_baseWidth;

    // Screen.onEnterFrame notices the new FocusIndex and moves the highlight (an object cannot go through Invoke in
    // this GFx: FASValue has no object type, so DoSetFocus(row) is out)
    private static void FocusRow(GFxObject screen, GFxObject row, int id)
    {
        screen.SetFloat(FocusIndexMember, id);
        row.Invoke(SetFocusMethod, s_noArgs);
    }

    // ---- the rows' script functions while the screen is active ----

    private static bool Ours(RGFxMovieUI self) => s_active && self is RGFxMovieUI_PauseOptionsGame;

    // A row's State changed (the user, Y for defaults, or our own redraw)
    private static void RowSet(int id, int value)
    {
        if (!s_ready || s_leaving || s_rendering || id < 1 || id > MaxId || value == s_state[id])
        {
            return;
        }
        s_state[id] = value;
        switch (s_kind[id])
        {
            case RowKind.Mod:
                s_tab = s_lastTab = Math.Clamp(value, 0, s_tabs.Count - 1);
                s_page = 0;
                s_offset = 0;
                s_dirty = true; // redrawn from the next tick, not from inside Flash's call
                break;
            case RowKind.Page:
                s_page = value;
                s_offset = 0;
                s_dirty = true;
                break;
            case RowKind.Option when s_item[id] is { } item:
                // Kept for when the game resumes; back on the value the option has now, nothing is left to apply
                if (value == OptionsManager.ScreenIndex(item))
                {
                    s_pendingValues.Remove(item.Handle);
                }
                else
                {
                    s_pendingValues[item.Handle] = (item, value, DateTime.UtcNow);
                }
                break;
        }
    }

    private static int RowGet() => 0;

    // Back on the screen (the pause screens' OnBack): from here on its clips may be freed at any time
    [Redirect(typeof(RGFxMovieUI_PauseBase), nameof(RGFxMovieUI_PauseBase.OnBack))]
    private static void OnBack(RGFxMovieUI_PauseBase self)
    {
        if (Ours(self) && !s_leaving)
        {
            s_leaving = true;
            Debug.Log($"[mods screen] Back ({s_pendingValues.Count} change(s) still to apply)");
        }
        self.OnBack();
    }

    // The screen moved its focus (Screen.onEnterFrame, a frame after the move)
    [Redirect(typeof(RGFxMovieUI_PauseOptionsGame), nameof(RGFxMovieUI_PauseOptionsGame.OnFocus))]
    private static void OnFocus(RGFxMovieUI_PauseOptionsGame self, int Id)
    {
        if (Ours(self))
        {
            s_focus = Id;
        }
        self.OnFocus(Id);
    }

    // SetToolTip for the row that already has the focus: up on the first option row or down on the last one, which
    // link to themselves while the section goes on that way. Flash is not touched here.
    private static void Scroll(int id)
    {
        if (!s_ready || s_leaving || s_rendering || s_dirty || id != s_focus || id < 1 || id > MaxId
            || s_kind[id] != RowKind.Option || (DateTime.UtcNow - s_mouseMovedAt).TotalSeconds < MouseQuietSeconds)
        {
            return;
        }
        var first = Array.IndexOf(s_kind, RowKind.Option);
        var last = Array.LastIndexOf(s_kind, RowKind.Option);
        var count = s_pages[s_page].Items.Count;
        if (id == first || id == last)
        {
            Debug.Log($"[mods screen] edge row {id} pressed again: scroll {(id == last ? "down" : "up")} from {s_offset + 1}");
        }
        if (id == first && s_offset > 0)
        {
            s_offset--;
        }
        else if (id == last && s_offset + WindowRows < count)
        {
            s_offset++;
        }
        else
        {
            return;
        }
        s_scrolled = true;
        s_dirty = true; // redrawn from the next tick
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    private struct CursorPoint
    {
        public int X;
        public int Y;
    }

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern bool GetCursorPos(out CursorPoint point);

    [Redirect(typeof(RGFxMovie), nameof(RGFxMovie.SetToolTip))]
    private static void SetToolTip(RGFxMovie self, FString Text)
    {
        if (self is RGFxMovieUI ui && Ours(ui) && s_ready)
        {
            var key = Text.ToString() ?? "";
            var name = key.StartsWith("ToolTip.", StringComparison.Ordinal) ? key[8..] : key;
            var id = name == "Hints2" ? 6 : Array.IndexOf(Vars, name);
            Scroll(id);
            self.SetToolTip(new FString(id >= 1 && id <= MaxId ? s_help[id] ?? "" : ""));
            return;
        }
        self.SetToolTip(Text.ToString() is { } t ? new FString(t) : default);
    }

    // One Get/GetDefault/Set triple per row. The signatures must match the script functions exactly.
    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.GetInvertLook))]
    private static int GetInvertLook(RGFxMovieUI self, bool bPlayer2) => Ours(self) ? RowGet() : self.GetInvertLook(bPlayer2);

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.GetDefaultInvertLook))]
    private static int GetDefaultInvertLook(RGFxMovieUI self, bool bPlayer2) => Ours(self) ? RowGet() : self.GetDefaultInvertLook(bPlayer2);

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.SetInvertLook))]
    private static void SetInvertLook(RGFxMovieUI self, bool bPlayer2, int Value)
    {
        if (Ours(self)) { RowSet(1, Value); } else { self.SetInvertLook(bPlayer2, Value); }
    }

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.GetInvertRotation))]
    private static int GetInvertRotation(RGFxMovieUI self, bool bPlayer2) => Ours(self) ? RowGet() : self.GetInvertRotation(bPlayer2);

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.GetDefaultInvertRotation))]
    private static int GetDefaultInvertRotation(RGFxMovieUI self, bool bPlayer2) => Ours(self) ? RowGet() : self.GetDefaultInvertRotation(bPlayer2);

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.SetInvertRotation))]
    private static void SetInvertRotation(RGFxMovieUI self, bool bPlayer2, int Value)
    {
        if (Ours(self)) { RowSet(2, Value); } else { self.SetInvertRotation(bPlayer2, Value); }
    }

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.GetInvertGlide))]
    private static int GetInvertGlide(RGFxMovieUI self, bool bPlayer2) => Ours(self) ? RowGet() : self.GetInvertGlide(bPlayer2);

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.GetDefaultInvertGlide))]
    private static int GetDefaultInvertGlide(RGFxMovieUI self, bool bPlayer2) => Ours(self) ? RowGet() : self.GetDefaultInvertGlide(bPlayer2);

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.SetInvertGlide))]
    private static void SetInvertGlide(RGFxMovieUI self, bool bPlayer2, int Value)
    {
        if (Ours(self)) { RowSet(3, Value); } else { self.SetInvertGlide(bPlayer2, Value); }
    }

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.GetInvertBatarang))]
    private static int GetInvertBatarang(RGFxMovieUI self, bool bPlayer2) => Ours(self) ? RowGet() : self.GetInvertBatarang(bPlayer2);

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.GetDefaultInvertBatarang))]
    private static int GetDefaultInvertBatarang(RGFxMovieUI self, bool bPlayer2) => Ours(self) ? RowGet() : self.GetDefaultInvertBatarang(bPlayer2);

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.SetInvertBatarang))]
    private static void SetInvertBatarang(RGFxMovieUI self, bool bPlayer2, int Value)
    {
        if (Ours(self)) { RowSet(4, Value); } else { self.SetInvertBatarang(bPlayer2, Value); }
    }

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.GetCameraAssist))]
    private static int GetCameraAssist(RGFxMovieUI self, bool bPlayer2) => Ours(self) ? RowGet() : self.GetCameraAssist(bPlayer2);

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.GetDefaultCameraAssist))]
    private static int GetDefaultCameraAssist(RGFxMovieUI self, bool bPlayer2) => Ours(self) ? RowGet() : self.GetDefaultCameraAssist(bPlayer2);

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.SetCameraAssist))]
    private static void SetCameraAssist(RGFxMovieUI self, bool bPlayer2, int Value)
    {
        if (Ours(self)) { RowSet(5, Value); } else { self.SetCameraAssist(bPlayer2, Value); }
    }

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.GetHints))]
    private static int GetHints(RGFxMovieUI self, bool bPlayer2) => Ours(self) ? RowGet() : self.GetHints(bPlayer2);

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.GetDefaultHints))]
    private static int GetDefaultHints(RGFxMovieUI self, bool bPlayer2) => Ours(self) ? RowGet() : self.GetDefaultHints(bPlayer2);

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.SetHints))]
    private static void SetHints(RGFxMovieUI self, bool bPlayer2, int Value)
    {
        if (Ours(self)) { RowSet(6, Value); } else { self.SetHints(bPlayer2, Value); }
    }

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.GetVibration))]
    private static int GetVibration(RGFxMovieUI self, bool bPlayer2) => Ours(self) ? RowGet() : self.GetVibration(bPlayer2);

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.GetDefaultVibration))]
    private static int GetDefaultVibration(RGFxMovieUI self, bool bPlayer2) => Ours(self) ? RowGet() : self.GetDefaultVibration(bPlayer2);

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.SetVibration))]
    private static void SetVibration(RGFxMovieUI self, bool bPlayer2, int Value)
    {
        if (Ours(self)) { RowSet(7, Value); } else { self.SetVibration(bPlayer2, Value); }
    }

    // The added rows (only Set: their Get/GetDefault run before the row has its GameVariable)
    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.SetSixAxis))]
    private static void SetSixAxis(RGFxMovieUI self, bool bPlayer2, int Value)
    {
        if (Ours(self)) { RowSet(9, Value); } else { self.SetSixAxis(bPlayer2, Value); }
    }

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.SetControlType))]
    private static void SetControlType(RGFxMovieUI self, bool bPlayer2, int Value)
    {
        if (Ours(self)) { RowSet(10, Value); } else { self.SetControlType(bPlayer2, Value); }
    }

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.SetIntensity3D))]
    private static void SetIntensity3D(RGFxMovieUI self, bool bPlayer2, int Value)
    {
        if (Ours(self)) { RowSet(11, Value); } else { self.SetIntensity3D(bPlayer2, Value); }
    }

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.SetEyeInversion3D))]
    private static void SetEyeInversion3D(RGFxMovieUI self, bool bPlayer2, int Value)
    {
        if (Ours(self)) { RowSet(12, Value); } else { self.SetEyeInversion3D(bPlayer2, Value); }
    }

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.SetRender3D))]
    private static void SetRender3D(RGFxMovieUI self, bool bPlayer2, int Value)
    {
        if (Ours(self)) { RowSet(13, Value); } else { self.SetRender3D(bPlayer2, Value); }
    }

    [Redirect(typeof(RGFxMovieUI), nameof(RGFxMovieUI.SetTutorial))]
    private static void SetTutorial(RGFxMovieUI self, bool bPlayer2, int Value)
    {
        if (Ours(self)) { RowSet(14, Value); } else { self.SetTutorial(bPlayer2, Value); }
    }
}
