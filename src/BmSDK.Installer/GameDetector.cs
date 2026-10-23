using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace BmSDK.Installer;

internal sealed record GameInstall(string Path, string Source);

/// <summary>
/// Locates Arkham Origins installations from the Steam library metadata.
/// </summary>
/// <remarks>
/// Paths here are the game's root folder (the one Steam's "Browse local files" opens),
/// which holds SinglePlayer and Online. BmSDK goes into SinglePlayer.
/// </remarks>
internal static partial class GameDetector
{
    private const string SteamAppId = "209000";

    public const string GameProcessName = "BatmanOrigins";

    /// <summary>
    /// The folder inside the game root that BmSDK is installed into.
    /// </summary>
    public const string SinglePlayerDir = "SinglePlayer";

    /// <summary>
    /// Returns every valid installation found, deduplicated by directory.
    /// </summary>
    public static List<GameInstall> DetectAll()
    {
        var results = new List<GameInstall>();
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var install in DetectSteam())
        {
            var path = Normalize(install.Path);
            if (IsValidGameDir(path) && seen.Add(path))
            {
                results.Add(install with { Path = path });
            }
        }

        return results;
    }

    public static bool IsValidGameDir(string? path)
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            return false;
        }

        try
        {
            var singlePlayer = Path.Combine(path, SinglePlayerDir);
            return File.Exists(Path.Combine(singlePlayer, "Binaries", "Win32", "BatmanOrigins.exe"))
                && Directory.Exists(Path.Combine(singlePlayer, "BmGame"));
        }
        catch (ArgumentException)
        {
            return false;
        }
    }

    /// <summary>
    /// Accepts the game root or any folder inside it (SinglePlayer, Binaries\Win32...)
    /// and returns the game root, or null if none of them is an Arkham Origins folder.
    /// </summary>
    public static string? FindGameRoot(string? path)
    {
        for (var dir = path is null ? null : new DirectoryInfo(Normalize(path)); dir is not null; dir = dir.Parent)
        {
            if (IsValidGameDir(dir.FullName))
            {
                return Normalize(dir.FullName);
            }
        }

        return null;
    }

    public static string GetWin32Dir(string gameDir) =>
        Path.Combine(gameDir, SinglePlayerDir, "Binaries", "Win32");

    public static string? GetInstalledVersion(string gameDir)
    {
        var sdkPath = Path.Combine(GetWin32Dir(gameDir), "sdk", "BmSDK.dll");
        if (!File.Exists(sdkPath))
        {
            return null;
        }

        var version = System.Diagnostics.FileVersionInfo.GetVersionInfo(sdkPath).ProductVersion;
        return version?.Split('+')[0];
    }

    public static bool IsGameRunning() =>
        System.Diagnostics.Process.GetProcessesByName(GameProcessName).Length > 0;

    public static bool PathsEqual(string a, string b) =>
        string.Equals(Normalize(a), Normalize(b), StringComparison.OrdinalIgnoreCase);

    public static string Normalize(string path)
    {
        try
        {
            return Path.TrimEndingDirectorySeparator(Path.GetFullPath(path));
        }
        catch (ArgumentException)
        {
            return path;
        }
    }

    private static IEnumerable<GameInstall> DetectSteam()
    {
        var steamPath = GetSteamPath();
        if (steamPath is null)
        {
            yield break;
        }

        foreach (var library in GetSteamLibraries(steamPath))
        {
            var manifestPath = Path.Combine(library, "steamapps", $"appmanifest_{SteamAppId}.acf");
            var installDir = ReadValue(manifestPath, InstallDirRegex());
            if (installDir is not null)
            {
                yield return new GameInstall(
                    Path.Combine(library, "steamapps", "common", installDir),
                    "Steam"
                );
            }
        }
    }

    private static string? GetSteamPath()
    {
        var machinePath = Registry.GetValue(
            @"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Valve\Steam", "InstallPath", null) as string;

        var userPath = Registry.GetValue(
            @"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamPath", null) as string;

        var steamPath = machinePath ?? userPath;
        return Directory.Exists(steamPath) ? steamPath : null;
    }

    private static IEnumerable<string> GetSteamLibraries(string steamPath)
    {
        var libraryFile = Path.Combine(steamPath, "steamapps", "libraryfolders.vdf");

        return ReadValues(libraryFile, LibraryPathRegex())
            .Prepend(steamPath)
            .DistinctBy(Normalize, StringComparer.OrdinalIgnoreCase);
    }

    private static string? ReadValue(string filePath, Regex regex) =>
        ReadValues(filePath, regex).FirstOrDefault();

    /// <summary>
    /// Returns the first capture group of every match, unescaping Steam's doubled backslashes.
    /// </summary>
    private static List<string> ReadValues(string filePath, Regex regex)
    {
        try
        {
            return regex.Matches(File.ReadAllText(filePath))
                .Select(x => x.Groups[1].Value.Replace(@"\\", @"\"))
                .ToList();
        }
        catch (Exception e) when (e is IOException or UnauthorizedAccessException or ArgumentException)
        {
            return [];
        }
    }

    [GeneratedRegex("""^\s*"path"\s+"(.+?)"\s*$""", RegexOptions.Multiline)]
    private static partial Regex LibraryPathRegex();

    [GeneratedRegex("""^\s*"installdir"\s+"(.+?)"\s*$""", RegexOptions.Multiline)]
    private static partial Regex InstallDirRegex();
}
