#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDPawnConfig<br/>
/// (size = 688)
/// (flags = 134250642)
/// </summary>
public partial class GDPawnConfig : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDPawnConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDPawnConfig.
    /// </summary>
    public static GDPawnConfig DefaultObject => (GDPawnConfig)StaticClass().DefaultObject;

    internal GDPawnConfig() { }

    /// <summary>
    /// Constructs a new GDPawnConfig
    /// </summary>
    public GDPawnConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDPawnConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDPawnConfig(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnConfig>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnConfig>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnConfig>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnConfig>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnConfig>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnConfig>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnConfig>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnConfig>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetNumLoadoutSlots;
    /// <summary>
    /// Function: GetNumLoadoutSlots
    /// </summary>
    public unsafe virtual int GetNumLoadoutSlots()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumLoadoutSlots, "BmGame.GDPawnConfig.GetNumLoadoutSlots");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetDashUpgrade;
    /// <summary>
    /// Function: SetDashUpgrade
    /// </summary>
    public unsafe virtual void SetDashUpgrade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDashUpgrade, "BmGame.GDPawnConfig.SetDashUpgrade");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDashTime;
    /// <summary>
    /// Function: GetDashTime
    /// </summary>
    public unsafe virtual float GetDashTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDashTime, "BmGame.GDPawnConfig.GetDashTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBestUpgradeLevelForGadget;
    /// <summary>
    /// Function: GetBestUpgradeLevelForGadget
    /// </summary>
    public unsafe virtual int GetBestUpgradeLevelForGadget(BmSDK.BmGame.RGameInfo.PlayerGadgetId GadgetIdentifier, bool bCheckShowInMenu = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestUpgradeLevelForGadget, "BmGame.GDPawnConfig.GetBestUpgradeLevelForGadget");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetIdentifier, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckShowInMenu, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetGadgetByGadgetId;
    /// <summary>
    /// Function: GetGadgetByGadgetId
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RInventoryGadget GetGadgetByGadgetId(BmSDK.BmGame.RGameInfo.PlayerGadgetId GadgetID, int SpecificUpgradeLevel = default, bool bCheckUnlocked = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetByGadgetId, "BmGame.GDPawnConfig.GetGadgetByGadgetId");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecificUpgradeLevel, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckUnlocked, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetNewGadgetUnlocksForLevel;
    /// <summary>
    /// Function: GetNewGadgetUnlocksForLevel
    /// </summary>
    public unsafe virtual void GetNewGadgetUnlocksForLevel(int NewLevel, BmSDK.BmGame.GDGIBase.ETeamType ForTeam, out BmSDK.TArray<BmSDK.BmGame.RInventoryGadget> UnlockedGadgets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNewGadgetUnlocksForLevel, "BmGame.GDPawnConfig.GetNewGadgetUnlocksForLevel");
        byte* paramsPtr = stackalloc byte[45];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLevel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForTeam, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        UnlockedGadgets = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget>>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// FloatProperty: HealthRegenDelay
    /// </summary>
    public unsafe float HealthRegenDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// FloatProperty: HealthRegenDelayInCover
    /// </summary>
    public unsafe float HealthRegenDelayInCover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// FloatProperty: HealthRegenInterval
    /// </summary>
    public unsafe float HealthRegenInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// FloatProperty: HealthRegenAmount
    /// </summary>
    public unsafe float HealthRegenAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// IntProperty: MaxRegenLevel
    /// </summary>
    public unsafe int MaxRegenLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: bUseDashMeter
    /// </summary>
    public unsafe bool bUseDashMeter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: UseDashOverlayCamera
    /// </summary>
    public unsafe bool UseDashOverlayCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: StaggerDamageActive
    /// </summary>
    public unsafe bool StaggerDamageActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysShowTacInfo
    /// </summary>
    public unsafe bool bAlwaysShowTacInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bShowFirearmInfoHUD
    /// </summary>
    public unsafe bool bShowFirearmInfoHUD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bShowGadgetHUD
    /// </summary>
    public unsafe bool bShowGadgetHUD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// StructProperty: DashData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableSkill DashData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableSkill>(Ptr + 72);

    /// <summary>
    /// NameProperty: DashOverlayCameraName
    /// </summary>
    public unsafe BmSDK.FName DashOverlayCameraName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: DashTime
    /// </summary>
    public unsafe float DashTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: DashRecoverTime
    /// </summary>
    public unsafe float DashRecoverTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: DashRecoverTimeInCover
    /// </summary>
    public unsafe float DashRecoverTimeInCover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: DashMinimumRecoverTime
    /// </summary>
    public unsafe float DashMinimumRecoverTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: RunningTurnRadiusMin
    /// </summary>
    public unsafe float RunningTurnRadiusMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: RunningTurnRadiusMax
    /// </summary>
    public unsafe float RunningTurnRadiusMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ObjectProperty: LockedOnAudio
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LockedOnAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ObjectProperty: LockedOnStartAudio
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LockedOnStartAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// ObjectProperty: LockedOnStopAudio
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LockedOnStopAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: LockingOnBeepFrequency
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName LockingOnBeepFrequency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: LockedOnAudioDuration
    /// </summary>
    public unsafe float LockedOnAudioDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// NameProperty: AttachToBone
    /// </summary>
    public unsafe BmSDK.FName AttachToBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ObjectProperty: HealthRegenEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HealthRegenEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// NameProperty: PoisonEffectBone
    /// </summary>
    public unsafe BmSDK.FName PoisonEffectBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: PoisonParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem PoisonParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: QuickStrike
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove_BatmanStrike QuickStrike
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove_BatmanStrike>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// ObjectProperty: StunStrike
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove_BatmanStrike StunStrike
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove_BatmanStrike>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// FloatProperty: StaggerTimeLimit
    /// </summary>
    public unsafe float StaggerTimeLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// FloatProperty: StaggerDamageThreshold
    /// </summary>
    public unsafe float StaggerDamageThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ObjectProperty: PoisonStartAudio
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent PoisonStartAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ObjectProperty: PoisonStopAudio
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent PoisonStopAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ObjectProperty: PoisonEffect
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName PoisonEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// ObjectProperty: PlayerHealthReverb
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName PlayerHealthReverb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// FloatProperty: StartLowHealthPP
    /// </summary>
    public unsafe float StartLowHealthPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// FloatProperty: FullLowHealthPP
    /// </summary>
    public unsafe float FullLowHealthPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// FloatProperty: LowHealthPPMaxChangeVal
    /// </summary>
    public unsafe float LowHealthPPMaxChangeVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// FloatProperty: LowHealthPPInterpSpeed
    /// </summary>
    public unsafe float LowHealthPPInterpSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// FloatProperty: DeathEffectLerpTime
    /// </summary>
    public unsafe float DeathEffectLerpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: DamageEffectWhenDeadLerpTime
    /// </summary>
    public unsafe float DamageEffectWhenDeadLerpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: UseableGadgets
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget> UseableGadgets => new(26, Ptr + 216, 12, this);

    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 216);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 228);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 240);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 252);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 264);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 276);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 288);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 300);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 312);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 324);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 336);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_11
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 348);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_12
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 360);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_13
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 372);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_14
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 384);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_15
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 396);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_16
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 408);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_17
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 420);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_18
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 432);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_19
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 444);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_20
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 456);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_21
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 468);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_22
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 480);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_23
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 492);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_24
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 504);
    /// <summary>
    /// StructProperty: UseableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget UseableGadgets_25
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FAnUpgradableGadget>(Ptr + 516);

    /// <summary>
    /// StructProperty: LoadoutSlotUpgrades
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnConfig.FSLoadoutSlotUpgrades LoadoutSlotUpgrades
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnConfig.FSLoadoutSlotUpgrades>(Ptr + 528);

    /// <summary>
    /// InlineArray{NameProperty}: BoneNames
    /// </summary>
    public InlineArray<BmSDK.FName> BoneNames => new(11, Ptr + 540, 8, this);

    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ArrayProperty: AmmoRefillStages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDPawnConfig.FSAmmoRefillStage> AmmoRefillStages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDPawnConfig.FSAmmoRefillStage>>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: AmmoCrateUseCooldown
    /// </summary>
    public unsafe float AmmoCrateUseCooldown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// FloatProperty: MinAmmoPercentageToShowAmmoIndicators
    /// </summary>
    public unsafe float MinAmmoPercentageToShowAmmoIndicators
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// FloatProperty: PhysTurnOffDistance
    /// </summary>
    public unsafe float PhysTurnOffDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// FloatProperty: PhysTurnOffDistanceCrosshair
    /// </summary>
    public unsafe float PhysTurnOffDistanceCrosshair
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// FloatProperty: PhysTurnOffAngle
    /// </summary>
    public unsafe float PhysTurnOffAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// FloatProperty: PhysTurnOffCheckTime
    /// </summary>
    public unsafe float PhysTurnOffCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: ElectronicCounterMeasureDetectionRange
    /// </summary>
    public unsafe float ElectronicCounterMeasureDetectionRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// FloatProperty: PromptTimeElectronicCounterMeasure
    /// </summary>
    public unsafe float PromptTimeElectronicCounterMeasure
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// FloatProperty: SupervillainDoorInteractTime
    /// </summary>
    public unsafe float SupervillainDoorInteractTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// StrProperty: AimAssistBoneName
    /// </summary>
    public unsafe BmSDK.FString AimAssistBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// Struct: FSAmmoRefillStage
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSAmmoRefillStage
    {
        /// <summary>
        /// FloatProperty: AfterRummageSecs
        /// </summary>
        public unsafe float AfterRummageSecs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: AmmoClipsAwarded
        /// </summary>
        public unsafe int AmmoClipsAwarded
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: GrenadesAwarded
        /// </summary>
        public unsafe int GrenadesAwarded
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FSLoadoutSlotUpgrades
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSLoadoutSlotUpgrades
    {
        /// <summary>
        /// ArrayProperty: Upgrades
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDLoadoutSlotsData> Upgrades
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDLoadoutSlotsData>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FAnUpgradableSkill
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FAnUpgradableSkill
    {
        /// <summary>
        /// ArrayProperty: Upgrades
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDDashData> Upgrades
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDDashData>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FAnUpgradableGadget
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FAnUpgradableGadget
    {
        /// <summary>
        /// ArrayProperty: Upgrades
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RInventoryGadget> Upgrades
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }
}
