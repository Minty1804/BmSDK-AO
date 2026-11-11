#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDGameReplicationInfo_HunterHunted<br/>
/// (size = 2652)
/// (flags = 8421398)
/// </summary>
public partial class GDGameReplicationInfo_HunterHunted : BmSDK.BmGame.GDGameReplicationInfo_ControlPoints, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGameReplicationInfo_HunterHunted", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGameReplicationInfo_HunterHunted.
    /// </summary>
    public static GDGameReplicationInfo_HunterHunted DefaultObject => (GDGameReplicationInfo_HunterHunted)StaticClass().DefaultObject;

    internal GDGameReplicationInfo_HunterHunted() { }

    /// <summary>
    /// Constructs a new GDGameReplicationInfo_HunterHunted
    /// </summary>
    public GDGameReplicationInfo_HunterHunted(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGameReplicationInfo_HunterHunted(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_HunterHunted>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_HunterHunted>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_HunterHunted>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_HunterHunted>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_HunterHunted>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_HunterHunted>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_HunterHunted>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_HunterHunted>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetVisibleToHeroes;
    /// <summary>
    /// Function: GetVisibleToHeroes
    /// </summary>
    public unsafe virtual bool GetVisibleToHeroes(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVisibleToHeroes, "BmGame.GDGameReplicationInfo_HunterHunted.GetVisibleToHeroes");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetVisibleToHeroes;
    /// <summary>
    /// Function: SetVisibleToHeroes
    /// </summary>
    public unsafe virtual void SetVisibleToHeroes(int Index, bool bVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVisibleToHeroes, "BmGame.GDGameReplicationInfo_HunterHunted.SetVisibleToHeroes");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckControlPointStateChanges;
    /// <summary>
    /// Function: CheckControlPointStateChanges
    /// </summary>
    public unsafe virtual void CheckControlPointStateChanges()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckControlPointStateChanges, "BmGame.GDGameReplicationInfo_HunterHunted.CheckControlPointStateChanges");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldBarkUseSecondaryCommander;
    /// <summary>
    /// Function: ShouldBarkUseSecondaryCommander
    /// </summary>
    public unsafe override bool ShouldBarkUseSecondaryCommander(BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.BmGame.GDGIBase.ETeamType TeamType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldBarkUseSecondaryCommander, "BmGame.GDGameReplicationInfo_HunterHunted.ShouldBarkUseSecondaryCommander");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPresenceContext;
    /// <summary>
    /// Function: GetPresenceContext
    /// </summary>
    public unsafe override BmSDK.BmGame.RGameInfo.EMatchTypeContexts GetPresenceContext()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPresenceContext, "BmGame.GDGameReplicationInfo_HunterHunted.GetPresenceContext");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.EMatchTypeContexts>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.GDGameReplicationInfo_HunterHunted.Tick");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: SecondaryCommanderBarkProbability
    /// </summary>
    public unsafe float SecondaryCommanderBarkProbability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderControlPointActivating
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderControlPointActivating
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderControlPointActivated
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderControlPointActivated
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderControlPointCaptured
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderControlPointCaptured
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2524); }
    }

    /// <summary>
    /// ArrayProperty: BarkEventCommanderControlPointArguments
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BarkEventCommanderControlPointArguments
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// ObjectProperty: CPActivatedSting
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CPActivatedSting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// ObjectProperty: FinalCPActivatedSting
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FinalCPActivatedSting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// ObjectProperty: RoundEndingSting
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RoundEndingSting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// FloatProperty: FinalCPCaptureProgressForBarkTrigger
    /// </summary>
    public unsafe float FinalCPCaptureProgressForBarkTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// BoolProperty: bShowWinnerMessage
    /// </summary>
    public unsafe bool bShowWinnerMessage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2556) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2556); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2556); }
    }

    /// <summary>
    /// BoolProperty: bLastThugStandingStateTriggered
    /// </summary>
    public unsafe bool bLastThugStandingStateTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2556) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2556); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2556); }
    }

    /// <summary>
    /// BoolProperty: bLastTwoThugsStingPlayed
    /// </summary>
    public unsafe bool bLastTwoThugsStingPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2556) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2556); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2556); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: PreviousCPState
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.FSReplicatedCPData> PreviousCPState => new(3, Ptr + 2560, 24, this);

    /// <summary>
    /// StructProperty: PreviousCPState
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.FSReplicatedCPData PreviousCPState_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.FSReplicatedCPData>(Ptr + 2560);
    /// <summary>
    /// StructProperty: PreviousCPState
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.FSReplicatedCPData PreviousCPState_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.FSReplicatedCPData>(Ptr + 2584);
    /// <summary>
    /// StructProperty: PreviousCPState
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.FSReplicatedCPData PreviousCPState_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.FSReplicatedCPData>(Ptr + 2608);

    /// <summary>
    /// IntProperty: CapturedCPCount
    /// </summary>
    public unsafe int CapturedCPCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// IntProperty: ActivatedCPCount
    /// </summary>
    public unsafe int ActivatedCPCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// ArrayProperty: FinaleControlPointCaptureMessages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDGameReplicationInfo_HunterHunted.FSFinalControlPointCaptureMessage> FinaleControlPointCaptureMessages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDGameReplicationInfo_HunterHunted.FSFinalControlPointCaptureMessage>>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// Struct: FSFinalControlPointCaptureMessage
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSFinalControlPointCaptureMessage
    {
        /// <summary>
        /// FloatProperty: AtPercentage
        /// </summary>
        public unsafe float AtPercentage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: LocalisedString
        /// </summary>
        public unsafe BmSDK.FString LocalisedString
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
