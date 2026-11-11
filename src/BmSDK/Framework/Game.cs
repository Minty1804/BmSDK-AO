using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using BmSDK.BmGame;
using BmSDK.Engine;

namespace BmSDK.Framework;

public static partial class Game
{
    /// <summary>
    /// Gets the world info object for the currently-loaded world.
    /// </summary>
    public static WorldInfo GetWorldInfo() => Guard.NotNull(WorldInfo.GetWorldInfo());

    /// <summary>
    /// Gets the player controller belonging to the local player.
    /// </summary>
    public static RPlayerController GetPlayerController(int controllerId = 0)
    {
        var player = GetGameViewportClient().FindPlayerByControllerId(controllerId);
        return Guard.NotNull(player.Actor as RPlayerController);
    }

    /// <summary>
    /// Gets the pawn currently possessed by the local player controller (returned by <see cref="GetPlayerController"/>).
    /// May be null if the game is currently in the main menu for example.
    /// </summary>
    public static RPawnPlayer? GetPlayerPawn(int controllerId = 0)
    {
        var playerController = GetPlayerController(controllerId);
        return playerController.CombatPawn;
    }

    /// <summary>
    /// Gets (or creates if needed) the cheat manager owned by the local player controller (returned by <see cref="GetPlayerController"/>).
    /// </summary>
    public static RCheatManager GetCheatManager()
    {
        var playerController = GetPlayerController();
        playerController.CheatManager ??= new RCheatManager(playerController);

        return (RCheatManager)playerController.CheatManager;
    }

    /// <summary>
    /// Gets the game info object for the currently-loaded world.
    /// </summary>
    public static RGameInfo GetGameInfo()
    {
        var worldInfo = GetWorldInfo();
        return Guard.NotNull(worldInfo.Game as RGameInfo);
    }

    /// <summary>
    /// Gets the replication info object for the currently-loaded world.
    /// </summary>
    public static RGameRI GetGameRI()
    {
        var worldInfo = GetWorldInfo();
        return Guard.NotNull(worldInfo.GRI as RGameRI);
    }

#if !BMSDK_AOO // AO Online's RGameInfo has no PersistentData (campaign save data)
    /// <summary>
    /// Gets the persistent data object for the currently-loaded world.
    /// </summary>
    public static RPersistentData GetPersistentData()
    {
        var gameInfo = GetGameInfo();
        return Guard.NotNull(gameInfo.PersistentData);
    }
#endif

    /// <summary>
    /// Gets the global engine object.
    /// </summary>
    public static GameEngine GetEngine() => Guard.NotNull(_Engine.GetEngine() as GameEngine);

    /// <summary>
    /// Gets the global viewport client object.
    /// </summary>
    public static RGFxGameViewportClient GetGameViewportClient()
    {
        var engine = GetEngine();
        return Guard.NotNull(engine.GameViewport as RGFxGameViewportClient);
    }

    /// <summary>
    /// Gets the global console object.
    /// </summary>
    public static _Console GetConsole()
    {
        var gameViewport = GetGameViewportClient();
        return Guard.NotNull(gameViewport.ViewportConsole);
    }

    // The Get* functions above throw when the object is missing (main menu, loading, teardown).
    // These report that instead, for code that runs in every state.

    /// <summary>Gets the world info object, or false when no world is loaded.</summary>
    public static bool TryGetWorldInfo([NotNullWhen(true)] out WorldInfo? worldInfo)
    {
        worldInfo = WorldInfo.GetWorldInfo();
        return Alive(worldInfo);
    }

    /// <summary>Gets the local player's controller, or false when there is none (yet).</summary>
    public static bool TryGetPlayerController([NotNullWhen(true)] out RPlayerController? playerController, int controllerId = 0)
    {
        playerController = null;
        if (!TryGetGameViewportClient(out var viewport))
        {
            return false;
        }

        var player = viewport.FindPlayerByControllerId(controllerId);
        playerController = player is { IsValid: true } ? player.Actor as RPlayerController : null;
        return Alive(playerController);
    }

    /// <summary>Gets the game info object, or false when no world is loaded.</summary>
    public static bool TryGetGameInfo([NotNullWhen(true)] out RGameInfo? gameInfo)
    {
        gameInfo = TryGetWorldInfo(out var worldInfo) ? worldInfo.Game as RGameInfo : null;
        return Alive(gameInfo);
    }

    /// <summary>Gets the replication info object, or false when no world is loaded.</summary>
    public static bool TryGetGameRI([NotNullWhen(true)] out RGameRI? gameRI)
    {
        gameRI = TryGetWorldInfo(out var worldInfo) ? worldInfo.GRI as RGameRI : null;
        return Alive(gameRI);
    }

#if !BMSDK_AOO
    /// <summary>Gets the persistent data object, or false when there is none.</summary>
    public static bool TryGetPersistentData([NotNullWhen(true)] out RPersistentData? persistentData)
    {
        persistentData = TryGetGameInfo(out var gameInfo) ? gameInfo.PersistentData : null;
        return Alive(persistentData);
    }
#endif

