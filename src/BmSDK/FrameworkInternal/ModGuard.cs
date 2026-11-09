namespace BmSDK.Framework;

/// <summary>
/// Runs mod code (lifecycle callbacks, redirects) so that an exception is logged and the game keeps
/// running. Before this, any exception escaping a mod callback ended the process.
/// </summary>
/// <remarks>
/// A callback that keeps failing is switched off after <see cref="MaxConsecutiveFailures"/> failures
/// in a row (a broken OnTick would otherwise log sixty errors a second), and switched back on when
/// any mod reloads. A success resets the count. Exceptions inside BmSDK's own detour code are not
/// handled here: there the state may be corrupt, and the process still exits.
/// </remarks>
internal static class ModGuard
{
    public const int MaxConsecutiveFailures = 10;

    // Keyed by the script or component INSTANCE plus the callback name: a Script's Name is not unique
    // (it defaults to the source file, which may hold several scripts).
    private static readonly Dictionary<(object Owner, string What), int> s_failures = [];
    private static readonly HashSet<(object Owner, string What)> s_disabled = [];

    /// <summary>
    /// Runs <paramref name="action"/>, a callback <paramref name="what"/> of <paramref name="owner"/>,
    /// with <paramref name="sender"/> as the log sender. Returns false if it threw, or is switched off.
    /// </summary>
    public static bool Run(object owner, string sender, string what, Action action)
    {
        var key = (owner, what);
        if (s_disabled.Contains(key))
        {
            return false;
        }

        Debug.PushSender(sender);
        var prevContext = CrashContext.Enter(sender, action.Method); // BmSDK-AO: for the crash log
        try
        {
            action();
            if (s_failures.Count > 0)
            {
                s_failures.Remove(key);
            }
            return true;
        }
        catch (Exception ex)
        {
            Report(key, ex, what);
            return false;
        }
        finally
        {
            CrashContext.Leave(prevContext);
            Debug.PopSender();
        }
    }

    /// <summary>Whether <paramref name="what"/> of <paramref name="owner"/> has been switched off.</summary>
    public static bool IsDisabled(object owner, string what) => s_disabled.Contains((owner, what));

    /// <summary>Logs an exception that mod code threw, counting towards switching that code off.</summary>
    public static void Report(object owner, string sender, string what, Exception ex, string? describe = null)
    {
        Debug.PushSender(sender);
        try
        {
            Report((owner, what), ex, describe ?? what);
        }
        finally
        {
            Debug.PopSender();
        }
    }

    /// <summary>Forgets every failure and re-enables everything. Called on mod (re)load.</summary>
    public static void Reset()
    {
        s_failures.Clear();
        s_disabled.Clear();
    }

    private static void Report((object Owner, string What) key, Exception ex, string describe)
    {
        var count = s_failures.GetValueOrDefault(key) + 1;
        s_failures[key] = count;

        // The first line reaches the on-screen overlay; the stack trace goes to the log only.
        Debug.LogError($"{describe} threw {ex.GetType().Name}: {ex.Message}");
        if (ex.StackTrace is { } trace)
        {
            Debug.Log(trace, skipSender: true);
        }

        if (count >= MaxConsecutiveFailures)
        {
            s_disabled.Add(key);
            s_failures.Remove(key);
            Debug.LogError(
                $"{describe} failed {count} times in a row and is switched off until the mod reloads."
            );
        }
    }
}
