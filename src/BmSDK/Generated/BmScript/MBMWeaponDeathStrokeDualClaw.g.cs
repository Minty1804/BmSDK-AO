#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MBMWeaponDeathStrokeDualClaw<br/>
/// (size = 1276)
/// (flags = 8388658)
/// </summary>
public partial class MBMWeaponDeathStrokeDualClaw : BmSDK.BmGame.RBMWeaponRanged, BmSDK.BmGame.MDualClawInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MBMWeaponDeathStrokeDualClaw", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MBMWeaponDeathStrokeDualClaw.
    /// </summary>
    public static MBMWeaponDeathStrokeDualClaw DefaultObject => (MBMWeaponDeathStrokeDualClaw)StaticClass().DefaultObject;

    internal MBMWeaponDeathStrokeDualClaw() { }

    /// <summary>
    /// Constructs a new MBMWeaponDeathStrokeDualClaw
    /// </summary>
    public MBMWeaponDeathStrokeDualClaw(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MBMWeaponDeathStrokeDualClaw(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMWeaponDeathStrokeDualClaw>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMWeaponDeathStrokeDualClaw>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMWeaponDeathStrokeDualClaw>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMWeaponDeathStrokeDualClaw>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMWeaponDeathStrokeDualClaw>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMWeaponDeathStrokeDualClaw>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMWeaponDeathStrokeDualClaw>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMWeaponDeathStrokeDualClaw>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetAttachBoneNameForPawn;
    /// <summary>
    /// Function: GetAttachBoneNameForPawn
    /// </summary>
    public unsafe virtual BmSDK.FName GetAttachBoneNameForPawn(BmSDK.BmGame.RPawnCombat toVictim, BmSDK.Engine.Actor fromActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAttachBoneNameForPawn, "BmScript.MBMWeaponDeathStrokeDualClaw.GetAttachBoneNameForPawn");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(toVictim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fromActor, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDualClawMesh;
    /// <summary>
    /// Function: GetDualClawMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent GetDualClawMesh()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDualClawMesh, "BmScript.MBMWeaponDeathStrokeDualClaw.GetDualClawMesh");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopDualClawClusterFollowCam;
    /// <summary>
    /// Function: StopDualClawClusterFollowCam
    /// </summary>
    public unsafe virtual void StopDualClawClusterFollowCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopDualClawClusterFollowCam, "BmScript.MBMWeaponDeathStrokeDualClaw.StopDualClawClusterFollowCam");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveDualClawProjectile;
    /// <summary>
    /// Function: RemoveDualClawProjectile
    /// </summary>
    public unsafe virtual bool RemoveDualClawProjectile(BmSDK.BmGame.MDualClawClusterProjectile DualClawClusterProjectile)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveDualClawProjectile, "BmScript.MBMWeaponDeathStrokeDualClaw.RemoveDualClawProjectile");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DualClawClusterProjectile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FailedReachedDest;
    /// <summary>
    /// Function: FailedReachedDest
    /// </summary>
    public unsafe virtual void FailedReachedDest(BmSDK.BmGame.MDualClawClusterProjectile DualClawClusterProjectile)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FailedReachedDest, "BmScript.MBMWeaponDeathStrokeDualClaw.FailedReachedDest");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DualClawClusterProjectile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGadgetConfig;
    /// <summary>
    /// Function: GetGadgetConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MInventoryGadgetConfig_DualClawBase GetGadgetConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetConfig, "BmScript.MBMWeaponDeathStrokeDualClaw.GetGadgetConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MInventoryGadgetConfig_DualClawBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHidePointWireClass;
    /// <summary>
    /// Function: GetHidePointWireClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetHidePointWireClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHidePointWireClass, "BmScript.MBMWeaponDeathStrokeDualClaw.GetHidePointWireClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDualClawProjectileClass;
    /// <summary>
    /// Function: GetDualClawProjectileClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetDualClawProjectileClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDualClawProjectileClass, "BmScript.MBMWeaponDeathStrokeDualClaw.GetDualClawProjectileClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDualClawConfig;
    /// <summary>
    /// Function: GetDualClawConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MInventoryGadgetConfig_DualClawBase GetDualClawConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDualClawConfig, "BmScript.MBMWeaponDeathStrokeDualClaw.GetDualClawConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MInventoryGadgetConfig_DualClawBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateWeaponConfig;
    /// <summary>
    /// Function: CreateWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateWeaponConfig(BmSDK.GameObject NewOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfig, "BmScript.MBMWeaponDeathStrokeDualClaw.CreateWeaponConfig");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CreateCombatWeaponConfig;
    /// <summary>
    /// Function: CreateCombatWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateCombatWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateCombatWeaponConfig, "BmScript.MBMWeaponDeathStrokeDualClaw.CreateCombatWeaponConfig");
        byte* paramsPtr = stackalloc byte[744];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSets, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetRemoteClawAimingConfig;
    /// <summary>
    /// Function: GetRemoteClawAimingConfig
    /// </summary>
    public unsafe static BmSDK.BmGame.RAimingConfig GetRemoteClawAimingConfig()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRemoteClawAimingConfig, "BmScript.MBMWeaponDeathStrokeDualClaw.GetRemoteClawAimingConfig");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAimingConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetTargets;
    /// <summary>
    /// Function: ResetTargets
    /// </summary>
    public unsafe virtual void ResetTargets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetTargets, "BmScript.MBMWeaponDeathStrokeDualClaw.ResetTargets");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffVisibleSight;
    /// <summary>
    /// Function: TurnOffVisibleSight
    /// </summary>
    public unsafe virtual void TurnOffVisibleSight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffVisibleSight, "BmScript.MBMWeaponDeathStrokeDualClaw.TurnOffVisibleSight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnVisibleSight;
    /// <summary>
    /// Function: TurnOnVisibleSight
    /// </summary>
    public unsafe virtual void TurnOnVisibleSight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnVisibleSight, "BmScript.MBMWeaponDeathStrokeDualClaw.TurnOnVisibleSight");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateLaserSight;
    /// <summary>
    /// Function: UpdateLaserSight
    /// </summary>
    public unsafe virtual void UpdateLaserSight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLaserSight, "BmScript.MBMWeaponDeathStrokeDualClaw.UpdateLaserSight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAimingPositionFromTarget;
    /// <summary>
    /// Function: GetAimingPositionFromTarget
    /// </summary>
    public unsafe virtual void GetAimingPositionFromTarget(BmSDK.Engine.Actor Target, int socketIndex, out System.Numerics.Vector3 AimPos, out BmSDK.FName aimSocket)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAimingPositionFromTarget, "BmScript.MBMWeaponDeathStrokeDualClaw.GetAimingPositionFromTarget");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(socketIndex, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AimPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimPos, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out aimSocket);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aimSocket, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AimPos = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        aimSocket = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_FireProjectileShowTime;
    /// <summary>
    /// Function: FireProjectileShowTime
    /// </summary>
    public unsafe virtual void FireProjectileShowTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireProjectileShowTime, "BmScript.MBMWeaponDeathStrokeDualClaw.FireProjectileShowTime");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireClusterProjectile;
    /// <summary>
    /// Function: FireClusterProjectile
    /// </summary>
    public unsafe virtual void FireClusterProjectile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireClusterProjectile, "BmScript.MBMWeaponDeathStrokeDualClaw.FireClusterProjectile");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.MBMWeaponDeathStrokeDualClaw.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DualClawFire;
    /// <summary>
    /// Function: DualClawFire
    /// </summary>
    public unsafe virtual void DualClawFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DualClawFire, "BmScript.MBMWeaponDeathStrokeDualClaw.DualClawFire");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWire;
    /// <summary>
    /// Function: GetWire
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint_RopeBase GetWire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWire, "BmScript.MBMWeaponDeathStrokeDualClaw.GetWire");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHidePoint_RopeBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsRopeHookToRopeHookComplete;
    /// <summary>
    /// Function: IsRopeHookToRopeHookComplete
    /// </summary>
    public unsafe virtual bool IsRopeHookToRopeHookComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRopeHookToRopeHookComplete, "BmScript.MBMWeaponDeathStrokeDualClaw.IsRopeHookToRopeHookComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ThrowObjectAt;
    /// <summary>
    /// Function: ThrowObjectAt
    /// </summary>
    public unsafe virtual void ThrowObjectAt(BmSDK.Engine.Actor TargetActor, float CustomDamageAmount = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowObjectAt, "BmScript.MBMWeaponDeathStrokeDualClaw.ThrowObjectAt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomDamageAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AimObject;
    /// <summary>
    /// Function: AimObject
    /// </summary>
    public unsafe virtual void AimObject(BmSDK.Engine.Actor TargetObject)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimObject, "BmScript.MBMWeaponDeathStrokeDualClaw.AimObject");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawPos;
    /// <summary>
    /// Function: DrawPos
    /// </summary>
    public unsafe virtual void DrawPos(BmSDK.Engine.Canvas HudCanvas, System.Numerics.Vector3 PosToDraw, int CursorIndex, BmSDK.FString AnimName, bool ClearCursor = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawPos, "BmScript.MBMWeaponDeathStrokeDualClaw.DrawPos");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudCanvas, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosToDraw, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClearCursor, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFireSoundWithCam;
    /// <summary>
    /// Function: StopFireSoundWithCam
    /// </summary>
    public unsafe virtual void StopFireSoundWithCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFireSoundWithCam, "BmScript.MBMWeaponDeathStrokeDualClaw.StopFireSoundWithCam");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFirstFireSound;
    /// <summary>
    /// Function: PlayFirstFireSound
    /// </summary>
    public unsafe virtual void PlayFirstFireSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFirstFireSound, "BmScript.MBMWeaponDeathStrokeDualClaw.PlayFirstFireSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnClusterProjectile;
    /// <summary>
    /// Function: SpawnClusterProjectile
    /// </summary>
    public unsafe virtual void SpawnClusterProjectile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnClusterProjectile, "BmScript.MBMWeaponDeathStrokeDualClaw.SpawnClusterProjectile");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.MBMWeaponDeathStrokeDualClaw.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: mAimingTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor mAimingTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// StructProperty: mAimingTargetPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mAimingTargetPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1128);

    /// <summary>
    /// NameProperty: mAimingTargetSocket
    /// </summary>
    public unsafe BmSDK.FName mAimingTargetSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// IntProperty: mAimingTargetSocketIndex
    /// </summary>
    public unsafe int mAimingTargetSocketIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// ObjectProperty: mPrimaryTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor mPrimaryTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// StructProperty: mPrimaryTargetPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mPrimaryTargetPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1156);

    /// <summary>
    /// NameProperty: mPrimaryTargetSocket
    /// </summary>
    public unsafe BmSDK.FName mPrimaryTargetSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// IntProperty: mPrimaryTargetSocketIndex
    /// </summary>
    public unsafe int mPrimaryTargetSocketIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ObjectProperty: mSecondaryTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor mSecondaryTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// StructProperty: mSecondaryTargetPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mSecondaryTargetPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1184);

    /// <summary>
    /// NameProperty: mSecondaryTargetSocket
    /// </summary>
    public unsafe BmSDK.FName mSecondaryTargetSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// IntProperty: mSecondaryTargetSocketIndex
    /// </summary>
    public unsafe int mSecondaryTargetSocketIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// ClassProperty: mHidePointWireClass
    /// </summary>
    public unsafe BmSDK.Class mHidePointWireClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// ClassProperty: mDualClawProjectileClass
    /// </summary>
    public unsafe BmSDK.Class mDualClawProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// ClassProperty: mDualClawClusterProjectileClass
    /// </summary>
    public unsafe BmSDK.Class mDualClawClusterProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ComponentProperty: LaserSight
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent LaserSight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: mClusterProjectile
    /// </summary>
    public InlineArray<BmSDK.BmGame.MDualClawClusterProjectile> mClusterProjectile => new(6, Ptr + 1224, 4, this);

    /// <summary>
    /// ObjectProperty: mClusterProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile mClusterProjectile_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }
    /// <summary>
    /// ObjectProperty: mClusterProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile mClusterProjectile_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }
    /// <summary>
    /// ObjectProperty: mClusterProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile mClusterProjectile_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }
    /// <summary>
    /// ObjectProperty: mClusterProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile mClusterProjectile_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }
    /// <summary>
    /// ObjectProperty: mClusterProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile mClusterProjectile_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }
    /// <summary>
    /// ObjectProperty: mClusterProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile mClusterProjectile_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// IntProperty: mCurrentActiveClusterIndex
    /// </summary>
    public unsafe int mCurrentActiveClusterIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// BoolProperty: mIsInDualClawMode
    /// </summary>
    public unsafe bool mIsInDualClawMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1252) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1252); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1252); }
    }

    /// <summary>
    /// ObjectProperty: mRedLaserEffectMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant mRedLaserEffectMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ObjectProperty: mGreenLaserEffectMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant mGreenLaserEffectMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// ObjectProperty: mDualClawConfig
    /// </summary>
    public unsafe BmSDK.BmGame.MInventoryGadgetConfig_DualClawBase mDualClawConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MInventoryGadgetConfig_DualClawBase>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// ObjectProperty: GadgetConfig
    /// </summary>
    public unsafe BmSDK.BmGame.MInventoryGadgetConfig GadgetConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MInventoryGadgetConfig>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// ObjectProperty: mCurrentClusterProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile mCurrentClusterProjectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }
}
