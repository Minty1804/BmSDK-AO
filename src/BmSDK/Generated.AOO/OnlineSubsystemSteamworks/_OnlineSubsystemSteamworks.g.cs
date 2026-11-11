#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: _OnlineSubsystemSteamworks<br/>
/// (size = 2852)
/// (flags = 134250678)
/// </summary>
public partial class _OnlineSubsystemSteamworks : BmSDK.IpDrv.OnlineSubsystemCommonImpl, BmSDK.Engine.OnlinePlayerInterface, BmSDK.Engine.OnlinePlayerInterfaceEx, BmSDK.Engine.OnlineVoiceInterface, BmSDK.Engine.OnlineStatsInterface, BmSDK.Engine.OnlineSystemInterface, BmSDK.Engine.OnlineAccountInterface, BmSDK.Engine.UserCloudFileInterface, BmSDK.Engine.SharedCloudFileInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as _OnlineSubsystemSteamworks.
    /// </summary>
    public static _OnlineSubsystemSteamworks DefaultObject => (_OnlineSubsystemSteamworks)StaticClass().DefaultObject;

    internal _OnlineSubsystemSteamworks() { }

    /// <summary>
    /// Constructs a new _OnlineSubsystemSteamworks
    /// </summary>
    public _OnlineSubsystemSteamworks(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, _OnlineSubsystemSteamworks Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected _OnlineSubsystemSteamworks(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<_OnlineSubsystemSteamworks>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetSessionRegistrants;
    /// <summary>
    /// Function: GetSessionRegistrants
    /// </summary>
    public unsafe override bool GetSessionRegistrants(BmSDK.FName SessionName, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineRegistrant> RegistrantList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSessionRegistrants, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetSessionRegistrants");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RegistrantList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineRegistrant>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SetAllowInviteMessages;
    /// <summary>
    /// Function: SetAllowInviteMessages
    /// </summary>
    public unsafe virtual void SetAllowInviteMessages(bool Allow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllowInviteMessages, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetAllowInviteMessages");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Allow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessBootInviteMessage;
    /// <summary>
    /// Function: ProcessBootInviteMessage
    /// </summary>
    public unsafe virtual bool ProcessBootInviteMessage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessBootInviteMessage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ProcessBootInviteMessage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckBootInviteMessage;
    /// <summary>
    /// Function: CheckBootInviteMessage
    /// </summary>
    public unsafe virtual bool CheckBootInviteMessage(out int AcceptedUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckBootInviteMessage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CheckBootInviteMessage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AcceptedUserNum);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AcceptedUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AcceptedUserNum = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FakeDisconnection;
    /// <summary>
    /// Function: FakeDisconnection
    /// </summary>
    public unsafe virtual void FakeDisconnection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeDisconnection, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.FakeDisconnection");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetOnlineStatsForAllUsers;
    /// <summary>
    /// Function: ResetOnlineStatsForAllUsers
    /// </summary>
    public unsafe virtual bool ResetOnlineStatsForAllUsers(int BoardID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetOnlineStatsForAllUsers, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ResetOnlineStatsForAllUsers");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoardID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ResetOnlineStatsForUser;
    /// <summary>
    /// Function: ResetOnlineStatsForUser
    /// </summary>
    public unsafe virtual bool ResetOnlineStatsForUser(byte LocalUserNum, int BoardID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetOnlineStatsForUser, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ResetOnlineStatsForUser");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoardID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetTimeSinceGuideLastClosed;
    /// <summary>
    /// Function: GetTimeSinceGuideLastClosed
    /// </summary>
    public unsafe virtual float GetTimeSinceGuideLastClosed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeSinceGuideLastClosed, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetTimeSinceGuideLastClosed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearNewInfocastDelegate;
    /// <summary>
    /// Function: ClearNewInfocastDelegate
    /// </summary>
    public unsafe virtual void ClearNewInfocastDelegate(System.IntPtr InfocastDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearNewInfocastDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearNewInfocastDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfocastDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddNewInfocastDelegate;
    /// <summary>
    /// Function: AddNewInfocastDelegate
    /// </summary>
    public unsafe virtual void AddNewInfocastDelegate(System.IntPtr InfocastDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddNewInfocastDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddNewInfocastDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfocastDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnNewInfocast;
    /// <summary>
    /// Function: OnNewInfocast
    /// </summary>
    public unsafe virtual void OnNewInfocast(BmSDK.FString Infocast)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnNewInfocast, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnNewInfocast");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Infocast, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateInfocastSystem;
    /// <summary>
    /// Function: CreateInfocastSystem
    /// </summary>
    public unsafe virtual void CreateInfocastSystem()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateInfocastSystem, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CreateInfocastSystem");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowGuideUI;
    /// <summary>
    /// Function: ShowGuideUI
    /// </summary>
    public unsafe virtual bool ShowGuideUI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowGuideUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowGuideUI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsOnlineAccount;
    /// <summary>
    /// Function: IsOnlineAccount
    /// </summary>
    public unsafe virtual bool IsOnlineAccount(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOnlineAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsOnlineAccount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnLevelLoaded;
    /// <summary>
    /// Function: OnLevelLoaded
    /// </summary>
    public unsafe virtual void OnLevelLoaded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLevelLoaded, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLevelLoaded");
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

    private static BmSDK.Function __fn_ClearAllDelegates;
    /// <summary>
    /// Function: ClearAllDelegates
    /// </summary>
    public unsafe virtual void ClearAllDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAllDelegates, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearAllDelegates");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearMicroTransactionResponseDelegate;
    /// <summary>
    /// Function: ClearMicroTransactionResponseDelegate
    /// </summary>
    public unsafe virtual void ClearMicroTransactionResponseDelegate(System.IntPtr MicroTransactionResponseDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearMicroTransactionResponseDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearMicroTransactionResponseDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MicroTransactionResponseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddMicroTransactionResponseDelegate;
    /// <summary>
    /// Function: AddMicroTransactionResponseDelegate
    /// </summary>
    public unsafe virtual void AddMicroTransactionResponseDelegate(System.IntPtr MicroTransactionResponseDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMicroTransactionResponseDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddMicroTransactionResponseDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MicroTransactionResponseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMicroTransactionResponse;
    /// <summary>
    /// Function: OnMicroTransactionResponse
    /// </summary>
    public unsafe virtual void OnMicroTransactionResponse(BmSDK.FString OrderId, BmSDK.FString AppId, bool Authorized)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMicroTransactionResponse, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnMicroTransactionResponse");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrderId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AppId, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Authorized, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearWriteSharedFileCompleteDelegate;
    /// <summary>
    /// Function: ClearWriteSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWriteSharedFileCompleteDelegate(System.IntPtr WriteSharedFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWriteSharedFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWriteSharedFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddWriteSharedFileCompleteDelegate;
    /// <summary>
    /// Function: AddWriteSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWriteSharedFileCompleteDelegate(System.IntPtr WriteSharedFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWriteSharedFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWriteSharedFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WriteSharedFile;
    /// <summary>
    /// Function: WriteSharedFile
    /// </summary>
    public unsafe virtual bool WriteSharedFile(BmSDK.FString UserId, BmSDK.FString Filename, in BmSDK.TArray<byte> Contents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteSharedFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteSharedFile");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contents, paramsPtr + 24);
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

    private static BmSDK.Function __fn_OnWriteSharedFileComplete;
    /// <summary>
    /// Function: OnWriteSharedFileComplete
    /// </summary>
    public unsafe virtual void OnWriteSharedFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename, BmSDK.FString SharedHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWriteSharedFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWriteSharedFileComplete");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SharedHandle, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearReadSharedFileCompleteDelegate;
    /// <summary>
    /// Function: ClearReadSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadSharedFileCompleteDelegate(System.IntPtr ReadSharedFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadSharedFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadSharedFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadSharedFileCompleteDelegate;
    /// <summary>
    /// Function: AddReadSharedFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadSharedFileCompleteDelegate(System.IntPtr ReadSharedFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadSharedFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadSharedFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSharedFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadSharedFile;
    /// <summary>
    /// Function: ReadSharedFile
    /// </summary>
    public unsafe virtual bool ReadSharedFile(BmSDK.FString SharedHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadSharedFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadSharedFile");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SharedHandle, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnReadSharedFileComplete;
    /// <summary>
    /// Function: OnReadSharedFileComplete
    /// </summary>
    public unsafe virtual void OnReadSharedFileComplete(bool bWasSuccessful, BmSDK.FString SharedHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadSharedFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadSharedFileComplete");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SharedHandle, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearSharedFile;
    /// <summary>
    /// Function: ClearSharedFile
    /// </summary>
    public unsafe virtual bool ClearSharedFile(BmSDK.FString SharedHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearSharedFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearSharedFile");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SharedHandle, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearSharedFiles;
    /// <summary>
    /// Function: ClearSharedFiles
    /// </summary>
    public unsafe virtual bool ClearSharedFiles()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearSharedFiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearSharedFiles");
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

    private static BmSDK.Function __fn_GetSharedFileContents;
    /// <summary>
    /// Function: GetSharedFileContents
    /// </summary>
    public unsafe virtual bool GetSharedFileContents(BmSDK.FString SharedHandle, out BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSharedFileContents, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetSharedFileContents");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SharedHandle, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ClearDeleteUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearDeleteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearDeleteUserFileCompleteDelegate(System.IntPtr DeleteUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDeleteUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearDeleteUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDeleteUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddDeleteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddDeleteUserFileCompleteDelegate(System.IntPtr DeleteUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDeleteUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddDeleteUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeleteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeleteUserFile;
    /// <summary>
    /// Function: DeleteUserFile
    /// </summary>
    public unsafe virtual bool DeleteUserFile(BmSDK.FString UserId, BmSDK.FString Filename, bool bShouldCloudDelete, bool bShouldLocallyDelete)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteUserFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DeleteUserFile");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldCloudDelete, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldLocallyDelete, paramsPtr + 28);
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

    private static BmSDK.Function __fn_OnDeleteUserFileComplete;
    /// <summary>
    /// Function: OnDeleteUserFileComplete
    /// </summary>
    public unsafe virtual void OnDeleteUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeleteUserFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnDeleteUserFileComplete");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearWriteUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearWriteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWriteUserFileCompleteDelegate(System.IntPtr WriteUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWriteUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWriteUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddWriteUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddWriteUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWriteUserFileCompleteDelegate(System.IntPtr WriteUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWriteUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWriteUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WriteUserFile;
    /// <summary>
    /// Function: WriteUserFile
    /// </summary>
    public unsafe virtual bool WriteUserFile(BmSDK.FString UserId, BmSDK.FString Filename, in BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteUserFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteUserFile");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FileContents, paramsPtr + 24);
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

    private static BmSDK.Function __fn_OnWriteUserFileComplete;
    /// <summary>
    /// Function: OnWriteUserFileComplete
    /// </summary>
    public unsafe virtual void OnWriteUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWriteUserFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWriteUserFileComplete");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearReadUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearReadUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadUserFileCompleteDelegate(System.IntPtr ReadUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddReadUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadUserFileCompleteDelegate(System.IntPtr ReadUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadUserFile;
    /// <summary>
    /// Function: ReadUserFile
    /// </summary>
    public unsafe virtual bool ReadUserFile(BmSDK.FString UserId, BmSDK.FString Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadUserFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadUserFile");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_OnReadUserFileComplete;
    /// <summary>
    /// Function: OnReadUserFileComplete
    /// </summary>
    public unsafe virtual void OnReadUserFileComplete(bool bWasSuccessful, BmSDK.FString UserId, BmSDK.FString Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadUserFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadUserFileComplete");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUserFileList;
    /// <summary>
    /// Function: GetUserFileList
    /// </summary>
    public unsafe virtual void GetUserFileList(BmSDK.FString UserId, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile> UserFiles)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUserFileList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetUserFileList");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        UserFiles = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile>>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_ClearEnumerateUserFileCompleteDelegate;
    /// <summary>
    /// Function: ClearEnumerateUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearEnumerateUserFileCompleteDelegate(System.IntPtr EnumerateUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearEnumerateUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearEnumerateUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnumerateUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddEnumerateUserFileCompleteDelegate;
    /// <summary>
    /// Function: AddEnumerateUserFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddEnumerateUserFileCompleteDelegate(System.IntPtr EnumerateUserFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddEnumerateUserFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddEnumerateUserFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnumerateUserFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnumerateUserFiles;
    /// <summary>
    /// Function: EnumerateUserFiles
    /// </summary>
    public unsafe virtual void EnumerateUserFiles(BmSDK.FString UserId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnumerateUserFiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.EnumerateUserFiles");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnEnumerateUserFilesComplete;
    /// <summary>
    /// Function: OnEnumerateUserFilesComplete
    /// </summary>
    public unsafe virtual void OnEnumerateUserFilesComplete(bool bWasSuccessful, BmSDK.FString UserId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEnumerateUserFilesComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnEnumerateUserFilesComplete");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearFile;
    /// <summary>
    /// Function: ClearFile
    /// </summary>
    public unsafe virtual bool ClearFile(BmSDK.FString UserId, BmSDK.FString Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFile");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ClearFiles;
    /// <summary>
    /// Function: ClearFiles
    /// </summary>
    public unsafe virtual bool ClearFiles(BmSDK.FString UserId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFiles");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetFileContents;
    /// <summary>
    /// Function: GetFileContents
    /// </summary>
    public unsafe virtual bool GetFileContents(BmSDK.FString UserId, BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFileContents, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetFileContents");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_WriteUserFileInternal;
    /// <summary>
    /// Function: WriteUserFileInternal
    /// </summary>
    public unsafe bool WriteUserFileInternal(BmSDK.FString UserId, BmSDK.FString Filename, in BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteUserFileInternal, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteUserFileInternal");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FileContents, paramsPtr + 24);
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

    private static BmSDK.Function __fn_GetFriendJoinURL;
    /// <summary>
    /// Function: GetFriendJoinURL
    /// </summary>
    public unsafe virtual bool GetFriendJoinURL(BmSDK.Engine.OnlineSubsystem.FUniqueNetId FriendUID, out BmSDK.FString ServerURL, out BmSDK.FString ServerUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFriendJoinURL, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetFriendJoinURL");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendUID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ServerURL = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
        ServerUID = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetCommandlineJoinURL;
    /// <summary>
    /// Function: GetCommandlineJoinURL
    /// </summary>
    public unsafe virtual bool GetCommandlineJoinURL(bool bMarkAsJoined, out BmSDK.FString ServerURL, out BmSDK.FString ServerUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCommandlineJoinURL, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetCommandlineJoinURL");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMarkAsJoined, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ServerURL = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
        ServerUID = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_Int64ToUniqueNetId;
    /// <summary>
    /// Function: Int64ToUniqueNetId
    /// </summary>
    public unsafe virtual bool Int64ToUniqueNetId(BmSDK.FString UIDString, out BmSDK.Engine.OnlineSubsystem.FUniqueNetId OutUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Int64ToUniqueNetId, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Int64ToUniqueNetId");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UIDString, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutUID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutUID, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutUID = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_UniqueNetIdToInt64;
    /// <summary>
    /// Function: UniqueNetIdToInt64
    /// </summary>
    public unsafe virtual BmSDK.FString UniqueNetIdToInt64(in BmSDK.Engine.OnlineSubsystem.FUniqueNetId Uid)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UniqueNetIdToInt64, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UniqueNetIdToInt64");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetLobbyInterface;
    /// <summary>
    /// Function: SetLobbyInterface
    /// </summary>
    public unsafe virtual bool SetLobbyInterface(BmSDK.GameObject NewInterface)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLobbyInterface, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetLobbyInterface");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewInterface, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_NotifyVOIPPlaybackFinished;
    /// <summary>
    /// Function: NotifyVOIPPlaybackFinished
    /// </summary>
    public unsafe virtual void NotifyVOIPPlaybackFinished(BmSDK.Engine.AudioComponent VOIPAudioComponent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyVOIPPlaybackFinished, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.NotifyVOIPPlaybackFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VOIPAudioComponent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnVOIPPlaybackFinished;
    /// <summary>
    /// Function: OnVOIPPlaybackFinished
    /// </summary>
    public unsafe virtual void OnVOIPPlaybackFinished(BmSDK.Engine.AudioComponent AC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnVOIPPlaybackFinished, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnVOIPPlaybackFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowProfileUI;
    /// <summary>
    /// Function: ShowProfileUI
    /// </summary>
    public unsafe virtual bool ShowProfileUI(byte LocalUserNum, BmSDK.FString SubURL = default, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerUID = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowProfileUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowProfileUI");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubURL, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerUID, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_UniqueNetIdToPlayerName;
    /// <summary>
    /// Function: UniqueNetIdToPlayerName
    /// </summary>
    public unsafe virtual BmSDK.FString UniqueNetIdToPlayerName(in BmSDK.Engine.OnlineSubsystem.FUniqueNetId Uid)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UniqueNetIdToPlayerName, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UniqueNetIdToPlayerName");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DisplayAchievementProgress;
    /// <summary>
    /// Function: DisplayAchievementProgress
    /// </summary>
    public unsafe virtual bool DisplayAchievementProgress(int AchievementId, int ProgressCount, int MaxProgress)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayAchievementProgress, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DisplayAchievementProgress");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AchievementId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProgressCount, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxProgress, paramsPtr + 8);
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

    private static BmSDK.Function __fn_CreateLeaderboard;
    /// <summary>
    /// Function: CreateLeaderboard
    /// </summary>
    public unsafe virtual bool CreateLeaderboard(BmSDK.FString LeaderboardName, BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardSortType SortType, BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardFormat DisplayFormat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateLeaderboard, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CreateLeaderboard");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeaderboardName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SortType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisplayFormat, paramsPtr + 13);
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

    private static BmSDK.Function __fn_ResetStats;
    /// <summary>
    /// Function: ResetStats
    /// </summary>
    public unsafe virtual bool ResetStats(bool bResetAchievements)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ResetStats");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetAchievements, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShowCustomMessageUI;
    /// <summary>
    /// Function: ShowCustomMessageUI
    /// </summary>
    public unsafe virtual bool ShowCustomMessageUI(byte LocalUserNum, in BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Recipients, BmSDK.FString MessageTitle, BmSDK.FString NonEditableMessage, BmSDK.FString EditableMessage = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCustomMessageUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowCustomMessageUI");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Recipients, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageTitle, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NonEditableMessage, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EditableMessage, paramsPtr + 40);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_ClearCrossTitleProfileSettings;
    /// <summary>
    /// Function: ClearCrossTitleProfileSettings
    /// </summary>
    public unsafe virtual void ClearCrossTitleProfileSettings(byte LocalUserNum, int TitleId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCrossTitleProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearCrossTitleProfileSettings");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCrossTitleProfileSettings;
    /// <summary>
    /// Function: GetCrossTitleProfileSettings
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineProfileSettings GetCrossTitleProfileSettings(byte LocalUserNum, int TitleId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCrossTitleProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetCrossTitleProfileSettings");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineProfileSettings>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearReadCrossTitleProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadCrossTitleProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadCrossTitleProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadCrossTitleProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadCrossTitleProfileSettingsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadCrossTitleProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: AddReadCrossTitleProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadCrossTitleProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadCrossTitleProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadCrossTitleProfileSettingsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadCrossTitleProfileSettingsComplete;
    /// <summary>
    /// Function: OnReadCrossTitleProfileSettingsComplete
    /// </summary>
    public unsafe virtual void OnReadCrossTitleProfileSettingsComplete(byte LocalUserNum, int TitleId, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadCrossTitleProfileSettingsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadCrossTitleProfileSettingsComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadCrossTitleProfileSettings;
    /// <summary>
    /// Function: ReadCrossTitleProfileSettings
    /// </summary>
    public unsafe virtual bool ReadCrossTitleProfileSettings(byte LocalUserNum, int TitleId, BmSDK.Engine.OnlineProfileSettings ProfileSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadCrossTitleProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadCrossTitleProfileSettings");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettings, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_UnlockAvatarAward;
    /// <summary>
    /// Function: UnlockAvatarAward
    /// </summary>
    public unsafe virtual bool UnlockAvatarAward(byte LocalUserNum, int AvatarItemId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockAvatarAward, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnlockAvatarAward");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvatarItemId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetSteamClanData;
    /// <summary>
    /// Function: GetSteamClanData
    /// </summary>
    public unsafe virtual void GetSteamClanData(out BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamPlayerClanData> Results)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSteamClanData, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetSteamClanData");
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
        Results = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamPlayerClanData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ClearGetNumberOfCurrentPlayersCompleteDelegate;
    /// <summary>
    /// Function: ClearGetNumberOfCurrentPlayersCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearGetNumberOfCurrentPlayersCompleteDelegate(System.IntPtr GetNumberOfCurrentPlayersCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGetNumberOfCurrentPlayersCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearGetNumberOfCurrentPlayersCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetNumberOfCurrentPlayersCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGetNumberOfCurrentPlayersCompleteDelegate;
    /// <summary>
    /// Function: AddGetNumberOfCurrentPlayersCompleteDelegate
    /// </summary>
    public unsafe virtual void AddGetNumberOfCurrentPlayersCompleteDelegate(System.IntPtr GetNumberOfCurrentPlayersCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGetNumberOfCurrentPlayersCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddGetNumberOfCurrentPlayersCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetNumberOfCurrentPlayersCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnGetNumberOfCurrentPlayersComplete;
    /// <summary>
    /// Function: OnGetNumberOfCurrentPlayersComplete
    /// </summary>
    public unsafe virtual void OnGetNumberOfCurrentPlayersComplete(int TotalPlayers)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGetNumberOfCurrentPlayersComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnGetNumberOfCurrentPlayersComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalPlayers, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNumberOfCurrentPlayers;
    /// <summary>
    /// Function: GetNumberOfCurrentPlayers
    /// </summary>
    public unsafe virtual bool GetNumberOfCurrentPlayers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumberOfCurrentPlayers, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetNumberOfCurrentPlayers");
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

    private static BmSDK.Function __fn_ReadOnlineAvatar;
    /// <summary>
    /// Function: ReadOnlineAvatar
    /// </summary>
    public unsafe virtual void ReadOnlineAvatar(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId, int Size, System.IntPtr ReadOnlineAvatarCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadOnlineAvatar, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineAvatar");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadOnlineAvatarCompleteDelegate, paramsPtr + 12);
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

    private static BmSDK.Function __fn_OnReadOnlineAvatarComplete;
    /// <summary>
    /// Function: OnReadOnlineAvatarComplete
    /// </summary>
    public unsafe virtual void OnReadOnlineAvatarComplete(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId, BmSDK.Engine.Texture2D Avatar)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadOnlineAvatarComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadOnlineAvatarComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Avatar, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowCustomPlayersUI;
    /// <summary>
    /// Function: ShowCustomPlayersUI
    /// </summary>
    public unsafe virtual bool ShowCustomPlayersUI(byte LocalUserNum, in BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players, BmSDK.FString Title, BmSDK.FString Description)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCustomPlayersUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowCustomPlayersUI");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Players, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetAchievements;
    /// <summary>
    /// Function: GetAchievements
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetAchievements(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FAchievementDetails> Achievements, int TitleId = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAchievements, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetAchievements");
        byte* paramsPtr = stackalloc byte[37];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Achievements = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FAchievementDetails>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ClearReadAchievementsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadAchievementsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadAchievementsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadAchievementsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadAchievementsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadAchievementsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadAchievementsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadAchievementsCompleteDelegate;
    /// <summary>
    /// Function: AddReadAchievementsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadAchievementsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadAchievementsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadAchievementsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadAchievementsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadAchievementsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadAchievementsComplete;
    /// <summary>
    /// Function: OnReadAchievementsComplete
    /// </summary>
    public unsafe virtual void OnReadAchievementsComplete(int TitleId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadAchievementsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadAchievementsComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadAchievements;
    /// <summary>
    /// Function: ReadAchievements
    /// </summary>
    public unsafe virtual bool ReadAchievements(byte LocalUserNum, int TitleId = default, bool bShouldReadText = default, bool bShouldReadImages = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadAchievements, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadAchievements");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldReadText, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldReadImages, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ShowPlayersUI;
    /// <summary>
    /// Function: ShowPlayersUI
    /// </summary>
    public unsafe virtual bool ShowPlayersUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowPlayersUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowPlayersUI");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShowFriendsInviteUI;
    /// <summary>
    /// Function: ShowFriendsInviteUI
    /// </summary>
    public unsafe virtual bool ShowFriendsInviteUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowFriendsInviteUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowFriendsInviteUI");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ShowFriendsUI;
    /// <summary>
    /// Function: ShowFriendsUI
    /// </summary>
    public unsafe virtual bool ShowFriendsUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowFriendsUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowFriendsUI");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClearProfileDataChangedDelegate;
    /// <summary>
    /// Function: ClearProfileDataChangedDelegate
    /// </summary>
    public unsafe virtual void ClearProfileDataChangedDelegate(byte LocalUserNum, System.IntPtr ProfileDataChangedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearProfileDataChangedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearProfileDataChangedDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileDataChangedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddProfileDataChangedDelegate;
    /// <summary>
    /// Function: AddProfileDataChangedDelegate
    /// </summary>
    public unsafe virtual void AddProfileDataChangedDelegate(byte LocalUserNum, System.IntPtr ProfileDataChangedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddProfileDataChangedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddProfileDataChangedDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileDataChangedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnProfileDataChanged;
    /// <summary>
    /// Function: OnProfileDataChanged
    /// </summary>
    public unsafe virtual void OnProfileDataChanged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnProfileDataChanged, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnProfileDataChanged");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockGamerPicture;
    /// <summary>
    /// Function: UnlockGamerPicture
    /// </summary>
    public unsafe virtual bool UnlockGamerPicture(byte LocalUserNum, int PictureId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockGamerPicture, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnlockGamerPicture");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PictureId, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ClearUnlockAchievementCompleteDelegate;
    /// <summary>
    /// Function: ClearUnlockAchievementCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearUnlockAchievementCompleteDelegate(byte LocalUserNum, System.IntPtr UnlockAchievementCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearUnlockAchievementCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearUnlockAchievementCompleteDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockAchievementCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddUnlockAchievementCompleteDelegate;
    /// <summary>
    /// Function: AddUnlockAchievementCompleteDelegate
    /// </summary>
    public unsafe virtual void AddUnlockAchievementCompleteDelegate(byte LocalUserNum, System.IntPtr UnlockAchievementCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUnlockAchievementCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddUnlockAchievementCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockAchievementCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnUnlockAchievementComplete;
    /// <summary>
    /// Function: OnUnlockAchievementComplete
    /// </summary>
    public unsafe virtual void OnUnlockAchievementComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnUnlockAchievementComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnUnlockAchievementComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockAchievement;
    /// <summary>
    /// Function: UnlockAchievement
    /// </summary>
    public unsafe virtual bool UnlockAchievement(byte LocalUserNum, int AchievementId, float PercentComplete = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockAchievement, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnlockAchievement");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AchievementId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PercentComplete, paramsPtr + 8);
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

    private static BmSDK.Function __fn_IsDeviceValid;
    /// <summary>
    /// Function: IsDeviceValid
    /// </summary>
    public unsafe virtual bool IsDeviceValid(int DeviceID, int SizeNeeded = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDeviceValid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsDeviceValid");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SizeNeeded, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetDeviceSelectionResults;
    /// <summary>
    /// Function: GetDeviceSelectionResults
    /// </summary>
    public unsafe virtual int GetDeviceSelectionResults(byte LocalUserNum, out BmSDK.FString DeviceName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDeviceSelectionResults, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetDeviceSelectionResults");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DeviceName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ClearDeviceSelectionDoneDelegate;
    /// <summary>
    /// Function: ClearDeviceSelectionDoneDelegate
    /// </summary>
    public unsafe virtual void ClearDeviceSelectionDoneDelegate(byte LocalUserNum, System.IntPtr DeviceDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDeviceSelectionDoneDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearDeviceSelectionDoneDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDeviceSelectionDoneDelegate;
    /// <summary>
    /// Function: AddDeviceSelectionDoneDelegate
    /// </summary>
    public unsafe virtual void AddDeviceSelectionDoneDelegate(byte LocalUserNum, System.IntPtr DeviceDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDeviceSelectionDoneDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddDeviceSelectionDoneDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeviceSelectionComplete;
    /// <summary>
    /// Function: OnDeviceSelectionComplete
    /// </summary>
    public unsafe virtual void OnDeviceSelectionComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeviceSelectionComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnDeviceSelectionComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowDeviceSelectionUI;
    /// <summary>
    /// Function: ShowDeviceSelectionUI
    /// </summary>
    public unsafe virtual bool ShowDeviceSelectionUI(byte LocalUserNum, int SizeNeeded, bool bForceShowUI = default, bool bManageStorage = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowDeviceSelectionUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowDeviceSelectionUI");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SizeNeeded, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceShowUI, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bManageStorage, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ShowMembershipMarketplaceUI;
    /// <summary>
    /// Function: ShowMembershipMarketplaceUI
    /// </summary>
    public unsafe virtual bool ShowMembershipMarketplaceUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowMembershipMarketplaceUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowMembershipMarketplaceUI");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShowContentMarketplaceUI;
    /// <summary>
    /// Function: ShowContentMarketplaceUI
    /// </summary>
    public unsafe override bool ShowContentMarketplaceUI(byte LocalUserNum, int CategoryMask = default, int OfferId = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowContentMarketplaceUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowContentMarketplaceUI");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CategoryMask, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OfferId, paramsPtr + 8);
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

    private static BmSDK.Function __fn_ShowInviteUI;
    /// <summary>
    /// Function: ShowInviteUI
    /// </summary>
    public unsafe virtual bool ShowInviteUI(byte LocalUserNum, BmSDK.FString InviteText = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowInviteUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowInviteUI");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteText, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ShowAchievementsUI;
    /// <summary>
    /// Function: ShowAchievementsUI
    /// </summary>
    public unsafe virtual bool ShowAchievementsUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowAchievementsUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowAchievementsUI");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShowMessagesUI;
    /// <summary>
    /// Function: ShowMessagesUI
    /// </summary>
    public unsafe virtual bool ShowMessagesUI(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowMessagesUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowMessagesUI");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShowGamerCardUI;
    /// <summary>
    /// Function: ShowGamerCardUI
    /// </summary>
    public unsafe virtual bool ShowGamerCardUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowGamerCardUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowGamerCardUI");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ShowFeedbackUI;
    /// <summary>
    /// Function: ShowFeedbackUI
    /// </summary>
    public unsafe virtual bool ShowFeedbackUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowFeedbackUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowFeedbackUI");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
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

    private static BmSDK.Function __fn_DeleteMessage;
    /// <summary>
    /// Function: DeleteMessage
    /// </summary>
    public unsafe virtual bool DeleteMessage(byte LocalUserNum, int MessageIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteMessage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DeleteMessage");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UnmuteAll;
    /// <summary>
    /// Function: UnmuteAll
    /// </summary>
    public unsafe virtual bool UnmuteAll(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnmuteAll, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnmuteAll");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MuteAll;
    /// <summary>
    /// Function: MuteAll
    /// </summary>
    public unsafe virtual bool MuteAll(byte LocalUserNum, bool bAllowFriends)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MuteAll, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.MuteAll");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowFriends, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CalcAggregateSkill;
    /// <summary>
    /// Function: CalcAggregateSkill
    /// </summary>
    public unsafe virtual void CalcAggregateSkill(BmSDK.TArray<double> Mus, BmSDK.TArray<double> Sigmas, out double OutAggregateMu, out double OutAggregateSigma)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalcAggregateSkill, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CalcAggregateSkill");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Sigmas, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutAggregateMu);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutAggregateMu, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutAggregateSigma);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutAggregateSigma, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutAggregateMu = BmSDK.Framework.MarshalUtil.ToManagedParam<double>(paramsPtr + 24);
        OutAggregateSigma = BmSDK.Framework.MarshalUtil.ToManagedParam<double>(paramsPtr + 32);
        return;
    }

    private static BmSDK.Function __fn_RegisterStatGuid;
    /// <summary>
    /// Function: RegisterStatGuid
    /// </summary>
    public unsafe virtual bool RegisterStatGuid(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, in BmSDK.FString ClientStatGuid)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterStatGuid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RegisterStatGuid");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientStatGuid, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetClientStatGuid;
    /// <summary>
    /// Function: GetClientStatGuid
    /// </summary>
    public unsafe virtual BmSDK.FString GetClientStatGuid()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClientStatGuid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetClientStatGuid");
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

    private static BmSDK.Function __fn_ClearRegisterHostStatGuidCompleteDelegateDelegate;
    /// <summary>
    /// Function: ClearRegisterHostStatGuidCompleteDelegateDelegate
    /// </summary>
    public unsafe virtual void ClearRegisterHostStatGuidCompleteDelegateDelegate(System.IntPtr RegisterHostStatGuidCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRegisterHostStatGuidCompleteDelegateDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearRegisterHostStatGuidCompleteDelegateDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterHostStatGuidCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddRegisterHostStatGuidCompleteDelegate;
    /// <summary>
    /// Function: AddRegisterHostStatGuidCompleteDelegate
    /// </summary>
    public unsafe virtual void AddRegisterHostStatGuidCompleteDelegate(System.IntPtr RegisterHostStatGuidCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRegisterHostStatGuidCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddRegisterHostStatGuidCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterHostStatGuidCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRegisterHostStatGuidComplete;
    /// <summary>
    /// Function: OnRegisterHostStatGuidComplete
    /// </summary>
    public unsafe virtual void OnRegisterHostStatGuidComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRegisterHostStatGuidComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnRegisterHostStatGuidComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterHostStatGuid;
    /// <summary>
    /// Function: RegisterHostStatGuid
    /// </summary>
    public unsafe virtual bool RegisterHostStatGuid(in BmSDK.FString HostStatGuid)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterHostStatGuid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RegisterHostStatGuid");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HostStatGuid, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetHostStatGuid;
    /// <summary>
    /// Function: GetHostStatGuid
    /// </summary>
    public unsafe virtual BmSDK.FString GetHostStatGuid()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHostStatGuid, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetHostStatGuid");
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

    private static BmSDK.Function __fn_ClearFriendMessageReceivedDelegate;
    /// <summary>
    /// Function: ClearFriendMessageReceivedDelegate
    /// </summary>
    public unsafe virtual void ClearFriendMessageReceivedDelegate(byte LocalUserNum, System.IntPtr MessageDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFriendMessageReceivedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFriendMessageReceivedDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFriendMessageReceivedDelegate;
    /// <summary>
    /// Function: AddFriendMessageReceivedDelegate
    /// </summary>
    public unsafe virtual void AddFriendMessageReceivedDelegate(byte LocalUserNum, System.IntPtr MessageDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFriendMessageReceivedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriendMessageReceivedDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFriendMessageReceived;
    /// <summary>
    /// Function: OnFriendMessageReceived
    /// </summary>
    public unsafe virtual void OnFriendMessageReceived(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId SendingPlayer, BmSDK.FString SendingNick, BmSDK.FString Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFriendMessageReceived, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnFriendMessageReceived");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SendingPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SendingNick, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFriendMessages;
    /// <summary>
    /// Function: GetFriendMessages
    /// </summary>
    public unsafe virtual void GetFriendMessages(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriendMessage> FriendMessages)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFriendMessages, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetFriendMessages");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FriendMessages = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriendMessage>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_ClearJoinFriendGameCompleteDelegate;
    /// <summary>
    /// Function: ClearJoinFriendGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearJoinFriendGameCompleteDelegate(System.IntPtr JoinFriendGameCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearJoinFriendGameCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearJoinFriendGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JoinFriendGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddJoinFriendGameCompleteDelegate;
    /// <summary>
    /// Function: AddJoinFriendGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddJoinFriendGameCompleteDelegate(System.IntPtr JoinFriendGameCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddJoinFriendGameCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddJoinFriendGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JoinFriendGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnJoinFriendGameComplete;
    /// <summary>
    /// Function: OnJoinFriendGameComplete
    /// </summary>
    public unsafe virtual void OnJoinFriendGameComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnJoinFriendGameComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnJoinFriendGameComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JoinFriendGame;
    /// <summary>
    /// Function: JoinFriendGame
    /// </summary>
    public unsafe virtual bool JoinFriendGame(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Friend)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JoinFriendGame, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.JoinFriendGame");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Friend, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ClearReceivedGameInviteDelegate;
    /// <summary>
    /// Function: ClearReceivedGameInviteDelegate
    /// </summary>
    public unsafe virtual void ClearReceivedGameInviteDelegate(byte LocalUserNum, System.IntPtr ReceivedGameInviteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReceivedGameInviteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReceivedGameInviteDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReceivedGameInviteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReceivedGameInviteDelegate;
    /// <summary>
    /// Function: AddReceivedGameInviteDelegate
    /// </summary>
    public unsafe virtual void AddReceivedGameInviteDelegate(byte LocalUserNum, System.IntPtr ReceivedGameInviteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReceivedGameInviteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReceivedGameInviteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReceivedGameInviteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReceivedGameInvite;
    /// <summary>
    /// Function: OnReceivedGameInvite
    /// </summary>
    public unsafe virtual void OnReceivedGameInvite(byte LocalUserNum, BmSDK.FString InviterName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReceivedGameInvite, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReceivedGameInvite");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviterName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendGameInviteToFriends;
    /// <summary>
    /// Function: SendGameInviteToFriends
    /// </summary>
    public unsafe virtual bool SendGameInviteToFriends(byte LocalUserNum, BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Friends, BmSDK.FString Text = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendGameInviteToFriends, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SendGameInviteToFriends");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Friends, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 16);
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

    private static BmSDK.Function __fn_SendGameInviteToFriend;
    /// <summary>
    /// Function: SendGameInviteToFriend
    /// </summary>
    public unsafe virtual bool SendGameInviteToFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Friend, BmSDK.FString Text = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendGameInviteToFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SendGameInviteToFriend");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Friend, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_SendMessageToFriend;
    /// <summary>
    /// Function: SendMessageToFriend
    /// </summary>
    public unsafe virtual bool SendMessageToFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Friend, BmSDK.FString Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendMessageToFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SendMessageToFriend");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Friend, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ClearFriendInviteReceivedDelegate;
    /// <summary>
    /// Function: ClearFriendInviteReceivedDelegate
    /// </summary>
    public unsafe virtual void ClearFriendInviteReceivedDelegate(byte LocalUserNum, System.IntPtr InviteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFriendInviteReceivedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFriendInviteReceivedDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFriendInviteReceivedDelegate;
    /// <summary>
    /// Function: AddFriendInviteReceivedDelegate
    /// </summary>
    public unsafe virtual void AddFriendInviteReceivedDelegate(byte LocalUserNum, System.IntPtr InviteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFriendInviteReceivedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriendInviteReceivedDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFriendInviteReceived;
    /// <summary>
    /// Function: OnFriendInviteReceived
    /// </summary>
    public unsafe virtual void OnFriendInviteReceived(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPlayer, BmSDK.FString RequestingNick, BmSDK.FString Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFriendInviteReceived, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnFriendInviteReceived");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingNick, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DenyFriendInvite;
    /// <summary>
    /// Function: DenyFriendInvite
    /// </summary>
    public unsafe virtual bool DenyFriendInvite(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DenyFriendInvite, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DenyFriendInvite");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingPlayer, paramsPtr + 4);
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

    private static BmSDK.Function __fn_AcceptFriendInvite;
    /// <summary>
    /// Function: AcceptFriendInvite
    /// </summary>
    public unsafe virtual bool AcceptFriendInvite(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AcceptFriendInvite, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AcceptFriendInvite");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingPlayer, paramsPtr + 4);
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

    private static BmSDK.Function __fn_RemoveFriend;
    /// <summary>
    /// Function: RemoveFriend
    /// </summary>
    public unsafe virtual bool RemoveFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId FormerFriend)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RemoveFriend");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FormerFriend, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ClearAddFriendByNameCompleteDelegate;
    /// <summary>
    /// Function: ClearAddFriendByNameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearAddFriendByNameCompleteDelegate(byte LocalUserNum, System.IntPtr FriendDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAddFriendByNameCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearAddFriendByNameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddAddFriendByNameCompleteDelegate;
    /// <summary>
    /// Function: AddAddFriendByNameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddAddFriendByNameCompleteDelegate(byte LocalUserNum, System.IntPtr FriendDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddAddFriendByNameCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddAddFriendByNameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAddFriendByNameComplete;
    /// <summary>
    /// Function: OnAddFriendByNameComplete
    /// </summary>
    public unsafe virtual void OnAddFriendByNameComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAddFriendByNameComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnAddFriendByNameComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFriendByName;
    /// <summary>
    /// Function: AddFriendByName
    /// </summary>
    public unsafe virtual bool AddFriendByName(byte LocalUserNum, BmSDK.FString FriendName, BmSDK.FString Message = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFriendByName, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriendByName");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 16);
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

    private static BmSDK.Function __fn_AddFriend;
    /// <summary>
    /// Function: AddFriend
    /// </summary>
    public unsafe virtual bool AddFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NewFriend, BmSDK.FString Message = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriend");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFriend, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetKeyboardInputResults;
    /// <summary>
    /// Function: GetKeyboardInputResults
    /// </summary>
    public unsafe virtual BmSDK.FString GetKeyboardInputResults(out byte bWasCanceled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKeyboardInputResults, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetKeyboardInputResults");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bWasCanceled);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasCanceled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bWasCanceled = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClearKeyboardInputDoneDelegate;
    /// <summary>
    /// Function: ClearKeyboardInputDoneDelegate
    /// </summary>
    public unsafe virtual void ClearKeyboardInputDoneDelegate(System.IntPtr InputDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearKeyboardInputDoneDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearKeyboardInputDoneDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InputDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddKeyboardInputDoneDelegate;
    /// <summary>
    /// Function: AddKeyboardInputDoneDelegate
    /// </summary>
    public unsafe virtual void AddKeyboardInputDoneDelegate(System.IntPtr InputDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddKeyboardInputDoneDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddKeyboardInputDoneDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InputDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnKeyboardInputComplete;
    /// <summary>
    /// Function: OnKeyboardInputComplete
    /// </summary>
    public unsafe virtual void OnKeyboardInputComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnKeyboardInputComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnKeyboardInputComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowKeyboardUI;
    /// <summary>
    /// Function: ShowKeyboardUI
    /// </summary>
    public unsafe virtual bool ShowKeyboardUI(byte LocalUserNum, BmSDK.FString TitleText, BmSDK.FString DescriptionText, bool bIsPassword = default, bool bShouldValidate = default, BmSDK.FString DefaultText = default, int MaxResultLength = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowKeyboardUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowKeyboardUI");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleText, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DescriptionText, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPassword, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldValidate, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultText, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxResultLength, paramsPtr + 48);
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

    private static BmSDK.Function __fn_SetOnlineStatus;
    /// <summary>
    /// Function: SetOnlineStatus
    /// </summary>
    public unsafe virtual void SetOnlineStatus(byte LocalUserNum, int StatusId, in BmSDK.TArray<BmSDK.Engine.Settings.FLocalizedStringSetting> LocalizedStringSettings, in BmSDK.TArray<BmSDK.Engine.Settings.FSettingsProperty> Properties)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOnlineStatus, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetOnlineStatus");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatusId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalizedStringSettings, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Properties, paramsPtr + 20);
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

    private static BmSDK.Function __fn_GetLocalAccountNames;
    /// <summary>
    /// Function: GetLocalAccountNames
    /// </summary>
    public unsafe virtual bool GetLocalAccountNames(out BmSDK.TArray<BmSDK.FString> Accounts)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalAccountNames, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetLocalAccountNames");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Accounts = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DeleteLocalAccount;
    /// <summary>
    /// Function: DeleteLocalAccount
    /// </summary>
    public unsafe virtual bool DeleteLocalAccount(BmSDK.FString UserName, BmSDK.FString Password = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteLocalAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.DeleteLocalAccount");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Password, paramsPtr + 12);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_RenameLocalAccount;
    /// <summary>
    /// Function: RenameLocalAccount
    /// </summary>
    public unsafe virtual bool RenameLocalAccount(BmSDK.FString NewUserName, BmSDK.FString OldUserName, BmSDK.FString Password = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RenameLocalAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RenameLocalAccount");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUserName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldUserName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Password, paramsPtr + 24);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_CreateLocalAccount;
    /// <summary>
    /// Function: CreateLocalAccount
    /// </summary>
    public unsafe virtual bool CreateLocalAccount(BmSDK.FString UserName, BmSDK.FString Password = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateLocalAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CreateLocalAccount");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Password, paramsPtr + 12);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ClearCreateOnlineAccountCompletedDelegate;
    /// <summary>
    /// Function: ClearCreateOnlineAccountCompletedDelegate
    /// </summary>
    public unsafe virtual void ClearCreateOnlineAccountCompletedDelegate(System.IntPtr AccountCreateDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCreateOnlineAccountCompletedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearCreateOnlineAccountCompletedDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AccountCreateDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCreateOnlineAccountCompletedDelegate;
    /// <summary>
    /// Function: AddCreateOnlineAccountCompletedDelegate
    /// </summary>
    public unsafe virtual void AddCreateOnlineAccountCompletedDelegate(System.IntPtr AccountCreateDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCreateOnlineAccountCompletedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddCreateOnlineAccountCompletedDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AccountCreateDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCreateOnlineAccountCompleted;
    /// <summary>
    /// Function: OnCreateOnlineAccountCompleted
    /// </summary>
    public unsafe virtual void OnCreateOnlineAccountCompleted(BmSDK.Engine.OnlineSubsystem.EOnlineAccountCreateStatus ErrorStatus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCreateOnlineAccountCompleted, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnCreateOnlineAccountCompleted");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ErrorStatus, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateOnlineAccount;
    /// <summary>
    /// Function: CreateOnlineAccount
    /// </summary>
    public unsafe virtual bool CreateOnlineAccount(BmSDK.FString UserName, BmSDK.FString Password, BmSDK.FString EmailAddress, BmSDK.FString ProductKey = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateOnlineAccount, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CreateOnlineAccount");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Password, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EmailAddress, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProductKey, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_GetTitleFileState;
    /// <summary>
    /// Function: GetTitleFileState
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetTitleFileState(BmSDK.FString Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTitleFileState, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetTitleFileState");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetTitleFileContents;
    /// <summary>
    /// Function: GetTitleFileContents
    /// </summary>
    public unsafe virtual bool GetTitleFileContents(BmSDK.FString Filename, out BmSDK.TArray<byte> FileContents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTitleFileContents, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetTitleFileContents");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FileContents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ClearReadTitleFileCompleteDelegate;
    /// <summary>
    /// Function: ClearReadTitleFileCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadTitleFileCompleteDelegate(System.IntPtr ReadTitleFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadTitleFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadTitleFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadTitleFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadTitleFileCompleteDelegate;
    /// <summary>
    /// Function: AddReadTitleFileCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadTitleFileCompleteDelegate(System.IntPtr ReadTitleFileCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadTitleFileCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadTitleFileCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadTitleFileCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadTitleFile;
    /// <summary>
    /// Function: ReadTitleFile
    /// </summary>
    public unsafe virtual bool ReadTitleFile(BmSDK.FString FileToRead)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadTitleFile, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadTitleFile");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FileToRead, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnReadTitleFileComplete;
    /// <summary>
    /// Function: OnReadTitleFileComplete
    /// </summary>
    public unsafe virtual void OnReadTitleFileComplete(bool bWasSuccessful, BmSDK.FString Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadTitleFileComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadTitleFileComplete");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearStorageDeviceChangeDelegate;
    /// <summary>
    /// Function: ClearStorageDeviceChangeDelegate
    /// </summary>
    public unsafe virtual void ClearStorageDeviceChangeDelegate(System.IntPtr StorageDeviceChangeDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearStorageDeviceChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearStorageDeviceChangeDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StorageDeviceChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddStorageDeviceChangeDelegate;
    /// <summary>
    /// Function: AddStorageDeviceChangeDelegate
    /// </summary>
    public unsafe virtual void AddStorageDeviceChangeDelegate(System.IntPtr StorageDeviceChangeDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddStorageDeviceChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddStorageDeviceChangeDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StorageDeviceChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnStorageDeviceChange;
    /// <summary>
    /// Function: OnStorageDeviceChange
    /// </summary>
    public unsafe virtual void OnStorageDeviceChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnStorageDeviceChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnStorageDeviceChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLocale;
    /// <summary>
    /// Function: GetLocale
    /// </summary>
    public unsafe virtual int GetLocale()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocale, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetLocale");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNATType;
    /// <summary>
    /// Function: GetNATType
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.ENATType GetNATType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNATType, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetNATType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.ENATType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearConnectionStatusChangeDelegate;
    /// <summary>
    /// Function: ClearConnectionStatusChangeDelegate
    /// </summary>
    public unsafe virtual void ClearConnectionStatusChangeDelegate(System.IntPtr ConnectionStatusDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearConnectionStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearConnectionStatusChangeDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConnectionStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddConnectionStatusChangeDelegate;
    /// <summary>
    /// Function: AddConnectionStatusChangeDelegate
    /// </summary>
    public unsafe virtual void AddConnectionStatusChangeDelegate(System.IntPtr ConnectionStatusDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddConnectionStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddConnectionStatusChangeDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConnectionStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnConnectionStatusChange;
    /// <summary>
    /// Function: OnConnectionStatusChange
    /// </summary>
    public unsafe virtual void OnConnectionStatusChange(BmSDK.Engine.OnlineSubsystem.EOnlineServerConnectionStatus ConnectionStatus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnConnectionStatusChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnConnectionStatusChange");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConnectionStatus, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsControllerConnected;
    /// <summary>
    /// Function: IsControllerConnected
    /// </summary>
    public unsafe virtual bool IsControllerConnected(int ControllerId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsControllerConnected, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsControllerConnected");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClearControllerChangeDelegate;
    /// <summary>
    /// Function: ClearControllerChangeDelegate
    /// </summary>
    public unsafe virtual void ClearControllerChangeDelegate(System.IntPtr ControllerChangeDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearControllerChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearControllerChangeDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddControllerChangeDelegate;
    /// <summary>
    /// Function: AddControllerChangeDelegate
    /// </summary>
    public unsafe virtual void AddControllerChangeDelegate(System.IntPtr ControllerChangeDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddControllerChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddControllerChangeDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnControllerChange;
    /// <summary>
    /// Function: OnControllerChange
    /// </summary>
    public unsafe virtual void OnControllerChange(int ControllerId, bool bIsConnected)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnControllerChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnControllerChange");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsConnected, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNetworkNotificationPosition;
    /// <summary>
    /// Function: SetNetworkNotificationPosition
    /// </summary>
    public unsafe virtual void SetNetworkNotificationPosition(BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition NewPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNetworkNotificationPosition, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetNetworkNotificationPosition");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPos, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetNetworkNotificationPosition;
    /// <summary>
    /// Function: GetNetworkNotificationPosition
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition GetNetworkNotificationPosition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNetworkNotificationPosition, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetNetworkNotificationPosition");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearExternalUIChangeDelegate;
    /// <summary>
    /// Function: ClearExternalUIChangeDelegate
    /// </summary>
    public unsafe virtual void ClearExternalUIChangeDelegate(System.IntPtr ExternalUIDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearExternalUIChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearExternalUIChangeDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExternalUIDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddExternalUIChangeDelegate;
    /// <summary>
    /// Function: AddExternalUIChangeDelegate
    /// </summary>
    public unsafe virtual void AddExternalUIChangeDelegate(System.IntPtr ExternalUIDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddExternalUIChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddExternalUIChangeDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExternalUIDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnExternalUIChange;
    /// <summary>
    /// Function: OnExternalUIChange
    /// </summary>
    public unsafe virtual void OnExternalUIChange(bool bIsOpening)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnExternalUIChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnExternalUIChange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsOpening, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLinkStatusChangeDelegate;
    /// <summary>
    /// Function: ClearLinkStatusChangeDelegate
    /// </summary>
    public unsafe virtual void ClearLinkStatusChangeDelegate(System.IntPtr LinkStatusDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLinkStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLinkStatusChangeDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLinkStatusChangeDelegate;
    /// <summary>
    /// Function: AddLinkStatusChangeDelegate
    /// </summary>
    public unsafe virtual void AddLinkStatusChangeDelegate(System.IntPtr LinkStatusDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLinkStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLinkStatusChangeDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLinkStatusChange;
    /// <summary>
    /// Function: OnLinkStatusChange
    /// </summary>
    public unsafe virtual void OnLinkStatusChange(bool bIsConnected)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLinkStatusChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLinkStatusChange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsConnected, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasLinkConnection;
    /// <summary>
    /// Function: HasLinkConnection
    /// </summary>
    public unsafe virtual bool HasLinkConnection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasLinkConnection, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.HasLinkConnection");
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

    private static BmSDK.Function __fn_GetPlayerNicknameFromIndex;
    /// <summary>
    /// Function: GetPlayerNicknameFromIndex
    /// </summary>
    public unsafe override BmSDK.FString GetPlayerNicknameFromIndex(int UserIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerNicknameFromIndex, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetPlayerNicknameFromIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_WriteOnlinePlayerScores;
    /// <summary>
    /// Function: WriteOnlinePlayerScores
    /// </summary>
    public unsafe virtual bool WriteOnlinePlayerScores(BmSDK.FName SessionName, int LeaderboardId, in BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlinePlayerScore> PlayerScores)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteOnlinePlayerScores, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteOnlinePlayerScores");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeaderboardId, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerScores, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ClearFlushOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: ClearFlushOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearFlushOnlineStatsCompleteDelegate(System.IntPtr FlushOnlineStatsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFlushOnlineStatsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFlushOnlineStatsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlushOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFlushOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: AddFlushOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddFlushOnlineStatsCompleteDelegate(System.IntPtr FlushOnlineStatsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFlushOnlineStatsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFlushOnlineStatsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlushOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFlushOnlineStatsComplete;
    /// <summary>
    /// Function: OnFlushOnlineStatsComplete
    /// </summary>
    public unsafe virtual void OnFlushOnlineStatsComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFlushOnlineStatsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnFlushOnlineStatsComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlushOnlineStats;
    /// <summary>
    /// Function: FlushOnlineStats
    /// </summary>
    public unsafe virtual bool FlushOnlineStats(BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushOnlineStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.FlushOnlineStats");
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

    private static BmSDK.Function __fn_WriteOnlineStats;
    /// <summary>
    /// Function: WriteOnlineStats
    /// </summary>
    public unsafe virtual bool WriteOnlineStats(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player, BmSDK.Engine.OnlineStatsWrite StatsWrite)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteOnlineStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteOnlineStats");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsWrite, paramsPtr + 16);
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

    private static BmSDK.Function __fn_FreeStats;
    /// <summary>
    /// Function: FreeStats
    /// </summary>
    public unsafe virtual void FreeStats(BmSDK.Engine.OnlineStatsRead StatsRead)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FreeStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.FreeStats");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearReadOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadOnlineStatsCompleteDelegate(System.IntPtr ReadOnlineStatsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadOnlineStatsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadOnlineStatsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadOnlineStatsCompleteDelegate;
    /// <summary>
    /// Function: AddReadOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadOnlineStatsCompleteDelegate(System.IntPtr ReadOnlineStatsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadOnlineStatsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadOnlineStatsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadOnlineStatsCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadOnlineStatsComplete;
    /// <summary>
    /// Function: OnReadOnlineStatsComplete
    /// </summary>
    public unsafe virtual void OnReadOnlineStatsComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadOnlineStatsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadOnlineStatsComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadOnlineStatsByRankAroundPlayer;
    /// <summary>
    /// Function: ReadOnlineStatsByRankAroundPlayer
    /// </summary>
    public unsafe virtual bool ReadOnlineStatsByRankAroundPlayer(byte LocalUserNum, BmSDK.Engine.OnlineStatsRead StatsRead, int NumRows = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadOnlineStatsByRankAroundPlayer, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineStatsByRankAroundPlayer");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumRows, paramsPtr + 8);
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

    private static BmSDK.Function __fn_ReadOnlineStatsByRank;
    /// <summary>
    /// Function: ReadOnlineStatsByRank
    /// </summary>
    public unsafe virtual bool ReadOnlineStatsByRank(BmSDK.Engine.OnlineStatsRead StatsRead, int StartIndex = default, int NumToRead = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadOnlineStatsByRank, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineStatsByRank");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumToRead, paramsPtr + 8);
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

    private static BmSDK.Function __fn_ReadOnlineStatsForFriends;
    /// <summary>
    /// Function: ReadOnlineStatsForFriends
    /// </summary>
    public unsafe virtual bool ReadOnlineStatsForFriends(byte LocalUserNum, BmSDK.Engine.OnlineStatsRead StatsRead)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadOnlineStatsForFriends, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineStatsForFriends");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ReadOnlineStats;
    /// <summary>
    /// Function: ReadOnlineStats
    /// </summary>
    public unsafe virtual bool ReadOnlineStats(in BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players, BmSDK.Engine.OnlineStatsRead StatsRead)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadOnlineStats, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadOnlineStats");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Players, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsRead, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetSpeechRecognitionObject;
    /// <summary>
    /// Function: SetSpeechRecognitionObject
    /// </summary>
    public unsafe virtual bool SetSpeechRecognitionObject(byte LocalUserNum, BmSDK.Engine.SpeechRecognition SpeechRecogObj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSpeechRecognitionObject, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetSpeechRecognitionObject");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeechRecogObj, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SelectVocabulary;
    /// <summary>
    /// Function: SelectVocabulary
    /// </summary>
    public unsafe virtual bool SelectVocabulary(byte LocalUserNum, int VocabularyId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectVocabulary, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SelectVocabulary");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VocabularyId, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ClearRecognitionCompleteDelegate;
    /// <summary>
    /// Function: ClearRecognitionCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearRecognitionCompleteDelegate(byte LocalUserNum, System.IntPtr RecognitionDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecognitionCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearRecognitionCompleteDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecognitionDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddRecognitionCompleteDelegate;
    /// <summary>
    /// Function: AddRecognitionCompleteDelegate
    /// </summary>
    public unsafe virtual void AddRecognitionCompleteDelegate(byte LocalUserNum, System.IntPtr RecognitionDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRecognitionCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddRecognitionCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecognitionDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRecognitionComplete;
    /// <summary>
    /// Function: OnRecognitionComplete
    /// </summary>
    public unsafe virtual void OnRecognitionComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRecognitionComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnRecognitionComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRecognitionResults;
    /// <summary>
    /// Function: GetRecognitionResults
    /// </summary>
    public unsafe virtual bool GetRecognitionResults(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FSpeechRecognizedWord> Words)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRecognitionResults, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetRecognitionResults");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Words = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FSpeechRecognizedWord>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_StopSpeechRecognition;
    /// <summary>
    /// Function: StopSpeechRecognition
    /// </summary>
    public unsafe virtual bool StopSpeechRecognition(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSpeechRecognition, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StopSpeechRecognition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StartSpeechRecognition;
    /// <summary>
    /// Function: StartSpeechRecognition
    /// </summary>
    public unsafe virtual bool StartSpeechRecognition(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSpeechRecognition, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StartSpeechRecognition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StopNetworkedVoice;
    /// <summary>
    /// Function: StopNetworkedVoice
    /// </summary>
    public unsafe virtual void StopNetworkedVoice(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopNetworkedVoice, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StopNetworkedVoice");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StartNetworkedVoice;
    /// <summary>
    /// Function: StartNetworkedVoice
    /// </summary>
    public unsafe virtual void StartNetworkedVoice(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartNetworkedVoice, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.StartNetworkedVoice");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearPlayerTalkingDelegate;
    /// <summary>
    /// Function: ClearPlayerTalkingDelegate
    /// </summary>
    public unsafe virtual void ClearPlayerTalkingDelegate(System.IntPtr TalkerDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPlayerTalkingDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearPlayerTalkingDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TalkerDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPlayerTalkingDelegate;
    /// <summary>
    /// Function: AddPlayerTalkingDelegate
    /// </summary>
    public unsafe virtual void AddPlayerTalkingDelegate(System.IntPtr TalkerDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPlayerTalkingDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddPlayerTalkingDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TalkerDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPlayerTalkingStateChange;
    /// <summary>
    /// Function: OnPlayerTalkingStateChange
    /// </summary>
    public unsafe virtual void OnPlayerTalkingStateChange(BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player, bool bIsTalking)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlayerTalkingStateChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnPlayerTalkingStateChange");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsTalking, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnmuteRemoteTalker;
    /// <summary>
    /// Function: UnmuteRemoteTalker
    /// </summary>
    public unsafe virtual bool UnmuteRemoteTalker(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bIsSystemWide = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnmuteRemoteTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnmuteRemoteTalker");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSystemWide, paramsPtr + 12);
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

    private static BmSDK.Function __fn_MuteRemoteTalker;
    /// <summary>
    /// Function: MuteRemoteTalker
    /// </summary>
    public unsafe virtual bool MuteRemoteTalker(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bIsSystemWide = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MuteRemoteTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.MuteRemoteTalker");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSystemWide, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetRemoteTalkerPriority;
    /// <summary>
    /// Function: SetRemoteTalkerPriority
    /// </summary>
    public unsafe virtual bool SetRemoteTalkerPriority(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, int Priority)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRemoteTalkerPriority, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.SetRemoteTalkerPriority");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 12);
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

    private static BmSDK.Function __fn_IsHeadsetPresent;
    /// <summary>
    /// Function: IsHeadsetPresent
    /// </summary>
    public unsafe virtual bool IsHeadsetPresent(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHeadsetPresent, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsHeadsetPresent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsRemotePlayerTalking;
    /// <summary>
    /// Function: IsRemotePlayerTalking
    /// </summary>
    public unsafe virtual bool IsRemotePlayerTalking(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRemotePlayerTalking, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsRemotePlayerTalking");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsLocalPlayerTalking;
    /// <summary>
    /// Function: IsLocalPlayerTalking
    /// </summary>
    public unsafe virtual bool IsLocalPlayerTalking(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocalPlayerTalking, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsLocalPlayerTalking");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UnregisterRemoteTalker;
    /// <summary>
    /// Function: UnregisterRemoteTalker
    /// </summary>
    public unsafe virtual bool UnregisterRemoteTalker(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterRemoteTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnregisterRemoteTalker");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RegisterRemoteTalker;
    /// <summary>
    /// Function: RegisterRemoteTalker
    /// </summary>
    public unsafe virtual bool RegisterRemoteTalker(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterRemoteTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RegisterRemoteTalker");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UnregisterLocalTalker;
    /// <summary>
    /// Function: UnregisterLocalTalker
    /// </summary>
    public unsafe virtual bool UnregisterLocalTalker(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterLocalTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.UnregisterLocalTalker");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RegisterLocalTalker;
    /// <summary>
    /// Function: RegisterLocalTalker
    /// </summary>
    public unsafe virtual bool RegisterLocalTalker(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterLocalTalker, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.RegisterLocalTalker");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetFriendsList;
    /// <summary>
    /// Function: GetFriendsList
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetFriendsList(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend> Friends, int Count = default, int StartingAt = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFriendsList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetFriendsList");
        byte* paramsPtr = stackalloc byte[41];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartingAt, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Friends = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ClearReadFriendsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadFriendsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadFriendsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadFriendsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadFriendsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadFriendsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadFriendsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadFriendsCompleteDelegate;
    /// <summary>
    /// Function: AddReadFriendsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadFriendsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadFriendsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadFriendsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadFriendsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadFriendsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadFriendsComplete;
    /// <summary>
    /// Function: OnReadFriendsComplete
    /// </summary>
    public unsafe virtual void OnReadFriendsComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadFriendsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadFriendsComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadFriendsList;
    /// <summary>
    /// Function: ReadFriendsList
    /// </summary>
    public unsafe virtual bool ReadFriendsList(byte LocalUserNum, int Count = default, int StartingAt = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadFriendsList, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadFriendsList");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartingAt, paramsPtr + 8);
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

    private static BmSDK.Function __fn_ClearWritePlayerStorageCompleteDelegate;
    /// <summary>
    /// Function: ClearWritePlayerStorageCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWritePlayerStorageCompleteDelegate(byte LocalUserNum, System.IntPtr WritePlayerStorageCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWritePlayerStorageCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWritePlayerStorageCompleteDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WritePlayerStorageCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddWritePlayerStorageCompleteDelegate;
    /// <summary>
    /// Function: AddWritePlayerStorageCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWritePlayerStorageCompleteDelegate(byte LocalUserNum, System.IntPtr WritePlayerStorageCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWritePlayerStorageCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWritePlayerStorageCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WritePlayerStorageCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWritePlayerStorageComplete;
    /// <summary>
    /// Function: OnWritePlayerStorageComplete
    /// </summary>
    public unsafe virtual void OnWritePlayerStorageComplete(byte LocalUserNum, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWritePlayerStorageComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWritePlayerStorageComplete");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WritePlayerStorage;
    /// <summary>
    /// Function: WritePlayerStorage
    /// </summary>
    public unsafe virtual bool WritePlayerStorage(byte LocalUserNum, BmSDK.Engine.OnlinePlayerStorage PlayerStorage, int DeviceID = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WritePlayerStorage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WritePlayerStorage");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetPlayerStorage;
    /// <summary>
    /// Function: GetPlayerStorage
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlinePlayerStorage GetPlayerStorage(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerStorage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetPlayerStorage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlinePlayerStorage>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClearReadPlayerStorageForNetIdCompleteDelegate;
    /// <summary>
    /// Function: ClearReadPlayerStorageForNetIdCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadPlayerStorageForNetIdCompleteDelegate(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, System.IntPtr ReadPlayerStorageForNetIdCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadPlayerStorageForNetIdCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadPlayerStorageForNetIdCompleteDelegate");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadPlayerStorageForNetIdCompleteDelegate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadPlayerStorageForNetIdCompleteDelegate;
    /// <summary>
    /// Function: AddReadPlayerStorageForNetIdCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadPlayerStorageForNetIdCompleteDelegate(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, System.IntPtr ReadPlayerStorageForNetIdCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadPlayerStorageForNetIdCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadPlayerStorageForNetIdCompleteDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadPlayerStorageForNetIdCompleteDelegate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadPlayerStorageForNetIdComplete;
    /// <summary>
    /// Function: OnReadPlayerStorageForNetIdComplete
    /// </summary>
    public unsafe virtual void OnReadPlayerStorageForNetIdComplete(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadPlayerStorageForNetIdComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadPlayerStorageForNetIdComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadPlayerStorageForNetId;
    /// <summary>
    /// Function: ReadPlayerStorageForNetId
    /// </summary>
    public unsafe virtual bool ReadPlayerStorageForNetId(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, BmSDK.Engine.OnlinePlayerStorage PlayerStorage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadPlayerStorageForNetId, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadPlayerStorageForNetId");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ClearReadPlayerStorageCompleteDelegate;
    /// <summary>
    /// Function: ClearReadPlayerStorageCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadPlayerStorageCompleteDelegate(byte LocalUserNum, System.IntPtr ReadPlayerStorageCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadPlayerStorageCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadPlayerStorageCompleteDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadPlayerStorageCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadPlayerStorageCompleteDelegate;
    /// <summary>
    /// Function: AddReadPlayerStorageCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadPlayerStorageCompleteDelegate(byte LocalUserNum, System.IntPtr ReadPlayerStorageCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadPlayerStorageCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadPlayerStorageCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadPlayerStorageCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadPlayerStorageComplete;
    /// <summary>
    /// Function: OnReadPlayerStorageComplete
    /// </summary>
    public unsafe virtual void OnReadPlayerStorageComplete(byte LocalUserNum, bool bWasSuccessful, bool bIsCorrupted)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadPlayerStorageComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadPlayerStorageComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsCorrupted, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CallOnReadPlayerStorageCompleteDelegates;
    /// <summary>
    /// Function: CallOnReadPlayerStorageCompleteDelegates
    /// </summary>
    public unsafe virtual bool CallOnReadPlayerStorageCompleteDelegates(byte LocalUserNum, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CallOnReadPlayerStorageCompleteDelegates, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CallOnReadPlayerStorageCompleteDelegates");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ReadPlayerStorage;
    /// <summary>
    /// Function: ReadPlayerStorage
    /// </summary>
    public unsafe virtual bool ReadPlayerStorage(byte LocalUserNum, BmSDK.Engine.OnlinePlayerStorage PlayerStorage, int DeviceID = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadPlayerStorage, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadPlayerStorage");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearWriteProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: ClearWriteProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearWriteProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr WriteProfileSettingsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWriteProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearWriteProfileSettingsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddWriteProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: AddWriteProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddWriteProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr WriteProfileSettingsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWriteProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddWriteProfileSettingsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWriteProfileSettingsComplete;
    /// <summary>
    /// Function: OnWriteProfileSettingsComplete
    /// </summary>
    public unsafe virtual void OnWriteProfileSettingsComplete(byte LocalUserNum, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWriteProfileSettingsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnWriteProfileSettingsComplete");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WriteProfileSettings;
    /// <summary>
    /// Function: WriteProfileSettings
    /// </summary>
    public unsafe virtual bool WriteProfileSettings(byte LocalUserNum, BmSDK.Engine.OnlineProfileSettings ProfileSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WriteProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.WriteProfileSettings");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettings, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetProfileSettings;
    /// <summary>
    /// Function: GetProfileSettings
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineProfileSettings GetProfileSettings(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetProfileSettings");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineProfileSettings>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClearReadProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: ClearReadProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearReadProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearReadProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearReadProfileSettingsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReadProfileSettingsCompleteDelegate;
    /// <summary>
    /// Function: AddReadProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe virtual void AddReadProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReadProfileSettingsCompleteDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddReadProfileSettingsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadProfileSettingsCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadProfileSettingsComplete;
    /// <summary>
    /// Function: OnReadProfileSettingsComplete
    /// </summary>
    public unsafe virtual void OnReadProfileSettingsComplete(byte LocalUserNum, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadProfileSettingsComplete, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnReadProfileSettingsComplete");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadProfileSettings;
    /// <summary>
    /// Function: ReadProfileSettings
    /// </summary>
    public unsafe virtual bool ReadProfileSettings(byte LocalUserNum, BmSDK.Engine.OnlineProfileSettings ProfileSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadProfileSettings, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ReadProfileSettings");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettings, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ClearFriendsChangeDelegate;
    /// <summary>
    /// Function: ClearFriendsChangeDelegate
    /// </summary>
    public unsafe virtual void ClearFriendsChangeDelegate(byte LocalUserNum, System.IntPtr FriendsDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFriendsChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearFriendsChangeDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendsDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFriendsChangeDelegate;
    /// <summary>
    /// Function: AddFriendsChangeDelegate
    /// </summary>
    public unsafe virtual void AddFriendsChangeDelegate(byte LocalUserNum, System.IntPtr FriendsDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFriendsChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddFriendsChangeDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendsDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearMutingChangeDelegate;
    /// <summary>
    /// Function: ClearMutingChangeDelegate
    /// </summary>
    public unsafe virtual void ClearMutingChangeDelegate(System.IntPtr MutingDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearMutingChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearMutingChangeDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MutingDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddMutingChangeDelegate;
    /// <summary>
    /// Function: AddMutingChangeDelegate
    /// </summary>
    public unsafe virtual void AddMutingChangeDelegate(System.IntPtr MutingDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMutingChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddMutingChangeDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MutingDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLoginCancelledDelegate;
    /// <summary>
    /// Function: ClearLoginCancelledDelegate
    /// </summary>
    public unsafe virtual void ClearLoginCancelledDelegate(System.IntPtr CancelledDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLoginCancelledDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLoginCancelledDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CancelledDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLoginCancelledDelegate;
    /// <summary>
    /// Function: AddLoginCancelledDelegate
    /// </summary>
    public unsafe virtual void AddLoginCancelledDelegate(System.IntPtr CancelledDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLoginCancelledDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLoginCancelledDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CancelledDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLoginStatusChangeDelegate;
    /// <summary>
    /// Function: ClearLoginStatusChangeDelegate
    /// </summary>
    public unsafe virtual void ClearLoginStatusChangeDelegate(System.IntPtr LoginStatusDelegate, byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLoginStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLoginStatusChangeDelegate");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLoginStatusChangeDelegate;
    /// <summary>
    /// Function: AddLoginStatusChangeDelegate
    /// </summary>
    public unsafe virtual void AddLoginStatusChangeDelegate(System.IntPtr LoginStatusDelegate, byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLoginStatusChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLoginStatusChangeDelegate");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginStatusDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoginStatusChange;
    /// <summary>
    /// Function: OnLoginStatusChange
    /// </summary>
    public unsafe virtual void OnLoginStatusChange(BmSDK.Engine.OnlineSubsystem.ELoginStatus NewStatus, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NewId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoginStatusChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLoginStatusChange");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStatus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLoginChangeDelegate;
    /// <summary>
    /// Function: ClearLoginChangeDelegate
    /// </summary>
    public unsafe virtual void ClearLoginChangeDelegate(System.IntPtr LoginDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLoginChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLoginChangeDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLoginChangeDelegate;
    /// <summary>
    /// Function: AddLoginChangeDelegate
    /// </summary>
    public unsafe virtual void AddLoginChangeDelegate(System.IntPtr LoginDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLoginChangeDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLoginChangeDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsMuted;
    /// <summary>
    /// Function: IsMuted
    /// </summary>
    public unsafe virtual bool IsMuted(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMuted, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsMuted");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
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

    private static BmSDK.Function __fn_AreAnyFriends;
    /// <summary>
    /// Function: AreAnyFriends
    /// </summary>
    public unsafe virtual bool AreAnyFriends(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FFriendsQuery> Query)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreAnyFriends, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AreAnyFriends");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Query = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FFriendsQuery>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsFriend;
    /// <summary>
    /// Function: IsFriend
    /// </summary>
    public unsafe virtual bool IsFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFriend, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsFriend");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
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

    private static BmSDK.Function __fn_CanShowPresenceInformation;
    /// <summary>
    /// Function: CanShowPresenceInformation
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanShowPresenceInformation(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanShowPresenceInformation, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanShowPresenceInformation");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_CanViewPlayerProfiles;
    /// <summary>
    /// Function: CanViewPlayerProfiles
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanViewPlayerProfiles(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanViewPlayerProfiles, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanViewPlayerProfiles");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_CanPurchaseContent;
    /// <summary>
    /// Function: CanPurchaseContent
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanPurchaseContent(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPurchaseContent, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanPurchaseContent");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_CanDownloadUserContent;
    /// <summary>
    /// Function: CanDownloadUserContent
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanDownloadUserContent(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDownloadUserContent, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanDownloadUserContent");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_CanCommunicate;
    /// <summary>
    /// Function: CanCommunicate
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanCommunicate(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCommunicate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanCommunicate");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_CanPlayOnline;
    /// <summary>
    /// Function: CanPlayOnline
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanPlayOnline(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayOnline, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.CanPlayOnline");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_GetPlayerNickname;
    /// <summary>
    /// Function: GetPlayerNickname
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlayerNickname(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerNickname, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetPlayerNickname");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetUniquePlayerId;
    /// <summary>
    /// Function: GetUniquePlayerId
    /// </summary>
    public unsafe virtual bool GetUniquePlayerId(byte LocalUserNum, out BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUniquePlayerId, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetUniquePlayerId");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlayerID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PlayerID = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsLocalLogin;
    /// <summary>
    /// Function: IsLocalLogin
    /// </summary>
    public unsafe virtual bool IsLocalLogin(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocalLogin, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsLocalLogin");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsGuestLogin;
    /// <summary>
    /// Function: IsGuestLogin
    /// </summary>
    public unsafe virtual bool IsGuestLogin(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGuestLogin, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.IsGuestLogin");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetLoginStatus;
    /// <summary>
    /// Function: GetLoginStatus
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.ELoginStatus GetLoginStatus(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLoginStatus, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetLoginStatus");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.ELoginStatus>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_ClearLogoutCompletedDelegate;
    /// <summary>
    /// Function: ClearLogoutCompletedDelegate
    /// </summary>
    public unsafe virtual void ClearLogoutCompletedDelegate(byte LocalUserNum, System.IntPtr LogoutDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLogoutCompletedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLogoutCompletedDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LogoutDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLogoutCompletedDelegate;
    /// <summary>
    /// Function: AddLogoutCompletedDelegate
    /// </summary>
    public unsafe virtual void AddLogoutCompletedDelegate(byte LocalUserNum, System.IntPtr LogoutDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLogoutCompletedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLogoutCompletedDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LogoutDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLogoutCompleted;
    /// <summary>
    /// Function: OnLogoutCompleted
    /// </summary>
    public unsafe virtual void OnLogoutCompleted(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLogoutCompleted, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLogoutCompleted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Logout;
    /// <summary>
    /// Function: Logout
    /// </summary>
    public unsafe virtual bool Logout(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Logout, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Logout");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClearLoginFailedDelegate;
    /// <summary>
    /// Function: ClearLoginFailedDelegate
    /// </summary>
    public unsafe virtual void ClearLoginFailedDelegate(byte LocalUserNum, System.IntPtr LoginFailedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLoginFailedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ClearLoginFailedDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginFailedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLoginFailedDelegate;
    /// <summary>
    /// Function: AddLoginFailedDelegate
    /// </summary>
    public unsafe virtual void AddLoginFailedDelegate(byte LocalUserNum, System.IntPtr LoginFailedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLoginFailedDelegate, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AddLoginFailedDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginFailedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoginFailed;
    /// <summary>
    /// Function: OnLoginFailed
    /// </summary>
    public unsafe virtual void OnLoginFailed(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineServerConnectionStatus ErrorCode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoginFailed, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLoginFailed");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ErrorCode, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutoLogin;
    /// <summary>
    /// Function: AutoLogin
    /// </summary>
    public unsafe virtual bool AutoLogin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoLogin, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.AutoLogin");
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

    private static BmSDK.Function __fn_Login;
    /// <summary>
    /// Function: Login
    /// </summary>
    public unsafe virtual bool Login(byte LocalUserNum, BmSDK.FString LoginName, BmSDK.FString Password, bool bWantsLocalOnly = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Login, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Login");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoginName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Password, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWantsLocalOnly, paramsPtr + 28);
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

    private static BmSDK.Function __fn_ConstructVOIPNetDriver;
    /// <summary>
    /// Function: ConstructVOIPNetDriver
    /// </summary>
    public unsafe virtual void ConstructVOIPNetDriver()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConstructVOIPNetDriver, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ConstructVOIPNetDriver");
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

    private static BmSDK.Function __fn_ConnectPeerVoipDriver;
    /// <summary>
    /// Function: ConnectPeerVoipDriver
    /// </summary>
    public unsafe virtual void ConnectPeerVoipDriver(BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConnectPeerVoipDriver, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ConnectPeerVoipDriver");
        byte* paramsPtr = stackalloc byte[24];
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
        return;
    }

    private static BmSDK.Function __fn_ShowLoginUI;
    /// <summary>
    /// Function: ShowLoginUI
    /// </summary>
    public unsafe virtual bool ShowLoginUI(bool bShowOnlineOnly = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowLoginUI, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.ShowLoginUI");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowOnlineOnly, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnFriendsChange;
    /// <summary>
    /// Function: OnFriendsChange
    /// </summary>
    public unsafe virtual void OnFriendsChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFriendsChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnFriendsChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMutingChange;
    /// <summary>
    /// Function: OnMutingChange
    /// </summary>
    public unsafe virtual void OnMutingChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMutingChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnMutingChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoginCancelled;
    /// <summary>
    /// Function: OnLoginCancelled
    /// </summary>
    public unsafe virtual void OnLoginCancelled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoginCancelled, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLoginCancelled");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoginChange;
    /// <summary>
    /// Function: OnLoginChange
    /// </summary>
    public unsafe virtual void OnLoginChange(byte LocalUserNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoginChange, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.OnLoginChange");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlayerUniqueNetIdFromIndex;
    /// <summary>
    /// Function: GetPlayerUniqueNetIdFromIndex
    /// </summary>
    public unsafe override BmSDK.Engine.OnlineSubsystem.FUniqueNetId GetPlayerUniqueNetIdFromIndex(int UserIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerUniqueNetIdFromIndex, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.GetPlayerUniqueNetIdFromIndex");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Exit;
    /// <summary>
    /// Function: Exit
    /// </summary>
    public unsafe override void Exit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Exit, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Exit");
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

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "OnlineSubsystemSteamworks.OnlineSubsystemSteamworks.Init");
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

    /// <summary>
    /// Struct: FIpAddr
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FIpAddr
    {
        /// <summary>
        /// IntProperty: Addr
        /// </summary>
        public unsafe int Addr
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Port
        /// </summary>
        public unsafe int Port
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FSteamPlayerClanData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FSteamPlayerClanData
    {
        /// <summary>
        /// StrProperty: ClanName
        /// </summary>
        public unsafe BmSDK.FString ClanName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ClanTag
        /// </summary>
        public unsafe BmSDK.FString ClanTag
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FViewIdToLeaderboardName
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FViewIdToLeaderboardName
    {
        /// <summary>
        /// IntProperty: ViewId
        /// </summary>
        public unsafe int ViewId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: LeaderboardName
        /// </summary>
        public unsafe BmSDK.FString LeaderboardName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FLeaderboardEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FLeaderboardEntry
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
        /// IntProperty: Rank
        /// </summary>
        public unsafe int Rank
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Score
        /// </summary>
        public unsafe int Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: LeaderboardData
        /// </summary>
        public unsafe BmSDK.TArray<int> LeaderboardData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FDeferredLeaderboardWrite
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FDeferredLeaderboardWrite
    {
        /// <summary>
        /// StrProperty: LeaderboardName
        /// </summary>
        public unsafe BmSDK.FString LeaderboardName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Score
        /// </summary>
        public unsafe int Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: LeaderboardData
        /// </summary>
        public unsafe BmSDK.TArray<int> LeaderboardData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FDeferredLeaderboardRead
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FDeferredLeaderboardRead
    {
        /// <summary>
        /// StrProperty: LeaderboardName
        /// </summary>
        public unsafe BmSDK.FString LeaderboardName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: RequestType
        /// </summary>
        public unsafe byte RequestType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Start
        /// </summary>
        public unsafe int Start
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: End
        /// </summary>
        public unsafe int End
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ArrayProperty: PlayerList
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> PlayerList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FLeaderboardTemplate
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FLeaderboardTemplate
    {
        /// <summary>
        /// StrProperty: LeaderboardName
        /// </summary>
        public unsafe BmSDK.FString LeaderboardName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: UpdateType
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardUpdateType UpdateType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardUpdateType>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: LeaderboardSize
        /// </summary>
        public unsafe int LeaderboardSize
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: SortType
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardSortType SortType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardSortType>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ByteProperty: DisplayFormat
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardFormat DisplayFormat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.ELeaderboardFormat>(Ptr + 21); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21); }; }
        }

        /// <summary>
        /// StructProperty: LeaderboardRef
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLeaderboardHandle LeaderboardRef
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLeaderboardHandle>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bLeaderboardInitializing
        /// </summary>
        public unsafe bool bLeaderboardInitializing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bLeaderboardInitiated
        /// </summary>
        public unsafe bool bLeaderboardInitiated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FLeaderboardHandle
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FLeaderboardHandle
    {
        /// <summary>
        /// StructProperty: Dud
        /// </summary>
        public unsafe ulong Dud
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: ELeaderboardUpdateType
    /// </summary>
    public enum ELeaderboardUpdateType : byte
    {
        LUT_KeepBest = 0,
        LUT_Force = 1,
        LUT_MAX = 2,
    }

    /// <summary>
    /// Enum: ELeaderboardFormat
    /// </summary>
    public enum ELeaderboardFormat : byte
    {
        LF_Number = 0,
        LF_Seconds = 1,
        LF_Milliseconds = 2,
        LF_MAX = 3,
    }

    /// <summary>
    /// Enum: ELeaderboardSortType
    /// </summary>
    public enum ELeaderboardSortType : byte
    {
        LST_Ascending = 0,
        LST_Descending = 1,
        LST_MAX = 2,
    }

    /// <summary>
    /// Enum: ELeaderboardRequestType
    /// </summary>
    public enum ELeaderboardRequestType : byte
    {
        LRT_Global = 0,
        LRT_Player = 1,
        LRT_Friends = 2,
        LRT_MAX = 3,
    }

    /// <summary>
    /// Struct: FAchievementProgressStat
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FAchievementProgressStat
    {
        /// <summary>
        /// IntProperty: AchievementId
        /// </summary>
        public unsafe int AchievementId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Progress
        /// </summary>
        public unsafe int Progress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: MaxProgress
        /// </summary>
        public unsafe int MaxProgress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bUnlock
        /// </summary>
        public unsafe bool bUnlock
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FAchievementMappingInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FAchievementMappingInfo
    {
        /// <summary>
        /// IntProperty: AchievementId
        /// </summary>
        public unsafe int AchievementId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: AchievementName
        /// </summary>
        public unsafe BmSDK.FName AchievementName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: ViewId
        /// </summary>
        public unsafe int ViewId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: ProgressCount
        /// </summary>
        public unsafe int ProgressCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: MaxProgress
        /// </summary>
        public unsafe int MaxProgress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bAutoUnlock
        /// </summary>
        public unsafe bool bAutoUnlock
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FQueuedAvatarRequest
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FQueuedAvatarRequest
    {
        /// <summary>
        /// FloatProperty: CheckTime
        /// </summary>
        public unsafe float CheckTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: NumberOfAttempts
        /// </summary>
        public unsafe int NumberOfAttempts
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: PlayerNetId
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Size
        /// </summary>
        public unsafe int Size
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// DelegateProperty: ReadOnlineAvatarCompleteDelegate
        /// </summary>
        public unsafe System.IntPtr ReadOnlineAvatarCompleteDelegate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FSteamUserCloudMetadata
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FSteamUserCloudMetadata
    {
        /// <summary>
        /// StrProperty: UserId
        /// </summary>
        public unsafe BmSDK.FString UserId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: UserCloudMetadata
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile> UserCloudMetadata
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FEmsFile>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FSteamUserCloud
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FSteamUserCloud
    {
        /// <summary>
        /// StrProperty: UserId
        /// </summary>
        public unsafe BmSDK.FString UserId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: UserCloudFileData
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FTitleFile> UserCloudFileData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FTitleFile>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FDelayedInvite
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FDelayedInvite
    {
        /// <summary>
        /// StructProperty: LobbyId
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId LobbyId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: FriendId
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId FriendId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bAccepted
        /// </summary>
        public unsafe bool bAccepted
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FControllerConnectionState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FControllerConnectionState
    {
        /// <summary>
        /// IntProperty: bIsControllerConnected
        /// </summary>
        public unsafe int bIsControllerConnected
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: bLastIsControllerConnected
        /// </summary>
        public unsafe int bLastIsControllerConnected
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FOnlineStatusMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FOnlineStatusMapping
    {
        /// <summary>
        /// IntProperty: StatusId
        /// </summary>
        public unsafe int StatusId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: StatusString
        /// </summary>
        public unsafe BmSDK.FString StatusString
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FDeviceIdCache
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FDeviceIdCache
    {
        /// <summary>
        /// IntProperty: DeviceID
        /// </summary>
        public unsafe int DeviceID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// DelegateProperty: DeviceSelectionMulticast
        /// </summary>
        public unsafe System.IntPtr DeviceSelectionMulticast
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: DeviceSelectionDelegates
        /// </summary>
        public unsafe BmSDK.TArray<System.IntPtr> DeviceSelectionDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FProfileSettingsCache
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FProfileSettingsCache
    {
        /// <summary>
        /// ObjectProperty: Profile
        /// </summary>
        public unsafe BmSDK.Engine.OnlineProfileSettings Profile
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineProfileSettings>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: ReadDelegates
        /// </summary>
        public unsafe BmSDK.TArray<System.IntPtr> ReadDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: WriteDelegates
        /// </summary>
        public unsafe BmSDK.TArray<System.IntPtr> WriteDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ArrayProperty: ProfileDataChangedDelegates
        /// </summary>
        public unsafe BmSDK.TArray<System.IntPtr> ProfileDataChangedDelegates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Struct: FPendingPlayerStats
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial record struct FPendingPlayerStats
    {
        /// <summary>
        /// StructProperty: Player
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: PlayerName
        /// </summary>
        public unsafe BmSDK.FString PlayerName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: StatGuid
        /// </summary>
        public unsafe BmSDK.FString StatGuid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ArrayProperty: Stats
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FPlayerStat> Stats
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FPlayerStat>>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: Score
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FOnlinePlayerScore Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FOnlinePlayerScore>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StrProperty: Place
        /// </summary>
        public unsafe BmSDK.FString Place
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// Struct: FPlayerStat
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FPlayerStat
    {
        /// <summary>
        /// IntProperty: ViewId
        /// </summary>
        public unsafe int ViewId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ColumnId
        /// </summary>
        public unsafe int ColumnId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.Engine.Settings.FSettingsData Data
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Settings.FSettingsData>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FLocalTalkerSteam
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FLocalTalkerSteam
    {
        /// <summary>
        /// BoolProperty: bHasVoice
        /// </summary>
        public unsafe bool bHasVoice
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bHasNetworkedVoice
        /// </summary>
        public unsafe bool bHasNetworkedVoice
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bIsRecognizingSpeech
        /// </summary>
        public unsafe bool bIsRecognizingSpeech
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bWasTalking
        /// </summary>
        public unsafe bool bWasTalking
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bIsTalking
        /// </summary>
        public unsafe bool bIsTalking
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bIsRegistered
        /// </summary>
        public unsafe bool bIsRegistered
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: MuteType
        /// </summary>
        public unsafe BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.EMuteType MuteType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.EMuteType>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EMuteType
    /// </summary>
    public enum EMuteType : byte
    {
        MUTE_None = 0,
        MUTE_AllButFriends = 1,
        MUTE_All = 2,
        MUTE_MAX = 3,
    }

    /// <summary>
    /// InlineArray{ByteProperty}: SteamTicket
    /// </summary>
    public InlineArray<byte> SteamTicket => new(1024, Ptr + 304, 1, this);

    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 305); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 305); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 306); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 306); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 307); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 307); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 309); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 309); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 310); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 310); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 311); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 311); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 313); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 313); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 314); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 314); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 315); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 315); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 317); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 317); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 318); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 318); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 319); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 319); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 321); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 321); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 322); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 322); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 323); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 323); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 325); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 325); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 326); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 326); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 327); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 327); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 329); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 329); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 330); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 330); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 331); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 331); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 333); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 333); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 334); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 334); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 335); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 335); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 337); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 337); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 338); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 338); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 339); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 339); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 341); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 341); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 342); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 342); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 343); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 343); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 345); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 345); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 346); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 346); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 347); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 347); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 349); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 349); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 350); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 350); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 351); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 351); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 353); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 353); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 354); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 354); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 355); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 355); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 357); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 357); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 358); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 358); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 359); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 359); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 361); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 361); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 362); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 362); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 363); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 363); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 365); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 365); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 366); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 366); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 367); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 367); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 369); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 369); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 370); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 370); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 371); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 371); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 373); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 373); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 374); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 374); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_71
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 375); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 375); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_72
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_73
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 377); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 377); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_74
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 378); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 378); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_75
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 379); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 379); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_76
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_77
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 381); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 381); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_78
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 382); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 382); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_79
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 383); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 383); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_80
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_81
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 385); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 385); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_82
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 386); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 386); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_83
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 387); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 387); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_84
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_85
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 389); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 389); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_86
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 390); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 390); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_87
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 391); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 391); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_88
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_89
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 393); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 393); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_90
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 394); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 394); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_91
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 395); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 395); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_92
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_93
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 397); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 397); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_94
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 398); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 398); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_95
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 399); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 399); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_96
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_97
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 401); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 401); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_98
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 402); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 402); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_99
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 403); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 403); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_100
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_101
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 405); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 405); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_102
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 406); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 406); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_103
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 407); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 407); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_104
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_105
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 409); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 409); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_106
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 410); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 410); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_107
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 411); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 411); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_108
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_109
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 413); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 413); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_110
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 414); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 414); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_111
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 415); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 415); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_112
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_113
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 417); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 417); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_114
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 418); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 418); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_115
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 419); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 419); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_116
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_117
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 421); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 421); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_118
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 422); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 422); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_119
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 423); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 423); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_120
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_121
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 425); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 425); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_122
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 426); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 426); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_123
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 427); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 427); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_124
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_125
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 429); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 429); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_126
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 430); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 430); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_127
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 431); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 431); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_128
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_129
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 433); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 433); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_130
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 434); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 434); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_131
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 435); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 435); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_132
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_133
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 437); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 437); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_134
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 438); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 438); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_135
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 439); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 439); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_136
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_137
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 441); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 441); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_138
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 442); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 442); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_139
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 443); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 443); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_140
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_141
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 445); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 445); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_142
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 446); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 446); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_143
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 447); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 447); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_144
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_145
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 449); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 449); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_146
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 450); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 450); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_147
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 451); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 451); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_148
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_149
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 453); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 453); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_150
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 454); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 454); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_151
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 455); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 455); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_152
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_153
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 457); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 457); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_154
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 458); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 458); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_155
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 459); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 459); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_156
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_157
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 461); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 461); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_158
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 462); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 462); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_159
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 463); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 463); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_160
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_161
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 465); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 465); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_162
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 466); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 466); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_163
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 467); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 467); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_164
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_165
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 469); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 469); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_166
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 470); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 470); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_167
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 471); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 471); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_168
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_169
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 473); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 473); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_170
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 474); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 474); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_171
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 475); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 475); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_172
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_173
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 477); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 477); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_174
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 478); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 478); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_175
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 479); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 479); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_176
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_177
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 481); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 481); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_178
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 482); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 482); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_179
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 483); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 483); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_180
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_181
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 485); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 485); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_182
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 486); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 486); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_183
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 487); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 487); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_184
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_185
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 489); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 489); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_186
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 490); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 490); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_187
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 491); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 491); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_188
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_189
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 493); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 493); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_190
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 494); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 494); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_191
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 495); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 495); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_192
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_193
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 497); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 497); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_194
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 498); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 498); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_195
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 499); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 499); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_196
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_197
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 501); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 501); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_198
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 502); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 502); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_199
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 503); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 503); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_200
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_201
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 505); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 505); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_202
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 506); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 506); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_203
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 507); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 507); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_204
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_205
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 509); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 509); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_206
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 510); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 510); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_207
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 511); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 511); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_208
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_209
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 513); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 513); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_210
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 514); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 514); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_211
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 515); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 515); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_212
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_213
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 517); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 517); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_214
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 518); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 518); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_215
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 519); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 519); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_216
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_217
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 521); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 521); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_218
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 522); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 522); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_219
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 523); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 523); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_220
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_221
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 525); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 525); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_222
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 526); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 526); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_223
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 527); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 527); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_224
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_225
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 529); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 529); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_226
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 530); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 530); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_227
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 531); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 531); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_228
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_229
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 533); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 533); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_230
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 534); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 534); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_231
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 535); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 535); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_232
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_233
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 537); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 537); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_234
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 538); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 538); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_235
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 539); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 539); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_236
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_237
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 541); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 541); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_238
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 542); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 542); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_239
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 543); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 543); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_240
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_241
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 545); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 545); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_242
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 546); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 546); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_243
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 547); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 547); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_244
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_245
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 549); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 549); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_246
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 550); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 550); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_247
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 551); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 551); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_248
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_249
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 553); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 553); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_250
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 554); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 554); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_251
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 555); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 555); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_252
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_253
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 557); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 557); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_254
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 558); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 558); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_255
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 559); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 559); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_256
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_257
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 561); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 561); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_258
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 562); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 562); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_259
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 563); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 563); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_260
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_261
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 565); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 565); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_262
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 566); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 566); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_263
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 567); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 567); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_264
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_265
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 569); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 569); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_266
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 570); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 570); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_267
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 571); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 571); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_268
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_269
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 573); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 573); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_270
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 574); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 574); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_271
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 575); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 575); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_272
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_273
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 577); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 577); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_274
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 578); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 578); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_275
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 579); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 579); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_276
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_277
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 581); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 581); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_278
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 582); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 582); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_279
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 583); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 583); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_280
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_281
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 585); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 585); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_282
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 586); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 586); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_283
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 587); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 587); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_284
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_285
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 589); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 589); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_286
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 590); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 590); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_287
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 591); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 591); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_288
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_289
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 593); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 593); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_290
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 594); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 594); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_291
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 595); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 595); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_292
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_293
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 597); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 597); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_294
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 598); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 598); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_295
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 599); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 599); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_296
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_297
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 601); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 601); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_298
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 602); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 602); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_299
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 603); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 603); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_300
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_301
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 605); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 605); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_302
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 606); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 606); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_303
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 607); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 607); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_304
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_305
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 609); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 609); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_306
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 610); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 610); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_307
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 611); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 611); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_308
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_309
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 613); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 613); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_310
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 614); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 614); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_311
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 615); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 615); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_312
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_313
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 617); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 617); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_314
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 618); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 618); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_315
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 619); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 619); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_316
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_317
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 621); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 621); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_318
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 622); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 622); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_319
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 623); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 623); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_320
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_321
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 625); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 625); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_322
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 626); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 626); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_323
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 627); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 627); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_324
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_325
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 629); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 629); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_326
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 630); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 630); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_327
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 631); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 631); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_328
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_329
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 633); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 633); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_330
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 634); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 634); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_331
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 635); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 635); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_332
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_333
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 637); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 637); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_334
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 638); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 638); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_335
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 639); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 639); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_336
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_337
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 641); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 641); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_338
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 642); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 642); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_339
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 643); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 643); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_340
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_341
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 645); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 645); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_342
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 646); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 646); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_343
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 647); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 647); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_344
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_345
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 649); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 649); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_346
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 650); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 650); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_347
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 651); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 651); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_348
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_349
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 653); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 653); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_350
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 654); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 654); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_351
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 655); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 655); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_352
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_353
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 657); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 657); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_354
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 658); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 658); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_355
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 659); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 659); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_356
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_357
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 661); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 661); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_358
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 662); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 662); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_359
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 663); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 663); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_360
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_361
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 665); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 665); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_362
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 666); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 666); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_363
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 667); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 667); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_364
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_365
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 669); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 669); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_366
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 670); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 670); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_367
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 671); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 671); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_368
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_369
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 673); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 673); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_370
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 674); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 674); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_371
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 675); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 675); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_372
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_373
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 677); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 677); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_374
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 678); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 678); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_375
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 679); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 679); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_376
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_377
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 681); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 681); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_378
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 682); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 682); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_379
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 683); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 683); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_380
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_381
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 685); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 685); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_382
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 686); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 686); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_383
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 687); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 687); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_384
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_385
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 689); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 689); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_386
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 690); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 690); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_387
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 691); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 691); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_388
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_389
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 693); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 693); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_390
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 694); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 694); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_391
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 695); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 695); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_392
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_393
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 697); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 697); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_394
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 698); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 698); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_395
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 699); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 699); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_396
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_397
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 701); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 701); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_398
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 702); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 702); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_399
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 703); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 703); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_400
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_401
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 705); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 705); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_402
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 706); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 706); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_403
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 707); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 707); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_404
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_405
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 709); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 709); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_406
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 710); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 710); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_407
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 711); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 711); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_408
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_409
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 713); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 713); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_410
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 714); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 714); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_411
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 715); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 715); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_412
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_413
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 717); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 717); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_414
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 718); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 718); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_415
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 719); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 719); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_416
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_417
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 721); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 721); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_418
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 722); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 722); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_419
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 723); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 723); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_420
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_421
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 725); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 725); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_422
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 726); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 726); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_423
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 727); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 727); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_424
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_425
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 729); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 729); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_426
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 730); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 730); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_427
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 731); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 731); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_428
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_429
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 733); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 733); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_430
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 734); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 734); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_431
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 735); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 735); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_432
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_433
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 737); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 737); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_434
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 738); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 738); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_435
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 739); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 739); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_436
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_437
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 741); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 741); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_438
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 742); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 742); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_439
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 743); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 743); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_440
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_441
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 745); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 745); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_442
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 746); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 746); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_443
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 747); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 747); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_444
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_445
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 749); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 749); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_446
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 750); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 750); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_447
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 751); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 751); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_448
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_449
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 753); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 753); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_450
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 754); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 754); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_451
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 755); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 755); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_452
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_453
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 757); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 757); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_454
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 758); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 758); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_455
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 759); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 759); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_456
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_457
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 761); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 761); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_458
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 762); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 762); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_459
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 763); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 763); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_460
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_461
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 765); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 765); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_462
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 766); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 766); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_463
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 767); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 767); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_464
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_465
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 769); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 769); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_466
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 770); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 770); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_467
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 771); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 771); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_468
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_469
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 773); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 773); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_470
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 774); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 774); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_471
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 775); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 775); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_472
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_473
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 777); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 777); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_474
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 778); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 778); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_475
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 779); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 779); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_476
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_477
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 781); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 781); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_478
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 782); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 782); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_479
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 783); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 783); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_480
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_481
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 785); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 785); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_482
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 786); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 786); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_483
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 787); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 787); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_484
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_485
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 789); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 789); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_486
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 790); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 790); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_487
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 791); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 791); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_488
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_489
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 793); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 793); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_490
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 794); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 794); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_491
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 795); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 795); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_492
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_493
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 797); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 797); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_494
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 798); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 798); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_495
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 799); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 799); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_496
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_497
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 801); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 801); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_498
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 802); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 802); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_499
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 803); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 803); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_500
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_501
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 805); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 805); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_502
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 806); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 806); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_503
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 807); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 807); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_504
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_505
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 809); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 809); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_506
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 810); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 810); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_507
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 811); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 811); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_508
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_509
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 813); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 813); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_510
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 814); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 814); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_511
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 815); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 815); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_512
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_513
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 817); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 817); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_514
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 818); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 818); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_515
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 819); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 819); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_516
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_517
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 821); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 821); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_518
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 822); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 822); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_519
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 823); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 823); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_520
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_521
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 825); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 825); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_522
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 826); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 826); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_523
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 827); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 827); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_524
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_525
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 829); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 829); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_526
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 830); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 830); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_527
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 831); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 831); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_528
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_529
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 833); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 833); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_530
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 834); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 834); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_531
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 835); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 835); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_532
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_533
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 837); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 837); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_534
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 838); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 838); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_535
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 839); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 839); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_536
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_537
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 841); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 841); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_538
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 842); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 842); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_539
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 843); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 843); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_540
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_541
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 845); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 845); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_542
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 846); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 846); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_543
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 847); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 847); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_544
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_545
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 849); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 849); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_546
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 850); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 850); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_547
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 851); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 851); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_548
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_549
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 853); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 853); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_550
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 854); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 854); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_551
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 855); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 855); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_552
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_553
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 857); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 857); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_554
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 858); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 858); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_555
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 859); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 859); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_556
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_557
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 861); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 861); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_558
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 862); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 862); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_559
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 863); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 863); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_560
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_561
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 865); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 865); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_562
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 866); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 866); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_563
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 867); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 867); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_564
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_565
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 869); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 869); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_566
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 870); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 870); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_567
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 871); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 871); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_568
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_569
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 873); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 873); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_570
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 874); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 874); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_571
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 875); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 875); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_572
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_573
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 877); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 877); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_574
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 878); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 878); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_575
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 879); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 879); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_576
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_577
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 881); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 881); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_578
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 882); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 882); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_579
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 883); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 883); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_580
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_581
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 885); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 885); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_582
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 886); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 886); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_583
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 887); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 887); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_584
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_585
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 889); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 889); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_586
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 890); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 890); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_587
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 891); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 891); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_588
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_589
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 893); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 893); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_590
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 894); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 894); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_591
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 895); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 895); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_592
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_593
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 897); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 897); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_594
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 898); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 898); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_595
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 899); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 899); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_596
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_597
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 901); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 901); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_598
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 902); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 902); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_599
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 903); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 903); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_600
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_601
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 905); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 905); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_602
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 906); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 906); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_603
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 907); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 907); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_604
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_605
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 909); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 909); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_606
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 910); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 910); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_607
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 911); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 911); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_608
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_609
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 913); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 913); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_610
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 914); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 914); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_611
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 915); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 915); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_612
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_613
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 917); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 917); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_614
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 918); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 918); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_615
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 919); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 919); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_616
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_617
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 921); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 921); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_618
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 922); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 922); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_619
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 923); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 923); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_620
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_621
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 925); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 925); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_622
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 926); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 926); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_623
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 927); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 927); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_624
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_625
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 929); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 929); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_626
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 930); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 930); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_627
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 931); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 931); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_628
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_629
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 933); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 933); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_630
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 934); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 934); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_631
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 935); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 935); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_632
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_633
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 937); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 937); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_634
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 938); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 938); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_635
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 939); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 939); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_636
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_637
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 941); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 941); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_638
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 942); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 942); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_639
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 943); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 943); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_640
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_641
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 945); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 945); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_642
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 946); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 946); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_643
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 947); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 947); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_644
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_645
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 949); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 949); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_646
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 950); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 950); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_647
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 951); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 951); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_648
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_649
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 953); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 953); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_650
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 954); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 954); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_651
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 955); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 955); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_652
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_653
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 957); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 957); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_654
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 958); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 958); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_655
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 959); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 959); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_656
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_657
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 961); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 961); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_658
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 962); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 962); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_659
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 963); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 963); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_660
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_661
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 965); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 965); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_662
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 966); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 966); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_663
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 967); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 967); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_664
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_665
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 969); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 969); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_666
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 970); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 970); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_667
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 971); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 971); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_668
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_669
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 973); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 973); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_670
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 974); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 974); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_671
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 975); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 975); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_672
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_673
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 977); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 977); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_674
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 978); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 978); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_675
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 979); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 979); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_676
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_677
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 981); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 981); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_678
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 982); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 982); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_679
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 983); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 983); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_680
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_681
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 985); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 985); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_682
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 986); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 986); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_683
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 987); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 987); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_684
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_685
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 989); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 989); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_686
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 990); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 990); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_687
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 991); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 991); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_688
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_689
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 993); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 993); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_690
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 994); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 994); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_691
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 995); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 995); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_692
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_693
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 997); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 997); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_694
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 998); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 998); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_695
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 999); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 999); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_696
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_697
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1001); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1001); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_698
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1002); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1002); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_699
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1003); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1003); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_700
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_701
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1005); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1005); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_702
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1006); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1006); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_703
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1007); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1007); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_704
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_705
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1009); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1009); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_706
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1010); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1010); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_707
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1011); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1011); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_708
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_709
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1013); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1013); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_710
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1014); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1014); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_711
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1015); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1015); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_712
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_713
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1017); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1017); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_714
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1018); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1018); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_715
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1019); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1019); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_716
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_717
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1021); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1021); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_718
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1022); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1022); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_719
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1023); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1023); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_720
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_721
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1025); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1025); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_722
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1026); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1026); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_723
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1027); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1027); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_724
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_725
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1029); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1029); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_726
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1030); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1030); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_727
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1031); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1031); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_728
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_729
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1033); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1033); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_730
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1034); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1034); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_731
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1035); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1035); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_732
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_733
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1037); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1037); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_734
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1038); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1038); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_735
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1039); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1039); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_736
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_737
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1041); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1041); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_738
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1042); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1042); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_739
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1043); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1043); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_740
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_741
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1045); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1045); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_742
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1046); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1046); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_743
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1047); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1047); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_744
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_745
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1049); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1049); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_746
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1050); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1050); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_747
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1051); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1051); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_748
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_749
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1053); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1053); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_750
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1054); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1054); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_751
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1055); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1055); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_752
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_753
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1057); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1057); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_754
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1058); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1058); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_755
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1059); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1059); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_756
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_757
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1061); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1061); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_758
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1062); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1062); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_759
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1063); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1063); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_760
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_761
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1065); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1065); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_762
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1066); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1066); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_763
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1067); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1067); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_764
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_765
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1069); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1069); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_766
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1070); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1070); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_767
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1071); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1071); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_768
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_769
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1073); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1073); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_770
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1074); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1074); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_771
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1075); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1075); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_772
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_773
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1077); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1077); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_774
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1078); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1078); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_775
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1079); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1079); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_776
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_777
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1081); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1081); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_778
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1082); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1082); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_779
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1083); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1083); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_780
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_781
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1085); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1085); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_782
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1086); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1086); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_783
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1087); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1087); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_784
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_785
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1089); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1089); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_786
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1090); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1090); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_787
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1091); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1091); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_788
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_789
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1093); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1093); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_790
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1094); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1094); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_791
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1095); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1095); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_792
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_793
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1097); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1097); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_794
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1098); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1098); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_795
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1099); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1099); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_796
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_797
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1101); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1101); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_798
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1102); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1102); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_799
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1103); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1103); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_800
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_801
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1105); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1105); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_802
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1106); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1106); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_803
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1107); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1107); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_804
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_805
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1109); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1109); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_806
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1110); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1110); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_807
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1111); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1111); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_808
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_809
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1113); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1113); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_810
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1114); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1114); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_811
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1115); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1115); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_812
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_813
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1117); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1117); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_814
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1118); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1118); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_815
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1119); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1119); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_816
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_817
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1121); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1121); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_818
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1122); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1122); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_819
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1123); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1123); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_820
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_821
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1125); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1125); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_822
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1126); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1126); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_823
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1127); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1127); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_824
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_825
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1129); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1129); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_826
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1130); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1130); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_827
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1131); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1131); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_828
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_829
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1133); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1133); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_830
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1134); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1134); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_831
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1135); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1135); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_832
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_833
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1137); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1137); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_834
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1138); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1138); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_835
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1139); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1139); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_836
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_837
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1141); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1141); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_838
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1142); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1142); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_839
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1143); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1143); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_840
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_841
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1145); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1145); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_842
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1146); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1146); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_843
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1147); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1147); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_844
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_845
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1149); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1149); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_846
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1150); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1150); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_847
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1151); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1151); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_848
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_849
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1153); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1153); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_850
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1154); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1154); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_851
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1155); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1155); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_852
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_853
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1157); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1157); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_854
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1158); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1158); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_855
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1159); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1159); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_856
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_857
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1161); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1161); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_858
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1162); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1162); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_859
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1163); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1163); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_860
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_861
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1165); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1165); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_862
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1166); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1166); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_863
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1167); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1167); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_864
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_865
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1169); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1169); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_866
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1170); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1170); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_867
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1171); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1171); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_868
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_869
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1173); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1173); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_870
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1174); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1174); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_871
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1175); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1175); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_872
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_873
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1177); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1177); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_874
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1178); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1178); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_875
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1179); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1179); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_876
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_877
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1181); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1181); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_878
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1182); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1182); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_879
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1183); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1183); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_880
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_881
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1185); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1185); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_882
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1186); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1186); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_883
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1187); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1187); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_884
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_885
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1189); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1189); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_886
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1190); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1190); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_887
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1191); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1191); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_888
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_889
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1193); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1193); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_890
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1194); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1194); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_891
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1195); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1195); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_892
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_893
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1197); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1197); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_894
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1198); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1198); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_895
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1199); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1199); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_896
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_897
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1201); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1201); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_898
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1202); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1202); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_899
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1203); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1203); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_900
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_901
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1205); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1205); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_902
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1206); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1206); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_903
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1207); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1207); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_904
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_905
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1209); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1209); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_906
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1210); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1210); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_907
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1211); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1211); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_908
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_909
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1213); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1213); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_910
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1214); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1214); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_911
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1215); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1215); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_912
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_913
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1217); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1217); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_914
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1218); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1218); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_915
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1219); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1219); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_916
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_917
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1221); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1221); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_918
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1222); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1222); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_919
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1223); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1223); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_920
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_921
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1225); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1225); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_922
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1226); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1226); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_923
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1227); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1227); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_924
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_925
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1229); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1229); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_926
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1230); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1230); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_927
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1231); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1231); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_928
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_929
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1233); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1233); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_930
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1234); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1234); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_931
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1235); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1235); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_932
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_933
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1237); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1237); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_934
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1238); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1238); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_935
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1239); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1239); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_936
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_937
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1241); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1241); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_938
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1242); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1242); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_939
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1243); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1243); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_940
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_941
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1245); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1245); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_942
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1246); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1246); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_943
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1247); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1247); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_944
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_945
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1249); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1249); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_946
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1250); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1250); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_947
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1251); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1251); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_948
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_949
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1253); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1253); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_950
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1254); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1254); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_951
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1255); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1255); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_952
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_953
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1257); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1257); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_954
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1258); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1258); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_955
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1259); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1259); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_956
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_957
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1261); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1261); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_958
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1262); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1262); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_959
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1263); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1263); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_960
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_961
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1265); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1265); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_962
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1266); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1266); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_963
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1267); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1267); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_964
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_965
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1269); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1269); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_966
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1270); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1270); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_967
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1271); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1271); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_968
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_969
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1273); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1273); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_970
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1274); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1274); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_971
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1275); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1275); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_972
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_973
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1277); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1277); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_974
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1278); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1278); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_975
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1279); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1279); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_976
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_977
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1281); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1281); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_978
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1282); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1282); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_979
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1283); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1283); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_980
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_981
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1285); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1285); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_982
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1286); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1286); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_983
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1287); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1287); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_984
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_985
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1289); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1289); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_986
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1290); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1290); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_987
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1291); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1291); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_988
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_989
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1293); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1293); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_990
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1294); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1294); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_991
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1295); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1295); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_992
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_993
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1297); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1297); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_994
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1298); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1298); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_995
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1299); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1299); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_996
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_997
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1301); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1301); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_998
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1302); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1302); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_999
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1303); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1303); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1000
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1001
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1305); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1305); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1002
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1306); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1306); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1003
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1307); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1307); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1004
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1005
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1309); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1309); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1006
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1310); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1310); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1007
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1311); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1311); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1008
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1009
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1313); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1313); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1010
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1314); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1314); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1011
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1315); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1315); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1012
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1013
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1317); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1317); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1014
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1318); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1318); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1015
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1319); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1319); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1016
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1017
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1321); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1321); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1018
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1322); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1322); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1019
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1323); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1323); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1020
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1021
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1325); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1325); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1022
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1326); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1326); }
    }
    /// <summary>
    /// ByteProperty: SteamTicket
    /// </summary>
    public unsafe byte SteamTicket_1023
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1327); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1327); }
    }

    /// <summary>
    /// ByteProperty: UserStatsReceivedState
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState UserStatsReceivedState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// ByteProperty: LoggedInStatus
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.ELoginStatus LoggedInStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ELoginStatus>(Ptr + 1329); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1329); }
    }

    /// <summary>
    /// ByteProperty: bWasKeyboardInputCanceled
    /// </summary>
    public unsafe byte bWasKeyboardInputCanceled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1330); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1330); }
    }

    /// <summary>
    /// ByteProperty: CurrentNotificationPosition
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition CurrentNotificationPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ENetworkNotificationPosition>(Ptr + 1331); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1331); }
    }

    /// <summary>
    /// IntProperty: SteamTicketSize
    /// </summary>
    public unsafe int SteamTicketSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForSteamTicket
    /// </summary>
    public unsafe bool bWaitingForSteamTicket
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1336); }
    }

    /// <summary>
    /// BoolProperty: bStoringAchievement
    /// </summary>
    public unsafe bool bStoringAchievement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1336); }
    }

    /// <summary>
    /// BoolProperty: bClientStatsStorePending
    /// </summary>
    public unsafe bool bClientStatsStorePending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1336); }
    }

    /// <summary>
    /// BoolProperty: bGSStatsStoresSuccess
    /// </summary>
    public unsafe bool bGSStatsStoresSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1336); }
    }

    /// <summary>
    /// BoolProperty: bNeedsKeyboardTicking
    /// </summary>
    public unsafe bool bNeedsKeyboardTicking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1336); }
    }

    /// <summary>
    /// BoolProperty: bLastHasConnection
    /// </summary>
    public unsafe bool bLastHasConnection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1336); }
    }

    /// <summary>
    /// BoolProperty: bIsStatsSessionOk
    /// </summary>
    public unsafe bool bIsStatsSessionOk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1336); }
    }

    /// <summary>
    /// BoolProperty: bHasSteamworksAccount
    /// </summary>
    public unsafe bool bHasSteamworksAccount
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1336); }
    }

    /// <summary>
    /// BoolProperty: bShouldUseMcp
    /// </summary>
    public unsafe bool bShouldUseMcp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1336); }
    }

    /// <summary>
    /// StructProperty: SteamCallResultEncryptedAppTicket
    /// </summary>
    public unsafe System.IntPtr SteamCallResultEncryptedAppTicket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// IntProperty: TotalGSStatsStoresPending
    /// </summary>
    public unsafe int TotalGSStatsStoresPending
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// ObjectProperty: CachedGameInt
    /// </summary>
    public unsafe BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks CachedGameInt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks.OnlineGameInterfaceSteamworks>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// StrProperty: LocalProfileName
    /// </summary>
    public unsafe BmSDK.FString LocalProfileName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// StrProperty: LoggedInPlayerName
    /// </summary>
    public unsafe BmSDK.FString LoggedInPlayerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// StructProperty: LoggedInPlayerId
    /// </summary>
    public unsafe ref BmSDK.Engine.OnlineSubsystem.FUniqueNetId LoggedInPlayerId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 1376);

    /// <summary>
    /// IntProperty: LoggedInPlayerNum
    /// </summary>
    public unsafe int LoggedInPlayerNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// StrProperty: ProfileDataDirectory
    /// </summary>
    public unsafe BmSDK.FString ProfileDataDirectory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// StrProperty: ProfileDataExtension
    /// </summary>
    public unsafe BmSDK.FString ProfileDataExtension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// ArrayProperty: WriteProfileSettingsDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> WriteProfileSettingsDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// ObjectProperty: CachedProfile
    /// </summary>
    public unsafe BmSDK.Engine.OnlineProfileSettings CachedProfile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineProfileSettings>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// ArrayProperty: LocalPlayerStorageReadDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LocalPlayerStorageReadDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// ArrayProperty: LocalPlayerStorageWriteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LocalPlayerStorageWriteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// ArrayProperty: RemotePlayerStorageReadDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> RemotePlayerStorageReadDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// ArrayProperty: SpeechRecognitionCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> SpeechRecognitionCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// ArrayProperty: ReadFriendsDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ReadFriendsDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// ArrayProperty: FriendsChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FriendsChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// ArrayProperty: MutingChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> MutingChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// ArrayProperty: LoginChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LoginChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// ArrayProperty: LoginFailedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LoginFailedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// ArrayProperty: LogoutCompletedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LogoutCompletedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// ArrayProperty: AccountCreateDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> AccountCreateDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// ArrayProperty: TalkingDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> TalkingDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// ArrayProperty: ReadOnlineStatsCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ReadOnlineStatsCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// ArrayProperty: FlushOnlineStatsDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FlushOnlineStatsDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// ArrayProperty: ConnectionStatusChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ConnectionStatusChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// ArrayProperty: ControllerChangeDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ControllerChangeDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// ArrayProperty: LinkStatusDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LinkStatusDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// ArrayProperty: ReadTitleFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ReadTitleFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }

    /// <summary>
    /// ArrayProperty: AchievementDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> AchievementDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1644); }
    }

    /// <summary>
    /// ArrayProperty: AchievementReadDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> AchievementReadDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }
    }

    /// <summary>
    /// ArrayProperty: EnumerateUserFilesCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> EnumerateUserFilesCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// ArrayProperty: ReadUserFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ReadUserFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }

    /// <summary>
    /// ArrayProperty: WriteUserFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> WriteUserFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// ArrayProperty: DeleteUserFileCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> DeleteUserFileCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// ArrayProperty: SharedFileReadCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> SharedFileReadCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// ArrayProperty: SharedFileWriteCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> SharedFileWriteCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }
    }

    /// <summary>
    /// ArrayProperty: MicroTransactionResponseDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> MicroTransactionResponseDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// ObjectProperty: VOIPNetDriver
    /// </summary>
    public unsafe BmSDK.Engine.NetDriver VOIPNetDriver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NetDriver>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// StructProperty: CurrentLocalTalker
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLocalTalkerSteam CurrentLocalTalker
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLocalTalkerSteam>(Ptr + 1756);

    /// <summary>
    /// ArrayProperty: RemoteTalkers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FRemoteTalker> RemoteTalkers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FRemoteTalker>>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// IntProperty: GameID
    /// </summary>
    public unsafe int GameID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// ObjectProperty: CurrentStatsRead
    /// </summary>
    public unsafe BmSDK.Engine.OnlineStatsRead CurrentStatsRead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineStatsRead>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// ArrayProperty: PendingStats
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FPendingPlayerStats> PendingStats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FPendingPlayerStats>>(Ptr + 1784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }
    }

    /// <summary>
    /// StrProperty: KeyboardResultsString
    /// </summary>
    public unsafe BmSDK.FString KeyboardResultsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// ArrayProperty: KeyboardInputDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> KeyboardInputDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// ArrayProperty: FriendInviteReceivedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FriendInviteReceivedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// ArrayProperty: FriendMessageReceivedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FriendMessageReceivedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// ArrayProperty: AddFriendByNameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> AddFriendByNameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// StructProperty: ProfileCache
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FProfileSettingsCache ProfileCache
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FProfileSettingsCache>(Ptr + 1856);

    /// <summary>
    /// ObjectProperty: PlayerStorageCache
    /// </summary>
    public unsafe BmSDK.Engine.OnlinePlayerStorage PlayerStorageCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePlayerStorage>(Ptr + 1896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }
    }

    /// <summary>
    /// StrProperty: CachedFriendMessage
    /// </summary>
    public unsafe BmSDK.FString CachedFriendMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// StructProperty: DeviceCache
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeviceIdCache DeviceCache
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeviceIdCache>(Ptr + 1912);

    /// <summary>
    /// ArrayProperty: LocationUrlsForInvites
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LocationUrlsForInvites
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// StrProperty: LocationUrl
    /// </summary>
    public unsafe BmSDK.FString LocationUrl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// ArrayProperty: ReceivedGameInviteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ReceivedGameInviteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// ArrayProperty: JoinFriendGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> JoinFriendGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// ArrayProperty: GetNumberOfCurrentPlayersCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> GetNumberOfCurrentPlayersCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// ArrayProperty: RegisterHostStatGuidCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> RegisterHostStatGuidCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }

    /// <summary>
    /// ArrayProperty: CachedFriendMessages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriendMessage> CachedFriendMessages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriendMessage>>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// ArrayProperty: StatusMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FOnlineStatusMapping> StatusMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FOnlineStatusMapping>>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// StrProperty: DefaultStatus
    /// </summary>
    public unsafe BmSDK.FString DefaultStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// StrProperty: GameInviteMessage
    /// </summary>
    public unsafe BmSDK.FString GameInviteMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ControllerStates
    /// </summary>
    public InlineArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState> ControllerStates => new(4, Ptr + 2060, 8, this);

    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState ControllerStates_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState>(Ptr + 2060);
    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState ControllerStates_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState>(Ptr + 2068);
    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState ControllerStates_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState>(Ptr + 2076);
    /// <summary>
    /// StructProperty: ControllerStates
    /// </summary>
    public unsafe ref BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState ControllerStates_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FControllerConnectionState>(Ptr + 2084);

    /// <summary>
    /// FloatProperty: ConnectionPresenceTimeInterval
    /// </summary>
    public unsafe float ConnectionPresenceTimeInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// FloatProperty: ConnectionPresenceElapsedTime
    /// </summary>
    public unsafe float ConnectionPresenceElapsedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// StrProperty: EncryptedProductKey
    /// </summary>
    public unsafe BmSDK.FString EncryptedProductKey
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// ArrayProperty: MuteList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> MuteList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// ArrayProperty: DelayedInvites
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDelayedInvite> DelayedInvites
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDelayedInvite>>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// ArrayProperty: UserCloudFiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamUserCloud> UserCloudFiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamUserCloud>>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// ArrayProperty: UserCloudMetadata
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamUserCloudMetadata> UserCloudMetadata
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FSteamUserCloudMetadata>>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// ArrayProperty: SharedFileCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FTitleFile> SharedFileCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FTitleFile>>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// ArrayProperty: QueuedAvatarRequests
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FQueuedAvatarRequest> QueuedAvatarRequests
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FQueuedAvatarRequest>>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// ArrayProperty: AchievementMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FAchievementMappingInfo> AchievementMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FAchievementMappingInfo>>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// ArrayProperty: PendingAchievementProgress
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FAchievementProgressStat> PendingAchievementProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FAchievementProgressStat>>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// ArrayProperty: LeaderboardList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLeaderboardTemplate> LeaderboardList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FLeaderboardTemplate>>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// ArrayProperty: DeferredLeaderboardReads
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardRead> DeferredLeaderboardReads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardRead>>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// ArrayProperty: DeferredLeaderboardWrites
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardWrite> DeferredLeaderboardWrites
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardWrite>>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// ArrayProperty: PendingLeaderboardStats
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardWrite> PendingLeaderboardStats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FDeferredLeaderboardWrite>>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// ArrayProperty: LeaderboardNameMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FViewIdToLeaderboardName> LeaderboardNameMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FViewIdToLeaderboardName>>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// ArrayProperty: GameServerStatsMappings
    /// </summary>
    public unsafe BmSDK.TArray<int> GameServerStatsMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// ObjectProperty: CachedAuthInt
    /// </summary>
    public unsafe BmSDK.OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks CachedAuthInt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// ArrayProperty: PendingRedirects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FIpAddr> PendingRedirects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.OnlineSubsystemSteamworks._OnlineSubsystemSteamworks.FIpAddr>>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// ObjectProperty: LobbyInterface
    /// </summary>
    public unsafe BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks LobbyInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoginChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginCancelled__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoginCancelled__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// DelegateProperty: __OnMutingChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnMutingChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// DelegateProperty: __OnFriendsChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFriendsChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginFailed__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoginFailed__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// DelegateProperty: __OnLogoutCompleted__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLogoutCompleted__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoginStatusChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoginStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2372); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadProfileSettingsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadProfileSettingsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteProfileSettingsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWriteProfileSettingsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadPlayerStorageComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadPlayerStorageComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadPlayerStorageForNetIdComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadPlayerStorageForNetIdComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// DelegateProperty: __OnWritePlayerStorageComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWritePlayerStorageComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadFriendsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadFriendsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// DelegateProperty: __OnPlayerTalkingStateChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnPlayerTalkingStateChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// DelegateProperty: __OnRecognitionComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRecognitionComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadOnlineStatsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadOnlineStatsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// DelegateProperty: __OnFlushOnlineStatsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFlushOnlineStatsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// DelegateProperty: __OnLinkStatusChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLinkStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }

    /// <summary>
    /// DelegateProperty: __OnExternalUIChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnExternalUIChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }

    /// <summary>
    /// DelegateProperty: __OnControllerChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnControllerChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// DelegateProperty: __OnConnectionStatusChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnConnectionStatusChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// DelegateProperty: __OnStorageDeviceChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnStorageDeviceChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadTitleFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadTitleFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// DelegateProperty: __OnCreateOnlineAccountCompleted__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCreateOnlineAccountCompleted__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// DelegateProperty: __OnKeyboardInputComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnKeyboardInputComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// DelegateProperty: __OnAddFriendByNameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnAddFriendByNameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// DelegateProperty: __OnFriendInviteReceived__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFriendInviteReceived__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// DelegateProperty: __OnReceivedGameInvite__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReceivedGameInvite__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// DelegateProperty: __OnJoinFriendGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnJoinFriendGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// DelegateProperty: __OnFriendMessageReceived__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFriendMessageReceived__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// DelegateProperty: __OnRegisterHostStatGuidComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRegisterHostStatGuidComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2660); }
    }

    /// <summary>
    /// DelegateProperty: __OnDeviceSelectionComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDeviceSelectionComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// DelegateProperty: __OnUnlockAchievementComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnUnlockAchievementComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2684); }
    }

    /// <summary>
    /// DelegateProperty: __OnProfileDataChanged__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnProfileDataChanged__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadAchievementsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadAchievementsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2708); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadOnlineAvatarComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadOnlineAvatarComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// DelegateProperty: __OnGetNumberOfCurrentPlayersComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnGetNumberOfCurrentPlayersComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2732); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadCrossTitleProfileSettingsComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadCrossTitleProfileSettingsComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2744); }
    }

    /// <summary>
    /// DelegateProperty: __OnEnumerateUserFilesComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnEnumerateUserFilesComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2756); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadUserFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadUserFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteUserFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWriteUserFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2780); }
    }

    /// <summary>
    /// DelegateProperty: __OnDeleteUserFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDeleteUserFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2792); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadSharedFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadSharedFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2804); }
    }

    /// <summary>
    /// DelegateProperty: __OnWriteSharedFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnWriteSharedFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }
    }

    /// <summary>
    /// DelegateProperty: __OnMicroTransactionResponse__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnMicroTransactionResponse__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2828); }
    }

    /// <summary>
    /// DelegateProperty: __OnNewInfocast__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnNewInfocast__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }
    }
}
