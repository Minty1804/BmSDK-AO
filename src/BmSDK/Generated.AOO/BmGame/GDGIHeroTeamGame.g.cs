#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: GDGIHeroTeamGame<br/>
/// (size = 1868)
/// (flags = 10518583)
/// </summary>
public partial class GDGIHeroTeamGame : BmSDK.BmGame.GDGITeamGame, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGIHeroTeamGame", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGIHeroTeamGame.
    /// </summary>
    public static GDGIHeroTeamGame DefaultObject => (GDGIHeroTeamGame)StaticClass().DefaultObject;

    internal GDGIHeroTeamGame() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGIHeroTeamGame(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGIHeroTeamGame>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIHeroTeamGame>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGIHeroTeamGame>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIHeroTeamGame>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIHeroTeamGame>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIHeroTeamGame>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGIHeroTeamGame>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIHeroTeamGame>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PlayForever;
    /// <summary>
    /// Function: PlayForever
    /// </summary>
    public unsafe override void PlayForever()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayForever, "BmGame.GDGIHeroTeamGame.PlayForever");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHeroScore;
    /// <summary>
    /// Function: SetHeroScore
    /// </summary>
    public unsafe virtual void SetHeroScore(int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHeroScore, "BmGame.GDGIHeroTeamGame.SetHeroScore");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHeroScoreLimit;
    /// <summary>
    /// Function: SetHeroScoreLimit
    /// </summary>
    public unsafe virtual void SetHeroScoreLimit(int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHeroScoreLimit, "BmGame.GDGIHeroTeamGame.SetHeroScoreLimit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndGameHero;
    /// <summary>
    /// Function: EndGameHero
    /// </summary>
    public unsafe virtual void EndGameHero()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndGameHero, "BmGame.GDGIHeroTeamGame.EndGameHero");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PointCaptured;
    /// <summary>
    /// Function: PointCaptured
    /// </summary>
    public unsafe virtual void PointCaptured(BmSDK.BmGame.GDGIBase.ETeamType CapturedTeam, bool bDrainTicket)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointCaptured, "BmGame.GDGIHeroTeamGame.PointCaptured");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CapturedTeam, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrainTicket, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKillAssistScoreAndXP, "BmGame.GDGIHeroTeamGame.GetKillAssistScoreAndXP");
        byte* paramsPtr = stackalloc byte[42];
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

    private static BmSDK.Function __fn_InitGameReplicationInfo;
    /// <summary>
    /// Function: InitGameReplicationInfo
    /// </summary>
    public unsafe override void InitGameReplicationInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitGameReplicationInfo, "BmGame.GDGIHeroTeamGame.InitGameReplicationInfo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScoreLimits;
    /// <summary>
    /// Function: SetScoreLimits
    /// </summary>
    public unsafe override void SetScoreLimits(BmSDK.BmGame.GDMatchSettings FromSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScoreLimits, "BmGame.GDGIHeroTeamGame.SetScoreLimits");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromSettings, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRobinAchievementKillCount;
    /// <summary>
    /// Function: ClearRobinAchievementKillCount
    /// </summary>
    public unsafe virtual void ClearRobinAchievementKillCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRobinAchievementKillCount, "BmGame.GDGIHeroTeamGame.ClearRobinAchievementKillCount");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearBatmanAchievementKillCounter;
    /// <summary>
    /// Function: ClearBatmanAchievementKillCounter
    /// </summary>
    public unsafe virtual void ClearBatmanAchievementKillCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearBatmanAchievementKillCounter, "BmGame.GDGIHeroTeamGame.ClearBatmanAchievementKillCounter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBaseScoreForHeroDamageType;
    /// <summary>
    /// Function: GetBaseScoreForHeroDamageType
    /// </summary>
    public unsafe virtual int GetBaseScoreForHeroDamageType(BmSDK.Class DamageType, out BmSDK.BmGame.GDGIBase.EHeroScoringTakedownType TakedownType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBaseScoreForHeroDamageType, "BmGame.GDGIHeroTeamGame.GetBaseScoreForHeroDamageType");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TakedownType);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TakedownType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TakedownType = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDGIBase.EHeroScoringTakedownType>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CheckHeroIntimidationScore;
    /// <summary>
    /// Function: CheckHeroIntimidationScore
    /// </summary>
    public unsafe virtual void CheckHeroIntimidationScore(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckHeroIntimidationScore, "BmGame.GDGIHeroTeamGame.CheckHeroIntimidationScore");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveKillScore, "BmGame.GDGIHeroTeamGame.GiveKillScore");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Killed;
    /// <summary>
    /// Function: Killed
    /// </summary>
    public unsafe override void Killed(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Killed, "BmGame.GDGIHeroTeamGame.Killed");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalculateIntimidationGain;
    /// <summary>
    /// Function: CalculateIntimidationGain
    /// </summary>
    public unsafe virtual int CalculateIntimidationGain(BmSDK.BmGame.RPlayerController Hero, BmSDK.BmGame.RPlayerController Thug, bool bDied, BmSDK.Class DamageType, out BmSDK.BmGame.GDGIBase.FSIntimidationEvent IntimidationEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateIntimidationGain, "BmGame.GDGIHeroTeamGame.CalculateIntimidationGain");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Hero, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thug, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDied, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntimidationEvent);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntimidationEvent, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IntimidationEvent = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDGIBase.FSIntimidationEvent>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 64);
    }

    private static BmSDK.Function __fn_CalculateIntimidationLoss;
    /// <summary>
    /// Function: CalculateIntimidationLoss
    /// </summary>
    public unsafe virtual int CalculateIntimidationLoss(BmSDK.BmGame.RPlayerController KilledHero)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateIntimidationLoss, "BmGame.GDGIHeroTeamGame.CalculateIntimidationLoss");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledHero, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AdjustIntimidationLoss;
    /// <summary>
    /// Function: AdjustIntimidationLoss
    /// </summary>
    public unsafe virtual int AdjustIntimidationLoss(int InitialLossAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustIntimidationLoss, "BmGame.GDGIHeroTeamGame.AdjustIntimidationLoss");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialLossAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetValidPlayerStarts;
    /// <summary>
    /// Function: GetValidPlayerStarts
    /// </summary>
    public unsafe override void GetValidPlayerStarts(BmSDK.BmGame.GDGIBase.ETeamType Team, BmSDK.BmGame.RPlayerController Player, out BmSDK.TArray<BmSDK.BmGame.GDPlayerStart> ValidStarts)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetValidPlayerStarts, "BmGame.GDGIHeroTeamGame.GetValidPlayerStarts");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ValidStarts = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDPlayerStart>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_GetRandomTeamIndex;
    /// <summary>
    /// Function: GetRandomTeamIndex
    /// </summary>
    public unsafe virtual int GetRandomTeamIndex(bool bIncludeHeroTeam = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandomTeamIndex, "BmGame.GDGIHeroTeamGame.GetRandomTeamIndex");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeHeroTeam, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestTeamIndex, "BmGame.GDGIHeroTeamGame.GetBestTeamIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_LoadTeams;
    /// <summary>
    /// Function: LoadTeams
    /// </summary>
    public unsafe override void LoadTeams()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadTeams, "BmGame.GDGIHeroTeamGame.LoadTeams");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SortByRoundsSinceHero;
    /// <summary>
    /// Function: SortByRoundsSinceHero
    /// </summary>
    public unsafe virtual int SortByRoundsSinceHero(BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember A, BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortByRoundsSinceHero, "BmGame.GDGIHeroTeamGame.SortByRoundsSinceHero");
        byte* paramsPtr = stackalloc byte[168];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 136);
    }

    private static BmSDK.Function __fn_IgnoreTeamForRemainderCheck;
    /// <summary>
    /// Function: IgnoreTeamForRemainderCheck
    /// </summary>
    public unsafe static int IgnoreTeamForRemainderCheck()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IgnoreTeamForRemainderCheck, "BmGame.GDGIHeroTeamGame.IgnoreTeamForRemainderCheck");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AssignHeroes;
    /// <summary>
    /// Function: AssignHeroes
    /// </summary>
    public unsafe static void AssignHeroes(out BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember> UnassignedPlayers, BmSDK.BmGame.GDLobbySystemSteam LobbySys)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignHeroes, "BmGame.GDGIHeroTeamGame.AssignHeroes");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbySys, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        UnassignedPlayers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DoTeamAssignmentStep;
    /// <summary>
    /// Function: DoTeamAssignmentStep
    /// </summary>
    public unsafe static void DoTeamAssignmentStep(BmSDK.BmGame.GDGITeamGame.ETeamAssignmentStep Step, BmSDK.BmGame.GDLobbySystemSteam LobbySys, out BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember> UnassignedPlayers)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoTeamAssignmentStep, "BmGame.GDGIHeroTeamGame.DoTeamAssignmentStep");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Step, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbySys, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        UnassignedPlayers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_CheckRequiredTeamSizes;
    /// <summary>
    /// Function: CheckRequiredTeamSizes
    /// </summary>
    public unsafe static void CheckRequiredTeamSizes()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckRequiredTeamSizes, "BmGame.GDGIHeroTeamGame.CheckRequiredTeamSizes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHeroTeamSize;
    /// <summary>
    /// Function: GetHeroTeamSize
    /// </summary>
    public unsafe static int GetHeroTeamSize()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeroTeamSize, "BmGame.GDGIHeroTeamGame.GetHeroTeamSize");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLobbyTeamIndices;
    /// <summary>
    /// Function: GetLobbyTeamIndices
    /// </summary>
    public unsafe static void GetLobbyTeamIndices(out int HeroTeamIndex, out int JokerTeamIndex, out int BaneTeamIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyTeamIndices, "BmGame.GDGIHeroTeamGame.GetLobbyTeamIndices");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestTeamIndexStatic, "BmGame.GDGIHeroTeamGame.GetBestTeamIndexStatic");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamPlayerCounts, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetLobbyDetails;
    /// <summary>
    /// Function: GetLobbyDetails
    /// </summary>
    public unsafe static void GetLobbyDetails(out int NumTeams, out int MaxPlayerCount, out int ThugTeamSize, out int HeroTeamSize)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyDetails, "BmGame.GDGIHeroTeamGame.GetLobbyDetails");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumTeams, "BmGame.GDGIHeroTeamGame.GetNumTeams");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitGame, "BmGame.GDGIHeroTeamGame.InitGame");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ErrorMessage = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// IntProperty: MaxPlayersHeroTeam
    /// </summary>
    public unsafe int MaxPlayersHeroTeam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceFirstPlayerToHeroTeam
    /// </summary>
    public unsafe bool bDebugForceFirstPlayerToHeroTeam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1748) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1748); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1748); }
    }

    /// <summary>
    /// BoolProperty: bSkipLotteryScreen
    /// </summary>
    public unsafe bool bSkipLotteryScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1748) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1748); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1748); }
    }

    /// <summary>
    /// IntProperty: MinPlayersForMultipleHeroes
    /// </summary>
    public unsafe int MinPlayersForMultipleHeroes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// IntProperty: MinPlayersForHeroLottery
    /// </summary>
    public unsafe int MinPlayersForHeroLottery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }

    /// <summary>
    /// FloatProperty: OptOutScreenTime
    /// </summary>
    public unsafe float OptOutScreenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// IntProperty: BatmanKillCountForAchievement
    /// </summary>
    public unsafe int BatmanKillCountForAchievement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// IntProperty: RobinKillCountForAchievement
    /// </summary>
    public unsafe int RobinKillCountForAchievement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }

    /// <summary>
    /// ObjectProperty: CurrentBatmanPRI
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerRI CurrentBatmanPRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerRI>(Ptr + 1772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1772); }
    }

    /// <summary>
    /// ObjectProperty: CurrentRobinPRI
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerRI CurrentRobinPRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerRI>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// ArrayProperty: JokerTeamMembers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerRI> JokerTeamMembers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerRI>>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// ArrayProperty: BaneTeamMembers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerRI> BaneTeamMembers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerRI>>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// IntProperty: NumNextRoundHeroes
    /// </summary>
    public unsafe int NumNextRoundHeroes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// StructProperty: BatmanAchievementTracker
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIHeroTeamGame.FSPredatorParagonAchievmentTracker BatmanAchievementTracker
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIHeroTeamGame.FSPredatorParagonAchievmentTracker>(Ptr + 1808);

    /// <summary>
    /// StructProperty: RobinAchievementTracker
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIHeroTeamGame.FSPredatorParagonAchievmentTracker RobinAchievementTracker
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIHeroTeamGame.FSPredatorParagonAchievmentTracker>(Ptr + 1832);

    /// <summary>
    /// DelegateProperty: __SortByRoundsSinceHero__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByRoundsSinceHero__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// Struct: FSPredatorParagonAchievmentTracker
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FSPredatorParagonAchievmentTracker
    {
        /// <summary>
        /// ArrayProperty: UniqueKnockedOutThugs
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> UniqueKnockedOutThugs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: UniqueMethods
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Class> UniqueMethods
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }
}
