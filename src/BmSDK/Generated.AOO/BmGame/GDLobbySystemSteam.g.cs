#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDLobbySystemSteam<br/>
/// (size = 944)
/// (flags = 134250646)
/// </summary>
public partial class GDLobbySystemSteam : BmSDK.SDEngine.SDLobbySystem, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDLobbySystemSteam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDLobbySystemSteam.
    /// </summary>
    public static GDLobbySystemSteam DefaultObject => (GDLobbySystemSteam)StaticClass().DefaultObject;

    internal GDLobbySystemSteam() { }

    /// <summary>
    /// Constructs a new GDLobbySystemSteam
    /// </summary>
    public GDLobbySystemSteam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDLobbySystemSteam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDLobbySystemSteam(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDLobbySystemSteam>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDLobbySystemSteam>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDLobbySystemSteam>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDLobbySystemSteam>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDLobbySystemSteam>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDLobbySystemSteam>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDLobbySystemSteam>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDLobbySystemSteam>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetSkillSearchParams;
    /// <summary>
    /// Function: GetSkillSearchParams
    /// </summary>
    public unsafe override void GetSkillSearchParams(out float SkillSpeed, out float SkillSpeedMax, out float SkillAccel, out float SkillMin, out float SkillMax, out int NumTriesSameSkill, out float TimeoutSearch, out float TimeoutJoin, out float SearchRequestThrottleTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSkillSearchParams, "BmGame.GDLobbySystemSteam.GetSkillSearchParams");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SkillSpeed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkillSpeed, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SkillSpeedMax);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkillSpeedMax, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SkillAccel);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkillAccel, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SkillMin);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkillMin, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SkillMax);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkillMax, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NumTriesSameSkill);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumTriesSameSkill, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TimeoutSearch);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeoutSearch, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TimeoutJoin);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeoutJoin, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SearchRequestThrottleTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchRequestThrottleTime, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SkillSpeed = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        SkillSpeedMax = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        SkillAccel = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        SkillMin = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        SkillMax = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        NumTriesSameSkill = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
        TimeoutSearch = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        TimeoutJoin = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
        SearchRequestThrottleTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 32);
        return;
    }

    private static BmSDK.Function __fn_GetPlayerSkill;
    /// <summary>
    /// Function: GetPlayerSkill
    /// </summary>
    public unsafe override int GetPlayerSkill()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerSkill, "BmGame.GDLobbySystemSteam.GetPlayerSkill");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DestroyLobby;
    /// <summary>
    /// Function: DestroyLobby
    /// </summary>
    public unsafe override void DestroyLobby(BmSDK.SDEngine.SDLobbySystem.ReturnPoint inDesiredRetPoint = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyLobby, "BmGame.GDLobbySystemSteam.DestroyLobby");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inDesiredRetPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFailedToJoinLobby;
    /// <summary>
    /// Function: OnFailedToJoinLobby
    /// </summary>
    public unsafe override void OnFailedToJoinLobby()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFailedToJoinLobby, "BmGame.GDLobbySystemSteam.OnFailedToJoinLobby");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetReadyStatus;
    /// <summary>
    /// Function: SetReadyStatus
    /// </summary>
    public unsafe override void SetReadyStatus(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, bool ReadyStatus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetReadyStatus, "BmGame.GDLobbySystemSteam.SetReadyStatus");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadyStatus, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndGame;
    /// <summary>
    /// Function: EndGame
    /// </summary>
    public unsafe override void EndGame(bool bReturnToFrontend)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndGame, "BmGame.GDLobbySystemSteam.EndGame");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReturnToFrontend, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TravelToLobbySession;
    /// <summary>
    /// Function: TravelToLobbySession
    /// </summary>
    public unsafe override void TravelToLobbySession(BmSDK.Class SearchClass, byte PlatformSpecificInfo, bool bShouldLoad)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TravelToLobbySession, "BmGame.GDLobbySystemSteam.TravelToLobbySession");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformSpecificInfo, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldLoad, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetGDLobbyData;
    /// <summary>
    /// Function: ResetGDLobbyData
    /// </summary>
    public unsafe virtual void ResetGDLobbyData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetGDLobbyData, "BmGame.GDLobbySystemSteam.ResetGDLobbyData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateLobby;
    /// <summary>
    /// Function: CreateLobby
    /// </summary>
    public unsafe override void CreateLobby(BmSDK.SDEngine.SDLocalPlayer Host, int InNumTeams = default, int InNumPlayersPerTeam = default, int inMaxPlayers = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateLobby, "BmGame.GDLobbySystemSteam.CreateLobby");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Host, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InNumTeams, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InNumPlayersPerTeam, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inMaxPlayers, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AcceptInvite;
    /// <summary>
    /// Function: AcceptInvite
    /// </summary>
    public unsafe override void AcceptInvite(BmSDK.SDEngine.SDLocalPlayer Host, BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult InviteResult)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AcceptInvite, "BmGame.GDLobbySystemSteam.AcceptInvite");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Host, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteResult, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JoinLobby;
    /// <summary>
    /// Function: JoinLobby
    /// </summary>
    public unsafe override void JoinLobby(BmSDK.SDEngine.SDLocalPlayer Host, BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult SearchResult)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JoinLobby, "BmGame.GDLobbySystemSteam.JoinLobby");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Host, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchResult, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MigrateClient;
    /// <summary>
    /// Function: MigrateClient
    /// </summary>
    public unsafe override void MigrateClient(BmSDK.Class SearchClass, byte PlatformSpecificInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MigrateClient, "BmGame.GDLobbySystemSteam.MigrateClient");
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformSpecificInfo, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MigrateClientToFrontend;
    /// <summary>
    /// Function: MigrateClientToFrontend
    /// </summary>
    public unsafe override void MigrateClientToFrontend(BmSDK.Class SearchClass, byte PlatformSpecificInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MigrateClientToFrontend, "BmGame.GDLobbySystemSteam.MigrateClientToFrontend");
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformSpecificInfo, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MigrateLobbyToFrontend;
    /// <summary>
    /// Function: MigrateLobbyToFrontend
    /// </summary>
    public unsafe override void MigrateLobbyToFrontend()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MigrateLobbyToFrontend, "BmGame.GDLobbySystemSteam.MigrateLobbyToFrontend");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MigrateLobby;
    /// <summary>
    /// Function: MigrateLobby
    /// </summary>
    public unsafe override void MigrateLobby()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MigrateLobby, "BmGame.GDLobbySystemSteam.MigrateLobby");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickMatch;
    /// <summary>
    /// Function: QuickMatch
    /// </summary>
    public unsafe override void QuickMatch(BmSDK.SDEngine.SDLocalPlayer Host)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickMatch, "BmGame.GDLobbySystemSteam.QuickMatch");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Host, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckNextRoundHeroesStillExist;
    /// <summary>
    /// Function: CheckNextRoundHeroesStillExist
    /// </summary>
    public unsafe virtual void CheckNextRoundHeroesStillExist()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckNextRoundHeroesStillExist, "BmGame.GDLobbySystemSteam.CheckNextRoundHeroesStillExist");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetNewJoinersTeams;
    /// <summary>
    /// Function: ResetNewJoinersTeams
    /// </summary>
    public unsafe virtual void ResetNewJoinersTeams()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetNewJoinersTeams, "BmGame.GDLobbySystemSteam.ResetNewJoinersTeams");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ContextGameModeToGameMode;
    /// <summary>
    /// Function: ContextGameModeToGameMode
    /// </summary>
    public unsafe override int ContextGameModeToGameMode(int ContextGM)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ContextGameModeToGameMode, "BmGame.GDLobbySystemSteam.ContextGameModeToGameMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextGM, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetContextGameMode;
    /// <summary>
    /// Function: GetContextGameMode
    /// </summary>
    public unsafe override int GetContextGameMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetContextGameMode, "BmGame.GDLobbySystemSteam.GetContextGameMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AssignTeams;
    /// <summary>
    /// Function: AssignTeams
    /// </summary>
    public unsafe virtual void AssignTeams()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignTeams, "BmGame.GDLobbySystemSteam.AssignTeams");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLobbyJoinGame;
    /// <summary>
    /// Function: OnLobbyJoinGame
    /// </summary>
    public unsafe override void OnLobbyJoinGame(in BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FActiveLobbyInfo> LobbyList, int LobbyIndex, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerID, BmSDK.FString ServerIP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbyJoinGame, "BmGame.GDLobbySystemSteam.OnLobbyJoinGame");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerID, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TravelToGameSession;
    /// <summary>
    /// Function: TravelToGameSession
    /// </summary>
    public unsafe override void TravelToGameSession(BmSDK.Class SearchClass, byte PlatformSpecificInfo, bool bShouldLoad)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TravelToGameSession, "BmGame.GDLobbySystemSteam.TravelToGameSession");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformSpecificInfo, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldLoad, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartGame;
    /// <summary>
    /// Function: StartGame
    /// </summary>
    public unsafe override void StartGame(bool bCreateListenServer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGame, "BmGame.GDLobbySystemSteam.StartGame");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCreateListenServer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActualStartCountDown;
    /// <summary>
    /// Function: ActualStartCountDown
    /// </summary>
    public unsafe virtual void ActualStartCountDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActualStartCountDown, "BmGame.GDLobbySystemSteam.ActualStartCountDown");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryStartCountDown;
    /// <summary>
    /// Function: TryStartCountDown
    /// </summary>
    public unsafe virtual void TryStartCountDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryStartCountDown, "BmGame.GDLobbySystemSteam.TryStartCountDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartCountdown;
    /// <summary>
    /// Function: StartCountdown
    /// </summary>
    public unsafe override void StartCountdown(float NumSeconds, System.IntPtr TickCallback = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCountdown, "BmGame.GDLobbySystemSteam.StartCountdown");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSeconds, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TickCallback, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerMemberListUpdatedDelegates;
    /// <summary>
    /// Function: TriggerMemberListUpdatedDelegates
    /// </summary>
    public unsafe virtual void TriggerMemberListUpdatedDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerMemberListUpdatedDelegates, "BmGame.GDLobbySystemSteam.TriggerMemberListUpdatedDelegates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMemberListUpdated;
    /// <summary>
    /// Function: OnMemberListUpdated
    /// </summary>
    public unsafe override void OnMemberListUpdated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMemberListUpdated, "BmGame.GDLobbySystemSteam.OnMemberListUpdated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateLocalLoadout;
    /// <summary>
    /// Function: CreateLocalLoadout
    /// </summary>
    public unsafe virtual void CreateLocalLoadout(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateLocalLoadout, "BmGame.GDLobbySystemSteam.CreateLocalLoadout");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InternalCreateLocalLoadout;
    /// <summary>
    /// Function: InternalCreateLocalLoadout
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDLobbySystemSteam.FGDLoadout InternalCreateLocalLoadout(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalCreateLocalLoadout, "BmGame.GDLobbySystemSteam.InternalCreateLocalLoadout");
        byte* paramsPtr = stackalloc byte[448];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDLobbySystemSteam.FGDLoadout>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPawnConfig;
    /// <summary>
    /// Function: GetPawnConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDPawnConfigInterfaceBase GetPawnConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnConfig, "BmGame.GDLobbySystemSteam.GetPawnConfig");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDPawnConfigInterfaceBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasLocalLoadout;
    /// <summary>
    /// Function: HasLocalLoadout
    /// </summary>
    public unsafe virtual bool HasLocalLoadout(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasLocalLoadout, "BmGame.GDLobbySystemSteam.HasLocalLoadout");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanSwapTeams;
    /// <summary>
    /// Function: CanSwapTeams
    /// </summary>
    public unsafe virtual bool CanSwapTeams(int CurrentTeamIndex, int SwapToTeamIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSwapTeams, "BmGame.GDLobbySystemSteam.CanSwapTeams");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwapToTeamIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetFactionPreferenceFromNetID;
    /// <summary>
    /// Function: GetFactionPreferenceFromNetID
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDLobbySystemSteam.ELobbyFactionType GetFactionPreferenceFromNetID(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFactionPreferenceFromNetID, "BmGame.GDLobbySystemSteam.GetFactionPreferenceFromNetID");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDLobbySystemSteam.ELobbyFactionType>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DumpPreferredFactions;
    /// <summary>
    /// Function: DumpPreferredFactions
    /// </summary>
    public unsafe virtual void DumpPreferredFactions()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpPreferredFactions, "BmGame.GDLobbySystemSteam.DumpPreferredFactions");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnArbitrationCompleted;
    /// <summary>
    /// Function: OnArbitrationCompleted
    /// </summary>
    public unsafe override void OnArbitrationCompleted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnArbitrationCompleted, "BmGame.GDLobbySystemSteam.OnArbitrationCompleted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KickIdlers;
    /// <summary>
    /// Function: KickIdlers
    /// </summary>
    public unsafe override void KickIdlers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KickIdlers, "BmGame.GDLobbySystemSteam.KickIdlers");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KickPlayer;
    /// <summary>
    /// Function: KickPlayer
    /// </summary>
    public unsafe override void KickPlayer(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KickPlayer, "BmGame.GDLobbySystemSteam.KickPlayer");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BroadcastAllVotes;
    /// <summary>
    /// Function: BroadcastAllVotes
    /// </summary>
    public unsafe override void BroadcastAllVotes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BroadcastAllVotes, "BmGame.GDLobbySystemSteam.BroadcastAllVotes");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Vote;
    /// <summary>
    /// Function: Vote
    /// </summary>
    public unsafe override void Vote(byte NewVote)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Vote, "BmGame.GDLobbySystemSteam.Vote");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVote, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpLobbyState;
    /// <summary>
    /// Function: DumpLobbyState
    /// </summary>
    public unsafe override void DumpLobbyState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpLobbyState, "BmGame.GDLobbySystemSteam.DumpLobbyState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpLobbyMembers;
    /// <summary>
    /// Function: DumpLobbyMembers
    /// </summary>
    public unsafe override void DumpLobbyMembers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpLobbyMembers, "BmGame.GDLobbySystemSteam.DumpLobbyMembers");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTeamAssignment;
    /// <summary>
    /// Function: GetTeamAssignment
    /// </summary>
    public unsafe override void GetTeamAssignment(in BmSDK.IpDrv.PartyBeacon.FPartyReservation Party, out int TeamNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeamAssignment, "BmGame.GDLobbySystemSteam.GetTeamAssignment");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Party, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TeamNum);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamNum, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TeamNum = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_DestroyBeacon;
    /// <summary>
    /// Function: DestroyBeacon
    /// </summary>
    public unsafe override void DestroyBeacon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyBeacon, "BmGame.GDLobbySystemSteam.DestroyBeacon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBeacon;
    /// <summary>
    /// Function: GetBeacon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDLobbySteamBeacon GetBeacon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBeacon, "BmGame.GDLobbySystemSteam.GetBeacon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDLobbySteamBeacon>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnTriggerPlayerAssetsPreloadOnClients;
    /// <summary>
    /// Function: OnTriggerPlayerAssetsPreloadOnClients
    /// </summary>
    public unsafe virtual void OnTriggerPlayerAssetsPreloadOnClients()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTriggerPlayerAssetsPreloadOnClients, "BmGame.GDLobbySystemSteam.OnTriggerPlayerAssetsPreloadOnClients");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearTriggerPlayerAssetsPreloadOnClientsDelegate;
    /// <summary>
    /// Function: ClearTriggerPlayerAssetsPreloadOnClientsDelegate
    /// </summary>
    public unsafe virtual void ClearTriggerPlayerAssetsPreloadOnClientsDelegate(System.IntPtr Callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearTriggerPlayerAssetsPreloadOnClientsDelegate, "BmGame.GDLobbySystemSteam.ClearTriggerPlayerAssetsPreloadOnClientsDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddTriggerPlayerAssetsPreloadOnClientsDelegate;
    /// <summary>
    /// Function: AddTriggerPlayerAssetsPreloadOnClientsDelegate
    /// </summary>
    public unsafe virtual void AddTriggerPlayerAssetsPreloadOnClientsDelegate(System.IntPtr Callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddTriggerPlayerAssetsPreloadOnClientsDelegate, "BmGame.GDLobbySystemSteam.AddTriggerPlayerAssetsPreloadOnClientsDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPreloadLocalSkinSelectionReceived;
    /// <summary>
    /// Function: OnPreloadLocalSkinSelectionReceived
    /// </summary>
    public unsafe virtual void OnPreloadLocalSkinSelectionReceived(BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId, BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int CharAltMeshIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPreloadLocalSkinSelectionReceived, "BmGame.GDLobbySystemSteam.OnPreloadLocalSkinSelectionReceived");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharAltMeshIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPreloadLocalSkinSelectionReceivedDelegate;
    /// <summary>
    /// Function: ClearPreloadLocalSkinSelectionReceivedDelegate
    /// </summary>
    public unsafe virtual void ClearPreloadLocalSkinSelectionReceivedDelegate(System.IntPtr Callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPreloadLocalSkinSelectionReceivedDelegate, "BmGame.GDLobbySystemSteam.ClearPreloadLocalSkinSelectionReceivedDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPreloadLocalSkinSelectionReceivedDelegate;
    /// <summary>
    /// Function: AddPreloadLocalSkinSelectionReceivedDelegate
    /// </summary>
    public unsafe virtual void AddPreloadLocalSkinSelectionReceivedDelegate(System.IntPtr Callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPreloadLocalSkinSelectionReceivedDelegate, "BmGame.GDLobbySystemSteam.AddPreloadLocalSkinSelectionReceivedDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnUpdateCharAltMeshIndex;
    /// <summary>
    /// Function: OnUpdateCharAltMeshIndex
    /// </summary>
    public unsafe virtual void OnUpdateCharAltMeshIndex(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int CharAltMeshIndex, bool ForceReloadPlayableMeshes)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnUpdateCharAltMeshIndex, "BmGame.GDLobbySystemSteam.OnUpdateCharAltMeshIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharAltMeshIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceReloadPlayableMeshes, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearUpdateCharAltMeshIndexDelegate;
    /// <summary>
    /// Function: ClearUpdateCharAltMeshIndexDelegate
    /// </summary>
    public unsafe virtual void ClearUpdateCharAltMeshIndexDelegate(System.IntPtr Callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearUpdateCharAltMeshIndexDelegate, "BmGame.GDLobbySystemSteam.ClearUpdateCharAltMeshIndexDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddUpdateCharAltMeshIndexDelegate;
    /// <summary>
    /// Function: AddUpdateCharAltMeshIndexDelegate
    /// </summary>
    public unsafe virtual void AddUpdateCharAltMeshIndexDelegate(System.IntPtr Callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUpdateCharAltMeshIndexDelegate, "BmGame.GDLobbySystemSteam.AddUpdateCharAltMeshIndexDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnUpdateMemberCustomization;
    /// <summary>
    /// Function: OnUpdateMemberCustomization
    /// </summary>
    public unsafe virtual void OnUpdateMemberCustomization(BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId, BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelectionIndexed> CurrentCustomizationSetsIndexed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnUpdateMemberCustomization, "BmGame.GDLobbySystemSteam.OnUpdateMemberCustomization");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentCustomizationSetsIndexed, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearUpdateMemberCustomizationDelegate;
    /// <summary>
    /// Function: ClearUpdateMemberCustomizationDelegate
    /// </summary>
    public unsafe virtual void ClearUpdateMemberCustomizationDelegate(System.IntPtr Callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearUpdateMemberCustomizationDelegate, "BmGame.GDLobbySystemSteam.ClearUpdateMemberCustomizationDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddUpdateMemberCustomizationDelegate;
    /// <summary>
    /// Function: AddUpdateMemberCustomizationDelegate
    /// </summary>
    public unsafe virtual void AddUpdateMemberCustomizationDelegate(System.IntPtr Callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUpdateMemberCustomizationDelegate, "BmGame.GDLobbySystemSteam.AddUpdateMemberCustomizationDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNextRobinPlayerNetId;
    /// <summary>
    /// Function: GetNextRobinPlayerNetId
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.FUniqueNetId GetNextRobinPlayerNetId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextRobinPlayerNetId, "BmGame.GDLobbySystemSteam.GetNextRobinPlayerNetId");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRobinPlayerNetId;
    /// <summary>
    /// Function: GetRobinPlayerNetId
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.FUniqueNetId GetRobinPlayerNetId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRobinPlayerNetId, "BmGame.GDLobbySystemSteam.GetRobinPlayerNetId");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetRobinPlayer;
    /// <summary>
    /// Function: SetRobinPlayer
    /// </summary>
    public unsafe virtual void SetRobinPlayer(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRobinPlayer, "BmGame.GDLobbySystemSteam.SetRobinPlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNextBatmanPlayerNetId;
    /// <summary>
    /// Function: GetNextBatmanPlayerNetId
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.FUniqueNetId GetNextBatmanPlayerNetId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextBatmanPlayerNetId, "BmGame.GDLobbySystemSteam.GetNextBatmanPlayerNetId");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatmanPlayerNetId;
    /// <summary>
    /// Function: GetBatmanPlayerNetId
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.FUniqueNetId GetBatmanPlayerNetId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatmanPlayerNetId, "BmGame.GDLobbySystemSteam.GetBatmanPlayerNetId");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetBatmanPlayer;
    /// <summary>
    /// Function: SetBatmanPlayer
    /// </summary>
    public unsafe virtual void SetBatmanPlayer(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatmanPlayer, "BmGame.GDLobbySystemSteam.SetBatmanPlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNextRobinPlayerNetId;
    /// <summary>
    /// Function: SetNextRobinPlayerNetId
    /// </summary>
    public unsafe virtual void SetNextRobinPlayerNetId(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNextRobinPlayerNetId, "BmGame.GDLobbySystemSteam.SetNextRobinPlayerNetId");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNextBatmanPlayerNetId;
    /// <summary>
    /// Function: SetNextBatmanPlayerNetId
    /// </summary>
    public unsafe virtual void SetNextBatmanPlayerNetId(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNextBatmanPlayerNetId, "BmGame.GDLobbySystemSteam.SetNextBatmanPlayerNetId");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRobinPlayerNetId;
    /// <summary>
    /// Function: SetRobinPlayerNetId
    /// </summary>
    public unsafe virtual void SetRobinPlayerNetId(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRobinPlayerNetId, "BmGame.GDLobbySystemSteam.SetRobinPlayerNetId");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBatmanPlayerNetId;
    /// <summary>
    /// Function: SetBatmanPlayerNetId
    /// </summary>
    public unsafe virtual void SetBatmanPlayerNetId(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatmanPlayerNetId, "BmGame.GDLobbySystemSteam.SetBatmanPlayerNetId");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetNextRoundPlayerHeroesAssignments;
    /// <summary>
    /// Function: ResetNextRoundPlayerHeroesAssignments
    /// </summary>
    public unsafe virtual void ResetNextRoundPlayerHeroesAssignments()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetNextRoundPlayerHeroesAssignments, "BmGame.GDLobbySystemSteam.ResetNextRoundPlayerHeroesAssignments");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetPlayerHeroesAssignments;
    /// <summary>
    /// Function: ResetPlayerHeroesAssignments
    /// </summary>
    public unsafe virtual void ResetPlayerHeroesAssignments()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPlayerHeroesAssignments, "BmGame.GDLobbySystemSteam.ResetPlayerHeroesAssignments");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHeroPlayerNetIDs;
    /// <summary>
    /// Function: UpdateHeroPlayerNetIDs
    /// </summary>
    public unsafe virtual void UpdateHeroPlayerNetIDs()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHeroPlayerNetIDs, "BmGame.GDLobbySystemSteam.UpdateHeroPlayerNetIDs");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SortNetId;
    /// <summary>
    /// Function: SortNetId
    /// </summary>
    public unsafe virtual int SortNetId(BmSDK.Engine.OnlineSubsystem.FUniqueNetId A, BmSDK.Engine.OnlineSubsystem.FUniqueNetId B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortNetId, "BmGame.GDLobbySystemSteam.SortNetId");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SortNetIdScript;
    /// <summary>
    /// Function: SortNetIdScript
    /// </summary>
    public unsafe virtual int SortNetIdScript(BmSDK.Engine.OnlineSubsystem.FUniqueNetId A, BmSDK.Engine.OnlineSubsystem.FUniqueNetId B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortNetIdScript, "BmGame.GDLobbySystemSteam.SortNetIdScript");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetHerosNetIds;
    /// <summary>
    /// Function: GetHerosNetIds
    /// </summary>
    public unsafe virtual void GetHerosNetIds(out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> outNetIds)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHerosNetIds, "BmGame.GDLobbySystemSteam.GetHerosNetIds");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outNetIds = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetHeroOptOutForUser;
    /// <summary>
    /// Function: SetHeroOptOutForUser
    /// </summary>
    public unsafe virtual void SetHeroOptOutForUser(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, bool bOptOut)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHeroOptOutForUser, "BmGame.GDLobbySystemSteam.SetHeroOptOutForUser");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOptOut, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRoundsPlayedSinceHeroForUser;
    /// <summary>
    /// Function: SetRoundsPlayedSinceHeroForUser
    /// </summary>
    public unsafe virtual void SetRoundsPlayedSinceHeroForUser(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, int NumRounds)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRoundsPlayedSinceHeroForUser, "BmGame.GDLobbySystemSteam.SetRoundsPlayedSinceHeroForUser");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumRounds, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHeroOptOutForUser;
    /// <summary>
    /// Function: GetHeroOptOutForUser
    /// </summary>
    public unsafe virtual bool GetHeroOptOutForUser(BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeroOptOutForUser, "BmGame.GDLobbySystemSteam.GetHeroOptOutForUser");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetRoundsPlayedSinceHeroForUser;
    /// <summary>
    /// Function: GetRoundsPlayedSinceHeroForUser
    /// </summary>
    public unsafe virtual int GetRoundsPlayedSinceHeroForUser(BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRoundsPlayedSinceHeroForUser, "BmGame.GDLobbySystemSteam.GetRoundsPlayedSinceHeroForUser");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetLobbyMemberData;
    /// <summary>
    /// Function: GetLobbyMemberData
    /// </summary>
    public unsafe virtual bool GetLobbyMemberData(BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, out BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember outLobbyMemberData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyMemberData, "BmGame.GDLobbySystemSteam.GetLobbyMemberData");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outLobbyMemberData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 76);
    }

    private static BmSDK.Function __fn_GetLocalMemberNetId;
    /// <summary>
    /// Function: GetLocalMemberNetId
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.FUniqueNetId GetLocalMemberNetId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalMemberNetId, "BmGame.GDLobbySystemSteam.GetLocalMemberNetId");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerPlayerAssetsPreloadOnClients;
    /// <summary>
    /// Function: TriggerPlayerAssetsPreloadOnClients
    /// </summary>
    public unsafe virtual void TriggerPlayerAssetsPreloadOnClients()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPlayerAssetsPreloadOnClients, "BmGame.GDLobbySystemSteam.TriggerPlayerAssetsPreloadOnClients");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendPreloadLocalSkinSelection;
    /// <summary>
    /// Function: SendPreloadLocalSkinSelection
    /// </summary>
    public unsafe virtual void SendPreloadLocalSkinSelection(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int CharAltMeshIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendPreloadLocalSkinSelection, "BmGame.GDLobbySystemSteam.SendPreloadLocalSkinSelection");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharAltMeshIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BroadcastReadyList;
    /// <summary>
    /// Function: BroadcastReadyList
    /// </summary>
    public unsafe override void BroadcastReadyList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BroadcastReadyList, "BmGame.GDLobbySystemSteam.BroadcastReadyList");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendArbitrationAck;
    /// <summary>
    /// Function: SendArbitrationAck
    /// </summary>
    public unsafe override void SendArbitrationAck()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendArbitrationAck, "BmGame.GDLobbySystemSteam.SendArbitrationAck");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BroadcastArbitrationId;
    /// <summary>
    /// Function: BroadcastArbitrationId
    /// </summary>
    public unsafe override void BroadcastArbitrationId(BmSDK.FString ArbitrationId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BroadcastArbitrationId, "BmGame.GDLobbySystemSteam.BroadcastArbitrationId");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArbitrationId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendCharAltMeshIndex;
    /// <summary>
    /// Function: SendCharAltMeshIndex
    /// </summary>
    public unsafe virtual void SendCharAltMeshIndex(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int CharAltMeshIndex, bool ForceReloadPlayableMeshes)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendCharAltMeshIndex, "BmGame.GDLobbySystemSteam.SendCharAltMeshIndex");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharAltMeshIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceReloadPlayableMeshes, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendClientCustomizationData;
    /// <summary>
    /// Function: SendClientCustomizationData
    /// </summary>
    public unsafe virtual void SendClientCustomizationData(BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelectionIndexed> currentCustomizationSets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendClientCustomizationData, "BmGame.GDLobbySystemSteam.SendClientCustomizationData");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(currentCustomizationSets, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlayerLoadoutFromNetId;
    /// <summary>
    /// Function: GetPlayerLoadoutFromNetId
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDLobbySystemSteam.FGDLoadout GetPlayerLoadoutFromNetId(BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerLoadoutFromNetId, "BmGame.GDLobbySystemSteam.GetPlayerLoadoutFromNetId");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDLobbySystemSteam.FGDLoadout>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindPlayerLoadout;
    /// <summary>
    /// Function: FindPlayerLoadout
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDLobbySystemSteam.FGDLoadout FindPlayerLoadout(BmSDK.BmGame.RPawnPlayer _pawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPlayerLoadout, "BmGame.GDLobbySystemSteam.FindPlayerLoadout");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_pawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDLobbySystemSteam.FGDLoadout>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetPlayerTeam;
    /// <summary>
    /// Function: SetPlayerTeam
    /// </summary>
    public unsafe virtual void SetPlayerTeam(BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId, int TeamID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerTeam, "BmGame.GDLobbySystemSteam.SetPlayerTeam");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePlayerTeam;
    /// <summary>
    /// Function: UpdatePlayerTeam
    /// </summary>
    public unsafe virtual void UpdatePlayerTeam(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, int TeamID, bool ForceUpdate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePlayerTeam, "BmGame.GDLobbySystemSteam.UpdatePlayerTeam");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceUpdate, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNextHeroPlayers;
    /// <summary>
    /// Function: SetNextHeroPlayers
    /// </summary>
    public unsafe virtual void SetNextHeroPlayers(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NextBatmanNetID, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NextRobinNetID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNextHeroPlayers, "BmGame.GDLobbySystemSteam.SetNextHeroPlayers");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextBatmanNetID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextRobinNetID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateNextHeroPlayers;
    /// <summary>
    /// Function: UpdateNextHeroPlayers
    /// </summary>
    public unsafe virtual void UpdateNextHeroPlayers(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NextBatmanNetID, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NextRobinNetID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateNextHeroPlayers, "BmGame.GDLobbySystemSteam.UpdateNextHeroPlayers");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextBatmanNetID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextRobinNetID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHeroOptOutStatus;
    /// <summary>
    /// Function: SetHeroOptOutStatus
    /// </summary>
    public unsafe virtual void SetHeroOptOutStatus(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, bool bOptOut)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHeroOptOutStatus, "BmGame.GDLobbySystemSteam.SetHeroOptOutStatus");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOptOut, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRoundsSinceHero;
    /// <summary>
    /// Function: SetRoundsSinceHero
    /// </summary>
    public unsafe virtual void SetRoundsSinceHero(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, int RoundsSinceHero)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRoundsSinceHero, "BmGame.GDLobbySystemSteam.SetRoundsSinceHero");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoundsSinceHero, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InactiveProfileAcceptedInvite;
    /// <summary>
    /// Function: InactiveProfileAcceptedInvite
    /// </summary>
    public unsafe virtual void InactiveProfileAcceptedInvite(int UserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InactiveProfileAcceptedInvite, "BmGame.GDLobbySystemSteam.InactiveProfileAcceptedInvite");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Cleanup;
    /// <summary>
    /// Function: Cleanup
    /// </summary>
    public unsafe override void Cleanup()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Cleanup, "BmGame.GDLobbySystemSteam.Cleanup");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLobbySettingsUpdate;
    /// <summary>
    /// Function: OnLobbySettingsUpdate
    /// </summary>
    public unsafe virtual void OnLobbySettingsUpdate(in BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FActiveLobbyInfo> LobbyList, int LobbyIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbySettingsUpdate, "BmGame.GDLobbySystemSteam.OnLobbySettingsUpdate");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLobbyMemberStatusUpdate;
    /// <summary>
    /// Function: OnLobbyMemberStatusUpdate
    /// </summary>
    public unsafe virtual void OnLobbyMemberStatusUpdate(in BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FActiveLobbyInfo> LobbyList, int LobbyIndex, int MemberIndex, int InstigatorIndex, BmSDK.FString Status)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbyMemberStatusUpdate, "BmGame.GDLobbySystemSteam.OnLobbyMemberStatusUpdate");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatorIndex, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Status, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BroadcastMessage;
    /// <summary>
    /// Function: BroadcastMessage
    /// </summary>
    public unsafe override void BroadcastMessage(in BmSDK.TArray<byte> Data)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BroadcastMessage, "BmGame.GDLobbySystemSteam.BroadcastMessage");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_SendMessageToHost;
    /// <summary>
    /// Function: SendMessageToHost
    /// </summary>
    public unsafe override void SendMessageToHost(in BmSDK.TArray<byte> Data)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendMessageToHost, "BmGame.GDLobbySystemSteam.SendMessageToHost");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_SendMessageToClient;
    /// <summary>
    /// Function: SendMessageToClient
    /// </summary>
    public unsafe override void SendMessageToClient(in BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientId, in BmSDK.TArray<byte> Data)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendMessageToClient, "BmGame.GDLobbySystemSteam.SendMessageToClient");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_OnLobbyReceiveMessage;
    /// <summary>
    /// Function: OnLobbyReceiveMessage
    /// </summary>
    public unsafe virtual void OnLobbyReceiveMessage(in BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FActiveLobbyInfo> LobbyList, int LobbyIndex, int MemberIndex, BmSDK.FString Type, BmSDK.FString Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbyReceiveMessage, "BmGame.GDLobbySystemSteam.OnLobbyReceiveMessage");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLobbyReceiveBinaryData;
    /// <summary>
    /// Function: OnLobbyReceiveBinaryData
    /// </summary>
    public unsafe virtual void OnLobbyReceiveBinaryData(in BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FActiveLobbyInfo> LobbyList, int LobbyIndex, int MemberIndex, in BmSDK.TArray<byte> Data)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbyReceiveBinaryData, "BmGame.GDLobbySystemSteam.OnLobbyReceiveBinaryData");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLevelLoaded;
    /// <summary>
    /// Function: OnLevelLoaded
    /// </summary>
    public unsafe virtual void OnLevelLoaded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLevelLoaded, "BmGame.GDLobbySystemSteam.OnLevelLoaded");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.GDLobbySystemSteam.Initialise");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AcceptedLobbyInvite;
    /// <summary>
    /// Function: AcceptedLobbyInvite
    /// </summary>
    public unsafe virtual void AcceptedLobbyInvite(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, BmSDK.Engine.OnlineSubsystem.FUniqueNetId FriendId, bool bAccepted)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AcceptedLobbyInvite, "BmGame.GDLobbySystemSteam.AcceptedLobbyInvite");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendId, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAccepted, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateVoip;
    /// <summary>
    /// Function: UpdateVoip
    /// </summary>
    public unsafe override void UpdateVoip()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateVoip, "BmGame.GDLobbySystemSteam.UpdateVoip");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGameModeStringFromGameMode;
    /// <summary>
    /// Function: GetGameModeStringFromGameMode
    /// </summary>
    public unsafe virtual BmSDK.FString GetGameModeStringFromGameMode(BmSDK.BmGame.RGameInfo.EGameModes _GameMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameModeStringFromGameMode, "BmGame.GDLobbySystemSteam.GetGameModeStringFromGameMode");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_GameMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_LoadoutChanged;
    /// <summary>
    /// Function: LoadoutChanged
    /// </summary>
    public unsafe virtual void LoadoutChanged(in BmSDK.BmGame.GDLobbySystemSteam.FGDLoadout ChangedLoadout)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadoutChanged, "BmGame.GDLobbySystemSteam.LoadoutChanged");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChangedLoadout, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsHost;
    /// <summary>
    /// Function: IsHost
    /// </summary>
    public unsafe override bool IsHost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHost, "BmGame.GDLobbySystemSteam.IsHost");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WaitForServerStart;
    /// <summary>
    /// Function: WaitForServerStart
    /// </summary>
    public unsafe virtual void WaitForServerStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WaitForServerStart, "BmGame.GDLobbySystemSteam.WaitForServerStart");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoadoutChanged;
    /// <summary>
    /// Function: OnLoadoutChanged
    /// </summary>
    public unsafe virtual void OnLoadoutChanged(in BmSDK.BmGame.GDLobbySystemSteam.FGDLoadout ChangedLoadout)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoadoutChanged, "BmGame.GDLobbySystemSteam.OnLoadoutChanged");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChangedLoadout, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreloadLocalSkinSelectionReceivedDelegate;
    /// <summary>
    /// Function: PreloadLocalSkinSelectionReceivedDelegate
    /// </summary>
    public unsafe virtual void PreloadLocalSkinSelectionReceivedDelegate(BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId, BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int CharAltMeshIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreloadLocalSkinSelectionReceivedDelegate, "BmGame.GDLobbySystemSteam.PreloadLocalSkinSelectionReceivedDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharAltMeshIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerPlayerAssetsPreloadOnClientsDelegate;
    /// <summary>
    /// Function: TriggerPlayerAssetsPreloadOnClientsDelegate
    /// </summary>
    public unsafe virtual void TriggerPlayerAssetsPreloadOnClientsDelegate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPlayerAssetsPreloadOnClientsDelegate, "BmGame.GDLobbySystemSteam.TriggerPlayerAssetsPreloadOnClientsDelegate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCharAltMeshIndexDelegate;
    /// <summary>
    /// Function: UpdateCharAltMeshIndexDelegate
    /// </summary>
    public unsafe virtual void UpdateCharAltMeshIndexDelegate(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int CharAltMeshIndex, bool ForceReloadPlayableMeshes)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCharAltMeshIndexDelegate, "BmGame.GDLobbySystemSteam.UpdateCharAltMeshIndexDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharAltMeshIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceReloadPlayableMeshes, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMemberCustomizationDelegate;
    /// <summary>
    /// Function: UpdateMemberCustomizationDelegate
    /// </summary>
    public unsafe virtual void UpdateMemberCustomizationDelegate(BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId, BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelectionIndexed> currentCustomizationSets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMemberCustomizationDelegate, "BmGame.GDLobbySystemSteam.UpdateMemberCustomizationDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(currentCustomizationSets, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FGDLoadout
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FGDLoadout
    {
        /// <summary>
        /// StructProperty: PlayerID
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: BaneLevel
        /// </summary>
        public unsafe byte BaneLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: JokerLevel
        /// </summary>
        public unsafe byte JokerLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 9); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9); }; }
        }

        /// <summary>
        /// ByteProperty: PlayerLevel
        /// </summary>
        public unsafe byte PlayerLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 10); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10); }; }
        }

        /// <summary>
        /// ByteProperty: PlayerPrestigeLevel
        /// </summary>
        public unsafe byte PlayerPrestigeLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 11); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11); }; }
        }

        /// <summary>
        /// ByteProperty: BaneEquippedWeapon
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.WeaponId BaneEquippedWeapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.WeaponId>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: JokerEquippedWeapon
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.WeaponId JokerEquippedWeapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.WeaponId>(Ptr + 13); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13); }; }
        }

        /// <summary>
        /// ByteProperty: JokerEquippedWeaponLevel
        /// </summary>
        public unsafe byte JokerEquippedWeaponLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 14); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14); }; }
        }

        /// <summary>
        /// ByteProperty: BaneEquippedWeaponLevel
        /// </summary>
        public unsafe byte BaneEquippedWeaponLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 15); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 15); }; }
        }

        /// <summary>
        /// ByteProperty: BaneWestGadget
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId BaneWestGadget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: BaneEastGadget
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId BaneEastGadget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 17); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17); }; }
        }

        /// <summary>
        /// ByteProperty: JokerWestGadget
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId JokerWestGadget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 18); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18); }; }
        }

        /// <summary>
        /// ByteProperty: JokerEastGadget
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId JokerEastGadget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 19); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19); }; }
        }

        /// <summary>
        /// ByteProperty: PreferredFaction
        /// </summary>
        public unsafe byte PreferredFaction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ByteProperty: BaneWestGadgetUpgrdIdx
        /// </summary>
        public unsafe byte BaneWestGadgetUpgrdIdx
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 21); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21); }; }
        }

        /// <summary>
        /// ByteProperty: BaneEastGadgetUpgrdIdx
        /// </summary>
        public unsafe byte BaneEastGadgetUpgrdIdx
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 22); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22); }; }
        }

        /// <summary>
        /// ByteProperty: JokerWestGadgetUpgrdIdx
        /// </summary>
        public unsafe byte JokerWestGadgetUpgrdIdx
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 23); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 23); }; }
        }

        /// <summary>
        /// ByteProperty: JokerEastGadgetUpgrdIdx
        /// </summary>
        public unsafe byte JokerEastGadgetUpgrdIdx
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: ELobbyFactionType
    /// </summary>
    public enum ELobbyFactionType : byte
    {
        ELobbyFactionType_Hero = 0,
        ELobbyFactionType_Joker = 1,
        ELobbyFactionType_Bane = 2,
        ELobbyFactionType_MAX = 3,
    }

    /// <summary>
    /// Enum: EGDLobbyPacketType
    /// </summary>
    public enum EGDLobbyPacketType : byte
    {
        GDLPT_UpdateMemberCustomizationData = 0,
        GDLPT_Loadout = 1,
        GDLPT_LoadoutList = 2,
        GDLPT_UpdateCharacterAltMeshIndex = 3,
        GDLPT_TriggerPlayerAssetsPreload = 4,
        GDLPT_PreloadLocalSkinSelection = 5,
        GDLPT_UseConsumable = 6,
        GDLPT_ConsumablesInUse = 7,
        GDLPT_ConsumablesStartArbitration = 8,
        GDLPT_UpdatePlayerTeam = 9,
        GDLPT_UpdateNextHeroPlayers = 10,
        GDLPT_RemoveConsumable = 11,
        GDLPT_SetRoundsSinceHero = 12,
        GDLPT_SetHeroOptOutStatus = 13,
        GDLPT_MAX = 14,
    }

    /// <summary>
    /// StrProperty: GameModeBMGameStr
    /// </summary>
    public unsafe BmSDK.FString GameModeBMGameStr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: SteamBeacon
    /// </summary>
    public unsafe BmSDK.BmGame.GDLobbySteamBeacon SteamBeacon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDLobbySteamBeacon>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// IntProperty: CachedSessionIndex
    /// </summary>
    public unsafe int CachedSessionIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: LobbyUI
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_LobbyBaseGame LobbyUI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_LobbyBaseGame>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// FloatProperty: MemberListUpdateTime
    /// </summary>
    public unsafe float MemberListUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// DelegateProperty: SavedTickCallback
    /// </summary>
    public unsafe System.IntPtr SavedTickCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// IntProperty: SavedCountDownTimer
    /// </summary>
    public unsafe int SavedCountDownTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: CheckStartCountdownTimer
    /// </summary>
    public unsafe BmSDK.SDEngine.SDTimer CheckStartCountdownTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDTimer>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ArrayProperty: MemberLoadouts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDLobbySystemSteam.FGDLoadout> MemberLoadouts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDLobbySystemSteam.FGDLoadout>>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ArrayProperty: UpdateMemberCustomizationDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> UpdateMemberCustomizationDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ArrayProperty: UpdateCharAltMeshIndexDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> UpdateCharAltMeshIndexDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ArrayProperty: TriggerPlayerAssetsPreloadOnClientsDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> TriggerPlayerAssetsPreloadOnClientsDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ArrayProperty: PreloadLocalSkinSelectionReceivedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> PreloadLocalSkinSelectionReceivedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// StructProperty: m_BatmanPlayerNetId
    /// </summary>
    public unsafe ref BmSDK.Engine.OnlineSubsystem.FUniqueNetId m_BatmanPlayerNetId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 840);

    /// <summary>
    /// StructProperty: m_RobinPlayerNetId
    /// </summary>
    public unsafe ref BmSDK.Engine.OnlineSubsystem.FUniqueNetId m_RobinPlayerNetId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 848);

    /// <summary>
    /// StructProperty: m_NextRoundBatmanPlayerNetId
    /// </summary>
    public unsafe ref BmSDK.Engine.OnlineSubsystem.FUniqueNetId m_NextRoundBatmanPlayerNetId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 856);

    /// <summary>
    /// StructProperty: m_NextRoundRobinPlayerNetId
    /// </summary>
    public unsafe ref BmSDK.Engine.OnlineSubsystem.FUniqueNetId m_NextRoundRobinPlayerNetId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 864);

    /// <summary>
    /// ByteProperty: GameModeSetting
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameModes GameModeSetting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameModes>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// BoolProperty: LobbyMenuOpen
    /// </summary>
    public unsafe bool LobbyMenuOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 876); }
    }

    /// <summary>
    /// BoolProperty: bDidMigrateFromGame
    /// </summary>
    public unsafe bool bDidMigrateFromGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 876); }
    }

    /// <summary>
    /// BoolProperty: bInviteAccepted
    /// </summary>
    public unsafe bool bInviteAccepted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 876); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForServerStart
    /// </summary>
    public unsafe bool bWaitingForServerStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: PawnConfigInterface
    /// </summary>
    public unsafe BmSDK.BmGame.GDPawnConfigInterfaceBase PawnConfigInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnConfigInterfaceBase>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// DelegateProperty: __UpdateMemberCustomizationDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __UpdateMemberCustomizationDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// DelegateProperty: __UpdateCharAltMeshIndexDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __UpdateCharAltMeshIndexDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// DelegateProperty: __TriggerPlayerAssetsPreloadOnClientsDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __TriggerPlayerAssetsPreloadOnClientsDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// DelegateProperty: __PreloadLocalSkinSelectionReceivedDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __PreloadLocalSkinSelectionReceivedDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoadoutChanged__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoadoutChanged__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }
}
