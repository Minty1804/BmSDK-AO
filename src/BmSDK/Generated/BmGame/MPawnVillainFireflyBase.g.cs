#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: MPawnVillainFireflyBase<br/>
/// (size = 4392)
/// (flags = 10485815)
/// </summary>
public partial class MPawnVillainFireflyBase : BmSDK.BmGame.RPawnVillain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MPawnVillainFireflyBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnVillainFireflyBase.
    /// </summary>
    public static MPawnVillainFireflyBase DefaultObject => (MPawnVillainFireflyBase)StaticClass().DefaultObject;

    internal MPawnVillainFireflyBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnVillainFireflyBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFireflyBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFireflyBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFireflyBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFireflyBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFireflyBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFireflyBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFireflyBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainFireflyBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: CanExplodeGel
    /// </summary>
    public unsafe virtual bool CanExplodeGel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnVillainFireflyBase.CanExplodeGel", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsFiringAttack
    /// </summary>
    public unsafe virtual bool IsFiringAttack(bool IsDeploying = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnVillainFireflyBase.IsFiringAttack", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsDeploying, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IgnoreBatarangHit
    /// </summary>
    public unsafe virtual bool IgnoreBatarangHit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnVillainFireflyBase.IgnoreBatarangHit", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DoSlowMoInBatClawCam
    /// </summary>
    public unsafe virtual bool DoSlowMoInBatClawCam()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnVillainFireflyBase.DoSlowMoInBatClawCam", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetFlameWallLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFlameWallLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnVillainFireflyBase.GetFlameWallLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TriggerNextStage
    /// </summary>
    public unsafe virtual void TriggerNextStage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnVillainFireflyBase.TriggerNextStage", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldStartFinalBlowCam
    /// </summary>
    public unsafe override bool ShouldStartFinalBlowCam(float StrikeDamageAmount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnVillainFireflyBase.ShouldStartFinalBlowCam", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDamageAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: FireFlamethrower
    /// </summary>
    public unsafe virtual void FireFlamethrower(System.Numerics.Vector3 TargetLocation, bool DoBalls, bool SpecialProjectile = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnVillainFireflyBase.FireFlamethrower", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DoBalls, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialProjectile, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ThrowGrenade
    /// </summary>
    public unsafe virtual void ThrowGrenade(System.Numerics.Vector3 GrenadeTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnVillainFireflyBase.ThrowGrenade", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenadeTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ThrowIncendiaryGrenade
    /// </summary>
    public unsafe virtual void ThrowIncendiaryGrenade(System.Numerics.Vector3 GrenadeTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnVillainFireflyBase.ThrowIncendiaryGrenade", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenadeTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopFiringAttack
    /// </summary>
    public unsafe virtual void StopFiringAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnVillainFireflyBase.StopFiringAttack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour_Combat GetBehaviour()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnVillainFireflyBase.GetBehaviour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_Combat>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnVillainFireflyBase.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 3996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3996); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 4000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4000); }
    }

    /// <summary>
    /// FloatProperty: BatmanImmuneTime
    /// </summary>
    public unsafe float BatmanImmuneTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4004); }
    }

    /// <summary>
    /// FloatProperty: InitialHealth
    /// </summary>
    public unsafe float InitialHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4008); }
    }

    /// <summary>
    /// FloatProperty: HealthThresholdSpecialStunA
    /// </summary>
    public unsafe float HealthThresholdSpecialStunA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4012); }
    }

    /// <summary>
    /// FloatProperty: HealthThresholdForPhaseB
    /// </summary>
    public unsafe float HealthThresholdForPhaseB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4016); }
    }

    /// <summary>
    /// FloatProperty: HealthThresholdSpecialStunB
    /// </summary>
    public unsafe float HealthThresholdSpecialStunB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4020); }
    }

    /// <summary>
    /// FloatProperty: HealthThresholdForPhaseC
    /// </summary>
    public unsafe float HealthThresholdForPhaseC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4024); }
    }

    /// <summary>
    /// IntProperty: NormalStrikeDamage
    /// </summary>
    public unsafe int NormalStrikeDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4028); }
    }

    /// <summary>
    /// IntProperty: FinalStrikeDamage
    /// </summary>
    public unsafe int FinalStrikeDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4032); }
    }

    /// <summary>
    /// IntProperty: NormalBeatdownStrikeDamage
    /// </summary>
    public unsafe int NormalBeatdownStrikeDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4036); }
    }

    /// <summary>
    /// IntProperty: FinalBeatdownStrikeDamage
    /// </summary>
    public unsafe int FinalBeatdownStrikeDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }

    /// <summary>
    /// IntProperty: LightTOWPunchDamage
    /// </summary>
    public unsafe int LightTOWPunchDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }

    /// <summary>
    /// IntProperty: TOWPunchDamage
    /// </summary>
    public unsafe int TOWPunchDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4048); }
    }

    /// <summary>
    /// FloatProperty: HealthRecovery
    /// </summary>
    public unsafe float HealthRecovery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4052); }
    }

    /// <summary>
    /// FloatProperty: TimeStunnedOnGround
    /// </summary>
    public unsafe float TimeStunnedOnGround
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4056); }
    }

    /// <summary>
    /// IntProperty: NumberOfBeatdownStrikes
    /// </summary>
    public unsafe int NumberOfBeatdownStrikes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4060); }
    }

    /// <summary>
    /// IntProperty: NumberOfConsecutiveStrikes
    /// </summary>
    public unsafe int NumberOfConsecutiveStrikes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4064); }
    }

    /// <summary>
    /// IntProperty: BigStrikeDamageAmount
    /// </summary>
    public unsafe int BigStrikeDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4068); }
    }

    /// <summary>
    /// IntProperty: SmallStrikeDamageAmount
    /// </summary>
    public unsafe int SmallStrikeDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4072); }
    }

    /// <summary>
    /// IntProperty: TOW_LightStrikeDamageAmount
    /// </summary>
    public unsafe int TOW_LightStrikeDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4076); }
    }

    /// <summary>
    /// IntProperty: TOW_StrikeDamageAmount
    /// </summary>
    public unsafe int TOW_StrikeDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4080); }
    }

    /// <summary>
    /// FloatProperty: SpecialStunTime
    /// </summary>
    public unsafe float SpecialStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4084); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeMovingToOtherAnchor
    /// </summary>
    public unsafe float TimeBeforeMovingToOtherAnchor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4088); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeHuntingPlayer
    /// </summary>
    public unsafe float TimeBeforeHuntingPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4092); }
    }

    /// <summary>
    /// FloatProperty: PlayerDistanceToBeHidden
    /// </summary>
    public unsafe float PlayerDistanceToBeHidden
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4096); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: FireballDamage
    /// </summary>
    public InlineArray<float> FireballDamage => new(3, Ptr + 4100, 4, this);

    /// <summary>
    /// FloatProperty: FireballDamage
    /// </summary>
    public unsafe float FireballDamage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }
    /// <summary>
    /// FloatProperty: FireballDamage
    /// </summary>
    public unsafe float FireballDamage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4104); }
    }
    /// <summary>
    /// FloatProperty: FireballDamage
    /// </summary>
    public unsafe float FireballDamage_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4108); }
    }

    /// <summary>
    /// FloatProperty: PlayerImmuneTimeAfterHit
    /// </summary>
    public unsafe float PlayerImmuneTimeAfterHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4112); }
    }

    /// <summary>
    /// IntProperty: PlayerHitsToBeImmune
    /// </summary>
    public unsafe int PlayerHitsToBeImmune
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4116); }
    }

    /// <summary>
    /// IntProperty: NumFireballPerBurst
    /// </summary>
    public unsafe int NumFireballPerBurst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4120); }
    }

    /// <summary>
    /// IntProperty: NumFireballToKnockDown
    /// </summary>
    public unsafe int NumFireballToKnockDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4124); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenFireballProjectile
    /// </summary>
    public unsafe float TimeBetweenFireballProjectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4128); }
    }

    /// <summary>
    /// FloatProperty: FireBallBurstSpeed
    /// </summary>
    public unsafe float FireBallBurstSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }

    /// <summary>
    /// FloatProperty: NumProjectilePerGasTank
    /// </summary>
    public unsafe float NumProjectilePerGasTank
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4136); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: RollingFireDamage
    /// </summary>
    public InlineArray<float> RollingFireDamage => new(3, Ptr + 4140, 4, this);

    /// <summary>
    /// FloatProperty: RollingFireDamage
    /// </summary>
    public unsafe float RollingFireDamage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4140); }
    }
    /// <summary>
    /// FloatProperty: RollingFireDamage
    /// </summary>
    public unsafe float RollingFireDamage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4144); }
    }
    /// <summary>
    /// FloatProperty: RollingFireDamage
    /// </summary>
    public unsafe float RollingFireDamage_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// FloatProperty: RollingFireBurstSpeed
    /// </summary>
    public unsafe float RollingFireBurstSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenFireWalls
    /// </summary>
    public unsafe float TimeBetweenFireWalls
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4156); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenFireWallsWhenHit
    /// </summary>
    public unsafe float TimeBetweenFireWallsWhenHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4160); }
    }

    /// <summary>
    /// FloatProperty: FlameWallDuration
    /// </summary>
    public unsafe float FlameWallDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4164); }
    }

    /// <summary>
    /// FloatProperty: FlameWallSpreadingTime
    /// </summary>
    public unsafe float FlameWallSpreadingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4168); }
    }

    /// <summary>
    /// IntProperty: OverheatAnimCnt
    /// </summary>
    public unsafe int OverheatAnimCnt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4172); }
    }

    /// <summary>
    /// IntProperty: NumFirewalls
    /// </summary>
    public unsafe int NumFirewalls
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4176); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenFlameBurst
    /// </summary>
    public unsafe float MinTimeBetweenFlameBurst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4180); }
    }

    /// <summary>
    /// FloatProperty: GrenadeDamage
    /// </summary>
    public unsafe float GrenadeDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4184); }
    }

    /// <summary>
    /// FloatProperty: GrenadeExplosionRadius
    /// </summary>
    public unsafe float GrenadeExplosionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4188); }
    }

    /// <summary>
    /// FloatProperty: DelayBetweenGrenades
    /// </summary>
    public unsafe float DelayBetweenGrenades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4192); }
    }

    /// <summary>
    /// FloatProperty: DelayBeforeFirstGrenadeThrow
    /// </summary>
    public unsafe float DelayBeforeFirstGrenadeThrow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4196); }
    }

    /// <summary>
    /// FloatProperty: IncendiaryGrenadeDamage
    /// </summary>
    public unsafe float IncendiaryGrenadeDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4200); }
    }

    /// <summary>
    /// FloatProperty: IncendiaryGrenadeExplosionRadius
    /// </summary>
    public unsafe float IncendiaryGrenadeExplosionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4204); }
    }

    /// <summary>
    /// FloatProperty: DamagePerBatarang
    /// </summary>
    public unsafe float DamagePerBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4208); }
    }

    /// <summary>
    /// FloatProperty: DamagePerExplosifGel
    /// </summary>
    public unsafe float DamagePerExplosifGel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4212); }
    }

    /// <summary>
    /// FloatProperty: BatarangStunTime
    /// </summary>
    public unsafe float BatarangStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4216); }
    }

    /// <summary>
    /// FloatProperty: GlueGrenadeStunTime
    /// </summary>
    public unsafe float GlueGrenadeStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4220); }
    }

    /// <summary>
    /// FloatProperty: ExplosifGelStunTime
    /// </summary>
    public unsafe float ExplosifGelStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4224); }
    }

    /// <summary>
    /// FloatProperty: RemoteClawStunTime
    /// </summary>
    public unsafe float RemoteClawStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// FloatProperty: FlameLaneBurstDelay
    /// </summary>
    public unsafe float FlameLaneBurstDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4232); }
    }

    /// <summary>
    /// FloatProperty: FlameLaneBurstSpeed
    /// </summary>
    public unsafe float FlameLaneBurstSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4236); }
    }

    /// <summary>
    /// StructProperty: CamDragUpRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CamDragUpRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 4240);

    /// <summary>
    /// StructProperty: CamDragUpOffSet
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CamDragUpOffSet
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4252);

    /// <summary>
    /// IntProperty: RollCoasterPunchDamage
    /// </summary>
    public unsafe int RollCoasterPunchDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4264); }
    }

    /// <summary>
    /// FloatProperty: MaxCameraYaw
    /// </summary>
    public unsafe float MaxCameraYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4268); }
    }

    /// <summary>
    /// ObjectProperty: PullDownMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PullDownMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4272); }
    }

    /// <summary>
    /// StructProperty: FlameWallLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FlameWallLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4276);

    /// <summary>
    /// ObjectProperty: FireflyBark_BM_BatClawFailed
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_BM_BatClawFailed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4288); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_BM_FightStart
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_BM_FightStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4292); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_BM_HintGrapple
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_BM_HintGrapple
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_ChargeShoot
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_ChargeShoot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_ChargeUp
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_ChargeUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4304); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_ClusterGrenade1
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_ClusterGrenade1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4308); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_ClusterGrenade2
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_ClusterGrenade2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4312); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_DodgeBatclaw
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_DodgeBatclaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_DragBMinAir
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_DragBMinAir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4320); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_DragBMintoObstacle
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_DragBMintoObstacle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4324); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_Fascinated
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_Fascinated
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4328); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_FightStart
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_FightStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4332); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_GunJam
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_GunJam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4336); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_HitbyGlueGrenade
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_HitbyGlueGrenade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4340); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_HitbyGrapple
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_HitbyGrapple
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4344); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_HPHalfStage1
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_HPHalfStage1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4348); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_NAV_BombsBM
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_NAV_BombsBM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4352); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_NAV_ShootsBM
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_NAV_ShootsBM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4356); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_NAV_Start
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_NAV_Start
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4360); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_Phase2Start
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_Phase2Start
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4364); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_PushBMOff
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_PushBMOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_SmokeUseless
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_SmokeUseless
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4372); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_Stage1Taunts
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_Stage1Taunts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4376); }
    }

    /// <summary>
    /// ObjectProperty: FireflyBark_FF_Stage2Taunts
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine FireflyBark_FF_Stage2Taunts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4380); }
    }

    /// <summary>
    /// ObjectProperty: BatarangTrailFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BatarangTrailFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4384); }
    }

    /// <summary>
    /// BoolProperty: IsMoving
    /// </summary>
    public unsafe bool IsMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4388) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4388); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4388); }
    }
}
