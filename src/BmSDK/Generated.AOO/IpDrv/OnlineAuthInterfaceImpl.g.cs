#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: OnlineAuthInterfaceImpl<br/>
/// (size = 612)
/// (flags = 134250642)
/// </summary>
public partial class OnlineAuthInterfaceImpl : BmSDK.GameObject, BmSDK.Engine.OnlineAuthInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.OnlineAuthInterfaceImpl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as OnlineAuthInterfaceImpl.
    /// </summary>
    public static OnlineAuthInterfaceImpl DefaultObject => (OnlineAuthInterfaceImpl)StaticClass().DefaultObject;

    internal OnlineAuthInterfaceImpl() { }

    /// <summary>
    /// Constructs a new OnlineAuthInterfaceImpl
    /// </summary>
    public OnlineAuthInterfaceImpl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineAuthInterfaceImpl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineAuthInterfaceImpl(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineAuthInterfaceImpl>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineAuthInterfaceImpl>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineAuthInterfaceImpl>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineAuthInterfaceImpl>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineAuthInterfaceImpl>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineAuthInterfaceImpl>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<OnlineAuthInterfaceImpl>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<OnlineAuthInterfaceImpl>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetServerAddr;
    /// <summary>
    /// Function: GetServerAddr
    /// </summary>
    public unsafe virtual bool GetServerAddr(out int OutServerIP, out int OutServerPort)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetServerAddr, "IpDrv.OnlineAuthInterfaceImpl.GetServerAddr");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutServerIP);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutServerIP, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutServerPort);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutServerPort, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutServerIP = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        OutServerPort = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetServerUniqueId;
    /// <summary>
    /// Function: GetServerUniqueId
    /// </summary>
    public unsafe virtual bool GetServerUniqueId(out BmSDK.Engine.OnlineSubsystem.FUniqueNetId OutServerUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetServerUniqueId, "IpDrv.OnlineAuthInterfaceImpl.GetServerUniqueId");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutServerUID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutServerUID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutServerUID = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindLocalServerAuthSession;
    /// <summary>
    /// Function: FindLocalServerAuthSession
    /// </summary>
    public unsafe virtual bool FindLocalServerAuthSession(BmSDK.Engine.Player ClientConnection, out BmSDK.Engine.OnlineAuthInterface.FLocalAuthSession OutSessionInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindLocalServerAuthSession, "IpDrv.OnlineAuthInterfaceImpl.FindLocalServerAuthSession");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutSessionInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutSessionInfo, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutSessionInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineAuthInterface.FLocalAuthSession>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_FindServerAuthSession;
    /// <summary>
    /// Function: FindServerAuthSession
    /// </summary>
    public unsafe virtual bool FindServerAuthSession(BmSDK.Engine.Player ServerConnection, out BmSDK.Engine.OnlineAuthInterface.FAuthSession OutSessionInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindServerAuthSession, "IpDrv.OnlineAuthInterfaceImpl.FindServerAuthSession");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerConnection, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutSessionInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutSessionInfo, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutSessionInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineAuthInterface.FAuthSession>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_FindLocalClientAuthSession;
    /// <summary>
    /// Function: FindLocalClientAuthSession
    /// </summary>
    public unsafe virtual bool FindLocalClientAuthSession(BmSDK.Engine.Player ServerConnection, out BmSDK.Engine.OnlineAuthInterface.FLocalAuthSession OutSessionInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindLocalClientAuthSession, "IpDrv.OnlineAuthInterfaceImpl.FindLocalClientAuthSession");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerConnection, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutSessionInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutSessionInfo, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutSessionInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineAuthInterface.FLocalAuthSession>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_FindClientAuthSession;
    /// <summary>
    /// Function: FindClientAuthSession
    /// </summary>
    public unsafe virtual bool FindClientAuthSession(BmSDK.Engine.Player ClientConnection, out BmSDK.Engine.OnlineAuthInterface.FAuthSession OutSessionInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindClientAuthSession, "IpDrv.OnlineAuthInterfaceImpl.FindClientAuthSession");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutSessionInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutSessionInfo, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutSessionInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineAuthInterface.FAuthSession>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_EndAllRemoteServerAuthSessions;
    /// <summary>
    /// Function: EndAllRemoteServerAuthSessions
    /// </summary>
    public unsafe virtual void EndAllRemoteServerAuthSessions()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndAllRemoteServerAuthSessions, "IpDrv.OnlineAuthInterfaceImpl.EndAllRemoteServerAuthSessions");
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

    private static BmSDK.Function __fn_EndAllLocalServerAuthSessions;
    /// <summary>
    /// Function: EndAllLocalServerAuthSessions
    /// </summary>
    public unsafe virtual void EndAllLocalServerAuthSessions()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndAllLocalServerAuthSessions, "IpDrv.OnlineAuthInterfaceImpl.EndAllLocalServerAuthSessions");
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

    private static BmSDK.Function __fn_EndRemoteServerAuthSession;
    /// <summary>
    /// Function: EndRemoteServerAuthSession
    /// </summary>
    public unsafe virtual void EndRemoteServerAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndRemoteServerAuthSession, "IpDrv.OnlineAuthInterfaceImpl.EndRemoteServerAuthSession");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 8);
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

    private static BmSDK.Function __fn_EndLocalServerAuthSession;
    /// <summary>
    /// Function: EndLocalServerAuthSession
    /// </summary>
    public unsafe virtual void EndLocalServerAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndLocalServerAuthSession, "IpDrv.OnlineAuthInterfaceImpl.EndLocalServerAuthSession");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientIP, paramsPtr + 8);
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

    private static BmSDK.Function __fn_VerifyServerAuthSession;
    /// <summary>
    /// Function: VerifyServerAuthSession
    /// </summary>
    public unsafe virtual bool VerifyServerAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int AuthTicketUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VerifyServerAuthSession, "IpDrv.OnlineAuthInterfaceImpl.VerifyServerAuthSession");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthTicketUID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CreateServerAuthSession;
    /// <summary>
    /// Function: CreateServerAuthSession
    /// </summary>
    public unsafe virtual bool CreateServerAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP, int ClientPort, out int OutAuthTicketUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateServerAuthSession, "IpDrv.OnlineAuthInterfaceImpl.CreateServerAuthSession");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientPort, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutAuthTicketUID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutAuthTicketUID, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutAuthTicketUID = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_EndAllRemoteClientAuthSessions;
    /// <summary>
    /// Function: EndAllRemoteClientAuthSessions
    /// </summary>
    public unsafe virtual void EndAllRemoteClientAuthSessions()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndAllRemoteClientAuthSessions, "IpDrv.OnlineAuthInterfaceImpl.EndAllRemoteClientAuthSessions");
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

    private static BmSDK.Function __fn_EndAllLocalClientAuthSessions;
    /// <summary>
    /// Function: EndAllLocalClientAuthSessions
    /// </summary>
    public unsafe virtual void EndAllLocalClientAuthSessions()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndAllLocalClientAuthSessions, "IpDrv.OnlineAuthInterfaceImpl.EndAllLocalClientAuthSessions");
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

    private static BmSDK.Function __fn_EndRemoteClientAuthSession;
    /// <summary>
    /// Function: EndRemoteClientAuthSession
    /// </summary>
    public unsafe virtual void EndRemoteClientAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndRemoteClientAuthSession, "IpDrv.OnlineAuthInterfaceImpl.EndRemoteClientAuthSession");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientIP, paramsPtr + 8);
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

    private static BmSDK.Function __fn_EndLocalClientAuthSession;
    /// <summary>
    /// Function: EndLocalClientAuthSession
    /// </summary>
    public unsafe virtual void EndLocalClientAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int ServerPort)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndLocalClientAuthSession, "IpDrv.OnlineAuthInterfaceImpl.EndLocalClientAuthSession");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerPort, paramsPtr + 12);
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

    private static BmSDK.Function __fn_VerifyClientAuthSession;
    /// <summary>
    /// Function: VerifyClientAuthSession
    /// </summary>
    public unsafe virtual bool VerifyClientAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP, int ClientPort, int AuthTicketUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VerifyClientAuthSession, "IpDrv.OnlineAuthInterfaceImpl.VerifyClientAuthSession");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientPort, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthTicketUID, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_CreateClientAuthSession;
    /// <summary>
    /// Function: CreateClientAuthSession
    /// </summary>
    public unsafe virtual bool CreateClientAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int ServerPort, bool bSecure, out int OutAuthTicketUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateClientAuthSession, "IpDrv.OnlineAuthInterfaceImpl.CreateClientAuthSession");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerPort, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSecure, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutAuthTicketUID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutAuthTicketUID, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutAuthTicketUID = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_SendServerAuthRetryRequest;
    /// <summary>
    /// Function: SendServerAuthRetryRequest
    /// </summary>
    public unsafe virtual bool SendServerAuthRetryRequest()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendServerAuthRetryRequest, "IpDrv.OnlineAuthInterfaceImpl.SendServerAuthRetryRequest");
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

    private static BmSDK.Function __fn_SendClientAuthEndSessionRequest;
    /// <summary>
    /// Function: SendClientAuthEndSessionRequest
    /// </summary>
    public unsafe virtual bool SendClientAuthEndSessionRequest(BmSDK.Engine.Player ClientConnection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendClientAuthEndSessionRequest, "IpDrv.OnlineAuthInterfaceImpl.SendClientAuthEndSessionRequest");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SendServerAuthResponse;
    /// <summary>
    /// Function: SendServerAuthResponse
    /// </summary>
    public unsafe virtual bool SendServerAuthResponse(BmSDK.Engine.Player ClientConnection, int AuthTicketUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendServerAuthResponse, "IpDrv.OnlineAuthInterfaceImpl.SendServerAuthResponse");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthTicketUID, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SendClientAuthResponse;
    /// <summary>
    /// Function: SendClientAuthResponse
    /// </summary>
    public unsafe virtual bool SendClientAuthResponse(int AuthTicketUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendClientAuthResponse, "IpDrv.OnlineAuthInterfaceImpl.SendClientAuthResponse");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthTicketUID, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SendServerAuthRequest;
    /// <summary>
    /// Function: SendServerAuthRequest
    /// </summary>
    public unsafe virtual bool SendServerAuthRequest(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendServerAuthRequest, "IpDrv.OnlineAuthInterfaceImpl.SendServerAuthRequest");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SendClientAuthRequest;
    /// <summary>
    /// Function: SendClientAuthRequest
    /// </summary>
    public unsafe virtual bool SendClientAuthRequest(BmSDK.Engine.Player ClientConnection, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendClientAuthRequest, "IpDrv.OnlineAuthInterfaceImpl.SendClientAuthRequest");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearServerConnectionCloseDelegate;
    /// <summary>
    /// Function: ClearServerConnectionCloseDelegate
    /// </summary>
    public unsafe virtual void ClearServerConnectionCloseDelegate(System.IntPtr ServerConnectionCloseDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearServerConnectionCloseDelegate, "IpDrv.OnlineAuthInterfaceImpl.ClearServerConnectionCloseDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerConnectionCloseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddServerConnectionCloseDelegate;
    /// <summary>
    /// Function: AddServerConnectionCloseDelegate
    /// </summary>
    public unsafe virtual void AddServerConnectionCloseDelegate(System.IntPtr ServerConnectionCloseDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddServerConnectionCloseDelegate, "IpDrv.OnlineAuthInterfaceImpl.AddServerConnectionCloseDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerConnectionCloseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnServerConnectionClose;
    /// <summary>
    /// Function: OnServerConnectionClose
    /// </summary>
    public unsafe virtual void OnServerConnectionClose(BmSDK.Engine.Player ServerConnection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnServerConnectionClose, "IpDrv.OnlineAuthInterfaceImpl.OnServerConnectionClose");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerConnection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearClientConnectionCloseDelegate;
    /// <summary>
    /// Function: ClearClientConnectionCloseDelegate
    /// </summary>
    public unsafe virtual void ClearClientConnectionCloseDelegate(System.IntPtr ClientConnectionCloseDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearClientConnectionCloseDelegate, "IpDrv.OnlineAuthInterfaceImpl.ClearClientConnectionCloseDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnectionCloseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddClientConnectionCloseDelegate;
    /// <summary>
    /// Function: AddClientConnectionCloseDelegate
    /// </summary>
    public unsafe virtual void AddClientConnectionCloseDelegate(System.IntPtr ClientConnectionCloseDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddClientConnectionCloseDelegate, "IpDrv.OnlineAuthInterfaceImpl.AddClientConnectionCloseDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnectionCloseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClientConnectionClose;
    /// <summary>
    /// Function: OnClientConnectionClose
    /// </summary>
    public unsafe virtual void OnClientConnectionClose(BmSDK.Engine.Player ClientConnection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClientConnectionClose, "IpDrv.OnlineAuthInterfaceImpl.OnClientConnectionClose");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearServerAuthRetryRequestDelegate;
    /// <summary>
    /// Function: ClearServerAuthRetryRequestDelegate
    /// </summary>
    public unsafe virtual void ClearServerAuthRetryRequestDelegate(System.IntPtr ServerAuthRetryRequestDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearServerAuthRetryRequestDelegate, "IpDrv.OnlineAuthInterfaceImpl.ClearServerAuthRetryRequestDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthRetryRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddServerAuthRetryRequestDelegate;
    /// <summary>
    /// Function: AddServerAuthRetryRequestDelegate
    /// </summary>
    public unsafe virtual void AddServerAuthRetryRequestDelegate(System.IntPtr ServerAuthRetryRequestDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddServerAuthRetryRequestDelegate, "IpDrv.OnlineAuthInterfaceImpl.AddServerAuthRetryRequestDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthRetryRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnServerAuthRetryRequest;
    /// <summary>
    /// Function: OnServerAuthRetryRequest
    /// </summary>
    public unsafe virtual void OnServerAuthRetryRequest(BmSDK.Engine.Player ClientConnection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnServerAuthRetryRequest, "IpDrv.OnlineAuthInterfaceImpl.OnServerAuthRetryRequest");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearClientAuthEndSessionRequestDelegate;
    /// <summary>
    /// Function: ClearClientAuthEndSessionRequestDelegate
    /// </summary>
    public unsafe virtual void ClearClientAuthEndSessionRequestDelegate(System.IntPtr ClientAuthEndSessionRequestDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearClientAuthEndSessionRequestDelegate, "IpDrv.OnlineAuthInterfaceImpl.ClearClientAuthEndSessionRequestDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthEndSessionRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddClientAuthEndSessionRequestDelegate;
    /// <summary>
    /// Function: AddClientAuthEndSessionRequestDelegate
    /// </summary>
    public unsafe virtual void AddClientAuthEndSessionRequestDelegate(System.IntPtr ClientAuthEndSessionRequestDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddClientAuthEndSessionRequestDelegate, "IpDrv.OnlineAuthInterfaceImpl.AddClientAuthEndSessionRequestDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthEndSessionRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClientAuthEndSessionRequest;
    /// <summary>
    /// Function: OnClientAuthEndSessionRequest
    /// </summary>
    public unsafe virtual void OnClientAuthEndSessionRequest(BmSDK.Engine.Player ServerConnection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClientAuthEndSessionRequest, "IpDrv.OnlineAuthInterfaceImpl.OnClientAuthEndSessionRequest");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerConnection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearServerAuthCompleteDelegate;
    /// <summary>
    /// Function: ClearServerAuthCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearServerAuthCompleteDelegate(System.IntPtr ServerAuthCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearServerAuthCompleteDelegate, "IpDrv.OnlineAuthInterfaceImpl.ClearServerAuthCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddServerAuthCompleteDelegate;
    /// <summary>
    /// Function: AddServerAuthCompleteDelegate
    /// </summary>
    public unsafe virtual void AddServerAuthCompleteDelegate(System.IntPtr ServerAuthCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddServerAuthCompleteDelegate, "IpDrv.OnlineAuthInterfaceImpl.AddServerAuthCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnServerAuthComplete;
    /// <summary>
    /// Function: OnServerAuthComplete
    /// </summary>
    public unsafe virtual void OnServerAuthComplete(bool bSuccess, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, BmSDK.Engine.Player ServerConnection, BmSDK.FString ExtraInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnServerAuthComplete, "IpDrv.OnlineAuthInterfaceImpl.OnServerAuthComplete");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccess, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerConnection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraInfo, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearClientAuthCompleteDelegate;
    /// <summary>
    /// Function: ClearClientAuthCompleteDelegate
    /// </summary>
    public unsafe virtual void ClearClientAuthCompleteDelegate(System.IntPtr ClientAuthCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearClientAuthCompleteDelegate, "IpDrv.OnlineAuthInterfaceImpl.ClearClientAuthCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddClientAuthCompleteDelegate;
    /// <summary>
    /// Function: AddClientAuthCompleteDelegate
    /// </summary>
    public unsafe virtual void AddClientAuthCompleteDelegate(System.IntPtr ClientAuthCompleteDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddClientAuthCompleteDelegate, "IpDrv.OnlineAuthInterfaceImpl.AddClientAuthCompleteDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClientAuthComplete;
    /// <summary>
    /// Function: OnClientAuthComplete
    /// </summary>
    public unsafe virtual void OnClientAuthComplete(bool bSuccess, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, BmSDK.Engine.Player ClientConnection, BmSDK.FString ExtraInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClientAuthComplete, "IpDrv.OnlineAuthInterfaceImpl.OnClientAuthComplete");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccess, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraInfo, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearServerAuthResponseDelegate;
    /// <summary>
    /// Function: ClearServerAuthResponseDelegate
    /// </summary>
    public unsafe virtual void ClearServerAuthResponseDelegate(System.IntPtr ServerAuthResponseDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearServerAuthResponseDelegate, "IpDrv.OnlineAuthInterfaceImpl.ClearServerAuthResponseDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthResponseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddServerAuthResponseDelegate;
    /// <summary>
    /// Function: AddServerAuthResponseDelegate
    /// </summary>
    public unsafe virtual void AddServerAuthResponseDelegate(System.IntPtr ServerAuthResponseDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddServerAuthResponseDelegate, "IpDrv.OnlineAuthInterfaceImpl.AddServerAuthResponseDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthResponseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnServerAuthResponse;
    /// <summary>
    /// Function: OnServerAuthResponse
    /// </summary>
    public unsafe virtual void OnServerAuthResponse(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int AuthTicketUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnServerAuthResponse, "IpDrv.OnlineAuthInterfaceImpl.OnServerAuthResponse");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthTicketUID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearClientAuthResponseDelegate;
    /// <summary>
    /// Function: ClearClientAuthResponseDelegate
    /// </summary>
    public unsafe virtual void ClearClientAuthResponseDelegate(System.IntPtr ClientAuthResponseDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearClientAuthResponseDelegate, "IpDrv.OnlineAuthInterfaceImpl.ClearClientAuthResponseDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthResponseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddClientAuthResponseDelegate;
    /// <summary>
    /// Function: AddClientAuthResponseDelegate
    /// </summary>
    public unsafe virtual void AddClientAuthResponseDelegate(System.IntPtr ClientAuthResponseDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddClientAuthResponseDelegate, "IpDrv.OnlineAuthInterfaceImpl.AddClientAuthResponseDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthResponseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClientAuthResponse;
    /// <summary>
    /// Function: OnClientAuthResponse
    /// </summary>
    public unsafe virtual void OnClientAuthResponse(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP, int AuthTicketUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClientAuthResponse, "IpDrv.OnlineAuthInterfaceImpl.OnClientAuthResponse");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthTicketUID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearServerAuthRequestDelegate;
    /// <summary>
    /// Function: ClearServerAuthRequestDelegate
    /// </summary>
    public unsafe virtual void ClearServerAuthRequestDelegate(System.IntPtr ServerAuthRequestDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearServerAuthRequestDelegate, "IpDrv.OnlineAuthInterfaceImpl.ClearServerAuthRequestDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddServerAuthRequestDelegate;
    /// <summary>
    /// Function: AddServerAuthRequestDelegate
    /// </summary>
    public unsafe virtual void AddServerAuthRequestDelegate(System.IntPtr ServerAuthRequestDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddServerAuthRequestDelegate, "IpDrv.OnlineAuthInterfaceImpl.AddServerAuthRequestDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnServerAuthRequest;
    /// <summary>
    /// Function: OnServerAuthRequest
    /// </summary>
    public unsafe virtual void OnServerAuthRequest(BmSDK.Engine.Player ClientConnection, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP, int ClientPort)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnServerAuthRequest, "IpDrv.OnlineAuthInterfaceImpl.OnServerAuthRequest");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientIP, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientPort, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearClientAuthRequestDelegate;
    /// <summary>
    /// Function: ClearClientAuthRequestDelegate
    /// </summary>
    public unsafe virtual void ClearClientAuthRequestDelegate(System.IntPtr ClientAuthRequestDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearClientAuthRequestDelegate, "IpDrv.OnlineAuthInterfaceImpl.ClearClientAuthRequestDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddClientAuthRequestDelegate;
    /// <summary>
    /// Function: AddClientAuthRequestDelegate
    /// </summary>
    public unsafe virtual void AddClientAuthRequestDelegate(System.IntPtr ClientAuthRequestDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddClientAuthRequestDelegate, "IpDrv.OnlineAuthInterfaceImpl.AddClientAuthRequestDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClientAuthRequest;
    /// <summary>
    /// Function: OnClientAuthRequest
    /// </summary>
    public unsafe virtual void OnClientAuthRequest(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int ServerPort, bool bSecure)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClientAuthRequest, "IpDrv.OnlineAuthInterfaceImpl.OnClientAuthRequest");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerPort, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSecure, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAuthReadyDelegate;
    /// <summary>
    /// Function: ClearAuthReadyDelegate
    /// </summary>
    public unsafe virtual void ClearAuthReadyDelegate(System.IntPtr AuthReadyDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAuthReadyDelegate, "IpDrv.OnlineAuthInterfaceImpl.ClearAuthReadyDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthReadyDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddAuthReadyDelegate;
    /// <summary>
    /// Function: AddAuthReadyDelegate
    /// </summary>
    public unsafe virtual void AddAuthReadyDelegate(System.IntPtr AuthReadyDelegate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddAuthReadyDelegate, "IpDrv.OnlineAuthInterfaceImpl.AddAuthReadyDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthReadyDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAuthReady;
    /// <summary>
    /// Function: OnAuthReady
    /// </summary>
    public unsafe virtual void OnAuthReady()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAuthReady, "IpDrv.OnlineAuthInterfaceImpl.OnAuthReady");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsReady;
    /// <summary>
    /// Function: IsReady
    /// </summary>
    public unsafe virtual bool IsReady()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsReady, "IpDrv.OnlineAuthInterfaceImpl.IsReady");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// StructProperty: VfTable_IOnlineAuthInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IOnlineAuthInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ObjectProperty: OwningSubsystem
    /// </summary>
    public unsafe BmSDK.IpDrv.OnlineSubsystemCommonImpl OwningSubsystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.OnlineSubsystemCommonImpl>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bAuthReady
    /// </summary>
    public unsafe bool bAuthReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// StructProperty: ClientAuthSessions
    /// </summary>
    public unsafe ref BmSDK.GameObject.FSparseArray_Mirror ClientAuthSessions
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FSparseArray_Mirror>(Ptr + 60);

    /// <summary>
    /// StructProperty: ServerAuthSessions
    /// </summary>
    public unsafe ref BmSDK.GameObject.FSparseArray_Mirror ServerAuthSessions
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FSparseArray_Mirror>(Ptr + 108);

    /// <summary>
    /// StructProperty: PeerAuthSessions
    /// </summary>
    public unsafe ref BmSDK.GameObject.FSparseArray_Mirror PeerAuthSessions
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FSparseArray_Mirror>(Ptr + 156);

    /// <summary>
    /// StructProperty: LocalClientAuthSessions
    /// </summary>
    public unsafe ref BmSDK.GameObject.FSparseArray_Mirror LocalClientAuthSessions
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FSparseArray_Mirror>(Ptr + 204);

    /// <summary>
    /// StructProperty: LocalServerAuthSessions
    /// </summary>
    public unsafe ref BmSDK.GameObject.FSparseArray_Mirror LocalServerAuthSessions
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FSparseArray_Mirror>(Ptr + 252);

    /// <summary>
    /// StructProperty: LocalPeerAuthSessions
    /// </summary>
    public unsafe ref BmSDK.GameObject.FSparseArray_Mirror LocalPeerAuthSessions
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FSparseArray_Mirror>(Ptr + 300);

    /// <summary>
    /// ArrayProperty: AuthReadyDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> AuthReadyDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ArrayProperty: ClientAuthRequestDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ClientAuthRequestDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ArrayProperty: ServerAuthRequestDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ServerAuthRequestDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// ArrayProperty: ClientAuthResponseDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ClientAuthResponseDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ArrayProperty: ServerAuthResponseDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ServerAuthResponseDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ArrayProperty: ClientAuthCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ClientAuthCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ArrayProperty: ServerAuthCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ServerAuthCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ArrayProperty: ClientAuthEndSessionRequestDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ClientAuthEndSessionRequestDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ArrayProperty: ServerAuthRetryRequestDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ServerAuthRetryRequestDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ArrayProperty: ClientConnectionCloseDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ClientConnectionCloseDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ArrayProperty: ServerConnectionCloseDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ServerConnectionCloseDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// DelegateProperty: __OnAuthReady__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnAuthReady__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// DelegateProperty: __OnClientAuthRequest__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnClientAuthRequest__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// DelegateProperty: __OnServerAuthRequest__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnServerAuthRequest__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// DelegateProperty: __OnClientAuthResponse__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnClientAuthResponse__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// DelegateProperty: __OnServerAuthResponse__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnServerAuthResponse__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// DelegateProperty: __OnClientAuthComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnClientAuthComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// DelegateProperty: __OnServerAuthComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnServerAuthComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// DelegateProperty: __OnClientAuthEndSessionRequest__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnClientAuthEndSessionRequest__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// DelegateProperty: __OnServerAuthRetryRequest__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnServerAuthRetryRequest__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// DelegateProperty: __OnClientConnectionClose__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnClientConnectionClose__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// DelegateProperty: __OnServerConnectionClose__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnServerConnectionClose__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }
}
