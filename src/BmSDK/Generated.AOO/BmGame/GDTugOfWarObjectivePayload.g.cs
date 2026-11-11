#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDTugOfWarObjectivePayload<br/>
/// (size = 696)
/// (flags = 8421906)
/// </summary>
public partial class GDTugOfWarObjectivePayload : BmSDK.Engine.SkeletalMeshActorMAT, BmSDK.BmGame.GDTugOfWarObjectiveHelperInterface, BmSDK.BmGame.GDDisruptableObjectiveHelperInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDTugOfWarObjectivePayload", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDTugOfWarObjectivePayload.
    /// </summary>
    public static GDTugOfWarObjectivePayload DefaultObject => (GDTugOfWarObjectivePayload)StaticClass().DefaultObject;

    internal GDTugOfWarObjectivePayload() { }

    /// <summary>
    /// Constructs a new GDTugOfWarObjectivePayload
    /// </summary>
    public GDTugOfWarObjectivePayload(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDTugOfWarObjectivePayload(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDTugOfWarObjectivePayload>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDTugOfWarObjectivePayload>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDTugOfWarObjectivePayload>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDTugOfWarObjectivePayload>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDTugOfWarObjectivePayload>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDTugOfWarObjectivePayload>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDTugOfWarObjectivePayload>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDTugOfWarObjectivePayload>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DrawDebugHUD;
    /// <summary>
    /// Function: DrawDebugHUD
    /// </summary>
    public unsafe virtual int DrawDebugHUD(BmSDK.SDEngine.SDWorldInfo SDWI, int X, int Y)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugHUD, "BmGame.GDTugOfWarObjectivePayload.DrawDebugHUD");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SDWI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetBaseLocationForTeam;
    /// <summary>
    /// Function: GetBaseLocationForTeam
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBaseLocationForTeam(BmSDK.BmGame.GDGIBase.ETeamType Type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBaseLocationForTeam, "BmGame.GDTugOfWarObjectivePayload.GetBaseLocationForTeam");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetMaxSpeedPercentage;
    /// <summary>
    /// Function: GetMaxSpeedPercentage
    /// </summary>
    public unsafe virtual float GetMaxSpeedPercentage(BmSDK.BmGame.GDTugOfWarObjectivePayload.EPayloadSpeedRating ForRating)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxSpeedPercentage, "BmGame.GDTugOfWarObjectivePayload.GetMaxSpeedPercentage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForRating, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasStateChanged;
    /// <summary>
    /// Function: HasStateChanged
    /// </summary>
    public unsafe virtual bool HasStateChanged(BmSDK.BmGame.GDTugOfWarObjectivePayload.FSTugOfWarPayloadState NewState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasStateChanged, "BmGame.GDTugOfWarObjectivePayload.HasStateChanged");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_UpdatePayloadState;
    /// <summary>
    /// Function: UpdatePayloadState
    /// </summary>
    public unsafe virtual void UpdatePayloadState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePayloadState, "BmGame.GDTugOfWarObjectivePayload.UpdatePayloadState");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetPayload;
    /// <summary>
    /// Function: ResetPayload
    /// </summary>
    public unsafe virtual void ResetPayload()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPayload, "BmGame.GDTugOfWarObjectivePayload.ResetPayload");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateProgress;
    /// <summary>
    /// Function: UpdateProgress
    /// </summary>
    public unsafe virtual float UpdateProgress()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateProgress, "BmGame.GDTugOfWarObjectivePayload.UpdateProgress");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ChangeDirection;
    /// <summary>
    /// Function: ChangeDirection
    /// </summary>
    public unsafe virtual void ChangeDirection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeDirection, "BmGame.GDTugOfWarObjectivePayload.ChangeDirection");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Stop;
    /// <summary>
    /// Function: Stop
    /// </summary>
    public unsafe virtual void Stop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Stop, "BmGame.GDTugOfWarObjectivePayload.Stop");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Play;
    /// <summary>
    /// Function: Play
    /// </summary>
    public unsafe virtual void Play()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Play, "BmGame.GDTugOfWarObjectivePayload.Play");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.GDTugOfWarObjectivePayload.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreBeginPlay;
    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe override void PreBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreBeginPlay, "BmGame.GDTugOfWarObjectivePayload.PreBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.GDTugOfWarObjectivePayload.Tick");
        byte* paramsPtr = stackalloc byte[30];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScramblerDestroyed;
    /// <summary>
    /// Function: ScramblerDestroyed
    /// </summary>
    public unsafe virtual void ScramblerDestroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScramblerDestroyed, "BmGame.GDTugOfWarObjectivePayload.ScramblerDestroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartScramble;
    /// <summary>
    /// Function: StartScramble
    /// </summary>
    public unsafe virtual void StartScramble(BmSDK.Engine.Actor Scrambler)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartScramble, "BmGame.GDTugOfWarObjectivePayload.StartScramble");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scrambler, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ObjectiveDisrupted;
    /// <summary>
    /// Function: ObjectiveDisrupted
    /// </summary>
    public unsafe virtual void ObjectiveDisrupted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObjectiveDisrupted, "BmGame.GDTugOfWarObjectivePayload.ObjectiveDisrupted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoScramblePulse;
    /// <summary>
    /// Function: DoScramblePulse
    /// </summary>
    public unsafe virtual void DoScramblePulse()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoScramblePulse, "BmGame.GDTugOfWarObjectivePayload.DoScramblePulse");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnObjectiveReset;
    /// <summary>
    /// Function: OnObjectiveReset
    /// </summary>
    public unsafe virtual void OnObjectiveReset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnObjectiveReset, "BmGame.GDTugOfWarObjectivePayload.OnObjectiveReset");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnObjectiveComplete;
    /// <summary>
    /// Function: OnObjectiveComplete
    /// </summary>
    public unsafe virtual void OnObjectiveComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnObjectiveComplete, "BmGame.GDTugOfWarObjectivePayload.OnObjectiveComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnObjectiveActivated;
    /// <summary>
    /// Function: OnObjectiveActivated
    /// </summary>
    public unsafe virtual void OnObjectiveActivated(BmSDK.BmGame.GDTugOfWarObjective ObjectiveOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnObjectiveActivated, "BmGame.GDTugOfWarObjectivePayload.OnObjectiveActivated");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectiveOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterObjectiveMatinee;
    /// <summary>
    /// Function: RegisterObjectiveMatinee
    /// </summary>
    public unsafe virtual void RegisterObjectiveMatinee(BmSDK.BmGame.GDSeqAct_ObjectiveInterp ObjectiveMatinee)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterObjectiveMatinee, "BmGame.GDTugOfWarObjectivePayload.RegisterObjectiveMatinee");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectiveMatinee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: PayloadAcceleration
    /// </summary>
    public unsafe float PayloadAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// StructProperty: SpeedRating0Data
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDTugOfWarObjectivePayload.FSPayloadSpeedRatingData SpeedRating0Data
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDTugOfWarObjectivePayload.FSPayloadSpeedRatingData>(Ptr + 548);

    /// <summary>
    /// StructProperty: SpeedRating1Data
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDTugOfWarObjectivePayload.FSPayloadSpeedRatingData SpeedRating1Data
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDTugOfWarObjectivePayload.FSPayloadSpeedRatingData>(Ptr + 556);

    /// <summary>
    /// StructProperty: SpeedRating2Data
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDTugOfWarObjectivePayload.FSPayloadSpeedRatingData SpeedRating2Data
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDTugOfWarObjectivePayload.FSPayloadSpeedRatingData>(Ptr + 564);

    /// <summary>
    /// StructProperty: SpeedRating3Data
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDTugOfWarObjectivePayload.FSPayloadSpeedRatingData SpeedRating3Data
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDTugOfWarObjectivePayload.FSPayloadSpeedRatingData>(Ptr + 572);

    /// <summary>
    /// ByteProperty: JokerTeamDirection
    /// </summary>
    public unsafe BmSDK.BmGame.GDTugOfWarObjectivePayload.EPayloadDirection JokerTeamDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDTugOfWarObjectivePayload.EPayloadDirection>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ByteProperty: BaneTeamDirection
    /// </summary>
    public unsafe BmSDK.BmGame.GDTugOfWarObjectivePayload.EPayloadDirection BaneTeamDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDTugOfWarObjectivePayload.EPayloadDirection>(Ptr + 581); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 581); }
    }

    /// <summary>
    /// ByteProperty: CurrentTravelDirection
    /// </summary>
    public unsafe BmSDK.BmGame.GDTugOfWarObjectivePayload.EPayloadDirection CurrentTravelDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDTugOfWarObjectivePayload.EPayloadDirection>(Ptr + 582); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 582); }
    }

    /// <summary>
    /// ObjectProperty: PositiveDirectionBase
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget PositiveDirectionBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ObjectProperty: NegativeDirectionBase
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget NegativeDirectionBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ComponentProperty: InfluenceHelper
    /// </summary>
    public unsafe BmSDK.BmGame.GDObjectiveInfluenceHelper InfluenceHelper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDObjectiveInfluenceHelper>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// FloatProperty: MaxHealth
    /// </summary>
    public unsafe float MaxHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// FloatProperty: HealthReductionPerHack
    /// </summary>
    public unsafe float HealthReductionPerHack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// FloatProperty: HealthReductionPerScramblerPulse
    /// </summary>
    public unsafe float HealthReductionPerScramblerPulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// StrProperty: UIIconName
    /// </summary>
    public unsafe BmSDK.FString UIIconName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ObjectProperty: MatineePath
    /// </summary>
    public unsafe BmSDK.SDEngine.SDSeqAct_ObjectiveInterp MatineePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDSeqAct_ObjectiveInterp>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: LastProgress
    /// </summary>
    public unsafe float LastProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// StructProperty: CurrentStateData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDTugOfWarObjectivePayload.FSTugOfWarPayloadState CurrentStateData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDTugOfWarObjectivePayload.FSTugOfWarPayloadState>(Ptr + 628);

    /// <summary>
    /// FloatProperty: CurrentSpeed
    /// </summary>
    public unsafe float CurrentSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// BoolProperty: bActive
    /// </summary>
    public unsafe bool bActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 656) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 656); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 656); }
    }

    /// <summary>
    /// BoolProperty: bPlaying
    /// </summary>
    public unsafe bool bPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 656) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 656); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 656); }
    }

    /// <summary>
    /// FloatProperty: JokerTeamProgress
    /// </summary>
    public unsafe float JokerTeamProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: BaneTeamProgress
    /// </summary>
    public unsafe float BaneTeamProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// FloatProperty: CurrentHealth
    /// </summary>
    public unsafe float CurrentHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// StructProperty: PositiveBaseLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositiveBaseLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 672);

    /// <summary>
    /// StructProperty: NegativeBaseLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 NegativeBaseLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 684);

    /// <summary>
    /// Struct: FSTugOfWarPayloadState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FSTugOfWarPayloadState
    {
        /// <summary>
        /// IntProperty: BaneGangCount
        /// </summary>
        public unsafe int BaneGangCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: JokerGangCount
        /// </summary>
        public unsafe int JokerGangCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: MajorityCount
        /// </summary>
        public unsafe int MajorityCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: MajorityTeam
        /// </summary>
        public unsafe BmSDK.BmGame.GDGIBase.ETeamType MajorityTeam
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGIBase.ETeamType>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bContested
        /// </summary>
        public unsafe bool bContested
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bUnattended
        /// </summary>
        public unsafe bool bUnattended
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: SpeedRating
        /// </summary>
        public unsafe BmSDK.BmGame.GDTugOfWarObjectivePayload.EPayloadSpeedRating SpeedRating
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDTugOfWarObjectivePayload.EPayloadSpeedRating>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FSPayloadSpeedRatingData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FSPayloadSpeedRatingData
    {
        /// <summary>
        /// ByteProperty: Rating
        /// </summary>
        public unsafe BmSDK.BmGame.GDTugOfWarObjectivePayload.EPayloadSpeedRating Rating
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDTugOfWarObjectivePayload.EPayloadSpeedRating>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: RatioOfMaxSpeed
        /// </summary>
        public unsafe float RatioOfMaxSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EPayloadDirection
    /// </summary>
    public enum EPayloadDirection : byte
    {
        EPayloadDirection_Unknown = 0,
        EPayloadDirection_Positive = 1,
        EPayloadDirection_Negative = 2,
        EPayloadDirection_MAX = 3,
    }

    /// <summary>
    /// Enum: EPayloadSpeedRating
    /// </summary>
    public enum EPayloadSpeedRating : byte
    {
        EPayloadSpeedRating_Unknown = 0,
        EPayloadSpeedRating_Level0 = 1,
        EPayloadSpeedRating_Level1 = 2,
        EPayloadSpeedRating_Level2 = 3,
        EPayloadSpeedRating_Level3 = 4,
        EPayloadSpeedRating_MAX = 5,
    }
}
