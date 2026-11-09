using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace BmSDK.Framework;

/// <summary>
/// Provides utility methods for ensuring conditions are met.
/// </summary>
public static class Guard
{
    [DebuggerHidden]
    public static bool Require(bool value, string? message = null)
    {
        if (!value)
        {
            throw new ArgumentException(message ?? "Got unexpected false");
        }

        return value;
    }

    [DebuggerHidden]
    public static int Bounds(int index, int count, string? message = null)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException(
                message ?? $"Index {index} is outside of the collections bounds (0 to {count - 1})"
            );
        }

        return index;
    }

    [DebuggerHidden]
    public static T NotNull<T>([NotNull] T? obj, string? message = null)
        where T : class
    {
        if (obj is null)
        {
            throw new ArgumentException(message ?? "Got unexpected null");
        }

        return obj;
    }

    [DebuggerHidden]
    public static T NotNull<T>([NotNull] T? obj, string? message = null)
        where T : struct
    {
        if (!obj.HasValue)
        {
            throw new ArgumentException(message ?? "Got unexpected null");
        }

        return obj.Value;
    }

    /// <summary>
    /// Throws when a wrapper's object is gone: destroyed or garbage collected by the game, so its
    /// <see cref="GameObject.Ptr"/> was cleared. Generated calls check this before running the function,
    /// since the engine would otherwise fault on a null object. Check <see cref="GameObject.IsValid"/>
    /// before using a wrapper you have kept hold of.
    /// </summary>
    [DebuggerHidden]
    public static void NotDestroyed(GameObject obj)
    {
        if (obj.Ptr == IntPtr.Zero)
        {
            throw new ObjectDisposedException(
                obj.GetType().Name,
                "The game object behind this wrapper has been destroyed; check IsValid before using it."
            );
        }
    }

    [DebuggerHidden]
    public static string NotNullOrWhitespace([NotNull] string? obj, string? message = null)
    {
        if (obj is null)
        {
            throw new ArgumentException(message ?? "Got unexpected null");
        }

        if (string.IsNullOrWhiteSpace(obj))
        {
            throw new ArgumentException(message ?? "Got unexpected whitespace");
        }

        return obj;
    }
}
