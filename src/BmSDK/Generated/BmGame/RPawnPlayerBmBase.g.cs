#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayerBmBase<br/>
/// (size = 6440)
/// (flags = 144703670)
/// </summary>
public partial class RPawnPlayerBmBase : BmSDK.BmGame.RPawnPlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerBmBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayerBmBase.
    /// </summary>
    public static RPawnPlayerBmBase DefaultObject => (RPawnPlayerBmBase)StaticClass().DefaultObject;

    internal RPawnPlayerBmBase() { }

    /// <summary>
    /// Constructs a new RPawnPlayerBmBase
    /// </summary>
    public RPawnPlayerBmBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerBmBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: SetDamageLevelState
    /// </summary>
    public unsafe virtual void SetDamageLevelState(int DamageLevel)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.SetDamageLevelState", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDamageLevelState
    /// </summary>
    public unsafe virtual int GetDamageLevelState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.GetDamageLevelState", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: InitDamageLevelState
    /// </summary>
    public unsafe virtual void InitDamageLevelState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.InitDamageLevelState", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayCapeSnowFX
    /// </summary>
    public unsafe virtual void PlayCapeSnowFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.PlayCapeSnowFX", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WBIDEntitlementEnabled
    /// </summary>
    public unsafe virtual bool WBIDEntitlementEnabled()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.WBIDEntitlementEnabled", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TogglePrototypeGadget
    /// </summary>
    public unsafe virtual void TogglePrototypeGadget(bool useBM2Gadgets)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.TogglePrototypeGadget", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(useBM2Gadgets, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChangeQuickGadgets
    /// </summary>
    public unsafe virtual void ChangeQuickGadgets()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.ChangeQuickGadgets", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyForensicsUpdateRequired
    /// </summary>
    public unsafe virtual void NotifyForensicsUpdateRequired()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.NotifyForensicsUpdateRequired", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EyeMaterialUpdated
    /// </summary>
    public unsafe virtual void EyeMaterialUpdated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.EyeMaterialUpdated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CapeChangeStateGeneral
    /// </summary>
    public unsafe virtual int CapeChangeStateGeneral(BmSDK.BmGame.RPhysUtil.FCapeStateChangeData StateChangeData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.CapeChangeStateGeneral", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateChangeData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 60);
    }

    /// <summary>
    /// Function: CapeStartInState
    /// </summary>
    public unsafe virtual int CapeStartInState(BmSDK.FName NewCapeStateName, float AnimStartTime = default, float AnimPlayRate = default, BmSDK.BmGame.RPhysUtil.ECapeMirroredType MirroredType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.CapeStartInState", true);
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCapeStateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimStartTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPlayRate, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: CapeChangeStateAnim
    /// </summary>
    public unsafe virtual int CapeChangeStateAnim(BmSDK.FName NewCapeStateName, BmSDK.FName NewCapeAnimName, float AnimStartTime = default, float AnimPlayRate = default, BmSDK.BmGame.RPhysUtil.ECapeMirroredType MirroredType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.CapeChangeStateAnim", true);
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCapeStateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCapeAnimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimStartTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPlayRate, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredType, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: CapeChangeState
    /// </summary>
    public unsafe virtual int CapeChangeState(BmSDK.FName NewCapeStateName, float AnimStartTime = default, float AnimPlayRate = default, BmSDK.BmGame.RPhysUtil.ECapeMirroredType MirroredType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.CapeChangeState", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCapeStateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimStartTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPlayRate, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: ToggleMatCapeGlide
    /// </summary>
    public unsafe virtual void ToggleMatCapeGlide(bool bOn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.ToggleMatCapeGlide", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReflectCinematicPlayableActor
    /// </summary>
    public unsafe virtual void ReflectCinematicPlayableActor()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.ReflectCinematicPlayableActor", true);
        byte* paramsPtr = stackalloc byte[0];
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
    /// Function: GetCapeCurrentStateChangeIndex
    /// </summary>
    public unsafe virtual int GetCapeCurrentStateChangeIndex()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.GetCapeCurrentStateChangeIndex", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCinematicCapeStateName
    /// </summary>
    public unsafe virtual BmSDK.FName GetCinematicCapeStateName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.GetCinematicCapeStateName", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCurrentCapeStateName
    /// </summary>
    public unsafe virtual BmSDK.FName GetCurrentCapeStateName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.GetCurrentCapeStateName", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpawnFogSphere
    /// </summary>
    public unsafe virtual BmSDK.Engine.FogVolumeSphericalDensityInfo SpawnFogSphere(BmSDK.Class RaftType, System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.SpawnFogSphere", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RaftType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FogVolumeSphericalDensityInfo>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: MatineeTeleport
    /// </summary>
    public unsafe override void MatineeTeleport()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.MatineeTeleport", true);
        byte* paramsPtr = stackalloc byte[0];
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
    /// Function: OnDestroyPhysicsAssetInstance
    /// </summary>
    public unsafe override void OnDestroyPhysicsAssetInstance(BmSDK.Engine.SkeletalMeshComponent AffectedComponent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.OnDestroyPhysicsAssetInstance", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AffectedComponent, paramsPtr + 0);
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
    /// Function: OnCreatePhysicsAssetInstance
    /// </summary>
    public unsafe override void OnCreatePhysicsAssetInstance(BmSDK.Engine.SkeletalMeshComponent AffectedComponent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.OnCreatePhysicsAssetInstance", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AffectedComponent, paramsPtr + 0);
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
    /// Function: GetCameraGrappleSnowFx
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCameraEmitter GetCameraGrappleSnowFx()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.GetCameraGrappleSnowFx", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCameraEmitter>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bUseDamageMeshes
    /// </summary>
    public unsafe bool bUseDamageMeshes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6332) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6332); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6332); }
    }

    /// <summary>
    /// BoolProperty: DemonTrialsVulnerable
    /// </summary>
    public unsafe bool DemonTrialsVulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6332) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6332); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6332); }
    }

    /// <summary>
    /// BoolProperty: CameraRunSnowFxOn
    /// </summary>
    public unsafe bool CameraRunSnowFxOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6332) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6332); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6332); }
    }

    /// <summary>
    /// ComponentProperty: CapeSkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent CapeSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6336); }
    }

    /// <summary>
    /// ComponentProperty: CapeComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeComponent CapeComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeComponent>(Ptr + 6340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6340); }
    }

    /// <summary>
    /// ComponentProperty: CapeRenderingComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeRenderingComponent CapeRenderingComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeRenderingComponent>(Ptr + 6344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6344); }
    }

    /// <summary>
    /// ObjectProperty: EyesMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant EyesMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6348); }
    }

    /// <summary>
    /// ObjectProperty: EyesMaterial2
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant EyesMaterial2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6352); }
    }

    /// <summary>
    /// ObjectProperty: GlideDirectionalDirectionNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlendDirectional GlideDirectionalDirectionNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlendDirectional>(Ptr + 6356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6356); }
    }

    /// <summary>
    /// ObjectProperty: GlideDirectionalStrengthNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend GlideDirectionalStrengthNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 6360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6360); }
    }

    /// <summary>
    /// ObjectProperty: GlideRetractBlendNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend GlideRetractBlendNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 6364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6364); }
    }

    /// <summary>
    /// ObjectProperty: GlideBaseNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNode GlideBaseNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNode>(Ptr + 6368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6368); }
    }

    /// <summary>
    /// ObjectProperty: GlideRetractBlendMixer
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlendPerBone GlideRetractBlendMixer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlendPerBone>(Ptr + 6372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6372); }
    }

    /// <summary>
    /// ObjectProperty: GlideFlutterStrengthNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend GlideFlutterStrengthNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 6376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6376); }
    }

    /// <summary>
    /// FloatProperty: DivePullUpAnimStrength
    /// </summary>
    public unsafe float DivePullUpAnimStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6380); }
    }

    /// <summary>
    /// ArrayProperty: DemonSafeObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> DemonSafeObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 6384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6384); }
    }

    /// <summary>
    /// FloatProperty: CurrentPoisonFaceLevel
    /// </summary>
    public unsafe float CurrentPoisonFaceLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6396); }
    }

    /// <summary>
    /// FloatProperty: PoisonFaceLevelBlendTime
    /// </summary>
    public unsafe float PoisonFaceLevelBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6400); }
    }

    /// <summary>
    /// ComponentProperty: LeftWingTipTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent LeftWingTipTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6404); }
    }

    /// <summary>
    /// ComponentProperty: RightWingTipTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent RightWingTipTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6408); }
    }

    /// <summary>
    /// ComponentProperty: GrappleSnowTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent GrappleSnowTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6412); }
    }

    /// <summary>
    /// ComponentProperty: DiveSnowTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DiveSnowTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6416); }
    }

    /// <summary>
    /// ObjectProperty: CameraGrappleSnowFx
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCameraEmitter CameraGrappleSnowFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCameraEmitter>(Ptr + 6420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6420); }
    }

    /// <summary>
    /// ArrayProperty: DamageLevelStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DamageLevelStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 6424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6424); }
    }

    /// <summary>
    /// ComponentProperty: ApexClothFF
    /// </summary>
    public unsafe BmSDK.Engine.NxForceFieldGenericComponent ApexClothFF
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NxForceFieldGenericComponent>(Ptr + 6436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6436); }
    }
}
