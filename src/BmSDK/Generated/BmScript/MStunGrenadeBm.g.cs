#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MStunGrenadeBm<br/>
/// (size = 1440)
/// (flags = 8388658)
/// </summary>
public partial class MStunGrenadeBm : BmSDK.BmGame.MGrenadeGadgetBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MStunGrenadeBm", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MStunGrenadeBm.
    /// </summary>
    public static MStunGrenadeBm DefaultObject => (MStunGrenadeBm)StaticClass().DefaultObject;

    internal MStunGrenadeBm() { }

    /// <summary>
    /// Constructs a new MStunGrenadeBm
    /// </summary>
    public MStunGrenadeBm(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MStunGrenadeBm(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStunGrenadeBm>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStunGrenadeBm>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStunGrenadeBm>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStunGrenadeBm>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStunGrenadeBm>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStunGrenadeBm>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStunGrenadeBm>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStunGrenadeBm>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetProjectileTargetLocation;
    /// <summary>
    /// Function: GetProjectileTargetLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetProjectileTargetLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProjectileTargetLocation, "BmScript.MStunGrenadeBm.GetProjectileTargetLocation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckAutoTarget;
    /// <summary>
    /// Function: CheckAutoTarget
    /// </summary>
    public unsafe override bool CheckAutoTarget(BmSDK.Engine.Actor Target, out System.Numerics.Vector3 TargetPosition, out float OverridePriority, out float OverrideMaxRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAutoTarget, "BmScript.MStunGrenadeBm.CheckAutoTarget");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TargetPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPosition, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverridePriority);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridePriority, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverrideMaxRange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaxRange, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TargetPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        OverridePriority = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        OverrideMaxRange = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_UpdateAutoTarget;
    /// <summary>
    /// Function: UpdateAutoTarget
    /// </summary>
    public unsafe override void UpdateAutoTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAutoTarget, "BmScript.MStunGrenadeBm.UpdateAutoTarget");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProjectileDetonate;
    /// <summary>
    /// Function: ProjectileDetonate
    /// </summary>
    public unsafe override void ProjectileDetonate(BmSDK.BmGame.RPawnVillain DeployedVillain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectileDetonate, "BmScript.MStunGrenadeBm.ProjectileDetonate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeployedVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireGadgetCombat;
    /// <summary>
    /// Function: FireGadgetCombat
    /// </summary>
    public unsafe override bool FireGadgetCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireGadgetCombat, "BmScript.MStunGrenadeBm.FireGadgetCombat");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ProjectileTimeOut;
    /// <summary>
    /// Function: ProjectileTimeOut
    /// </summary>
    public unsafe virtual void ProjectileTimeOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectileTimeOut, "BmScript.MStunGrenadeBm.ProjectileTimeOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Throw;
    /// <summary>
    /// Function: Throw
    /// </summary>
    public unsafe override bool Throw(bool bSecondary = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Throw, "BmScript.MStunGrenadeBm.Throw");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSecondary, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanQuickFire;
    /// <summary>
    /// Function: CanQuickFire
    /// </summary>
    public unsafe override bool CanQuickFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanQuickFire, "BmScript.MStunGrenadeBm.CanQuickFire");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmScript.MStunGrenadeBm.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestoreMoveInput;
    /// <summary>
    /// Function: RestoreMoveInput
    /// </summary>
    public unsafe virtual void RestoreMoveInput()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreMoveInput, "BmScript.MStunGrenadeBm.RestoreMoveInput");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldFirePowerGadgetGrenade;
    /// <summary>
    /// Function: ShouldFirePowerGadgetGrenade
    /// </summary>
    public unsafe virtual bool ShouldFirePowerGadgetGrenade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldFirePowerGadgetGrenade, "BmScript.MStunGrenadeBm.ShouldFirePowerGadgetGrenade");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_QuickFire;
    /// <summary>
    /// Function: QuickFire
    /// </summary>
    public unsafe override void QuickFire(bool OverridesCombatMove = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickFire, "BmScript.MStunGrenadeBm.QuickFire");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridesCombatMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopGetOutSound;
    /// <summary>
    /// Function: StopGetOutSound
    /// </summary>
    public unsafe override void StopGetOutSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGetOutSound, "BmScript.MStunGrenadeBm.StopGetOutSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayThrowSound;
    /// <summary>
    /// Function: PlayThrowSound
    /// </summary>
    public unsafe override void PlayThrowSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayThrowSound, "BmScript.MStunGrenadeBm.PlayThrowSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayGetOutSound;
    /// <summary>
    /// Function: PlayGetOutSound
    /// </summary>
    public unsafe override void PlayGetOutSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayGetOutSound, "BmScript.MStunGrenadeBm.PlayGetOutSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyProjectile;
    /// <summary>
    /// Function: DestroyProjectile
    /// </summary>
    public unsafe virtual void DestroyProjectile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyProjectile, "BmScript.MStunGrenadeBm.DestroyProjectile");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetClusterStance;
    /// <summary>
    /// Function: SetClusterStance
    /// </summary>
    public unsafe override void SetClusterStance(bool bIsCluster)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClusterStance, "BmScript.MStunGrenadeBm.SetClusterStance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsCluster, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefuseToThrow;
    /// <summary>
    /// Function: RefuseToThrow
    /// </summary>
    public unsafe override bool RefuseToThrow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefuseToThrow, "BmScript.MStunGrenadeBm.RefuseToThrow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetProjectileThrowAnim;
    /// <summary>
    /// Function: GetProjectileThrowAnim
    /// </summary>
    public unsafe override BmSDK.FName GetProjectileThrowAnim(BmSDK.Rotator ThrowDirection, out BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc AimingConfig, bool Mirrored)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProjectileThrowAnim, "BmScript.MStunGrenadeBm.GetProjectileThrowAnim");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDirection, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AimingConfig);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimingConfig, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AimingConfig = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetPrimedPose;
    /// <summary>
    /// Function: GetPrimedPose
    /// </summary>
    public unsafe override BmSDK.FName GetPrimedPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess, bool InSoftCover, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.FName OutCapeState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrimedPose, "BmScript.MStunGrenadeBm.GetPrimedPose");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StanceIsCrouched);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StanceIsCrouched, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MirroredNess);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredNess, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCapeState);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCapeState, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StanceIsCrouched = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch>(paramsPtr + 0);
        MirroredNess = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(paramsPtr + 1);
        OutCapeState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ProjectileSpawned;
    /// <summary>
    /// Function: ProjectileSpawned
    /// </summary>
    public unsafe override void ProjectileSpawned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectileSpawned, "BmScript.MStunGrenadeBm.ProjectileSpawned");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bPlayedGetOutSound
    /// </summary>
    public unsafe bool bPlayedGetOutSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1432) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1432); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1432); }
    }

    /// <summary>
    /// BoolProperty: bThrowGrenade
    /// </summary>
    public unsafe bool bThrowGrenade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1432) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1432); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1432); }
    }

    /// <summary>
    /// BoolProperty: bShouldDetonateInstantly
    /// </summary>
    public unsafe bool bShouldDetonateInstantly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1432) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1432); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1432); }
    }

    /// <summary>
    /// FloatProperty: MaxLifetime
    /// </summary>
    public unsafe float MaxLifetime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }
}
