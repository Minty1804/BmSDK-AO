#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.SDEngine;

/// <summary>
/// Class: SDOnlineGameInterface<br/>
/// (size = 520)
/// (flags = 134250646)
/// </summary>
public partial class SDOnlineGameInterface : BmSDK.IpDrv.OnlineGameInterfaceImpl, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "SDEngine.SDOnlineGameInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as SDOnlineGameInterface.
    /// </summary>
    public static SDOnlineGameInterface DefaultObject => (SDOnlineGameInterface)StaticClass().DefaultObject;

    internal SDOnlineGameInterface() { }

    /// <summary>
    /// Constructs a new SDOnlineGameInterface
    /// </summary>
    public SDOnlineGameInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SDOnlineGameInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SDOnlineGameInterface(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDOnlineGameInterface>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDOnlineGameInterface>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDOnlineGameInterface>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDOnlineGameInterface>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDOnlineGameInterface>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDOnlineGameInterface>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDOnlineGameInterface>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDOnlineGameInterface>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetGlobalChatMode;
    /// <summary>
    /// Function: SetGlobalChatMode
    /// </summary>
    public unsafe virtual void SetGlobalChatMode(bool bEnableGlobalChatMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGlobalChatMode, "SDEngine.SDOnlineGameInterface.SetGlobalChatMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableGlobalChatMode, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetGameSettings;
    /// <summary>
    /// Function: GetGameSettings
    /// </summary>
    public unsafe override BmSDK.Engine.OnlineGameSettings GetGameSettings(BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameSettings, "SDEngine.SDOnlineGameInterface.GetGameSettings");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineGameSettings>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UnregisterPlayers;
    /// <summary>
    /// Function: UnregisterPlayers
    /// </summary>
    public unsafe virtual bool UnregisterPlayers(BmSDK.FName SessionName, in BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterPlayers, "SDEngine.SDOnlineGameInterface.UnregisterPlayers");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Players, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_RegisterPlayers;
    /// <summary>
    /// Function: RegisterPlayers
    /// </summary>
    public unsafe virtual bool RegisterPlayers(BmSDK.FName SessionName, in BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterPlayers, "SDEngine.SDOnlineGameInterface.RegisterPlayers");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Players, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_UnregisterPlayer;
    /// <summary>
    /// Function: UnregisterPlayer
    /// </summary>
    public unsafe override bool UnregisterPlayer(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterPlayer, "SDEngine.SDOnlineGameInterface.UnregisterPlayer");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_RegisterPlayer;
    /// <summary>
    /// Function: RegisterPlayer
    /// </summary>
    public unsafe override bool RegisterPlayer(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bWasInvited)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterPlayer, "SDEngine.SDOnlineGameInterface.RegisterPlayer");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasInvited, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetSessionDetails;
    /// <summary>
    /// Function: GetSessionDetails
    /// </summary>
    public unsafe override BmSDK.Engine.OnlineSubsystem.FSessionDetails GetSessionDetails(BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSessionDetails, "SDEngine.SDOnlineGameInterface.GetSessionDetails");
        byte* paramsPtr = stackalloc byte[588];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FSessionDetails>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetResolvedConnectString;
    /// <summary>
    /// Function: GetResolvedConnectString
    /// </summary>
    public unsafe override bool GetResolvedConnectString(BmSDK.FName SessionName, out BmSDK.FString ConnectInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetResolvedConnectString, "SDEngine.SDOnlineGameInterface.GetResolvedConnectString");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ConnectInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_EndOnlineGame;
    /// <summary>
    /// Function: EndOnlineGame
    /// </summary>
    public unsafe override bool EndOnlineGame(BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndOnlineGame, "SDEngine.SDOnlineGameInterface.EndOnlineGame");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UpdateOnlineGame;
    /// <summary>
    /// Function: UpdateOnlineGame
    /// </summary>
    public unsafe override bool UpdateOnlineGame(BmSDK.FName SessionName, BmSDK.Engine.OnlineGameSettings UpdatedGameSettings, bool bShouldRefreshOnlineData = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateOnlineGame, "SDEngine.SDOnlineGameInterface.UpdateOnlineGame");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdatedGameSettings, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldRefreshOnlineData, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_StartOnlineGame;
    /// <summary>
    /// Function: StartOnlineGame
    /// </summary>
    public unsafe override bool StartOnlineGame(BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartOnlineGame, "SDEngine.SDOnlineGameInterface.StartOnlineGame");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_JoinOnlineGame;
    /// <summary>
    /// Function: JoinOnlineGame
    /// </summary>
    public unsafe override bool JoinOnlineGame(byte PlayerNum, BmSDK.FName SessionName, in BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult DesiredGame)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JoinOnlineGame, "SDEngine.SDOnlineGameInterface.JoinOnlineGame");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredGame, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_DestroyOnlineGame;
    /// <summary>
    /// Function: DestroyOnlineGame
    /// </summary>
    public unsafe override bool DestroyOnlineGame(BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyOnlineGame, "SDEngine.SDOnlineGameInterface.DestroyOnlineGame");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CreateOnlineGame;
    /// <summary>
    /// Function: CreateOnlineGame
    /// </summary>
    public unsafe override bool CreateOnlineGame(byte HostingPlayerNum, BmSDK.FName SessionName, BmSDK.Engine.OnlineGameSettings NewGameSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateOnlineGame, "SDEngine.SDOnlineGameInterface.CreateOnlineGame");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HostingPlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGameSettings, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ManageInvites;
    /// <summary>
    /// Function: ManageInvites
    /// </summary>
    public unsafe virtual void ManageInvites()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManageInvites, "SDEngine.SDOnlineGameInterface.ManageInvites");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadPlatformSpecificSessionInfoBySessionName;
    /// <summary>
    /// Function: ReadPlatformSpecificSessionInfoBySessionName
    /// </summary>
    public unsafe override bool ReadPlatformSpecificSessionInfoBySessionName(BmSDK.FName SessionName, out byte PlatformSpecificInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadPlatformSpecificSessionInfoBySessionName, "SDEngine.SDOnlineGameInterface.ReadPlatformSpecificSessionInfoBySessionName");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlatformSpecificInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformSpecificInfo, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlatformSpecificInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_NotifyGameInviteAccepted;
    /// <summary>
    /// Function: NotifyGameInviteAccepted
    /// </summary>
    public unsafe virtual void NotifyGameInviteAccepted(byte LocalUserNum, in BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult InviteResult)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyGameInviteAccepted, "SDEngine.SDOnlineGameInterface.NotifyGameInviteAccepted");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteResult, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearGameInviteAcceptedDelegate;
    /// <summary>
    /// Function: ClearGameInviteAcceptedDelegate
    /// </summary>
    public unsafe override void ClearGameInviteAcceptedDelegate(byte LocalUserNum, System.IntPtr GameInviteAcceptedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGameInviteAcceptedDelegate, "SDEngine.SDOnlineGameInterface.ClearGameInviteAcceptedDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameInviteAcceptedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGameInviteAcceptedDelegate;
    /// <summary>
    /// Function: AddGameInviteAcceptedDelegate
    /// </summary>
    public unsafe override void AddGameInviteAcceptedDelegate(byte LocalUserNum, System.IntPtr GameInviteAcceptedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGameInviteAcceptedDelegate, "SDEngine.SDOnlineGameInterface.AddGameInviteAcceptedDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameInviteAcceptedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// InlineArray{StructProperty}: GameInviteAcceptedDelegates
    /// </summary>
    public InlineArray<BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks> GameInviteAcceptedDelegates => new(8, Ptr + 424, 12, this);

    /// <summary>
    /// StructProperty: GameInviteAcceptedDelegates
    /// </summary>
    public unsafe ref BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks GameInviteAcceptedDelegates_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks>(Ptr + 424);
    /// <summary>
    /// StructProperty: GameInviteAcceptedDelegates
    /// </summary>
    public unsafe ref BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks GameInviteAcceptedDelegates_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks>(Ptr + 436);
    /// <summary>
    /// StructProperty: GameInviteAcceptedDelegates
    /// </summary>
    public unsafe ref BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks GameInviteAcceptedDelegates_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks>(Ptr + 448);
    /// <summary>
    /// StructProperty: GameInviteAcceptedDelegates
    /// </summary>
    public unsafe ref BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks GameInviteAcceptedDelegates_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks>(Ptr + 460);
    /// <summary>
    /// StructProperty: GameInviteAcceptedDelegates
    /// </summary>
    public unsafe ref BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks GameInviteAcceptedDelegates_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks>(Ptr + 472);
    /// <summary>
    /// StructProperty: GameInviteAcceptedDelegates
    /// </summary>
    public unsafe ref BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks GameInviteAcceptedDelegates_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks>(Ptr + 484);
    /// <summary>
    /// StructProperty: GameInviteAcceptedDelegates
    /// </summary>
    public unsafe ref BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks GameInviteAcceptedDelegates_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks>(Ptr + 496);
    /// <summary>
    /// StructProperty: GameInviteAcceptedDelegates
    /// </summary>
    public unsafe ref BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks GameInviteAcceptedDelegates_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.SDEngine.SDOnlineGameInterface.FGameInviteAcceptedCallbacks>(Ptr + 508);

    /// <summary>
    /// Struct: FGameInviteAcceptedCallbacks
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FGameInviteAcceptedCallbacks
    {
        /// <summary>
        /// ArrayProperty: Callbacks
        /// </summary>
        public unsafe BmSDK.TArray<System.IntPtr> Callbacks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }
}
