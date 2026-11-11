#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGameInfo<br/>
/// (size = 1436)
/// (flags = 144736438)
/// </summary>
public partial class RGameInfo : BmSDK.BmGame.RGameInfoBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGameInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGameInfo.
    /// </summary>
    public static RGameInfo DefaultObject => (RGameInfo)StaticClass().DefaultObject;

    internal RGameInfo() { }

    /// <summary>
    /// Constructs a new RGameInfo
    /// </summary>
    public RGameInfo(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGameInfo(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_Is3DTVPresent;
    /// <summary>
    /// Function: Is3DTVPresent
    /// </summary>
    public unsafe virtual bool Is3DTVPresent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Is3DTVPresent, "BmGame.RGameInfo.Is3DTVPresent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HackToLoadAssetsAllTheTimeToSaveDVDSpaceAndStreamingTime;
    /// <summary>
    /// Function: HackToLoadAssetsAllTheTimeToSaveDVDSpaceAndStreamingTime
    /// </summary>
    public unsafe virtual BmSDK.GameObject HackToLoadAssetsAllTheTimeToSaveDVDSpaceAndStreamingTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HackToLoadAssetsAllTheTimeToSaveDVDSpaceAndStreamingTime, "BmGame.RGameInfo.HackToLoadAssetsAllTheTimeToSaveDVDSpaceAndStreamingTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RiddlerIcons_AnyLeftToReveal;
    /// <summary>
    /// Function: RiddlerIcons_AnyLeftToReveal
    /// </summary>
    public unsafe virtual bool RiddlerIcons_AnyLeftToReveal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiddlerIcons_AnyLeftToReveal, "BmGame.RGameInfo.RiddlerIcons_AnyLeftToReveal");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RiddlesLeftSpecificMapCheck;
    /// <summary>
    /// Function: RiddlesLeftSpecificMapCheck
    /// </summary>
    public unsafe virtual bool RiddlesLeftSpecificMapCheck(BmSDK.FString MapName, BmSDK.FString RiddleMapName, bool CWAllow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiddlesLeftSpecificMapCheck, "BmGame.RGameInfo.RiddlesLeftSpecificMapCheck");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RiddleMapName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CWAllow, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_RiddlerIcons_GetIndexListOfClosest;
    /// <summary>
    /// Function: RiddlerIcons_GetIndexListOfClosest
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem> RiddlerIcons_GetIndexListOfClosest(BmSDK.FString MapName, int atX, int atY, int atZ, int MaxWanted)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiddlerIcons_GetIndexListOfClosest, "BmGame.RGameInfo.RiddlerIcons_GetIndexListOfClosest");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxWanted, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem>>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_RiddlerIcons_GetIndexListForNearestToLoc;
    /// <summary>
    /// Function: RiddlerIcons_GetIndexListForNearestToLoc
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem> RiddlerIcons_GetIndexListForNearestToLoc(BmSDK.FString MapName, int atX, int atY, int atZ, int MaxWanted, bool bHiddenOnly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RiddlerIcons_GetIndexListForNearestToLoc, "BmGame.RGameInfo.RiddlerIcons_GetIndexListForNearestToLoc");
        byte* paramsPtr = stackalloc byte[168];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxWanted, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHiddenOnly, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem>>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_SortByIndexDist;
    /// <summary>
    /// Function: SortByIndexDist
    /// </summary>
    public unsafe virtual int SortByIndexDist(BmSDK.BmGame.RGameInfo.FIndexDistItem A, BmSDK.BmGame.RGameInfo.FIndexDistItem B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortByIndexDist, "BmGame.RGameInfo.SortByIndexDist");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ToggleDebugCamera;
    /// <summary>
    /// Function: ToggleDebugCamera
    /// </summary>
    public unsafe virtual void ToggleDebugCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleDebugCamera, "BmGame.RGameInfo.ToggleDebugCamera");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnregisterHelicopter;
    /// <summary>
    /// Function: UnregisterHelicopter
    /// </summary>
    public unsafe virtual void UnregisterHelicopter(BmSDK.BmGame.RHelicopterBase OldHeli)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterHelicopter, "BmGame.RGameInfo.UnregisterHelicopter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldHeli, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterHelicopter;
    /// <summary>
    /// Function: RegisterHelicopter
    /// </summary>
    public unsafe virtual void RegisterHelicopter(BmSDK.BmGame.RHelicopterBase NewHeli)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterHelicopter, "BmGame.RGameInfo.RegisterHelicopter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewHeli, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateObjectiveMarkerVisibility;
    /// <summary>
    /// Function: UpdateObjectiveMarkerVisibility
    /// </summary>
    public unsafe virtual void UpdateObjectiveMarkerVisibility()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateObjectiveMarkerVisibility, "BmGame.RGameInfo.UpdateObjectiveMarkerVisibility");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateObjectiveMarker;
    /// <summary>
    /// Function: ActivateObjectiveMarker
    /// </summary>
    public unsafe virtual void ActivateObjectiveMarker(BmSDK.FName roomName, bool show)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateObjectiveMarker, "BmGame.RGameInfo.ActivateObjectiveMarker");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(roomName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldSpawnAtStartSpot;
    /// <summary>
    /// Function: ShouldSpawnAtStartSpot
    /// </summary>
    public unsafe override bool ShouldSpawnAtStartSpot(BmSDK.Engine.Controller Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSpawnAtStartSpot, "BmGame.RGameInfo.ShouldSpawnAtStartSpot");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_EndGame;
    /// <summary>
    /// Function: EndGame
    /// </summary>
    public unsafe override void EndGame(BmSDK.Engine.PlayerReplicationInfo Winner, BmSDK.FString Reason)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndGame, "BmGame.RGameInfo.EndGame");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RoundEnded;
    /// <summary>
    /// Function: RoundEnded
    /// </summary>
    public unsafe virtual void RoundEnded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RoundEnded, "BmGame.RGameInfo.RoundEnded");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RatePlayerStart;
    /// <summary>
    /// Function: RatePlayerStart
    /// </summary>
    public unsafe override float RatePlayerStart(BmSDK.Engine.PlayerStart P, byte Team, BmSDK.Engine.Controller Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RatePlayerStart, "BmGame.RGameInfo.RatePlayerStart");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PostLogin;
    /// <summary>
    /// Function: PostLogin
    /// </summary>
    public unsafe override void PostLogin(BmSDK.Engine.PlayerController NewPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostLogin, "BmGame.RGameInfo.PostLogin");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleSeamlessTravelPlayer, "BmGame.RGameInfo.HandleSeamlessTravelPlayer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out C);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        C = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Controller>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_HandleLobby;
    /// <summary>
    /// Function: HandleLobby
    /// </summary>
    public unsafe virtual void HandleLobby(BmSDK.BmGame.RPlayerController LobbyPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleLobby, "BmGame.RGameInfo.HandleLobby");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowLobby;
    /// <summary>
    /// Function: ShowLobby
    /// </summary>
    public unsafe virtual bool ShowLobby(BmSDK.BmGame.RPlayerController LobbyTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowLobby, "BmGame.RGameInfo.ShowLobby");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Game_ExitToFrontend;
    /// <summary>
    /// Function: Game_ExitToFrontend
    /// </summary>
    public unsafe virtual void Game_ExitToFrontend()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Game_ExitToFrontend, "BmGame.RGameInfo.Game_ExitToFrontend");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Game_PauseExitToFrontend;
    /// <summary>
    /// Function: Game_PauseExitToFrontend
    /// </summary>
    public unsafe virtual void Game_PauseExitToFrontend()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Game_PauseExitToFrontend, "BmGame.RGameInfo.Game_PauseExitToFrontend");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Game_Retry;
    /// <summary>
    /// Function: Game_Retry
    /// </summary>
    public unsafe virtual void Game_Retry()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Game_Retry, "BmGame.RGameInfo.Game_Retry");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Game_Restart;
    /// <summary>
    /// Function: Game_Restart
    /// </summary>
    public unsafe virtual void Game_Restart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Game_Restart, "BmGame.RGameInfo.Game_Restart");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Game_ExitGame;
    /// <summary>
    /// Function: Game_ExitGame
    /// </summary>
    public unsafe virtual void Game_ExitGame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Game_ExitGame, "BmGame.RGameInfo.Game_ExitGame");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Game_Continue;
    /// <summary>
    /// Function: Game_Continue
    /// </summary>
    public unsafe virtual void Game_Continue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Game_Continue, "BmGame.RGameInfo.Game_Continue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Game_StartGameAt;
    /// <summary>
    /// Function: Game_StartGameAt
    /// </summary>
    public unsafe virtual void Game_StartGameAt(BmSDK.FString AtName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Game_StartGameAt, "BmGame.RGameInfo.Game_StartGameAt");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AtName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDefaultPlayerClass;
    /// <summary>
    /// Function: GetDefaultPlayerClass
    /// </summary>
    public unsafe override BmSDK.Class GetDefaultPlayerClass(BmSDK.Engine.Controller C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultPlayerClass, "BmGame.RGameInfo.GetDefaultPlayerClass");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPlayerCharacterIndex;
    /// <summary>
    /// Function: GetPlayerCharacterIndex
    /// </summary>
    public unsafe virtual int GetPlayerCharacterIndex(BmSDK.Engine.Controller C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerCharacterIndex, "BmGame.RGameInfo.GetPlayerCharacterIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnDefaultPawnFor;
    /// <summary>
    /// Function: SpawnDefaultPawnFor
    /// </summary>
    public unsafe override BmSDK.Engine.Pawn SpawnDefaultPawnFor(BmSDK.Engine.Controller NewPlayer, BmSDK.Engine.NavigationPoint StartSpot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDefaultPawnFor, "BmGame.RGameInfo.SpawnDefaultPawnFor");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartSpot, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Pawn>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ProcessServerLogin;
    /// <summary>
    /// Function: ProcessServerLogin
    /// </summary>
    public unsafe override bool ProcessServerLogin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessServerLogin, "BmGame.RGameInfo.ProcessServerLogin");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetURLParam;
    /// <summary>
    /// Function: GetURLParam
    /// </summary>
    public unsafe virtual BmSDK.FString GetURLParam(BmSDK.FString Named)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetURLParam, "BmGame.RGameInfo.GetURLParam");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Named, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_HasURLParam;
    /// <summary>
    /// Function: HasURLParam
    /// </summary>
    public unsafe virtual bool HasURLParam(BmSDK.FString Named)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasURLParam, "BmGame.RGameInfo.HasURLParam");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Named, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetGameTimePlayedString;
    /// <summary>
    /// Function: GetGameTimePlayedString
    /// </summary>
    public unsafe override BmSDK.FString GetGameTimePlayedString()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameTimePlayedString, "BmGame.RGameInfo.GetGameTimePlayedString");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGameTimePlayed;
    /// <summary>
    /// Function: GetGameTimePlayed
    /// </summary>
    public unsafe override float GetGameTimePlayed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameTimePlayed, "BmGame.RGameInfo.GetGameTimePlayed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsKingOfTheHill;
    /// <summary>
    /// Function: IsKingOfTheHill
    /// </summary>
    public unsafe virtual bool IsKingOfTheHill()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsKingOfTheHill, "BmGame.RGameInfo.IsKingOfTheHill");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsFrontend;
    /// <summary>
    /// Function: IsFrontend
    /// </summary>
    public unsafe virtual bool IsFrontend()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFrontend, "BmGame.RGameInfo.IsFrontend");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsChallengeMode;
    /// <summary>
    /// Function: IsChallengeMode
    /// </summary>
    public unsafe virtual bool IsChallengeMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsChallengeMode, "BmGame.RGameInfo.IsChallengeMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsStoryMode;
    /// <summary>
    /// Function: IsStoryMode
    /// </summary>
    public unsafe virtual bool IsStoryMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStoryMode, "BmGame.RGameInfo.IsStoryMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPredatorChaseTime;
    /// <summary>
    /// Function: GetPredatorChaseTime
    /// </summary>
    public unsafe virtual float GetPredatorChaseTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPredatorChaseTime, "BmGame.RGameInfo.GetPredatorChaseTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateGameWindConfig;
    /// <summary>
    /// Function: UpdateGameWindConfig
    /// </summary>
    public unsafe virtual void UpdateGameWindConfig(BmSDK.BmGame.RGameInfo.FRBasicWindConfig NewWind)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGameWindConfig, "BmGame.RGameInfo.UpdateGameWindConfig");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWind, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpAllNav;
    /// <summary>
    /// Function: DumpAllNav
    /// </summary>
    public unsafe virtual void DumpAllNav()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpAllNav, "BmGame.RGameInfo.DumpAllNav");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWindAtPoint;
    /// <summary>
    /// Function: GetWindAtPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetWindAtPoint(System.Numerics.Vector3 ObjectPosition, System.Numerics.Vector3 ObjectVelocity)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWindAtPoint, "BmGame.RGameInfo.GetWindAtPoint");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectVelocity, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_UpdateGlobalWind;
    /// <summary>
    /// Function: UpdateGlobalWind
    /// </summary>
    public unsafe virtual void UpdateGlobalWind(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGlobalWind, "BmGame.RGameInfo.UpdateGlobalWind");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RGameInfo.Tick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSpawnPawn;
    /// <summary>
    /// Function: CanSpawnPawn
    /// </summary>
    public unsafe virtual bool CanSpawnPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSpawnPawn, "BmGame.RGameInfo.CanSpawnPawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PawnSpawned;
    /// <summary>
    /// Function: PawnSpawned
    /// </summary>
    public unsafe virtual void PawnSpawned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnSpawned, "BmGame.RGameInfo.PawnSpawned");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_Killed;
    /// <summary>
    /// Function: Killed
    /// </summary>
    public unsafe override void Killed(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Killed, "BmGame.RGameInfo.Killed");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GoStartMatch;
    /// <summary>
    /// Function: GoStartMatch
    /// </summary>
    public unsafe virtual void GoStartMatch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoStartMatch, "BmGame.RGameInfo.GoStartMatch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlayerPawn;
    /// <summary>
    /// Function: GetPlayerPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer GetPlayerPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerPawn, "BmGame.RGameInfo.GetPlayerPawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetPlayerStartPoints;
    /// <summary>
    /// Function: ResetPlayerStartPoints
    /// </summary>
    public unsafe virtual void ResetPlayerStartPoints()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPlayerStartPoints, "BmGame.RGameInfo.ResetPlayerStartPoints");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckToStartMatch;
    /// <summary>
    /// Function: CheckToStartMatch
    /// </summary>
    public unsafe virtual void CheckToStartMatch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckToStartMatch, "BmGame.RGameInfo.CheckToStartMatch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TimedStartGame;
    /// <summary>
    /// Function: TimedStartGame
    /// </summary>
    public unsafe virtual void TimedStartGame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimedStartGame, "BmGame.RGameInfo.TimedStartGame");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLevelChange;
    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe virtual void OnLevelChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLevelChange, "BmGame.RGameInfo.OnLevelChange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreCommitMapChange;
    /// <summary>
    /// Function: PreCommitMapChange
    /// </summary>
    public unsafe override void PreCommitMapChange(BmSDK.FString PreviousMapName, BmSDK.FString NextMapName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreCommitMapChange, "BmGame.RGameInfo.PreCommitMapChange");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousMapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextMapName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsCombatChallenge;
    /// <summary>
    /// Function: IsCombatChallenge
    /// </summary>
    public unsafe virtual bool IsCombatChallenge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCombatChallenge, "BmGame.RGameInfo.IsCombatChallenge");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateStatsLogging;
    /// <summary>
    /// Function: CreateStatsLogging
    /// </summary>
    public unsafe virtual void CreateStatsLogging()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateStatsLogging, "BmGame.RGameInfo.CreateStatsLogging");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostCommitMapChange;
    /// <summary>
    /// Function: PostCommitMapChange
    /// </summary>
    public unsafe override void PostCommitMapChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostCommitMapChange, "BmGame.RGameInfo.PostCommitMapChange");
        byte* paramsPtr = stackalloc byte[16];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreBeginPlay, "BmGame.RGameInfo.PreBeginPlay");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowCheats;
    /// <summary>
    /// Function: AllowCheats
    /// </summary>
    public unsafe virtual bool AllowCheats(BmSDK.Engine.PlayerController P)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowCheats, "BmGame.RGameInfo.AllowCheats");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDifficulty;
    /// <summary>
    /// Function: GetDifficulty
    /// </summary>
    public unsafe virtual int GetDifficulty()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDifficulty, "BmGame.RGameInfo.GetDifficulty");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WaitToBankXP;
    /// <summary>
    /// Function: WaitToBankXP
    /// </summary>
    public unsafe virtual bool WaitToBankXP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WaitToBankXP, "BmGame.RGameInfo.WaitToBankXP");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsCurrentPredZoneAlerted;
    /// <summary>
    /// Function: IsCurrentPredZoneAlerted
    /// </summary>
    public unsafe virtual bool IsCurrentPredZoneAlerted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCurrentPredZoneAlerted, "BmGame.RGameInfo.IsCurrentPredZoneAlerted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindProjectileArc;
    /// <summary>
    /// Function: FindProjectileArc
    /// </summary>
    public unsafe virtual bool FindProjectileArc(BmSDK.Engine.Actor TraceActor, out System.Numerics.Vector3 ThrowVelocity, out float FlightTime, System.Numerics.Vector3 StartPoint, System.Numerics.Vector3 Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindProjectileArc, "BmGame.RGameInfo.FindProjectileArc");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceActor, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThrowVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowVelocity, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FlightTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlightTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThrowVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        FlightTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_SecuROMProtectionCheck4;
    /// <summary>
    /// Function: SecuROMProtectionCheck4
    /// </summary>
    public unsafe virtual int SecuROMProtectionCheck4(int A, int B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SecuROMProtectionCheck4, "BmGame.RGameInfo.SecuROMProtectionCheck4");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SecuROMProtectionCheck3;
    /// <summary>
    /// Function: SecuROMProtectionCheck3
    /// </summary>
    public unsafe virtual int SecuROMProtectionCheck3()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SecuROMProtectionCheck3, "BmGame.RGameInfo.SecuROMProtectionCheck3");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SecuROMProtectionCheck2;
    /// <summary>
    /// Function: SecuROMProtectionCheck2
    /// </summary>
    public unsafe virtual bool SecuROMProtectionCheck2()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SecuROMProtectionCheck2, "BmGame.RGameInfo.SecuROMProtectionCheck2");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SecuROMProtectionCheck1;
    /// <summary>
    /// Function: SecuROMProtectionCheck1
    /// </summary>
    public unsafe virtual bool SecuROMProtectionCheck1()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SecuROMProtectionCheck1, "BmGame.RGameInfo.SecuROMProtectionCheck1");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLanguageForScriptCode;
    /// <summary>
    /// Function: GetLanguageForScriptCode
    /// </summary>
    public unsafe virtual BmSDK.FString GetLanguageForScriptCode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLanguageForScriptCode, "BmGame.RGameInfo.GetLanguageForScriptCode");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPlyrPawn;
    /// <summary>
    /// Function: GetPlyrPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer GetPlyrPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlyrPawn, "BmGame.RGameInfo.GetPlyrPawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPC;
    /// <summary>
    /// Function: GetPC
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPlayerController GetPC()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPC, "BmGame.RGameInfo.GetPC");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPlayerController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumLocalPlayers;
    /// <summary>
    /// Function: GetNumLocalPlayers
    /// </summary>
    public unsafe virtual int GetNumLocalPlayers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumLocalPlayers, "BmGame.RGameInfo.GetNumLocalPlayers");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLevelVolumeFor;
    /// <summary>
    /// Function: GetLevelVolumeFor
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RLevelVolume GetLevelVolumeFor(BmSDK.GameObject Obj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLevelVolumeFor, "BmGame.RGameInfo.GetLevelVolumeFor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obj, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RLevelVolume>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetStoryIndex;
    /// <summary>
    /// Function: GetStoryIndex
    /// </summary>
    public unsafe virtual int GetStoryIndex(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStoryIndex, "BmGame.RGameInfo.GetStoryIndex");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsStoryPresent;
    /// <summary>
    /// Function: IsStoryPresent
    /// </summary>
    public unsafe virtual bool IsStoryPresent(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStoryPresent, "BmGame.RGameInfo.IsStoryPresent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetStoryCount;
    /// <summary>
    /// Function: GetStoryCount
    /// </summary>
    public unsafe virtual int GetStoryCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStoryCount, "BmGame.RGameInfo.GetStoryCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetIsSaveInProgress;
    /// <summary>
    /// Function: GetIsSaveInProgress
    /// </summary>
    public unsafe virtual bool GetIsSaveInProgress()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIsSaveInProgress, "BmGame.RGameInfo.GetIsSaveInProgress");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSaveGameSize;
    /// <summary>
    /// Function: GetSaveGameSize
    /// </summary>
    public unsafe virtual int GetSaveGameSize()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSaveGameSize, "BmGame.RGameInfo.GetSaveGameSize");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsDLCInstalled;
    /// <summary>
    /// Function: IsDLCInstalled
    /// </summary>
    public unsafe virtual bool IsDLCInstalled(BmSDK.FString DLCBundleName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDLCInstalled, "BmGame.RGameInfo.IsDLCInstalled");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DLCBundleName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Struct: FStoryDLCItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FStoryDLCItem
    {
        /// <summary>
        /// IntProperty: PackId
        /// </summary>
        public unsafe int PackId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: PersistentSaveSlotId
        /// </summary>
        public unsafe int PersistentSaveSlotId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: BaseCharacter
        /// </summary>
        public unsafe BmSDK.FString BaseCharacter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: NewGameStart
        /// </summary>
        public unsafe BmSDK.FString NewGameStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FMapElementsItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FMapElementsItem
    {
        /// <summary>
        /// StrProperty: ItemType
        /// </summary>
        public unsafe BmSDK.FString ItemType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ItemSubType
        /// </summary>
        public unsafe BmSDK.FString ItemSubType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: ItemName
        /// </summary>
        public unsafe BmSDK.FString ItemName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: X
        /// </summary>
        public unsafe int X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: Y
        /// </summary>
        public unsafe int Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: Z
        /// </summary>
        public unsafe int Z
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Struct: FMapElements
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FMapElements
    {
        /// <summary>
        /// StrProperty: MapName
        /// </summary>
        public unsafe BmSDK.FString MapName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Base
        /// </summary>
        public unsafe int Base
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Count
        /// </summary>
        public unsafe int Count
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FIndexDistItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FIndexDistItem
    {
        /// <summary>
        /// IntProperty: Index
        /// </summary>
        public unsafe int Index
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Distance
        /// </summary>
        public unsafe float Distance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FMapHackOWLoc
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FMapHackOWLoc
    {
        /// <summary>
        /// StrProperty: SubName
        /// </summary>
        public unsafe BmSDK.FString SubName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: X
        /// </summary>
        public unsafe int X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Y
        /// </summary>
        public unsafe int Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Z
        /// </summary>
        public unsafe int Z
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: SubX
        /// </summary>
        public unsafe int SubX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: SubY
        /// </summary>
        public unsafe int SubY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: SubZ
        /// </summary>
        public unsafe int SubZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: Distance
        /// </summary>
        public unsafe float Distance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StrProperty: FlagCheck
        /// </summary>
        public unsafe BmSDK.FString FlagCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FMapItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 124)]
    public partial record struct FMapItem
    {
        /// <summary>
        /// StrProperty: Row
        /// </summary>
        public unsafe BmSDK.FString Row
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: PackId
        /// </summary>
        public unsafe int PackId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: SId
        /// </summary>
        public unsafe int SId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: Mask1
        /// </summary>
        public unsafe int Mask1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: Mask2
        /// </summary>
        public unsafe int Mask2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: RFCMask
        /// </summary>
        public unsafe int RFCMask
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StrProperty: ScriptRef
        /// </summary>
        public unsafe BmSDK.FString ScriptRef
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StrProperty: Start
        /// </summary>
        public unsafe BmSDK.FString Start
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: bPredator
        /// </summary>
        public unsafe bool bPredator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bNotCustom
        /// </summary>
        public unsafe bool bNotCustom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// ArrayProperty: Modifiers
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers> Modifiers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers>>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// ArrayProperty: CampaignEntry
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapCampaignEntry> CampaignEntry
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapCampaignEntry>>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// ArrayProperty: DefaultChallengeScores
        /// </summary>
        public unsafe BmSDK.TArray<int> DefaultChallengeScores
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// ArrayProperty: DefaultChallengeActions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> DefaultChallengeActions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }
    }

    /// <summary>
    /// Struct: FMapCampaignEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FMapCampaignEntry
    {
        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: EStasisLevel
    /// </summary>
    public enum EStasisLevel : byte
    {
        STASISLEVEL_Normal = 0,
        STASISLEVEL_Cheap = 1,
        STASISLEVEL_SuperCheap = 2,
        STASISLEVEL_MAX = 3,
    }

    /// <summary>
    /// Struct: FFloorCorrectionConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FFloorCorrectionConfig
    {
        /// <summary>
        /// StructProperty: Standing
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig Standing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Moving
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig Moving
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: OnCeiling
        /// </summary>
        public unsafe bool OnCeiling
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: CatwomanCrawlingHack
        /// </summary>
        public unsafe bool CatwomanCrawlingHack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FFloorMovementCorrectionConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FFloorMovementCorrectionConfig
    {
        /// <summary>
        /// FloatProperty: Along
        /// </summary>
        public unsafe float Along
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Up
        /// </summary>
        public unsafe float Up
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Down
        /// </summary>
        public unsafe float Down
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: Orientation
        /// </summary>
        public unsafe float Orientation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: OrientationPivotZ
        /// </summary>
        public unsafe float OrientationPivotZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FRWindState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FRWindState
    {
        /// <summary>
        /// StructProperty: WindVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 WindVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: SourceVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 SourceVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: SourceAcceleration
        /// </summary>
        public unsafe System.Numerics.Vector3 SourceAcceleration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: TargetVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: TargetAcceleration
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetAcceleration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: TotalInterpolationTime
        /// </summary>
        public unsafe float TotalInterpolationTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: RemainingInterpolationTime
        /// </summary>
        public unsafe float RemainingInterpolationTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Struct: FRWindConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FRWindConfig
    {
        /// <summary>
        /// BoolProperty: IsApplyWind
        /// </summary>
        public unsafe bool IsApplyWind
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: WindVelocityCentre
        /// </summary>
        public unsafe System.Numerics.Vector3 WindVelocityCentre
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: WindVelocityRadius
        /// </summary>
        public unsafe float WindVelocityRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: MaxWindAccelerationRadius
        /// </summary>
        public unsafe float MaxWindAccelerationRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: MinTargetChangePeriod
        /// </summary>
        public unsafe float MinTargetChangePeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: MaxTargetChangePeriod
        /// </summary>
        public unsafe float MaxTargetChangePeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: WindForceCoefficient
        /// </summary>
        public unsafe float WindForceCoefficient
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FRBasicWindConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FRBasicWindConfig
    {
        /// <summary>
        /// BoolProperty: IsApplyWind
        /// </summary>
        public unsafe bool IsApplyWind
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: WindDirection
        /// </summary>
        public unsafe System.Numerics.Vector3 WindDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: WindBlusteryness
        /// </summary>
        public unsafe float WindBlusteryness
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Enum: ThugResponseType
    /// </summary>
    public enum ThugResponseType : byte
    {
        TRS_None = 0,
        TRS_Ambient = 1,
        TRS_MAX = 2,
    }

    /// <summary>
    /// Enum: GameCombatCameraType
    /// </summary>
    public enum GameCombatCameraType : byte
    {
        GCCT_BrawlComatCamera = 0,
        GCCT_CorridorCombatCamera = 1,
        GCCT_HighCombatCamera = 2,
        GCCT_MAX = 3,
    }

    /// <summary>
    /// Struct: FSoundSurface
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FSoundSurface
    {
        /// <summary>
        /// ObjectProperty: SurfaceType
        /// </summary>
        public unsafe BmSDK.Engine.AkSwitchName SurfaceType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: CameraLookAtSpeed
    /// </summary>
    public enum CameraLookAtSpeed : byte
    {
        CLASP_Slow = 0,
        CLASP_Fast = 1,
        CLASP_VeryFast = 2,
        CLASP_VerySlow = 3,
        CLASP_MAX = 4,
    }

    /// <summary>
    /// Enum: CameraLookAtStrength
    /// </summary>
    public enum CameraLookAtStrength : byte
    {
        CLAS_ForceCamera = 0,
        CLAS_ForceUntilLookAtNeutral = 1,
        CLAS_LookAtWeakNoDrag = 2,
        CLAS_LookAtWeak = 3,
        CLAS_MAX = 4,
    }

    /// <summary>
    /// Enum: CameraLookAtType
    /// </summary>
    public enum CameraLookAtType : byte
    {
        CLAT_NoLookAt = 0,
        CLAT_LookAtRotation = 1,
        CLAT_LookAtLocation = 2,
        CLAT_LookAtActor = 3,
        CLAT_MAX = 4,
    }

    /// <summary>
    /// Enum: ECombatLockType
    /// </summary>
    public enum ECombatLockType : byte
    {
        ECLT_None = 0,
        ECLT_Thugs = 1,
        ECLT_Lunatics = 2,
        ECLT_MAX = 3,
    }

    /// <summary>
    /// Enum: EChallengeModifiers
    /// </summary>
    public enum EChallengeModifiers : byte
    {
        CMod_None = 0,
        CMod_Neg_ExtremeEnemies = 1,
        CMod_Neg_TimeLimit = 2,
        CMod_Neg_IncreasedAggression = 3,
        CMod_Neg_DecreasedHealth = 4,
        CMod_Neg_ProtectiveAura = 5,
        CMod_Neg_DangerZones = 6,
        CMod_Neg_OneHandTied = 7,
        CMod_Neg_ScatteredWeapons = 8,
        CMod_Pos_ReplenishingHealth = 9,
        CMod_Pos_TakedownProjectiles = 10,
        CMod_Pos_SuperPowered = 11,
        CMod_Pos_FreeMedal = 12,
        CMod_MAX = 13,
    }

    /// <summary>
    /// Enum: EChallengeModifierType
    /// </summary>
    public enum EChallengeModifierType : byte
    {
        EChallengeModifier_None = 0,
        EChallengeModifier_Example1 = 1,
        EChallengeModifier_Example2 = 2,
        EChallengeModifier_MAX = 3,
    }

    /// <summary>
    /// Enum: EChallengeCharacter
    /// </summary>
    public enum EChallengeCharacter : byte
    {
        ECCID_Batman = 0,
        ECCID_BatmanArmoured = 1,
        ECCID_Joker = 2,
        ECCID_MAX = 3,
    }

    /// <summary>
    /// Enum: EChallengeMode
    /// </summary>
    public enum EChallengeMode : byte
    {
        ECMID_Combat = 0,
        ECMID_CombatEndurance = 1,
        ECMID_Predator = 2,
        ECMID_MAX = 3,
    }

    /// <summary>
    /// Enum: EAchievementID
    /// </summary>
    public enum EAchievementID : byte
    {
        EACID_None = 0,
        EACID_Im_Batman = 1,
        EACID_Saved_Catwoman = 2,
        EACID_Saved_Church_Hostages = 3,
        EACID_Get_in_steelmill = 4,
        EACID_Defeated_Lieutenant = 5,
        EACID_Shut_off_Jammers = 6,
        EACID_Gladiator_Pit = 7,
        EACID_Defeated_Grundy = 8,
        EACID_Entered_WonderCity = 9,
        EACID_Defeated_Ras = 10,
        EACID_Defeated_Freeze = 11,
        EACID_Got_Beaten_by_Joker = 12,
        EACID_Confronted_Strange = 13,
        EACID_Defeated_Clayface = 14,
        EACID_Deadshot_Stash = 15,
        EACID_Stopped_Deadshot = 16,
        EACID_Stopped_Hush = 17,
        EACID_Competed_Azrael = 18,
        EACID_Found_Bane = 19,
        EACID_Stopped_Bane = 20,
        EACID_Zsasz_Phone = 21,
        EACID_Stopped_Zsasz = 22,
        EACID_Stopped_Mad_Hatter = 23,
        EACID_Saved_Nora = 24,
        EACID_Complete_AR = 25,
        EACID_All_Gadgets = 26,
        EACID_Save_All_Bullies = 27,
        EACID_Riddler_Church = 28,
        EACID_Riddler_Room_1 = 29,
        EACID_Riddler_Room_2 = 30,
        EACID_Riddler_Room_3 = 31,
        EACID_Riddler_Room_4 = 32,
        EACID_Riddler_Room_5 = 33,
        EACID_Stopped_Riddler = 34,
        EACID_Ranked_Challenges_All_Bronze = 35,
        EACID_Ranked_Challenges_All_Silver = 36,
        EACID_Ranked_Challenges_All_Gold = 37,
        EACID_Campaigns_All_Bronze = 38,
        EACID_Campaigns_All_Silver = 39,
        EACID_Campaigns_All_Gold = 40,
        EACID_Flawless_Freeflow_Fighter = 41,
        EACID_New_Game_PLUS = 42,
        EACID_5_Times_Around_Tower = 43,
        EACID_Pay_Respects = 44,
        EACID_12_Calendar_Stories = 45,
        EACID_Azrael_Catch = 46,
        EACID_40_Combo = 47,
        EACID_Perfect_Freeflow = 48,
        EACID_5_Gadgets_Fight = 49,
        EACID_Perfect_Knight = 50,
        EACID_CW_Steal_Two_Face = 51,
        EACID_CW_Ivy = 52,
        EACID_CW_Tyger_vault = 53,
        EACID_CW_Loot = 54,
        EACID_CW_Ranked_Challenges_All_Gold = 55,
        EACID_CW_Campaigns_All_Gold = 56,
        EACID_ROBIN_Ranked_Challenges_All_Gold = 57,
        EACID_ROBIN_Campaigns_All_Gold = 58,
        EACID_NW_Ranked_Challenges_All_Gold = 59,
        EACID_NW_Campaigns_All_Gold = 60,
        EACID_MAX = 61,
    }

    /// <summary>
    /// Enum: SContexts
    /// </summary>
    public enum SContexts : byte
    {
        SContexts_OVERWORLD = 0,
        SContexts_COURT = 1,
        SContexts_CHURCH = 2,
        SContexts_STEEL = 3,
        SContexts_MUSEUM = 4,
        SContexts_UNDERWORLD = 5,
        SContexts_GCPD = 6,
        SContexts_RIDDLER = 7,
        SContexts_IVYLAIR = 8,
        SContexts_CW = 9,
        SContexts_ZSASZ = 10,
        SContexts_NORA = 11,
        SContexts_MADHATTER = 12,
        SContexts_BANE = 13,
        SContexts_HUSH = 14,
        SContexts_MAX = 15,
    }

    /// <summary>
    /// Enum: EContexts
    /// </summary>
    public enum EContexts : byte
    {
        EContexts_CHALLENGE = 0,
        EContexts_Nothing0 = 1,
        EContexts_CHALLENGETYPE = 2,
        EContexts_Nothing1 = 3,
        EContexts_Nothing2 = 4,
        EContexts_MatchType = 5,
        EContexts_MatchMap = 6,
        EContexts_STORYTYPE = 7,
        EContexts_Frontend = 8,
        EContexts_MAX = 9,
    }

    /// <summary>
    /// Enum: EPresenceID
    /// </summary>
    public enum EPresenceID : byte
    {
        EPresence_Idle = 0,
        EPresence_Frontend = 1,
        EPresence_Story = 2,
        EPresence_Challenge = 3,
        EPresence_Multiplayer = 4,
        EPresence_MAX = 5,
    }

    /// <summary>
    /// Enum: EFrontendContexts
    /// </summary>
    public enum EFrontendContexts : byte
    {
        EFC_Menu = 0,
        EFC_TrophyRoom = 1,
        EFC_Credits = 2,
        EFC_Waynetech = 3,
        EFC_MAX = 4,
    }

    /// <summary>
    /// Enum: EMatchMapsContexts
    /// </summary>
    public enum EMatchMapsContexts : byte
    {
        EMMC_ChemPlant = 0,
        EMMC_BlackGate = 1,
        EMMC_Funhouse = 2,
        EMMC_RobotFactory = 3,
        EMMC_MAX = 4,
    }

    /// <summary>
    /// Enum: EMatchTypeContexts
    /// </summary>
    public enum EMatchTypeContexts : byte
    {
        EMTC_InvisiblePredator = 0,
        EMTC_HunterHunted = 1,
        EMTC_MAX = 2,
    }

    /// <summary>
    /// Enum: EComboMoveType
    /// </summary>
    public enum EComboMoveType : byte
    {
        ECMT_Strike = 0,
        ECMT_PowerStrike = 1,
        ECMT_Counter = 2,
        ECMT_Stun = 3,
        ECMT_SuperStun = 4,
        ECMT_Evade = 5,
        ECMT_Redirect = 6,
        ECMT_ProjectileCounter = 7,
        ECMT_AerialAttack = 8,
        ECMT_DirectedAerialAttack = 9,
        ECMT_GroundTakedown = 10,
        ECMT_BeatdownStart = 11,
        ECMT_BeatdownStrike = 12,
        ECMT_BeatdownFinish = 13,
        ECMT_BladeComboCounter = 14,
        ECMT_SuperBladeComboCounter = 15,
        ECMT_ElectricFloor = 16,
        ECMT_TitanStrike = 17,
        ECMT_TitanRideStrike = 18,
        ECMT_TitanRideShockwave = 19,
        ECMT_TitanRideCharge = 20,
        ECMT_TitanFinish = 21,
        ECMT_TitanBerserk = 22,
        ECMT_LieutenantFinish = 23,
        ECMT_Takedown = 24,
        ECMT_Batarang = 25,
        ECMT_Batclaw = 26,
        ECMT_BatclawSlam = 27,
        ECMT_SmokePellet = 28,
        ECMT_REC = 29,
        ECMT_Freeze = 30,
        ECMT_Gel = 31,
        ECMT_BMDisarmAndDestroy = 32,
        ECMT_BMBatswarm = 33,
        ECMT_BMGroupGroundKO = 34,
        ECMT_CWProjectile = 35,
        ECMT_CWBullwhip = 36,
        ECMT_CWGroupTrip = 37,
        ECMT_CWGroupAttack = 38,
        ECMT_CWCaltrops = 39,
        ECMT_RBProjectile = 40,
        ECMT_RBStickyBomb = 41,
        ECMT_RBZipKick = 42,
        ECMT_RBShieldCharge = 43,
        ECMT_RBThrow = 44,
        ECMT_RBThrowRingOut = 45,
        ECMT_RBThrowKnockdown = 46,
        ECMT_RBGroupAttack = 47,
        ECMT_NWProjectile = 48,
        ECMT_NWGroupElectrify = 49,
        ECMT_NWGroupAttack = 50,
        ECMT_NWGroupStun = 51,
        ECMT_NWDart = 52,
        ECMT_NWDartHeadShot = 53,
        ECMT_NWStick = 54,
        ECMT_Slide = 55,
        ECMT_MAX = 56,
    }

    /// <summary>
    /// Enum: RagdollStunType
    /// </summary>
    public enum RagdollStunType : byte
    {
        RAGSTUN_Generic = 0,
        RAGSTUN_Batarang = 1,
        RAGSTUN_BatClaw = 2,
        RAGSTUN_GlideKick = 3,
        RAGSTUN_LineLaunchKick = 4,
        RAGSTUN_SwingKick = 5,
        RAGSTUN_Throw = 6,
        RAGSTUN_PounceAttack = 7,
        RAGSTUN_CaltropsTrap = 8,
        RAGSTUN_BoomerangBatarang = 9,
        RAGSTUN_DropAttack = 10,
        RAGSTUN_GelWeaponCrate = 11,
        RAGSTUN_SlideAttack = 12,
        RAGSTUN_GlideBoostTackle = 13,
        RAGSTUN_ControllableBatarang = 14,
        RAGSTUN_GelMine = 15,
        RAGSTUN_RECArmouredBlast = 16,
        RAGSTUN_RicochetStick = 17,
        RAGSTUN_ElectroBlast = 18,
        RAGSTUN_WristDart = 19,
        RAGSTUN_ShieldBash = 20,
        RAGSTUN_ShieldBlockAndBash = 21,
        RAGSTUN_ZipKick = 22,
        RAGSTUN_StickyBomb = 23,
        RAGSTUN_RasFade = 24,
        RAGSTUN_WhipTrip = 25,
        RAGSTUN_FreezeLadder = 26,
        RAGSTUN_IceThugPush = 27,
        RAGSTUN_MAX = 28,
    }

    /// <summary>
    /// Enum: EGameAction
    /// </summary>
    public enum EGameAction : byte
    {
        GA_None = 0,
        GA_Takedown_CombatTakedown = 1,
        GA_Takedown_CombatRedirect = 2,
        GA_Takedown_CombatRailing = 3,
        GA_Takedown_CombatStrike = 4,
        GA_Takedown_CombatWall = 5,
        GA_Takedown_CombatShocked = 6,
        GA_Takedown_Fallen = 7,
        GA_Takedown_GrabStanding = 8,
        GA_Takedown_GrabFloor = 9,
        GA_Takedown_GrabGrate = 10,
        GA_Takedown_GrabCorner = 11,
        GA_Takedown_HangAttack = 12,
        GA_Takedown_GlideKick = 13,
        GA_Takedown_GlassAttack = 14,
        GA_Takedown_VentAttack = 15,
        GA_Takedown_LedgeAttack = 16,
        GA_Takedown_DoubleHeadTakedown = 17,
        GA_KO = 18,
        GA_KO_Knife = 19,
        GA_KO_Pipe = 20,
        GA_KO_StunStick = 21,
        GA_KO_Shield = 22,
        GA_KO_Armoured = 23,
        GA_KO_Ninja = 24,
        GA_KO_CombatGun = 25,
        GA_KO_PredatorGun = 26,
        GA_KO_Sniper = 27,
        GA_THUG_ThugKill = 28,
        GA_THUG_HeroKill = 29,
        GA_Assist = 30,
        GA_EvidenceTrailOver = 31,
        GA_Pickup = 32,
        GA_Pickup_Map = 33,
        GA_Pickup_Tape = 34,
        GA_Cipher_Found = 35,
        GA_Riddle_Solved = 36,
        GA_DestroyTeeth = 37,
        GA_VenomHenchmanDefeated = 38,
        GA_SP_InitialDiscovery = 39,
        GA_BossGrundyPhaseOver = 40,
        GA_BossGrundyPhaseOver_Hard = 41,
        GA_BossJokerPhaseOver = 42,
        GA_BossClayfacePhaseOver = 43,
        GA_DropOnThug = 44,
        GA_ScareThug = 45,
        GA_SP_FurtherDiscovery = 46,
        GA_Stun_Batarang = 47,
        GA_Combo_XP_Multiplier = 48,
        GA_MultiplayerAward = 49,
        GA_ObjectiveCaptured = 50,
        GA_ObjectiveFullyCaptured = 51,
        GA_ObjectiveNeutralized = 52,
        GA_ObjectiveDisabled = 53,
        GA_ObjectiveReached = 54,
        GA_Combat_QuickStrike = 55,
        GA_Combat_HeavyStrike = 56,
        GA_Combat_ComboStrike = 57,
        GA_Combat_Counter = 58,
        GA_Combat_Redirect = 59,
        GA_Combat_Evade = 60,
        GA_Combat_Stun = 61,
        GA_Grab_Henchman = 62,
        GA_Gadget_Grapple = 63,
        GA_Gadget_Grapple_Rescue = 64,
        GA_Gadget_Grapple_AnyTime = 65,
        GA_Gadget_Grapple_Failed = 66,
        GA_Gadget_Batarang180Flip = 67,
        GA_Gadget_Batarang = 68,
        GA_Gadget_SonicBatarang = 69,
        GA_Gadget_ExplosiveGel = 70,
        GA_Gadget_BatClaw = 71,
        GA_Gadget_Resonator = 72,
        GA_Gadget_BroadcastAnalyser = 73,
        GA_Gadget_ControllableBatarang = 74,
        GA_Gadget_RoundTheBackarang = 75,
        GA_Gadget_MagneticBlast = 76,
        GA_Gadget_MagneticBlastRepel = 77,
        GA_Gadget_FreezeSpray = 78,
        GA_Gadget_SmokeBomb = 79,
        GA_Gadget_JammerGadget = 80,
        GA_Gadget_LineLauncherTightRope = 81,
        GA_Gadget_LineLauncher_IfNotFired = 82,
        GA_Gadget_BatarangBrake = 83,
        GA_Gadget_LineLauncher = 84,
        GA_Gadget_CombatBatClaw = 85,
        GA_Gadget_CombatBatarang = 86,
        GA_Gadget_Detonator = 87,
        GA_Gadget_Bullwhip = 88,
        GA_Gadget_CombatBullwhip = 89,
        GA_Gadget_BullwhipCombatDisarm = 90,
        GA_Gadget_Staff = 91,
        GA_Gadget_ShieldBash = 92,
        GA_Gadget_SticksAreaStun = 93,
        GA_Gadget_SticksRicochet = 94,
        GA_Gadget_WristDart = 95,
        GA_Gadget_StickyBomb = 96,
        GA_Gadget_ZipKick = 97,
        GA_Gadget_QuickBatarang = 98,
        GA_Gadget_QuickGel = 99,
        GA_Gadget_QuickDetonate = 100,
        GA_Gadget_QuickClaw = 101,
        GA_Gadget_QuickFreeze = 102,
        GA_Gadget_QuickMagBlast = 103,
        GA_Gadget_DetonateGel = 104,
        GA_Gadget_QuickBullwhip = 105,
        GA_Gadget_DoubleLineLauncher_Tutorial = 106,
        GA_EnygmaScreen_Tutorial = 107,
        GA_SilentPredatorCamera = 108,
        GA_InvestigateMode = 109,
        GA_MapOpened = 110,
        GA_Zoom = 111,
        GA_UnZoom = 112,
        GA_Agility_Climb = 113,
        GA_Agility_ClimbDown = 114,
        GA_Agility_Shimmy = 115,
        GA_Agility_DiveThroughWindow = 116,
        GA_Agility_WalkOnRailing = 117,
        GA_Agility_Swing = 118,
        GA_Agility_Slide = 119,
        GA_Agility_Jump = 120,
        GA_Agility_CwSwingToCeiling = 121,
        GA_Agility_CwJumpToCeiling = 122,
        GA_Agility_CwUsedCeilingGrate = 123,
        GA_InvisiblePredator_Crouch = 124,
        GA_InvisiblePredator_CornerCover = 125,
        GA_InvisiblePredator_TunnelGrate = 126,
        GA_InvisiblePredator_HangMode = 127,
        GA_InvisiblePredator_JumpFromVantagePoint = 128,
        GA_InvisiblePredator_SwingToVantagePoint = 129,
        GA_InvisiblePredator_InstantSmokeBomb = 130,
        GA_TakedownBeginTakedown = 131,
        GA_Died = 132,
        GA_PredatorChallenge_WallKill = 133,
        GA_PredatorChallenge_BatarangThenTakedown = 134,
        GA_PredatorChallenge_GlideKickThenTakedown = 135,
        GA_PredatorChallenge_1Wall3Kills = 136,
        GA_PredatorChallenge_2Walls2Kills = 137,
        GA_PredatorChallenge_3Walls3Kills = 138,
        GA_PredatorChallenge_LineLaunchKickThroughWindow = 139,
        GA_PredatorChallenge_BatclawOverLedge = 140,
        GA_PredatorChallenge_Batclaw3OverLedge = 141,
        GA_PredatorChallenge_LineLaunch2People = 142,
        GA_PredatorChallenge_LineLaunch3People = 143,
        GA_PredatorChallenge_Hit3WithSteerableBatarang = 144,
        GA_PredatorChallenge_SonicBatarangKill = 145,
        GA_PredatorChallenge_3BatarangHit = 146,
        GA_PredatorChallenge_LineLauncherKill = 147,
        GA_PredatorChallenge_GrateThenGrab = 148,
        GA_PredatorChallenge_PullOutFloorFrom1 = 149,
        GA_PredatorChallenge_PullOutFloorFrom2 = 150,
        GA_PredatorChallenge_PullOutFloorFrom3 = 151,
        GA_PredatorChallenge_SilentTakedown = 152,
        GA_PredatorChallenge_LedgeTakedown = 153,
        GA_PredatorChallenge_CornerTakedown = 154,
        GA_PredatorChallenge_GlassTakedown = 155,
        GA_PredatorChallenge_HangingTakedown = 156,
        GA_PredatorChallenge_DropTakedown = 157,
        GA_PredatorChallenge_PunchArmedThug = 158,
        GA_PredatorChallenge_UltraBatclawWallKill = 159,
        GA_PredatorChallenge_ScareThug = 160,
        GA_PredatorChallenge_GooStun = 161,
        GA_PredatorChallenge_TakedownVIPFirst = 162,
        GA_PredatorChallenge_Punch3DifferentThugs = 163,
        GA_PredatorChallenge_NoDamage = 164,
        GA_PredatorChallenge_TakedownVIPLast = 165,
        GA_PredatorChallenge_UpLadderOntoGel = 166,
        GA_PredatorChallenge_HangingTakeDownThroughGlass = 167,
        GA_PredatorChallenge_QuickSilentTakedown = 168,
        GA_PredatorChallenge_ReverseChokeTakedown = 169,
        GA_PredatorChallenge_FromAboveTakedown = 170,
        GA_PredatorChallenge_DoubleLedgeTakedown = 171,
        GA_PredatorChallenge_DoubleHeadTakedown = 172,
        GA_PredatorChallenge_DoubleVantagePointTakedown = 173,
        GA_PredatorChallenge_LineLauncherTakedown = 174,
        GA_PredatorChallenge_SwingKickThenTakedown = 175,
        GA_PredatorChallenge_FractureWallTakedown = 176,
        GA_PredatorChallenge_InvertedCeilingTakedown = 177,
        GA_PredatorChallenge_PounceKOThenTakedown = 178,
        GA_PredatorChallenge_CaltropKOThenTakedown = 179,
        GA_PredatorChallenge_PullFromCatwalkTakedown = 180,
        GA_PredatorChallenge_BoomerangBatarangTakedown = 181,
        GA_PredatorChallenge_GelCrateThenTakedown = 182,
        GA_PredatorChallenge_BatclawDisarmThenKO = 183,
        GA_PredatorChallenge_BatclawThroughWindow = 184,
        GA_PredatorChallenge_LineLaunchKick = 185,
        GA_PredatorChallenge_DropAttackFromTightRope = 186,
        GA_PredatorChallenge_DoubleLineLaunchKick = 187,
        GA_PredatorChallenge_RECScareThugs = 188,
        GA_PredatorChallenge_RECArmouredBowlingBall = 189,
        GA_PredatorChallenge_FreezeTakedown = 190,
        GA_PredatorChallenge_FreezeClusterDoubleTakedown = 191,
        GA_PredatorChallenge_FreezeProximityThenTakedown = 192,
        GA_PredatorChallenge_SmokeBombTakedown = 193,
        GA_PredatorChallenge_BeatDownTakedown = 194,
        GA_PredatorChallenge_SlideThenTakedown = 195,
        GA_PredatorChallenge_DiveBombThenTakedown = 196,
        GA_PredatorChallenge_Shockwave3Enemies = 197,
        GA_PredatorChallenge_VentTakedown = 198,
        GA_PredatorChallenge_FloorGrateTakedown = 199,
        GA_PredatorChallenge_Combo3 = 200,
        GA_PredatorChallenge_Combo8 = 201,
        GA_PredatorChallenge_BatarangBoostArmouredThug = 202,
        GA_PredatorChallenge_BatarangBoostKO = 203,
        GA_PredatorChallenge_HangTakedownOnJammer = 204,
        GA_PredatorChallenge_MineDetonateOnMineLayer = 205,
        GA_PredatorChallenge_CombatFloorKO = 206,
        GA_PredatorChallenge_FloorGrab = 207,
        GA_PredatorChallenge_PunchKO = 208,
        GA_PredatorChallenge_EscrimaStick1 = 209,
        GA_PredatorChallenge_EscrimaStick2 = 210,
        GA_PredatorChallenge_RemoteElectricalBlast1 = 211,
        GA_PredatorChallenge_RemoteElectricalBlast2 = 212,
        GA_PredatorChallenge_RemoteElectricalBlast3 = 213,
        GA_PredatorChallenge_WristDart1 = 214,
        GA_PredatorChallenge_WristDart2 = 215,
        GA_PredatorChallenge_WristDart3 = 216,
        GA_PredatorChallenge_BulletShield1 = 217,
        GA_PredatorChallenge_BulletShield2 = 218,
        GA_PredatorChallenge_BulletShield3 = 219,
        GA_PredatorChallenge_ZipKick1 = 220,
        GA_PredatorChallenge_ZipKick2 = 221,
        GA_PredatorChallenge_ZipKick3 = 222,
        GA_PredatorChallenge_StickyBomb1 = 223,
        GA_PredatorChallenge_StickyBomb2 = 224,
        GA_PredatorChallenge_StickyBomb3 = 225,
        GA_PredatorChallenge_WhipDisarm = 226,
        GA_PredatorChallenge_CwBeatDownTakedown = 227,
        GA_PredatorChallenge_PullSniperFromCatwalkTakedown = 228,
        GA_PredatorChallenge_WeaponJam = 229,
        GA_PredatorChallenge_SonicBatarangTakedown = 230,
        GA_PredatorChallenge_RECOverLedge = 231,
        GA_PredatorChallenge_GelCeiling = 232,
        GA_PredatorChallenge_BatarangDistract = 233,
        GA_PredatorChallenge_FireExtinguisherTakedown = 234,
        GA_PredatorChallenge_WindowTakedown = 235,
        GA_PredatorChallenge_BatarangThenTakedownCW = 236,
        GA_PredatorChallenge_BatarangThenTakedownRB = 237,
        GA_PredatorChallenge_BatarangThenTakedownNW = 238,
        GA_PredatorChallenge_BatarangDistractCW = 239,
        GA_PredatorChallenge_BatarangDistractRB = 240,
        GA_PredatorChallenge_BatarangDistractNW = 241,
        GA_PredatorChallenge_FireExtinguisherTakedownCW = 242,
        GA_PredatorChallenge_FireExtinguisherTakedownRB = 243,
        GA_PredatorChallenge_WhipTripThenTakedown = 244,
        GA_PredatorChallenge_FallingTakedown = 245,
        GA_PredatorChallenge_CornerTakedownKO = 246,
        GA_PredatorChallenge_MineExplosionKO = 247,
        GA_Combat_CounterStart = 248,
        GA_InterrogatedThug = 249,
        GA_ScannedInterrogateThug = 250,
        GA_TitanRideStarted = 251,
        GA_SuperStun = 252,
        GA_StruckStunStickThug = 253,
        GA_ChallengeMedalGained = 254,
        GA_Max = 255,
    }

    /// <summary>
    /// Enum: ELive_LiveError
    /// </summary>
    public enum ELive_LiveError : byte
    {
        EL_None = 0,
        EL_LoginLost = 1,
        EL_LoginChanged = 2,
        EL_NotConnected = 3,
        EL_Connected = 4,
        EL_ConnectionDropped = 5,
        EL_NoNetworkConnection = 6,
        EL_ServiceUnavailable = 7,
        EL_UpdateRequired = 8,
        EL_ServersTooBusy = 9,
        EL_DuplicateLoginDetected = 10,
        EL_InvalidUser = 11,
        EL_PS3NotConnected = 12,
        EL_PS3NotLoggedIn = 13,
        EL_DLCInvalidated = 14,
        EL_DLCNewContent = 15,
        EL_MAX = 16,
    }

    /// <summary>
    /// Enum: EGS_Reason
    /// </summary>
    public enum EGS_Reason : byte
    {
        EGS_None = 0,
        EGS_StoryExit = 1,
        EGS_StoryComplete = 2,
        EGS_Challenge_Lost = 3,
        EGS_Challenge_Won = 4,
        EGS_MAX = 5,
    }

    /// <summary>
    /// Enum: EGameModes
    /// </summary>
    public enum EGameModes : byte
    {
        EGM_Frontend = 0,
        EGM_KingOfTheHill = 1,
        EGM_Deathmatch = 2,
        EGM_TeamDeathmatch = 3,
        EGM_TugOfWar = 4,
        EGM_Gangland = 5,
        EGM_HunterHunted = 6,
        EGM_BeTheBatman = 7,
        EGM_BeTheVillain = 8,
        EGM_Story = 9,
        EGM_Challenge = 10,
        EGM_MAX = 11,
    }

    /// <summary>
    /// Enum: ELeaderboardColumns
    /// </summary>
    public enum ELeaderboardColumns : byte
    {
        ELBC_Medal = 0,
        ELBC_Score = 1,
        ELBC_RatingScore = 2,
        ELBC_MAX = 3,
    }

    /// <summary>
    /// Enum: StreamedCombatWeaponTypes
    /// </summary>
    public enum StreamedCombatWeaponTypes : byte
    {
        COMBATWEAPON_None = 0,
        COMBATWEAPON_Rifle = 1,
        COMBATWEAPON_Knife = 2,
        COMBATWEAPON_Bottle = 3,
        COMBATWEAPON_Pipe = 4,
        COMBATWEAPON_Bat = 5,
        COMBATWEAPON_Shield = 6,
        COMBATWEAPON_StunStick = 7,
        COMBATWEAPON_MAX = 8,
    }

    /// <summary>
    /// Enum: StreamedPredWeaponTypes
    /// </summary>
    public enum StreamedPredWeaponTypes : byte
    {
        PREDWEAPON_Rifle = 0,
        PREDWEAPON_Shotgun = 1,
        PREDWEAPON_Sniper = 2,
        PREDWEAPON_None = 3,
        PREDWEAPON_MAX = 4,
    }

    /// <summary>
    /// Enum: VocalPriority
    /// </summary>
    public enum VocalPriority : byte
    {
        EVP_Default = 0,
        EVP_Low = 1,
        EVP_Medium = 2,
        EVP_High = 3,
        EVP_Highest = 4,
        EVP_DuckAllOther = 5,
        EVP_MAX = 6,
    }

    /// <summary>
    /// Enum: VocalType
    /// </summary>
    public enum VocalType : byte
    {
        EVT_Emote = 0,
        EVT_Bark = 1,
        EVT_Speech = 2,
        EVT_MAX = 3,
    }

    /// <summary>
    /// Struct: FShotByInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FShotByInfo
    {
        /// <summary>
        /// StrProperty: NameOfShooter
        /// </summary>
        public unsafe BmSDK.FString NameOfShooter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: HitLocation
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.RecordedShotLocations HitLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.RecordedShotLocations>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ClassProperty: TypeDamage
        /// </summary>
        public unsafe BmSDK.Class TypeDamage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Damage
        /// </summary>
        public unsafe int Damage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FGDPlayerLoadout
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial record struct FGDPlayerLoadout
    {
        /// <summary>
        /// ByteProperty: RelevantTeam
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.ELoadoutTeamId RelevantTeam
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ELoadoutTeamId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: EquippedWeapon
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.WeaponId EquippedWeapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.WeaponId>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// IntProperty: EquippedWeaponLevel
        /// </summary>
        public unsafe int EquippedWeaponLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: WeaponSkinIdx
        /// </summary>
        public unsafe int WeaponSkinIdx
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: UnboundGadgets
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.PlayerGadgetId> UnboundGadgets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.PlayerGadgetId>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 25); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 25); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 26); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 26); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 27); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 27); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 29); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 29); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 30); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 30); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_7
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 31); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 31); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_8
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_9
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 33); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 33); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_10
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 34); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 34); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_11
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 35); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 35); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_12
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_13
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 37); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 37); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_14
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 38); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 38); }; }
        }
        /// <summary>
        /// ByteProperty: DpadGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId DpadGadgets_15
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 39); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 39); }; }
        }

        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_7
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_8
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_9
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_10
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_11
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_12
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_13
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_14
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }
        /// <summary>
        /// IntProperty: DpadGadgetsUpgradeIdx
        /// </summary>
        public unsafe int DpadGadgetsUpgradeIdx_15
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// ByteProperty: QuickGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId QuickGadgets_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }
        /// <summary>
        /// ByteProperty: QuickGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId QuickGadgets_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 105); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 105); }; }
        }
        /// <summary>
        /// ByteProperty: QuickGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId QuickGadgets_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 106); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 106); }; }
        }
        /// <summary>
        /// ByteProperty: QuickGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId QuickGadgets_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 107); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 107); }; }
        }
        /// <summary>
        /// ByteProperty: QuickGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId QuickGadgets_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }
        /// <summary>
        /// ByteProperty: QuickGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId QuickGadgets_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 109); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 109); }; }
        }
        /// <summary>
        /// ByteProperty: QuickGadgets
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.PlayerGadgetId QuickGadgets_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(Ptr + 110); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 110); }; }
        }
    }

    /// <summary>
    /// Enum: ESpecialistObitType
    /// </summary>
    public enum ESpecialistObitType : byte
    {
        ESpecialistObitType_Invalid = 0,
        ESpecialistObitType_Headshot = 1,
        ESpecialistObitType_HeroMeleeBatman = 2,
        ESpecialistObitType_HeroMeleeRobin = 3,
        ESpecialistObitType_HeroTakedownBatman = 4,
        ESpecialistObitType_HeroTakedownRobin = 5,
        ESpecialistObitType_Suicide = 6,
        ESpecialistObitType_MAX = 7,
    }

    /// <summary>
    /// Enum: LoadoutCharacterID
    /// </summary>
    public enum LoadoutCharacterID : byte
    {
        LCI_ThugJoker = 0,
        LCI_ThugBane = 1,
        LCI_Batman = 2,
        LCI_Robin = 3,
        LCI_Bane = 4,
        LCI_Joker = 5,
        LCI_Invalid = 6,
        LCI_MAX = 7,
    }

    /// <summary>
    /// Enum: RecordedShotLocations
    /// </summary>
    public enum RecordedShotLocations : byte
    {
        RSL_Head = 0,
        RSL_Chest = 1,
        RSL_Stomach = 2,
        RSL_UpperLeftArm = 3,
        RSL_UpperRightArm = 4,
        RSL_LowerLeftArm = 5,
        RSL_LowerRightArm = 6,
        RSL_UpperLeftLeg = 7,
        RSL_UpperRightLeg = 8,
        RSL_LowerLeftLeg = 9,
        RSL_LowerRightLeg = 10,
        RSL_MAX = 11,
    }

    /// <summary>
    /// Enum: EQuickGadgetType
    /// </summary>
    public enum EQuickGadgetType : byte
    {
        QGT_GadgetLT = 0,
        QGT_GadgetRT = 1,
        QGT_GadgetB = 2,
        QGT_GadgetX = 3,
        QGT_GadgetY = 4,
        QGT_GadgetLB = 5,
        QGT_GadgetRB = 6,
        QGT_MAX = 7,
    }

    /// <summary>
    /// Enum: eGadgetSlot
    /// </summary>
    public enum eGadgetSlot : byte
    {
        GSL_InnerNorth = 0,
        GSL_InnerNorthEast = 1,
        GSL_InnerEast = 2,
        GSL_InnerSouthEast = 3,
        GSL_InnerSouth = 4,
        GSL_InnerSouthWest = 5,
        GSL_InnerWest = 6,
        GSL_InnerNorthWest = 7,
        GSL_OuterNorth = 8,
        GSL_OuterNorthEast = 9,
        GSL_OuterEast = 10,
        GSL_OuterSouthEast = 11,
        GSL_OuterSouth = 12,
        GSL_OuterSouthWest = 13,
        GSL_OuterWest = 14,
        GSL_OuterNorthWest = 15,
        GSL_MAX = 16,
    }

    /// <summary>
    /// Enum: WeaponId
    /// </summary>
    public enum WeaponId : byte
    {
        PWI_AssaultRifle_01 = 0,
        PWI_AssaultRifle_02 = 1,
        PWI_AssaultRifle_03 = 2,
        PWI_Shotgun_01 = 3,
        PWI_Shotgun_02 = 4,
        PWI_Shotgun_03 = 5,
        PWI_SMG_01 = 6,
        PWI_SMG_02 = 7,
        PWI_Sniper_01 = 8,
        PWI_Sniper_02 = 9,
        PWI_Sidearm_01 = 10,
        PWI_AdditionalWeapon_01 = 11,
        PWI_AdditionalWeapon_02 = 12,
        PWI_AdditionalWeapon_03 = 13,
        PWI_AdditionalWeapon_04 = 14,
        PWI_Invalid = 15,
        PWI_MAX = 16,
    }

    /// <summary>
    /// Enum: PlayerGadgetId
    /// </summary>
    public enum PlayerGadgetId : byte
    {
        PGI_Batarang = 0,
        PGI_GooSpray = 1,
        PGI_ResonatorTuner = 2,
        PGI_Scrambler = 3,
        PGI_SmokePellet = 4,
        PGI_BulletShield = 5,
        PGI_RCBatarang = 6,
        PGI_SonicBatarang = 7,
        PGI_RobinBatclaw = 8,
        PGI_ThugVision = 9,
        PGI_RocketLauncher = 10,
        PGI_SyringeLauncher = 11,
        PGI_FragGrenade = 12,
        PGI_TeamObjective = 13,
        PGI_EquippedWeapon = 14,
        PGI_Joker_DeathBlossom = 15,
        PGI_DualWield = 16,
        PGI_TacticalDart = 17,
        PGI_RCHelicopter = 18,
        PGI_SecondaryWeapon = 19,
        PGI_VenomInjector = 20,
        PGI_SupriseYoureDead = 21,
        PGI_UAV = 22,
        PGI_UltrasonicPulse = 23,
        PGI_Joker_EquippedWeapon = 24,
        PGI_Invalid = 25,
        PGI_MAX = 26,
    }

    /// <summary>
    /// Enum: ELoadoutTeamId
    /// </summary>
    public enum ELoadoutTeamId : byte
    {
        ULT_Hero = 0,
        ULT_Joker = 1,
        ULT_Bane = 2,
        ULT_MAX = 3,
    }

    /// <summary>
    /// Enum: NewExperienceAmounts
    /// </summary>
    public enum NewExperienceAmounts : byte
    {
        NEA_Thug_NormalKillThug = 0,
        NEA_Thug_MeleeKillThug = 1,
        NEA_Thug_GrenadeKillThug = 2,
        NEA_Thug_SpecialKillThug = 3,
        NEA_Thug_AssistKillThug = 4,
        NEA_Thug_NormalKillHero = 5,
        NEA_Thug_MeleeKillHero = 6,
        NEA_Thug_GrenadeKillHero = 7,
        NEA_Thug_SpecialKillHero = 8,
        NEA_Thug_AssistKillHero = 9,
        NEA_Thug_MidTakedownKillHero = 10,
        NEA_Thug_MidHackKillHero = 11,
        NEA_Thug_GangleaderKill = 12,
        NEA_Thug_ControlPointCaptured = 13,
        NEA_Thug_ControlPointSecured = 14,
        NEA_Thug_ControlPointNeutralized = 15,
        NEA_Thug_ControlPointCleared = 16,
        NEA_Thug_FinaleExitReached = 17,
        NEA_Thug_FinaleThugKilled = 18,
        NEA_Thug_FinaleExitReachedBonusXP = 19,
        NEA_Hero_HangingTakedown = 20,
        NEA_Hero_FloorTakedown = 21,
        NEA_Hero_TunnelTakedown = 22,
        NEA_Hero_VentTakedown = 23,
        NEA_Hero_GlassTakedown = 24,
        NEA_Hero_WallTakedown = 25,
        NEA_Hero_DoubleTakedown = 26,
        NEA_Hero_KnockoutSmashTakedown = 27,
        NEA_Hero_SneakyTakedown = 28,
        NEA_Hero_DoubleLedgeTakedown = 29,
        NEA_Hero_RailingTakedown = 30,
        NEA_Hero_LedgeTakedown = 31,
        NEA_Hero_ReverseChokeTakedown = 32,
        NEA_Hero_CornerTakedown = 33,
        NEA_Hero_Knockout = 34,
        NEA_Hero_Assist = 35,
        NEA_Hero_TechnicalAssist = 36,
        NEA_Hero_UNUSED = 37,
        NEA_Hero_CompleteControl = 38,
        NEA_Hero_StatusQuo = 39,
        NEA_Hero_TechnicalKnockout = 40,
        NEA_AwardLevelOne = 41,
        NEA_AwardLevelTwo = 42,
        NEA_AwardLevelThree = 43,
        NEA_Thug_Comeback = 44,
        NEA_Gangland_Won = 45,
        NEA_Gangland_Lost = 46,
        NEA_HunterHunted_Won = 47,
        NEA_HunterHunted_Lost = 48,
        NEA_HunterHunted_FinaleKill = 49,
        NEA_HunterHunted_Survived = 50,
        NEA_Thug_FirstBlood = 51,
        NEA_Thug_DestroyScrambler = 52,
        NEA_Thug_MidGlideHeroKill = 53,
        NEA_Thug_TacDartHeroTag = 54,
        NEA_Thug_TacDartThugTag = 55,
        NEA_Thug_TacDartGangleaderTag = 56,
        NEA_Thug_SupervillainAssist = 57,
        NEA_Hero_SupervillainAssist = 58,
        NEA_Gangleader_JokerPrimaryKill = 59,
        NEA_Gangleader_JokerSecondaryKill = 60,
        NEA_Gangleader_JokerThugExecution = 61,
        NEA_Gangleader_JokerHeroExecution = 62,
        NEA_Gangleader_BaneGroundPunch = 63,
        NEA_Gangleader_BaneRocketLauncher = 64,
        NEA_Gangleader_BaneThugExecutionFloor = 65,
        NEA_Gangleader_BaneThugExecutionWall = 66,
        NEA_Gangleader_BaneThugExecutionThrow = 67,
        NEA_Gangleader_BaneHeroExecution = 68,
        NEA_Thug_CapturePointTick = 69,
        NEA_Thug_KillStreakKill = 70,
        NEA_Thug_CaptainSurvivalBonus = 71,
        NEA_Thug_CaptainProtectionBonus = 72,
        NEA_All_FirstMatchPlayed = 73,
        NEA_Hero_ScrambledThugVision = 74,
        NEA_Invalid = 75,
        NEA_MAX = 76,
    }

    /// <summary>
    /// ObjectProperty: GameplayEventsWriter
    /// </summary>
    public unsafe BmSDK.BmGame.RGameplayEventsHydra GameplayEventsWriter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameplayEventsHydra>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ArrayProperty: AllThugScarableCrows
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCrowsBase> AllThugScarableCrows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCrowsBase>>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// IntProperty: CrowTimeSliceIndex
    /// </summary>
    public unsafe int CrowTimeSliceIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: GADuplicateList_Main
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> GADuplicateList_Main
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ArrayProperty: GADuplicateList_Dup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> GADuplicateList_Dup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: FloorTakedownChallengeAction
    /// </summary>
    public InlineArray<BmSDK.BmGame.RGameInfo.EGameAction> FloorTakedownChallengeAction => new(28, Ptr + 988, 1, this);

    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 989); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 989); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 990); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 990); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 991); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 991); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 993); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 993); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 994); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 994); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 995); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 995); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 997); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 997); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 998); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 998); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 999); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 999); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1001); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1001); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1002); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1002); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1003); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1003); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1005); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1005); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1006); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1006); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1007); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1007); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1009); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1009); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1010); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1010); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1011); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1011); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1013); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1013); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1014); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1014); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1015); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1015); }
    }

    /// <summary>
    /// ByteProperty: GameMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameModes GameMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameModes>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ByteProperty: ChallengeMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EChallengeMode ChallengeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeMode>(Ptr + 1017); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1017); }
    }

    /// <summary>
    /// ByteProperty: ChallengeCharacter
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EChallengeCharacter ChallengeCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeCharacter>(Ptr + 1018); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1018); }
    }

    /// <summary>
    /// ByteProperty: StasisLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStasisLevel StasisLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStasisLevel>(Ptr + 1019); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1019); }
    }

    /// <summary>
    /// ByteProperty: ReplayId
    /// </summary>
    public unsafe byte ReplayId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// ObjectProperty: CachedPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController CachedPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bHead2Head
    /// </summary>
    public unsafe bool bHead2Head
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bStoryDLC
    /// </summary>
    public unsafe bool bStoryDLC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bSavingStartPoints
    /// </summary>
    public unsafe bool bSavingStartPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bShowChaseStartPos
    /// </summary>
    public unsafe bool bShowChaseStartPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bM8VantageVisibilityHack
    /// </summary>
    public unsafe bool bM8VantageVisibilityHack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bOneHitKill
    /// </summary>
    public unsafe bool bOneHitKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bNoGadgets
    /// </summary>
    public unsafe bool bNoGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bSilentTakeDownOnly
    /// </summary>
    public unsafe bool bSilentTakeDownOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bNoGrapple
    /// </summary>
    public unsafe bool bNoGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bNoInvestigateMode
    /// </summary>
    public unsafe bool bNoInvestigateMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bUseLowLineLauncherHeight
    /// </summary>
    public unsafe bool bUseLowLineLauncherHeight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: LevelLoadedAndReady
    /// </summary>
    public unsafe bool LevelLoadedAndReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bDoCombatGrapnelToVpointArriveCheck
    /// </summary>
    public unsafe bool bDoCombatGrapnelToVpointArriveCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: EnableBigHeadMode
    /// </summary>
    public unsafe bool EnableBigHeadMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bSplitscreenCaptureMode
    /// </summary>
    public unsafe bool bSplitscreenCaptureMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: bPreventPauseOnControllerRemoval
    /// </summary>
    public unsafe bool bPreventPauseOnControllerRemoval
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: SavedOWDTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedOWDTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: SavedMuseumTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedMuseumTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: SavedUnderTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedUnderTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// IntProperty: ChallengeID
    /// </summary>
    public unsafe int ChallengeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: SessionTimePlayed
    /// </summary>
    public unsafe float SessionTimePlayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: FootstepNoiseDist
    /// </summary>
    public unsafe float FootstepNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: WalkFootstepNoiseDist
    /// </summary>
    public unsafe float WalkFootstepNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: TakedownNoiseDist
    /// </summary>
    public unsafe float TakedownNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: ChaseCheatTime
    /// </summary>
    public unsafe float ChaseCheatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// FloatProperty: RBSmashSpeedAlertThreshold
    /// </summary>
    public unsafe float RBSmashSpeedAlertThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: BingBongTimer
    /// </summary>
    public unsafe float BingBongTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: GunStartleTimer
    /// </summary>
    public unsafe float GunStartleTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// StructProperty: CurrentWindState
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FRWindState CurrentWindState
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FRWindState>(Ptr + 1068);

    /// <summary>
    /// StructProperty: CurrentWindConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FRWindConfig CurrentWindConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FRWindConfig>(Ptr + 1136);

    /// <summary>
    /// FloatProperty: CurrentRainIntensity
    /// </summary>
    public unsafe float CurrentRainIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// ArrayProperty: ObjectiveMarkers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RObjectiveMarker> ObjectiveMarkers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RObjectiveMarker>>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// IntProperty: VisibleObjectiveMarker
    /// </summary>
    public unsafe int VisibleObjectiveMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// IntProperty: HighestPriorityNonCustomObjectiveMarker
    /// </summary>
    public unsafe int HighestPriorityNonCustomObjectiveMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ArrayProperty: LoadedAllTheTimeOnPCToSaveDVDSpace
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> LoadedAllTheTimeOnPCToSaveDVDSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// FloatProperty: PredChaseTime
    /// </summary>
    public unsafe float PredChaseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// ArrayProperty: LevelTransitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLevelTransition> LevelTransitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLevelTransition>>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// ObjectProperty: PatrolGunDefaultAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PatrolGunDefaultAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// ObjectProperty: PatrolGunUpAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PatrolGunUpAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// ObjectProperty: ManDownPeekAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager ManDownPeekAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// ObjectProperty: GuardPointAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager GuardPointAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// ObjectProperty: ReloadAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager ReloadAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// ObjectProperty: TutThugAimingAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager TutThugAimingAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// ObjectProperty: PerimOutAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PerimOutAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// FloatProperty: LastExclaimTime
    /// </summary>
    public unsafe float LastExclaimTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// IntProperty: LastExclaimPriority
    /// </summary>
    public unsafe int LastExclaimPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// FloatProperty: CombatGrapnelToVPointStartTime
    /// </summary>
    public unsafe float CombatGrapnelToVPointStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// IntProperty: FramesUntilNextPawnSpawn
    /// </summary>
    public unsafe int FramesUntilNextPawnSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// ArrayProperty: ActiveHelicopters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterBase> ActiveHelicopters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterBase>>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// FloatProperty: ICStasisRange
    /// </summary>
    public unsafe float ICStasisRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// FloatProperty: FullStasisRange
    /// </summary>
    public unsafe float FullStasisRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// IntProperty: SkinMode
    /// </summary>
    public unsafe int SkinMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// StrProperty: SkinWhoBase
    /// </summary>
    public unsafe BmSDK.FString SkinWhoBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// StrProperty: SkinStartString
    /// </summary>
    public unsafe BmSDK.FString SkinStartString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// IntProperty: PlayFromChosenSlot
    /// </summary>
    public unsafe int PlayFromChosenSlot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// ArrayProperty: ChallengeMapList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapItem> ChallengeMapList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapItem>>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// ArrayProperty: SubMapLocList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapHackOWLoc> SubMapLocList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapHackOWLoc>>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// ArrayProperty: MapElementList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElements> MapElementList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElements>>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// ArrayProperty: MapElementItemList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElementsItem> MapElementItemList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElementsItem>>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// ArrayProperty: StoryDLCList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FStoryDLCItem> StoryDLCList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FStoryDLCItem>>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// FloatProperty: DebugForceGarbageTimer
    /// </summary>
    public unsafe float DebugForceGarbageTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// ArrayProperty: DLCBundlesInstalled
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DLCBundlesInstalled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// FloatProperty: CameraMovementSpeed
    /// </summary>
    public unsafe float CameraMovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// IntProperty: helicopterSequenceNumber
    /// </summary>
    public unsafe int helicopterSequenceNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// StrProperty: deathMovieOverride
    /// </summary>
    public unsafe BmSDK.FString deathMovieOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// IntProperty: SavedMapIndexForSecretsLeftCheck
    /// </summary>
    public unsafe int SavedMapIndexForSecretsLeftCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// IntProperty: SavedSecretIndexForSecretsLeftCheck
    /// </summary>
    public unsafe int SavedSecretIndexForSecretsLeftCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// DelegateProperty: __SortByIndexDist__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByIndexDist__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }
}
