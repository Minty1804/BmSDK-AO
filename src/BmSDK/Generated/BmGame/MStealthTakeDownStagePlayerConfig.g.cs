#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MStealthTakeDownStagePlayerConfig<br/>
/// (size = 232)
/// (flags = 134217874)
/// </summary>
public partial class MStealthTakeDownStagePlayerConfig : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MStealthTakeDownStagePlayerConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MStealthTakeDownStagePlayerConfig.
    /// </summary>
    public static MStealthTakeDownStagePlayerConfig DefaultObject => (MStealthTakeDownStagePlayerConfig)StaticClass().DefaultObject;

    internal MStealthTakeDownStagePlayerConfig() { }

    /// <summary>
    /// Constructs a new MStealthTakeDownStagePlayerConfig
    /// </summary>
    public MStealthTakeDownStagePlayerConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MStealthTakeDownStagePlayerConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MStealthTakeDownStagePlayerConfig(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStagePlayerConfig>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStagePlayerConfig>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStagePlayerConfig>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStagePlayerConfig>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStagePlayerConfig>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStagePlayerConfig>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStagePlayerConfig>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStealthTakeDownStagePlayerConfig>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: SpawnTakedown
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RStealthTakeDownStage SpawnTakedown(BmSDK.BmGame.RPlayerController Owner, BmSDK.BmGame.RPawnVillain Victim, BmSDK.BmGame.MStealthTakeDownStagePlayerConfig.EStealthTakeDownStages Stage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MStealthTakeDownStagePlayerConfig.SpawnTakedown", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Owner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stage, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SpawnTakedownArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage SpawnTakedownArchetype(BmSDK.BmGame.RPlayerController Owner, BmSDK.BmGame.MStealthTakeDownStagePlayerConfig.EStealthTakeDownStages Stage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MStealthTakeDownStagePlayerConfig.SpawnTakedownArchetype", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Owner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stage, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(paramsPtr + 8);
    }

    /// <summary>
    /// FloatProperty: StealthAttackTargetRadius
    /// </summary>
    public unsafe float StealthAttackTargetRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// FloatProperty: StunnedStealthAttackTargetRadius
    /// </summary>
    public unsafe float StunnedStealthAttackTargetRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bCanDoDoubleStealthAttacks
    /// </summary>
    public unsafe bool bCanDoDoubleStealthAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bDisableAllTakedowns
    /// </summary>
    public unsafe bool bDisableAllTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bCanDoEnvironmentStealthAttacks
    /// </summary>
    public unsafe bool bCanDoEnvironmentStealthAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentStealthAttackTargetMaxRadius
    /// </summary>
    public unsafe float EnvironmentStealthAttackTargetMaxRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentStealthAttackTargetMinRadius
    /// </summary>
    public unsafe float EnvironmentStealthAttackTargetMinRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentStealthAttackWeaponRadius
    /// </summary>
    public unsafe float EnvironmentStealthAttackWeaponRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// IntProperty: EnvironmentStealthAttackTargetMinAngle
    /// </summary>
    public unsafe int EnvironmentStealthAttackTargetMinAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: TakedownArchetype
    /// </summary>
    public InlineArray<BmSDK.GameObject> TakedownArchetype => new(40, Ptr + 72, 4, this);

    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
    /// <summary>
    /// ObjectProperty: TakedownArchetype
    /// </summary>
    public unsafe BmSDK.GameObject TakedownArchetype_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// Enum: EStealthTakeDownStages
    /// </summary>
    public enum EStealthTakeDownStages : byte
    {
        ESTDS_CornerGrab = 0,
        ESTDS_FallingTakeDown = 1,
        ESTDS_GlassAttack = 2,
        ESTDS_GrabFromCrouch2 = 3,
        ESTDS_GrabFromCrouchAware = 4,
        ESTDS_GrabFromHang = 5,
        ESTDS_GrabOnFloor = 6,
        ESTDS_LedgeAttack = 7,
        ESTDS_DoubleLedgeAttack = 8,
        ESTDS_RailingAttack = 9,
        ESTDS_SneakyCombatTakeDown = 10,
        ESTDS_ReverseChokeAttack = 11,
        ESTDS_DoubleHead = 12,
        ESTDS_FromAbove = 13,
        ESTDS_LineLauncherTakeDown = 14,
        ESTDS_CwInvertedFromCeilingGrab = 15,
        ESTDS_CwInvertedFromCeilingEnd = 16,
        ESTDS_CwInvertedFromCeilingSuccess = 17,
        ESTDS_FractureWallTakeDown = 18,
        ESTDS_CwPullFromCatwalk = 19,
        ESTDS_TunnelGrateGrab = 20,
        ESTDS_VentAttack = 21,
        ESTDS_BoostGlideTackle = 22,
        ESTDS_SuperGlideTakedown = 23,
        ESTDS_GrappleBoostTakedown = 24,
        ESTDS_LineLauncherAttack = 25,
        ESTDS_LongRangeLedgeTakedown = 26,
        ESTDS_LongRangeRailingTakedown = 27,
        ESTDS_StandingQuickTakedown = 28,
        ESTDS_HangingFearFinish = 29,
        ESTDS_GlassTakedownFinish = 30,
        ESTDS_ReverseChokeFinish = 31,
        ESTDS_TunnelGrateEnd = 32,
        ESTDS_Stunned = 33,
        ESTDS_Environment = 34,
        ESTDS_GlassBehindActor = 35,
        ESTDS_TightRopeTakedownStart = 36,
        ESTDS_TightRopeTakedownFinish = 37,
        ESTDS_ZipLineTakedownStart = 38,
        ESTDS_ZipLineTakedownFinish = 39,
        ESTDS_StealthTakeDownStageMAX = 40,
        ESTDS_MAX = 41,
    }
}