    /// <summary>Gets the global engine object, or false before it exists.</summary>
    public static bool TryGetEngine([NotNullWhen(true)] out GameEngine? engine)
    {
        engine = _Engine.GetEngine() as GameEngine;
        return Alive(engine);
    }

    /// <summary>Gets the global viewport client, or false before it exists.</summary>
    public static bool TryGetGameViewportClient([NotNullWhen(true)] out RGFxGameViewportClient? viewportClient)
    {
        viewportClient = TryGetEngine(out var engine) ? engine.GameViewport as RGFxGameViewportClient : null;
        return Alive(viewportClient);
    }

    private static bool Alive([NotNullWhen(true)] GameObject? obj) => obj is { IsValid: true };

    /// <summary>
    /// Gets the time in seconds since the last world tick.
    /// </summary>
    public static float GetDeltaTime()
    {
        var worldInfo = GetWorldInfo();
        return worldInfo.DeltaSeconds;
    }

    /// <summary>
    /// Finds and returns the object with the given path. Will be null if the object hasn't been loaded yet (see <see cref="LoadPackage"/> ).
    /// </summary>
    public static T? FindObject<T>(string pathName)
        where T : GameObject, IGameObject => GameObject.FindObject(pathName, T.StaticClass()) as T;

    /// <summary>
    /// Returns an enumerable containing all objects of the given type.
    /// </summary>
    /// <remarks>
    /// Can be slow, in cases where many objects of the given type exist.
    /// Be careful when using this with common types like <see cref="GameObject"/>  or <see cref="Actor"/>.
    /// </remarks>
    public static IEnumerable<T> FindObjects<T>()
        where T : GameObject => FindObjectsCache.FindObjects<T>();

    /// <summary>
    /// Spawns a new actor of the given type.
    /// </summary>
    public static unsafe Actor SpawnActor(
        Class Class,
        FName Name = default,
        Vector3 Location = default,
        Rotator Rotation = default,
        Actor? Template = null,
        GameObject? Owner = null,
        GameObject? Instigator = null,
        Level? Level = null
    )
    {
        var resPtr = SpawnActorInternal(Class, Name, Location, Rotation, Template, Owner, Instigator, Level);
        return MarshalUtil.ToManaged<Actor>(&resPtr);
    }

    /// <inheritdoc cref="SpawnActor"/>
    [Obsolete("Use `new Actor()` instead")]
    public static T? SpawnActor<T>(
        FName Name = default,
        Vector3 Location = default,
        Rotator Rotation = default,
        Actor? Template = null,
        GameObject? Owner = null,
        GameObject? Instigator = null,
        Level? Level = null
    )
        where T : Actor, IGameObject =>
        SpawnActor(T.StaticClass(), Name, Location, Rotation, Template, Owner, Instigator, Level) as T;

#if !BMSDK_AOO // AO Online's RCharacter has no StaticCreatePawn
    /// <summary>
    /// Spawns a new actor of the given pawn and character types.
    /// </summary>
    [Obsolete("Use `RBMPawnAI.InitCharacter()` instead")]
    public static TPawn? SpawnCharacter<TPawn, TCharacter>(Vector3 Position, Rotator Rotation)
        where TPawn : RBMPawnAI, IGameObject
        where TCharacter : RCharacter, IGameObject
    {
        return (TPawn)
            RCharacter.StaticCreatePawn(
                Position,
                Rotation,
                null,
                TPawn.StaticClass(),
                TCharacter.StaticClass(),
                true,
                FName.None,
                FName.None
            );
    }
#endif

    internal static unsafe IntPtr SpawnActorInternal(
        Class Class,
        FName Name,
        Vector3 Location,
        Rotator Rotation,
        Actor? Template,
        GameObject? Owner,
        GameObject? Instigator,
        Level? Level
    )
    {
        var world = Level is null ? (World)GetWorldInfo().Outer.Outer : (World)Level.Outer;
        var resPtr = GameFunctions.SpawnActor(
            world.Ptr,
            Class.Ptr,
            Name,
            (IntPtr)(&Location),
            (IntPtr)(&Rotation),
            Template?.Ptr ?? 0,
            1,
            0,
            Owner?.Ptr ?? 0,
            Instigator?.Ptr ?? 0,
            1
        );

        Guard.Require(resPtr != 0, "SpawnActor() returned null");
        return resPtr;
    }

    /// <summary>
    /// Loads a package into memory given its .upk file name.
    /// </summary>
    public static unsafe Package? LoadPackage(string filename)
    {
        // Get TCHAR* from string
        fixed (char* filenamePtr = filename)
        {
            // Call native func
            var result = GameFunctions.LoadPackage(0, (IntPtr)filenamePtr, 0);

            return MarshalUtil.ToManaged<Package>(&result);
        }
    }
}
