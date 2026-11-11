#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDGIGangland<br/>
/// (size = 2028)
/// (flags = 10518582)
/// </summary>
public partial class GDGIGangland : BmSDK.BmGame.GDGIHeroTeamGame, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGIGangland", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGIGangland.
    /// </summary>
    public static GDGIGangland DefaultObject => (GDGIGangland)StaticClass().DefaultObject;

    internal GDGIGangland() { }

    /// <summary>
    /// Constructs a new GDGIGangland
    /// </summary>
    public GDGIGangland(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGIGangland(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGIGangland>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIGangland>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGIGangland>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIGangland>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIGangland>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIGangland>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGIGangland>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIGangland>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DrawDebugHUD;
    /// <summary>
    /// Function: DrawDebugHUD
    /// </summary>
    public unsafe override int DrawDebugHUD(BmSDK.SDEngine.SDWorldInfo SDWI, int X, int Y)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugHUD, "BmGame.GDGIGangland.DrawDebugHUD");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SDWI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SortTiebreakerAscending;
    /// <summary>
    /// Function: SortTiebreakerAscending
    /// </summary>
    public unsafe virtual int SortTiebreakerAscending(BmSDK.BmGame.GDGIGangland.FSTeamTiebreakerScore A, BmSDK.BmGame.GDGIGangland.FSTeamTiebreakerScore B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortTiebreakerAscending, "BmGame.GDGIGangland.SortTiebreakerAscending");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SortTiebreakerDescending;
    /// <summary>
    /// Function: SortTiebreakerDescending
    /// </summary>
    public unsafe virtual int SortTiebreakerDescending(BmSDK.BmGame.GDGIGangland.FSTeamTiebreakerScore A, BmSDK.BmGame.GDGIGangland.FSTeamTiebreakerScore B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortTiebreakerDescending, "BmGame.GDGIGangland.SortTiebreakerDescending");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_LogEndGameEventScores;
    /// <summary>
    /// Function: LogEndGameEventScores
    /// </summary>
    public unsafe override void LogEndGameEventScores(out BmSDK.BmGame.GDStatEndgameEvent EndgameEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogEndGameEventScores, "BmGame.GDGIGangland.LogEndGameEventScores");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out EndgameEvent);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndgameEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        EndgameEvent = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDStatEndgameEvent>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DoGameSpecificLogin;
    /// <summary>
    /// Function: DoGameSpecificLogin
    /// </summary>
    public unsafe override BmSDK.Engine.PlayerController DoGameSpecificLogin(BmSDK.FString Portal, BmSDK.FString Options, BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, out BmSDK.FString ErrorMessage, bool bSpectator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoGameSpecificLogin, "BmGame.GDGIGangland.DoGameSpecificLogin");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Portal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpectator, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ErrorMessage = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerController>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_PointCaptured;
    /// <summary>
    /// Function: PointCaptured
    /// </summary>
    public unsafe override void PointCaptured(BmSDK.BmGame.GDGIBase.ETeamType CapturedTeam, bool bDrainTicket)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointCaptured, "BmGame.GDGIGangland.PointCaptured");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CapturedTeam, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrainTicket, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterExitDoor;
    /// <summary>
    /// Function: RegisterExitDoor
    /// </summary>
    public unsafe virtual void RegisterExitDoor(BmSDK.BmGame.GDExitDoorObjectBase Door)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterExitDoor, "BmGame.GDGIGangland.RegisterExitDoor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Door, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindPlayerStart;
    /// <summary>
    /// Function: FindPlayerStart
    /// </summary>
    public unsafe override BmSDK.Engine.NavigationPoint FindPlayerStart(BmSDK.Engine.Controller Player, byte InTeam = default, BmSDK.FString IncomingName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPlayerStart, "BmGame.GDGIGangland.FindPlayerStart");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTeam, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncomingName, paramsPtr + 8);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.NavigationPoint>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_RemovePawnOnRestartPlayer;
    /// <summary>
    /// Function: RemovePawnOnRestartPlayer
    /// </summary>
    public unsafe virtual bool RemovePawnOnRestartPlayer(BmSDK.BmGame.RPlayerController RestartingPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePawnOnRestartPlayer, "BmGame.GDGIGangland.RemovePawnOnRestartPlayer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RestartingPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TeamReachedHighScoreWarning;
    /// <summary>
    /// Function: TeamReachedHighScoreWarning
    /// </summary>
    public unsafe override void TeamReachedHighScoreWarning(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeamReachedHighScoreWarning, "BmGame.GDGIGangland.TeamReachedHighScoreWarning");
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
    public unsafe override void TeamReachedScoreWarning(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeamReachedScoreWarning, "BmGame.GDGIGangland.TeamReachedScoreWarning");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasReachedHighScoreWarningTimer;
    /// <summary>
    /// Function: HasReachedHighScoreWarningTimer
    /// </summary>
    public unsafe virtual void HasReachedHighScoreWarningTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasReachedHighScoreWarningTimer, "BmGame.GDGIGangland.HasReachedHighScoreWarningTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasReachedHighScoreWarning;
    /// <summary>
    /// Function: HasReachedHighScoreWarning
    /// </summary>
    public unsafe override bool HasReachedHighScoreWarning(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasReachedHighScoreWarning, "BmGame.GDGIGangland.HasReachedHighScoreWarning");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Killed;
    /// <summary>
    /// Function: Killed
    /// </summary>
    public unsafe override void Killed(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Killed, "BmGame.GDGIGangland.Killed");
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerKillBarks;
    /// <summary>
    /// Function: TriggerKillBarks
    /// </summary>
    public unsafe override void TriggerKillBarks(BmSDK.Engine.Pawn KillerPawn, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerKillBarks, "BmGame.GDGIGangland.TriggerKillBarks");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateSupervillainSpawn;
    /// <summary>
    /// Function: ActivateSupervillainSpawn
    /// </summary>
    public unsafe virtual void ActivateSupervillainSpawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateSupervillainSpawn, "BmGame.GDGIGangland.ActivateSupervillainSpawn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSupervillainSpawnProcess;
    /// <summary>
    /// Function: TriggerSupervillainSpawnProcess
    /// </summary>
    public unsafe virtual void TriggerSupervillainSpawnProcess(bool bFromTicketRatio, BmSDK.BmGame.GDExitDoorObjectBase ForcedDoor = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSupervillainSpawnProcess, "BmGame.GDGIGangland.TriggerSupervillainSpawnProcess");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFromTicketRatio, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForcedDoor, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSupervillainNotificationDelayForTeam;
    /// <summary>
    /// Function: GetSupervillainNotificationDelayForTeam
    /// </summary>
    public unsafe virtual float GetSupervillainNotificationDelayForTeam(BmSDK.BmGame.GDGIBase.ETeamType Team, bool bFromTicketRatio)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSupervillainNotificationDelayForTeam, "BmGame.GDGIGangland.GetSupervillainNotificationDelayForTeam");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFromTicketRatio, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TriggerSupervillainFromIntimidation;
    /// <summary>
    /// Function: TriggerSupervillainFromIntimidation
    /// </summary>
    public unsafe virtual bool TriggerSupervillainFromIntimidation(BmSDK.BmGame.GDGameReplicationInfo_Gangland GRI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSupervillainFromIntimidation, "BmGame.GDGIGangland.TriggerSupervillainFromIntimidation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GRI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TriggerSupervillainFromTicketCount;
    /// <summary>
    /// Function: TriggerSupervillainFromTicketCount
    /// </summary>
    public unsafe virtual bool TriggerSupervillainFromTicketCount(BmSDK.BmGame.GDGameReplicationInfo_Gangland GRI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSupervillainFromTicketCount, "BmGame.GDGIGangland.TriggerSupervillainFromTicketCount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GRI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckTeamScores;
    /// <summary>
    /// Function: CheckTeamScores
    /// </summary>
    public unsafe override bool CheckTeamScores()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckTeamScores, "BmGame.GDGIGangland.CheckTeamScores");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GiveWinXP;
    /// <summary>
    /// Function: GiveWinXP
    /// </summary>
    public unsafe virtual void GiveWinXP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveWinXP, "BmGame.GDGIGangland.GiveWinXP");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndGameTeam;
    /// <summary>
    /// Function: EndGameTeam
    /// </summary>
    public unsafe override void EndGameTeam(BmSDK.BmGame.GDTeamInfo Winner, BmSDK.FString Reason)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndGameTeam, "BmGame.GDGIGangland.EndGameTeam");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckTicketCounts;
    /// <summary>
    /// Function: CheckTicketCounts
    /// </summary>
    public unsafe virtual void CheckTicketCounts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckTicketCounts, "BmGame.GDGIGangland.CheckTicketCounts");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckLastManStanding;
    /// <summary>
    /// Function: CheckLastManStanding
    /// </summary>
    public unsafe virtual void CheckLastManStanding()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckLastManStanding, "BmGame.GDGIGangland.CheckLastManStanding");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateScore;
    /// <summary>
    /// Function: UpdateScore
    /// </summary>
    public unsafe override void UpdateScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateScore, "BmGame.GDGIGangland.UpdateScore");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckMatchSettingsClass;
    /// <summary>
    /// Function: CheckMatchSettingsClass
    /// </summary>
    public unsafe override bool CheckMatchSettingsClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckMatchSettingsClass, "BmGame.GDGIGangland.CheckMatchSettingsClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanRespawnPlayer;
    /// <summary>
    /// Function: CanRespawnPlayer
    /// </summary>
    public unsafe override bool CanRespawnPlayer(BmSDK.Engine.Controller RespawnMe)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRespawnPlayer, "BmGame.GDGIGangland.CanRespawnPlayer");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RespawnMe, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GiveKillScore;
    /// <summary>
    /// Function: GiveKillScore
    /// </summary>
    public unsafe override void GiveKillScore(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveKillScore, "BmGame.GDGIGangland.GiveKillScore");
        byte* paramsPtr = stackalloc byte[34];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnZeroTickets;
    /// <summary>
    /// Function: OnZeroTickets
    /// </summary>
    public unsafe virtual void OnZeroTickets(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnZeroTickets, "BmGame.GDGIGangland.OnZeroTickets");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SortByRespawnTime;
    /// <summary>
    /// Function: SortByRespawnTime
    /// </summary>
    public unsafe virtual int SortByRespawnTime(BmSDK.BmGame.RPlayerController A, BmSDK.BmGame.RPlayerController B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortByRespawnTime, "BmGame.GDGIGangland.SortByRespawnTime");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FakeHeroRespawnKill;
    /// <summary>
    /// Function: FakeHeroRespawnKill
    /// </summary>
    public unsafe virtual void FakeHeroRespawnKill()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeHeroRespawnKill, "BmGame.GDGIGangland.FakeHeroRespawnKill");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckHeroKill;
    /// <summary>
    /// Function: CheckHeroKill
    /// </summary>
    public unsafe virtual void CheckHeroKill(BmSDK.BmGame.RPlayerController Killer, BmSDK.BmGame.GDGIBase.ETeamType KillingTeam, BmSDK.BmGame.RPlayerController DeadHero)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckHeroKill, "BmGame.GDGIGangland.CheckHeroKill");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillingTeam, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadHero, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalculateIntimidationLoss;
    /// <summary>
    /// Function: CalculateIntimidationLoss
    /// </summary>
    public unsafe override int CalculateIntimidationLoss(BmSDK.BmGame.RPlayerController KilledHero)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateIntimidationLoss, "BmGame.GDGIGangland.CalculateIntimidationLoss");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledHero, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RegisterObjectiveMatinee;
    /// <summary>
    /// Function: RegisterObjectiveMatinee
    /// </summary>
    public unsafe override void RegisterObjectiveMatinee(BmSDK.BmGame.GDSeqAct_ObjectiveInterp ObjectiveMatinee, BmSDK.BmGame.GDObjective NewObjective)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterObjectiveMatinee, "BmGame.GDGIGangland.RegisterObjectiveMatinee");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectiveMatinee, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewObjective, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitGameReplicationInfo;
    /// <summary>
    /// Function: InitGameReplicationInfo
    /// </summary>
    public unsafe override void InitGameReplicationInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitGameReplicationInfo, "BmGame.GDGIGangland.InitGameReplicationInfo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bSent30SecondWarning
    /// </summary>
    public unsafe bool bSent30SecondWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1868) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1868); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1868); }
    }

    /// <summary>
    /// BoolProperty: bSent10SecondWarning
    /// </summary>
    public unsafe bool bSent10SecondWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1868) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1868); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1868); }
    }

    /// <summary>
    /// BoolProperty: bSent3SecondWarning
    /// </summary>
    public unsafe bool bSent3SecondWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1868) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1868); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1868); }
    }

    /// <summary>
    /// BoolProperty: bSent2SecondWarning
    /// </summary>
    public unsafe bool bSent2SecondWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1868) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1868); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1868); }
    }

    /// <summary>
    /// BoolProperty: bSent1SecondWarning
    /// </summary>
    public unsafe bool bSent1SecondWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1868) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1868); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1868); }
    }

    /// <summary>
    /// BoolProperty: bDoneSupervillainSpawn
    /// </summary>
    public unsafe bool bDoneSupervillainSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1868) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1868); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1868); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventThugCommanderOnKillHeroNoReinforcements
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventThugCommanderOnKillHeroNoReinforcements
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventThugCommanderOnKillHeroReinforcements
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventThugCommanderOnKillHeroReinforcements
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnEscapeTime
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnEscapeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// NameProperty: BarkEventCommanderOnEscapeTimeArgument30
    /// </summary>
    public unsafe BmSDK.FName BarkEventCommanderOnEscapeTimeArgument30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// NameProperty: BarkEventCommanderOnEscapeTimeArgument10
    /// </summary>
    public unsafe BmSDK.FName BarkEventCommanderOnEscapeTimeArgument10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }

    /// <summary>
    /// ObjectProperty: GanglandMatchSettings
    /// </summary>
    public unsafe BmSDK.BmGame.GDGanglandMatchSettings GanglandMatchSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGanglandMatchSettings>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// ArrayProperty: ExitDoors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDExitDoorObjectBase> ExitDoors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDExitDoorObjectBase>>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }

    /// <summary>
    /// ObjectProperty: InUseSupervillainSpawnDoor
    /// </summary>
    public unsafe BmSDK.BmGame.GDExitDoorObjectBase InUseSupervillainSpawnDoor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDExitDoorObjectBase>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// ByteProperty: WinningTeamAtSupervillainSpawn
    /// </summary>
    public unsafe BmSDK.BmGame.GDGIBase.ETeamType WinningTeamAtSupervillainSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGIBase.ETeamType>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: SupervillainNotificationDelay
    /// </summary>
    public InlineArray<float> SupervillainNotificationDelay => new(5, Ptr + 1924, 4, this);

    /// <summary>
    /// FloatProperty: SupervillainNotificationDelay
    /// </summary>
    public unsafe float SupervillainNotificationDelay_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }
    /// <summary>
    /// FloatProperty: SupervillainNotificationDelay
    /// </summary>
    public unsafe float SupervillainNotificationDelay_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }
    /// <summary>
    /// FloatProperty: SupervillainNotificationDelay
    /// </summary>
    public unsafe float SupervillainNotificationDelay_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }
    /// <summary>
    /// FloatProperty: SupervillainNotificationDelay
    /// </summary>
    public unsafe float SupervillainNotificationDelay_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }
    /// <summary>
    /// FloatProperty: SupervillainNotificationDelay
    /// </summary>
    public unsafe float SupervillainNotificationDelay_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// FloatProperty: IntimidationRatioForSupervillainTrigger
    /// </summary>
    public unsafe float IntimidationRatioForSupervillainTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// FloatProperty: TicketRatioForSupervillainTrigger
    /// </summary>
    public unsafe float TicketRatioForSupervillainTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: FirstKillTime
    /// </summary>
    public InlineArray<float> FirstKillTime => new(5, Ptr + 1952, 4, this);

    /// <summary>
    /// FloatProperty: FirstKillTime
    /// </summary>
    public unsafe float FirstKillTime_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }
    /// <summary>
    /// FloatProperty: FirstKillTime
    /// </summary>
    public unsafe float FirstKillTime_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }
    /// <summary>
    /// FloatProperty: FirstKillTime
    /// </summary>
    public unsafe float FirstKillTime_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }
    /// <summary>
    /// FloatProperty: FirstKillTime
    /// </summary>
    public unsafe float FirstKillTime_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }
    /// <summary>
    /// FloatProperty: FirstKillTime
    /// </summary>
    public unsafe float FirstKillTime_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: TeamKills
    /// </summary>
    public InlineArray<int> TeamKills => new(5, Ptr + 1972, 4, this);

    /// <summary>
    /// IntProperty: TeamKills
    /// </summary>
    public unsafe int TeamKills_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }
    /// <summary>
    /// IntProperty: TeamKills
    /// </summary>
    public unsafe int TeamKills_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }
    /// <summary>
    /// IntProperty: TeamKills
    /// </summary>
    public unsafe int TeamKills_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }
    /// <summary>
    /// IntProperty: TeamKills
    /// </summary>
    public unsafe int TeamKills_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }
    }
    /// <summary>
    /// IntProperty: TeamKills
    /// </summary>
    public unsafe int TeamKills_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// DelegateProperty: __SortByRespawnTime__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByRespawnTime__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }

    /// <summary>
    /// DelegateProperty: __SortTiebreakerDescending__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortTiebreakerDescending__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2004); }
    }

    /// <summary>
    /// DelegateProperty: __SortTiebreakerAscending__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortTiebreakerAscending__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }
    }

    /// <summary>
    /// Struct: FSTeamTiebreakerScore
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FSTeamTiebreakerScore
    {
        /// <summary>
        /// ByteProperty: Team
        /// </summary>
        public unsafe BmSDK.BmGame.GDGIBase.ETeamType Team
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGIBase.ETeamType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Score
        /// </summary>
        public unsafe float Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
