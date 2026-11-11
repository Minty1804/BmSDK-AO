#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: GDGITeamGame<br/>
/// (size = 1744)
/// (flags = 10518583)
/// </summary>
public partial class GDGITeamGame : BmSDK.BmGame.GDGIBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGITeamGame", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGITeamGame.
    /// </summary>
    public static GDGITeamGame DefaultObject => (GDGITeamGame)StaticClass().DefaultObject;

    internal GDGITeamGame() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGITeamGame(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGITeamGame>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGITeamGame>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGITeamGame>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGITeamGame>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGITeamGame>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGITeamGame>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGITeamGame>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGITeamGame>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_LogStatsPlayerResults;
    /// <summary>
    /// Function: LogStatsPlayerResults
    /// </summary>
    public unsafe override void LogStatsPlayerResults()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogStatsPlayerResults, "BmGame.GDGITeamGame.LogStatsPlayerResults");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsWinningPlayer;
    /// <summary>
    /// Function: IsWinningPlayer
    /// </summary>
    public unsafe override bool IsWinningPlayer(BmSDK.Engine.PlayerReplicationInfo PRI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWinningPlayer, "BmGame.GDGITeamGame.IsWinningPlayer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayForever;
    /// <summary>
    /// Function: PlayForever
    /// </summary>
    public unsafe override void PlayForever()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayForever, "BmGame.GDGITeamGame.PlayForever");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetThugScoreLimit;
    /// <summary>
    /// Function: SetThugScoreLimit
    /// </summary>
    public unsafe virtual void SetThugScoreLimit(int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetThugScoreLimit, "BmGame.GDGITeamGame.SetThugScoreLimit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndGameBane;
    /// <summary>
    /// Function: EndGameBane
    /// </summary>
    public unsafe virtual void EndGameBane()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndGameBane, "BmGame.GDGITeamGame.EndGameBane");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndGameJoker;
    /// <summary>
    /// Function: EndGameJoker
    /// </summary>
    public unsafe virtual void EndGameJoker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndGameJoker, "BmGame.GDGITeamGame.EndGameJoker");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetKillAssistScoreAndXP;
    /// <summary>
    /// Function: GetKillAssistScoreAndXP
    /// </summary>
    public unsafe override bool GetKillAssistScoreAndXP(BmSDK.BmGame.RPlayerController KilledPlayer, BmSDK.BmGame.RPlayerController AssistingPlayer, out int Score, out BmSDK.BmGame.RGameInfo.NewExperienceAmounts NEAType, BmSDK.Class RDamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKillAssistScoreAndXP, "BmGame.GDGITeamGame.GetKillAssistScoreAndXP");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AssistingPlayer, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Score);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NEAType);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NEAType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RDamageType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Score = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        NEAType = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.NewExperienceAmounts>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GiveAssistScore;
    /// <summary>
    /// Function: GiveAssistScore
    /// </summary>
    public unsafe override void GiveAssistScore(BmSDK.BmGame.RPlayerController Player, int Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveAssistScore, "BmGame.GDGITeamGame.GiveAssistScore");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResolveTie;
    /// <summary>
    /// Function: ResolveTie
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDTeamInfo ResolveTie(BmSDK.TArray<BmSDK.BmGame.GDTeamInfo> WinningTeams)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResolveTie, "BmGame.GDGITeamGame.ResolveTie");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WinningTeams, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDTeamInfo>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CheckTeamScores;
    /// <summary>
    /// Function: CheckTeamScores
    /// </summary>
    public unsafe virtual bool CheckTeamScores()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckTeamScores, "BmGame.GDGITeamGame.CheckTeamScores");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitGameReplicationInfo;
    /// <summary>
    /// Function: InitGameReplicationInfo
    /// </summary>
    public unsafe override void InitGameReplicationInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitGameReplicationInfo, "BmGame.GDGITeamGame.InitGameReplicationInfo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TeamReachedHighScoreWarning;
    /// <summary>
    /// Function: TeamReachedHighScoreWarning
    /// </summary>
    public unsafe virtual void TeamReachedHighScoreWarning(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeamReachedHighScoreWarning, "BmGame.GDGITeamGame.TeamReachedHighScoreWarning");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TeamReachedScoreWarning;
    /// <summary>
    /// Function: TeamReachedScoreWarning
    /// </summary>
    public unsafe virtual void TeamReachedScoreWarning(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeamReachedScoreWarning, "BmGame.GDGITeamGame.TeamReachedScoreWarning");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasReachedScoreWarning;
    /// <summary>
    /// Function: HasReachedScoreWarning
    /// </summary>
    public unsafe virtual bool HasReachedScoreWarning(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasReachedScoreWarning, "BmGame.GDGITeamGame.HasReachedScoreWarning");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasReachedHighScoreWarning;
    /// <summary>
    /// Function: HasReachedHighScoreWarning
    /// </summary>
    public unsafe virtual bool HasReachedHighScoreWarning(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasReachedHighScoreWarning, "BmGame.GDGITeamGame.HasReachedHighScoreWarning");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetScoreLimits;
    /// <summary>
    /// Function: SetScoreLimits
    /// </summary>
    public unsafe override void SetScoreLimits(BmSDK.BmGame.GDMatchSettings FromSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScoreLimits, "BmGame.GDGITeamGame.SetScoreLimits");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromSettings, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearGameWideRegenBoost;
    /// <summary>
    /// Function: ClearGameWideRegenBoost
    /// </summary>
    public unsafe override void ClearGameWideRegenBoost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGameWideRegenBoost, "BmGame.GDGITeamGame.ClearGameWideRegenBoost");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyGameWideRegenBoost;
    /// <summary>
    /// Function: ApplyGameWideRegenBoost
    /// </summary>
    public unsafe override void ApplyGameWideRegenBoost(BmSDK.BmGame.RPlayerController LauncherPC, float BoostAmount, BmSDK.BmGame.RPawnPlayer Victim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyGameWideRegenBoost, "BmGame.GDGITeamGame.ApplyGameWideRegenBoost");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LauncherPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoostAmount, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLeadingTeam;
    /// <summary>
    /// Function: GetLeadingTeam
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDTeamInfo GetLeadingTeam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLeadingTeam, "BmGame.GDGITeamGame.GetLeadingTeam");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDTeamInfo>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTeamInfoForType;
    /// <summary>
    /// Function: GetTeamInfoForType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDTeamInfo GetTeamInfoForType(BmSDK.BmGame.GDGIBase.ETeamType TeamType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeamInfoForType, "BmGame.GDGITeamGame.GetTeamInfoForType");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDTeamInfo>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetRespawnTime;
    /// <summary>
    /// Function: GetRespawnTime
    /// </summary>
    public unsafe override float GetRespawnTime(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRespawnTime, "BmGame.GDGITeamGame.GetRespawnTime");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RemoveScoreFromTeam;
    /// <summary>
    /// Function: RemoveScoreFromTeam
    /// </summary>
    public unsafe virtual void RemoveScoreFromTeam(int TeamIndex, float Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveScoreFromTeam, "BmGame.GDGITeamGame.RemoveScoreFromTeam");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckScoreBanks;
    /// <summary>
    /// Function: CheckScoreBanks
    /// </summary>
    public unsafe virtual void CheckScoreBanks(BmSDK.BmGame.GDGIBase.ETeamType Team, out int ScoreToRemove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckScoreBanks, "BmGame.GDGITeamGame.CheckScoreBanks");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ScoreToRemove);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScoreToRemove, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ScoreToRemove = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_AddScoreToTeam;
    /// <summary>
    /// Function: AddScoreToTeam
    /// </summary>
    public unsafe virtual void AddScoreToTeam(int TeamIndex, float Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddScoreToTeam, "BmGame.GDGITeamGame.AddScoreToTeam");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveScoreFromTeamType;
    /// <summary>
    /// Function: RemoveScoreFromTeamType
    /// </summary>
    public unsafe virtual void RemoveScoreFromTeamType(BmSDK.BmGame.GDGIBase.ETeamType Team, float Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveScoreFromTeamType, "BmGame.GDGITeamGame.RemoveScoreFromTeamType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddScoreToTeamType;
    /// <summary>
    /// Function: AddScoreToTeamType
    /// </summary>
    public unsafe virtual void AddScoreToTeamType(BmSDK.BmGame.GDGIBase.ETeamType Team, float Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddScoreToTeamType, "BmGame.GDGITeamGame.AddScoreToTeamType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveKillScore;
    /// <summary>
    /// Function: GiveKillScore
    /// </summary>
    public unsafe override void GiveKillScore(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveKillScore, "BmGame.GDGITeamGame.GiveKillScore");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsOnTeamType;
    /// <summary>
    /// Function: IsOnTeamType
    /// </summary>
    public unsafe virtual bool IsOnTeamType(BmSDK.Engine.Controller C, BmSDK.BmGame.GDGIBase.ETeamType TeamType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOnTeamType, "BmGame.GDGITeamGame.IsOnTeamType");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsThugTeam;
    /// <summary>
    /// Function: IsThugTeam
    /// </summary>
    public unsafe virtual bool IsThugTeam(BmSDK.Engine.Controller C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsThugTeam, "BmGame.GDGITeamGame.IsThugTeam");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNumPlayers;
    /// <summary>
    /// Function: GetNumPlayers
    /// </summary>
    public unsafe override int GetNumPlayers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumPlayers, "BmGame.GDGITeamGame.GetNumPlayers");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayerCountForTeamType;
    /// <summary>
    /// Function: PlayerCountForTeamType
    /// </summary>
    public unsafe virtual int PlayerCountForTeamType(BmSDK.BmGame.GDGIBase.ETeamType TeamType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerCountForTeamType, "BmGame.GDGITeamGame.PlayerCountForTeamType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayerCountForTeam;
    /// <summary>
    /// Function: PlayerCountForTeam
    /// </summary>
    public unsafe virtual int PlayerCountForTeam(BmSDK.BmGame.GDTeamInfo TeamInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerCountForTeam, "BmGame.GDGITeamGame.PlayerCountForTeam");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBestTeamIndex;
    /// <summary>
    /// Function: GetBestTeamIndex
    /// </summary>
    public unsafe override byte GetBestTeamIndex()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestTeamIndex, "BmGame.GDGITeamGame.GetBestTeamIndex");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMaxCapacity;
    /// <summary>
    /// Function: GetMaxCapacity
    /// </summary>
    public unsafe override int GetMaxCapacity()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxCapacity, "BmGame.GDGITeamGame.GetMaxCapacity");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_LoadTeams;
    /// <summary>
    /// Function: LoadTeams
    /// </summary>
    public unsafe override void LoadTeams()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadTeams, "BmGame.GDGITeamGame.LoadTeams");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTeamForID;
    /// <summary>
    /// Function: GetTeamForID
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDTeamInfo GetTeamForID(int TeamID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeamForID, "BmGame.GDGITeamGame.GetTeamForID");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDTeamInfo>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SeamlessTravelRestoreTeams;
    /// <summary>
    /// Function: SeamlessTravelRestoreTeams
    /// </summary>
    public unsafe virtual void SeamlessTravelRestoreTeams()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SeamlessTravelRestoreTeams, "BmGame.GDGITeamGame.SeamlessTravelRestoreTeams");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SeamlessTravelStoreTeams;
    /// <summary>
    /// Function: SeamlessTravelStoreTeams
    /// </summary>
    public unsafe virtual void SeamlessTravelStoreTeams()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SeamlessTravelStoreTeams, "BmGame.GDGITeamGame.SeamlessTravelStoreTeams");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessServerTravel;
    /// <summary>
    /// Function: ProcessServerTravel
    /// </summary>
    public unsafe override void ProcessServerTravel(BmSDK.FString URL, bool bAbsolute = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessServerTravel, "BmGame.GDGITeamGame.ProcessServerTravel");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAbsolute, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeTeam;
    /// <summary>
    /// Function: ChangeTeam
    /// </summary>
    public unsafe override bool ChangeTeam(BmSDK.Engine.Controller Other, int N, bool bNewTeam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeTeam, "BmGame.GDGITeamGame.ChangeTeam");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(N, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewTeam, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_EndGameTeam;
    /// <summary>
    /// Function: EndGameTeam
    /// </summary>
    public unsafe override void EndGameTeam(BmSDK.BmGame.GDTeamInfo Winner, BmSDK.FString Reason)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndGameTeam, "BmGame.GDGITeamGame.EndGameTeam");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndGame;
    /// <summary>
    /// Function: EndGame
    /// </summary>
    public unsafe override void EndGame(BmSDK.Engine.PlayerReplicationInfo Winner, BmSDK.FString Reason)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndGame, "BmGame.GDGITeamGame.EndGame");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoGameSpecificLogin;
    /// <summary>
    /// Function: DoGameSpecificLogin
    /// </summary>
    public unsafe override BmSDK.Engine.PlayerController DoGameSpecificLogin(BmSDK.FString Portal, BmSDK.FString Options, BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, out BmSDK.FString ErrorMessage, bool bSpectator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoGameSpecificLogin, "BmGame.GDGITeamGame.DoGameSpecificLogin");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Portal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpectator, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ErrorMessage = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerController>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_PickTeamForNetId;
    /// <summary>
    /// Function: PickTeamForNetId
    /// </summary>
    public unsafe virtual byte PickTeamForNetId(byte Current, BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickTeamForNetId, "BmGame.GDGITeamGame.PickTeamForNetId");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetValidPlayerStarts;
    /// <summary>
    /// Function: GetValidPlayerStarts
    /// </summary>
    public unsafe override void GetValidPlayerStarts(BmSDK.BmGame.GDGIBase.ETeamType Team, BmSDK.BmGame.RPlayerController Player, out BmSDK.TArray<BmSDK.BmGame.GDPlayerStart> ValidStarts)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetValidPlayerStarts, "BmGame.GDGITeamGame.GetValidPlayerStarts");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ValidStarts = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDPlayerStart>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_DoGameSpecificPostSeamlessTravel;
    /// <summary>
    /// Function: DoGameSpecificPostSeamlessTravel
    /// </summary>
    public unsafe override void DoGameSpecificPostSeamlessTravel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoGameSpecificPostSeamlessTravel, "BmGame.GDGITeamGame.DoGameSpecificPostSeamlessTravel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlayerTeamName;
    /// <summary>
    /// Function: GetPlayerTeamName
    /// </summary>
    public unsafe override BmSDK.FString GetPlayerTeamName(BmSDK.Engine.Controller C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerTeamName, "BmGame.GDGITeamGame.GetPlayerTeamName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnPlayerControllerGD;
    /// <summary>
    /// Function: SpawnPlayerControllerGD
    /// </summary>
    public unsafe override BmSDK.Engine.PlayerController SpawnPlayerControllerGD(int TeamIndex, System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation, in BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerUniqueId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnPlayerControllerGD, "BmGame.GDGITeamGame.SpawnPlayerControllerGD");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerUniqueId, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerController>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_SpawnPlayerControllerGDFromController;
    /// <summary>
    /// Function: SpawnPlayerControllerGDFromController
    /// </summary>
    public unsafe override BmSDK.Engine.PlayerController SpawnPlayerControllerGDFromController(out BmSDK.Engine.Controller C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnPlayerControllerGDFromController, "BmGame.GDGITeamGame.SpawnPlayerControllerGDFromController");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out C);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        C = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Controller>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerController>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPlayerControllerClass;
    /// <summary>
    /// Function: GetPlayerControllerClass
    /// </summary>
    public unsafe override BmSDK.Class GetPlayerControllerClass(out BmSDK.Engine.Controller C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerControllerClass, "BmGame.GDGITeamGame.GetPlayerControllerClass");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out C);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        C = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Controller>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetWinnerString;
    /// <summary>
    /// Function: GetWinnerString
    /// </summary>
    public unsafe override BmSDK.FString GetWinnerString()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWinnerString, "BmGame.GDGITeamGame.GetWinnerString");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPlayerTeamCaptain;
    /// <summary>
    /// Function: IsPlayerTeamCaptain
    /// </summary>
    public unsafe virtual bool IsPlayerTeamCaptain(BmSDK.BmGame.RPlayerController Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerTeamCaptain, "BmGame.GDGITeamGame.IsPlayerTeamCaptain");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AssignRemainder;
    /// <summary>
    /// Function: AssignRemainder
    /// </summary>
    public unsafe static void AssignRemainder(out BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember> UnassignedPlayers, BmSDK.BmGame.GDLobbySystemSteam LobbySys)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignRemainder, "BmGame.GDGITeamGame.AssignRemainder");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbySys, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        UnassignedPlayers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_IgnoreTeamForRemainderCheck;
    /// <summary>
    /// Function: IgnoreTeamForRemainderCheck
    /// </summary>
    public unsafe static int IgnoreTeamForRemainderCheck()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IgnoreTeamForRemainderCheck, "BmGame.GDGITeamGame.IgnoreTeamForRemainderCheck");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AssignPreferredFactions;
    /// <summary>
    /// Function: AssignPreferredFactions
    /// </summary>
    public unsafe static void AssignPreferredFactions(out BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember> UnassignedPlayers, BmSDK.BmGame.GDLobbySystemSteam LobbySys)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignPreferredFactions, "BmGame.GDGITeamGame.AssignPreferredFactions");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbySys, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        UnassignedPlayers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetTeamToAssignTo;
    /// <summary>
    /// Function: GetTeamToAssignTo
    /// </summary>
    public unsafe static int GetTeamToAssignTo(BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember ForPlayer, BmSDK.BmGame.GDLobbySystemSteam LobbySys)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeamToAssignTo, "BmGame.GDGITeamGame.GetTeamToAssignTo");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbySys, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_DoTeamAssignmentStep;
    /// <summary>
    /// Function: DoTeamAssignmentStep
    /// </summary>
    public unsafe static void DoTeamAssignmentStep(BmSDK.BmGame.GDGITeamGame.ETeamAssignmentStep Step, BmSDK.BmGame.GDLobbySystemSteam LobbySys, out BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember> UnassignedPlayers)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoTeamAssignmentStep, "BmGame.GDGITeamGame.DoTeamAssignmentStep");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Step, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbySys, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        UnassignedPlayers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_AssignTeams;
    /// <summary>
    /// Function: AssignTeams
    /// </summary>
    public unsafe static void AssignTeams()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignTeams, "BmGame.GDGITeamGame.AssignTeams");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GameModeRequiresHeroesAssetPreload;
    /// <summary>
    /// Function: GameModeRequiresHeroesAssetPreload
    /// </summary>
    public unsafe static bool GameModeRequiresHeroesAssetPreload()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GameModeRequiresHeroesAssetPreload, "BmGame.GDGITeamGame.GameModeRequiresHeroesAssetPreload");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLobbyFactionForPlayer;
    /// <summary>
    /// Function: GetLobbyFactionForPlayer
    /// </summary>
    public unsafe static int GetLobbyFactionForPlayer(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyFactionForPlayer, "BmGame.GDGITeamGame.GetLobbyFactionForPlayer");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetLobbyTeamIndices;
    /// <summary>
    /// Function: GetLobbyTeamIndices
    /// </summary>
    public unsafe static void GetLobbyTeamIndices(out int HeroTeamIndex, out int JokerTeamIndex, out int BaneTeamIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyTeamIndices, "BmGame.GDGITeamGame.GetLobbyTeamIndices");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HeroTeamIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeroTeamIndex, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out JokerTeamIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JokerTeamIndex, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BaneTeamIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaneTeamIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HeroTeamIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        JokerTeamIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        BaneTeamIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_GetBestTeamIndexStatic;
    /// <summary>
    /// Function: GetBestTeamIndexStatic
    /// </summary>
    public unsafe static int GetBestTeamIndexStatic(BmSDK.TArray<int> TeamPlayerCounts)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestTeamIndexStatic, "BmGame.GDGITeamGame.GetBestTeamIndexStatic");
        byte* paramsPtr = stackalloc byte[41];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamPlayerCounts, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetTeamIndexForLobbyParty;
    /// <summary>
    /// Function: GetTeamIndexForLobbyParty
    /// </summary>
    public unsafe static int GetTeamIndexForLobbyParty(in BmSDK.IpDrv.PartyBeacon.FPartyReservation IncomingParty, out BmSDK.TArray<int> TeamPlayerCounts)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeamIndexForLobbyParty, "BmGame.GDGITeamGame.GetTeamIndexForLobbyParty");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncomingParty, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TeamPlayerCounts = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetLobbyDetails;
    /// <summary>
    /// Function: GetLobbyDetails
    /// </summary>
    public unsafe static void GetLobbyDetails(out int NumTeams, out int MaxPlayerCount, out int ThugTeamSize, out int HeroTeamSize)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyDetails, "BmGame.GDGITeamGame.GetLobbyDetails");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NumTeams);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumTeams, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MaxPlayerCount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxPlayerCount, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThugTeamSize);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugTeamSize, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HeroTeamSize);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeroTeamSize, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NumTeams = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        MaxPlayerCount = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        ThugTeamSize = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        HeroTeamSize = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetNumTeams;
    /// <summary>
    /// Function: GetNumTeams
    /// </summary>
    public unsafe static int GetNumTeams()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumTeams, "BmGame.GDGITeamGame.GetNumTeams");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitGame;
    /// <summary>
    /// Function: InitGame
    /// </summary>
    public unsafe override void InitGame(BmSDK.FString Options, out BmSDK.FString ErrorMessage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitGame, "BmGame.GDGITeamGame.InitGame");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ErrorMessage = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_DoGameSpecificSeamlessTravelPlayer;
    /// <summary>
    /// Function: DoGameSpecificSeamlessTravelPlayer
    /// </summary>
    public unsafe override void DoGameSpecificSeamlessTravelPlayer(out BmSDK.Engine.Controller C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoGameSpecificSeamlessTravelPlayer, "BmGame.GDGITeamGame.DoGameSpecificSeamlessTravelPlayer");
        byte* paramsPtr = stackalloc byte[37];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out C);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        C = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Controller>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_PreBeginPlay;
    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe override void PreBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreBeginPlay, "BmGame.GDGITeamGame.PreBeginPlay");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: Teams
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDGITeamGame.FSTeam> Teams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDGITeamGame.FSTeam>>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// IntProperty: StartThugTeamsIndex
    /// </summary>
    public unsafe int StartThugTeamsIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// IntProperty: MaxPlayersThugTeam
    /// </summary>
    public unsafe int MaxPlayersThugTeam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: InitialStartsForTeamType
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDGITeamGame.FSInitialSpawns> InitialStartsForTeamType => new(5, Ptr + 1680, 12, this);

    /// <summary>
    /// StructProperty: InitialStartsForTeamType
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGITeamGame.FSInitialSpawns InitialStartsForTeamType_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGITeamGame.FSInitialSpawns>(Ptr + 1680);
    /// <summary>
    /// StructProperty: InitialStartsForTeamType
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGITeamGame.FSInitialSpawns InitialStartsForTeamType_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGITeamGame.FSInitialSpawns>(Ptr + 1692);
    /// <summary>
    /// StructProperty: InitialStartsForTeamType
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGITeamGame.FSInitialSpawns InitialStartsForTeamType_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGITeamGame.FSInitialSpawns>(Ptr + 1704);
    /// <summary>
    /// StructProperty: InitialStartsForTeamType
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGITeamGame.FSInitialSpawns InitialStartsForTeamType_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGITeamGame.FSInitialSpawns>(Ptr + 1716);
    /// <summary>
    /// StructProperty: InitialStartsForTeamType
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGITeamGame.FSInitialSpawns InitialStartsForTeamType_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGITeamGame.FSInitialSpawns>(Ptr + 1728);

    /// <summary>
    /// BoolProperty: bForceFlipSpawns
    /// </summary>
    public unsafe bool bForceFlipSpawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1740) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1740); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1740); }
    }

    /// <summary>
    /// Struct: FSInitialSpawns
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSInitialSpawns
    {
        /// <summary>
        /// ArrayProperty: InitialSpawns
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDPlayerStart> InitialSpawns
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDPlayerStart>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: ETeamAssignmentStep
    /// </summary>
    public enum ETeamAssignmentStep : byte
    {
        ETeamAssignmentStep_Heroes = 0,
        ETeamAssignmentStep_PreferredFactions = 1,
        ETeamAssignmentStep_Remainder = 2,
        ETeamAssignmentStep_MAX = 3,
    }

    /// <summary>
    /// Struct: FSTeam
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FSTeam
    {
        /// <summary>
        /// ObjectProperty: TeamInfo
        /// </summary>
        public unsafe BmSDK.BmGame.GDTeamInfo TeamInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDTeamInfo>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: MaxPlayers
        /// </summary>
        public unsafe int MaxPlayers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
