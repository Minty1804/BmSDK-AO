#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: PartyBeaconClient<br/>
/// (size = 216)
/// (flags = 134250646)
/// </summary>
public partial class PartyBeaconClient : BmSDK.IpDrv.PartyBeacon, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.PartyBeaconClient", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as PartyBeaconClient.
    /// </summary>
    public static PartyBeaconClient DefaultObject => (PartyBeaconClient)StaticClass().DefaultObject;

    internal PartyBeaconClient() { }

    /// <summary>
    /// Constructs a new PartyBeaconClient
    /// </summary>
    public PartyBeaconClient(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PartyBeaconClient Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PartyBeaconClient(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<PartyBeaconClient>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PartyBeaconClient>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<PartyBeaconClient>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PartyBeaconClient>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PartyBeaconClient>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PartyBeaconClient>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<PartyBeaconClient>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PartyBeaconClient>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DestroyBeacon;
    /// <summary>
    /// Function: DestroyBeacon
    /// </summary>
    public unsafe override void DestroyBeacon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyBeacon, "IpDrv.PartyBeaconClient.DestroyBeacon");
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

    private static BmSDK.Function __fn_CancelReservation;
    /// <summary>
    /// Function: CancelReservation
    /// </summary>
    public unsafe virtual bool CancelReservation(BmSDK.Engine.OnlineSubsystem.FUniqueNetId CancellingPartyLeader)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelReservation, "IpDrv.PartyBeaconClient.CancelReservation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CancellingPartyLeader, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RequestReservationUpdate;
    /// <summary>
    /// Function: RequestReservationUpdate
    /// </summary>
    public unsafe virtual bool RequestReservationUpdate(in BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult DesiredHost, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPartyLeader, in BmSDK.TArray<BmSDK.IpDrv.PartyBeacon.FPlayerReservation> PlayersToAdd)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestReservationUpdate, "IpDrv.PartyBeaconClient.RequestReservationUpdate");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredHost, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingPartyLeader, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayersToAdd, paramsPtr + 16);
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

    private static BmSDK.Function __fn_RequestReservation;
    /// <summary>
    /// Function: RequestReservation
    /// </summary>
    public unsafe virtual bool RequestReservation(in BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult DesiredHost, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPartyLeader, in BmSDK.TArray<BmSDK.IpDrv.PartyBeacon.FPlayerReservation> Players)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestReservation, "IpDrv.PartyBeaconClient.RequestReservation");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredHost, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingPartyLeader, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Players, paramsPtr + 16);
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

    private static BmSDK.Function __fn_OnHostHasCancelled;
    /// <summary>
    /// Function: OnHostHasCancelled
    /// </summary>
    public unsafe virtual void OnHostHasCancelled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnHostHasCancelled, "IpDrv.PartyBeaconClient.OnHostHasCancelled");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnHostIsReady;
    /// <summary>
    /// Function: OnHostIsReady
    /// </summary>
    public unsafe virtual void OnHostIsReady()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnHostIsReady, "IpDrv.PartyBeaconClient.OnHostIsReady");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnTravelRequestReceived;
    /// <summary>
    /// Function: OnTravelRequestReceived
    /// </summary>
    public unsafe virtual void OnTravelRequestReceived(BmSDK.FName SessionName, BmSDK.Class SearchClass, byte PlatformSpecificInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTravelRequestReceived, "IpDrv.PartyBeaconClient.OnTravelRequestReceived");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchClass, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformSpecificInfo, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReservationCountUpdated;
    /// <summary>
    /// Function: OnReservationCountUpdated
    /// </summary>
    public unsafe virtual void OnReservationCountUpdated(int ReservationRemaining)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReservationCountUpdated, "IpDrv.PartyBeaconClient.OnReservationCountUpdated");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReservationRemaining, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReservationRequestComplete;
    /// <summary>
    /// Function: OnReservationRequestComplete
    /// </summary>
    public unsafe virtual void OnReservationRequestComplete(BmSDK.IpDrv.PartyBeacon.EPartyReservationResult ReservationResult)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReservationRequestComplete, "IpDrv.PartyBeaconClient.OnReservationRequestComplete");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReservationResult, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EPartyBeaconClientRequest
    /// </summary>
    public enum EPartyBeaconClientRequest : byte
    {
        PBClientRequest_NewReservation = 0,
        PBClientRequest_UpdateReservation = 1,
        PBClientRequest_MAX = 2,
    }

    /// <summary>
    /// Enum: EPartyBeaconClientState
    /// </summary>
    public enum EPartyBeaconClientState : byte
    {
        PBCS_None = 0,
        PBCS_Connecting = 1,
        PBCS_Connected = 2,
        PBCS_ConnectionFailed = 3,
        PBCS_AwaitingResponse = 4,
        PBCS_Closed = 5,
        PBCS_MAX = 6,
    }

    /// <summary>
    /// StructProperty: HostPendingRequest
    /// </summary>
    public unsafe ref BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult HostPendingRequest
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult>(Ptr + 92);

    /// <summary>
    /// StructProperty: PendingRequest
    /// </summary>
    public unsafe ref BmSDK.IpDrv.PartyBeacon.FPartyReservation PendingRequest
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.IpDrv.PartyBeacon.FPartyReservation>(Ptr + 100);

    /// <summary>
    /// ByteProperty: ClientBeaconState
    /// </summary>
    public unsafe BmSDK.IpDrv.PartyBeaconClient.EPartyBeaconClientState ClientBeaconState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.PartyBeaconClient.EPartyBeaconClientState>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ByteProperty: ClientBeaconRequestType
    /// </summary>
    public unsafe BmSDK.IpDrv.PartyBeaconClient.EPartyBeaconClientRequest ClientBeaconRequestType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.PartyBeaconClient.EPartyBeaconClientRequest>(Ptr + 125); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 125); }
    }

    /// <summary>
    /// FloatProperty: ReservationRequestTimeout
    /// </summary>
    public unsafe float ReservationRequestTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: ReservationRequestElapsedTime
    /// </summary>
    public unsafe float ReservationRequestElapsedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StrProperty: ResolverClassName
    /// </summary>
    public unsafe BmSDK.FString ResolverClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ClassProperty: ResolverClass
    /// </summary>
    public unsafe BmSDK.Class ResolverClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: Resolver
    /// </summary>
    public unsafe BmSDK.IpDrv.ClientBeaconAddressResolver Resolver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.ClientBeaconAddressResolver>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// DelegateProperty: __OnReservationRequestComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReservationRequestComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// DelegateProperty: __OnReservationCountUpdated__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReservationCountUpdated__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// DelegateProperty: __OnTravelRequestReceived__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnTravelRequestReceived__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// DelegateProperty: __OnHostIsReady__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnHostIsReady__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// DelegateProperty: __OnHostHasCancelled__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnHostHasCancelled__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
}
