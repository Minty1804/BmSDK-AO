namespace BmSDK.Framework;

/// <summary>
/// BmSDK-AO addition: path names of the UFunctions that run through UObject::ProcessInternal, cached per function
/// object. Building a path name walks the outer chain and allocates a string; ProcessInternal runs for every script
/// call, so it was done thousands of times a frame. Each entry also keeps the paths of the functions it overrides
/// (its super functions), for redirects with <see cref="RedirectAttribute.IncludeOverrides"/>.
/// An entry is checked against the object's name and outer on every use, so a function freed and replaced by
/// another one at the same address is recomputed.
/// </summary>
internal static unsafe class FunctionCache
{
    public sealed class Entry
    {
        public int NameIndex;
        public int NameNumber;
        public IntPtr Outer;

        /// <summary>Path of the function itself ("BmGame.RPlayerController:ShowHealthBar").</summary>
        public string Path = "";

        /// <summary>Paths of the functions it overrides, nearest first (empty for most).</summary>
        public string[] Supers = [];

        private IntPtr _label;

        /// <summary>The path as UTF-8, made on first use and never freed (the crash log reads it).</summary>
        public IntPtr Label => _label != IntPtr.Zero ? _label : _label = Marshal.StringToCoTaskMemUTF8(Path);
    }

    private static readonly Dictionary<IntPtr, Entry> s_entries = [];

    /// <summary>
    /// The UFunction a generated function wrapper calls, kept in that wrapper's own static field (ported from
    /// XeTrinityz/BmSDK-AK). Every generated call used to run StaticFindObject on its function's path string. A
    /// wrapper is invalidated (Ptr set to zero) when its object is destroyed, so a stale entry is looked up again.
    /// </summary>
    public static Function Get(ref Function? slot, string path)
    {
        var func = slot;
        if (func is not null && func.Ptr != IntPtr.Zero)
        {
            return func;
        }

        return slot = GameObject.StaticFindObjectChecked<Function>(Function.StaticClass(), null, path, true);
    }

    public static Entry Get(Function func)
    {
        var ptr = func.Ptr;
        var nameIndex = *(int*)(ptr + GameDefine.MemberOffsets.Object__Name);
        var nameNumber = *(int*)(ptr + GameDefine.MemberOffsets.Object__Name + 4);
        var outer = *(IntPtr*)(ptr + GameDefine.MemberOffsets.Object__Outer);
        if (
            s_entries.TryGetValue(ptr, out var e)
            && e.NameIndex == nameIndex
            && e.NameNumber == nameNumber
            && e.Outer == outer
        )
        {
            return e;
        }

        e = new Entry
        {
            NameIndex = nameIndex,
            NameNumber = nameNumber,
            Outer = outer,
            Path = func.GetPathName(),
        };
        var supers = new List<string>();
        var depth = 0;
        for (var super = func.SuperStruct; super != null && depth < 32; super = super.SuperStruct, depth++)
        {
            supers.Add(super.GetPathName());
        }
        e.Supers = [.. supers];
        s_entries[ptr] = e;
        return e;
    }
}
