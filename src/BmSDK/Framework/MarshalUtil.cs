using System.Reflection;

namespace BmSDK.Framework;

/// <summary>
/// Provides utility methods for converting data between unmanaged and managed
/// representations.
/// </summary>
public static unsafe class MarshalUtil
{
    [StructLayout(LayoutKind.Sequential)]
    private struct FScriptInterface
    {
        public IntPtr ObjectPointer;
        public IntPtr InterfacePointer;
    }

    private static readonly Dictionary<IntPtr, GameObject> s_managedObjects = [];

    // BmSDK-AO: addresses of objects the game destroyed, until a new object is created there. Some object
    // references are never cleared by the GC (native transient ones, such as ActorComponent.Owner): a component that
    // outlives its actor still points at the freed actor, and wrapping that pointer reads freed memory (Ultimate UI
    // AO, crash on level load right after Ultimate Suit Selector put the suit back, 2026-11-05). Such a reference
    // reads as null, which is what the game's script would see once the GC had cleared it.
    // The set spares reading freed memory for recent objects. It was capped at 250,000 and then stopped guarding
    // (reached after returning to the main menu: user's log, 2026-11-08); now it is emptied when full, and every
    // pointer without a wrapper is also checked against the game's object table (IsLiveObject), which has no limit.
    private static readonly HashSet<IntPtr> s_destroyed = [];
    private const int MaxDestroyed = 250_000; // 32-bit process short of memory: emptied beyond this (tested with 5,000 on 2026-11-09)
    private static int s_destroyedResets;

    /// <summary>
    /// BmSDK-AO: whether <paramref name="objPtr"/> is in GObjObjects at its own index, i.e. a live object. A destroyed
    /// object's slot is cleared or holds another object. An index below 0 (objects of static registration) passes.
    /// </summary>
    private static bool IsLiveObject(IntPtr objPtr)
    {
        var index = *(int*)(objPtr + GameDefine.MemberOffsets.Object__ObjectInternalInteger).ToPointer();
        if (index < 0)
        {
            return true;
        }
        var objects = MemUtil.GetPointer<IntPtr>(GameDefine.Current.GObjObjects);
        var data = (IntPtr*)objects[0];
        var num = ((int*)objects)[1];
        return data != null && index < num && data[index] == objPtr;
    }

    /// <summary>A new object was created at <paramref name="objPtr"/> (UObject::AddObject).</summary>
    internal static void NoteCreated(IntPtr objPtr) => s_destroyed.Remove(objPtr);

    /// <summary>Classes already reported as unknown, so each is logged once rather than per object.</summary>
    private static readonly HashSet<string> s_unknownClassesLogged = [];

    /// <summary>
    /// Marshals unmanaged data to managed, then returns it.
    /// </summary>
    public static TManaged ToManaged<TManaged>(void* data)
    {
        // Try to copy memory directly (for struct, primitive types)
        if (typeof(TManaged).IsValueType)
        {
            return MemUtil.Blit<TManaged>(data);
        }
        else if (
            typeof(TManaged).IsGenericType
            && typeof(TManaged).GetGenericTypeDefinition() == typeof(TArray<>)
        )
        {
            // Create new TArray wrapper every time - duplicates will still refer to the same native object.
            var instance = Guard.NotNull(
                Activator.CreateInstance(
                    typeof(TManaged),
                    BindingFlags.Instance | BindingFlags.NonPublic,
                    null,
                    [(IntPtr)data],
                    null
                ),
                $"Couldn't create an instance of array 0x{new IntPtr(data):X}"
            );

            return (TManaged)instance;
        }
        else if (
            typeof(TManaged).IsAssignableTo(typeof(GameObject))
            || typeof(TManaged).IsAssignableTo(typeof(Interface))
        )
        {
            var objPtr = MemUtil.Blit<IntPtr>(data);

            // Handle null object pointers, and dangling ones to destroyed objects (BmSDK-AO).
            if (objPtr == IntPtr.Zero || s_destroyed.Contains(objPtr))
            {
                return (TManaged)(object)null!;
            }
            if (s_managedObjects.TryGetValue(objPtr, out var wrapped))
            {
                return (TManaged)(object)wrapped;
            }
            if (!IsLiveObject(objPtr))
            {
                return (TManaged)(object)null!;
            }

            // Get or create a managed wrapper for the UObject
            return (TManaged)(object)Guard.NotNull(GetOrCreateWrapper(objPtr));
        }

        throw new NotImplementedException(
            $"Marshaling not (fully) implemented for type {typeof(TManaged).Name}"
        );
    }

