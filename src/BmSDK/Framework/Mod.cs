using Tomlyn;
using Tomlyn.Model;

namespace BmSDK.Framework;

/// <summary>
/// Represents a loaded mod and its configuration.
/// </summary>
public sealed class Mod
{
    /// <summary>
    /// The display name of this mod, from mod.toml or the directory name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Full path to this mod's directory.
    /// </summary>
    public string DirectoryPath { get; }

    /// <summary>
    /// The full parsed mod.toml as a TOML table. Empty for the implicit Scripts mod.
    /// </summary>
    public TomlTable Config { get; }

    /// <summary>
    /// Values that survive a hot reload of this mod. A reload compiles a new assembly, so the mod's
    /// statics start over and its own types change identity; keep only BCL and BmSDK types here
    /// (numbers, strings, game object wrappers, collections of those), or the cast fails after a reload.
    /// </summary>
    public IDictionary<string, object?> State => GetState(DirectoryPath);

    private static readonly Dictionary<string, Dictionary<string, object?>> s_states = [];

    private static IDictionary<string, object?> GetState(string directoryPath)
    {
        lock (s_states)
        {
            if (!s_states.TryGetValue(directoryPath, out var state))
            {
                state = [];
                s_states[directoryPath] = state;
            }

            return state;
        }
    }

    internal Mod(string name, string directoryPath, TomlTable config)
    {
        Name = name;
        DirectoryPath = directoryPath;
        Config = config;
    }

    internal static Mod FromDirectory(string modDir)
    {
        var tomlPath = Path.Combine(modDir, "mod.toml");
        var tomlText = File.ReadAllText(tomlPath);
        var config = TomlSerializer.Deserialize<TomlTable>(tomlText)!;

        var name =
            (config.TryGetValue("name", out var nameObj) && nameObj is string nameStr)
                ? nameStr
                : Path.GetFileName(modDir)!;

        return new Mod(name, modDir, config);
    }

    internal static Mod CreateDefault(string scriptsDir)
    {
        return new Mod("Scripts", scriptsDir, []);
    }
}
