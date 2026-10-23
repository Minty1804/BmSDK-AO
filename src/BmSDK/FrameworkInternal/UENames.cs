namespace BmSDK.Framework;

/// <summary>
/// UE3 names (FName) are case-insensitive: the name table keeps the spelling of whichever object
/// registered the name first. Arkham Origins mixes spellings (e.g. BmScript.MHarpoonGunDk in its package,
/// MHarpoonGunDK in memory), so the text of a class or function path can change with load order.
/// Compare game paths with these helpers, never with ==.
/// </summary>
internal static class UENames
{
    public static readonly StringComparer Comparer = StringComparer.OrdinalIgnoreCase;

    public static bool Equal(string? a, string? b) => string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
}

/// <summary>Key comparer for (object pointer, function path) pairs.</summary>
internal sealed class ObjFuncKeyComparer : IEqualityComparer<(IntPtr ObjPtr, string FuncPath)>
{
    public static readonly ObjFuncKeyComparer Instance = new();

    public bool Equals((IntPtr ObjPtr, string FuncPath) x, (IntPtr ObjPtr, string FuncPath) y) =>
        x.ObjPtr == y.ObjPtr && UENames.Equal(x.FuncPath, y.FuncPath);

    public int GetHashCode((IntPtr ObjPtr, string FuncPath) obj) =>
        HashCode.Combine(obj.ObjPtr, UENames.Comparer.GetHashCode(obj.FuncPath));
}