    public static TManaged ToManaged<TManaged>(IntPtr data) =>
        ToManaged<TManaged>(data.ToPointer());

    /// <summary>
    /// Marshals an out or return parameter from a function call's parameter buffer.
    /// </summary>
    /// <remarks>
    /// The parameter buffer only lives for the duration of the call, so a <see cref="TArray{T}"/>
    /// can't wrap it the way it wraps a property in object memory: its header is copied into
    /// memory kept alive by the new wrapper instead. Its elements are not freed by the wrapper
    /// (as before). Every other type marshals exactly like <see cref="ToManaged{TManaged}(void*)"/>.
    /// </remarks>
    public static TManaged ToManagedParam<TManaged>(void* data)
    {
        if (
            typeof(TManaged).IsGenericType
            && typeof(TManaged).GetGenericTypeDefinition() == typeof(TArray<>)
        )
        {
            var instance = Guard.NotNull(
                Activator.CreateInstance(
                    typeof(TManaged),
                    BindingFlags.Instance | BindingFlags.NonPublic,
                    null,
                    [(IntPtr)data, true],
                    null
                ),
                $"Couldn't copy array parameter 0x{new IntPtr(data):X}"
            );

            return (TManaged)instance;
        }

        return ToManaged<TManaged>(data);
    }

    /// <summary>
    /// Boxing adapters over the generic marshallers, one instantiation per type, so marshalling by
    /// <see cref="Type"/> (redirect arguments and results) costs a dictionary lookup and a delegate call
    /// rather than reflection on every call.
    /// </summary>
    private static class Boxed<T>
    {
        public static object? To(IntPtr data) => ToManaged<T>(data);

        public static void From(object? value, IntPtr data) => ToUnmanaged((T)value!, data);
    }

    private static readonly Dictionary<Type, Func<IntPtr, object?>> s_toManagedByType = [];
    private static readonly Dictionary<Type, Action<object?, IntPtr>> s_toUnmanagedByType = [];

    /// <summary>Marshals unmanaged data to a managed value of a type only known at run time.</summary>
    public static object? ToManaged(IntPtr data, Type managedType)
    {
        if (!s_toManagedByType.TryGetValue(managedType, out var marshal))
        {
            marshal = typeof(Boxed<>)
                .MakeGenericType(managedType)
                .GetMethod(nameof(Boxed<int>.To), BindingFlags.Public | BindingFlags.Static)!
                .CreateDelegate<Func<IntPtr, object?>>();
            s_toManagedByType[managedType] = marshal;
        }

        return marshal(data);
    }

    /// <summary>
    /// Marshals a managed object to native, then copies it into an existing buffer.
    /// </summary>
    public static void ToUnmanaged<TManaged>(TManaged value, void* data)
    {
        // Try to copy memory directly (for struct, primitive types)
        if (typeof(TManaged).IsValueType)
        {
            MemUtil.Blit(value, data);
            return;
        }
        else if (
            typeof(TManaged).IsGenericType
            && typeof(TManaged).GetGenericTypeDefinition() == typeof(TArray<>)
        )
        {
            var dataSize = sizeof(TArray<TManaged>.NativeData);

            if (value is null || data == null)
            {
                // Clear native struct memory
                NativeMemory.Clear(data, (nuint)dataSize);
                return;
            }

            // Copy native struct memory
            var sourcePtr = ((IArray)value).Ptr;
            Buffer.MemoryCopy(sourcePtr.ToPointer(), data, dataSize, dataSize);
            return;
        }
        else if (typeof(TManaged).IsAssignableTo(typeof(GameObject)))
        {
            // Handle null object references.
            if (value is null)
            {
                ToUnmanaged(IntPtr.Zero, data);
                return;
            }

            // We already have a pointer to this object's native instance, so just assign it.
            ToUnmanaged(((GameObject)(object)value!).Ptr, data);
            return;
        }

        throw new NotImplementedException(
            $"Marshaling not (fully) implemented for type {typeof(TManaged).Name}"
        );
    }

    public static void ToUnmanaged<TManaged>(TManaged value, IntPtr data) =>
        ToUnmanaged(value, data.ToPointer());

    /// <summary>Marshals a managed value of a type only known at run time into an existing buffer.</summary>
    public static void ToUnmanaged(object? value, IntPtr data, Type managedType)
    {
        if (!s_toUnmanagedByType.TryGetValue(managedType, out var marshal))
        {
            marshal = typeof(Boxed<>)
                .MakeGenericType(managedType)
                .GetMethod(nameof(Boxed<int>.From), BindingFlags.Public | BindingFlags.Static)!
                .CreateDelegate<Action<object?, IntPtr>>();
            s_toUnmanagedByType[managedType] = marshal;
        }

        marshal(value, data);
    }

