#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: OnlineGameInterfaceSteamworks<br/>
/// (size = 544)
/// (flags = 134217878)
/// </summary>
public partial class OnlineGameInterfaceSteamworks : BmSDK.IpDrv.OnlineGameInterfaceImpl, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as OnlineGameInterfaceSteamworks.
    /// </summary>
    public static OnlineGameInterfaceSteamworks DefaultObject => (OnlineGameInterfaceSteamworks)StaticClass().DefaultObject;

    internal OnlineGameInterfaceSteamworks() { }

    /// <summary>
    /// Constructs a new OnlineGameInterfaceSteamworks
    /// </summary>
    public OnlineGameInterfaceSteamworks(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineGameInterfaceSteamworks Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineGameInterfaceSteamworks(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceSteamworks>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceSteamworks>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceSteamworks>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceSteamworks>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceSteamworks>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceSteamworks>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceSteamworks>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceSteamworks>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_QueryNonAdvertisedData;
    /// <summary>
    /// Function: QueryNonAdvertisedData
    /// </summary>
    public unsafe virtual bool QueryNonAdvertisedData(int StartAt, int NumberToQuery)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueryNonAdvertisedData, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.QueryNonAdvertisedData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartAt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumberToQuery, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearUnregisterPlayerCompleteDelegate;
    /// <summary>
    /// Function: ClearUnregisterPlayerCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearUnregisterPlayerCompleteDelegate(System.IntPtr UnregisterPlayerCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearUnregisterPlayerCompleteDelegate, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.ClearUnregisterPlayerCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnregisterPlayerCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddUnregisterPlayerCompleteDelegate;
    /// <summary>
    /// Function: AddUnregisterPlayerCompleteDelegate
    /// </summary>
    public unsafe virtual void AddUnregisterPlayerCompleteDelegate(System.IntPtr UnregisterPlayerCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUnregisterPlayerCompleteDelegate, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.AddUnregisterPlayerCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnregisterPlayerCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnUnregisterPlayerComplete;
    /// <summary>
    /// Function: OnUnregisterPlayerComplete
    /// </summary>
    public unsafe override void OnUnregisterPlayerComplete(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnUnregisterPlayerComplete, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.OnUnregisterPlayerComplete");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnregisterPlayer;
    /// <summary>
    /// Function: UnregisterPlayer
    /// </summary>
    public unsafe override bool UnregisterPlayer(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterPlayer, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.UnregisterPlayer");
        byte* paramsPtr = stackalloc byte[72];
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_ClearRegisterPlayerCompleteDelegate;
    /// <summary>
    /// Function: ClearRegisterPlayerCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearRegisterPlayerCompleteDelegate(System.IntPtr RegisterPlayerCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRegisterPlayerCompleteDelegate, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.ClearRegisterPlayerCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterPlayerCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddRegisterPlayerCompleteDelegate;
    /// <summary>
    /// Function: AddRegisterPlayerCompleteDelegate
    /// </summary>
    public unsafe virtual void AddRegisterPlayerCompleteDelegate(System.IntPtr RegisterPlayerCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRegisterPlayerCompleteDelegate, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.AddRegisterPlayerCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterPlayerCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRegisterPlayerComplete;
    /// <summary>
    /// Function: OnRegisterPlayerComplete
    /// </summary>
    public unsafe override void OnRegisterPlayerComplete(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRegisterPlayerComplete, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.OnRegisterPlayerComplete");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterPlayer;
    /// <summary>
    /// Function: RegisterPlayer
    /// </summary>
    public unsafe override bool RegisterPlayer(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bWasInvited)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterPlayer, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.RegisterPlayer");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasInvited, paramsPtr + 52);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_AcceptGameInvite;
    /// <summary>
    /// Function: AcceptGameInvite
    /// </summary>
    public unsafe override bool AcceptGameInvite(byte LocalUserNum, BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AcceptGameInvite, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.AcceptGameInvite");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 4);
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

    private static BmSDK.Function __fn_OnGameInviteAccepted;
    /// <summary>
    /// Function: OnGameInviteAccepted
    /// </summary>
    public unsafe override void OnGameInviteAccepted(in BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult InviteResult)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGameInviteAccepted, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.OnGameInviteAccepted");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteResult, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGameInviteAcceptedDelegate, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.ClearGameInviteAcceptedDelegate");
        byte* paramsPtr = stackalloc byte[36];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGameInviteAcceptedDelegate, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.AddGameInviteAcceptedDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameInviteAcceptedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateOnlineGame;
    /// <summary>
    /// Function: UpdateOnlineGame
    /// </summary>
    public unsafe virtual bool UpdateOnlineGame(BmSDK.FName SessionName, BmSDK.Engine.OnlineGameSettings UpdatedGameSettings, bool bShouldRefreshOnlineData = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateOnlineGame, "OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.UpdateOnlineGame");
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

    /// <summary>
    /// Enum: ESteamMatchmakingType
    /// </summary>
    public enum ESteamMatchmakingType : byte
    {
        SMT_Invalid = 0,
        SMT_LAN = 1,
        SMT_Internet = 2,
        SMT_MAX = 3,
    }

    /// <summary>
    /// Struct: FServerQueryToPingResponseMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FServerQueryToPingResponseMapping
    {
        /// <summary>
        /// IntProperty: Query
        /// </summary>
        public unsafe int Query
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Response
        /// </summary>
        public unsafe System.IntPtr Response
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: QueryToRulesResponseMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FServerQueryToRulesResponseMapping> QueryToRulesResponseMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FServerQueryToRulesResponseMapping>>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ArrayProperty: QueryToPingResponseMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FServerQueryToPingResponseMapping> QueryToPingResponseMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.FServerQueryToPingResponseMapping>>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// StructProperty: ServerListResponse
    /// </summary>
    public unsafe System.IntPtr ServerListResponse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ByteProperty: CurrentMatchmakingType
    /// </summary>
    public unsafe BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.ESteamMatchmakingType CurrentMatchmakingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks.ESteamMatchmakingType>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// StructProperty: CurrentMatchmakingQuery
    /// </summary>
    public unsafe System.IntPtr CurrentMatchmakingQuery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ArrayProperty: GameInviteAcceptedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> GameInviteAcceptedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: InviteGameSearch
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSearch InviteGameSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSearch>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// StrProperty: InviteLocationUrl
    /// </summary>
    public unsafe BmSDK.FString InviteLocationUrl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ArrayProperty: RegisterPlayerCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> RegisterPlayerCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ArrayProperty: UnregisterPlayerCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> UnregisterPlayerCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// DelegateProperty: __OnGameInviteAccepted__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnGameInviteAccepted__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// DelegateProperty: __OnRegisterPlayerComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRegisterPlayerComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// DelegateProperty: __OnUnregisterPlayerComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnUnregisterPlayerComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// Struct: FServerQueryToRulesResponseMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FServerQueryToRulesResponseMapping
    {
        /// <summary>
        /// IntProperty: Query
        /// </summary>
        public unsafe int Query
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Response
        /// </summary>
        public unsafe System.IntPtr Response
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
