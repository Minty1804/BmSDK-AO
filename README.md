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
- **In-game options menu** (F10, or Insert while the Ultimate UI AO `.asi` is installed): mods declare their settings with `[Option]` and get their own tab. Settings are saved to an `options.ini` next to each mod. The menu supports toggles, sliders, choices, colours, text, sections, English and Spanish.
- **Native hooks for scripts:** `DetourUtil.Hook` hooks a function of the game executable. BmSDK removes a mod's hooks when it is unloaded or reloaded.
- **`[Redirect(..., IncludeOverrides = true)]`:** a redirect that also runs when a subclass or a state overrides the function. Off by default, as in the original.

Everything specific to Arkham Origins lives in separate files (`*.AO.cs`, `ao_*`) where possible, so the original code stays easy to compare and update.

## 🚀 Getting started
Download the latest version from [Releases](https://github.com/Minty1804/BmSDK-AO/releases). Nothing else is needed: BmSDK-AO carries its own .NET runtime.

1. Run `BmSDK_AO_Installer_vX.Y.Z.exe`, pick your game and click *Install*. It finds the Steam copy of the game by itself. If it doesn't, click *Choose another folder...* and pick the game folder (in Steam: right-click *Batman: Arkham Origins* > *Manage* > *Browse local files*).
2. Start the game. Press F10 to open the options of your mods.

The installer only adds files to `SinglePlayer\Binaries\Win32\`: `plugins\BmSDK.Host.asi`, the `sdk` folder and `dinput8.dll` ([Ultimate ASI Loader](https://github.com/ThirteenAG/Ultimate-ASI-Loader); an existing `dinput8.dll` from another mod is kept).

Script mods go in their own folder in `SinglePlayer\BmGame\Mods\<Mod>\` (a `mod.toml` and a `scripts` folder), or as .cs files in `SinglePlayer\BmGame\Scripts`. The log is written to `SinglePlayer\Binaries\Win32\BmSDK.log`.

**Update:** run the installer of the new version. Your mods and their settings are kept.

**Uninstall:** in `SinglePlayer\Binaries\Win32\`, delete `plugins\BmSDK.Host.asi`, the `sdk` folder, `BmSDK.ini` and the `BmSDK*.log` files. Delete `dinput8.dll` too, unless another ASI mod uses it.

To build from source instead, see [Building from source](https://bmsdk.dev/docs/contributing/building/), then copy `bin\Binaries\Win32\plugins\BmSDK.Host.asi` and `bin\Binaries\Win32\sdk\` into `SinglePlayer\Binaries\Win32\` (with [Ultimate ASI Loader](https://github.com/ThirteenAG/Ultimate-ASI-Loader) as `dinput8.dll`).

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