    /// <summary>
    /// Gets the managed wrapper instance corresponding to the given unmanaged pointer.
    /// </summary>
    /// <remarks>
    /// This function is useful when working with native redirects. It allows one to
    /// easily convert this-pointers to the actual instances in BmSDK.
    /// </remarks>
    /// <param name="objPtr">Pointer to unmanaged object</param>
    /// <returns>Managed wrapper of unmanaged pointer</returns>
    internal static GameObject GetOrCreateWrapper(IntPtr objPtr)
    {
        // Get cached object wrapper
        if (s_managedObjects.TryGetValue(objPtr, out var existingObj))
        {
            return existingObj;
        }

        // Objects from static registration whose class has registered since get their real wrapper now.
        if (s_pendingEarly.Count > 0)
        {
            WrapPendingEarly();
            if (s_managedObjects.TryGetValue(objPtr, out existingObj))
            {
                return existingObj;
            }
        }

        var classPtr = *(IntPtr*)(objPtr + GameDefine.MemberOffsets.Object__Class).ToPointer();

        // An object created during static registration, before its own class was registered: the
        // class's Index is still INDEX_NONE and its Name and Outer aren't set yet, so it can't be
        // identified. In AK that is 73 objects: the 44 intrinsic classes registered before Core.Class
        // itself, the Core package (before Core.Package) and Core.System's default properties (before
        // the property classes). Such an object is remembered and wrapped, with the right type, by the
        // first call after its class has registered. (Caching a Class-typed wrapper here, as before,
        // left the Core package wrapped as a Class for the whole session, so every Core.* path printed
        // as "Core:Object:X" and no redirect on a Core function ever matched.)
        if (ClassIndex(classPtr) < 0)
        {
            s_pendingEarly.Add(objPtr);
            var early = (GameObject)Activator.CreateInstance(typeof(GameObject), true)!;
            early.Ptr = objPtr;
            return early;
        }

        return CreateManagedWrapper(objPtr, WrapperTypeFor(classPtr));
    }

    /// <summary>Objects created before their class was registered, waiting for their real wrapper.</summary>
    private static readonly List<IntPtr> s_pendingEarly = [];

    private static int ClassIndex(IntPtr classPtr) =>
        *(int*)(classPtr + GameDefine.MemberOffsets.Object__ObjectInternalInteger).ToPointer();

    private static void WrapPendingEarly()
    {
        for (var i = s_pendingEarly.Count - 1; i >= 0; i--)
        {
            var objPtr = s_pendingEarly[i];
            var classPtr = *(IntPtr*)(objPtr + GameDefine.MemberOffsets.Object__Class).ToPointer();
            if (ClassIndex(classPtr) < 0)
            {
                continue;
            }

            s_pendingEarly.RemoveAt(i);
            if (!s_managedObjects.ContainsKey(objPtr))
            {
                CreateManagedWrapper(objPtr, WrapperTypeFor(classPtr));
            }
        }
    }

    /// <summary>
    /// The managed type (and its constructor) for a class, worked out once per class: every object the
    /// game creates comes through here, and building the class path string each time was a large share
    /// of the garbage behind the streaming stutter.
    /// </summary>
    private static WrapperType WrapperTypeFor(IntPtr classPtr)
    {
        if (!s_wrapperTypes.TryGetValue(classPtr, out var wrapperType))
        {
            var classFlags = *(Class.EClassFlags*)(classPtr + GameDefine.MemberOffsets.Class__ClassFlags).ToPointer();
            var managedType = !classFlags.HasFlag(Class.EClassFlags.CLASS_Interface)
                ? GetManagedTypeForClassPtr(classPtr)
                : typeof(GameObject); // Wrap CDOs of interfaces as GameObject
            wrapperType = new WrapperType(managedType, MakeFactory(managedType));
            s_wrapperTypes[classPtr] = wrapperType;
        }

        return wrapperType;
    }

    private sealed record WrapperType(Type ManagedType, Func<GameObject> Factory);

    /// <summary>Wrapper type and constructor per UClass; an entry is dropped when its class is destroyed.</summary>
    private static readonly Dictionary<IntPtr, WrapperType> s_wrapperTypes = [];

