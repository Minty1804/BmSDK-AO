#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RB_ConstraintInstance<br/>
/// (size = 156)
/// (flags = 142606482)
/// </summary>
public partial class RB_ConstraintInstance : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RB_ConstraintInstance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RB_ConstraintInstance.
    /// </summary>
    public static RB_ConstraintInstance DefaultObject => (RB_ConstraintInstance)StaticClass().DefaultObject;

    internal RB_ConstraintInstance() { }

    /// <summary>
    /// Constructs a new RB_ConstraintInstance
    /// </summary>
    public RB_ConstraintInstance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RB_ConstraintInstance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RB_ConstraintInstance(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RB_ConstraintInstance>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RB_ConstraintInstance>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RB_ConstraintInstance>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RB_ConstraintInstance>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RB_ConstraintInstance>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RB_ConstraintInstance>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RB_ConstraintInstance>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RB_ConstraintInstance>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetDistanceJointLimits;
    /// <summary>
    /// Function: SetDistanceJointLimits
    /// </summary>
    public unsafe virtual void SetDistanceJointLimits(bool bLimitMinDist, bool bLimitMaxDist, float NewMinDistance = default, float NewMaxDistance = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDistanceJointLimits, "Engine.RB_ConstraintInstance.SetDistanceJointLimits");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLimitMinDist, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLimitMaxDist, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMinDistance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMaxDistance, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetDistanceJointMinLimit;
    /// <summary>
    /// Function: SetDistanceJointMinLimit
    /// </summary>
    public unsafe virtual void SetDistanceJointMinLimit(bool bLimitMinDist, float NewMinDistance = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDistanceJointMinLimit, "Engine.RB_ConstraintInstance.SetDistanceJointMinLimit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLimitMinDist, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMinDistance, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetDistanceJointMaxLimit;
    /// <summary>
    /// Function: SetDistanceJointMaxLimit
    /// </summary>
    public unsafe virtual void SetDistanceJointMaxLimit(bool bLimitMaxDist, float NewMaxDistance = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDistanceJointMaxLimit, "Engine.RB_ConstraintInstance.SetDistanceJointMaxLimit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLimitMaxDist, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMaxDistance, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetDistanceJointMinLimit;
    /// <summary>
    /// Function: GetDistanceJointMinLimit
    /// </summary>
    public unsafe virtual bool GetDistanceJointMinLimit(out float OutMinDistance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDistanceJointMinLimit, "Engine.RB_ConstraintInstance.GetDistanceJointMinLimit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutMinDistance);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutMinDistance, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutMinDistance = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDistanceJointMaxLimit;
    /// <summary>
    /// Function: GetDistanceJointMaxLimit
    /// </summary>
    public unsafe virtual bool GetDistanceJointMaxLimit(out float OutMaxDistance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDistanceJointMaxLimit, "Engine.RB_ConstraintInstance.GetDistanceJointMaxLimit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutMaxDistance);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutMaxDistance, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutMaxDistance = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MoveKinActorTransform;
    /// <summary>
    /// Function: MoveKinActorTransform
    /// </summary>
    public unsafe virtual void MoveKinActorTransform(out BmSDK.GameObject.FMatrix NewTM)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveKinActorTransform, "Engine.RB_ConstraintInstance.MoveKinActorTransform");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NewTM = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FMatrix>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetLinearLimitSize;
    /// <summary>
    /// Function: SetLinearLimitSize
    /// </summary>
    public unsafe virtual void SetLinearLimitSize(float NewLimitSize)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLinearLimitSize, "Engine.RB_ConstraintInstance.SetLinearLimitSize");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLimitSize, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetAngularDOFLimitScale;
    /// <summary>
    /// Function: SetAngularDOFLimitScale
    /// </summary>
    public unsafe virtual void SetAngularDOFLimitScale(float InSwing1LimitScale, float InSwing2LimitScale, float InTwistLimitScale, BmSDK.Engine.RB_ConstraintSetup InSetup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAngularDOFLimitScale, "Engine.RB_ConstraintInstance.SetAngularDOFLimitScale");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSwing1LimitScale, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSwing2LimitScale, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTwistLimitScale, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSetup, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetAngularDriveParams;
    /// <summary>
    /// Function: SetAngularDriveParams
    /// </summary>
    public unsafe virtual void SetAngularDriveParams(float InSpring, float InDamping, float InForceLimit)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAngularDriveParams, "Engine.RB_ConstraintInstance.SetAngularDriveParams");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSpring, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDamping, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InForceLimit, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetAngularVelocityTarget;
    /// <summary>
    /// Function: SetAngularVelocityTarget
    /// </summary>
    public unsafe virtual void SetAngularVelocityTarget(System.Numerics.Vector3 InVelTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAngularVelocityTarget, "Engine.RB_ConstraintInstance.SetAngularVelocityTarget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InVelTarget, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetAngularPositionTarget;
    /// <summary>
    /// Function: SetAngularPositionTarget
    /// </summary>
    public unsafe virtual void SetAngularPositionTarget(in BmSDK.GameObject.FQuat InPosTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAngularPositionTarget, "Engine.RB_ConstraintInstance.SetAngularPositionTarget");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPosTarget, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetLinearDriveParams;
    /// <summary>
    /// Function: SetLinearDriveParams
    /// </summary>
    public unsafe virtual void SetLinearDriveParams(float InSpring, float InDamping, float InForceLimit)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLinearDriveParams, "Engine.RB_ConstraintInstance.SetLinearDriveParams");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSpring, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDamping, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InForceLimit, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetLinearVelocityTarget;
    /// <summary>
    /// Function: SetLinearVelocityTarget
    /// </summary>
    public unsafe virtual void SetLinearVelocityTarget(System.Numerics.Vector3 InVelTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLinearVelocityTarget, "Engine.RB_ConstraintInstance.SetLinearVelocityTarget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InVelTarget, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetLinearPositionTarget;
    /// <summary>
    /// Function: SetLinearPositionTarget
    /// </summary>
    public unsafe virtual void SetLinearPositionTarget(System.Numerics.Vector3 InPosTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLinearPositionTarget, "Engine.RB_ConstraintInstance.SetLinearPositionTarget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPosTarget, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetAngularVelocityDrive;
    /// <summary>
    /// Function: SetAngularVelocityDrive
    /// </summary>
    public unsafe virtual void SetAngularVelocityDrive(bool bEnableSwingDrive, bool bEnableTwistDrive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAngularVelocityDrive, "Engine.RB_ConstraintInstance.SetAngularVelocityDrive");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableSwingDrive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableTwistDrive, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetAngularPositionDrive;
    /// <summary>
    /// Function: SetAngularPositionDrive
    /// </summary>
    public unsafe virtual void SetAngularPositionDrive(bool bEnableSwingDrive, bool bEnableTwistDrive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAngularPositionDrive, "Engine.RB_ConstraintInstance.SetAngularPositionDrive");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableSwingDrive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableTwistDrive, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetLinearVelocityDrive;
    /// <summary>
    /// Function: SetLinearVelocityDrive
    /// </summary>
    public unsafe virtual void SetLinearVelocityDrive(bool bEnableXDrive, bool bEnableYDrive, bool bEnableZDrive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLinearVelocityDrive, "Engine.RB_ConstraintInstance.SetLinearVelocityDrive");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableXDrive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableYDrive, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableZDrive, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetLinearPositionDrive;
    /// <summary>
    /// Function: SetLinearPositionDrive
    /// </summary>
    public unsafe virtual void SetLinearPositionDrive(bool bEnableXDrive, bool bEnableYDrive, bool bEnableZDrive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLinearPositionDrive, "Engine.RB_ConstraintInstance.SetLinearPositionDrive");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableXDrive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableYDrive, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableZDrive, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetConstraintLocation;
    /// <summary>
    /// Function: GetConstraintLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetConstraintLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetConstraintLocation, "Engine.RB_ConstraintInstance.GetConstraintLocation");
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

    private static BmSDK.Function __fn_GetPhysicsAssetInstance;
    /// <summary>
    /// Function: GetPhysicsAssetInstance
    /// </summary>
    public unsafe virtual BmSDK.Engine.PhysicsAssetInstance GetPhysicsAssetInstance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPhysicsAssetInstance, "Engine.RB_ConstraintInstance.GetPhysicsAssetInstance");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PhysicsAssetInstance>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TermConstraint;
    /// <summary>
    /// Function: TermConstraint
    /// </summary>
    public unsafe virtual void TermConstraint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TermConstraint, "Engine.RB_ConstraintInstance.TermConstraint");
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

    private static BmSDK.Function __fn_InitConstraint;
    /// <summary>
    /// Function: InitConstraint
    /// </summary>
    public unsafe virtual void InitConstraint(BmSDK.Engine.PrimitiveComponent PrimComp1, BmSDK.Engine.PrimitiveComponent PrimComp2, BmSDK.Engine.RB_ConstraintSetup Setup, float Scale, BmSDK.Engine.Actor InOwner, BmSDK.Engine.PrimitiveComponent InPrimComp, bool bMakeKinForBody1)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitConstraint, "Engine.RB_ConstraintInstance.InitConstraint");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrimComp1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrimComp2, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Setup, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InOwner, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPrimComp, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMakeKinForBody1, paramsPtr + 24);
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
    /// ObjectProperty: Owner
    /// </summary>
    public unsafe BmSDK.Engine.Actor Owner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ComponentProperty: OwnerComponent
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent OwnerComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// IntProperty: ConstraintIndex
    /// </summary>
    public unsafe int ConstraintIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// IntProperty: SceneIndex
    /// </summary>
    public unsafe int SceneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bInHardware
    /// </summary>
    public unsafe bool bInHardware
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: bLinearXPositionDrive
    /// </summary>
    public unsafe bool bLinearXPositionDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: bLinearXVelocityDrive
    /// </summary>
    public unsafe bool bLinearXVelocityDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: bLinearYPositionDrive
    /// </summary>
    public unsafe bool bLinearYPositionDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: bLinearYVelocityDrive
    /// </summary>
    public unsafe bool bLinearYVelocityDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: bLinearZPositionDrive
    /// </summary>
    public unsafe bool bLinearZPositionDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: bLinearZVelocityDrive
    /// </summary>
    public unsafe bool bLinearZVelocityDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: bSwingPositionDrive
    /// </summary>
    public unsafe bool bSwingPositionDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: bSwingVelocityDrive
    /// </summary>
    public unsafe bool bSwingVelocityDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: bTwistPositionDrive
    /// </summary>
    public unsafe bool bTwistPositionDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: bTwistVelocityDrive
    /// </summary>
    public unsafe bool bTwistVelocityDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: bAngularSlerpDrive
    /// </summary>
    public unsafe bool bAngularSlerpDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: bTerminated
    /// </summary>
    public unsafe bool bTerminated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// StructProperty: ConstraintData
    /// </summary>
    public unsafe System.IntPtr ConstraintData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// StructProperty: LinearPositionTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LinearPositionTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 68);

    /// <summary>
    /// StructProperty: LinearVelocityTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LinearVelocityTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 80);

    /// <summary>
    /// FloatProperty: LinearDriveSpring
    /// </summary>
    public unsafe float LinearDriveSpring
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: LinearDriveDamping
    /// </summary>
    public unsafe float LinearDriveDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: LinearDriveForceLimit
    /// </summary>
    public unsafe float LinearDriveForceLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: AngularPositionTarget
    /// </summary>
    public unsafe ref BmSDK.GameObject.FQuat AngularPositionTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FQuat>(Ptr + 112);

    /// <summary>
    /// StructProperty: AngularVelocityTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AngularVelocityTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 128);

    /// <summary>
    /// FloatProperty: AngularDriveSpring
    /// </summary>
    public unsafe float AngularDriveSpring
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: AngularDriveDamping
    /// </summary>
    public unsafe float AngularDriveDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// FloatProperty: AngularDriveForceLimit
    /// </summary>
    public unsafe float AngularDriveForceLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StructProperty: DummyKinActor
    /// </summary>
    public unsafe System.IntPtr DummyKinActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
}
