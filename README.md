> **Important note**: This is **BmSDK-AO**, an unofficial fork of [BmSDK for Arkham City](https://github.com/Team-BmSDK/BmSDK-AC) that adds support for **Batman: Arkham Origins**.
>
> All credit for BmSDK goes to its original authors, [Eli Kramer (etkramer)](https://github.com/etkramer) and [Team-BmSDK](https://github.com/Team-BmSDK). This fork only adds Arkham Origins compatibility on top of their work. If you play Arkham City or Arkham Knight, use the official [BmSDK-AC](https://github.com/Team-BmSDK/BmSDK-AC) or [BmSDK-AK](https://github.com/Team-BmSDK/BmSDK-AK) instead.

<br />

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/user-attachments/assets/ab0b54fe-b851-4021-aaf4-c8e0a834f051">
    <img alt="BmSDK" width="600" src="https://github.com/user-attachments/assets/d5446cc2-16c8-4dd0-98fa-7248708d6c46">
  </picture>
</p>

<br />

<p align="center">
A powerful, easy-to-use scripting platform for Batman: Arkham Origins that lets you integrate custom C# code for gameplay mods and more.
</p>

<br />

<p align="center">
  <a href="./LICENSE.md">
    <img alt="MIT license" src="https://img.shields.io/badge/license-MIT-green.svg?style=for-the-badge" />
  </a>
  <a href="https://dotnet.microsoft.com/en-us/download/dotnet/10.0">
    <img alt=".NET 10" src="https://img.shields.io/badge/.NET-10.0-512bd4?style=for-the-badge" />
  </a>
  <a href="https://discord.com/invite/arkhamworkshop">
    <img alt="Community Discord" src="https://img.shields.io/discord/1218395254013558844?logo=discord&logoColor=E0E3FF&label=Community%20Discord&labelColor=5865F2&style=for-the-badge" />
  </a>
</p>

<hr />

<br />

Scripts get the same types, properties and functions the original developers worked with, plus life-cycle events *(e.g. tick and game enter)* and helpers on top. Below is an example mod that adds a field of view setting to the in-game options menu:
<details>
<summary>Example Script</summary>

```csharp
using BmSDK;

[Script]
public class FieldOfView : Script
{
    [Option("Custom field of view", Help = "Off: the game's own field of view.")]
    public static bool Enabled = false;

    [Option("Degrees", Min = 50, Max = 120, Help = "Wider shows more around Batman.")]
    public static float Degrees = 90f;

    public override void OnEnterGame() => Apply();

    public override void OnOptionChanged(string name) => Apply();

    private static void Apply()
    {
        // Same engine command the game binds to F6-F8 ("Fov 0" = the game's default)
        Game.GetPlayerController().FOV(Enabled ? Degrees : 0f);
    }
}
```
</details>

Check out the [BmSDK documentation](https://bmsdk.dev/docs) for more info. It is written for Arkham City, but the scripting API is the same.

## 🦇 What this fork adds
- **Arkham Origins support** (single player, Steam version): the game's address table, startup on the protected Steam executable, and C# classes generated from Arkham Origins itself.
- **In-game options menu** (F10, or Insert while the Ultimate UI AO `.asi` is installed): mods declare their settings with `[Option]` and get their own tab. Settings are saved to an `options.ini` next to each mod. The menu supports toggles, sliders, choices (also filled at run time with `OptionsMenu.SetChoices`), colours, text, sections, English and Spanish.
- **Native hooks for scripts:** `DetourUtil.Hook` hooks a function of the game executable. BmSDK removes a mod's hooks when it is unloaded or reloaded.
- **`[Redirect(..., IncludeOverrides = true)]`:** a redirect that also runs when a subclass or a state overrides the function. Off by default, as in the original.
- **Crash log:** when the game crashes in native code (the game, an `.asi` or a mod), `Binaries\Win32\BmSDK.Host.log` records the real cause: error, address as `module+offset`, registers, likely return addresses and the script or redirect that was running.
- **`const out` parameters** of game functions are generated as C# `in`, so the value reaches the game (in the original they arrive as zeros).

Everything specific to Arkham Origins lives in separate files (`*.AO.cs`, `ao_*`) where possible, so the original code stays easy to compare and update.

## 🚀 Getting started
If you want to use mods, here's how you get set up:

1. Download [the latest installer](https://github.com/Minty1804/BmSDK-AO/releases/latest) and run it.
2. Pick your Arkham Origins folder. The Steam installation is detected automatically, and you can browse for it yourself if it isn't listed.
3. Press **Install**, then start the game. Script mods go in your `SinglePlayer\BmGame\Mods` folder (one folder per mod) or in `SinglePlayer\BmGame\Scripts` as .cs files. Press F10 in game to open your mods' options.

The installer isn't code-signed, so Windows SmartScreen may warn you the first time you run it. Choose "More info" → "Run anyway" to continue.

<details>
<summary>Installing manually instead</summary>

1. Download the `BmSDK_AO_v*.zip` from the latest [release](https://github.com/Minty1804/BmSDK-AO/releases/latest) and open it.
2. Inside you'll see a `Binaries` folder. Copy it to your game's `SinglePlayer` folder (likely `C:\Program Files (x86)\Steam\steamapps\common\Batman Arkham Origins\SinglePlayer`). There should already be a folder there with the same name: merge them and replace the files. If your game already has a `Binaries\Win32\dinput8.dll` from another mod, keep yours when it is Ultimate ASI Loader; otherwise BmSDK-AO won't start.
3. BmSDK-AO is now installed! Script mods go in your `SinglePlayer\BmGame\Mods` folder (one folder per mod) or in `SinglePlayer\BmGame\Scripts` as .cs files. Press F10 in game to open your mods' options.

To uninstall, delete `Binaries\Win32\plugins\BmSDK.Host.asi` and the `Binaries\Win32\sdk` folder. `Binaries\Win32\dinput8.dll` (Ultimate ASI Loader) can stay if other `.asi` mods use it.
</details>

Keep in mind that script mods can potentially harm your computer. Make sure you only download and install mods from trusted sources.

### ⚠️ Supported versions
Only the Steam version of Arkham Origins (single player) is supported for now. The Epic Games and GOG versions and the multiplayer executable are not.

## 🛠️ Contributing
Contributions are welcome:
- **Arkham Origins compatibility** (addresses, game classes, fixes that only affect Arkham Origins, support for other versions of the game): open an issue or a pull request here.
- **General improvements to BmSDK** that would help every game: please contribute them to the original repository, [Team-BmSDK/BmSDK-AC](https://github.com/Team-BmSDK/BmSDK-AC), so everyone benefits. This fork picks up their changes.

To build from source, see the BmSDK docs: [Building from source](https://bmsdk.dev/docs/contributing/building/)

## 📋 Legal notice
BmSDK is published under the [MIT licence](LICENSE.md). BmSDK-AO keeps the same licence and the original copyright.

BmSDK is not associated with Warner Bros. Games, Rocksteady Studios or WB Games Montréal. All product and company names are trademarks or registered trademarks of their respective holders. Use of these names does not imply any affiliation or endorsement by them.