    private static Func<GameObject> MakeFactory(Type managedType)
    {
        var ctor = managedType.GetConstructor(
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
            Type.EmptyTypes
        );
        Guard.NotNull(ctor, $"Managed type {managedType.Name} has no parameterless constructor");

        return System.Linq.Expressions.Expression
            .Lambda<Func<GameObject>>(System.Linq.Expressions.Expression.New(ctor))
            .Compile();
    }

    /// <summary>
    /// Gets the managed type for the given unmanaged class. Classes that didn't exist at generation
    /// time fall back to the closest known type in their super chain.
    /// </summary>
    internal static Type GetManagedTypeForClassPtr(IntPtr classPtr)
    {
        var classPath = GetClassPath(classPtr);

        if (StaticInit.TryGetManagedTypeForClassPath(classPath, out var managedType))
        {
            return managedType;
        }

        // Class didn't exist at generation time, so walk up the super chain until we find one that did.
        for (
            var superPtr = GetSuperStruct(classPtr);
            superPtr != IntPtr.Zero;
            superPtr = GetSuperStruct(superPtr)
        )
        {
            if (StaticInit.TryGetManagedTypeForClassPath(GetClassPath(superPtr), out var superType))
            {
                if (s_unknownClassesLogged.Add(classPath))
                {
                    Debug.LogWarning(
                        $"Couldn't find managed type for class '{classPath}', falling back to {superType.FullName}"
                    );
                }
                return superType;
            }
        }

        if (s_unknownClassesLogged.Add(classPath))
        {
            Debug.LogWarning($"Couldn't find managed type for class '{classPath}'");
        }
        return typeof(GameObject);
    }

    private static IntPtr GetSuperStruct(IntPtr structPtr) =>
        *(IntPtr*)(structPtr + GameDefine.MemberOffsets.Struct__SuperStruct).ToPointer();

    private static GameObject CreateManagedWrapper(IntPtr objPtr, WrapperType wrapperType)
    {
        // Create a new managed object
        var newObj = s_managedObjects[objPtr] = wrapperType.Factory();
        newObj.Ptr = objPtr;
        FindObjectsCache.Register(newObj);
        return newObj;
    }

    private static string GetClassPath(IntPtr classPtr)
    {
        // Fetch class name.
        var className = *(FName*)(classPtr + GameDefine.MemberOffsets.Object__Name).ToPointer();

        // Fetch outer name.
        var classOuterPtr = *(IntPtr*)(classPtr + GameDefine.MemberOffsets.Object__Outer).ToPointer();
        var classOuterName = *(FName*)
            (classOuterPtr + GameDefine.MemberOffsets.Object__Name).ToPointer();

        return $"{classOuterName}.{className}";
    }

    /// <summary>
    /// Returns a ref to unmanaged data at the specified address.
    /// </summary>
    internal static ref T AsRef<T>(IntPtr data)
        where T : unmanaged => ref *(T*)data.ToPointer();

    internal static int GetSizeUnmanaged<TManaged>()
    {
        // Try to use managed size directly (for struct, primitive types)
        if (typeof(TManaged).IsValueType)
        {
            return Marshal.SizeOf<TManaged>();
        }
        // Return UE3 internal interface wrapper size
        else if (typeof(TManaged).IsInterface)
        {
            return sizeof(FScriptInterface);
        }
        // Return size of UObject pointer
        else if (typeof(TManaged).IsAssignableTo(typeof(GameObject)))
        {
            return sizeof(IntPtr);
        }

        throw new NotImplementedException(
            $"Marshaling not (fully) implemented for type {typeof(TManaged).Name}"
        );
    }

    internal static void DestroyManagedWrapper(IntPtr objPtr)
    {
        if (s_destroyed.Count >= MaxDestroyed)
        {
            // Older ones are still caught by IsLiveObject
            s_destroyed.Clear();
            if (s_destroyedResets++ == 0)
            {
                Debug.Log($"{MaxDestroyed} destroyed objects remembered: list emptied (checked against the object table from now on)");
            }
        }
        s_destroyed.Add(objPtr);

        if (s_pendingEarly.Count > 0)
        {
            s_pendingEarly.Remove(objPtr);
        }

        if (s_managedObjects.TryGetValue(objPtr, out var obj))
        {
            FindObjectsCache.Unregister(obj);

            // Detach all script components
            if (obj.HasScriptComponents)
            {
                obj.DetachAllScriptComponents();
            }

            // A class is going away: its address may be reused by another class later.
            if (obj is Class)
            {
                s_wrapperTypes.Remove(objPtr);
            }

            // Mark managed wrapper as invalid
            obj.Ptr = IntPtr.Zero;

            // Remove managed wrapper from storage
            s_managedObjects.Remove(objPtr);
        }
    }
}
