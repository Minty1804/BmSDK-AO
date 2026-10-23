#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MBMBehaviour_CombatMartialArtist<br/>
/// (size = 1120)
/// (flags = 8214)
/// </summary>
public partial class MBMBehaviour_CombatMartialArtist : BmSDK.BmGame.RBMBehaviour_CombatAI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MBMBehaviour_CombatMartialArtist", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MBMBehaviour_CombatMartialArtist.
    /// </summary>
    public static MBMBehaviour_CombatMartialArtist DefaultObject => (MBMBehaviour_CombatMartialArtist)StaticClass().DefaultObject;

    internal MBMBehaviour_CombatMartialArtist() { }

    /// <summary>
    /// Constructs a new MBMBehaviour_CombatMartialArtist
    /// </summary>
    public MBMBehaviour_CombatMartialArtist(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MBMBehaviour_CombatMartialArtist Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MBMBehaviour_CombatMartialArtist(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_CombatMartialArtist>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_CombatMartialArtist>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_CombatMartialArtist>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_CombatMartialArtist>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_CombatMartialArtist>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_CombatMartialArtist>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_CombatMartialArtist>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_CombatMartialArtist>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GetAttackPriorityOffset
    /// </summary>
    public unsafe override int GetAttackPriorityOffset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_CombatMartialArtist.GetAttackPriorityOffset", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: LaunchCounterAgainstBatmanAttack
    /// </summary>
    public unsafe virtual bool LaunchCounterAgainstBatmanAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_CombatMartialArtist.LaunchCounterAgainstBatmanAttack", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpawnVillainAttack
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCombatMove_VillainAttack SpawnVillainAttack(BmSDK.Class AttackClass)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_CombatMartialArtist.SpawnVillainAttack", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove_VillainAttack>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe override bool Update(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_CombatMartialArtist.Update", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: PlayTaunt
    /// </summary>
    public unsafe virtual void PlayTaunt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_CombatMartialArtist.PlayTaunt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe virtual bool SpawnSpecialAttack(BmSDK.BmGame.RPawnCombat PlayerPawn, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_CombatMartialArtist.SpawnSpecialAttack", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_CombatMartialArtist.OnActivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldUseEnvironment
    /// </summary>
    public unsafe override bool ShouldUseEnvironment(float DeltaTime, bool bForceCheck)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_CombatMartialArtist.ShouldUseEnvironment", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCheck, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetPossibleMoves
    /// </summary>
    public unsafe override void GetPossibleMoves(out BmSDK.TArray<BmSDK.Class> PossibleMoves)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_CombatMartialArtist.GetPossibleMoves", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PossibleMoves = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// IntProperty: ChanceToCounter
    /// </summary>
    public unsafe int ChanceToCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// IntProperty: ChanceToCounterBeatdown
    /// </summary>
    public unsafe int ChanceToCounterBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// IntProperty: ChanceToCounterDuringComboChain
    /// </summary>
    public unsafe int ChanceToCounterDuringComboChain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// IntProperty: PrevNoOfTimesBeforeCounter
    /// </summary>
    public unsafe int PrevNoOfTimesBeforeCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: MinAttacksBeforeCounter
    /// </summary>
    public InlineArray<int> MinAttacksBeforeCounter => new(3, Ptr + 836, 4, this);

    /// <summary>
    /// IntProperty: MinAttacksBeforeCounter
    /// </summary>
    public unsafe int MinAttacksBeforeCounter_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }
    /// <summary>
    /// IntProperty: MinAttacksBeforeCounter
    /// </summary>
    public unsafe int MinAttacksBeforeCounter_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }
    /// <summary>
    /// IntProperty: MinAttacksBeforeCounter
    /// </summary>
    public unsafe int MinAttacksBeforeCounter_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: ChanceToCounterPerDifficulty
    /// </summary>
    public InlineArray<int> ChanceToCounterPerDifficulty => new(3, Ptr + 848, 4, this);

    /// <summary>
    /// IntProperty: ChanceToCounterPerDifficulty
    /// </summary>
    public unsafe int ChanceToCounterPerDifficulty_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }
    /// <summary>
    /// IntProperty: ChanceToCounterPerDifficulty
    /// </summary>
    public unsafe int ChanceToCounterPerDifficulty_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }
    /// <summary>
    /// IntProperty: ChanceToCounterPerDifficulty
    /// </summary>
    public unsafe int ChanceToCounterPerDifficulty_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: IncChanceToCounterPerDifficultyByVal
    /// </summary>
    public InlineArray<int> IncChanceToCounterPerDifficultyByVal => new(3, Ptr + 860, 4, this);

    /// <summary>
    /// IntProperty: IncChanceToCounterPerDifficultyByVal
    /// </summary>
    public unsafe int IncChanceToCounterPerDifficultyByVal_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }
    /// <summary>
    /// IntProperty: IncChanceToCounterPerDifficultyByVal
    /// </summary>
    public unsafe int IncChanceToCounterPerDifficultyByVal_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }
    /// <summary>
    /// IntProperty: IncChanceToCounterPerDifficultyByVal
    /// </summary>
    public unsafe int IncChanceToCounterPerDifficultyByVal_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: ChanceToCounterBeatdownPerDifficulty
    /// </summary>
    public InlineArray<int> ChanceToCounterBeatdownPerDifficulty => new(3, Ptr + 872, 4, this);

    /// <summary>
    /// IntProperty: ChanceToCounterBeatdownPerDifficulty
    /// </summary>
    public unsafe int ChanceToCounterBeatdownPerDifficulty_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }
    /// <summary>
    /// IntProperty: ChanceToCounterBeatdownPerDifficulty
    /// </summary>
    public unsafe int ChanceToCounterBeatdownPerDifficulty_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }
    /// <summary>
    /// IntProperty: ChanceToCounterBeatdownPerDifficulty
    /// </summary>
    public unsafe int ChanceToCounterBeatdownPerDifficulty_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: IncChanceToCounterBeatdownPerDifficultyByVal
    /// </summary>
    public InlineArray<int> IncChanceToCounterBeatdownPerDifficultyByVal => new(3, Ptr + 884, 4, this);

    /// <summary>
    /// IntProperty: IncChanceToCounterBeatdownPerDifficultyByVal
    /// </summary>
    public unsafe int IncChanceToCounterBeatdownPerDifficultyByVal_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }
    /// <summary>
    /// IntProperty: IncChanceToCounterBeatdownPerDifficultyByVal
    /// </summary>
    public unsafe int IncChanceToCounterBeatdownPerDifficultyByVal_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }
    /// <summary>
    /// IntProperty: IncChanceToCounterBeatdownPerDifficultyByVal
    /// </summary>
    public unsafe int IncChanceToCounterBeatdownPerDifficultyByVal_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: ChanceToCounterDuringComboChainPerDifficulty
    /// </summary>
    public InlineArray<int> ChanceToCounterDuringComboChainPerDifficulty => new(3, Ptr + 896, 4, this);

    /// <summary>
    /// IntProperty: ChanceToCounterDuringComboChainPerDifficulty
    /// </summary>
    public unsafe int ChanceToCounterDuringComboChainPerDifficulty_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }
    /// <summary>
    /// IntProperty: ChanceToCounterDuringComboChainPerDifficulty
    /// </summary>
    public unsafe int ChanceToCounterDuringComboChainPerDifficulty_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }
    /// <summary>
    /// IntProperty: ChanceToCounterDuringComboChainPerDifficulty
    /// </summary>
    public unsafe int ChanceToCounterDuringComboChainPerDifficulty_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: IncChanceToCounterDuringComboChainPerDifficultyByVal
    /// </summary>
    public InlineArray<int> IncChanceToCounterDuringComboChainPerDifficultyByVal => new(3, Ptr + 908, 4, this);

    /// <summary>
    /// IntProperty: IncChanceToCounterDuringComboChainPerDifficultyByVal
    /// </summary>
    public unsafe int IncChanceToCounterDuringComboChainPerDifficultyByVal_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }
    /// <summary>
    /// IntProperty: IncChanceToCounterDuringComboChainPerDifficultyByVal
    /// </summary>
    public unsafe int IncChanceToCounterDuringComboChainPerDifficultyByVal_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }
    /// <summary>
    /// IntProperty: IncChanceToCounterDuringComboChainPerDifficultyByVal
    /// </summary>
    public unsafe int IncChanceToCounterDuringComboChainPerDifficultyByVal_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// FloatProperty: MinRangeForComboChainAttack
    /// </summary>
    public unsafe float MinRangeForComboChainAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// FloatProperty: MaxRangeForComboChainAttack
    /// </summary>
    public unsafe float MaxRangeForComboChainAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// FloatProperty: MinRangeForCloseAttack
    /// </summary>
    public unsafe float MinRangeForCloseAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// FloatProperty: MaxRangeForCloseAttack
    /// </summary>
    public unsafe float MaxRangeForCloseAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// IntProperty: ChanceOfComboChainAttack
    /// </summary>
    public unsafe int ChanceOfComboChainAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: IdealRangeFromBM
    /// </summary>
    public unsafe float IdealRangeFromBM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: UseMultiChainAsCloseAttack
    /// </summary>
    public unsafe bool UseMultiChainAsCloseAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bIsPlayingCycleBreaker
    /// </summary>
    public unsafe bool bIsPlayingCycleBreaker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bCanPlayCycleBreaker
    /// </summary>
    public unsafe bool bCanPlayCycleBreaker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// ArrayProperty: CounterFailAnimName_Back
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CounterFailAnimName_Back
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ArrayProperty: CounterFailAnimName_Front
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CounterFailAnimName_Front
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: CounterSuccessAnimName_Back
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CounterSuccessAnimName_Back
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ArrayProperty: CounterSuccessAnimName_Front
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CounterSuccessAnimName_Front
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ArrayProperty: CounterFailAnimName_Heavy_Back
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CounterFailAnimName_Heavy_Back
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ArrayProperty: CounterFailAnimName_Heavy_Front
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CounterFailAnimName_Heavy_Front
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ArrayProperty: CounterSuccessAnimName_Heavy_Back
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CounterSuccessAnimName_Heavy_Back
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// ArrayProperty: CounterSuccessAnimName_Heavy_Front
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CounterSuccessAnimName_Heavy_Front
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ArrayProperty: CycleBreakerAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CycleBreakerAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBeforeTaunt
    /// </summary>
    public unsafe float MinTimeBeforeTaunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: MaxTimeBeforeTaunt
    /// </summary>
    public unsafe float MaxTimeBeforeTaunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// IntProperty: ComboChainPriority
    /// </summary>
    public unsafe int ComboChainPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// IntProperty: PriorityIncrementor
    /// </summary>
    public unsafe int PriorityIncrementor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// IntProperty: TauntProbability
    /// </summary>
    public unsafe int TauntProbability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: CycleBreakerAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CycleBreakerAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// IntProperty: DifficultyLevel
    /// </summary>
    public unsafe int DifficultyLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: MartialArtist
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnVillainMartialArtist MartialArtist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnVillainMartialArtist>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: CombatTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat CombatTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// FloatProperty: TauntTimer
    /// </summary>
    public unsafe float TauntTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// StructProperty: TauntTransitionID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId TauntTransitionID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1096);

    /// <summary>
    /// IntProperty: CurrentComboChainPriority
    /// </summary>
    public unsafe int CurrentComboChainPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: BossBark_Mart1_Taunt
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBark_Mart1_Taunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ObjectProperty: BossBark_Mart2_Taunt
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBark_Mart2_Taunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ObjectProperty: BossBark_Mart3_Taunt
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBark_Mart3_Taunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ObjectProperty: BossBark_Mart4_Taunt
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBark_Mart4_Taunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }
}
