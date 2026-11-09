#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MGFxWidget<br/>
/// (size = 236)
/// (flags = 134217874)
/// </summary>
public partial class MGFxWidget : BmSDK.GFxUI.GFxObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MGFxWidget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGFxWidget.
    /// </summary>
    public static MGFxWidget DefaultObject => (MGFxWidget)StaticClass().DefaultObject;

    internal MGFxWidget() { }

    /// <summary>
    /// Constructs a new MGFxWidget
    /// </summary>
    public MGFxWidget(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxWidget Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxWidget(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidget>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidget>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidget>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidget>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidget>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidget>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidget>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidget>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ReleaseAllStreamedPackageReference;
    /// <summary>
    /// Function: ReleaseAllStreamedPackageReference
    /// </summary>
    public unsafe virtual void ReleaseAllStreamedPackageReference()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseAllStreamedPackageReference, "BmGame.MGFxWidget.ReleaseAllStreamedPackageReference");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseStreamedPackageReference;
    /// <summary>
    /// Function: ReleaseStreamedPackageReference
    /// </summary>
    public unsafe virtual void ReleaseStreamedPackageReference(BmSDK.FString PackageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseStreamedPackageReference, "BmGame.MGFxWidget.ReleaseStreamedPackageReference");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PackageStreamFailed;
    /// <summary>
    /// Function: PackageStreamFailed
    /// </summary>
    public unsafe virtual void PackageStreamFailed(BmSDK.FString Package)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PackageStreamFailed, "BmGame.MGFxWidget.PackageStreamFailed");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Package, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PackageStreamSucceeded;
    /// <summary>
    /// Function: PackageStreamSucceeded
    /// </summary>
    public unsafe virtual void PackageStreamSucceeded(BmSDK.FString PackageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PackageStreamSucceeded, "BmGame.MGFxWidget.PackageStreamSucceeded");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReferencesToObjectsInPackage;
    /// <summary>
    /// Function: AddReferencesToObjectsInPackage
    /// </summary>
    public unsafe virtual void AddReferencesToObjectsInPackage(BmSDK.Package StreamedPackage, int streamedPackagesIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReferencesToObjectsInPackage, "BmGame.MGFxWidget.AddReferencesToObjectsInPackage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StreamedPackage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(streamedPackagesIndex, paramsPtr + 4);
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

    private static BmSDK.Function __fn_PackageStreamed;
    /// <summary>
    /// Function: PackageStreamed
    /// </summary>
    public unsafe virtual void PackageStreamed(BmSDK.Engine.MObjectStreaming.EStreamingResult Result, BmSDK.Package StreamedPackage, BmSDK.Engine.MObjectStreaming.FObjectStreamingId Id, BmSDK.FString PackageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PackageStreamed, "BmGame.MGFxWidget.PackageStreamed");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Result, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StreamedPackage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StreamPackage;
    /// <summary>
    /// Function: StreamPackage
    /// </summary>
    public unsafe virtual void StreamPackage(BmSDK.FString PackageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StreamPackage, "BmGame.MGFxWidget.StreamPackage");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseAllStreamedObjectReference;
    /// <summary>
    /// Function: ReleaseAllStreamedObjectReference
    /// </summary>
    public unsafe virtual void ReleaseAllStreamedObjectReference()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseAllStreamedObjectReference, "BmGame.MGFxWidget.ReleaseAllStreamedObjectReference");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseStreamedObjectReference;
    /// <summary>
    /// Function: ReleaseStreamedObjectReference
    /// </summary>
    public unsafe virtual void ReleaseStreamedObjectReference(BmSDK.FString ObjectName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseStreamedObjectReference, "BmGame.MGFxWidget.ReleaseStreamedObjectReference");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ObjectStreamFailed;
    /// <summary>
    /// Function: ObjectStreamFailed
    /// </summary>
    public unsafe virtual void ObjectStreamFailed(BmSDK.FString ObjectName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObjectStreamFailed, "BmGame.MGFxWidget.ObjectStreamFailed");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ObjectStreamSucceeded;
    /// <summary>
    /// Function: ObjectStreamSucceeded
    /// </summary>
    public unsafe virtual void ObjectStreamSucceeded(BmSDK.FString ObjectName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObjectStreamSucceeded, "BmGame.MGFxWidget.ObjectStreamSucceeded");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ObjectStreamed;
    /// <summary>
    /// Function: ObjectStreamed
    /// </summary>
    public unsafe virtual void ObjectStreamed(BmSDK.Engine.MObjectStreaming.EStreamingResult Result, BmSDK.GameObject StreamedObject, BmSDK.Engine.MObjectStreaming.FObjectStreamingId Id, BmSDK.FString PackageName, BmSDK.FString ObjectName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObjectStreamed, "BmGame.MGFxWidget.ObjectStreamed");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Result, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StreamedObject, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StreamObject;
    /// <summary>
    /// Function: StreamObject
    /// </summary>
    public unsafe virtual void StreamObject(BmSDK.FString ObjectName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StreamObject, "BmGame.MGFxWidget.StreamObject");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TweenEnd;
    /// <summary>
    /// Function: TweenEnd
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGFxWidget TweenEnd(bool premise)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TweenEnd, "BmGame.MGFxWidget.TweenEnd");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(premise, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MGFxWidget>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TweenFromInternal;
    /// <summary>
    /// Function: TweenFromInternal
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGFxWidget TweenFromInternal(BmSDK.GFxUI.GFxObject propsFrom, BmSDK.FString Duration, BmSDK.GFxUI.GFxObject easeFunc, BmSDK.GFxUI.GFxObject endCallback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TweenFromInternal, "BmGame.MGFxWidget.TweenFromInternal");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(propsFrom, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(easeFunc, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(endCallback, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MGFxWidget>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_TweenFrom;
    /// <summary>
    /// Function: TweenFrom
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGFxWidget TweenFrom(BmSDK.GFxUI.GFxObject propsFrom, BmSDK.FString Duration, System.IntPtr easeFunc, System.IntPtr endCallback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TweenFrom, "BmGame.MGFxWidget.TweenFrom");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(propsFrom, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(easeFunc, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(endCallback, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MGFxWidget>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_TweenToInternal;
    /// <summary>
    /// Function: TweenToInternal
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGFxWidget TweenToInternal(BmSDK.GFxUI.GFxObject propsTo, BmSDK.FString Duration, BmSDK.GFxUI.GFxObject easeFunc, BmSDK.GFxUI.GFxObject endCallback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TweenToInternal, "BmGame.MGFxWidget.TweenToInternal");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(propsTo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(easeFunc, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(endCallback, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MGFxWidget>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_TweenTo;
    /// <summary>
    /// Function: TweenTo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGFxWidget TweenTo(BmSDK.GFxUI.GFxObject propsTo, BmSDK.FString Duration, System.IntPtr easeFunc, System.IntPtr endCallback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TweenTo, "BmGame.MGFxWidget.TweenTo");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(propsTo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(easeFunc, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(endCallback, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MGFxWidget>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_clearTimeout;
    /// <summary>
    /// Function: clearTimeout
    /// </summary>
    public unsafe virtual void clearTimeout(float Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_clearTimeout, "BmGame.MGFxWidget.clearTimeout");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_setTimeoutInternal;
    /// <summary>
    /// Function: setTimeoutInternal
    /// </summary>
    public unsafe virtual float setTimeoutInternal(BmSDK.GFxUI.GFxObject func, int durationMs)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_setTimeoutInternal, "BmGame.MGFxWidget.setTimeoutInternal");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(func, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(durationMs, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_setTimeout;
    /// <summary>
    /// Function: setTimeout
    /// </summary>
    public unsafe virtual float setTimeout(System.IntPtr Listener, int durationMs)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_setTimeout, "BmGame.MGFxWidget.setTimeout");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Listener, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(durationMs, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_clearInterval;
    /// <summary>
    /// Function: clearInterval
    /// </summary>
    public unsafe virtual void clearInterval(float Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_clearInterval, "BmGame.MGFxWidget.clearInterval");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_setInterval;
    /// <summary>
    /// Function: setInterval
    /// </summary>
    public unsafe virtual float setInterval(BmSDK.GFxUI.GFxObject O, BmSDK.FString MethodName, int durationMs)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_setInterval, "BmGame.MGFxWidget.setInterval");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MethodName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(durationMs, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_setIntervalDelegate;
    /// <summary>
    /// Function: setIntervalDelegate
    /// </summary>
    public unsafe virtual int setIntervalDelegate(System.IntPtr Listener, int durationMs)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_setIntervalDelegate, "BmGame.MGFxWidget.setIntervalDelegate");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Listener, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(durationMs, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_setEnterFrameListener;
    /// <summary>
    /// Function: setEnterFrameListener
    /// </summary>
    public unsafe virtual void setEnterFrameListener(System.IntPtr Listener)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_setEnterFrameListener, "BmGame.MGFxWidget.setEnterFrameListener");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Listener, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ASUnloadClip;
    /// <summary>
    /// Function: ASUnloadClip
    /// </summary>
    public unsafe virtual bool ASUnloadClip(BmSDK.GFxUI.GFxObject Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ASUnloadClip, "BmGame.MGFxWidget.ASUnloadClip");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ASLoadClip;
    /// <summary>
    /// Function: ASLoadClip
    /// </summary>
    public unsafe virtual bool ASLoadClip(BmSDK.FString Path, BmSDK.GFxUI.GFxObject Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ASLoadClip, "BmGame.MGFxWidget.ASLoadClip");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_setLoadStartListener;
    /// <summary>
    /// Function: setLoadStartListener
    /// </summary>
    public unsafe virtual void setLoadStartListener(BmSDK.GFxUI.GFxObject O, System.IntPtr Listener)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_setLoadStartListener, "BmGame.MGFxWidget.setLoadStartListener");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Listener, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_setLoadProgressListener;
    /// <summary>
    /// Function: setLoadProgressListener
    /// </summary>
    public unsafe virtual void setLoadProgressListener(BmSDK.GFxUI.GFxObject O, System.IntPtr Listener)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_setLoadProgressListener, "BmGame.MGFxWidget.setLoadProgressListener");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Listener, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_setLoadInitListener;
    /// <summary>
    /// Function: setLoadInitListener
    /// </summary>
    public unsafe virtual void setLoadInitListener(BmSDK.GFxUI.GFxObject O, System.IntPtr Listener)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_setLoadInitListener, "BmGame.MGFxWidget.setLoadInitListener");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Listener, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_setLoadErrorListener;
    /// <summary>
    /// Function: setLoadErrorListener
    /// </summary>
    public unsafe virtual void setLoadErrorListener(BmSDK.GFxUI.GFxObject O, System.IntPtr Listener)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_setLoadErrorListener, "BmGame.MGFxWidget.setLoadErrorListener");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Listener, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLoadCompleteListener;
    /// <summary>
    /// Function: SetLoadCompleteListener
    /// </summary>
    public unsafe virtual void SetLoadCompleteListener(BmSDK.GFxUI.GFxObject O, System.IntPtr Listener)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLoadCompleteListener, "BmGame.MGFxWidget.SetLoadCompleteListener");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Listener, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterFrameEvent;
    /// <summary>
    /// Function: EnterFrameEvent
    /// </summary>
    public unsafe virtual void EnterFrameEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterFrameEvent, "BmGame.MGFxWidget.EnterFrameEvent");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadClipLoadStartEvent;
    /// <summary>
    /// Function: LoadClipLoadStartEvent
    /// </summary>
    public unsafe virtual void LoadClipLoadStartEvent(BmSDK.GFxUI.GFxObject target_mc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadClipLoadStartEvent, "BmGame.MGFxWidget.LoadClipLoadStartEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_mc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadClipLoadProgressEvent;
    /// <summary>
    /// Function: LoadClipLoadProgressEvent
    /// </summary>
    public unsafe virtual void LoadClipLoadProgressEvent(BmSDK.GFxUI.GFxObject target_mc, int loadedBytes, int totalBytes)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadClipLoadProgressEvent, "BmGame.MGFxWidget.LoadClipLoadProgressEvent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_mc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(loadedBytes, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(totalBytes, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadClipInitEvent;
    /// <summary>
    /// Function: LoadClipInitEvent
    /// </summary>
    public unsafe virtual void LoadClipInitEvent(BmSDK.GFxUI.GFxObject target_mc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadClipInitEvent, "BmGame.MGFxWidget.LoadClipInitEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_mc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadClipErrorEvent;
    /// <summary>
    /// Function: LoadClipErrorEvent
    /// </summary>
    public unsafe virtual void LoadClipErrorEvent(BmSDK.GFxUI.GFxObject target_mc, BmSDK.FString ErrorCode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadClipErrorEvent, "BmGame.MGFxWidget.LoadClipErrorEvent");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_mc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ErrorCode, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadClipCompleteEvent;
    /// <summary>
    /// Function: LoadClipCompleteEvent
    /// </summary>
    public unsafe virtual void LoadClipCompleteEvent(BmSDK.GFxUI.GFxObject listenerObject, BmSDK.GFxUI.GFxObject target_mc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadClipCompleteEvent, "BmGame.MGFxWidget.LoadClipCompleteEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(listenerObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_mc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ASRemoveListener;
    /// <summary>
    /// Function: ASRemoveListener
    /// </summary>
    public unsafe virtual void ASRemoveListener(BmSDK.GFxUI.GFxObject O)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ASRemoveListener, "BmGame.MGFxWidget.ASRemoveListener");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddListener;
    /// <summary>
    /// Function: AddListener
    /// </summary>
    public unsafe virtual void AddListener(BmSDK.GFxUI.GFxObject O)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddListener, "BmGame.MGFxWidget.AddListener");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DispatchEvent;
    /// <summary>
    /// Function: DispatchEvent
    /// </summary>
    public unsafe void DispatchEvent(BmSDK.GFxUI.GFxObject O)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DispatchEvent, "BmGame.MGFxWidget.DispatchEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ASRemoveAllEventListeners;
    /// <summary>
    /// Function: ASRemoveAllEventListeners
    /// </summary>
    public unsafe void ASRemoveAllEventListeners(BmSDK.FString Event)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ASRemoveAllEventListeners, "BmGame.MGFxWidget.ASRemoveAllEventListeners");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ASAddEventListener;
    /// <summary>
    /// Function: ASAddEventListener
    /// </summary>
    public unsafe void ASAddEventListener(BmSDK.FString Type, BmSDK.GFxUI.GFxObject O, BmSDK.FString func)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ASAddEventListener, "BmGame.MGFxWidget.ASAddEventListener");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(func, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetListener;
    /// <summary>
    /// Function: SetListener
    /// </summary>
    public unsafe void SetListener(BmSDK.GFxUI.GFxObject O, BmSDK.FString Member, System.IntPtr Listener)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetListener, "BmGame.MGFxWidget.SetListener");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Member, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Listener, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClose;
    /// <summary>
    /// Function: OnClose
    /// </summary>
    public unsafe virtual void OnClose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClose, "BmGame.MGFxWidget.OnClose");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LateBindSubWidget;
    /// <summary>
    /// Function: LateBindSubWidget
    /// </summary>
    public unsafe virtual void LateBindSubWidget(BmSDK.FName N, BmSDK.Class C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LateBindSubWidget, "BmGame.MGFxWidget.LateBindSubWidget");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(N, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_loadMovie;
    /// <summary>
    /// Function: loadMovie
    /// </summary>
    public unsafe virtual void loadMovie(BmSDK.FString Path, BmSDK.FString replacename = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_loadMovie, "BmGame.MGFxWidget.loadMovie");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(replacename, paramsPtr + 12);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_RemoveAllEventListeners;
    /// <summary>
    /// Function: RemoveAllEventListeners
    /// </summary>
    public unsafe virtual void RemoveAllEventListeners(BmSDK.FString Event)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAllEventListeners, "BmGame.MGFxWidget.RemoveAllEventListeners");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddEventListener;
    /// <summary>
    /// Function: AddEventListener
    /// </summary>
    public unsafe virtual void AddEventListener(BmSDK.FString TypeString, System.IntPtr Listener)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddEventListener, "BmGame.MGFxWidget.AddEventListener");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TypeString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Listener, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EventListener;
    /// <summary>
    /// Function: EventListener
    /// </summary>
    public unsafe virtual void EventListener(BmSDK.GFxUI.GFxObject Event)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EventListener, "BmGame.MGFxWidget.EventListener");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitSubWidgets;
    /// <summary>
    /// Function: InitSubWidgets
    /// </summary>
    public unsafe virtual void InitSubWidgets(BmSDK.GFxUI.GFxObject Owner, BmSDK.FName Path)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitSubWidgets, "BmGame.MGFxWidget.InitSubWidgets");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Owner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init(BmSDK.BmGame.RGameInfo pRGI, BmSDK.BmGame.MGFxMovieControllerBCScreen parentMovieController)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.MGFxWidget.Init");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pRGI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(parentMovieController, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EaseInOutQuint;
    /// <summary>
    /// Function: EaseInOutQuint
    /// </summary>
    public unsafe static float EaseInOutQuint(float T, float B, float C, float D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EaseInOutQuint, "BmGame.MGFxWidget.EaseInOutQuint");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_EaseOutQuint;
    /// <summary>
    /// Function: EaseOutQuint
    /// </summary>
    public unsafe static float EaseOutQuint(float T, float B, float C, float D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EaseOutQuint, "BmGame.MGFxWidget.EaseOutQuint");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_EaseInQuint;
    /// <summary>
    /// Function: EaseInQuint
    /// </summary>
    public unsafe static float EaseInQuint(float T, float B, float C, float D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EaseInQuint, "BmGame.MGFxWidget.EaseInQuint");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_EaseInOutQuart;
    /// <summary>
    /// Function: EaseInOutQuart
    /// </summary>
    public unsafe static float EaseInOutQuart(float T, float B, float C, float D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EaseInOutQuart, "BmGame.MGFxWidget.EaseInOutQuart");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_EaseOutQuart;
    /// <summary>
    /// Function: EaseOutQuart
    /// </summary>
    public unsafe static float EaseOutQuart(float T, float B, float C, float D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EaseOutQuart, "BmGame.MGFxWidget.EaseOutQuart");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_EaseInQuart;
    /// <summary>
    /// Function: EaseInQuart
    /// </summary>
    public unsafe static float EaseInQuart(float T, float B, float C, float D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EaseInQuart, "BmGame.MGFxWidget.EaseInQuart");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_EaseInOutCubic;
    /// <summary>
    /// Function: EaseInOutCubic
    /// </summary>
    public unsafe static float EaseInOutCubic(float T, float B, float C, float D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EaseInOutCubic, "BmGame.MGFxWidget.EaseInOutCubic");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_EaseOutCubic;
    /// <summary>
    /// Function: EaseOutCubic
    /// </summary>
    public unsafe static float EaseOutCubic(float T, float B, float C, float D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EaseOutCubic, "BmGame.MGFxWidget.EaseOutCubic");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_EaseInCubic;
    /// <summary>
    /// Function: EaseInCubic
    /// </summary>
    public unsafe static float EaseInCubic(float T, float B, float C, float D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EaseInCubic, "BmGame.MGFxWidget.EaseInCubic");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_EaseInOutQuad;
    /// <summary>
    /// Function: EaseInOutQuad
    /// </summary>
    public unsafe static float EaseInOutQuad(float T, float B, float C, float D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EaseInOutQuad, "BmGame.MGFxWidget.EaseInOutQuad");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_EaseOutQuad;
    /// <summary>
    /// Function: EaseOutQuad
    /// </summary>
    public unsafe static float EaseOutQuad(float T, float B, float C, float D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EaseOutQuad, "BmGame.MGFxWidget.EaseOutQuad");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_EaseInQuad;
    /// <summary>
    /// Function: EaseInQuad
    /// </summary>
    public unsafe static float EaseInQuad(float T, float B, float C, float D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EaseInQuad, "BmGame.MGFxWidget.EaseInQuad");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_LinearEase;
    /// <summary>
    /// Function: LinearEase
    /// </summary>
    public unsafe static float LinearEase(float T, float B, float C, float D)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LinearEase, "BmGame.MGFxWidget.LinearEase");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_Ease;
    /// <summary>
    /// Function: Ease
    /// </summary>
    public unsafe virtual float Ease(float T, float B, float C, float D)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Ease, "BmGame.MGFxWidget.Ease");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    /// <summary>
    /// Struct: FWidgetStreamedPackageInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FWidgetStreamedPackageInfo
    {
        /// <summary>
        /// StructProperty: StreamingId
        /// </summary>
        public unsafe BmSDK.Engine.MObjectStreaming.FObjectStreamingId StreamingId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MObjectStreaming.FObjectStreamingId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: StreamedPackage
        /// </summary>
        public unsafe BmSDK.Package StreamedPackage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Package>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: StreamedPackageObjects
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.GameObject> StreamedPackageObjects
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: PackageName
        /// </summary>
        public unsafe BmSDK.FString PackageName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FWidgetStreamedObjectInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FWidgetStreamedObjectInfo
    {
        /// <summary>
        /// StructProperty: StreamingId
        /// </summary>
        public unsafe BmSDK.Engine.MObjectStreaming.FObjectStreamingId StreamingId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MObjectStreaming.FObjectStreamingId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: StreamedObject
        /// </summary>
        public unsafe BmSDK.GameObject StreamedObject
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: ObjectName
        /// </summary>
        public unsafe BmSDK.FString ObjectName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: RGI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo RGI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: Parent
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxMovieControllerBCScreen Parent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxMovieControllerBCScreen>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ArrayProperty: StreamedObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MGFxWidget.FWidgetStreamedObjectInfo> StreamedObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MGFxWidget.FWidgetStreamedObjectInfo>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: StreamedPackages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MGFxWidget.FWidgetStreamedPackageInfo> StreamedPackages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MGFxWidget.FWidgetStreamedPackageInfo>>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// DelegateProperty: __Ease__Delegate
    /// </summary>
    public unsafe System.IntPtr __Ease__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// DelegateProperty: __EventListener__Delegate
    /// </summary>
    public unsafe System.IntPtr __EventListener__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// DelegateProperty: __LoadClipCompleteEvent__Delegate
    /// </summary>
    public unsafe System.IntPtr __LoadClipCompleteEvent__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// DelegateProperty: __LoadClipErrorEvent__Delegate
    /// </summary>
    public unsafe System.IntPtr __LoadClipErrorEvent__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// DelegateProperty: __LoadClipInitEvent__Delegate
    /// </summary>
    public unsafe System.IntPtr __LoadClipInitEvent__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// DelegateProperty: __LoadClipLoadProgressEvent__Delegate
    /// </summary>
    public unsafe System.IntPtr __LoadClipLoadProgressEvent__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// DelegateProperty: __LoadClipLoadStartEvent__Delegate
    /// </summary>
    public unsafe System.IntPtr __LoadClipLoadStartEvent__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// DelegateProperty: __EnterFrameEvent__Delegate
    /// </summary>
    public unsafe System.IntPtr __EnterFrameEvent__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
}
