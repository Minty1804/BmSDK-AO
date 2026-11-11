#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDGanglandMatchSettings<br/>
/// (size = 404)
/// (flags = 2129938)
/// </summary>
public partial class GDGanglandMatchSettings : BmSDK.BmGame.GDMatchSettings, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGanglandMatchSettings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGanglandMatchSettings.
    /// </summary>
    public static GDGanglandMatchSettings DefaultObject => (GDGanglandMatchSettings)StaticClass().DefaultObject;

    internal GDGanglandMatchSettings() { }

    /// <summary>
    /// Constructs a new GDGanglandMatchSettings
    /// </summary>
    public GDGanglandMatchSettings(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDGanglandMatchSettings Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGanglandMatchSettings(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGanglandMatchSettings>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGanglandMatchSettings>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGanglandMatchSettings>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGanglandMatchSettings>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGanglandMatchSettings>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGanglandMatchSettings>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGanglandMatchSettings>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGanglandMatchSettings>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetTicketLossForMajority;
    /// <summary>
    /// Function: GetTicketLossForMajority
    /// </summary>
    public unsafe virtual int GetTicketLossForMajority(int MajorityCount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTicketLossForMajority, "BmGame.GDGanglandMatchSettings.GetTicketLossForMajority");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MajorityCount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    /// <summary>
    /// IntProperty: MaximumTeamTickets
    /// </summary>
    public unsafe int MaximumTeamTickets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// IntProperty: StartingTicketCount
    /// </summary>
    public unsafe int StartingTicketCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// IntProperty: TicketLossOnThugKill
    /// </summary>
    public unsafe int TicketLossOnThugKill
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// IntProperty: TicketGainOnHeroKill
    /// </summary>
    public unsafe int TicketGainOnHeroKill
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ArrayProperty: TicketLossForMajority
    /// </summary>
    public unsafe BmSDK.TArray<int> TicketLossForMajority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// FloatProperty: CycleInterval
    /// </summary>
    public unsafe float CycleInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// IntProperty: MaxAlivePlayersForInstantRespawn
    /// </summary>
    public unsafe int MaxAlivePlayersForInstantRespawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// IntProperty: HeroKillCausedRespawnScoreLoss
    /// </summary>
    public unsafe int HeroKillCausedRespawnScoreLoss
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// BoolProperty: HeroKillCausedRespawnIgnoreBanked
    /// </summary>
    public unsafe bool HeroKillCausedRespawnIgnoreBanked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: bRespawnThugsOnNonZeroTicketHeroKill
    /// </summary>
    public unsafe bool bRespawnThugsOnNonZeroTicketHeroKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// FloatProperty: HeroKillCausedRespawnHeroMinRespawnDelay
    /// </summary>
    public unsafe float HeroKillCausedRespawnHeroMinRespawnDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// IntProperty: TicketLossOnPointCapture
    /// </summary>
    public unsafe int TicketLossOnPointCapture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// FloatProperty: MinTicketRatioForSupervillainSpawn
    /// </summary>
    public unsafe float MinTicketRatioForSupervillainSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// FloatProperty: MaxTicketRatioForSupervillainSpawn
    /// </summary>
    public unsafe float MaxTicketRatioForSupervillainSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// FloatProperty: MinIntimidationRatioForSupervillainSpawn
    /// </summary>
    public unsafe float MinIntimidationRatioForSupervillainSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: MaxIntimidationRatioForSupervillainSpawn
    /// </summary>
    public unsafe float MaxIntimidationRatioForSupervillainSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// FloatProperty: WinningTeamAdvancedWarningTimeForTicketRatio
    /// </summary>
    public unsafe float WinningTeamAdvancedWarningTimeForTicketRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// FloatProperty: LosingTeamAdvancedWarningTimeForTicketRatio
    /// </summary>
    public unsafe float LosingTeamAdvancedWarningTimeForTicketRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// FloatProperty: TiedThugAdvancedWarningTimeForTicketRatio
    /// </summary>
    public unsafe float TiedThugAdvancedWarningTimeForTicketRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// FloatProperty: WinningTeamAdvancedWarningTimeForIntimidationRatio
    /// </summary>
    public unsafe float WinningTeamAdvancedWarningTimeForIntimidationRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// FloatProperty: LosingTeamAdvancedWarningTimeForIntimidationRatio
    /// </summary>
    public unsafe float LosingTeamAdvancedWarningTimeForIntimidationRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// FloatProperty: TiedThugAdvancedWarningTimeForIntimidationRatio
    /// </summary>
    public unsafe float TiedThugAdvancedWarningTimeForIntimidationRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// IntProperty: TicketDifferenceForTieDetermination
    /// </summary>
    public unsafe int TicketDifferenceForTieDetermination
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// FloatProperty: HeroSupervillainAdvancedWarningTimeForTicketRatio
    /// </summary>
    public unsafe float HeroSupervillainAdvancedWarningTimeForTicketRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// FloatProperty: HeroSupervillainAdvancedWarningTimeForIntimidationRatio
    /// </summary>
    public unsafe float HeroSupervillainAdvancedWarningTimeForIntimidationRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// IntProperty: SupervillainSpawnAtSecondsRemaining
    /// </summary>
    public unsafe int SupervillainSpawnAtSecondsRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// Enum: EGanglandMatchEvent
    /// </summary>
    public enum EGanglandMatchEvent : byte
    {
        ETicketedMatchEvent_Unknown = 0,
        ETicketedMatchEvent_GangMemberRespawned = 1,
        ETicketedMatchEvent_GangMemberRegainedConciousness = 2,
        ETicketedMatchEvent_GangKilledBatman = 3,
        ETicketedMatchEvent_GangKilledRobin = 4,
        ETicketedMatchEvent_GangHasMajority = 5,
        ETicketedMatchEvent_GangZeroTickets = 6,
        ETicketedMatchEvent_MAX = 7,
    }
}
