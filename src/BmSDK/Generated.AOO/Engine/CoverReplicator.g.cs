#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: CoverReplicator<br/>
/// (size = 476)
/// (flags = 8421394)
/// </summary>
public partial class CoverReplicator : BmSDK.Engine.ReplicationInfo, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.CoverReplicator", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as CoverReplicator.
    /// </summary>
    public static CoverReplicator DefaultObject => (CoverReplicator)StaticClass().DefaultObject;

    internal CoverReplicator() { }

    /// <summary>
    /// Constructs a new CoverReplicator
    /// </summary>
    public CoverReplicator(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected CoverReplicator(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CoverReplicator>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CoverReplicator>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CoverReplicator>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CoverReplicator>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CoverReplicator>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CoverReplicator>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CoverReplicator>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CoverReplicator>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ClientReceiveLinkDisabledState;
    /// <summary>
    /// Function: ClientReceiveLinkDisabledState
    /// </summary>
    public unsafe virtual void ClientReceiveLinkDisabledState(int Index, BmSDK.Engine.CoverLink Link, bool bLinkDisabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientReceiveLinkDisabledState, "Engine.CoverReplicator.ClientReceiveLinkDisabledState");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLinkDisabled, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSendLinkDisabledState;
    /// <summary>
    /// Function: ServerSendLinkDisabledState
    /// </summary>
    public unsafe virtual void ServerSendLinkDisabledState(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSendLinkDisabledState, "Engine.CoverReplicator.ServerSendLinkDisabledState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyLinkDisabledStateChange;
    /// <summary>
    /// Function: NotifyLinkDisabledStateChange
    /// </summary>
    public unsafe virtual void NotifyLinkDisabledStateChange(BmSDK.Engine.CoverLink Link)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyLinkDisabledStateChange, "Engine.CoverReplicator.NotifyLinkDisabledStateChange");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientReceiveManualCoverTypeSlots;
    /// <summary>
    /// Function: ClientReceiveManualCoverTypeSlots
    /// </summary>
    public unsafe virtual void ClientReceiveManualCoverTypeSlots(int Index, BmSDK.Engine.CoverLink Link, byte NumCoverTypesChanged, BmSDK.Engine.CoverReplicator.FManualCoverTypeInfo SlotsCoverTypeChanged, bool bDone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientReceiveManualCoverTypeSlots, "Engine.CoverReplicator.ClientReceiveManualCoverTypeSlots");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumCoverTypesChanged, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotsCoverTypeChanged, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDone, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSendManualCoverTypeSlots;
    /// <summary>
    /// Function: ServerSendManualCoverTypeSlots
    /// </summary>
    public unsafe virtual void ServerSendManualCoverTypeSlots(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSendManualCoverTypeSlots, "Engine.CoverReplicator.ServerSendManualCoverTypeSlots");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifySetManualCoverTypeForSlots;
    /// <summary>
    /// Function: NotifySetManualCoverTypeForSlots
    /// </summary>
    public unsafe virtual void NotifySetManualCoverTypeForSlots(BmSDK.Engine.CoverLink Link, in BmSDK.TArray<int> SlotIndices, BmSDK.Engine.CoverLink.ECoverType NewCoverType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifySetManualCoverTypeForSlots, "Engine.CoverReplicator.NotifySetManualCoverTypeForSlots");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotIndices, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCoverType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientReceiveAdjustedSlots;
    /// <summary>
    /// Function: ClientReceiveAdjustedSlots
    /// </summary>
    public unsafe virtual void ClientReceiveAdjustedSlots(int Index, BmSDK.Engine.CoverLink Link, byte NumSlotsAdjusted, byte SlotsAdjusted, bool bDone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientReceiveAdjustedSlots, "Engine.CoverReplicator.ClientReceiveAdjustedSlots");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSlotsAdjusted, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotsAdjusted, paramsPtr + 9);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDone, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSendAdjustedSlots;
    /// <summary>
    /// Function: ServerSendAdjustedSlots
    /// </summary>
    public unsafe virtual void ServerSendAdjustedSlots(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSendAdjustedSlots, "Engine.CoverReplicator.ServerSendAdjustedSlots");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyAutoAdjustSlots;
    /// <summary>
    /// Function: NotifyAutoAdjustSlots
    /// </summary>
    public unsafe virtual void NotifyAutoAdjustSlots(BmSDK.Engine.CoverLink Link, in BmSDK.TArray<int> SlotIndices)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyAutoAdjustSlots, "Engine.CoverReplicator.NotifyAutoAdjustSlots");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotIndices, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientReceiveDisabledSlots;
    /// <summary>
    /// Function: ClientReceiveDisabledSlots
    /// </summary>
    public unsafe virtual void ClientReceiveDisabledSlots(int Index, BmSDK.Engine.CoverLink Link, byte NumSlotsDisabled, byte SlotsDisabled, bool bDone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientReceiveDisabledSlots, "Engine.CoverReplicator.ClientReceiveDisabledSlots");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSlotsDisabled, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotsDisabled, paramsPtr + 9);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDone, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSendDisabledSlots;
    /// <summary>
    /// Function: ServerSendDisabledSlots
    /// </summary>
    public unsafe virtual void ServerSendDisabledSlots(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSendDisabledSlots, "Engine.CoverReplicator.ServerSendDisabledSlots");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyDisabledSlots;
    /// <summary>
    /// Function: NotifyDisabledSlots
    /// </summary>
    public unsafe virtual void NotifyDisabledSlots(BmSDK.Engine.CoverLink Link, in BmSDK.TArray<int> SlotIndices)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyDisabledSlots, "Engine.CoverReplicator.NotifyDisabledSlots");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotIndices, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientReceiveEnabledSlots;
    /// <summary>
    /// Function: ClientReceiveEnabledSlots
    /// </summary>
    public unsafe virtual void ClientReceiveEnabledSlots(int Index, BmSDK.Engine.CoverLink Link, byte NumSlotsEnabled, byte SlotsEnabled, bool bDone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientReceiveEnabledSlots, "Engine.CoverReplicator.ClientReceiveEnabledSlots");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSlotsEnabled, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotsEnabled, paramsPtr + 9);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDone, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSendEnabledSlots;
    /// <summary>
    /// Function: ServerSendEnabledSlots
    /// </summary>
    public unsafe virtual void ServerSendEnabledSlots(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSendEnabledSlots, "Engine.CoverReplicator.ServerSendEnabledSlots");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyEnabledSlots;
    /// <summary>
    /// Function: NotifyEnabledSlots
    /// </summary>
    public unsafe virtual void NotifyEnabledSlots(BmSDK.Engine.CoverLink Link, in BmSDK.TArray<int> SlotIndices)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyEnabledSlots, "Engine.CoverReplicator.NotifyEnabledSlots");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotIndices, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientReceiveInitialCoverReplicationInfo;
    /// <summary>
    /// Function: ClientReceiveInitialCoverReplicationInfo
    /// </summary>
    public unsafe virtual void ClientReceiveInitialCoverReplicationInfo(int Index, BmSDK.Engine.CoverLink Link, bool bLinkDisabled, byte NumSlotsEnabled, byte SlotsEnabled, byte NumSlotsDisabled, byte SlotsDisabled, byte NumSlotsAdjusted, byte SlotsAdjusted, byte NumCoverTypesChanged, BmSDK.Engine.CoverReplicator.FManualCoverTypeInfo SlotsCoverTypeChanged, bool bDone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientReceiveInitialCoverReplicationInfo, "Engine.CoverReplicator.ClientReceiveInitialCoverReplicationInfo");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLinkDisabled, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSlotsEnabled, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotsEnabled, paramsPtr + 13);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSlotsDisabled, paramsPtr + 21);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotsDisabled, paramsPtr + 22);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSlotsAdjusted, paramsPtr + 30);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotsAdjusted, paramsPtr + 31);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumCoverTypesChanged, paramsPtr + 39);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotsCoverTypeChanged, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDone, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSendInitialCoverReplicationInfo;
    /// <summary>
    /// Function: ServerSendInitialCoverReplicationInfo
    /// </summary>
    public unsafe virtual void ServerSendInitialCoverReplicationInfo(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSendInitialCoverReplicationInfo, "Engine.CoverReplicator.ServerSendInitialCoverReplicationInfo");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSetOwner;
    /// <summary>
    /// Function: ClientSetOwner
    /// </summary>
    public unsafe virtual void ClientSetOwner(BmSDK.Engine.PlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSetOwner, "Engine.CoverReplicator.ClientSetOwner");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplicateInitialCoverInfo;
    /// <summary>
    /// Function: ReplicateInitialCoverInfo
    /// </summary>
    public unsafe virtual void ReplicateInitialCoverInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicateInitialCoverInfo, "Engine.CoverReplicator.ReplicateInitialCoverInfo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PurgeOldEntries;
    /// <summary>
    /// Function: PurgeOldEntries
    /// </summary>
    public unsafe virtual void PurgeOldEntries()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PurgeOldEntries, "Engine.CoverReplicator.PurgeOldEntries");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: CoverReplicationData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.CoverReplicator.FCoverReplicationInfo> CoverReplicationData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.CoverReplicator.FCoverReplicationInfo>>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// Struct: FCoverReplicationInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FCoverReplicationInfo
    {
        /// <summary>
        /// ObjectProperty: Link
        /// </summary>
        public unsafe BmSDK.Engine.CoverLink Link
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CoverLink>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: SlotsEnabled
        /// </summary>
        public unsafe BmSDK.TArray<byte> SlotsEnabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: SlotsDisabled
        /// </summary>
        public unsafe BmSDK.TArray<byte> SlotsDisabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ArrayProperty: SlotsAdjusted
        /// </summary>
        public unsafe BmSDK.TArray<byte> SlotsAdjusted
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ArrayProperty: SlotsCoverTypeChanged
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.CoverReplicator.FManualCoverTypeInfo> SlotsCoverTypeChanged
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.CoverReplicator.FManualCoverTypeInfo>>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FManualCoverTypeInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FManualCoverTypeInfo
    {
        /// <summary>
        /// ByteProperty: SlotIndex
        /// </summary>
        public unsafe byte SlotIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: ManualCoverType
        /// </summary>
        public unsafe BmSDK.Engine.CoverLink.ECoverType ManualCoverType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CoverLink.ECoverType>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }
    }
}
