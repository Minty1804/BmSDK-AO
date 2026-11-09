#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MObjectStreaming<br/>
/// (size = 120)
/// (flags = 134217874)
/// </summary>
public partial class MObjectStreaming : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MObjectStreaming", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MObjectStreaming.
    /// </summary>
    public static MObjectStreaming DefaultObject => (MObjectStreaming)StaticClass().DefaultObject;

    internal MObjectStreaming() { }

    /// <summary>
    /// Constructs a new MObjectStreaming
    /// </summary>
    public MObjectStreaming(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MObjectStreaming Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MObjectStreaming(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MObjectStreaming>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MObjectStreaming>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MObjectStreaming>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MObjectStreaming>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MObjectStreaming>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MObjectStreaming>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MObjectStreaming>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MObjectStreaming>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetProperty;
    /// <summary>
    /// Function: SetProperty
    /// </summary>
    public unsafe static bool SetProperty(BmSDK.GameObject Owner, BmSDK.FName PropertyName, BmSDK.GameObject NewValue, BmSDK.Engine.MObjectStreaming.EArrayPropertyType ArrayOp)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetProperty, "Engine.MObjectStreaming.SetProperty");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Owner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrayOp, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_TerminateRequest;
    /// <summary>
    /// Function: TerminateRequest
    /// </summary>
    public unsafe virtual void TerminateRequest()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TerminateRequest, "Engine.MObjectStreaming.TerminateRequest");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_AsyncCancelLoading;
    /// <summary>
    /// Function: AsyncCancelLoading
    /// </summary>
    public unsafe virtual bool AsyncCancelLoading(BmSDK.Engine.MObjectStreaming.FObjectStreamingId Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AsyncCancelLoading, "Engine.MObjectStreaming.AsyncCancelLoading");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AsyncLoadPackage;
    /// <summary>
    /// Function: AsyncLoadPackage
    /// </summary>
    public unsafe virtual BmSDK.Engine.MObjectStreaming.FObjectStreamingId AsyncLoadPackage(BmSDK.FString PackageName, System.IntPtr OnCompletion, bool bPriority)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AsyncLoadPackage, "Engine.MObjectStreaming.AsyncLoadPackage");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnCompletion, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPriority, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.MObjectStreaming.FObjectStreamingId>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_AsyncLoadObject;
    /// <summary>
    /// Function: AsyncLoadObject
    /// </summary>
    public unsafe virtual BmSDK.Engine.MObjectStreaming.FObjectStreamingId AsyncLoadObject(BmSDK.FString PackageName, BmSDK.FString ObjectName, System.IntPtr OnCompletion, bool bPriority)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AsyncLoadObject, "Engine.MObjectStreaming.AsyncLoadObject");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnCompletion, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPriority, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.MObjectStreaming.FObjectStreamingId>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_CallPackageLoadCompleteDelegate;
    /// <summary>
    /// Function: CallPackageLoadCompleteDelegate
    /// </summary>
    public unsafe void CallPackageLoadCompleteDelegate(BmSDK.Engine.MObjectStreaming.FLoadingPackage Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CallPackageLoadCompleteDelegate, "Engine.MObjectStreaming.CallPackageLoadCompleteDelegate");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CallObjectLoadCompleteDelegate;
    /// <summary>
    /// Function: CallObjectLoadCompleteDelegate
    /// </summary>
    public unsafe void CallObjectLoadCompleteDelegate(BmSDK.Engine.MObjectStreaming.FLoadingObject Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CallObjectLoadCompleteDelegate, "Engine.MObjectStreaming.CallObjectLoadCompleteDelegate");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DummyPackageLoadCompletionDelegate;
    /// <summary>
    /// Function: DummyPackageLoadCompletionDelegate
    /// </summary>
    public unsafe virtual void DummyPackageLoadCompletionDelegate(BmSDK.Engine.MObjectStreaming.EStreamingResult Result, BmSDK.Package LoadedPackage, BmSDK.Engine.MObjectStreaming.FObjectStreamingId Id, BmSDK.FString PackageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DummyPackageLoadCompletionDelegate, "Engine.MObjectStreaming.DummyPackageLoadCompletionDelegate");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Result, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedPackage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DummyObjectLoadCompletionDelegate;
    /// <summary>
    /// Function: DummyObjectLoadCompletionDelegate
    /// </summary>
    public unsafe virtual void DummyObjectLoadCompletionDelegate(BmSDK.Engine.MObjectStreaming.EStreamingResult Result, BmSDK.GameObject LoadedObject, BmSDK.Engine.MObjectStreaming.FObjectStreamingId Id, BmSDK.FString PackageName, BmSDK.FString ObjectName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DummyObjectLoadCompletionDelegate, "Engine.MObjectStreaming.DummyObjectLoadCompletionDelegate");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Result, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedObject, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: LoadingObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MObjectStreaming.FLoadingObject> LoadingObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MObjectStreaming.FLoadingObject>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ArrayProperty: ResultingObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MObjectStreaming.FLoadingObject> ResultingObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MObjectStreaming.FLoadingObject>>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ArrayProperty: LoadingPackages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MObjectStreaming.FLoadingPackage> LoadingPackages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MObjectStreaming.FLoadingPackage>>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// ArrayProperty: ResultingPackages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MObjectStreaming.FLoadingPackage> ResultingPackages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MObjectStreaming.FLoadingPackage>>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// StructProperty: CriticalSection
    /// </summary>
    public unsafe System.IntPtr CriticalSection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// DelegateProperty: __DummyObjectLoadCompletionDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __DummyObjectLoadCompletionDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// DelegateProperty: __DummyPackageLoadCompletionDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __DummyPackageLoadCompletionDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// Struct: FLoadingPackage
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FLoadingPackage
    {
        /// <summary>
        /// StrProperty: PackageName
        /// </summary>
        public unsafe BmSDK.FString PackageName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// DelegateProperty: OnCompletion
        /// </summary>
        public unsafe System.IntPtr OnCompletion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: Id
        /// </summary>
        public unsafe BmSDK.Engine.MObjectStreaming.FObjectStreamingId Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MObjectStreaming.FObjectStreamingId>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ObjectProperty: LoadedPackage
        /// </summary>
        public unsafe BmSDK.Package LoadedPackage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Package>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ByteProperty: StreamingResult
        /// </summary>
        public unsafe BmSDK.Engine.MObjectStreaming.EStreamingResult StreamingResult
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MObjectStreaming.EStreamingResult>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FLoadingObject
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FLoadingObject
    {
        /// <summary>
        /// StrProperty: ObjectName
        /// </summary>
        public unsafe BmSDK.FString ObjectName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: PackageName
        /// </summary>
        public unsafe BmSDK.FString PackageName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// DelegateProperty: OnCompletion
        /// </summary>
        public unsafe System.IntPtr OnCompletion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: Id
        /// </summary>
        public unsafe BmSDK.Engine.MObjectStreaming.FObjectStreamingId Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MObjectStreaming.FObjectStreamingId>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ObjectProperty: LoadedObject
        /// </summary>
        public unsafe BmSDK.GameObject LoadedObject
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ByteProperty: StreamingResult
        /// </summary>
        public unsafe BmSDK.Engine.MObjectStreaming.EStreamingResult StreamingResult
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MObjectStreaming.EStreamingResult>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Struct: FObjectStreamingId
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FObjectStreamingId
    {
        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: EArrayPropertyType
    /// </summary>
    public enum EArrayPropertyType : byte
    {
        EAPT_None = 0,
        EAPT_ClearAndAdd = 1,
        EAPT_Add = 2,
        EAPT_MAX = 3,
    }

    /// <summary>
    /// Enum: EStreamingResult
    /// </summary>
    public enum EStreamingResult : byte
    {
        Streaming_Loaded = 0,
        Streaming_AlreadyLoaded = 1,
        Streaming_FailedCantLoadPackage = 2,
        Streaming_FailedCantFindObject = 3,
        Streaming_Canceled = 4,
        Streaming_MAX = 5,
    }
}

/// <summary>
/// The static native functions of MObjectStreaming, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class MObjectStreamingStatics
{
    private static BmSDK.Function __fn_SetProperty;
    /// <summary>
    /// Function: SetProperty, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static bool SetProperty(this BmSDK.Engine.MObjectStreaming self, BmSDK.GameObject Owner, BmSDK.FName PropertyName, BmSDK.GameObject NewValue, BmSDK.Engine.MObjectStreaming.EArrayPropertyType ArrayOp)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetProperty, "Engine.MObjectStreaming.SetProperty");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Owner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrayOp, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }
}
