#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDGameReplicationInfo<br/>
/// (size = 2340)
/// (flags = 142639254)
/// </summary>
public partial class GDGameReplicationInfo : BmSDK.BmGame.RGameRI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGameReplicationInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGameReplicationInfo.
    /// </summary>
    public static GDGameReplicationInfo DefaultObject => (GDGameReplicationInfo)StaticClass().DefaultObject;

    internal GDGameReplicationInfo() { }

    /// <summary>
    /// Constructs a new GDGameReplicationInfo
    /// </summary>
    public GDGameReplicationInfo(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGameReplicationInfo(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_FakeHeroLotteryStart;
    /// <summary>
    /// Function: FakeHeroLotteryStart
    /// </summary>
    public unsafe virtual void FakeHeroLotteryStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeHeroLotteryStart, "BmGame.GDGameReplicationInfo.FakeHeroLotteryStart");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FakeHeroLottery;
    /// <summary>
    /// Function: FakeHeroLottery
    /// </summary>
    public unsafe virtual void FakeHeroLottery()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeHeroLottery, "BmGame.GDGameReplicationInfo.FakeHeroLottery");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldForceCenterScreenXPForType;
    /// <summary>
    /// Function: ShouldForceCenterScreenXPForType
    /// </summary>
    public unsafe virtual bool ShouldForceCenterScreenXPForType(BmSDK.BmGame.RGameInfo.NewExperienceAmounts XPType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceCenterScreenXPForType, "BmGame.GDGameReplicationInfo.ShouldForceCenterScreenXPForType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetXPValueForType;
    /// <summary>
    /// Function: GetXPValueForType
    /// </summary>
    public unsafe virtual int GetXPValueForType(BmSDK.BmGame.RGameInfo.NewExperienceAmounts XPType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetXPValueForType, "BmGame.GDGameReplicationInfo.GetXPValueForType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetLocalLobbySystem;
    /// <summary>
    /// Function: GetLocalLobbySystem
    /// </summary>
    public unsafe virtual BmSDK.SDEngine.SDLobbySystem GetLocalLobbySystem()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalLobbySystem, "BmGame.GDGameReplicationInfo.GetLocalLobbySystem");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.SDEngine.SDLobbySystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldBarkUseSecondaryCommander;
    /// <summary>
    /// Function: ShouldBarkUseSecondaryCommander
    /// </summary>
    public unsafe virtual bool ShouldBarkUseSecondaryCommander(BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.BmGame.GDGIBase.ETeamType TeamType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldBarkUseSecondaryCommander, "BmGame.GDGameReplicationInfo.ShouldBarkUseSecondaryCommander");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsAnyoneOnTeamAlive;
    /// <summary>
    /// Function: IsAnyoneOnTeamAlive
    /// </summary>
    public unsafe virtual bool IsAnyoneOnTeamAlive(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnyoneOnTeamAlive, "BmGame.GDGameReplicationInfo.IsAnyoneOnTeamAlive");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPlayerKillsByTeam;
    /// <summary>
    /// Function: GetPlayerKillsByTeam
    /// </summary>
    public unsafe virtual int GetPlayerKillsByTeam(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerKillsByTeam, "BmGame.GDGameReplicationInfo.GetPlayerKillsByTeam");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsControllerBane;
    /// <summary>
    /// Function: IsControllerBane
    /// </summary>
    public unsafe virtual bool IsControllerBane(BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsControllerBane, "BmGame.GDGameReplicationInfo.IsControllerBane");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsControllerFactionLeader;
    /// <summary>
    /// Function: IsControllerFactionLeader
    /// </summary>
    public unsafe virtual bool IsControllerFactionLeader(BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsControllerFactionLeader, "BmGame.GDGameReplicationInfo.IsControllerFactionLeader");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsControllerCharacterOfType;
    /// <summary>
    /// Function: IsControllerCharacterOfType
    /// </summary>
    public unsafe virtual bool IsControllerCharacterOfType(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.RChallengeManager.EPlayableCharacters PLR)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsControllerCharacterOfType, "BmGame.GDGameReplicationInfo.IsControllerCharacterOfType");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PLR, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OnCaptainsAssigned;
    /// <summary>
    /// Function: OnCaptainsAssigned
    /// </summary>
    public unsafe virtual void OnCaptainsAssigned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCaptainsAssigned, "BmGame.GDGameReplicationInfo.OnCaptainsAssigned");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCaptainChanged;
    /// <summary>
    /// Function: OnCaptainChanged
    /// </summary>
    public unsafe virtual void OnCaptainChanged(BmSDK.BmGame.GDTeamInfo Team, BmSDK.BmGame.RPlayerRI Captain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCaptainChanged, "BmGame.GDGameReplicationInfo.OnCaptainChanged");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Captain, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MulticastGrenadesAvailable;
    /// <summary>
    /// Function: MulticastGrenadesAvailable
    /// </summary>
    public unsafe virtual void MulticastGrenadesAvailable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MulticastGrenadesAvailable, "BmGame.GDGameReplicationInfo.MulticastGrenadesAvailable");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MulticastGrenadesAboutToBecomeAvailable;
    /// <summary>
    /// Function: MulticastGrenadesAboutToBecomeAvailable
    /// </summary>
    public unsafe virtual void MulticastGrenadesAboutToBecomeAvailable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MulticastGrenadesAboutToBecomeAvailable, "BmGame.GDGameReplicationInfo.MulticastGrenadesAboutToBecomeAvailable");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MulticastOpenLobbyUI;
    /// <summary>
    /// Function: MulticastOpenLobbyUI
    /// </summary>
    public unsafe virtual void MulticastOpenLobbyUI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MulticastOpenLobbyUI, "BmGame.GDGameReplicationInfo.MulticastOpenLobbyUI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPawnOnIncentiveTeam;
    /// <summary>
    /// Function: IsPawnOnIncentiveTeam
    /// </summary>
    public unsafe virtual bool IsPawnOnIncentiveTeam(BmSDK.Engine.Pawn P)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPawnOnIncentiveTeam, "BmGame.GDGameReplicationInfo.IsPawnOnIncentiveTeam");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTeamTypeForTeamIndex;
    /// <summary>
    /// Function: GetTeamTypeForTeamIndex
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDGIBase.ETeamType GetTeamTypeForTeamIndex(byte TeamIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeamTypeForTeamIndex, "BmGame.GDGameReplicationInfo.GetTeamTypeForTeamIndex");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDGIBase.ETeamType>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_GetTeamInfoForType;
    /// <summary>
    /// Function: GetTeamInfoForType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDTeamInfo GetTeamInfoForType(BmSDK.BmGame.GDGIBase.ETeamType TeamType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeamInfoForType, "BmGame.GDGameReplicationInfo.GetTeamInfoForType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDTeamInfo>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetHighestMatchScoreFraction;
    /// <summary>
    /// Function: GetHighestMatchScoreFraction
    /// </summary>
    public unsafe virtual float GetHighestMatchScoreFraction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHighestMatchScoreFraction, "BmGame.GDGameReplicationInfo.GetHighestMatchScoreFraction");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckNextRoundTeamsSynchronised;
    /// <summary>
    /// Function: CheckNextRoundTeamsSynchronised
    /// </summary>
    public unsafe virtual void CheckNextRoundTeamsSynchronised()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckNextRoundTeamsSynchronised, "BmGame.GDGameReplicationInfo.CheckNextRoundTeamsSynchronised");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetScorePercentage;
    /// <summary>
    /// Function: GetScorePercentage
    /// </summary>
    public unsafe virtual int GetScorePercentage(BmSDK.BmGame.GDTeamInfo Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScorePercentage, "BmGame.GDGameReplicationInfo.GetScorePercentage");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetScore;
    /// <summary>
    /// Function: GetScore
    /// </summary>
    public unsafe virtual int GetScore(BmSDK.BmGame.GDTeamInfo Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScore, "BmGame.GDGameReplicationInfo.GetScore");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetScoreForTeamType;
    /// <summary>
    /// Function: GetScoreForTeamType
    /// </summary>
    public unsafe virtual int GetScoreForTeamType(BmSDK.BmGame.GDGIBase.ETeamType TeamType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForTeamType, "BmGame.GDGameReplicationInfo.GetScoreForTeamType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FinishedShowingHeroLotteryReview;
    /// <summary>
    /// Function: FinishedShowingHeroLotteryReview
    /// </summary>
    public unsafe virtual void FinishedShowingHeroLotteryReview()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedShowingHeroLotteryReview, "BmGame.GDGameReplicationInfo.FinishedShowingHeroLotteryReview");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerLostHeroLottery;
    /// <summary>
    /// Function: PlayerLostHeroLottery
    /// </summary>
    public unsafe virtual bool PlayerLostHeroLottery(BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerLostHeroLottery, "BmGame.GDGameReplicationInfo.PlayerLostHeroLottery");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GoToHeroLotteryReview;
    /// <summary>
    /// Function: GoToHeroLotteryReview
    /// </summary>
    public unsafe virtual void GoToHeroLotteryReview()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoToHeroLotteryReview, "BmGame.GDGameReplicationInfo.GoToHeroLotteryReview");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GoToHeroLotterySpin;
    /// <summary>
    /// Function: GoToHeroLotterySpin
    /// </summary>
    public unsafe virtual void GoToHeroLotterySpin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoToHeroLotterySpin, "BmGame.GDGameReplicationInfo.GoToHeroLotterySpin");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedShowingHeroLottery;
    /// <summary>
    /// Function: FinishedShowingHeroLottery
    /// </summary>
    public unsafe virtual void FinishedShowingHeroLottery()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedShowingHeroLottery, "BmGame.GDGameReplicationInfo.FinishedShowingHeroLottery");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNumberOfNextRoundHeroes;
    /// <summary>
    /// Function: SetNumberOfNextRoundHeroes
    /// </summary>
    public unsafe virtual void SetNumberOfNextRoundHeroes(int Num)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNumberOfNextRoundHeroes, "BmGame.GDGameReplicationInfo.SetNumberOfNextRoundHeroes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Num, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedOptOutPhase;
    /// <summary>
    /// Function: FinishedOptOutPhase
    /// </summary>
    public unsafe virtual void FinishedOptOutPhase(bool bSkipLottery)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedOptOutPhase, "BmGame.GDGameReplicationInfo.FinishedOptOutPhase");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipLottery, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAllowBaneTeamOptOut;
    /// <summary>
    /// Function: SetAllowBaneTeamOptOut
    /// </summary>
    public unsafe virtual void SetAllowBaneTeamOptOut(bool bAllowed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllowBaneTeamOptOut, "BmGame.GDGameReplicationInfo.SetAllowBaneTeamOptOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAllowJokerTeamOptOut;
    /// <summary>
    /// Function: SetAllowJokerTeamOptOut
    /// </summary>
    public unsafe virtual void SetAllowJokerTeamOptOut(bool bAllowed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllowJokerTeamOptOut, "BmGame.GDGameReplicationInfo.SetAllowJokerTeamOptOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAllowHeroTeamOptOut;
    /// <summary>
    /// Function: SetAllowHeroTeamOptOut
    /// </summary>
    public unsafe virtual void SetAllowHeroTeamOptOut(bool bAllowed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllowHeroTeamOptOut, "BmGame.GDGameReplicationInfo.SetAllowHeroTeamOptOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnHeroLottery;
    /// <summary>
    /// Function: OnHeroLottery
    /// </summary>
    public unsafe virtual void OnHeroLottery()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnHeroLottery, "BmGame.GDGameReplicationInfo.OnHeroLottery");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnGameOn;
    /// <summary>
    /// Function: OnGameOn
    /// </summary>
    public unsafe virtual void OnGameOn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGameOn, "BmGame.GDGameReplicationInfo.OnGameOn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenEndGameScoreboard;
    /// <summary>
    /// Function: OpenEndGameScoreboard
    /// </summary>
    public unsafe virtual void OpenEndGameScoreboard()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenEndGameScoreboard, "BmGame.GDGameReplicationInfo.OpenEndGameScoreboard");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRemainingEndGameReviewTime;
    /// <summary>
    /// Function: GetRemainingEndGameReviewTime
    /// </summary>
    public unsafe virtual float GetRemainingEndGameReviewTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRemainingEndGameReviewTime, "BmGame.GDGameReplicationInfo.GetRemainingEndGameReviewTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnEndGameReview;
    /// <summary>
    /// Function: OnEndGameReview
    /// </summary>
    public unsafe virtual void OnEndGameReview()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEndGameReview, "BmGame.GDGameReplicationInfo.OnEndGameReview");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedUIOutro;
    /// <summary>
    /// Function: FinishedUIOutro
    /// </summary>
    public unsafe virtual void FinishedUIOutro()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedUIOutro, "BmGame.GDGameReplicationInfo.FinishedUIOutro");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnGameOutro;
    /// <summary>
    /// Function: OnGameOutro
    /// </summary>
    public unsafe virtual void OnGameOutro()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGameOutro, "BmGame.GDGameReplicationInfo.OnGameOutro");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnGameIntro;
    /// <summary>
    /// Function: OnGameIntro
    /// </summary>
    public unsafe virtual void OnGameIntro()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGameIntro, "BmGame.GDGameReplicationInfo.OnGameIntro");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KismetEvent_EndGame;
    /// <summary>
    /// Function: KismetEvent_EndGame
    /// </summary>
    public unsafe virtual void KismetEvent_EndGame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KismetEvent_EndGame, "BmGame.GDGameReplicationInfo.KismetEvent_EndGame");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KismetEvent_GameStateChange;
    /// <summary>
    /// Function: KismetEvent_GameStateChange
    /// </summary>
    public unsafe virtual void KismetEvent_GameStateChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KismetEvent_GameStateChange, "BmGame.GDGameReplicationInfo.KismetEvent_GameStateChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsMovementInhibited;
    /// <summary>
    /// Function: IsMovementInhibited
    /// </summary>
    public unsafe virtual bool IsMovementInhibited(BmSDK.Engine.PlayerController C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMovementInhibited, "BmGame.GDGameReplicationInfo.IsMovementInhibited");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasReachedScoreLimit;
    /// <summary>
    /// Function: HasReachedScoreLimit
    /// </summary>
    public unsafe virtual bool HasReachedScoreLimit(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasReachedScoreLimit, "BmGame.GDGameReplicationInfo.HasReachedScoreLimit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetScoreLimit;
    /// <summary>
    /// Function: GetScoreLimit
    /// </summary>
    public unsafe virtual int GetScoreLimit(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreLimit, "BmGame.GDGameReplicationInfo.GetScoreLimit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ServerSetScoreLimit;
    /// <summary>
    /// Function: ServerSetScoreLimit
    /// </summary>
    public unsafe virtual void ServerSetScoreLimit(BmSDK.BmGame.GDGIBase.ETeamType Team, int Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSetScoreLimit, "BmGame.GDGameReplicationInfo.ServerSetScoreLimit");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMatchTimeRemaining;
    /// <summary>
    /// Function: GetMatchTimeRemaining
    /// </summary>
    public unsafe virtual int GetMatchTimeRemaining()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMatchTimeRemaining, "BmGame.GDGameReplicationInfo.GetMatchTimeRemaining");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMatchTime;
    /// <summary>
    /// Function: GetMatchTime
    /// </summary>
    public unsafe virtual float GetMatchTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMatchTime, "BmGame.GDGameReplicationInfo.GetMatchTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerSetGameStartTime;
    /// <summary>
    /// Function: ServerSetGameStartTime
    /// </summary>
    public unsafe virtual void ServerSetGameStartTime(float StartTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSetGameStartTime, "BmGame.GDGameReplicationInfo.ServerSetGameStartTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSetMinPlayers;
    /// <summary>
    /// Function: ServerSetMinPlayers
    /// </summary>
    public unsafe virtual void ServerSetMinPlayers(byte Players)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSetMinPlayers, "BmGame.GDGameReplicationInfo.ServerSetMinPlayers");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Players, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSetMaxPlayers;
    /// <summary>
    /// Function: ServerSetMaxPlayers
    /// </summary>
    public unsafe virtual void ServerSetMaxPlayers(byte Players)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSetMaxPlayers, "BmGame.GDGameReplicationInfo.ServerSetMaxPlayers");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Players, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnGameStateChanged;
    /// <summary>
    /// Function: OnGameStateChanged
    /// </summary>
    public unsafe virtual void OnGameStateChanged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGameStateChanged, "BmGame.GDGameReplicationInfo.OnGameStateChanged");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsIntro;
    /// <summary>
    /// Function: IsIntro
    /// </summary>
    public unsafe virtual bool IsIntro()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsIntro, "BmGame.GDGameReplicationInfo.IsIntro");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsGameOn;
    /// <summary>
    /// Function: IsGameOn
    /// </summary>
    public unsafe virtual bool IsGameOn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGameOn, "BmGame.GDGameReplicationInfo.IsGameOn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsGamePending;
    /// <summary>
    /// Function: IsGamePending
    /// </summary>
    public unsafe virtual bool IsGamePending()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGamePending, "BmGame.GDGameReplicationInfo.IsGamePending");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerSetStateTransitionToTime;
    /// <summary>
    /// Function: ServerSetStateTransitionToTime
    /// </summary>
    public unsafe virtual void ServerSetStateTransitionToTime(BmSDK.BmGame.GDGIBase.EGameState TransitionToState, float TransitionToTime, bool bAllowClientTransitionTo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSetStateTransitionToTime, "BmGame.GDGameReplicationInfo.ServerSetStateTransitionToTime");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionToState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionToTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowClientTransitionTo, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSetGameState;
    /// <summary>
    /// Function: ServerSetGameState
    /// </summary>
    public unsafe virtual void ServerSetGameState(BmSDK.BmGame.GDGIBase.EGameState GS)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSetGameState, "BmGame.GDGameReplicationInfo.ServerSetGameState");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GS, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowMessageToLocalPlayer;
    /// <summary>
    /// Function: ShowMessageToLocalPlayer
    /// </summary>
    public unsafe virtual bool ShowMessageToLocalPlayer(BmSDK.BmGame.GDGIBase.FSMatchObjectiveText Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowMessageToLocalPlayer, "BmGame.GDGameReplicationInfo.ShowMessageToLocalPlayer");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.GDGameReplicationInfo.Tick");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForStateTransition;
    /// <summary>
    /// Function: CheckForStateTransition
    /// </summary>
    public unsafe virtual void CheckForStateTransition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForStateTransition, "BmGame.GDGameReplicationInfo.CheckForStateTransition");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNextStateTransitionTime;
    /// <summary>
    /// Function: GetNextStateTransitionTime
    /// </summary>
    public unsafe virtual float GetNextStateTransitionTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextStateTransitionTime, "BmGame.GDGameReplicationInfo.GetNextStateTransitionTime");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Reset;
    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe override void Reset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reset, "BmGame.GDGameReplicationInfo.Reset");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsGameOver;
    /// <summary>
    /// Function: IsGameOver
    /// </summary>
    public unsafe virtual bool IsGameOver()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGameOver, "BmGame.GDGameReplicationInfo.IsGameOver");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPresenceContext;
    /// <summary>
    /// Function: GetPresenceContext
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.EMatchTypeContexts GetPresenceContext()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPresenceContext, "BmGame.GDGameReplicationInfo.GetPresenceContext");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.EMatchTypeContexts>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Timer;
    /// <summary>
    /// Function: Timer
    /// </summary>
    public unsafe override void Timer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Timer, "BmGame.GDGameReplicationInfo.Timer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplicatedEvent;
    /// <summary>
    /// Function: ReplicatedEvent
    /// </summary>
    public unsafe override void ReplicatedEvent(BmSDK.FName VarName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicatedEvent, "BmGame.GDGameReplicationInfo.ReplicatedEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.GDGameReplicationInfo.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreBeginPlay;
    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe override void PreBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreBeginPlay, "BmGame.GDGameReplicationInfo.PreBeginPlay");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.GDGameReplicationInfo.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NextRoundTeamsSynchronised;
    /// <summary>
    /// Function: NextRoundTeamsSynchronised
    /// </summary>
    public unsafe virtual void NextRoundTeamsSynchronised()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NextRoundTeamsSynchronised, "BmGame.GDGameReplicationInfo.NextRoundTeamsSynchronised");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: GameState
    /// </summary>
    public unsafe BmSDK.BmGame.GDGIBase.EGameState GameState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGIBase.EGameState>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// ByteProperty: OldGameState
    /// </summary>
    public unsafe BmSDK.BmGame.GDGIBase.EGameState OldGameState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGIBase.EGameState>(Ptr + 1501); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1501); }
    }

    /// <summary>
    /// ByteProperty: MaxPlayers
    /// </summary>
    public unsafe byte MaxPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1502); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1502); }
    }

    /// <summary>
    /// ByteProperty: MinPlayers
    /// </summary>
    public unsafe byte MinPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1503); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1503); }
    }

    /// <summary>
    /// ByteProperty: ScoreIncentiveTeam
    /// </summary>
    public unsafe BmSDK.BmGame.GDGIBase.ETeamType ScoreIncentiveTeam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGIBase.ETeamType>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// ByteProperty: ThugScoringMethod
    /// </summary>
    public unsafe BmSDK.BmGame.GDMatchSettings.EScoringMethod ThugScoringMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDMatchSettings.EScoringMethod>(Ptr + 1505); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1505); }
    }

    /// <summary>
    /// ByteProperty: HeroScoringMethod
    /// </summary>
    public unsafe BmSDK.BmGame.GDMatchSettings.EScoringMethod HeroScoringMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDMatchSettings.EScoringMethod>(Ptr + 1506); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1506); }
    }

    /// <summary>
    /// FloatProperty: GameStartTime
    /// </summary>
    public unsafe float GameStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// FloatProperty: EndGameReviewDuration
    /// </summary>
    public unsafe float EndGameReviewDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// FloatProperty: ScoreIncentiveFactor
    /// </summary>
    public unsafe float ScoreIncentiveFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// ArrayProperty: CachedTeamIndices
    /// </summary>
    public unsafe BmSDK.TArray<int> CachedTeamIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// ObjectProperty: GameplayModifierManager
    /// </summary>
    public unsafe BmSDK.BmGame.GDConsumableManager GameplayModifierManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDConsumableManager>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// ClassProperty: GameModeObjectiveRendererClass
    /// </summary>
    public unsafe BmSDK.Class GameModeObjectiveRendererClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// ClassProperty: GameModeTeamInfoRendererClass
    /// </summary>
    public unsafe BmSDK.Class GameModeTeamInfoRendererClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: TeamGoalScores
    /// </summary>
    public InlineArray<int> TeamGoalScores => new(5, Ptr + 1544, 4, this);

    /// <summary>
    /// IntProperty: TeamGoalScores
    /// </summary>
    public unsafe int TeamGoalScores_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }
    /// <summary>
    /// IntProperty: TeamGoalScores
    /// </summary>
    public unsafe int TeamGoalScores_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }
    /// <summary>
    /// IntProperty: TeamGoalScores
    /// </summary>
    public unsafe int TeamGoalScores_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }
    /// <summary>
    /// IntProperty: TeamGoalScores
    /// </summary>
    public unsafe int TeamGoalScores_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }
    /// <summary>
    /// IntProperty: TeamGoalScores
    /// </summary>
    public unsafe int TeamGoalScores_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: UseRespawns
    /// </summary>
    public unsafe bool UseRespawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bShowIntimidationBar
    /// </summary>
    public unsafe bool bShowIntimidationBar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bShowTimeWarningMessages
    /// </summary>
    public unsafe bool bShowTimeWarningMessages
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bAllowHeroTeamOptOut
    /// </summary>
    public unsafe bool bAllowHeroTeamOptOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bAllowBaneTeamOptOut
    /// </summary>
    public unsafe bool bAllowBaneTeamOptOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bAllowJokerTeamOptOut
    /// </summary>
    public unsafe bool bAllowJokerTeamOptOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bFlippedInitialSpawns
    /// </summary>
    public unsafe bool bFlippedInitialSpawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bFakeHeroLottery
    /// </summary>
    public unsafe bool bFakeHeroLottery
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// FloatProperty: ThugScoreBankRatio
    /// </summary>
    public unsafe float ThugScoreBankRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// FloatProperty: HeroScoreBankRatio
    /// </summary>
    public unsafe float HeroScoreBankRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderCaptain
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderCaptain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderNotCaptain
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderNotCaptain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderCaptainChange
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderCaptainChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnGrenades
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnGrenades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnVillianSpawnComment
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnVillianSpawnComment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// ObjectProperty: MusicEventCaptainChange
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent MusicEventCaptainChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// FloatProperty: ObjectiveTextDisplayDuration
    /// </summary>
    public unsafe float ObjectiveTextDisplayDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }

    /// <summary>
    /// IntProperty: StartingGrenadeCount
    /// </summary>
    public unsafe int StartingGrenadeCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }

    /// <summary>
    /// ObjectProperty: ControllerSwapStore
    /// </summary>
    public unsafe BmSDK.BmGame.GDTransientControllerSwapStore ControllerSwapStore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDTransientControllerSwapStore>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: IntroMessages
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText> IntroMessages => new(10, Ptr + 1612, 32, this);

    /// <summary>
    /// StructProperty: IntroMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText IntroMessages_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 1612);
    /// <summary>
    /// StructProperty: IntroMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText IntroMessages_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 1644);
    /// <summary>
    /// StructProperty: IntroMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText IntroMessages_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 1676);
    /// <summary>
    /// StructProperty: IntroMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText IntroMessages_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 1708);
    /// <summary>
    /// StructProperty: IntroMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText IntroMessages_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 1740);
    /// <summary>
    /// StructProperty: IntroMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText IntroMessages_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 1772);
    /// <summary>
    /// StructProperty: IntroMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText IntroMessages_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 1804);
    /// <summary>
    /// StructProperty: IntroMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText IntroMessages_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 1836);
    /// <summary>
    /// StructProperty: IntroMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText IntroMessages_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 1868);
    /// <summary>
    /// StructProperty: IntroMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText IntroMessages_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 1900);

    /// <summary>
    /// InlineArray{StructProperty}: TimedMessages
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText> TimedMessages => new(10, Ptr + 1932, 32, this);

    /// <summary>
    /// StructProperty: TimedMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText TimedMessages_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 1932);
    /// <summary>
    /// StructProperty: TimedMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText TimedMessages_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 1964);
    /// <summary>
    /// StructProperty: TimedMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText TimedMessages_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 1996);
    /// <summary>
    /// StructProperty: TimedMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText TimedMessages_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 2028);
    /// <summary>
    /// StructProperty: TimedMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText TimedMessages_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 2060);
    /// <summary>
    /// StructProperty: TimedMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText TimedMessages_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 2092);
    /// <summary>
    /// StructProperty: TimedMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText TimedMessages_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 2124);
    /// <summary>
    /// StructProperty: TimedMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText TimedMessages_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 2156);
    /// <summary>
    /// StructProperty: TimedMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText TimedMessages_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 2188);
    /// <summary>
    /// StructProperty: TimedMessages
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSMatchObjectiveText TimedMessages_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>(Ptr + 2220);

    /// <summary>
    /// FloatProperty: OptOutPhaseEndTime
    /// </summary>
    public unsafe float OptOutPhaseEndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// FloatProperty: OptOutPhaseDuration
    /// </summary>
    public unsafe float OptOutPhaseDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// IntProperty: NumberOfNextRoundHeroes
    /// </summary>
    public unsafe int NumberOfNextRoundHeroes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// FloatProperty: HeroLotteryTransitionToReviewDelay
    /// </summary>
    public unsafe float HeroLotteryTransitionToReviewDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// ObjectProperty: ExperienceValues
    /// </summary>
    public unsafe BmSDK.BmGame.GDExperienceValues ExperienceValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDExperienceValues>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: StateTransitionData
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDGameReplicationInfo.FSStateTransitionData> StateTransitionData => new(6, Ptr + 2272, 8, this);

    /// <summary>
    /// StructProperty: StateTransitionData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGameReplicationInfo.FSStateTransitionData StateTransitionData_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGameReplicationInfo.FSStateTransitionData>(Ptr + 2272);
    /// <summary>
    /// StructProperty: StateTransitionData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGameReplicationInfo.FSStateTransitionData StateTransitionData_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGameReplicationInfo.FSStateTransitionData>(Ptr + 2280);
    /// <summary>
    /// StructProperty: StateTransitionData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGameReplicationInfo.FSStateTransitionData StateTransitionData_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGameReplicationInfo.FSStateTransitionData>(Ptr + 2288);
    /// <summary>
    /// StructProperty: StateTransitionData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGameReplicationInfo.FSStateTransitionData StateTransitionData_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGameReplicationInfo.FSStateTransitionData>(Ptr + 2296);
    /// <summary>
    /// StructProperty: StateTransitionData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGameReplicationInfo.FSStateTransitionData StateTransitionData_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGameReplicationInfo.FSStateTransitionData>(Ptr + 2304);
    /// <summary>
    /// StructProperty: StateTransitionData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGameReplicationInfo.FSStateTransitionData StateTransitionData_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGameReplicationInfo.FSStateTransitionData>(Ptr + 2312);

    /// <summary>
    /// FloatProperty: ForcedStateTransitionTimeBeforeError
    /// </summary>
    public unsafe float ForcedStateTransitionTimeBeforeError
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// ObjectProperty: StateTransitionErrorPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester StateTransitionErrorPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// DelegateProperty: __NextRoundTeamsSynchronised__Delegate
    /// </summary>
    public unsafe System.IntPtr __NextRoundTeamsSynchronised__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }

    /// <summary>
    /// Struct: FSStateTransitionData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FSStateTransitionData
    {
        /// <summary>
        /// FloatProperty: TransitionToTime
        /// </summary>
        public unsafe float TransitionToTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bClientCanTransitionTo
        /// </summary>
        public unsafe bool bClientCanTransitionTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }
    }
}
