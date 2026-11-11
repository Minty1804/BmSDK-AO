#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: GDGIBase<br/>
/// (size = 1660)
/// (flags = 144736439)
/// </summary>
public partial class GDGIBase : BmSDK.BmGame.RGameInfo, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGIBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGIBase.
    /// </summary>
    public static GDGIBase DefaultObject => (GDGIBase)StaticClass().DefaultObject;

    internal GDGIBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGIBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGIBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGIBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGIBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGIBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_WriteOnlinePlayerScores;
    /// <summary>
    /// Function: WriteOnlinePlayerScores
    /// </summary>
    public unsafe override void WriteOnlinePlayerScores()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteOnlinePlayerScores, "BmGame.GDGIBase.WriteOnlinePlayerScores");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawDebugHUD;
    /// <summary>
    /// Function: DrawDebugHUD
    /// </summary>
    public unsafe virtual int DrawDebugHUD(BmSDK.SDEngine.SDWorldInfo SDWI, int X, int Y)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugHUD, "BmGame.GDGIBase.DrawDebugHUD");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SDWI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DebugCallback;
    /// <summary>
    /// Function: DebugCallback
    /// </summary>
    public unsafe virtual bool DebugCallback(BmSDK.FString CmdText)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCallback, "BmGame.GDGIBase.DebugCallback");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CmdText, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_UnregisterStatTracker;
    /// <summary>
    /// Function: UnregisterStatTracker
    /// </summary>
    public unsafe virtual void UnregisterStatTracker(BmSDK.BmGame.GDTickableStatTracker Tracker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterStatTracker, "BmGame.GDGIBase.UnregisterStatTracker");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tracker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterStatTracker;
    /// <summary>
    /// Function: RegisterStatTracker
    /// </summary>
    public unsafe virtual void RegisterStatTracker(BmSDK.BmGame.GDTickableStatTracker Tracker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterStatTracker, "BmGame.GDGIBase.RegisterStatTracker");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tracker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartReturnToLobbyTimer;
    /// <summary>
    /// Function: StartReturnToLobbyTimer
    /// </summary>
    public unsafe virtual void StartReturnToLobbyTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartReturnToLobbyTimer, "BmGame.GDGIBase.StartReturnToLobbyTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReturnToLobby;
    /// <summary>
    /// Function: ReturnToLobby
    /// </summary>
    public unsafe virtual void ReturnToLobby()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReturnToLobby, "BmGame.GDGIBase.ReturnToLobby");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GenerateFireteamStatObjectClasses;
    /// <summary>
    /// Function: GenerateFireteamStatObjectClasses
    /// </summary>
    public unsafe virtual void GenerateFireteamStatObjectClasses()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateFireteamStatObjectClasses, "BmGame.GDGIBase.GenerateFireteamStatObjectClasses");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpSDMemLogStartMatch;
    /// <summary>
    /// Function: DumpSDMemLogStartMatch
    /// </summary>
    public unsafe virtual void DumpSDMemLogStartMatch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpSDMemLogStartMatch, "BmGame.GDGIBase.DumpSDMemLogStartMatch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CurrentGrenadePickupUsed;
    /// <summary>
    /// Function: CurrentGrenadePickupUsed
    /// </summary>
    public unsafe virtual void CurrentGrenadePickupUsed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CurrentGrenadePickupUsed, "BmGame.GDGIBase.CurrentGrenadePickupUsed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowHeroesNextGrenadeLocation;
    /// <summary>
    /// Function: ShowHeroesNextGrenadeLocation
    /// </summary>
    public unsafe void ShowHeroesNextGrenadeLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowHeroesNextGrenadeLocation, "BmGame.GDGIBase.ShowHeroesNextGrenadeLocation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableGrenadePickup;
    /// <summary>
    /// Function: EnableGrenadePickup
    /// </summary>
    public unsafe void EnableGrenadePickup()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableGrenadePickup, "BmGame.GDGIBase.EnableGrenadePickup");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChooseNextGrenadePickupLocation;
    /// <summary>
    /// Function: ChooseNextGrenadePickupLocation
    /// </summary>
    public unsafe bool ChooseNextGrenadePickupLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChooseNextGrenadePickupLocation, "BmGame.GDGIBase.ChooseNextGrenadePickupLocation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoGrenadePickupSpawning;
    /// <summary>
    /// Function: CanDoGrenadePickupSpawning
    /// </summary>
    public unsafe bool CanDoGrenadePickupSpawning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoGrenadePickupSpawning, "BmGame.GDGIBase.CanDoGrenadePickupSpawning");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RateSpawnPoints;
    /// <summary>
    /// Function: RateSpawnPoints
    /// </summary>
    public unsafe virtual void RateSpawnPoints()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RateSpawnPoints, "BmGame.GDGIBase.RateSpawnPoints");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableDebugSpawning;
    /// <summary>
    /// Function: EnableDebugSpawning
    /// </summary>
    public unsafe virtual void EnableDebugSpawning(bool bEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableDebugSpawning, "BmGame.GDGIBase.EnableDebugSpawning");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMapVersion;
    /// <summary>
    /// Function: GetMapVersion
    /// </summary>
    public unsafe override BmSDK.FString GetMapVersion()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMapVersion, "BmGame.GDGIBase.GetMapVersion");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GoStartMatch;
    /// <summary>
    /// Function: GoStartMatch
    /// </summary>
    public unsafe override void GoStartMatch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoStartMatch, "BmGame.GDGIBase.GoStartMatch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetPlayForever;
    /// <summary>
    /// Function: ResetPlayForever
    /// </summary>
    public unsafe virtual void ResetPlayForever()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPlayForever, "BmGame.GDGIBase.ResetPlayForever");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayForever;
    /// <summary>
    /// Function: PlayForever
    /// </summary>
    public unsafe virtual void PlayForever()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayForever, "BmGame.GDGIBase.PlayForever");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetScoreLimit;
    /// <summary>
    /// Function: ResetScoreLimit
    /// </summary>
    public unsafe virtual void ResetScoreLimit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetScoreLimit, "BmGame.GDGIBase.ResetScoreLimit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetTimeLimit;
    /// <summary>
    /// Function: ResetTimeLimit
    /// </summary>
    public unsafe virtual void ResetTimeLimit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetTimeLimit, "BmGame.GDGIBase.ResetTimeLimit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTimeRemaining;
    /// <summary>
    /// Function: SetTimeRemaining
    /// </summary>
    public unsafe virtual void SetTimeRemaining(int Seconds = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTimeRemaining, "BmGame.GDGIBase.SetTimeRemaining");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seconds, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChoosePlayerStart;
    /// <summary>
    /// Function: ChoosePlayerStart
    /// </summary>
    public unsafe override BmSDK.Engine.PlayerStart ChoosePlayerStart(BmSDK.Engine.Controller Player, byte InTeam = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChoosePlayerStart, "BmGame.GDGIBase.ChoosePlayerStart");
        byte* paramsPtr = stackalloc byte[45];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTeam, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerStart>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShouldSpawnAtStartSpot;
    /// <summary>
    /// Function: ShouldSpawnAtStartSpot
    /// </summary>
    public unsafe override bool ShouldSpawnAtStartSpot(BmSDK.Engine.Controller Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSpawnAtStartSpot, "BmGame.GDGIBase.ShouldSpawnAtStartSpot");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TurnOffObjectives;
    /// <summary>
    /// Function: TurnOffObjectives
    /// </summary>
    public unsafe virtual void TurnOffObjectives()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffObjectives, "BmGame.GDGIBase.TurnOffObjectives");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PutPlayersIntoEndGameState;
    /// <summary>
    /// Function: PutPlayersIntoEndGameState
    /// </summary>
    public unsafe virtual void PutPlayersIntoEndGameState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PutPlayersIntoEndGameState, "BmGame.GDGIBase.PutPlayersIntoEndGameState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AdjustPlayerScore;
    /// <summary>
    /// Function: AdjustPlayerScore
    /// </summary>
    public unsafe virtual void AdjustPlayerScore(BmSDK.Engine.Controller Player, int Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustPlayerScore, "BmGame.GDGIBase.AdjustPlayerScore");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelPlayerRespawn;
    /// <summary>
    /// Function: CancelPlayerRespawn
    /// </summary>
    public unsafe virtual void CancelPlayerRespawn(BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelPlayerRespawn, "BmGame.GDGIBase.CancelPlayerRespawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnquePlayerRespawn;
    /// <summary>
    /// Function: EnquePlayerRespawn
    /// </summary>
    public unsafe virtual void EnquePlayerRespawn(BmSDK.BmGame.RPlayerController RPC, float RespawnDelay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnquePlayerRespawn, "BmGame.GDGIBase.EnquePlayerRespawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RespawnDelay, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BroadcastCommanderTimeLeft;
    /// <summary>
    /// Function: BroadcastCommanderTimeLeft
    /// </summary>
    public unsafe virtual void BroadcastCommanderTimeLeft(int TimeLeft)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BroadcastCommanderTimeLeft, "BmGame.GDGIBase.BroadcastCommanderTimeLeft");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeLeft, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearCaptains;
    /// <summary>
    /// Function: ClearCaptains
    /// </summary>
    public unsafe virtual void ClearCaptains()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCaptains, "BmGame.GDGIBase.ClearCaptains");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThereAreLivingCaptains;
    /// <summary>
    /// Function: ThereAreLivingCaptains
    /// </summary>
    public unsafe virtual bool ThereAreLivingCaptains()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThereAreLivingCaptains, "BmGame.GDGIBase.ThereAreLivingCaptains");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SortByMatchXP;
    /// <summary>
    /// Function: SortByMatchXP
    /// </summary>
    public unsafe virtual int SortByMatchXP(BmSDK.Engine.PlayerReplicationInfo A, BmSDK.Engine.PlayerReplicationInfo B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortByMatchXP, "BmGame.GDGIBase.SortByMatchXP");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AssignCaptains;
    /// <summary>
    /// Function: AssignCaptains
    /// </summary>
    public unsafe virtual void AssignCaptains()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignCaptains, "BmGame.GDGIBase.AssignCaptains");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanRespawnPlayer;
    /// <summary>
    /// Function: CanRespawnPlayer
    /// </summary>
    public unsafe virtual bool CanRespawnPlayer(BmSDK.Engine.Controller RespawnMe)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRespawnPlayer, "BmGame.GDGIBase.CanRespawnPlayer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RespawnMe, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RegisterObjectiveMatinee;
    /// <summary>
    /// Function: RegisterObjectiveMatinee
    /// </summary>
    public unsafe virtual void RegisterObjectiveMatinee(BmSDK.BmGame.GDSeqAct_ObjectiveInterp ObjectiveMatinee, BmSDK.BmGame.GDObjective Objective)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterObjectiveMatinee, "BmGame.GDGIBase.RegisterObjectiveMatinee");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectiveMatinee, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Objective, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTimeLimit;
    /// <summary>
    /// Function: SetTimeLimit
    /// </summary>
    public unsafe virtual void SetTimeLimit(int Seconds = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTimeLimit, "BmGame.GDGIBase.SetTimeLimit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seconds, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadTeams;
    /// <summary>
    /// Function: LoadTeams
    /// </summary>
    public unsafe virtual void LoadTeams()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadTeams, "BmGame.GDGIBase.LoadTeams");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AtCapacityWithThreshold;
    /// <summary>
    /// Function: AtCapacityWithThreshold
    /// </summary>
    public unsafe virtual bool AtCapacityWithThreshold(bool bSpectator, int MaxMissingPlayers)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AtCapacityWithThreshold, "BmGame.GDGIBase.AtCapacityWithThreshold");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpectator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxMissingPlayers, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AtCapacity;
    /// <summary>
    /// Function: AtCapacity
    /// </summary>
    public unsafe override bool AtCapacity(bool bSpectator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AtCapacity, "BmGame.GDGIBase.AtCapacity");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpectator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_InitialiseFromMapInfo;
    /// <summary>
    /// Function: InitialiseFromMapInfo
    /// </summary>
    public unsafe virtual void InitialiseFromMapInfo(BmSDK.FString Options)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseFromMapInfo, "BmGame.GDGIBase.InitialiseFromMapInfo");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialiseFromMatchSettings;
    /// <summary>
    /// Function: InitialiseFromMatchSettings
    /// </summary>
    public unsafe virtual void InitialiseFromMatchSettings(BmSDK.FString Options, out BmSDK.FString ErrorMessage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseFromMatchSettings, "BmGame.GDGIBase.InitialiseFromMatchSettings");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ErrorMessage = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_CheckMatchSettingsClass;
    /// <summary>
    /// Function: CheckMatchSettingsClass
    /// </summary>
    public unsafe virtual bool CheckMatchSettingsClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckMatchSettingsClass, "BmGame.GDGIBase.CheckMatchSettingsClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartHumans;
    /// <summary>
    /// Function: StartHumans
    /// </summary>
    public unsafe override void StartHumans()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartHumans, "BmGame.GDGIBase.StartHumans");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSpectating;
    /// <summary>
    /// Function: SetSpectating
    /// </summary>
    public unsafe virtual void SetSpectating(BmSDK.Engine.Controller C, bool Spectating)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSpectating, "BmGame.GDGIBase.SetSpectating");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spectating, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartMatchGameOn;
    /// <summary>
    /// Function: StartMatchGameOn
    /// </summary>
    public unsafe virtual void StartMatchGameOn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartMatchGameOn, "BmGame.GDGIBase.StartMatchGameOn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SynchronizeGameTimeWithClients;
    /// <summary>
    /// Function: SynchronizeGameTimeWithClients
    /// </summary>
    public unsafe virtual void SynchronizeGameTimeWithClients()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SynchronizeGameTimeWithClients, "BmGame.GDGIBase.SynchronizeGameTimeWithClients");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGameState;
    /// <summary>
    /// Function: GetGameState
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDGIBase.EGameState GetGameState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameState, "BmGame.GDGIBase.GetGameState");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDGIBase.EGameState>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerKillBarks;
    /// <summary>
    /// Function: TriggerKillBarks
    /// </summary>
    public unsafe virtual void TriggerKillBarks(BmSDK.Engine.Pawn KillerPawn, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerKillBarks, "BmGame.GDGIBase.TriggerKillBarks");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableCaptains;
    /// <summary>
    /// Function: EnableCaptains
    /// </summary>
    public unsafe virtual void EnableCaptains(bool bEnable)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableCaptains, "BmGame.GDGIBase.EnableCaptains");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCaptainKilled;
    /// <summary>
    /// Function: OnCaptainKilled
    /// </summary>
    public unsafe virtual void OnCaptainKilled(BmSDK.Engine.Controller KilledPlayer, BmSDK.Engine.Controller Killer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCaptainKilled, "BmGame.GDGIBase.OnCaptainKilled");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Killed, "BmGame.GDGIBase.Killed");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveMidTakedownKillXp;
    /// <summary>
    /// Function: GiveMidTakedownKillXp
    /// </summary>
    public unsafe virtual void GiveMidTakedownKillXp(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveMidTakedownKillXp, "BmGame.GDGIBase.GiveMidTakedownKillXp");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveObjectiveKillXp;
    /// <summary>
    /// Function: GiveObjectiveKillXp
    /// </summary>
    public unsafe virtual void GiveObjectiveKillXp(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveObjectiveKillXp, "BmGame.GDGIBase.GiveObjectiveKillXp");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckMidGlideKillXp;
    /// <summary>
    /// Function: CheckMidGlideKillXp
    /// </summary>
    public unsafe virtual void CheckMidGlideKillXp(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller Killed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckMidGlideKillXp, "BmGame.GDGIBase.CheckMidGlideKillXp");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckFirstBloodXp;
    /// <summary>
    /// Function: CheckFirstBloodXp
    /// </summary>
    public unsafe virtual void CheckFirstBloodXp(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller Killed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckFirstBloodXp, "BmGame.GDGIBase.CheckFirstBloodXp");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckKillstreak;
    /// <summary>
    /// Function: CheckKillstreak
    /// </summary>
    public unsafe virtual void CheckKillstreak(BmSDK.BmGame.RPlayerController Killer, BmSDK.Engine.Controller Killed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckKillstreak, "BmGame.GDGIBase.CheckKillstreak");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveAssistScore;
    /// <summary>
    /// Function: GiveAssistScore
    /// </summary>
    public unsafe virtual void GiveAssistScore(BmSDK.BmGame.RPlayerController Player, int Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveAssistScore, "BmGame.GDGIBase.GiveAssistScore");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogAssistStat;
    /// <summary>
    /// Function: LogAssistStat
    /// </summary>
    public unsafe virtual void LogAssistStat(BmSDK.Class AssistingDmgType, BmSDK.BmGame.RPlayerRI AssistingPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogAssistStat, "BmGame.GDGIBase.LogAssistStat");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AssistingDmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AssistingPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveKillAssists;
    /// <summary>
    /// Function: GiveKillAssists
    /// </summary>
    public unsafe virtual void GiveKillAssists(BmSDK.TArray<BmSDK.BmGame.RPlayerRI> AssistingPlayers, BmSDK.BmGame.RPlayerController KilledRPC, BmSDK.Class RDamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveKillAssists, "BmGame.GDGIBase.GiveKillAssists");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AssistingPlayers, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledRPC, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RDamageType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepareKillAssists;
    /// <summary>
    /// Function: PrepareKillAssists
    /// </summary>
    public unsafe virtual void PrepareKillAssists(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer, BmSDK.Class RDamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepareKillAssists, "BmGame.GDGIBase.PrepareKillAssists");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RDamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CountdownTimer;
    /// <summary>
    /// Function: CountdownTimer
    /// </summary>
    public unsafe virtual void CountdownTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CountdownTimer, "BmGame.GDGIBase.CountdownTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActualEndGame;
    /// <summary>
    /// Function: ActualEndGame
    /// </summary>
    public unsafe virtual void ActualEndGame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActualEndGame, "BmGame.GDGIBase.ActualEndGame");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEndGameStateTransitionTimes;
    /// <summary>
    /// Function: SetEndGameStateTransitionTimes
    /// </summary>
    public unsafe virtual void SetEndGameStateTransitionTimes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEndGameStateTransitionTimes, "BmGame.GDGIBase.SetEndGameStateTransitionTimes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndGame, "BmGame.GDGIBase.EndGame");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGameOver, "BmGame.GDGIBase.IsGameOver");
        byte* paramsPtr = stackalloc byte[20];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitGameReplicationInfo, "BmGame.GDGIBase.InitGameReplicationInfo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Reset;
    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe override void Reset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reset, "BmGame.GDGIBase.Reset");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Login;
    /// <summary>
    /// Function: Login
    /// </summary>
    public unsafe override BmSDK.Engine.PlayerController Login(BmSDK.FString Portal, BmSDK.FString Options, BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, out BmSDK.FString ErrorMessage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Login, "BmGame.GDGIBase.Login");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Portal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ErrorMessage = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerController>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_GetLobbyTeamIndex;
    /// <summary>
    /// Function: GetLobbyTeamIndex
    /// </summary>
    public unsafe virtual int GetLobbyTeamIndex(BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyTeamIndex, "BmGame.GDGIBase.GetLobbyTeamIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetLocalLobbySystem;
    /// <summary>
    /// Function: GetLocalLobbySystem
    /// </summary>
    public unsafe static BmSDK.SDEngine.SDLobbySystem GetLocalLobbySystem()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalLobbySystem, "BmGame.GDGIBase.GetLocalLobbySystem");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.SDEngine.SDLobbySystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ProcessServerTravel;
    /// <summary>
    /// Function: ProcessServerTravel
    /// </summary>
    public unsafe override void ProcessServerTravel(BmSDK.FString URL, bool bAbsolute = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessServerTravel, "BmGame.GDGIBase.ProcessServerTravel");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAbsolute, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRespawnTime;
    /// <summary>
    /// Function: GetRespawnTime
    /// </summary>
    public unsafe virtual float GetRespawnTime(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRespawnTime, "BmGame.GDGIBase.GetRespawnTime");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetRespawnTimeMod;
    /// <summary>
    /// Function: GetRespawnTimeMod
    /// </summary>
    public unsafe virtual float GetRespawnTimeMod(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRespawnTimeMod, "BmGame.GDGIBase.GetRespawnTimeMod");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateScore;
    /// <summary>
    /// Function: UpdateScore
    /// </summary>
    public unsafe virtual void UpdateScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateScore, "BmGame.GDGIBase.UpdateScore");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerCanRestart;
    /// <summary>
    /// Function: PlayerCanRestart
    /// </summary>
    public unsafe override bool PlayerCanRestart(BmSDK.Engine.PlayerController aPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerCanRestart, "BmGame.GDGIBase.PlayerCanRestart");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ProcessClientTravel;
    /// <summary>
    /// Function: ProcessClientTravel
    /// </summary>
    public unsafe override BmSDK.Engine.PlayerController ProcessClientTravel(out BmSDK.FString URL, BmSDK.GameObject.FGuid NextMapGuid, bool bSeamless, bool bAbsolute)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessClientTravel, "BmGame.GDGIBase.ProcessClientTravel");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextMapGuid, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSeamless, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAbsolute, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        URL = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerController>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CheckControllerSwap;
    /// <summary>
    /// Function: CheckControllerSwap
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPlayerController CheckControllerSwap(BmSDK.Engine.Controller NewPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckControllerSwap, "BmGame.GDGIBase.CheckControllerSwap");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPlayerController>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RestartPlayer;
    /// <summary>
    /// Function: RestartPlayer
    /// </summary>
    public unsafe override void RestartPlayer(BmSDK.Engine.Controller NewPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestartPlayer, "BmGame.GDGIBase.RestartPlayer");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnPlayerController;
    /// <summary>
    /// Function: SpawnPlayerController
    /// </summary>
    public unsafe override BmSDK.Engine.PlayerController SpawnPlayerController(System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation, in BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerUniqueId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnPlayerController, "BmGame.GDGIBase.SpawnPlayerController");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerUniqueId, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerController>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_RoundToNearestIncrement;
    /// <summary>
    /// Function: RoundToNearestIncrement
    /// </summary>
    public unsafe virtual float RoundToNearestIncrement(float Time, float interval)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RoundToNearestIncrement, "BmGame.GDGIBase.RoundToNearestIncrement");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(interval, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetRegularTimerEvent;
    /// <summary>
    /// Function: SetRegularTimerEvent
    /// </summary>
    public unsafe virtual void SetRegularTimerEvent(float interval, BmSDK.FName FuncName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRegularTimerEvent, "BmGame.GDGIBase.SetRegularTimerEvent");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(interval, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FuncName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogStatsPlayerNetwork;
    /// <summary>
    /// Function: LogStatsPlayerNetwork
    /// </summary>
    public unsafe virtual void LogStatsPlayerNetwork()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogStatsPlayerNetwork, "BmGame.GDGIBase.LogStatsPlayerNetwork");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogStatsServer;
    /// <summary>
    /// Function: LogStatsServer
    /// </summary>
    public unsafe virtual void LogStatsServer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogStatsServer, "BmGame.GDGIBase.LogStatsServer");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogStatsPlayerMove;
    /// <summary>
    /// Function: LogStatsPlayerMove
    /// </summary>
    public unsafe virtual void LogStatsPlayerMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogStatsPlayerMove, "BmGame.GDGIBase.LogStatsPlayerMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsWinningPlayer;
    /// <summary>
    /// Function: IsWinningPlayer
    /// </summary>
    public unsafe virtual bool IsWinningPlayer(BmSDK.Engine.PlayerReplicationInfo PRI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWinningPlayer, "BmGame.GDGIBase.IsWinningPlayer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_LogStatsMapResults;
    /// <summary>
    /// Function: LogStatsMapResults
    /// </summary>
    public unsafe virtual void LogStatsMapResults()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogStatsMapResults, "BmGame.GDGIBase.LogStatsMapResults");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStatTypeForMap;
    /// <summary>
    /// Function: GetStatTypeForMap
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDMapStatisticsStore.EGDMapStatType GetStatTypeForMap(BmSDK.FString MapName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStatTypeForMap, "BmGame.GDGIBase.GetStatTypeForMap");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDMapStatisticsStore.EGDMapStatType>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_EndLogging;
    /// <summary>
    /// Function: EndLogging
    /// </summary>
    public unsafe override void EndLogging(BmSDK.FString Reason)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndLogging, "BmGame.GDGIBase.EndLogging");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLobbyTeamIndices;
    /// <summary>
    /// Function: GetLobbyTeamIndices
    /// </summary>
    public unsafe static void GetLobbyTeamIndices(out int HeroTeamIndex, out int JokerTeamIndex, out int BaneTeamIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyTeamIndices, "BmGame.GDGIBase.GetLobbyTeamIndices");
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

    private static BmSDK.Function __fn_ObservePreferredFaction;
    /// <summary>
    /// Function: ObservePreferredFaction
    /// </summary>
    public unsafe static bool ObservePreferredFaction()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObservePreferredFaction, "BmGame.GDGIBase.ObservePreferredFaction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_LogEndGameEventScores;
    /// <summary>
    /// Function: LogEndGameEventScores
    /// </summary>
    public unsafe virtual void LogEndGameEventScores(out BmSDK.BmGame.GDStatEndgameEvent EndgameEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogEndGameEventScores, "BmGame.GDGIBase.LogEndGameEventScores");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out EndgameEvent);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndgameEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        EndgameEvent = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDStatEndgameEvent>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_LogEndGameEvent;
    /// <summary>
    /// Function: LogEndGameEvent
    /// </summary>
    public unsafe virtual void LogEndGameEvent(BmSDK.FString WinningTeam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogEndGameEvent, "BmGame.GDGIBase.LogEndGameEvent");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WinningTeam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDefaultInventory;
    /// <summary>
    /// Function: AddDefaultInventory
    /// </summary>
    public unsafe override void AddDefaultInventory(BmSDK.Engine.Pawn P)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDefaultInventory, "BmGame.GDGIBase.AddDefaultInventory");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostSeamlessTravel;
    /// <summary>
    /// Function: PostSeamlessTravel
    /// </summary>
    public unsafe override void PostSeamlessTravel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostSeamlessTravel, "BmGame.GDGIBase.PostSeamlessTravel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleSeamlessTravelPlayer;
    /// <summary>
    /// Function: HandleSeamlessTravelPlayer
    /// </summary>
    public unsafe override void HandleSeamlessTravelPlayer(out BmSDK.Engine.Controller C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleSeamlessTravelPlayer, "BmGame.GDGIBase.HandleSeamlessTravelPlayer");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out C);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        C = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Controller>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_LogPlayerEvent;
    /// <summary>
    /// Function: LogPlayerEvent
    /// </summary>
    public unsafe virtual void LogPlayerEvent(BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogPlayerEvent, "BmGame.GDGIBase.LogPlayerEvent");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostLogin;
    /// <summary>
    /// Function: PostLogin
    /// </summary>
    public unsafe override void PostLogin(BmSDK.Engine.PlayerController NewPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostLogin, "BmGame.GDGIBase.PostLogin");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.GDGIBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitGame;
    /// <summary>
    /// Function: InitGame
    /// </summary>
    public unsafe override void InitGame(BmSDK.FString Options, out BmSDK.FString ErrorMessage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitGame, "BmGame.GDGIBase.InitGame");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ErrorMessage = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_LogStatsPlayerResults;
    /// <summary>
    /// Function: LogStatsPlayerResults
    /// </summary>
    public unsafe virtual void LogStatsPlayerResults()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogStatsPlayerResults, "BmGame.GDGIBase.LogStatsPlayerResults");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckRequiredTeamSizes;
    /// <summary>
    /// Function: CheckRequiredTeamSizes
    /// </summary>
    public unsafe static void CheckRequiredTeamSizes()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckRequiredTeamSizes, "BmGame.GDGIBase.CheckRequiredTeamSizes");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignTeams;
    /// <summary>
    /// Function: AssignTeams
    /// </summary>
    public unsafe static void AssignTeams()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignTeams, "BmGame.GDGIBase.AssignTeams");
        byte* paramsPtr = stackalloc byte[16];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GameModeRequiresHeroesAssetPreload, "BmGame.GDGIBase.GameModeRequiresHeroesAssetPreload");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyFactionForPlayer, "BmGame.GDGIBase.GetLobbyFactionForPlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetTeamIndexForLobbyParty;
    /// <summary>
    /// Function: GetTeamIndexForLobbyParty
    /// </summary>
    public unsafe static int GetTeamIndexForLobbyParty(in BmSDK.IpDrv.PartyBeacon.FPartyReservation IncomingParty, out BmSDK.TArray<int> TeamPlayerCounts)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeamIndexForLobbyParty, "BmGame.GDGIBase.GetTeamIndexForLobbyParty");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyDetails, "BmGame.GDGIBase.GetLobbyDetails");
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

    private static BmSDK.Function __fn_GetValidPlayerStarts;
    /// <summary>
    /// Function: GetValidPlayerStarts
    /// </summary>
    public unsafe virtual void GetValidPlayerStarts(BmSDK.BmGame.GDGIBase.ETeamType Team, BmSDK.BmGame.RPlayerController Player, out BmSDK.TArray<BmSDK.BmGame.GDPlayerStart> ValidStarts)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetValidPlayerStarts, "BmGame.GDGIBase.GetValidPlayerStarts");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ValidStarts = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDPlayerStart>>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_AwardExtraExperienceForKill;
    /// <summary>
    /// Function: AwardExtraExperienceForKill
    /// </summary>
    public unsafe virtual void AwardExtraExperienceForKill(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller Victim, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardExtraExperienceForKill, "BmGame.GDGIBase.AwardExtraExperienceForKill");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetKillAssistScoreAndXP;
    /// <summary>
    /// Function: GetKillAssistScoreAndXP
    /// </summary>
    public unsafe virtual bool GetKillAssistScoreAndXP(BmSDK.BmGame.RPlayerController KilledPlayer, BmSDK.BmGame.RPlayerController AssistingPlayer, out int Score, out BmSDK.BmGame.RGameInfo.NewExperienceAmounts NEAType, BmSDK.Class RDamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKillAssistScoreAndXP, "BmGame.GDGIBase.GetKillAssistScoreAndXP");
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

    private static BmSDK.Function __fn_GiveKillScore;
    /// <summary>
    /// Function: GiveKillScore
    /// </summary>
    public unsafe virtual void GiveKillScore(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveKillScore, "BmGame.GDGIBase.GiveKillScore");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScoreLimits;
    /// <summary>
    /// Function: SetScoreLimits
    /// </summary>
    public unsafe virtual void SetScoreLimits(BmSDK.BmGame.GDMatchSettings FromSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScoreLimits, "BmGame.GDGIBase.SetScoreLimits");
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
    public unsafe virtual void ClearGameWideRegenBoost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGameWideRegenBoost, "BmGame.GDGIBase.ClearGameWideRegenBoost");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyGameWideRegenBoost;
    /// <summary>
    /// Function: ApplyGameWideRegenBoost
    /// </summary>
    public unsafe virtual void ApplyGameWideRegenBoost(BmSDK.BmGame.RPlayerController LauncherPC, float BoostAmount, BmSDK.BmGame.RPawnPlayer Victim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyGameWideRegenBoost, "BmGame.GDGIBase.ApplyGameWideRegenBoost");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LauncherPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoostAmount, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMaxCapacity;
    /// <summary>
    /// Function: GetMaxCapacity
    /// </summary>
    public unsafe virtual int GetMaxCapacity()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxCapacity, "BmGame.GDGIBase.GetMaxCapacity");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EndGameTeam;
    /// <summary>
    /// Function: EndGameTeam
    /// </summary>
    public unsafe virtual void EndGameTeam(BmSDK.BmGame.GDTeamInfo Winner, BmSDK.FString Reason)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndGameTeam, "BmGame.GDGIBase.EndGameTeam");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlayerTeamName;
    /// <summary>
    /// Function: GetPlayerTeamName
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlayerTeamName(BmSDK.Engine.Controller C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerTeamName, "BmGame.GDGIBase.GetPlayerTeamName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetWinnerString;
    /// <summary>
    /// Function: GetWinnerString
    /// </summary>
    public unsafe virtual BmSDK.FString GetWinnerString()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWinnerString, "BmGame.GDGIBase.GetWinnerString");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnPlayerControllerGD;
    /// <summary>
    /// Function: SpawnPlayerControllerGD
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerController SpawnPlayerControllerGD(int TeamIndex, System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation, in BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnPlayerControllerGD, "BmGame.GDGIBase.SpawnPlayerControllerGD");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerController>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_SpawnPlayerControllerGDFromController;
    /// <summary>
    /// Function: SpawnPlayerControllerGDFromController
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerController SpawnPlayerControllerGDFromController(out BmSDK.Engine.Controller C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnPlayerControllerGDFromController, "BmGame.GDGIBase.SpawnPlayerControllerGDFromController");
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
    public unsafe virtual BmSDK.Class GetPlayerControllerClass(out BmSDK.Engine.Controller C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerControllerClass, "BmGame.GDGIBase.GetPlayerControllerClass");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out C);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        C = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Controller>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DoGameSpecificLogin;
    /// <summary>
    /// Function: DoGameSpecificLogin
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerController DoGameSpecificLogin(BmSDK.FString Portal, BmSDK.FString Options, BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, out BmSDK.FString ErrorMessage, bool bSpectator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoGameSpecificLogin, "BmGame.GDGIBase.DoGameSpecificLogin");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Portal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpectator, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ErrorMessage = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerController>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_DoGameSpecificPostSeamlessTravel;
    /// <summary>
    /// Function: DoGameSpecificPostSeamlessTravel
    /// </summary>
    public unsafe virtual void DoGameSpecificPostSeamlessTravel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoGameSpecificPostSeamlessTravel, "BmGame.GDGIBase.DoGameSpecificPostSeamlessTravel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoGameSpecificSeamlessTravelPlayer;
    /// <summary>
    /// Function: DoGameSpecificSeamlessTravelPlayer
    /// </summary>
    public unsafe virtual void DoGameSpecificSeamlessTravelPlayer(out BmSDK.Engine.Controller C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoGameSpecificSeamlessTravelPlayer, "BmGame.GDGIBase.DoGameSpecificSeamlessTravelPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out C);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        C = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Controller>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Struct: FSMatchObjectiveText
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FSMatchObjectiveText
    {
        /// <summary>
        /// FloatProperty: ShowTimeSec
        /// </summary>
        public unsafe float ShowTimeSec
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Title
        /// </summary>
        public unsafe BmSDK.FString Title
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: Desc
        /// </summary>
        public unsafe BmSDK.FString Desc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bAllTeams
        /// </summary>
        public unsafe bool bAllTeams
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bShowJokerGang
        /// </summary>
        public unsafe bool bShowJokerGang
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bShowBaneGang
        /// </summary>
        public unsafe bool bShowBaneGang
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bShowHeroes
        /// </summary>
        public unsafe bool bShowHeroes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bAlivePlayersOnly
        /// </summary>
        public unsafe bool bAlivePlayersOnly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bShown
        /// </summary>
        public unsafe bool bShown
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Enum: EHeroScoringTakedownType
    /// </summary>
    public enum EHeroScoringTakedownType : byte
    {
        EHeroScoringTakedownType_Unknown = 0,
        EHeroScoringTakedownType_HangingTakedown = 1,
        EHeroScoringTakedownType_FloorTakedown = 2,
        EHeroScoringTakedownType_TunnelTakedown = 3,
        EHeroScoringTakedownType_VentTakedown = 4,
        EHeroScoringTakedownType_GlassTakedown = 5,
        EHeroScoringTakedownType_DoubleTakedown = 6,
        EHeroScoringTakedownType_KnockoutSmashTakedown = 7,
        EHeroScoringTakedownType_SneakyTakedown = 8,
        EHeroScoringTakedownType_DoubleLedgeTakedown = 9,
        EHeroScoringTakedownType_RailingTakedown = 10,
        EHeroScoringTakedownType_LedgeTakedown = 11,
        EHeroScoringTakedownType_ReverseChokeTakedown = 12,
        EHeroScoringTakedownType_CornerTakedown = 13,
        EHeroScoringTakedownType_Melee = 14,
        EHeroScoringTakedownType_MAX = 15,
    }

    /// <summary>
    /// BoolProperty: bFriendlyFire
    /// </summary>
    public unsafe bool bFriendlyFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1436); }
    }

    /// <summary>
    /// BoolProperty: bReturnToLobby
    /// </summary>
    public unsafe bool bReturnToLobby
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1436); }
    }

    /// <summary>
    /// BoolProperty: bDebugFastIntro
    /// </summary>
    public unsafe bool bDebugFastIntro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1436); }
    }

    /// <summary>
    /// BoolProperty: bUseCaptains
    /// </summary>
    public unsafe bool bUseCaptains
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1436); }
    }

    /// <summary>
    /// BoolProperty: bDoingRegenBoost
    /// </summary>
    public unsafe bool bDoingRegenBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1436); }
    }

    /// <summary>
    /// BoolProperty: bInitialSpawn
    /// </summary>
    public unsafe bool bInitialSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1436); }
    }

    /// <summary>
    /// BoolProperty: bShownHeroesNextGrenadeLocation
    /// </summary>
    public unsafe bool bShownHeroesNextGrenadeLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1436); }
    }

    /// <summary>
    /// BoolProperty: bUsePreferredFaction
    /// </summary>
    public unsafe bool bUsePreferredFaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1436); }
    }

    /// <summary>
    /// BoolProperty: bArbitrationEnded
    /// </summary>
    public unsafe bool bArbitrationEnded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1436); }
    }

    /// <summary>
    /// BoolProperty: bFirstKill
    /// </summary>
    public unsafe bool bFirstKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1436); }
    }

    /// <summary>
    /// BoolProperty: bIsPlayForever
    /// </summary>
    public unsafe bool bIsPlayForever
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1436); }
    }

    /// <summary>
    /// IntProperty: bDebugMinPlayersBeforeGameStarts
    /// </summary>
    public unsafe int bDebugMinPlayersBeforeGameStarts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// FloatProperty: DebugWaitForMinPlayersTimeout
    /// </summary>
    public unsafe float DebugWaitForMinPlayersTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// FloatProperty: GameIntroDuration
    /// </summary>
    public unsafe float GameIntroDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// FloatProperty: GameIntroShortening
    /// </summary>
    public unsafe float GameIntroShortening
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// FloatProperty: GameOutroDuration
    /// </summary>
    public unsafe float GameOutroDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// FloatProperty: GameEndReviewDuration
    /// </summary>
    public unsafe float GameEndReviewDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// ObjectProperty: LobbySystem
    /// </summary>
    public unsafe BmSDK.SDEngine.SDLobbySystem LobbySystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDLobbySystem>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// FloatProperty: FirstCaptainAssignTime
    /// </summary>
    public unsafe float FirstCaptainAssignTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// FloatProperty: CaptainReassignTime
    /// </summary>
    public unsafe float CaptainReassignTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// FloatProperty: DefaultRespawnTime
    /// </summary>
    public unsafe float DefaultRespawnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// StructProperty: CurrentRegenBoost
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGIBase.FSGameWideRegenBoost CurrentRegenBoost
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGIBase.FSGameWideRegenBoost>(Ptr + 1480);

    /// <summary>
    /// ObjectProperty: CurrentMatchSettings
    /// </summary>
    public unsafe BmSDK.BmGame.GDMatchSettings CurrentMatchSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDMatchSettings>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// IntProperty: GameModeScriptVersion
    /// </summary>
    public unsafe int GameModeScriptVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// ObjectProperty: ThugExecutingThugBarkEvent
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent ThugExecutingThugBarkEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// ObjectProperty: HeroTakingdownVillainBarkEvent
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent HeroTakingdownVillainBarkEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderRecap
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderRecap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventOnKill
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventOnKill
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventOnSuicide
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventOnSuicide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnTimeLeft
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnTimeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// NameProperty: BarkEventCommanderOnTimeLeftArgument30
    /// </summary>
    public unsafe BmSDK.FName BarkEventCommanderOnTimeLeftArgument30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// NameProperty: BarkEventCommanderOnTimeLeftArgument10
    /// </summary>
    public unsafe BmSDK.FName BarkEventCommanderOnTimeLeftArgument10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// StrProperty: WinningReason
    /// </summary>
    public unsafe BmSDK.FString WinningReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// FloatProperty: EndGameDelay
    /// </summary>
    public unsafe float EndGameDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// FloatProperty: RespawnProtectionTime
    /// </summary>
    public unsafe float RespawnProtectionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// ArrayProperty: ControlPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDObjectiveControlPoint> ControlPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDObjectiveControlPoint>>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// ObjectProperty: NextGrenadePickup
    /// </summary>
    public unsafe BmSDK.BmGame.GDAmmoPickupObjectBase NextGrenadePickup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDAmmoPickupObjectBase>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// ObjectProperty: CurrentGrenadePickup
    /// </summary>
    public unsafe BmSDK.BmGame.GDAmmoPickupObjectBase CurrentGrenadePickup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDAmmoPickupObjectBase>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// ObjectProperty: GameHostMigrationManager
    /// </summary>
    public unsafe BmSDK.BmGame.GDHostMigrationManager GameHostMigrationManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDHostMigrationManager>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// ObjectProperty: GDGI
    /// </summary>
    public unsafe BmSDK.BmGame.GDGameReplicationInfo GDGI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGameReplicationInfo>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// ObjectProperty: StatisticsManager
    /// </summary>
    public unsafe BmSDK.BmGame.GDStatisticsManager StatisticsManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDStatisticsManager>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// ArrayProperty: RegisteredStatTrackers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDTickableStatTracker> RegisteredStatTrackers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDTickableStatTracker>>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// ObjectProperty: XPStatTracker
    /// </summary>
    public unsafe BmSDK.BmGame.GDExperienceEventStatTracker XPStatTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDExperienceEventStatTracker>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// FloatProperty: MatchStartTime
    /// </summary>
    public unsafe float MatchStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// FloatProperty: PendingSpawnWaitTime
    /// </summary>
    public unsafe float PendingSpawnWaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// FloatProperty: BackToLobbyDelay
    /// </summary>
    public unsafe float BackToLobbyDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// ArrayProperty: InitialSpawnPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDPlayerStart> InitialSpawnPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDPlayerStart>>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// ArrayProperty: SubsequentSpawnPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDPlayerStart> SubsequentSpawnPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDPlayerStart>>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// DelegateProperty: __SortByMatchXP__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByMatchXP__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }
    }

    /// <summary>
    /// Struct: FSGameWideRegenBoost
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSGameWideRegenBoost
    {
        /// <summary>
        /// ObjectProperty: AffectedPlayer
        /// </summary>
        public unsafe BmSDK.BmGame.RPlayerController AffectedPlayer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: AffectedTeam
        /// </summary>
        public unsafe BmSDK.BmGame.GDTeamInfo AffectedTeam
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDTeamInfo>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: RegenBoost
        /// </summary>
        public unsafe float RegenBoost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: Victim
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer Victim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: ETeamType
    /// </summary>
    public enum ETeamType : byte
    {
        ETeamType_Unknown = 0,
        ETeamType_Hero = 1,
        ETeamType_Bane = 2,
        ETeamType_Joker = 3,
        ETeamType_Deathmatch = 4,
        ETeamType_MAX = 5,
    }

    /// <summary>
    /// Enum: EPlayerAllegiance
    /// </summary>
    public enum EPlayerAllegiance : byte
    {
        EPlayerAllegiance_Unknown = 0,
        EPlayerAllegiance_Friendly = 1,
        EPlayerAllegiance_Enemy = 2,
        EPlayerAllegiance_Neutral = 3,
        EPlayerAllegiance_MAX = 4,
    }

    /// <summary>
    /// Enum: EGameState
    /// </summary>
    public enum EGameState : byte
    {
        EGameState_Pending = 0,
        EGameState_Intro = 1,
        EGameState_GameOn = 2,
        EGameState_Outro = 3,
        EGameState_GameReview = 4,
        EGameState_HeroLottery = 5,
        EGameState_MAX = 6,
    }

    /// <summary>
    /// Struct: FSIntimidationEvent
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FSIntimidationEvent
    {
        /// <summary>
        /// ClassProperty: DamageType
        /// </summary>
        public unsafe BmSDK.Class DamageType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: TimeStamp
        /// </summary>
        public unsafe int TimeStamp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bHeroDeath
        /// </summary>
        public unsafe bool bHeroDeath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: RespawnedThugs
        /// </summary>
        public unsafe int RespawnedThugs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: FirstUseBonus
        /// </summary>
        public unsafe int FirstUseBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: VariationBonus
        /// </summary>
        public unsafe int VariationBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: SilentTakedownBonus
        /// </summary>
        public unsafe int SilentTakedownBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: CaptainTakedownBonus
        /// </summary>
        public unsafe int CaptainTakedownBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: CurrentCombo
        /// </summary>
        public unsafe int CurrentCombo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: BaseTakedownScore
        /// </summary>
        public unsafe int BaseTakedownScore
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: SupervillainTakedownBonus
        /// </summary>
        public unsafe int SupervillainTakedownBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: TotalScore
        /// </summary>
        public unsafe int TotalScore
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }
}
