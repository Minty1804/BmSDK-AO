#pragma once

// In-game options menu (BmSDK-AO addition): a Dear ImGui window drawn over the game's DX11 swapchain.
// BmSDK.dll (OptionsManager.cs) fills it with the options that mods declare with [Option] and polls it for changes;
// this file only draws and stores values. All exports are plain C (cdecl, UTF-8 strings) for P/Invoke.
//
// Threads: the exports are called from the game thread (and Install from a worker thread); drawing happens on
// whatever thread calls IDXGISwapChain::Present. The option table is guarded by a mutex.

#define BMSDK_MENU_API extern "C" __declspec(dllexport)

// Bumped when an export changes meaning or is added; OptionsManager checks it (now 3).
BMSDK_MENU_API int __cdecl BmSDK_Menu_ApiVersion();

// Hooks Present/ResizeBuffers through the swapchain vtable (a dummy device finds it). Call once the game is
// ticking: creating the dummy device during start-up can crash with ReShade (see Ultimate UI AO, RE_NOTES.md).
// Returns 1 on success. Safe to call again.
BMSDK_MENU_API int __cdecl BmSDK_Menu_Install(int menuKeyVk);

// Changes the key that opens the menu (virtual-key code).
BMSDK_MENU_API void __cdecl BmSDK_Menu_SetKey(int menuKeyVk);

// v1: adds a bool (0), int (1) or float (2) option to the tab `tab` (one tab per mod). Returns its id.
BMSDK_MENU_API int __cdecl BmSDK_Menu_AddOption(const char* tab, const char* label, const char* help, int type,
                                                double min, double max, double defaultValue, double value);

#define BMSDK_MENU_ADVANCED 1  // flags: drawn inside the section's collapsed "Advanced" node

// v3: every kind of option. Same layout in NativeMenu.cs (x86: pointers 4 bytes, doubles 8-aligned).
struct BmSDK_MenuOptionDesc {
    const char* tab;          // one tab per mod
    const char* section;      // inner tab inside the mod's tab ("" = above the inner tabs)
    const char* group;        // title line drawn when it changes ("" = none)
    const char* label;
    const char* help;         // tooltip
    const char* choices;      // type 3: "A\nB\nC", each optionally "Name\tTooltip"
    const char* format;       // slider format ("%.0f %%"), "" = default
    const char* text;         // type 5: current text
    const char* defaultText;  // type 5: default text
    int type;                 // 0 bool, 1 int, 2 float, 3 choice (index), 4 colour (0xRRGGBB), 5 text
    int flags;                // BMSDK_MENU_ADVANCED
    int parentId;             // bool option this one depends on (0 = none)
    int reserved[2];          // keeps the doubles at offset 56 with any packing
    double min, max, defaultValue, value;
};
BMSDK_MENU_API int __cdecl BmSDK_Menu_AddOptionEx(const BmSDK_MenuOptionDesc* desc);

// Removes every option of a tab (mod unloaded or reloaded). Their ids stop being valid.
BMSDK_MENU_API void __cdecl BmSDK_Menu_RemoveTab(const char* tab);

// Counter bumped every time the user changes a value in the menu.
BMSDK_MENU_API unsigned __cdecl BmSDK_Menu_Generation();

// v2: the options the user changed since the last call, each once with its latest value (text options: read the
// text with BmSDK_Menu_GetText). Returns how many were written (at most max); call again if it returns max.
BMSDK_MENU_API int __cdecl BmSDK_Menu_PollChanges(int* ids, double* values, int max);

// v2: id of the option whose slider is being dragged right now, 0 if none. Lets BmSDK notify mods less often
// during a drag and once more on release.
BMSDK_MENU_API int __cdecl BmSDK_Menu_ActiveOption();

// Current value of an option (bool: 0/1, choice: index, colour: 0xRRGGBB). NaN for an unknown id.
BMSDK_MENU_API double __cdecl BmSDK_Menu_GetValue(int id);

// Sets a value without bumping the generation (used when the mod or its ini changes it).
BMSDK_MENU_API void __cdecl BmSDK_Menu_SetValue(int id, double value);

// v3: text options. GetText copies up to size-1 bytes and returns the full length (-1 for an unknown id).
BMSDK_MENU_API int __cdecl BmSDK_Menu_GetText(int id, char* buffer, int size);
BMSDK_MENU_API void __cdecl BmSDK_Menu_SetText(int id, const char* text);

// v3: a status line under an option (state 0 info, 1 ok, 2 warning, 3 error). Warnings and errors always show;
// the others only when BmSDK_Menu_SetShowStatus(1).
BMSDK_MENU_API void __cdecl BmSDK_Menu_SetStatus(int id, const char* text, int state);
BMSDK_MENU_API void __cdecl BmSDK_Menu_SetShowStatus(int show);

// 1 while the menu is open.
BMSDK_MENU_API int __cdecl BmSDK_Menu_IsOpen();

// v3: the menu's own texts, for the language: 0 footer, 1 "Reset to defaults", 2 "No loaded mod...", 3 "Advanced".
BMSDK_MENU_API void __cdecl BmSDK_Menu_SetUiText(int which, const char* text);

// Text shown at the bottom of the menu (same as BmSDK_Menu_SetUiText(0, text)).
BMSDK_MENU_API void __cdecl BmSDK_Menu_SetFooter(const char* text);
