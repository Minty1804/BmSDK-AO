#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDGameReplicationInfo_ControlPoints<br/>
/// (size = 2512)
/// (flags = 142639254)
/// </summary>
public partial class GDGameReplicationInfo_ControlPoints : BmSDK.BmGame.GDGameReplicationInfo, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGameReplicationInfo_ControlPoints", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGameReplicationInfo_ControlPoints.
    /// </summary>
    public static GDGameReplicationInfo_ControlPoints DefaultObject => (GDGameReplicationInfo_ControlPoints)StaticClass().DefaultObject;

    internal GDGameReplicationInfo_ControlPoints() { }

    /// <summary>
    /// Constructs a new GDGameReplicationInfo_ControlPoints
    /// </summary>
    public GDGameReplicationInfo_ControlPoints(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGameReplicationInfo_ControlPoints(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_ControlPoints>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_ControlPoints>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_ControlPoints>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_ControlPoints>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_ControlPoints>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_ControlPoints>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_ControlPoints>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_ControlPoints>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CheckTime;
    /// <summary>
    /// Function: CheckTime
    /// </summary>
    public unsafe virtual void CheckTime(int NewTime, int BarkTime, int BarkTimeIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckTime, "BmGame.GDGameReplicationInfo_ControlPoints.CheckTime");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkTimeIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckTimes;
    /// <summary>
    /// Function: CheckTimes
    /// </summary>
    public unsafe virtual void CheckTimes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckTimes, "BmGame.GDGameReplicationInfo_ControlPoints.CheckTimes");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWinningTeamName;
    /// <summary>
    /// Function: GetWinningTeamName
    /// </summary>
    public unsafe virtual BmSDK.FName GetWinningTeamName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWinningTeamName, "BmGame.GDGameReplicationInfo_ControlPoints.GetWinningTeamName");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckScore;
    /// <summary>
    /// Function: CheckScore
    /// </summary>
    public unsafe virtual void CheckScore(int OldScore, int NewScore, int TeamGoalScore, BmSDK.FName TeamName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckScore, "BmGame.GDGameReplicationInfo_ControlPoints.CheckScore");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldScore, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewScore, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamGoalScore, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckHeroScore;
    /// <summary>
    /// Function: CheckHeroScore
    /// </summary>
    public unsafe virtual void CheckHeroScore(int OldScore, int NewScore, int TeamGoalScore, BmSDK.FName TeamName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckHeroScore, "BmGame.GDGameReplicationInfo_ControlPoints.CheckHeroScore");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldScore, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewScore, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamGoalScore, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckScores;
    /// <summary>
    /// Function: CheckScores
    /// </summary>
    public unsafe virtual void CheckScores()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckScores, "BmGame.GDGameReplicationInfo_ControlPoints.CheckScores");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickBarks;
    /// <summary>
    /// Function: TickBarks
    /// </summary>
    public unsafe virtual void TickBarks(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickBarks, "BmGame.GDGameReplicationInfo_ControlPoints.TickBarks");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.GDGameReplicationInfo_ControlPoints.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnControlPointCaptured;
    /// <summary>
    /// Function: OnControlPointCaptured
    /// </summary>
    public unsafe virtual void OnControlPointCaptured(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnControlPointCaptured, "BmGame.GDGameReplicationInfo_ControlPoints.OnControlPointCaptured");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCaptureProgress;
    /// <summary>
    /// Function: SetCaptureProgress
    /// </summary>
    public unsafe virtual void SetCaptureProgress(int Index, BmSDK.BmGame.GDGIBase.ETeamType CapturingTeam, float Progress)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCaptureProgress, "BmGame.GDGameReplicationInfo_ControlPoints.SetCaptureProgress");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CapturingTeam, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Progress, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnControlPointNeutralised;
    /// <summary>
    /// Function: OnControlPointNeutralised
    /// </summary>
    public unsafe virtual void OnControlPointNeutralised(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnControlPointNeutralised, "BmGame.GDGameReplicationInfo_ControlPoints.OnControlPointNeutralised");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateControlPoint;
    /// <summary>
    /// Function: ActivateControlPoint
    /// </summary>
    public unsafe virtual void ActivateControlPoint(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateControlPoint, "BmGame.GDGameReplicationInfo_ControlPoints.ActivateControlPoint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetControlPointState;
    /// <summary>
    /// Function: SetControlPointState
    /// </summary>
    public unsafe virtual void SetControlPointState(int Index, BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.EControlPointState CPState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControlPointState, "BmGame.GDGameReplicationInfo_ControlPoints.SetControlPointState");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetControlPointInfluencingTeam;
    /// <summary>
    /// Function: SetControlPointInfluencingTeam
    /// </summary>
    public unsafe virtual void SetControlPointInfluencingTeam(int Index, BmSDK.BmGame.GDGIBase.ETeamType InfluencingTeam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControlPointInfluencingTeam, "BmGame.GDGameReplicationInfo_ControlPoints.SetControlPointInfluencingTeam");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfluencingTeam, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetControlPointContested;
    /// <summary>
    /// Function: SetControlPointContested
    /// </summary>
    public unsafe virtual void SetControlPointContested(int Index, bool bContested)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControlPointContested, "BmGame.GDGameReplicationInfo_ControlPoints.SetControlPointContested");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bContested, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterNewControlPoint;
    /// <summary>
    /// Function: RegisterNewControlPoint
    /// </summary>
    public unsafe virtual void RegisterNewControlPoint(out BmSDK.BmGame.GDObjectiveControlPoint Obj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterNewControlPoint, "BmGame.GDGameReplicationInfo_ControlPoints.RegisterNewControlPoint");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Obj);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Obj = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDObjectiveControlPoint>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.GDGameReplicationInfo_ControlPoints.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// InlineArray{StructProperty}: ControlPoints
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.FSReplicatedCPData> ControlPoints => new(3, Ptr + 2340, 24, this);

    /// <summary>
    /// StructProperty: ControlPoints
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.FSReplicatedCPData ControlPoints_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.FSReplicatedCPData>(Ptr + 2340);
    /// <summary>
    /// StructProperty: ControlPoints
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.FSReplicatedCPData ControlPoints_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.FSReplicatedCPData>(Ptr + 2364);
    /// <summary>
    /// StructProperty: ControlPoints
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.FSReplicatedCPData ControlPoints_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.FSReplicatedCPData>(Ptr + 2388);

    /// <summary>
    /// InlineArray{ObjectProperty}: ControlPointActors
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDObjectiveControlPoint> ControlPointActors => new(3, Ptr + 2412, 4, this);

    /// <summary>
    /// ObjectProperty: ControlPointActors
    /// </summary>
    public unsafe BmSDK.BmGame.GDObjectiveControlPoint ControlPointActors_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDObjectiveControlPoint>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }
    /// <summary>
    /// ObjectProperty: ControlPointActors
    /// </summary>
    public unsafe BmSDK.BmGame.GDObjectiveControlPoint ControlPointActors_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDObjectiveControlPoint>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }
    /// <summary>
    /// ObjectProperty: ControlPointActors
    /// </summary>
    public unsafe BmSDK.BmGame.GDObjectiveControlPoint ControlPointActors_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDObjectiveControlPoint>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// IntProperty: CurrentControlPointCount
    /// </summary>
    public unsafe int CurrentControlPointCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// BoolProperty: bCanRecapturePoints
    /// </summary>
    public unsafe bool bCanRecapturePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2428) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2428); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2428); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnScore
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// ArrayProperty: BarkScoresFraction
    /// </summary>
    public unsafe BmSDK.TArray<float> BarkScoresFraction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// ArrayProperty: BarkScoreArguments
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BarkScoreArguments
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// IntProperty: OldScoreHero
    /// </summary>
    public unsafe int OldScoreHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// IntProperty: OldScoreThug1
    /// </summary>
    public unsafe int OldScoreThug1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// IntProperty: OldScoreThug2
    /// </summary>
    public unsafe int OldScoreThug2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnTime
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// ArrayProperty: BarkTimesFraction
    /// </summary>
    public unsafe BmSDK.TArray<float> BarkTimesFraction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// IntProperty: BarkTimeBrink
    /// </summary>
    public unsafe int BarkTimeBrink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// ArrayProperty: BarkTimeArguments
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BarkTimeArguments
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// IntProperty: BarkScoreLeadToBeWinning
    /// </summary>
    public unsafe int BarkScoreLeadToBeWinning
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }

    /// <summary>
    /// IntProperty: OldTime
    /// </summary>
    public unsafe int OldTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2508); }
    }

    /// <summary>
    /// Struct: FSReplicatedCPData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FSReplicatedCPData
    {
        /// <summary>
        /// ByteProperty: State
        /// </summary>
        public unsafe BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.EControlPointState State
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.EControlPointState>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: CapturingTeam
        /// </summary>
        public unsafe BmSDK.BmGame.GDGIBase.ETeamType CapturingTeam
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGIBase.ETeamType>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// ByteProperty: InfluencingTeam
        /// </summary>
        public unsafe BmSDK.BmGame.GDGIBase.ETeamType InfluencingTeam
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGIBase.ETeamType>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }

        /// <summary>
        /// FloatProperty: CaptureProgress
        /// </summary>
        public unsafe float CaptureProgress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bContested
        /// </summary>
        public unsafe bool bContested
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bShowObjectiveMarkerHeroes
        /// </summary>
        public unsafe bool bShowObjectiveMarkerHeroes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Enum: EControlPointState
    /// </summary>
    public enum EControlPointState : byte
    {
        EControlPointState_Unknown = 0,
        EControlPointState_Inactive = 1,
        EControlPointState_Active = 2,
        EControlPointState_Capturing = 3,
        EControlPointState_Captured = 4,
        EControlPointState_MAX = 5,
    }
}
