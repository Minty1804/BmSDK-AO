#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: MSockGrenadeGadgetBase<br/>
/// (size = 1428)
/// (flags = 142606515)
/// </summary>
public partial class MSockGrenadeGadgetBase : BmSDK.BmGame.RProjectileGadgetBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MSockGrenadeGadgetBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MSockGrenadeGadgetBase.
    /// </summary>
    public static MSockGrenadeGadgetBase DefaultObject => (MSockGrenadeGadgetBase)StaticClass().DefaultObject;

    internal MSockGrenadeGadgetBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MSockGrenadeGadgetBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSockGrenadeGadgetBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSockGrenadeGadgetBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSockGrenadeGadgetBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSockGrenadeGadgetBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSockGrenadeGadgetBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSockGrenadeGadgetBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSockGrenadeGadgetBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSockGrenadeGadgetBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpdateCapeBlendWeights;
    /// <summary>
    /// Function: UpdateCapeBlendWeights
    /// </summary>
    public unsafe virtual void UpdateCapeBlendWeights(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCapeBlendWeights, "BmGame.MSockGrenadeGadgetBase.UpdateCapeBlendWeights");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AimAndDrawHUD;
    /// <summary>
    /// Function: AimAndDrawHUD
    /// </summary>
    public unsafe override void AimAndDrawHUD(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimAndDrawHUD, "BmGame.MSockGrenadeGadgetBase.AimAndDrawHUD");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerBlastHitEvent;
    /// <summary>
    /// Function: TriggerBlastHitEvent
    /// </summary>
    public unsafe virtual void TriggerBlastHitEvent(BmSDK.Class ClusterGreandeGadgetHit)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerBlastHitEvent, "BmGame.MSockGrenadeGadgetBase.TriggerBlastHitEvent");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClusterGreandeGadgetHit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoFloorBlastEffects;
    /// <summary>
    /// Function: DoFloorBlastEffects
    /// </summary>
    public unsafe virtual void DoFloorBlastEffects(System.Numerics.Vector3 Position, bool bNoGroundParticles = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoFloorBlastEffects, "BmGame.MSockGrenadeGadgetBase.DoFloorBlastEffects");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoGroundParticles, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitFloorBlastVictims;
    /// <summary>
    /// Function: HitFloorBlastVictims
    /// </summary>
    public unsafe virtual bool HitFloorBlastVictims(System.Numerics.Vector3 CheckLocation, bool bAsCluster)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitFloorBlastVictims, "BmGame.MSockGrenadeGadgetBase.HitFloorBlastVictims");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAsCluster, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_HitVictimLegs;
    /// <summary>
    /// Function: HitVictimLegs
    /// </summary>
    public unsafe virtual bool HitVictimLegs(BmSDK.BmGame.RPawnVillain Victim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitVictimLegs, "BmGame.MSockGrenadeGadgetBase.HitVictimLegs");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetGlueDurationMultiplier;
    /// <summary>
    /// Function: GetGlueDurationMultiplier
    /// </summary>
    public unsafe virtual float GetGlueDurationMultiplier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlueDurationMultiplier, "BmGame.MSockGrenadeGadgetBase.GetGlueDurationMultiplier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnFogSphere;
    /// <summary>
    /// Function: SpawnFogSphere
    /// </summary>
    public unsafe virtual void SpawnFogSphere(System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFogSphere, "BmGame.MSockGrenadeGadgetBase.SpawnFogSphere");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSockVillain;
    /// <summary>
    /// Function: CanSockVillain
    /// </summary>
    public unsafe virtual bool CanSockVillain(BmSDK.BmGame.RPawnVillain Villain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSockVillain, "BmGame.MSockGrenadeGadgetBase.CanSockVillain");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RefuseToThrow;
    /// <summary>
    /// Function: RefuseToThrow
    /// </summary>
    public unsafe override bool RefuseToThrow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefuseToThrow, "BmGame.MSockGrenadeGadgetBase.RefuseToThrow");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayThrowSound;
    /// <summary>
    /// Function: PlayThrowSound
    /// </summary>
    public unsafe virtual void PlayThrowSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayThrowSound, "BmGame.MSockGrenadeGadgetBase.PlayThrowSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckAutoTarget;
    /// <summary>
    /// Function: CheckAutoTarget
    /// </summary>
    public unsafe override bool CheckAutoTarget(BmSDK.Engine.Actor Target, out System.Numerics.Vector3 TargetPosition, out float OverridePriority, out float OverrideMaxRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAutoTarget, "BmGame.MSockGrenadeGadgetBase.CheckAutoTarget");
        byte* paramsPtr = stackalloc byte[52];
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

    private static BmSDK.Function __fn_GetOverridePriority;
    /// <summary>
    /// Function: GetOverridePriority
    /// </summary>
    public unsafe virtual void GetOverridePriority(BmSDK.BmGame.RPawnVillain TargetVillain, out float OverridePriority)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverridePriority, "BmGame.MSockGrenadeGadgetBase.GetOverridePriority");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetVillain, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverridePriority);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridePriority, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OverridePriority = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_FindAutoTarget;
    /// <summary>
    /// Function: FindAutoTarget
    /// </summary>
    public unsafe override BmSDK.Engine.Actor FindAutoTarget(System.Numerics.Vector3 LaunchPosition, BmSDK.Rotator LaunchAngle, float Range, float TargetAngle, out int PositionIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAutoTarget, "BmGame.MSockGrenadeGadgetBase.FindAutoTarget");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchAngle, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Range, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetAngle, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PositionIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PositionIndex, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PositionIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetProjectileTargetLocation;
    /// <summary>
    /// Function: GetProjectileTargetLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetProjectileTargetLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProjectileTargetLocation, "BmGame.MSockGrenadeGadgetBase.GetProjectileTargetLocation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AttachToHand;
    /// <summary>
    /// Function: AttachToHand
    /// </summary>
    public unsafe override void AttachToHand(BmSDK.FName CustomBone = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToHand, "BmGame.MSockGrenadeGadgetBase.AttachToHand");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomBone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetClusterStance;
    /// <summary>
    /// Function: SetClusterStance
    /// </summary>
    public unsafe virtual void SetClusterStance(bool bIsCluster)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClusterStance, "BmGame.MSockGrenadeGadgetBase.SetClusterStance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsCluster, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerThrowProjectile;
    /// <summary>
    /// Function: ServerThrowProjectile
    /// </summary>
    public unsafe override void ServerThrowProjectile(System.Numerics.Vector3 LaunchLocation, System.Numerics.Vector3 TargetLoc, System.Numerics.Vector3 InitialVel, bool bSecondary, BmSDK.Engine.Actor Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerThrowProjectile, "BmGame.MSockGrenadeGadgetBase.ServerThrowProjectile");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialVel, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSecondary, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.MSockGrenadeGadgetBase.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFundamentalGrenadeGadget;
    /// <summary>
    /// Function: GetFundamentalGrenadeGadget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MPawnVillain_FundamentalGrenadeGadget GetFundamentalGrenadeGadget(BmSDK.BmGame.RPawnVillain VillainTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFundamentalGrenadeGadget, "BmGame.MSockGrenadeGadgetBase.GetFundamentalGrenadeGadget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MPawnVillain_FundamentalGrenadeGadget>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetLookAtRotator;
    /// <summary>
    /// Function: GetLookAtRotator
    /// </summary>
    public unsafe static BmSDK.Rotator GetLookAtRotator(System.Numerics.Vector3 Direction, System.Numerics.Vector3 Up)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLookAtRotator, "BmGame.MSockGrenadeGadgetBase.GetLookAtRotator");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Up, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 24);
    }

    /// <summary>
    /// FloatProperty: TargetCapeBlendWeight
    /// </summary>
    public unsafe float TargetCapeBlendWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ObjectProperty: ThrowSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ThrowSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// ByteProperty: GadgetUnlockUpgrade
    /// </summary>
    public unsafe BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility GadgetUnlockUpgrade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ByteProperty: GadgetUnlockSecondaryFireUpgrade
    /// </summary>
    public unsafe BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility GadgetUnlockSecondaryFireUpgrade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility>(Ptr + 1373); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1373); }
    }

    /// <summary>
    /// ByteProperty: HitFloorBlastDoublePredChallenge
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge HitFloorBlastDoublePredChallenge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 1374); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1374); }
    }

    /// <summary>
    /// ByteProperty: HitFloorBlastChallenge
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.EBatmanChallenge HitFloorBlastChallenge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.EBatmanChallenge>(Ptr + 1375); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1375); }
    }

    /// <summary>
    /// StrProperty: GadgetGlobalFlagNewGamePlus
    /// </summary>
    public unsafe BmSDK.FString GadgetGlobalFlagNewGamePlus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// ClassProperty: FogClass
    /// </summary>
    public unsafe BmSDK.Class FogClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// ComponentProperty: HandGrenade
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HandGrenade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// StructProperty: HandGrenadeOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HandGrenadeOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1396);

    /// <summary>
    /// FloatProperty: BlastRadius
    /// </summary>
    public unsafe float BlastRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// ObjectProperty: ExplodeEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ExplodeEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// ObjectProperty: VictimBlastParticles
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem VictimBlastParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// ObjectProperty: GroundBlastParticles
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GroundBlastParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// BoolProperty: bHasClusterUpgrade
    /// </summary>
    public unsafe bool bHasClusterUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }

    /// <summary>
    /// BoolProperty: bThrowingAsClusterGrenade
    /// </summary>
    public unsafe bool bThrowingAsClusterGrenade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }

    /// <summary>
    /// BoolProperty: bHasJustThrownGrenade
    /// </summary>
    public unsafe bool bHasJustThrownGrenade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }
}

/// <summary>
/// The static native functions of MSockGrenadeGadgetBase, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class MSockGrenadeGadgetBaseStatics
{
    private static BmSDK.Function __fn_GetLookAtRotator;
    /// <summary>
    /// Function: GetLookAtRotator, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static BmSDK.Rotator GetLookAtRotator(this BmSDK.BmGame.MSockGrenadeGadgetBase self, System.Numerics.Vector3 Direction, System.Numerics.Vector3 Up)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLookAtRotator, "BmGame.MSockGrenadeGadgetBase.GetLookAtRotator");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Up, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 24);
    }
}
