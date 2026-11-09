#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: OnlineGameInterfaceImpl<br/>
/// (size = 420)
/// (flags = 134217878)
/// </summary>
public partial class OnlineGameInterfaceImpl : BmSDK.GameObject, BmSDK.Engine.OnlineGameInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.OnlineGameInterfaceImpl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as OnlineGameInterfaceImpl.
    /// </summary>
    public static OnlineGameInterfaceImpl DefaultObject => (OnlineGameInterfaceImpl)StaticClass().DefaultObject;

    internal OnlineGameInterfaceImpl() { }

    /// <summary>
    /// Constructs a new OnlineGameInterfaceImpl
    /// </summary>
    public OnlineGameInterfaceImpl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineGameInterfaceImpl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineGameInterfaceImpl(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineGameInterfaceImpl>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnQosStatusChanged;
    /// <summary>
    /// Function: OnQosStatusChanged
    /// </summary>
    public unsafe virtual void OnQosStatusChanged(int NumComplete, int NumTotal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnQosStatusChanged, "IpDrv.OnlineGameInterfaceImpl.OnQosStatusChanged");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumComplete, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumTotal, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BindPlatformSpecificSessionToSearch;
    /// <summary>
    /// Function: BindPlatformSpecificSessionToSearch
    /// </summary>
    public unsafe virtual bool BindPlatformSpecificSessionToSearch(byte SearchingPlayerNum, BmSDK.Engine.OnlineGameSearch SearchSettings, byte PlatformSpecificInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BindPlatformSpecificSessionToSearch, "IpDrv.OnlineGameInterfaceImpl.BindPlatformSpecificSessionToSearch");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchingPlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchSettings, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformSpecificInfo, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_ReadPlatformSpecificSessionInfo;
    /// <summary>
    /// Function: ReadPlatformSpecificSessionInfo
    /// </summary>
    public unsafe virtual bool ReadPlatformSpecificSessionInfo(in BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult DesiredGame, out byte PlatformSpecificInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadPlatformSpecificSessionInfo, "IpDrv.OnlineGameInterfaceImpl.ReadPlatformSpecificSessionInfo");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredGame, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnJoinMigratedOnlineGameComplete;
    /// <summary>
    /// Function: OnJoinMigratedOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnJoinMigratedOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnJoinMigratedOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnJoinMigratedOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMigrateOnlineGameComplete;
    /// <summary>
    /// Function: OnMigrateOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnMigrateOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMigrateOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnMigrateOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRecalculateSkillRatingComplete;
    /// <summary>
    /// Function: OnRecalculateSkillRatingComplete
    /// </summary>
    public unsafe virtual void OnRecalculateSkillRatingComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRecalculateSkillRatingComplete, "IpDrv.OnlineGameInterfaceImpl.OnRecalculateSkillRatingComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AcceptGameInvite;
    /// <summary>
    /// Function: AcceptGameInvite
    /// </summary>
    public unsafe virtual bool AcceptGameInvite(byte LocalUserNum, BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AcceptGameInvite, "IpDrv.OnlineGameInterfaceImpl.AcceptGameInvite");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearGameInviteAcceptedDelegate;
    /// <summary>
    /// Function: ClearGameInviteAcceptedDelegate
    /// </summary>
    public unsafe virtual void ClearGameInviteAcceptedDelegate(byte LocalUserNum, System.IntPtr GameInviteAcceptedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGameInviteAcceptedDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearGameInviteAcceptedDelegate");
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
    public unsafe virtual void AddGameInviteAcceptedDelegate(byte LocalUserNum, System.IntPtr GameInviteAcceptedDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGameInviteAcceptedDelegate, "IpDrv.OnlineGameInterfaceImpl.AddGameInviteAcceptedDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameInviteAcceptedDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnGameInviteAccepted;
    /// <summary>
    /// Function: OnGameInviteAccepted
    /// </summary>
    public unsafe virtual void OnGameInviteAccepted(in BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult InviteResult)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGameInviteAccepted, "IpDrv.OnlineGameInterfaceImpl.OnGameInviteAccepted");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteResult, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearArbitrationRegistrationCompleteDelegate;
    /// <summary>
    /// Function: ClearArbitrationRegistrationCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearArbitrationRegistrationCompleteDelegate(System.IntPtr ArbitrationRegistrationCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearArbitrationRegistrationCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearArbitrationRegistrationCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArbitrationRegistrationCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddArbitrationRegistrationCompleteDelegate;
    /// <summary>
    /// Function: AddArbitrationRegistrationCompleteDelegate
    /// </summary>
    public unsafe virtual void AddArbitrationRegistrationCompleteDelegate(System.IntPtr ArbitrationRegistrationCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddArbitrationRegistrationCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddArbitrationRegistrationCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArbitrationRegistrationCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnArbitrationRegistrationComplete;
    /// <summary>
    /// Function: OnArbitrationRegistrationComplete
    /// </summary>
    public unsafe virtual void OnArbitrationRegistrationComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnArbitrationRegistrationComplete, "IpDrv.OnlineGameInterfaceImpl.OnArbitrationRegistrationComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterForArbitration;
    /// <summary>
    /// Function: RegisterForArbitration
    /// </summary>
    public unsafe virtual bool RegisterForArbitration(BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterForArbitration, "IpDrv.OnlineGameInterfaceImpl.RegisterForArbitration");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearEndOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: ClearEndOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearEndOnlineGameCompleteDelegate(System.IntPtr EndOnlineGameCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearEndOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearEndOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddEndOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: AddEndOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddEndOnlineGameCompleteDelegate(System.IntPtr EndOnlineGameCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddEndOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddEndOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnEndOnlineGameComplete;
    /// <summary>
    /// Function: OnEndOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnEndOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEndOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnEndOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndOnlineGame;
    /// <summary>
    /// Function: EndOnlineGame
    /// </summary>
    public unsafe virtual bool EndOnlineGame(BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndOnlineGame, "IpDrv.OnlineGameInterfaceImpl.EndOnlineGame");
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

    private static BmSDK.Function __fn_ClearStartOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: ClearStartOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearStartOnlineGameCompleteDelegate(System.IntPtr StartOnlineGameCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearStartOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearStartOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddStartOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: AddStartOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddStartOnlineGameCompleteDelegate(System.IntPtr StartOnlineGameCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddStartOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddStartOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnStartOnlineGameComplete;
    /// <summary>
    /// Function: OnStartOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnStartOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnStartOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnStartOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartOnlineGame;
    /// <summary>
    /// Function: StartOnlineGame
    /// </summary>
    public unsafe virtual bool StartOnlineGame(BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartOnlineGame, "IpDrv.OnlineGameInterfaceImpl.StartOnlineGame");
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

    private static BmSDK.Function __fn_OnUnregisterPlayerComplete;
    /// <summary>
    /// Function: OnUnregisterPlayerComplete
    /// </summary>
    public unsafe virtual void OnUnregisterPlayerComplete(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnUnregisterPlayerComplete, "IpDrv.OnlineGameInterfaceImpl.OnUnregisterPlayerComplete");
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
    public unsafe virtual bool UnregisterPlayer(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterPlayer, "IpDrv.OnlineGameInterfaceImpl.UnregisterPlayer");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_OnRegisterPlayerComplete;
    /// <summary>
    /// Function: OnRegisterPlayerComplete
    /// </summary>
    public unsafe virtual void OnRegisterPlayerComplete(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRegisterPlayerComplete, "IpDrv.OnlineGameInterfaceImpl.OnRegisterPlayerComplete");
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
    public unsafe virtual bool RegisterPlayer(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bWasInvited)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterPlayer, "IpDrv.OnlineGameInterfaceImpl.RegisterPlayer");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasInvited, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_GetResolvedConnectString;
    /// <summary>
    /// Function: GetResolvedConnectString
    /// </summary>
    public unsafe virtual bool GetResolvedConnectString(BmSDK.FName SessionName, out BmSDK.FString ConnectInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetResolvedConnectString, "IpDrv.OnlineGameInterfaceImpl.GetResolvedConnectString");
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

    private static BmSDK.Function __fn_ClearJoinOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: ClearJoinOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearJoinOnlineGameCompleteDelegate(System.IntPtr JoinOnlineGameCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearJoinOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearJoinOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JoinOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddJoinOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: AddJoinOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddJoinOnlineGameCompleteDelegate(System.IntPtr JoinOnlineGameCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddJoinOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddJoinOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JoinOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnJoinOnlineGameComplete;
    /// <summary>
    /// Function: OnJoinOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnJoinOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnJoinOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnJoinOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JoinOnlineGame;
    /// <summary>
    /// Function: JoinOnlineGame
    /// </summary>
    public unsafe virtual bool JoinOnlineGame(byte PlayerNum, BmSDK.FName SessionName, in BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult DesiredGame)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JoinOnlineGame, "IpDrv.OnlineGameInterfaceImpl.JoinOnlineGame");
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

    private static BmSDK.Function __fn_FreeSearchResults;
    /// <summary>
    /// Function: FreeSearchResults
    /// </summary>
    public unsafe virtual bool FreeSearchResults(BmSDK.Engine.OnlineGameSearch Search)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FreeSearchResults, "IpDrv.OnlineGameInterfaceImpl.FreeSearchResults");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Search, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnCancelFindOnlineGamesComplete;
    /// <summary>
    /// Function: OnCancelFindOnlineGamesComplete
    /// </summary>
    public unsafe virtual void OnCancelFindOnlineGamesComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCancelFindOnlineGamesComplete, "IpDrv.OnlineGameInterfaceImpl.OnCancelFindOnlineGamesComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelFindOnlineGames;
    /// <summary>
    /// Function: CancelFindOnlineGames
    /// </summary>
    public unsafe virtual bool CancelFindOnlineGames()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelFindOnlineGames, "IpDrv.OnlineGameInterfaceImpl.CancelFindOnlineGames");
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

    private static BmSDK.Function __fn_AddFindOnlineGamesCompleteDelegate;
    /// <summary>
    /// Function: AddFindOnlineGamesCompleteDelegate
    /// </summary>
    public unsafe virtual void AddFindOnlineGamesCompleteDelegate(System.IntPtr FindOnlineGamesCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFindOnlineGamesCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddFindOnlineGamesCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FindOnlineGamesCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindOnlineGames;
    /// <summary>
    /// Function: FindOnlineGames
    /// </summary>
    public unsafe virtual bool FindOnlineGames(byte SearchingPlayerNum, BmSDK.Engine.OnlineGameSearch SearchSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindOnlineGames, "IpDrv.OnlineGameInterfaceImpl.FindOnlineGames");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchingPlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchSettings, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ClearDestroyOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: ClearDestroyOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearDestroyOnlineGameCompleteDelegate(System.IntPtr DestroyOnlineGameCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDestroyOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearDestroyOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestroyOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDestroyOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: AddDestroyOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddDestroyOnlineGameCompleteDelegate(System.IntPtr DestroyOnlineGameCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDestroyOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddDestroyOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestroyOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDestroyOnlineGameComplete;
    /// <summary>
    /// Function: OnDestroyOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnDestroyOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDestroyOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnDestroyOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyOnlineGame;
    /// <summary>
    /// Function: DestroyOnlineGame
    /// </summary>
    public unsafe virtual bool DestroyOnlineGame(BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyOnlineGame, "IpDrv.OnlineGameInterfaceImpl.DestroyOnlineGame");
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

    private static BmSDK.Function __fn_OnUpdateOnlineGameComplete;
    /// <summary>
    /// Function: OnUpdateOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnUpdateOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnUpdateOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnUpdateOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearCreateOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: ClearCreateOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearCreateOnlineGameCompleteDelegate(System.IntPtr CreateOnlineGameCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCreateOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.ClearCreateOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CreateOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCreateOnlineGameCompleteDelegate;
    /// <summary>
    /// Function: AddCreateOnlineGameCompleteDelegate
    /// </summary>
    public unsafe virtual void AddCreateOnlineGameCompleteDelegate(System.IntPtr CreateOnlineGameCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCreateOnlineGameCompleteDelegate, "IpDrv.OnlineGameInterfaceImpl.AddCreateOnlineGameCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CreateOnlineGameCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCreateOnlineGameComplete;
    /// <summary>
    /// Function: OnCreateOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnCreateOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCreateOnlineGameComplete, "IpDrv.OnlineGameInterfaceImpl.OnCreateOnlineGameComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateOnlineGame;
    /// <summary>
    /// Function: CreateOnlineGame
    /// </summary>
    public unsafe virtual bool CreateOnlineGame(byte HostingPlayerNum, BmSDK.FName SessionName, BmSDK.Engine.OnlineGameSettings NewGameSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateOnlineGame, "IpDrv.OnlineGameInterfaceImpl.CreateOnlineGame");
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

    private static BmSDK.Function __fn_GetGameSearch;
    /// <summary>
    /// Function: GetGameSearch
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineGameSearch GetGameSearch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameSearch, "IpDrv.OnlineGameInterfaceImpl.GetGameSearch");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineGameSearch>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGameSettings;
    /// <summary>
    /// Function: GetGameSettings
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineGameSettings GetGameSettings(BmSDK.FName SessionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameSettings, "IpDrv.OnlineGameInterfaceImpl.GetGameSettings");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineGameSettings>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OnFindOnlineGamesComplete;
    /// <summary>
    /// Function: OnFindOnlineGamesComplete
    /// </summary>
    public unsafe virtual void OnFindOnlineGamesComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFindOnlineGamesComplete, "IpDrv.OnlineGameInterfaceImpl.OnFindOnlineGamesComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: OwningSubsystem
    /// </summary>
    public unsafe BmSDK.IpDrv.OnlineSubsystemCommonImpl OwningSubsystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.OnlineSubsystemCommonImpl>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ObjectProperty: GameSettings
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSettings GameSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSettings>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ObjectProperty: GameSearch
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSearch GameSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSearch>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// ByteProperty: CurrentGameState
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineGameState CurrentGameState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineGameState>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ByteProperty: LanBeaconState
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.ELanBeaconState LanBeaconState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ELanBeaconState>(Ptr + 57); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 57); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: LanNonce
    /// </summary>
    public InlineArray<byte> LanNonce => new(8, Ptr + 58, 1, this);

    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 58); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 58); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 59); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 59); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 61); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 61); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 62); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 62); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 63); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 63); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 65); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 65); }
    }

    /// <summary>
    /// ArrayProperty: CreateOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> CreateOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// ArrayProperty: UpdateOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> UpdateOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// ArrayProperty: DestroyOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> DestroyOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: JoinOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> JoinOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: MigrateOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> MigrateOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: JoinMigratedOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> JoinMigratedOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ArrayProperty: RecalculateSkillRatingCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> RecalculateSkillRatingCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: StartOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> StartOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ArrayProperty: EndOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> EndOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: FindOnlineGamesCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FindOnlineGamesCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ArrayProperty: CancelFindOnlineGamesCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> CancelFindOnlineGamesCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// IntProperty: LanAnnouncePort
    /// </summary>
    public unsafe int LanAnnouncePort
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// IntProperty: LanGameUniqueId
    /// </summary>
    public unsafe int LanGameUniqueId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// IntProperty: LanPacketPlatformMask
    /// </summary>
    public unsafe int LanPacketPlatformMask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: LanQueryTimeLeft
    /// </summary>
    public unsafe float LanQueryTimeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// FloatProperty: LanQueryTimeout
    /// </summary>
    public unsafe float LanQueryTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// StructProperty: LanBeacon
    /// </summary>
    public unsafe System.IntPtr LanBeacon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// StructProperty: SessionInfo
    /// </summary>
    public unsafe System.IntPtr SessionInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// DelegateProperty: __OnFindOnlineGamesComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFindOnlineGamesComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// DelegateProperty: __OnCreateOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCreateOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// DelegateProperty: __OnUpdateOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnUpdateOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// DelegateProperty: __OnDestroyOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDestroyOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// DelegateProperty: __OnCancelFindOnlineGamesComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCancelFindOnlineGamesComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// DelegateProperty: __OnJoinOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnJoinOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// DelegateProperty: __OnRegisterPlayerComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRegisterPlayerComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// DelegateProperty: __OnUnregisterPlayerComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnUnregisterPlayerComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// DelegateProperty: __OnStartOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnStartOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// DelegateProperty: __OnEndOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnEndOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// DelegateProperty: __OnArbitrationRegistrationComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnArbitrationRegistrationComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// DelegateProperty: __OnGameInviteAccepted__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnGameInviteAccepted__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// DelegateProperty: __OnRecalculateSkillRatingComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRecalculateSkillRatingComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// DelegateProperty: __OnMigrateOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnMigrateOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// DelegateProperty: __OnJoinMigratedOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnJoinMigratedOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// DelegateProperty: __OnQosStatusChanged__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnQosStatusChanged__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }
}
