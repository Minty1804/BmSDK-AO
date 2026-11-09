#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRopeComponentBase<br/>
/// (size = 580)
/// (flags = 2290090130)
/// </summary>
public partial class RRopeComponentBase : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRopeComponentBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RRopeComponentBase.
    /// </summary>
    public static RRopeComponentBase DefaultObject => (RRopeComponentBase)StaticClass().DefaultObject;

    internal RRopeComponentBase() { }

    /// <summary>
    /// Constructs a new RRopeComponentBase
    /// </summary>
    public RRopeComponentBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRopeComponentBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRopeComponentBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRopeComponentBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRopeComponentBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRopeComponentBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRopeComponentBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRopeComponentBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRopeComponentBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRopeComponentBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRopeComponentBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CallQueueReattach;
    /// <summary>
    /// Function: CallQueueReattach
    /// </summary>
    public unsafe virtual void CallQueueReattach()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CallQueueReattach, "BmGame.RRopeComponentBase.CallQueueReattach");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNoCollisions;
    /// <summary>
    /// Function: SetNoCollisions
    /// </summary>
    public unsafe virtual void SetNoCollisions()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNoCollisions, "BmGame.RRopeComponentBase.SetNoCollisions");
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

    private static BmSDK.Function __fn_CalculateDistanceBetweenRopeEnds;
    /// <summary>
    /// Function: CalculateDistanceBetweenRopeEnds
    /// </summary>
    public unsafe virtual float CalculateDistanceBetweenRopeEnds()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateDistanceBetweenRopeEnds, "BmGame.RRopeComponentBase.CalculateDistanceBetweenRopeEnds");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCollidesWithChannel;
    /// <summary>
    /// Function: SetCollidesWithChannel
    /// </summary>
    public unsafe virtual void SetCollidesWithChannel(BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel CollisionChannel, bool Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCollidesWithChannel, "BmGame.RRopeComponentBase.SetCollidesWithChannel");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionChannel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_FinaliseRope;
    /// <summary>
    /// Function: FinaliseRope
    /// </summary>
    public unsafe virtual void FinaliseRope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinaliseRope, "BmGame.RRopeComponentBase.FinaliseRope");
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

    private static BmSDK.Function __fn_InitialiseRope;
    /// <summary>
    /// Function: InitialiseRope
    /// </summary>
    public unsafe virtual void InitialiseRope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseRope, "BmGame.RRopeComponentBase.InitialiseRope");
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

    private static BmSDK.Function __fn_GetIsRopeInitialised;
    /// <summary>
    /// Function: GetIsRopeInitialised
    /// </summary>
    public unsafe virtual bool GetIsRopeInitialised()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIsRopeInitialised, "BmGame.RRopeComponentBase.GetIsRopeInitialised");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMinRopeLength;
    /// <summary>
    /// Function: GetMinRopeLength
    /// </summary>
    public unsafe virtual float GetMinRopeLength()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMinRopeLength, "BmGame.RRopeComponentBase.GetMinRopeLength");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopCurrentRopeLengthChange;
    /// <summary>
    /// Function: StopCurrentRopeLengthChange
    /// </summary>
    public unsafe virtual void StopCurrentRopeLengthChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCurrentRopeLengthChange, "BmGame.RRopeComponentBase.StopCurrentRopeLengthChange");
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

    private static BmSDK.Function __fn_SetGradualRopeLengthChange;
    /// <summary>
    /// Function: SetGradualRopeLengthChange
    /// </summary>
    public unsafe virtual void SetGradualRopeLengthChange(float NewRopeLength, BmSDK.BmGame.RRopeComponentBase.ERopeLengthChangeType LengthChangeType, float ChangeDuration)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGradualRopeLengthChange, "BmGame.RRopeComponentBase.SetGradualRopeLengthChange");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRopeLength, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LengthChangeType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChangeDuration, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetContinuousAutoLength;
    /// <summary>
    /// Function: SetContinuousAutoLength
    /// </summary>
    public unsafe virtual void SetContinuousAutoLength(BmSDK.BmGame.RRopeComponentBase.ERopeLengthChangeType LengthChangeType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetContinuousAutoLength, "BmGame.RRopeComponentBase.SetContinuousAutoLength");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LengthChangeType, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetAutoLength;
    /// <summary>
    /// Function: SetAutoLength
    /// </summary>
    public unsafe virtual void SetAutoLength(BmSDK.BmGame.RRopeComponentBase.ERopeLengthChangeType LengthChangeType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAutoLength, "BmGame.RRopeComponentBase.SetAutoLength");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LengthChangeType, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetRopeLength;
    /// <summary>
    /// Function: SetRopeLength
    /// </summary>
    public unsafe virtual void SetRopeLength(float NewRopeLength, BmSDK.BmGame.RRopeComponentBase.ERopeLengthChangeType LengthChangeType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRopeLength, "BmGame.RRopeComponentBase.SetRopeLength");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRopeLength, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LengthChangeType, paramsPtr + 4);
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

    private static BmSDK.Function __fn_DetachRopeEnd2;
    /// <summary>
    /// Function: DetachRopeEnd2
    /// </summary>
    public unsafe virtual void DetachRopeEnd2()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachRopeEnd2, "BmGame.RRopeComponentBase.DetachRopeEnd2");
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

    private static BmSDK.Function __fn_DetachRopeEnd1;
    /// <summary>
    /// Function: DetachRopeEnd1
    /// </summary>
    public unsafe virtual void DetachRopeEnd1()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachRopeEnd1, "BmGame.RRopeComponentBase.DetachRopeEnd1");
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

    private static BmSDK.Function __fn_AttachRopeEnd2ToSocket;
    /// <summary>
    /// Function: AttachRopeEnd2ToSocket
    /// </summary>
    public unsafe virtual void AttachRopeEnd2ToSocket(BmSDK.Engine.Actor AttachActor, BmSDK.FName SocketName, BmSDK.Engine.SkeletalMeshComponent AttachComponent = default, float AttachMaxDistance = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachRopeEnd2ToSocket, "BmGame.RRopeComponentBase.AttachRopeEnd2ToSocket");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SocketName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachComponent, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachMaxDistance, paramsPtr + 16);
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

    private static BmSDK.Function __fn_AttachRopeEnd1ToSocket;
    /// <summary>
    /// Function: AttachRopeEnd1ToSocket
    /// </summary>
    public unsafe virtual void AttachRopeEnd1ToSocket(BmSDK.Engine.Actor AttachActor, BmSDK.FName SocketName, BmSDK.Engine.SkeletalMeshComponent AttachComponent = default, float AttachMaxDistance = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachRopeEnd1ToSocket, "BmGame.RRopeComponentBase.AttachRopeEnd1ToSocket");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SocketName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachComponent, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachMaxDistance, paramsPtr + 16);
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

    private static BmSDK.Function __fn_AttachRopeEnd1WorldSpace;
    /// <summary>
    /// Function: AttachRopeEnd1WorldSpace
    /// </summary>
    public unsafe virtual void AttachRopeEnd1WorldSpace(BmSDK.Engine.Actor AttachActor, System.Numerics.Vector3 AttachPosWorld, BmSDK.FName AttachBone = default, BmSDK.Engine.PrimitiveComponent AttachComponent = default, float AttachMaxDistance = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachRopeEnd1WorldSpace, "BmGame.RRopeComponentBase.AttachRopeEnd1WorldSpace");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachPosWorld, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachBone, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachComponent, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachMaxDistance, paramsPtr + 28);
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

    private static BmSDK.Function __fn_AttachRopeEnd2;
    /// <summary>
    /// Function: AttachRopeEnd2
    /// </summary>
    public unsafe virtual void AttachRopeEnd2(BmSDK.Engine.Actor AttachActor, System.Numerics.Vector3 AttachPos, BmSDK.FName AttachBone = default, BmSDK.Engine.PrimitiveComponent AttachComponent = default, float AttachMaxDistance = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachRopeEnd2, "BmGame.RRopeComponentBase.AttachRopeEnd2");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachBone, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachComponent, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachMaxDistance, paramsPtr + 28);
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

    private static BmSDK.Function __fn_AttachRopeEnd1;
    /// <summary>
    /// Function: AttachRopeEnd1
    /// </summary>
    public unsafe virtual void AttachRopeEnd1(BmSDK.Engine.Actor AttachActor, System.Numerics.Vector3 AttachPos, BmSDK.FName AttachBone = default, BmSDK.Engine.PrimitiveComponent AttachComponent = default, float AttachMaxDistance = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachRopeEnd1, "BmGame.RRopeComponentBase.AttachRopeEnd1");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachBone, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachComponent, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachMaxDistance, paramsPtr + 28);
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

    private static BmSDK.Function __fn_GetWorldSpaceEnd2AttachPos;
    /// <summary>
    /// Function: GetWorldSpaceEnd2AttachPos
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetWorldSpaceEnd2AttachPos()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWorldSpaceEnd2AttachPos, "BmGame.RRopeComponentBase.GetWorldSpaceEnd2AttachPos");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetWorldSpaceEnd1AttachPos;
    /// <summary>
    /// Function: GetWorldSpaceEnd1AttachPos
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetWorldSpaceEnd1AttachPos()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWorldSpaceEnd1AttachPos, "BmGame.RRopeComponentBase.GetWorldSpaceEnd1AttachPos");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPositionOfRopePos;
    /// <summary>
    /// Function: GetPositionOfRopePos
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPositionOfRopePos(float RopePos, BmSDK.BmGame.RRopeComponentBase.ERopeEndType MeasurementRopeEnd)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPositionOfRopePos, "BmGame.RRopeComponentBase.GetPositionOfRopePos");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RopePos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeasurementRopeEnd, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetNearestPointOnRopeToPoint;
    /// <summary>
    /// Function: GetNearestPointOnRopeToPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetNearestPointOnRopeToPoint(System.Numerics.Vector3 WorldSpacePos, BmSDK.BmGame.RRopeComponentBase.ERopeEndType MeasurementRopeEnd, out float RopePos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNearestPointOnRopeToPoint, "BmGame.RRopeComponentBase.GetNearestPointOnRopeToPoint");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldSpacePos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeasurementRopeEnd, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RopePos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RopePos, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        RopePos = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetNearestPointOnRopeToRay;
    /// <summary>
    /// Function: GetNearestPointOnRopeToRay
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetNearestPointOnRopeToRay(System.Numerics.Vector3 RayStartPos, System.Numerics.Vector3 RayDirection, BmSDK.BmGame.RRopeComponentBase.ERopeEndType MeasurementRopeEnd, out float RopePos, out float RayPos, float BufferLength = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNearestPointOnRopeToRay, "BmGame.RRopeComponentBase.GetNearestPointOnRopeToRay");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RayStartPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RayDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeasurementRopeEnd, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RopePos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RopePos, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RayPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RayPos, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BufferLength, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        RopePos = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
        RayPos = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetNearestPointOnRopeToLineSegment;
    /// <summary>
    /// Function: GetNearestPointOnRopeToLineSegment
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetNearestPointOnRopeToLineSegment(System.Numerics.Vector3 LineSegmentStartPos, System.Numerics.Vector3 LineSegmentEndPos, BmSDK.BmGame.RRopeComponentBase.ERopeEndType MeasurementRopeEnd, out float RopePos, out float LineSegmentPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNearestPointOnRopeToLineSegment, "BmGame.RRopeComponentBase.GetNearestPointOnRopeToLineSegment");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineSegmentStartPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineSegmentEndPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeasurementRopeEnd, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RopePos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RopePos, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out LineSegmentPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineSegmentPos, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        RopePos = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
        LineSegmentPos = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_UpdateRope;
    /// <summary>
    /// Function: UpdateRope
    /// </summary>
    public unsafe virtual void UpdateRope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRope, "BmGame.RRopeComponentBase.UpdateRope");
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

    private static BmSDK.Function __fn_RequestUpdateRope;
    /// <summary>
    /// Function: RequestUpdateRope
    /// </summary>
    public unsafe virtual void RequestUpdateRope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestUpdateRope, "BmGame.RRopeComponentBase.RequestUpdateRope");
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

    /// <summary>
    /// BoolProperty: DrawAsChain
    /// </summary>
    public unsafe bool DrawAsChain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: IsRopeEnd1Attached
    /// </summary>
    public unsafe bool IsRopeEnd1Attached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: IsRopeEnd2Attached
    /// </summary>
    public unsafe bool IsRopeEnd2Attached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: HasConstraint
    /// </summary>
    public unsafe bool HasConstraint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: IsUpdateRopeRequested
    /// </summary>
    public unsafe bool IsUpdateRopeRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// ObjectProperty: RopeAttachActor1
    /// </summary>
    public unsafe BmSDK.Engine.Actor RopeAttachActor1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ObjectProperty: RopeAttachActor2
    /// </summary>
    public unsafe BmSDK.Engine.Actor RopeAttachActor2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ComponentProperty: RopeAttachComponent1
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent RopeAttachComponent1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ComponentProperty: RopeAttachComponent2
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent RopeAttachComponent2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// NameProperty: RopeActor1AttachBone
    /// </summary>
    public unsafe BmSDK.FName RopeActor1AttachBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// NameProperty: RopeActor2AttachBone
    /// </summary>
    public unsafe BmSDK.FName RopeActor2AttachBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// StructProperty: ConstraintActor1AttachPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ConstraintActor1AttachPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 476);

    /// <summary>
    /// StructProperty: ConstraintActor2AttachPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ConstraintActor2AttachPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 488);

    /// <summary>
    /// FloatProperty: RopeEnd1AttachMaxDistance
    /// </summary>
    public unsafe float RopeEnd1AttachMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// FloatProperty: RopeEnd2AttachMaxDistance
    /// </summary>
    public unsafe float RopeEnd2AttachMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// FloatProperty: RopeLength
    /// </summary>
    public unsafe float RopeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// FloatProperty: RopeRenderStartPos
    /// </summary>
    public unsafe float RopeRenderStartPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// FloatProperty: RopeStretch
    /// </summary>
    public unsafe float RopeStretch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// FloatProperty: RopeWidth
    /// </summary>
    public unsafe float RopeWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// FloatProperty: RopeTwistLimitPerMetre
    /// </summary>
    public unsafe float RopeTwistLimitPerMetre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// FloatProperty: RopeChangeLength
    /// </summary>
    public unsafe float RopeChangeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// FloatProperty: RopeChangeDuration
    /// </summary>
    public unsafe float RopeChangeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ByteProperty: RopeChangeType
    /// </summary>
    public unsafe BmSDK.BmGame.RRopeComponentBase.ERopeLengthChangeType RopeChangeType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRopeComponentBase.ERopeLengthChangeType>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ByteProperty: RopeLengthControlType
    /// </summary>
    public unsafe BmSDK.BmGame.RRopeComponentBase.ERopeLengthControlType RopeLengthControlType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRopeComponentBase.ERopeLengthControlType>(Ptr + 537); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 537); }
    }

    /// <summary>
    /// FloatProperty: RopeDrawWidth
    /// </summary>
    public unsafe float RopeDrawWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: Material
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface Material
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: UnitsPerV
    /// </summary>
    public unsafe float UnitsPerV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// FloatProperty: VOffsetChain
    /// </summary>
    public unsafe float VOffsetChain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// FloatProperty: RopeRenderInterpolationScale
    /// </summary>
    public unsafe float RopeRenderInterpolationScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// FloatProperty: AutoRopeLengthSlackRatio
    /// </summary>
    public unsafe float AutoRopeLengthSlackRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// FloatProperty: AutoRopeLengthMinLength
    /// </summary>
    public unsafe float AutoRopeLengthMinLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// FloatProperty: AutoRopeLengthMaxLength
    /// </summary>
    public unsafe float AutoRopeLengthMaxLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// StructProperty: RopePhysicsBase
    /// </summary>
    public unsafe System.IntPtr RopePhysicsBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// ObjectProperty: ConstraintSetup
    /// </summary>
    public unsafe BmSDK.Engine.RB_ConstraintSetup ConstraintSetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_ConstraintSetup>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// Enum: ERopeLengthControlType
    /// </summary>
    public enum ERopeLengthControlType : byte
    {
        ROPELENGTHCONTROLTYPE_None = 0,
        ROPELENGTHCONTROLTYPE_GradualLengthChange = 1,
        ROPELENGTHCONTROLTYPE_SingleAutoLength = 2,
        ROPELENGTHCONTROLTYPE_ContinuousAutoLength = 3,
        ROPELENGTHCONTROLTYPE_MAX = 4,
    }

    /// <summary>
    /// Enum: ERopeLengthChangeType
    /// </summary>
    public enum ERopeLengthChangeType : byte
    {
        ROPELENGTHCHANGE_ChangeFromEnd1 = 0,
        ROPELENGTHCHANGE_ChangeFromEnd2 = 1,
        ROPELENGTHCHANGE_ChangeFromBothEnds = 2,
        ROPELENGTHCHANGE_ChangeRope = 3,
        ROPELENGTHCHANGE_ChangeRope_VisualEnd1 = 4,
        ROPELENGTHCHANGE_ChangeRope_VisualEnd2 = 5,
        ROPELENGTHCHANGE_MAX = 6,
    }

    /// <summary>
    /// Enum: ERopeEndType
    /// </summary>
    public enum ERopeEndType : byte
    {
        ROPEEND_End1 = 0,
        ROPEEND_End2 = 1,
        ROPEEND_MAX = 2,
    }
}
