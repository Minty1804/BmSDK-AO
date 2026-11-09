#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MPawnVillainFirefly<br/>
/// (size = 4844)
/// (flags = 10485814)
/// </summary>
public partial class MPawnVillainFirefly : BmSDK.BmGame.MPawnVillainFireflyBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MPawnVillainFirefly", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnVillainFirefly.
    /// </summary>
    public static MPawnVillainFirefly DefaultObject => (MPawnVillainFirefly)StaticClass().DefaultObject;

    internal MPawnVillainFirefly() { }

    /// <summary>
    /// Constructs a new MPawnVillainFirefly
    /// </summary>
    public MPawnVillainFirefly(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnVillainFirefly(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFirefly>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFirefly>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFirefly>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFirefly>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFirefly>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFirefly>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFirefly>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFirefly>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CreateBatmansBossWeaponConfig;
    /// <summary>
    /// Function: CreateBatmansBossWeaponConfig
    /// </summary>
    public unsafe override void CreateBatmansBossWeaponConfig(BmSDK.BmGame.RPawnPlayerCombat Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateBatmansBossWeaponConfig, "BmScript.MPawnVillainFirefly.CreateBatmansBossWeaponConfig");
        byte* paramsPtr = stackalloc byte[3308];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FakeUnarmedCombatRef;
    /// <summary>
    /// Function: FakeUnarmedCombatRef
    /// </summary>
    public unsafe virtual BmSDK.GameObject FakeUnarmedCombatRef()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeUnarmedCombatRef, "BmScript.MPawnVillainFirefly.FakeUnarmedCombatRef");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnSpecialAttack;
    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe override bool SpawnSpecialAttack(BmSDK.BmGame.RPawnCombat PPawn, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialAttack, "BmScript.MPawnVillainFirefly.SpawnSpecialAttack");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UpdateJetPackSound;
    /// <summary>
    /// Function: UpdateJetPackSound
    /// </summary>
    public unsafe virtual void UpdateJetPackSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateJetPackSound, "BmScript.MPawnVillainFirefly.UpdateJetPackSound");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopJetPackFX;
    /// <summary>
    /// Function: StopJetPackFX
    /// </summary>
    public unsafe virtual void StopJetPackFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopJetPackFX, "BmScript.MPawnVillainFirefly.StopJetPackFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartJetPackFX;
    /// <summary>
    /// Function: StartJetPackFX
    /// </summary>
    public unsafe virtual void StartJetPackFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartJetPackFX, "BmScript.MPawnVillainFirefly.StartJetPackFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateChargeUpFX;
    /// <summary>
    /// Function: ActivateChargeUpFX
    /// </summary>
    public unsafe virtual void ActivateChargeUpFX(bool Active)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateChargeUpFX, "BmScript.MPawnVillainFirefly.ActivateChargeUpFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmScript.MPawnVillainFirefly.GetThoughts");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_HitWall;
    /// <summary>
    /// Function: HitWall
    /// </summary>
    public unsafe override void HitWall(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent WallComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitWall, "BmScript.MPawnVillainFirefly.HitWall");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallComp, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Touch;
    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe override void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Touch, "BmScript.MPawnVillainFirefly.Touch");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatBehaviourClass;
    /// <summary>
    /// Function: GetCombatBehaviourClass
    /// </summary>
    public unsafe override BmSDK.Class GetCombatBehaviourClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatBehaviourClass, "BmScript.MPawnVillainFirefly.GetCombatBehaviourClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmScript.MPawnVillainFirefly.Died");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_AllowRetractionOnDualClawRope;
    /// <summary>
    /// Function: AllowRetractionOnDualClawRope
    /// </summary>
    public unsafe override bool AllowRetractionOnDualClawRope(BmSDK.BmGame.MDualClawProjectile DCP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowRetractionOnDualClawRope, "BmScript.MPawnVillainFirefly.AllowRetractionOnDualClawRope");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DCP, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayHitFX;
    /// <summary>
    /// Function: PlayHitFX
    /// </summary>
    public unsafe virtual void PlayHitFX(float FXScale)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitFX, "BmScript.MPawnVillainFirefly.PlayHitFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FXScale, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TOW_Strike;
    /// <summary>
    /// Function: TOW_Strike
    /// </summary>
    public unsafe virtual void TOW_Strike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TOW_Strike, "BmScript.MPawnVillainFirefly.TOW_Strike");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TOW_LightStrike;
    /// <summary>
    /// Function: TOW_LightStrike
    /// </summary>
    public unsafe virtual void TOW_LightStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TOW_LightStrike, "BmScript.MPawnVillainFirefly.TOW_LightStrike");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleRemoteClawed;
    /// <summary>
    /// Function: HandleRemoteClawed
    /// </summary>
    public unsafe virtual void HandleRemoteClawed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleRemoteClawed, "BmScript.MPawnVillainFirefly.HandleRemoteClawed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleExplosiveGelImpact;
    /// <summary>
    /// Function: HandleExplosiveGelImpact
    /// </summary>
    public unsafe virtual void HandleExplosiveGelImpact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleExplosiveGelImpact, "BmScript.MPawnVillainFirefly.HandleExplosiveGelImpact");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverrideHarpoonHit;
    /// <summary>
    /// Function: OverrideHarpoonHit
    /// </summary>
    public unsafe override bool OverrideHarpoonHit(BmSDK.BmGame.RPawnPlayer BMPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideHarpoonHit, "BmScript.MPawnVillainFirefly.OverrideHarpoonHit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BMPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDodgeClass;
    /// <summary>
    /// Function: GetDodgeClass
    /// </summary>
    public unsafe override BmSDK.Class GetDodgeClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDodgeClass, "BmScript.MPawnVillainFirefly.GetDodgeClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckDodgeProjectile;
    /// <summary>
    /// Function: CheckDodgeProjectile
    /// </summary>
    public unsafe override bool CheckDodgeProjectile(BmSDK.BmGame.RPawn Thrower, BmSDK.FName TargetBone, System.Numerics.Vector3 ProjPos, int BatarangID, bool bForceDodge = default, bool bSteerableProj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDodgeProjectile, "BmScript.MPawnVillainFirefly.CheckDodgeProjectile");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBone, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangID, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDodge, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSteerableProj, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ShouldStartFinalBlowCam;
    /// <summary>
    /// Function: ShouldStartFinalBlowCam
    /// </summary>
    public unsafe override bool ShouldStartFinalBlowCam(float StrikeDamageAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStartFinalBlowCam, "BmScript.MPawnVillainFirefly.ShouldStartFinalBlowCam");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDamageAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultHitReactionClass;
    /// <summary>
    /// Function: GetDefaultHitReactionClass
    /// </summary>
    public unsafe override BmSDK.Class GetDefaultHitReactionClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultHitReactionClass, "BmScript.MPawnVillainFirefly.GetDefaultHitReactionClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerAttackTarget;
    /// <summary>
    /// Function: TriggerAttackTarget
    /// </summary>
    public unsafe virtual void TriggerAttackTarget(bool bCanFollowBatman, System.Numerics.Vector3 FindPostion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerAttackTarget, "BmScript.MPawnVillainFirefly.TriggerAttackTarget");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFollowBatman, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FindPostion, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsTargetatble;
    /// <summary>
    /// Function: IsTargetatble
    /// </summary>
    public unsafe virtual bool IsTargetatble()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTargetatble, "BmScript.MPawnVillainFirefly.IsTargetatble");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatarangSpeedBoost;
    /// <summary>
    /// Function: GetBatarangSpeedBoost
    /// </summary>
    public unsafe override float GetBatarangSpeedBoost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangSpeedBoost, "BmScript.MPawnVillainFirefly.GetBatarangSpeedBoost");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ForceHitAtEndOfFlight;
    /// <summary>
    /// Function: ForceHitAtEndOfFlight
    /// </summary>
    public unsafe override bool ForceHitAtEndOfFlight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceHitAtEndOfFlight, "BmScript.MPawnVillainFirefly.ForceHitAtEndOfFlight");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatarangPriority;
    /// <summary>
    /// Function: GetBatarangPriority
    /// </summary>
    public unsafe override float GetBatarangPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangPriority, "BmScript.MPawnVillainFirefly.GetBatarangPriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBatarangable;
    /// <summary>
    /// Function: IsBatarangable
    /// </summary>
    public unsafe override bool IsBatarangable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatarangable, "BmScript.MPawnVillainFirefly.IsBatarangable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateWeaponConfigUnarmed;
    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfigUnarmed, "BmScript.MPawnVillainFirefly.CreateWeaponConfigUnarmed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CreateBasicWeaponConfig;
    /// <summary>
    /// Function: CreateBasicWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateBasicWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets, BmSDK.Engine.AnimSet TurnAnimSet = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateBasicWeaponConfig, "BmScript.MPawnVillainFirefly.CreateBasicWeaponConfig");
        byte* paramsPtr = stackalloc byte[10212];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSets, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnAnimSet, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_CanBeTargettedByPlayer;
    /// <summary>
    /// Function: CanBeTargettedByPlayer
    /// </summary>
    public unsafe override bool CanBeTargettedByPlayer(BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTargettedByPlayer, "BmScript.MPawnVillainFirefly.CanBeTargettedByPlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCombatStance;
    /// <summary>
    /// Function: GetCombatStance
    /// </summary>
    public unsafe override BmSDK.FName GetCombatStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatStance, "BmScript.MPawnVillainFirefly.GetCombatStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopFiringAttack;
    /// <summary>
    /// Function: StopFiringAttack
    /// </summary>
    public unsafe override void StopFiringAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFiringAttack, "BmScript.MPawnVillainFirefly.StopFiringAttack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LightMyRightSide;
    /// <summary>
    /// Function: LightMyRightSide
    /// </summary>
    public unsafe virtual void LightMyRightSide()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LightMyRightSide, "BmScript.MPawnVillainFirefly.LightMyRightSide");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LightMyLeftSide;
    /// <summary>
    /// Function: LightMyLeftSide
    /// </summary>
    public unsafe virtual void LightMyLeftSide()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LightMyLeftSide, "BmScript.MPawnVillainFirefly.LightMyLeftSide");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopImpactLPSound;
    /// <summary>
    /// Function: StopImpactLPSound
    /// </summary>
    public unsafe virtual void StopImpactLPSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopImpactLPSound, "BmScript.MPawnVillainFirefly.StopImpactLPSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartImpactLPSound;
    /// <summary>
    /// Function: StartImpactLPSound
    /// </summary>
    public unsafe virtual void StartImpactLPSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartImpactLPSound, "BmScript.MPawnVillainFirefly.StartImpactLPSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPlayingBigHitReact;
    /// <summary>
    /// Function: ClearPlayingBigHitReact
    /// </summary>
    public unsafe virtual void ClearPlayingBigHitReact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPlayingBigHitReact, "BmScript.MPawnVillainFirefly.ClearPlayingBigHitReact");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyHitPlayer;
    /// <summary>
    /// Function: NotifyHitPlayer
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.FDamageInfo NotifyHitPlayer(System.Numerics.Vector3 HitNormal, bool IsFlameBall)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyHitPlayer, "BmScript.MPawnVillainFirefly.NotifyHitPlayer");
        byte* paramsPtr = stackalloc byte[568];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsFlameBall, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_JustHitPlayer;
    /// <summary>
    /// Function: JustHitPlayer
    /// </summary>
    public unsafe virtual void JustHitPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JustHitPlayer, "BmScript.MPawnVillainFirefly.JustHitPlayer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialBallNotifyHitPlayer;
    /// <summary>
    /// Function: SpecialBallNotifyHitPlayer
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.FDamageInfo SpecialBallNotifyHitPlayer(System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialBallNotifyHitPlayer, "BmScript.MPawnVillainFirefly.SpecialBallNotifyHitPlayer");
        byte* paramsPtr = stackalloc byte[540];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ResetPlayerFlameHits;
    /// <summary>
    /// Function: ResetPlayerFlameHits
    /// </summary>
    public unsafe virtual void ResetPlayerFlameHits()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPlayerFlameHits, "BmScript.MPawnVillainFirefly.ResetPlayerFlameHits");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoseTugOfWar;
    /// <summary>
    /// Function: LoseTugOfWar
    /// </summary>
    public unsafe virtual void LoseTugOfWar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoseTugOfWar, "BmScript.MPawnVillainFirefly.LoseTugOfWar");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WinTugOfWar;
    /// <summary>
    /// Function: WinTugOfWar
    /// </summary>
    public unsafe virtual void WinTugOfWar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WinTugOfWar, "BmScript.MPawnVillainFirefly.WinTugOfWar");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndTugOfWar;
    /// <summary>
    /// Function: EndTugOfWar
    /// </summary>
    public unsafe virtual void EndTugOfWar(bool IsLight = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndTugOfWar, "BmScript.MPawnVillainFirefly.EndTugOfWar");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsLight, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RecoverFromSpecialStun;
    /// <summary>
    /// Function: RecoverFromSpecialStun
    /// </summary>
    public unsafe virtual void RecoverFromSpecialStun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecoverFromSpecialStun, "BmScript.MPawnVillainFirefly.RecoverFromSpecialStun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartTugOfWar;
    /// <summary>
    /// Function: StartTugOfWar
    /// </summary>
    public unsafe virtual void StartTugOfWar(bool IsLight = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTugOfWar, "BmScript.MPawnVillainFirefly.StartTugOfWar");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsLight, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNearestAnchorLocation;
    /// <summary>
    /// Function: GetNearestAnchorLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetNearestAnchorLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNearestAnchorLocation, "BmScript.MPawnVillainFirefly.GetNearestAnchorLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBehaviour;
    /// <summary>
    /// Function: GetBehaviour
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMBehaviour_Combat GetBehaviour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBehaviour, "BmScript.MPawnVillainFirefly.GetBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMBehaviour_Combat>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFireflyBehaviour;
    /// <summary>
    /// Function: GetFireflyBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmScript.MBMBehaviour_BossFirefly GetFireflyBehaviour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFireflyBehaviour, "BmScript.MPawnVillainFirefly.GetFireflyBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.MBMBehaviour_BossFirefly>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_KismetBurnGround;
    /// <summary>
    /// Function: KismetBurnGround
    /// </summary>
    public unsafe virtual void KismetBurnGround()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KismetBurnGround, "BmScript.MPawnVillainFirefly.KismetBurnGround");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThrowGrenade;
    /// <summary>
    /// Function: ThrowGrenade
    /// </summary>
    public unsafe override void ThrowGrenade(System.Numerics.Vector3 GrenadeTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowGrenade, "BmScript.MPawnVillainFirefly.ThrowGrenade");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenadeTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThrowGrenadeNotify;
    /// <summary>
    /// Function: ThrowGrenadeNotify
    /// </summary>
    public unsafe virtual void ThrowGrenadeNotify()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowGrenadeNotify, "BmScript.MPawnVillainFirefly.ThrowGrenadeNotify");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThrowIncendiaryGrenadeTo;
    /// <summary>
    /// Function: ThrowIncendiaryGrenadeTo
    /// </summary>
    public unsafe virtual void ThrowIncendiaryGrenadeTo(System.Numerics.Vector3 GrenadeTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowIncendiaryGrenadeTo, "BmScript.MPawnVillainFirefly.ThrowIncendiaryGrenadeTo");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenadeTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThrowIncendiaryGrenade;
    /// <summary>
    /// Function: ThrowIncendiaryGrenade
    /// </summary>
    public unsafe override void ThrowIncendiaryGrenade(System.Numerics.Vector3 GrenadeTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowIncendiaryGrenade, "BmScript.MPawnVillainFirefly.ThrowIncendiaryGrenade");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenadeTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPhaseBSafeLocation;
    /// <summary>
    /// Function: GetPhaseBSafeLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPhaseBSafeLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPhaseBSafeLocation, "BmScript.MPawnVillainFirefly.GetPhaseBSafeLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerNextStage;
    /// <summary>
    /// Function: TriggerNextStage
    /// </summary>
    public unsafe override void TriggerNextStage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerNextStage, "BmScript.MPawnVillainFirefly.TriggerNextStage");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentPhase;
    /// <summary>
    /// Function: SetCurrentPhase
    /// </summary>
    public unsafe virtual void SetCurrentPhase(BmSDK.BmScript.MPawnVillainFirefly.FireflyPhase Phase)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentPhase, "BmScript.MPawnVillainFirefly.SetCurrentPhase");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Phase, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmScript.MPawnVillainFirefly.DamagedBy");
        byte* paramsPtr = stackalloc byte[273];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_CanSkipToNextMove;
    /// <summary>
    /// Function: CanSkipToNextMove
    /// </summary>
    public unsafe virtual void CanSkipToNextMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSkipToNextMove, "BmScript.MPawnVillainFirefly.CanSkipToNextMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Flyend;
    /// <summary>
    /// Function: Flyend
    /// </summary>
    public unsafe virtual void Flyend()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Flyend, "BmScript.MPawnVillainFirefly.Flyend");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Flybegin;
    /// <summary>
    /// Function: Flybegin
    /// </summary>
    public unsafe virtual void Flybegin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Flybegin, "BmScript.MPawnVillainFirefly.Flybegin");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitGluedBeahviour;
    /// <summary>
    /// Function: ExitGluedBeahviour
    /// </summary>
    public unsafe virtual void ExitGluedBeahviour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitGluedBeahviour, "BmScript.MPawnVillainFirefly.ExitGluedBeahviour");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHitReaction;
    /// <summary>
    /// Function: PlayHitReaction
    /// </summary>
    public unsafe override void PlayHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitReaction, "BmScript.MPawnVillainFirefly.PlayHitReaction");
        byte* paramsPtr = stackalloc byte[300];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFXReaction;
    /// <summary>
    /// Function: PlayFXReaction
    /// </summary>
    public unsafe virtual void PlayFXReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFXReaction, "BmScript.MPawnVillainFirefly.PlayFXReaction");
        byte* paramsPtr = stackalloc byte[308];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldGoRagdoll;
    /// <summary>
    /// Function: ShouldGoRagdoll
    /// </summary>
    public unsafe override bool ShouldGoRagdoll(BmSDK.Class dmgType, float DamageAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldGoRagdoll, "BmScript.MPawnVillainFirefly.ShouldGoRagdoll");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ModifyDamageAmount;
    /// <summary>
    /// Function: ModifyDamageAmount
    /// </summary>
    public unsafe override void ModifyDamageAmount(BmSDK.Class dmgType, out float DmgAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyDamageAmount, "BmScript.MPawnVillainFirefly.ModifyDamageAmount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DmgAmount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgAmount = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_CheckSpecialStun;
    /// <summary>
    /// Function: CheckSpecialStun
    /// </summary>
    public unsafe virtual bool CheckSpecialStun(float Damage = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSpecialStun, "BmScript.MPawnVillainFirefly.CheckSpecialStun");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DeActiveStunCam;
    /// <summary>
    /// Function: DeActiveStunCam
    /// </summary>
    public unsafe virtual void DeActiveStunCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeActiveStunCam, "BmScript.MPawnVillainFirefly.DeActiveStunCam");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActiveCustomCam;
    /// <summary>
    /// Function: ActiveCustomCam
    /// </summary>
    public unsafe virtual void ActiveCustomCam(float Duration = default, System.Numerics.Vector3 CameraOffset = default, System.Numerics.Vector3 TargetOffset = default, float BlendInTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActiveCustomCam, "BmScript.MPawnVillainFirefly.ActiveCustomCam");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraOffset, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetOffset, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendInTime, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActiveAttackCam;
    /// <summary>
    /// Function: ActiveAttackCam
    /// </summary>
    public unsafe virtual void ActiveAttackCam(float Duration = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActiveAttackCam, "BmScript.MPawnVillainFirefly.ActiveAttackCam");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActiveStunCam;
    /// <summary>
    /// Function: ActiveStunCam
    /// </summary>
    public unsafe virtual void ActiveStunCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActiveStunCam, "BmScript.MPawnVillainFirefly.ActiveStunCam");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoSlowMoInBatClawCam;
    /// <summary>
    /// Function: DoSlowMoInBatClawCam
    /// </summary>
    public unsafe override bool DoSlowMoInBatClawCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoSlowMoInBatClawCam, "BmScript.MPawnVillainFirefly.DoSlowMoInBatClawCam");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.MPawnVillainFirefly.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KeepInView;
    /// <summary>
    /// Function: KeepInView
    /// </summary>
    public unsafe virtual void KeepInView(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KeepInView, "BmScript.MPawnVillainFirefly.KeepInView");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LookInMyDirection;
    /// <summary>
    /// Function: LookInMyDirection
    /// </summary>
    public unsafe virtual void LookInMyDirection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookInMyDirection, "BmScript.MPawnVillainFirefly.LookInMyDirection");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFireAttackingFX;
    /// <summary>
    /// Function: StopFireAttackingFX
    /// </summary>
    public unsafe virtual void StopFireAttackingFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFireAttackingFX, "BmScript.MPawnVillainFirefly.StopFireAttackingFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartpFireAttackingFX;
    /// <summary>
    /// Function: StartpFireAttackingFX
    /// </summary>
    public unsafe virtual void StartpFireAttackingFX(bool CanBeCounter = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartpFireAttackingFX, "BmScript.MPawnVillainFirefly.StartpFireAttackingFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanBeCounter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanExplodeGel;
    /// <summary>
    /// Function: CanExplodeGel
    /// </summary>
    public unsafe override bool CanExplodeGel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanExplodeGel, "BmScript.MPawnVillainFirefly.CanExplodeGel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ExitRemoteClawed;
    /// <summary>
    /// Function: ExitRemoteClawed
    /// </summary>
    public unsafe virtual void ExitRemoteClawed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitRemoteClawed, "BmScript.MPawnVillainFirefly.ExitRemoteClawed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterRemoteClawed;
    /// <summary>
    /// Function: EnterRemoteClawed
    /// </summary>
    public unsafe virtual void EnterRemoteClawed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterRemoteClawed, "BmScript.MPawnVillainFirefly.EnterRemoteClawed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitTripleBataranged;
    /// <summary>
    /// Function: ExitTripleBataranged
    /// </summary>
    public unsafe virtual void ExitTripleBataranged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitTripleBataranged, "BmScript.MPawnVillainFirefly.ExitTripleBataranged");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetVulnerability;
    /// <summary>
    /// Function: ResetVulnerability
    /// </summary>
    public unsafe virtual void ResetVulnerability()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetVulnerability, "BmScript.MPawnVillainFirefly.ResetVulnerability");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterTripleBataranged;
    /// <summary>
    /// Function: EnterTripleBataranged
    /// </summary>
    public unsafe virtual void EnterTripleBataranged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterTripleBataranged, "BmScript.MPawnVillainFirefly.EnterTripleBataranged");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitExplosiveGeled;
    /// <summary>
    /// Function: ExitExplosiveGeled
    /// </summary>
    public unsafe virtual void ExitExplosiveGeled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitExplosiveGeled, "BmScript.MPawnVillainFirefly.ExitExplosiveGeled");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterExplosiveGeled;
    /// <summary>
    /// Function: EnterExplosiveGeled
    /// </summary>
    public unsafe virtual void EnterExplosiveGeled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterExplosiveGeled, "BmScript.MPawnVillainFirefly.EnterExplosiveGeled");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitGlued;
    /// <summary>
    /// Function: ExitGlued
    /// </summary>
    public unsafe virtual void ExitGlued()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitGlued, "BmScript.MPawnVillainFirefly.ExitGlued");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHitbyGlueBark;
    /// <summary>
    /// Function: PlayHitbyGlueBark
    /// </summary>
    public unsafe virtual void PlayHitbyGlueBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitbyGlueBark, "BmScript.MPawnVillainFirefly.PlayHitbyGlueBark");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterGlued;
    /// <summary>
    /// Function: EnterGlued
    /// </summary>
    public unsafe virtual void EnterGlued()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterGlued, "BmScript.MPawnVillainFirefly.EnterGlued");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFiringAttack;
    /// <summary>
    /// Function: IsFiringAttack
    /// </summary>
    public unsafe override bool IsFiringAttack(bool IsDeploying = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFiringAttack, "BmScript.MPawnVillainFirefly.IsFiringAttack");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsDeploying, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_EnableGlueGrenadeInteraction;
    /// <summary>
    /// Function: EnableGlueGrenadeInteraction
    /// </summary>
    public unsafe virtual void EnableGlueGrenadeInteraction(bool Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableGlueGrenadeInteraction, "BmScript.MPawnVillainFirefly.EnableGlueGrenadeInteraction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActiveGadgetInteraction;
    /// <summary>
    /// Function: ActiveGadgetInteraction
    /// </summary>
    public unsafe virtual void ActiveGadgetInteraction(bool Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActiveGadgetInteraction, "BmScript.MPawnVillainFirefly.ActiveGadgetInteraction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerHintDodgeBatclaw;
    /// <summary>
    /// Function: PlayerHintDodgeBatclaw
    /// </summary>
    public unsafe virtual void PlayerHintDodgeBatclaw()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerHintDodgeBatclaw, "BmScript.MPawnVillainFirefly.PlayerHintDodgeBatclaw");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCheckFalling;
    /// <summary>
    /// Function: CanCheckFalling
    /// </summary>
    public unsafe override bool CanCheckFalling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCheckFalling, "BmScript.MPawnVillainFirefly.CanCheckFalling");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FireBallProjectile;
    /// <summary>
    /// Function: FireBallProjectile
    /// </summary>
    public unsafe virtual void FireBallProjectile(System.Numerics.Vector3 TargetLocation, bool DoFlameBall, bool SpecialProjectile = default, float FireBallSpeed = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireBallProjectile, "BmScript.MPawnVillainFirefly.FireBallProjectile");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DoFlameBall, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialProjectile, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireBallSpeed, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartRagdoll;
    /// <summary>
    /// Function: StartRagdoll
    /// </summary>
    public unsafe virtual void StartRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRagdoll, "BmScript.MPawnVillainFirefly.StartRagdoll");
        byte* paramsPtr = stackalloc byte[284];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnFireWall;
    /// <summary>
    /// Function: SpawnFireWall
    /// </summary>
    public unsafe virtual void SpawnFireWall(System.Numerics.Vector3 TargetLocation, BmSDK.Rotator TargetRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFireWall, "BmScript.MPawnVillainFirefly.SpawnFireWall");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateRoadLaneFlame;
    /// <summary>
    /// Function: UpdateRoadLaneFlame
    /// </summary>
    public unsafe virtual void UpdateRoadLaneFlame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRoadLaneFlame, "BmScript.MPawnVillainFirefly.UpdateRoadLaneFlame");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopRoadLaneFlame;
    /// <summary>
    /// Function: StopRoadLaneFlame
    /// </summary>
    public unsafe virtual void StopRoadLaneFlame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopRoadLaneFlame, "BmScript.MPawnVillainFirefly.StopRoadLaneFlame");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartRoadLaneFlame;
    /// <summary>
    /// Function: StartRoadLaneFlame
    /// </summary>
    public unsafe virtual void StartRoadLaneFlame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRoadLaneFlame, "BmScript.MPawnVillainFirefly.StartRoadLaneFlame");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachSkeletalProps;
    /// <summary>
    /// Function: AttachSkeletalProps
    /// </summary>
    public unsafe override void AttachSkeletalProps()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachSkeletalProps, "BmScript.MPawnVillainFirefly.AttachSkeletalProps");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupPlayerGrapplePoint;
    /// <summary>
    /// Function: SetupPlayerGrapplePoint
    /// </summary>
    public unsafe virtual void SetupPlayerGrapplePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupPlayerGrapplePoint, "BmScript.MPawnVillainFirefly.SetupPlayerGrapplePoint");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "BmScript.MPawnVillainFirefly.TakeDamage");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHealthBar;
    /// <summary>
    /// Function: UpdateHealthBar
    /// </summary>
    public unsafe virtual void UpdateHealthBar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHealthBar, "BmScript.MPawnVillainFirefly.UpdateHealthBar");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckHPMiddlePaseA;
    /// <summary>
    /// Function: CheckHPMiddlePaseA
    /// </summary>
    public unsafe virtual void CheckHPMiddlePaseA()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckHPMiddlePaseA, "BmScript.MPawnVillainFirefly.CheckHPMiddlePaseA");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckHPMiddlePaseB;
    /// <summary>
    /// Function: CheckHPMiddlePaseB
    /// </summary>
    public unsafe virtual void CheckHPMiddlePaseB()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckHPMiddlePaseB, "BmScript.MPawnVillainFirefly.CheckHPMiddlePaseB");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TOWPunchImpact;
    /// <summary>
    /// Function: TOWPunchImpact
    /// </summary>
    public unsafe virtual void TOWPunchImpact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TOWPunchImpact, "BmScript.MPawnVillainFirefly.TOWPunchImpact");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateGrappleSpecialMove;
    /// <summary>
    /// Function: ActivateGrappleSpecialMove
    /// </summary>
    public unsafe virtual void ActivateGrappleSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateGrappleSpecialMove, "BmScript.MPawnVillainFirefly.ActivateGrappleSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TeleportForGrappleSpecialMove;
    /// <summary>
    /// Function: TeleportForGrappleSpecialMove
    /// </summary>
    public unsafe virtual void TeleportForGrappleSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeleportForGrappleSpecialMove, "BmScript.MPawnVillainFirefly.TeleportForGrappleSpecialMove");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldPlayLightTOW;
    /// <summary>
    /// Function: ShouldPlayLightTOW
    /// </summary>
    public unsafe virtual bool ShouldPlayLightTOW()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPlayLightTOW, "BmScript.MPawnVillainFirefly.ShouldPlayLightTOW");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RollCoasterPunchImpuct;
    /// <summary>
    /// Function: RollCoasterPunchImpuct
    /// </summary>
    public unsafe virtual void RollCoasterPunchImpuct()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RollCoasterPunchImpuct, "BmScript.MPawnVillainFirefly.RollCoasterPunchImpuct");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitHUD;
    /// <summary>
    /// Function: InitHUD
    /// </summary>
    public unsafe virtual void InitHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitHUD, "BmScript.MPawnVillainFirefly.InitHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopStunnedFX;
    /// <summary>
    /// Function: StopStunnedFX
    /// </summary>
    public unsafe virtual void StopStunnedFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopStunnedFX, "BmScript.MPawnVillainFirefly.StopStunnedFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartStunnedFX;
    /// <summary>
    /// Function: StartStunnedFX
    /// </summary>
    public unsafe virtual void StartStunnedFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartStunnedFX, "BmScript.MPawnVillainFirefly.StartStunnedFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHealth;
    /// <summary>
    /// Function: SetHealth
    /// </summary>
    public unsafe override void SetHealth()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealth, "BmScript.MPawnVillainFirefly.SetHealth");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmScript.MPawnVillainFirefly.Destroyed");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.MPawnVillainFirefly.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: LastBatarangHitTime
    /// </summary>
    public unsafe float LastBatarangHitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4392); }
    }

    /// <summary>
    /// IntProperty: NoOfQuickBatarangHits
    /// </summary>
    public unsafe int NoOfQuickBatarangHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4396); }
    }

    /// <summary>
    /// ClassProperty: PreferedCombatMoveClass
    /// </summary>
    public unsafe BmSDK.Class PreferedCombatMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4400); }
    }

    /// <summary>
    /// FloatProperty: LastTimeSawPlayer
    /// </summary>
    public unsafe float LastTimeSawPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4404); }
    }

    /// <summary>
    /// FloatProperty: FireflyStunTime
    /// </summary>
    public unsafe float FireflyStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4408); }
    }

    /// <summary>
    /// IntProperty: FireProjectileLeftInGasTank
    /// </summary>
    public unsafe int FireProjectileLeftInGasTank
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4412); }
    }

    /// <summary>
    /// ObjectProperty: UpperBurningFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem UpperBurningFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4416); }
    }

    /// <summary>
    /// ObjectProperty: LowerBurningFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem LowerBurningFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4420); }
    }

    /// <summary>
    /// ObjectProperty: EngineIdleSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EngineIdleSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4424); }
    }

    /// <summary>
    /// StructProperty: EngineIdleSFXHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle EngineIdleSFXHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 4428);

    /// <summary>
    /// ObjectProperty: HorizentalEngineSoundParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName HorizentalEngineSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 4440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4440); }
    }

    /// <summary>
    /// ObjectProperty: VerticalEngineSoundParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName VerticalEngineSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 4444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4444); }
    }

    /// <summary>
    /// FloatProperty: HorizentalEngineSoundValue
    /// </summary>
    public unsafe float HorizentalEngineSoundValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4448); }
    }

    /// <summary>
    /// FloatProperty: VerticalEngineSoundValue
    /// </summary>
    public unsafe float VerticalEngineSoundValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4452); }
    }

    /// <summary>
    /// FloatProperty: VerticalEngineSoundRandom
    /// </summary>
    public unsafe float VerticalEngineSoundRandom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4456); }
    }

    /// <summary>
    /// FloatProperty: HorizentalEngineSoundRandom
    /// </summary>
    public unsafe float HorizentalEngineSoundRandom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4460); }
    }

    /// <summary>
    /// ObjectProperty: RollCoasterPullSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RollCoasterPullSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4464); }
    }

    /// <summary>
    /// ObjectProperty: RollCoasterPullStopSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RollCoasterPullStopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4468); }
    }

    /// <summary>
    /// ObjectProperty: RollCoasterPullSoundParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName RollCoasterPullSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 4472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4472); }
    }

    /// <summary>
    /// ObjectProperty: RollCoasterPunchSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RollCoasterPunchSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4476); }
    }

    /// <summary>
    /// FloatProperty: RollCoasterSoundValue
    /// </summary>
    public unsafe float RollCoasterSoundValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }

    /// <summary>
    /// FloatProperty: RollCoasterMaxSqSpeed
    /// </summary>
    public unsafe float RollCoasterMaxSqSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4484); }
    }

    /// <summary>
    /// ObjectProperty: EngineMalfunctionStartdSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EngineMalfunctionStartdSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4488); }
    }

    /// <summary>
    /// ObjectProperty: EngineMalfunctionStopSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EngineMalfunctionStopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4492); }
    }

    /// <summary>
    /// ObjectProperty: ThrowSingleGrenadeSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ThrowSingleGrenadeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4496); }
    }

    /// <summary>
    /// ObjectProperty: ThrowMultiGrenadeSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ThrowMultiGrenadeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4500); }
    }

    /// <summary>
    /// ObjectProperty: SFXFlamethrower_FireBalls
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SFXFlamethrower_FireBalls
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4504); }
    }

    /// <summary>
    /// ObjectProperty: SFXFlamethrower_StopFireBalls
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SFXFlamethrower_StopFireBalls
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4508); }
    }

    /// <summary>
    /// ObjectProperty: SFXFlamethrower_FireWall
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SFXFlamethrower_FireWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4512); }
    }

    /// <summary>
    /// ObjectProperty: SFXFlamethrower_StopFireWall
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SFXFlamethrower_StopFireWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4516); }
    }

    /// <summary>
    /// StructProperty: FlameImpactLpSFXHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle FlameImpactLpSFXHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 4520);

    /// <summary>
    /// ComponentProperty: L_UpperArm_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent L_UpperArm_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4532); }
    }

    /// <summary>
    /// ComponentProperty: L_ForeArm_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent L_ForeArm_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4536); }
    }

    /// <summary>
    /// ComponentProperty: R_UpperArm_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent R_UpperArm_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4540); }
    }

    /// <summary>
    /// ComponentProperty: R_ForeArm_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent R_ForeArm_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4544); }
    }

    /// <summary>
    /// ComponentProperty: L_LThighTwist_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent L_LThighTwist_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4548); }
    }

    /// <summary>
    /// ComponentProperty: L_Calf_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent L_Calf_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4552); }
    }

    /// <summary>
    /// ComponentProperty: R_ThighTwist_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent R_ThighTwist_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4556); }
    }

    /// <summary>
    /// ComponentProperty: R_Calf_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent R_Calf_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }

    /// <summary>
    /// ComponentProperty: RightJetPackFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent RightJetPackFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4564); }
    }

    /// <summary>
    /// ComponentProperty: LeftJetPackFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent LeftJetPackFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4568); }
    }

    /// <summary>
    /// ComponentProperty: LaneChargeEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent LaneChargeEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4572); }
    }

    /// <summary>
    /// ObjectProperty: LaneChargeEffectFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem LaneChargeEffectFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4576); }
    }

    /// <summary>
    /// ObjectProperty: LaneChargeTrail
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyLaneChargeTrail LaneChargeTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyLaneChargeTrail>(Ptr + 4580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4580); }
    }

    /// <summary>
    /// StructProperty: LaneChargeRot
    /// </summary>
    public unsafe ref BmSDK.Rotator LaneChargeRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 4584);

    /// <summary>
    /// StructProperty: LaneChargeTrailRot
    /// </summary>
    public unsafe ref BmSDK.Rotator LaneChargeTrailRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 4596);

    /// <summary>
    /// StructProperty: LaneChargeTraiLoffSet
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LaneChargeTraiLoffSet
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4608);

    /// <summary>
    /// IntProperty: FireBallCount
    /// </summary>
    public unsafe int FireBallCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4620); }
    }

    /// <summary>
    /// IntProperty: PlayerFlameHits
    /// </summary>
    public unsafe int PlayerFlameHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4624); }
    }

    /// <summary>
    /// FloatProperty: StateTime
    /// </summary>
    public unsafe float StateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4628); }
    }

    /// <summary>
    /// IntProperty: CurrentBeatdownCount
    /// </summary>
    public unsafe int CurrentBeatdownCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4632); }
    }

    /// <summary>
    /// BoolProperty: FiringFlameLane
    /// </summary>
    public unsafe bool FiringFlameLane
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: CanDoLightBatClawed
    /// </summary>
    public unsafe bool CanDoLightBatClawed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: ReachedHPMiddlePaseB
    /// </summary>
    public unsafe bool ReachedHPMiddlePaseB
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: ReachedHPMiddlePaseA
    /// </summary>
    public unsafe bool ReachedHPMiddlePaseA
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: PlayingBitHitReact
    /// </summary>
    public unsafe bool PlayingBitHitReact
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: HintDodgeBatclawPlayed
    /// </summary>
    public unsafe bool HintDodgeBatclawPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: IsInCinematique
    /// </summary>
    public unsafe bool IsInCinematique
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: FirstTimeGlued
    /// </summary>
    public unsafe bool FirstTimeGlued
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: FirstTimeGeled
    /// </summary>
    public unsafe bool FirstTimeGeled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: bAttackingFXActive
    /// </summary>
    public unsafe bool bAttackingFXActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: ForceKeepInView
    /// </summary>
    public unsafe bool ForceKeepInView
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: HitOnlyByBatarang
    /// </summary>
    public unsafe bool HitOnlyByBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: ForceExplosiveGelReaction
    /// </summary>
    public unsafe bool ForceExplosiveGelReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: JetPackFXOn
    /// </summary>
    public unsafe bool JetPackFXOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: bCanSkipToNextMove
    /// </summary>
    public unsafe bool bCanSkipToNextMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// BoolProperty: bCanGrappleSpecialMove
    /// </summary>
    public unsafe bool bCanGrappleSpecialMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4636); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4636); }
    }

    /// <summary>
    /// FloatProperty: LastFlameLaneBurstTime
    /// </summary>
    public unsafe float LastFlameLaneBurstTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4640); }
    }

    /// <summary>
    /// ByteProperty: CurrentPhase
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnVillainFirefly.FireflyPhase CurrentPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnVillainFirefly.FireflyPhase>(Ptr + 4644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4644); }
    }

    /// <summary>
    /// ObjectProperty: FireFlyHangPoint
    /// </summary>
    public unsafe BmSDK.BmScript.MFireFlyHangPoint FireFlyHangPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireFlyHangPoint>(Ptr + 4648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4648); }
    }

    /// <summary>
    /// ObjectProperty: PlayerTugOfWarAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerTugOfWarAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4652); }
    }

    /// <summary>
    /// ObjectProperty: PlayerRollerCoasterAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerRollerCoasterAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4656); }
    }

    /// <summary>
    /// FloatProperty: MaxVerticalVelocity
    /// </summary>
    public unsafe float MaxVerticalVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4660); }
    }

    /// <summary>
    /// FloatProperty: MaxHorizontalVelocity
    /// </summary>
    public unsafe float MaxHorizontalVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4664); }
    }

    /// <summary>
    /// FloatProperty: BurstSpeedToDo
    /// </summary>
    public unsafe float BurstSpeedToDo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4668); }
    }

    /// <summary>
    /// ComponentProperty: StunnedFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent StunnedFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4672); }
    }

    /// <summary>
    /// StructProperty: Flamethrower
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMPawnAI.FCharacterSkeletalProps Flamethrower
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMPawnAI.FCharacterSkeletalProps>(Ptr + 4676);

    /// <summary>
    /// ObjectProperty: FlameThrowerTrail
    /// </summary>
    public unsafe BmSDK.BmScript.MFireFlyFlameThrowerTrail FlameThrowerTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireFlyFlameThrowerTrail>(Ptr + 4800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4800); }
    }

    /// <summary>
    /// ObjectProperty: FireflyFogVolume
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FireflyFogVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 4804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4804); }
    }

    /// <summary>
    /// ObjectProperty: FireFlyStunCam
    /// </summary>
    public unsafe BmSDK.BmScript.MFireFlyStunCam FireFlyStunCam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireFlyStunCam>(Ptr + 4808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4808); }
    }

    /// <summary>
    /// FloatProperty: CamGadgetTimer
    /// </summary>
    public unsafe float CamGadgetTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4812); }
    }

    /// <summary>
    /// FloatProperty: FireWallAnticipationBurst1
    /// </summary>
    public unsafe float FireWallAnticipationBurst1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4816); }
    }

    /// <summary>
    /// FloatProperty: FireWallAnticipationBurst2
    /// </summary>
    public unsafe float FireWallAnticipationBurst2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4820); }
    }

    /// <summary>
    /// FloatProperty: TimerKeepInView
    /// </summary>
    public unsafe float TimerKeepInView
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4824); }
    }

    /// <summary>
    /// ObjectProperty: PostProcessViewMTI
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance PostProcessViewMTI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 4828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4828); }
    }

    /// <summary>
    /// ObjectProperty: GrappleSpecialMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4832); }
    }

    /// <summary>
    /// IntProperty: NbBatarangWhenGlued
    /// </summary>
    public unsafe int NbBatarangWhenGlued
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4836); }
    }

    /// <summary>
    /// ComponentProperty: ChargeUpFXComponent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ChargeUpFXComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4840); }
    }

    /// <summary>
    /// Enum: FireflyPhase
    /// </summary>
    public enum FireflyPhase : byte
    {
        FFP_Phase_NotSet = 0,
        FFP_PhaseA_Attack = 1,
        FFP_NavigationChallenge = 2,
        FFP_PhaseB_Attack = 3,
        FFP_PhaseC = 4,
        FFP_Num = 5,
        FFP_MAX = 6,
    }
}
