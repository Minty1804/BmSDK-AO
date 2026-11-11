#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: OnlineLobbyInterfaceSteamworks<br/>
/// (size = 372)
/// (flags = 134250646)
/// </summary>
public partial class OnlineLobbyInterfaceSteamworks : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as OnlineLobbyInterfaceSteamworks.
    /// </summary>
    public static OnlineLobbyInterfaceSteamworks DefaultObject => (OnlineLobbyInterfaceSteamworks)StaticClass().DefaultObject;

    internal OnlineLobbyInterfaceSteamworks() { }

    /// <summary>
    /// Constructs a new OnlineLobbyInterfaceSteamworks
    /// </summary>
    public OnlineLobbyInterfaceSteamworks(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineLobbyInterfaceSteamworks Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineLobbyInterfaceSteamworks(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineLobbyInterfaceSteamworks>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineLobbyInterfaceSteamworks>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineLobbyInterfaceSteamworks>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineLobbyInterfaceSteamworks>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineLobbyInterfaceSteamworks>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineLobbyInterfaceSteamworks>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineLobbyInterfaceSteamworks>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineLobbyInterfaceSteamworks>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetLobbyFromCommandline;
    /// <summary>
    /// Function: GetLobbyFromCommandline
    /// </summary>
    public unsafe virtual bool GetLobbyFromCommandline(out BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, bool bMarkAsJoined = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyFromCommandline, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.GetLobbyFromCommandline");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out LobbyId);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMarkAsJoined, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LobbyId = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearLobbyInviteDelegate;
    /// <summary>
    /// Function: ClearLobbyInviteDelegate
    /// </summary>
    public unsafe virtual void ClearLobbyInviteDelegate(System.IntPtr LobbyInviteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLobbyInviteDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.ClearLobbyInviteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyInviteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLobbyInviteDelegate;
    /// <summary>
    /// Function: AddLobbyInviteDelegate
    /// </summary>
    public unsafe virtual void AddLobbyInviteDelegate(System.IntPtr LobbyInviteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLobbyInviteDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.AddLobbyInviteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyInviteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLobbyInvite;
    /// <summary>
    /// Function: OnLobbyInvite
    /// </summary>
    public unsafe virtual void OnLobbyInvite(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, BmSDK.Engine.OnlineSubsystem.FUniqueNetId FriendId, bool bAccepted)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbyInvite, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.OnLobbyInvite");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendId, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAccepted, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InviteToLobby;
    /// <summary>
    /// Function: InviteToLobby
    /// </summary>
    public unsafe virtual bool InviteToLobby(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InviteToLobby, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.InviteToLobby");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetLobbyOwner;
    /// <summary>
    /// Function: SetLobbyOwner
    /// </summary>
    public unsafe virtual bool SetLobbyOwner(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NewOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLobbyOwner, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.SetLobbyOwner");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetLobbyLock;
    /// <summary>
    /// Function: SetLobbyLock
    /// </summary>
    public unsafe virtual bool SetLobbyLock(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, bool bLocked)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLobbyLock, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.SetLobbyLock");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLocked, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetLobbyType;
    /// <summary>
    /// Function: SetLobbyType
    /// </summary>
    public unsafe virtual bool SetLobbyType(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.ELobbyVisibility Type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLobbyType, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.SetLobbyType");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetLobbyServer;
    /// <summary>
    /// Function: SetLobbyServer
    /// </summary>
    public unsafe virtual bool SetLobbyServer(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, BmSDK.FString ServerIP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLobbyServer, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.SetLobbyServer");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_RemoveLobbySetting;
    /// <summary>
    /// Function: RemoveLobbySetting
    /// </summary>
    public unsafe virtual bool RemoveLobbySetting(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, BmSDK.FString Key)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveLobbySetting, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.RemoveLobbySetting");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetLobbySetting;
    /// <summary>
    /// Function: SetLobbySetting
    /// </summary>
    public unsafe virtual bool SetLobbySetting(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, BmSDK.FString Key, BmSDK.FString Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLobbySetting, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.SetLobbySetting");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetLobbyAdmin;
    /// <summary>
    /// Function: GetLobbyAdmin
    /// </summary>
    public unsafe virtual bool GetLobbyAdmin(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, out BmSDK.Engine.OnlineSubsystem.FUniqueNetId AdminId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyAdmin, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.GetLobbyAdmin");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AdminId);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AdminId, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        AdminId = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_OnLobbyKicked;
    /// <summary>
    /// Function: OnLobbyKicked
    /// </summary>
    public unsafe virtual void OnLobbyKicked(in BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FActiveLobbyInfo> LobbyList, int LobbyIndex, int AdminIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbyKicked, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.OnLobbyKicked");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AdminIndex, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLobbyJoinGameDelegate;
    /// <summary>
    /// Function: ClearLobbyJoinGameDelegate
    /// </summary>
    public unsafe virtual void ClearLobbyJoinGameDelegate(System.IntPtr LobbyJoinGameDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLobbyJoinGameDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.ClearLobbyJoinGameDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyJoinGameDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLobbyJoinGameDelegate;
    /// <summary>
    /// Function: AddLobbyJoinGameDelegate
    /// </summary>
    public unsafe virtual void AddLobbyJoinGameDelegate(System.IntPtr LobbyJoinGameDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLobbyJoinGameDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.AddLobbyJoinGameDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyJoinGameDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerLobbyJoinGameDelegates;
    /// <summary>
    /// Function: TriggerLobbyJoinGameDelegates
    /// </summary>
    public unsafe virtual void TriggerLobbyJoinGameDelegates(int LobbyIndex, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerID, BmSDK.FString ServerIP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerLobbyJoinGameDelegates, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.TriggerLobbyJoinGameDelegates");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLobbyJoinGame;
    /// <summary>
    /// Function: OnLobbyJoinGame
    /// </summary>
    public unsafe virtual void OnLobbyJoinGame(in BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FActiveLobbyInfo> LobbyList, int LobbyIndex, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerID, BmSDK.FString ServerIP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbyJoinGame, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.OnLobbyJoinGame");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerID, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLobbyReceiveBinaryDataDelegate;
    /// <summary>
    /// Function: ClearLobbyReceiveBinaryDataDelegate
    /// </summary>
    public unsafe virtual void ClearLobbyReceiveBinaryDataDelegate(System.IntPtr LobbyReceiveBinaryDataDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLobbyReceiveBinaryDataDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.ClearLobbyReceiveBinaryDataDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyReceiveBinaryDataDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLobbyReceiveBinaryDataDelegate;
    /// <summary>
    /// Function: AddLobbyReceiveBinaryDataDelegate
    /// </summary>
    public unsafe virtual void AddLobbyReceiveBinaryDataDelegate(System.IntPtr LobbyReceiveBinaryDataDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLobbyReceiveBinaryDataDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.AddLobbyReceiveBinaryDataDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyReceiveBinaryDataDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerLobbyReceiveBinaryDataDelegates;
    /// <summary>
    /// Function: TriggerLobbyReceiveBinaryDataDelegates
    /// </summary>
    public unsafe virtual void TriggerLobbyReceiveBinaryDataDelegates(int LobbyIndex, int MemberIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerLobbyReceiveBinaryDataDelegates, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.TriggerLobbyReceiveBinaryDataDelegates");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberIndex, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbyReceiveBinaryData, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.OnLobbyReceiveBinaryData");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLobbyReceiveMessageDelegate;
    /// <summary>
    /// Function: ClearLobbyReceiveMessageDelegate
    /// </summary>
    public unsafe virtual void ClearLobbyReceiveMessageDelegate(System.IntPtr LobbyReceiveMessageDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLobbyReceiveMessageDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.ClearLobbyReceiveMessageDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyReceiveMessageDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLobbyReceiveMessageDelegate;
    /// <summary>
    /// Function: AddLobbyReceiveMessageDelegate
    /// </summary>
    public unsafe virtual void AddLobbyReceiveMessageDelegate(System.IntPtr LobbyReceiveMessageDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLobbyReceiveMessageDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.AddLobbyReceiveMessageDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyReceiveMessageDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerLobbyReceiveMessageDelegates;
    /// <summary>
    /// Function: TriggerLobbyReceiveMessageDelegates
    /// </summary>
    public unsafe virtual void TriggerLobbyReceiveMessageDelegates(int LobbyIndex, int MemberIndex, BmSDK.FString Type, BmSDK.FString Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerLobbyReceiveMessageDelegates, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.TriggerLobbyReceiveMessageDelegates");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLobbyReceiveMessage;
    /// <summary>
    /// Function: OnLobbyReceiveMessage
    /// </summary>
    public unsafe virtual void OnLobbyReceiveMessage(in BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FActiveLobbyInfo> LobbyList, int LobbyIndex, int MemberIndex, BmSDK.FString Type, BmSDK.FString Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbyReceiveMessage, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.OnLobbyReceiveMessage");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLobbyMemberStatusUpdateDelegate;
    /// <summary>
    /// Function: ClearLobbyMemberStatusUpdateDelegate
    /// </summary>
    public unsafe virtual void ClearLobbyMemberStatusUpdateDelegate(System.IntPtr LobbyMemberStatusUpdateDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLobbyMemberStatusUpdateDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.ClearLobbyMemberStatusUpdateDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyMemberStatusUpdateDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLobbyMemberStatusUpdateDelegate;
    /// <summary>
    /// Function: AddLobbyMemberStatusUpdateDelegate
    /// </summary>
    public unsafe virtual void AddLobbyMemberStatusUpdateDelegate(System.IntPtr LobbyMemberStatusUpdateDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLobbyMemberStatusUpdateDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.AddLobbyMemberStatusUpdateDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyMemberStatusUpdateDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerLobbyMemberStatusUpdateDelegates;
    /// <summary>
    /// Function: TriggerLobbyMemberStatusUpdateDelegates
    /// </summary>
    public unsafe virtual void TriggerLobbyMemberStatusUpdateDelegates(int LobbyIndex, int MemberIndex, int InstigatorIndex, BmSDK.FString Status)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerLobbyMemberStatusUpdateDelegates, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.TriggerLobbyMemberStatusUpdateDelegates");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatorIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Status, paramsPtr + 12);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbyMemberStatusUpdate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.OnLobbyMemberStatusUpdate");
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

    private static BmSDK.Function __fn_ClearLobbyMemberSettingsUpdateDelegate;
    /// <summary>
    /// Function: ClearLobbyMemberSettingsUpdateDelegate
    /// </summary>
    public unsafe virtual void ClearLobbyMemberSettingsUpdateDelegate(System.IntPtr LobbyMemberSettingsUpdateDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLobbyMemberSettingsUpdateDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.ClearLobbyMemberSettingsUpdateDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyMemberSettingsUpdateDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLobbyMemberSettingsUpdateDelegate;
    /// <summary>
    /// Function: AddLobbyMemberSettingsUpdateDelegate
    /// </summary>
    public unsafe virtual void AddLobbyMemberSettingsUpdateDelegate(System.IntPtr LobbyMemberSettingsUpdateDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLobbyMemberSettingsUpdateDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.AddLobbyMemberSettingsUpdateDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyMemberSettingsUpdateDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerLobbyMemberSettingsUpdateDelegates;
    /// <summary>
    /// Function: TriggerLobbyMemberSettingsUpdateDelegates
    /// </summary>
    public unsafe virtual void TriggerLobbyMemberSettingsUpdateDelegates(int LobbyIndex, int MemberIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerLobbyMemberSettingsUpdateDelegates, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.TriggerLobbyMemberSettingsUpdateDelegates");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLobbyMemberSettingsUpdate;
    /// <summary>
    /// Function: OnLobbyMemberSettingsUpdate
    /// </summary>
    public unsafe virtual void OnLobbyMemberSettingsUpdate(in BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FActiveLobbyInfo> LobbyList, int LobbyIndex, int MemberIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbyMemberSettingsUpdate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.OnLobbyMemberSettingsUpdate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberIndex, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLobbySettingsUpdateDelegate;
    /// <summary>
    /// Function: ClearLobbySettingsUpdateDelegate
    /// </summary>
    public unsafe virtual void ClearLobbySettingsUpdateDelegate(System.IntPtr LobbySettingsUpdateDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLobbySettingsUpdateDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.ClearLobbySettingsUpdateDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbySettingsUpdateDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLobbySettingsUpdateDelegate;
    /// <summary>
    /// Function: AddLobbySettingsUpdateDelegate
    /// </summary>
    public unsafe virtual void AddLobbySettingsUpdateDelegate(System.IntPtr LobbySettingsUpdateDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLobbySettingsUpdateDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.AddLobbySettingsUpdateDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbySettingsUpdateDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerLobbySettingsUpdateDelegates;
    /// <summary>
    /// Function: TriggerLobbySettingsUpdateDelegates
    /// </summary>
    public unsafe virtual void TriggerLobbySettingsUpdateDelegates(int LobbyIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerLobbySettingsUpdateDelegates, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.TriggerLobbySettingsUpdateDelegates");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbySettingsUpdate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.OnLobbySettingsUpdate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendLobbyBinaryData;
    /// <summary>
    /// Function: SendLobbyBinaryData
    /// </summary>
    public unsafe virtual bool SendLobbyBinaryData(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, in BmSDK.TArray<byte> Data)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendLobbyBinaryData, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.SendLobbyBinaryData");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SendLobbyMessage;
    /// <summary>
    /// Function: SendLobbyMessage
    /// </summary>
    public unsafe virtual bool SendLobbyMessage(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, BmSDK.FString Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendLobbyMessage, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.SendLobbyMessage");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetLobbyUserSetting;
    /// <summary>
    /// Function: SetLobbyUserSetting
    /// </summary>
    public unsafe virtual bool SetLobbyUserSetting(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, BmSDK.FString Key, BmSDK.FString Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLobbyUserSetting, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.SetLobbyUserSetting");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_LeaveAllLobbies;
    /// <summary>
    /// Function: LeaveAllLobbies
    /// </summary>
    public unsafe virtual bool LeaveAllLobbies()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LeaveAllLobbies, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.LeaveAllLobbies");
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

    private static BmSDK.Function __fn_LeaveLobby;
    /// <summary>
    /// Function: LeaveLobby
    /// </summary>
    public unsafe virtual bool LeaveLobby(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LeaveLobby, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.LeaveLobby");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetLobbyMemberLimit;
    /// <summary>
    /// Function: GetLobbyMemberLimit
    /// </summary>
    public unsafe virtual int GetLobbyMemberLimit(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyMemberLimit, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.GetLobbyMemberLimit");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearJoinLobbyCompleteDelegate;
    /// <summary>
    /// Function: ClearJoinLobbyCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearJoinLobbyCompleteDelegate(System.IntPtr JoinLobbyCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearJoinLobbyCompleteDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.ClearJoinLobbyCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JoinLobbyCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddJoinLobbyCompleteDelegate;
    /// <summary>
    /// Function: AddJoinLobbyCompleteDelegate
    /// </summary>
    public unsafe virtual void AddJoinLobbyCompleteDelegate(System.IntPtr JoinLobbyCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddJoinLobbyCompleteDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.AddJoinLobbyCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JoinLobbyCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerJoinLobbyCompleteDelegates;
    /// <summary>
    /// Function: TriggerJoinLobbyCompleteDelegates
    /// </summary>
    public unsafe virtual void TriggerJoinLobbyCompleteDelegates(bool bWasSuccessful, int LobbyIndex, BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyUID, BmSDK.FString Error)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerJoinLobbyCompleteDelegates, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.TriggerJoinLobbyCompleteDelegates");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyUID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Error, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnJoinLobbyComplete;
    /// <summary>
    /// Function: OnJoinLobbyComplete
    /// </summary>
    public unsafe virtual void OnJoinLobbyComplete(bool bWasSuccessful, in BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FActiveLobbyInfo> LobbyList, int LobbyIndex, BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyUID, BmSDK.FString Error)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnJoinLobbyComplete, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.OnJoinLobbyComplete");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyList, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyUID, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Error, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JoinLobby;
    /// <summary>
    /// Function: JoinLobby
    /// </summary>
    public unsafe virtual bool JoinLobby(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JoinLobby, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.JoinLobby");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearFindLobbiesCompleteDelegate;
    /// <summary>
    /// Function: ClearFindLobbiesCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearFindLobbiesCompleteDelegate(System.IntPtr FindLobbiesCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFindLobbiesCompleteDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.ClearFindLobbiesCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FindLobbiesCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFindLobbiesCompleteDelegate;
    /// <summary>
    /// Function: AddFindLobbiesCompleteDelegate
    /// </summary>
    public unsafe virtual void AddFindLobbiesCompleteDelegate(System.IntPtr FindLobbiesCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFindLobbiesCompleteDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.AddFindLobbiesCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FindLobbiesCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerFindLobbiesCompleteDelegates;
    /// <summary>
    /// Function: TriggerFindLobbiesCompleteDelegates
    /// </summary>
    public unsafe virtual void TriggerFindLobbiesCompleteDelegates(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFindLobbiesCompleteDelegates, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.TriggerFindLobbiesCompleteDelegates");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFindLobbiesComplete;
    /// <summary>
    /// Function: OnFindLobbiesComplete
    /// </summary>
    public unsafe virtual void OnFindLobbiesComplete(bool bWasSuccessful, in BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FBasicLobbyInfo> LobbyList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFindLobbiesComplete, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.OnFindLobbiesComplete");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyList, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateFoundLobbies;
    /// <summary>
    /// Function: UpdateFoundLobbies
    /// </summary>
    public unsafe virtual bool UpdateFoundLobbies(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFoundLobbies, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.UpdateFoundLobbies");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FindLobbies;
    /// <summary>
    /// Function: FindLobbies
    /// </summary>
    public unsafe virtual bool FindLobbies(int MaxResults = default, BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FLobbyFilter> Filters = default, BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FLobbySortFilter> SortFilters = default, int MinSlots = default, BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.ELobbyDistance Distance = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindLobbies, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FindLobbies");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxResults, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filters, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SortFilters, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinSlots, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Distance, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ClearCreateLobbyCompleteDelegate;
    /// <summary>
    /// Function: ClearCreateLobbyCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearCreateLobbyCompleteDelegate(System.IntPtr CreateLobbyCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCreateLobbyCompleteDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.ClearCreateLobbyCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CreateLobbyCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCreateLobbyCompleteDelegate;
    /// <summary>
    /// Function: AddCreateLobbyCompleteDelegate
    /// </summary>
    public unsafe virtual void AddCreateLobbyCompleteDelegate(System.IntPtr CreateLobbyCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCreateLobbyCompleteDelegate, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.AddCreateLobbyCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CreateLobbyCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCreateLobbyComplete;
    /// <summary>
    /// Function: OnCreateLobbyComplete
    /// </summary>
    public unsafe virtual void OnCreateLobbyComplete(bool bWasSuccessful, BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId, BmSDK.FString Error)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCreateLobbyComplete, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.OnCreateLobbyComplete");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Error, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateLobby;
    /// <summary>
    /// Function: CreateLobby
    /// </summary>
    public unsafe virtual bool CreateLobby(int MaxPlayers, BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.ELobbyVisibility Type = default, BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FLobbyMetaData> InitialSettings = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateLobby, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.CreateLobby");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxPlayers, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialSettings, paramsPtr + 8);
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

    /// <summary>
    /// Struct: FActiveLobbyInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FActiveLobbyInfo
    {
        /// <summary>
        /// StructProperty: LobbyUID
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyUID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: LobbySettings
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FLobbyMetaData> LobbySettings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FLobbyMetaData>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: Members
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FSteamLobbyMember> Members
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FSteamLobbyMember>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FSteamLobbyMember
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FSteamLobbyMember
    {
        /// <summary>
        /// StructProperty: PlayerUID
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerUID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: PlayerSettings
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FLobbyMetaData> PlayerSettings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FLobbyMetaData>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FBasicLobbyInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FBasicLobbyInfo
    {
        /// <summary>
        /// StructProperty: LobbyUID
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyUID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: LobbySettings
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FLobbyMetaData> LobbySettings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FLobbyMetaData>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FLobbySortFilter
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FLobbySortFilter
    {
        /// <summary>
        /// StrProperty: Key
        /// </summary>
        public unsafe BmSDK.FString Key
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: TargetValue
        /// </summary>
        public unsafe int TargetValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FLobbyFilter
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FLobbyFilter
    {
        /// <summary>
        /// StrProperty: Key
        /// </summary>
        public unsafe BmSDK.FString Key
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Value
        /// </summary>
        public unsafe BmSDK.FString Value
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: Operator
        /// </summary>
        public unsafe BmSDK.Engine.OnlineGameSearch.EOnlineGameSearchComparisonType Operator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSearch.EOnlineGameSearchComparisonType>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bNumeric
        /// </summary>
        public unsafe bool bNumeric
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Enum: ELobbyDistance
    /// </summary>
    public enum ELobbyDistance : byte
    {
        LD_Best = 0,
        LD_Close = 1,
        LD_Far = 2,
        LD_Any = 3,
        LD_MAX = 4,
    }

    /// <summary>
    /// ArrayProperty: CreateLobbySettings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FLobbyMetaData> CreateLobbySettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FLobbyMetaData>>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// StructProperty: PendingCreateLobbyResult
    /// </summary>
    public unsafe ref BmSDK.Engine.OnlineSubsystem.FUniqueNetId PendingCreateLobbyResult
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 60);

    /// <summary>
    /// ArrayProperty: CreateLobbyCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> CreateLobbyCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bLobbySearchInProgress
    /// </summary>
    public unsafe bool bLobbySearchInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 80); }
    }

    /// <summary>
    /// ArrayProperty: CachedFindLobbyResults
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FBasicLobbyInfo> CachedFindLobbyResults
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FBasicLobbyInfo>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: FindLobbiesCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FindLobbiesCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ArrayProperty: ActiveLobbies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FActiveLobbyInfo> ActiveLobbies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks.FActiveLobbyInfo>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: JoinLobbyCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> JoinLobbyCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// ArrayProperty: LobbyMemberKeys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LobbyMemberKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: LobbySettingsUpdateDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LobbySettingsUpdateDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ArrayProperty: LobbyMemberSettingsUpdateDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LobbyMemberSettingsUpdateDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: LobbyMemberStatusUpdateDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LobbyMemberStatusUpdateDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// ArrayProperty: LobbyReceiveMessageDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LobbyReceiveMessageDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: LobbyReceiveBinaryDataDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LobbyReceiveBinaryDataDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// ArrayProperty: CachedBinaryData
    /// </summary>
    public unsafe BmSDK.TArray<byte> CachedBinaryData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ArrayProperty: LobbyJoinGameDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LobbyJoinGameDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// ArrayProperty: LobbyInviteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LobbyInviteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// DelegateProperty: __OnCreateLobbyComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCreateLobbyComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// DelegateProperty: __OnFindLobbiesComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFindLobbiesComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// DelegateProperty: __OnJoinLobbyComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnJoinLobbyComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// DelegateProperty: __OnLobbySettingsUpdate__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLobbySettingsUpdate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// DelegateProperty: __OnLobbyMemberSettingsUpdate__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLobbyMemberSettingsUpdate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// DelegateProperty: __OnLobbyMemberStatusUpdate__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLobbyMemberStatusUpdate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// DelegateProperty: __OnLobbyReceiveMessage__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLobbyReceiveMessage__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// DelegateProperty: __OnLobbyReceiveBinaryData__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLobbyReceiveBinaryData__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// DelegateProperty: __OnLobbyJoinGame__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLobbyJoinGame__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// DelegateProperty: __OnLobbyKicked__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLobbyKicked__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// DelegateProperty: __OnLobbyInvite__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLobbyInvite__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// Struct: FLobbyMetaData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FLobbyMetaData
    {
        /// <summary>
        /// StrProperty: Key
        /// </summary>
        public unsafe BmSDK.FString Key
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Value
        /// </summary>
        public unsafe BmSDK.FString Value
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: ELobbyVisibility
    /// </summary>
    public enum ELobbyVisibility : byte
    {
        LV_Public = 0,
        LV_Friends = 1,
        LV_Private = 2,
        LV_Invisible = 3,
        LV_MAX = 4,
    }
}
