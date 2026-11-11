#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PhysicsAssetInstance<br/>
/// (size = 172)
/// (flags = 136347794)
/// </summary>
public partial class PhysicsAssetInstance : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PhysicsAssetInstance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as PhysicsAssetInstance.
    /// </summary>
    public static PhysicsAssetInstance DefaultObject => (PhysicsAssetInstance)StaticClass().DefaultObject;

    internal PhysicsAssetInstance() { }

    /// <summary>
    /// Constructs a new PhysicsAssetInstance
    /// </summary>
    public PhysicsAssetInstance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PhysicsAssetInstance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PhysicsAssetInstance(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<PhysicsAssetInstance>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PhysicsAssetInstance>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<PhysicsAssetInstance>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PhysicsAssetInstance>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PhysicsAssetInstance>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PhysicsAssetInstance>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<PhysicsAssetInstance>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PhysicsAssetInstance>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetDampingRampupProportion;
    /// <summary>
    /// Function: SetDampingRampupProportion
    /// </summary>
    public unsafe virtual void SetDampingRampupProportion(float NewDampingRampupProportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDampingRampupProportion, "Engine.PhysicsAssetInstance.SetDampingRampupProportion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDampingRampupProportion, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FindConstraintInstance;
    /// <summary>
    /// Function: FindConstraintInstance
    /// </summary>
    public unsafe virtual BmSDK.Engine.RB_ConstraintInstance FindConstraintInstance(BmSDK.FName ConName, BmSDK.Engine.PhysicsAsset InAsset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindConstraintInstance, "Engine.PhysicsAssetInstance.FindConstraintInstance");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAsset, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.RB_ConstraintInstance>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FindBodyInstance;
    /// <summary>
    /// Function: FindBodyInstance
    /// </summary>
    public unsafe virtual BmSDK.Engine.RB_BodyInstance FindBodyInstance(BmSDK.FName BodyName, BmSDK.Engine.PhysicsAsset InAsset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindBodyInstance, "Engine.PhysicsAssetInstance.FindBodyInstance");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BodyName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAsset, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.RB_BodyInstance>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetFullAnimWeightBonesFixed;
    /// <summary>
    /// Function: SetFullAnimWeightBonesFixed
    /// </summary>
    public unsafe virtual void SetFullAnimWeightBonesFixed(bool bNewFixed, BmSDK.Engine.SkeletalMeshComponent SkelMesh)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFullAnimWeightBonesFixed, "Engine.PhysicsAssetInstance.SetFullAnimWeightBonesFixed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewFixed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetFullAnimWeightBlockRigidBody;
    /// <summary>
    /// Function: SetFullAnimWeightBlockRigidBody
    /// </summary>
    public unsafe virtual void SetFullAnimWeightBlockRigidBody(bool bNewBlockRigidBody, BmSDK.Engine.SkeletalMeshComponent SkelMesh)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFullAnimWeightBlockRigidBody, "Engine.PhysicsAssetInstance.SetFullAnimWeightBlockRigidBody");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewBlockRigidBody, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetNamedBodiesBlockRigidBody;
    /// <summary>
    /// Function: SetNamedBodiesBlockRigidBody
    /// </summary>
    public unsafe virtual void SetNamedBodiesBlockRigidBody(bool bNewBlockRigidBody, BmSDK.TArray<BmSDK.FName> BoneNames, BmSDK.Engine.SkeletalMeshComponent SkelMesh)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNamedBodiesBlockRigidBody, "Engine.PhysicsAssetInstance.SetNamedBodiesBlockRigidBody");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewBlockRigidBody, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneNames, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 16);
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

    private static BmSDK.Function __fn_SetNamedRBBoneSprings;
    /// <summary>
    /// Function: SetNamedRBBoneSprings
    /// </summary>
    public unsafe virtual void SetNamedRBBoneSprings(bool bEnable, BmSDK.TArray<BmSDK.FName> BoneNames, float InBoneLinearSpring, float InBoneAngularSpring, BmSDK.Engine.SkeletalMeshComponent SkelMeshComp, BmSDK.Engine.PhysicsAssetInstance.EBoneSpringUsagePriority BoneSpringUsagePriority)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNamedRBBoneSprings, "Engine.PhysicsAssetInstance.SetNamedRBBoneSprings");
        byte* paramsPtr = stackalloc byte[45];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnable, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneNames, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InBoneLinearSpring, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InBoneAngularSpring, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMeshComp, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneSpringUsagePriority, paramsPtr + 28);
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

    private static BmSDK.Function __fn_SetNamedMotorsAngularVelocityDrive;
    /// <summary>
    /// Function: SetNamedMotorsAngularVelocityDrive
    /// </summary>
    public unsafe virtual void SetNamedMotorsAngularVelocityDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, BmSDK.TArray<BmSDK.FName> BoneNames, BmSDK.Engine.SkeletalMeshComponent SkelMeshComp, bool bSetOtherBodiesToComplement = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNamedMotorsAngularVelocityDrive, "Engine.PhysicsAssetInstance.SetNamedMotorsAngularVelocityDrive");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableSwingDrive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableTwistDrive, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneNames, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMeshComp, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetOtherBodiesToComplement, paramsPtr + 24);
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

    private static BmSDK.Function __fn_SetNamedMotorsAngularPositionDrive;
    /// <summary>
    /// Function: SetNamedMotorsAngularPositionDrive
    /// </summary>
    public unsafe virtual void SetNamedMotorsAngularPositionDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, BmSDK.TArray<BmSDK.FName> BoneNames, BmSDK.Engine.SkeletalMeshComponent SkelMeshComp, bool bSetOtherBodiesToComplement = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNamedMotorsAngularPositionDrive, "Engine.PhysicsAssetInstance.SetNamedMotorsAngularPositionDrive");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableSwingDrive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableTwistDrive, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneNames, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMeshComp, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetOtherBodiesToComplement, paramsPtr + 24);
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

    private static BmSDK.Function __fn_SetAllMotorsAngularDriveParams;
    /// <summary>
    /// Function: SetAllMotorsAngularDriveParams
    /// </summary>
    public unsafe virtual void SetAllMotorsAngularDriveParams(float InSpring, float InDamping, float InForceLimit, BmSDK.Engine.SkeletalMeshComponent SkelMesh = default, bool bSkipFullAnimWeightBodies = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllMotorsAngularDriveParams, "Engine.PhysicsAssetInstance.SetAllMotorsAngularDriveParams");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSpring, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDamping, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InForceLimit, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipFullAnimWeightBodies, paramsPtr + 16);
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

    private static BmSDK.Function __fn_SetAllMotorsAngularVelocityDrive;
    /// <summary>
    /// Function: SetAllMotorsAngularVelocityDrive
    /// </summary>
    public unsafe virtual void SetAllMotorsAngularVelocityDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, BmSDK.Engine.SkeletalMeshComponent SkelMeshComp, bool bSkipFullAnimWeightBodies = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllMotorsAngularVelocityDrive, "Engine.PhysicsAssetInstance.SetAllMotorsAngularVelocityDrive");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableSwingDrive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableTwistDrive, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMeshComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipFullAnimWeightBodies, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetAllMotorsAngularPositionDrive;
    /// <summary>
    /// Function: SetAllMotorsAngularPositionDrive
    /// </summary>
    public unsafe virtual void SetAllMotorsAngularPositionDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, BmSDK.Engine.SkeletalMeshComponent SkelMesh = default, bool bSkipFullAnimWeightBodies = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllMotorsAngularPositionDrive, "Engine.PhysicsAssetInstance.SetAllMotorsAngularPositionDrive");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableSwingDrive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableTwistDrive, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipFullAnimWeightBodies, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ForceAllBodiesBelowUnfixed;
    /// <summary>
    /// Function: ForceAllBodiesBelowUnfixed
    /// </summary>
    public unsafe virtual void ForceAllBodiesBelowUnfixed(in BmSDK.FName InBoneName, BmSDK.Engine.PhysicsAsset InAsset, BmSDK.Engine.SkeletalMeshComponent InSkelMesh, bool InbInstanceAlwaysFullAnimWeight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceAllBodiesBelowUnfixed, "Engine.PhysicsAssetInstance.ForceAllBodiesBelowUnfixed");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InBoneName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAsset, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSkelMesh, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbInstanceAlwaysFullAnimWeight, paramsPtr + 16);
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

    private static BmSDK.Function __fn_SetGroupBodiesFixed;
    /// <summary>
    /// Function: SetGroupBodiesFixed
    /// </summary>
    public unsafe virtual void SetGroupBodiesFixed(bool bNewFixed, BmSDK.FName GroupName, BmSDK.Engine.SkeletalMeshComponent SkelMesh, bool bSetOtherBodiesToComplement = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGroupBodiesFixed, "Engine.PhysicsAssetInstance.SetGroupBodiesFixed");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewFixed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetOtherBodiesToComplement, paramsPtr + 16);
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

    private static BmSDK.Function __fn_SetNamedBodiesFixed;
    /// <summary>
    /// Function: SetNamedBodiesFixed
    /// </summary>
    public unsafe virtual void SetNamedBodiesFixed(bool bNewFixed, BmSDK.TArray<BmSDK.FName> BoneNames, BmSDK.Engine.SkeletalMeshComponent SkelMesh, bool bSetOtherBodiesToComplement = default, bool bSkipFullAnimWeightBodies = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNamedBodiesFixed, "Engine.PhysicsAssetInstance.SetNamedBodiesFixed");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewFixed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneNames, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetOtherBodiesToComplement, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipFullAnimWeightBodies, paramsPtr + 24);
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

    private static BmSDK.Function __fn_SetAllBodiesFixed;
    /// <summary>
    /// Function: SetAllBodiesFixed
    /// </summary>
    public unsafe virtual void SetAllBodiesFixed(bool bNewFixed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllBodiesFixed, "Engine.PhysicsAssetInstance.SetAllBodiesFixed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewFixed, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetTotalMassBelowBone;
    /// <summary>
    /// Function: GetTotalMassBelowBone
    /// </summary>
    public unsafe virtual float GetTotalMassBelowBone(BmSDK.FName InBoneName, BmSDK.Engine.PhysicsAsset InAsset, BmSDK.Engine.SkeletalMesh InSkelMesh)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTotalMassBelowBone, "Engine.PhysicsAssetInstance.GetTotalMassBelowBone");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InBoneName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAsset, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSkelMesh, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SetAngularDriveScale;
    /// <summary>
    /// Function: SetAngularDriveScale
    /// </summary>
    public unsafe virtual void SetAngularDriveScale(float InAngularSpringScale, float InAngularDampingScale, float InAngularForceLimitScale)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAngularDriveScale, "Engine.PhysicsAssetInstance.SetAngularDriveScale");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAngularSpringScale, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAngularDampingScale, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAngularForceLimitScale, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetLinearDriveScale;
    /// <summary>
    /// Function: SetLinearDriveScale
    /// </summary>
    public unsafe virtual void SetLinearDriveScale(float InLinearSpringScale, float InLinearDampingScale, float InLinearForceLimitScale)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLinearDriveScale, "Engine.PhysicsAssetInstance.SetLinearDriveScale");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLinearSpringScale, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLinearDampingScale, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLinearForceLimitScale, paramsPtr + 8);
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
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// IntProperty: RootBodyIndex
    /// </summary>
    public unsafe int RootBodyIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// ArrayProperty: Bodies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RB_BodyInstance> Bodies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RB_BodyInstance>>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ArrayProperty: Constraints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RB_ConstraintInstance> Constraints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RB_ConstraintInstance>>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// StructProperty: CollisionDisableTable
    /// </summary>
    public unsafe ref BmSDK.GameObject.FMap_Mirror CollisionDisableTable
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FMap_Mirror>(Ptr + 80);

    /// <summary>
    /// FloatProperty: LinearSpringScale
    /// </summary>
    public unsafe float LinearSpringScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: LinearDampingScale
    /// </summary>
    public unsafe float LinearDampingScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// FloatProperty: LinearForceLimitScale
    /// </summary>
    public unsafe float LinearForceLimitScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// FloatProperty: AngularSpringScale
    /// </summary>
    public unsafe float AngularSpringScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// FloatProperty: AngularDampingScale
    /// </summary>
    public unsafe float AngularDampingScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: AngularForceLimitScale
    /// </summary>
    public unsafe float AngularForceLimitScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bInitBodies
    /// </summary>
    public unsafe bool bInitBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// FloatProperty: CachedDampingRampupProportion
    /// </summary>
    public unsafe float CachedDampingRampupProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// Enum: EBoneSpringUsagePriority
    /// </summary>
    public enum EBoneSpringUsagePriority : byte
    {
        BONESPRINGUSAGEPRIORITY_None = 0,
        BONESPRINGUSAGEPRIORITY_NetDrive = 1,
        BONESPRINGUSAGEPRIORITY_AnimDrive = 2,
        BONESPRINGUSAGEPRIORITY_Highest = 3,
        BONESPRINGUSAGEPRIORITY_MAX = 4,
    }
}
