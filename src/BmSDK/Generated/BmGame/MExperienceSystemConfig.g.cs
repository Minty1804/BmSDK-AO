#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MExperienceSystemConfig<br/>
/// (size = 464)
/// (flags = 134217874)
/// </summary>
public partial class MExperienceSystemConfig : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MExperienceSystemConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MExperienceSystemConfig.
    /// </summary>
    public static MExperienceSystemConfig DefaultObject => (MExperienceSystemConfig)StaticClass().DefaultObject;

    internal MExperienceSystemConfig() { }

    /// <summary>
    /// Constructs a new MExperienceSystemConfig
    /// </summary>
    public MExperienceSystemConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MExperienceSystemConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MExperienceSystemConfig(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MExperienceSystemConfig>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MExperienceSystemConfig>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MExperienceSystemConfig>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MExperienceSystemConfig>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MExperienceSystemConfig>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MExperienceSystemConfig>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MExperienceSystemConfig>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MExperienceSystemConfig>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GetFFCWeaponTypeXP
    /// </summary>
    public unsafe virtual int GetFFCWeaponTypeXP(BmSDK.BmGame.RGameInfo.FreeFlowCombatModifierType ffcweaponType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MExperienceSystemConfig.GetFFCWeaponTypeXP", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ffcweaponType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetGadgetUsageXP
    /// </summary>
    public unsafe virtual int GetGadgetUsageXP(BmSDK.BmGame.RGameInfo.EPredGadgetBonusType GadgetType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MExperienceSystemConfig.GetGadgetUsageXP", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetEnemyTypeXP
    /// </summary>
    public unsafe virtual int GetEnemyTypeXP(BmSDK.BmGame.RGameInfo.ECombatPawnType EnemyType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MExperienceSystemConfig.GetEnemyTypeXP", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnemyType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: InitXPValue
    /// </summary>
    public unsafe virtual void InitXPValue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MExperienceSystemConfig.InitXPValue", true);
        byte* paramsPtr = stackalloc byte[0];
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

    /// <summary>
    /// Struct: FVariationBonus
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FVariationBonus
    {
        /// <summary>
        /// IntProperty: MaxVariationCount
        /// </summary>
        public unsafe int MaxVariationCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: XPValue
        /// </summary>
        public unsafe int XPValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FExperienceLevel
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FExperienceLevel
    {
        /// <summary>
        /// IntProperty: XPNeededToLevel
        /// </summary>
        public unsafe int XPNeededToLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: TotalXPNeeded
        /// </summary>
        public unsafe int TotalXPNeeded
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FCombatGradeRange
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FCombatGradeRange
    {
        /// <summary>
        /// StrProperty: GradeLevel
        /// </summary>
        public unsafe BmSDK.FString GradeLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: GradeName
        /// </summary>
        public unsafe BmSDK.FString GradeName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: GradePointMin
        /// </summary>
        public unsafe int GradePointMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: GradePointMax
        /// </summary>
        public unsafe int GradePointMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: PercentXPBonus
        /// </summary>
        public unsafe float PercentXPBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FCombatEfficiencyRange
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FCombatEfficiencyRange
    {
        /// <summary>
        /// IntProperty: BetweenMin
        /// </summary>
        public unsafe int BetweenMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: BetweenMax
        /// </summary>
        public unsafe int BetweenMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: GradePoint
        /// </summary>
        public unsafe int GradePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FThreatLevelRange
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FThreatLevelRange
    {
        /// <summary>
        /// IntProperty: ThreatLevelMin
        /// </summary>
        public unsafe int ThreatLevelMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ThreatLevelMax
        /// </summary>
        public unsafe int ThreatLevelMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: ThreatLevelName
        /// </summary>
        public unsafe BmSDK.FString ThreatLevelName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: PlayerActionXPValue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FGameActionXPValue> PlayerActionXPValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FGameActionXPValue>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ArrayProperty: EnemyXPValue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FPawnXPValue> EnemyXPValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FPawnXPValue>>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ArrayProperty: FreeFlowCombatModifierXPValue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatModifierXPValue> FreeFlowCombatModifierXPValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatModifierXPValue>>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// ArrayProperty: GadgetUsageXPValue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FPredGadgetUsageXPValue> GadgetUsageXPValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FPredGadgetUsageXPValue>>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// IntProperty: PredatorTannoyThreatXP
    /// </summary>
    public unsafe int PredatorTannoyThreatXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// IntProperty: PredatorSpecialBonusUndetected
    /// </summary>
    public unsafe int PredatorSpecialBonusUndetected
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: MaxComboMultiplier
    /// </summary>
    public unsafe float MaxComboMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: CriticalHitMultiplier
    /// </summary>
    public unsafe float CriticalHitMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: UniqueQuickfireMultiplier
    /// </summary>
    public unsafe float UniqueQuickfireMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: GroundTakedownMultiplier
    /// </summary>
    public unsafe float GroundTakedownMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: AlfredBonusInteractLimitPerEpisode
    /// </summary>
    public InlineArray<int> AlfredBonusInteractLimitPerEpisode => new(10, Ptr + 116, 4, this);

    /// <summary>
    /// IntProperty: AlfredBonusInteractLimitPerEpisode
    /// </summary>
    public unsafe int AlfredBonusInteractLimitPerEpisode_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusInteractLimitPerEpisode
    /// </summary>
    public unsafe int AlfredBonusInteractLimitPerEpisode_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusInteractLimitPerEpisode
    /// </summary>
    public unsafe int AlfredBonusInteractLimitPerEpisode_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusInteractLimitPerEpisode
    /// </summary>
    public unsafe int AlfredBonusInteractLimitPerEpisode_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusInteractLimitPerEpisode
    /// </summary>
    public unsafe int AlfredBonusInteractLimitPerEpisode_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusInteractLimitPerEpisode
    /// </summary>
    public unsafe int AlfredBonusInteractLimitPerEpisode_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusInteractLimitPerEpisode
    /// </summary>
    public unsafe int AlfredBonusInteractLimitPerEpisode_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusInteractLimitPerEpisode
    /// </summary>
    public unsafe int AlfredBonusInteractLimitPerEpisode_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusInteractLimitPerEpisode
    /// </summary>
    public unsafe int AlfredBonusInteractLimitPerEpisode_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusInteractLimitPerEpisode
    /// </summary>
    public unsafe int AlfredBonusInteractLimitPerEpisode_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: AlfredBonusScorePerEpisode
    /// </summary>
    public InlineArray<int> AlfredBonusScorePerEpisode => new(10, Ptr + 156, 4, this);

    /// <summary>
    /// IntProperty: AlfredBonusScorePerEpisode
    /// </summary>
    public unsafe int AlfredBonusScorePerEpisode_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusScorePerEpisode
    /// </summary>
    public unsafe int AlfredBonusScorePerEpisode_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusScorePerEpisode
    /// </summary>
    public unsafe int AlfredBonusScorePerEpisode_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusScorePerEpisode
    /// </summary>
    public unsafe int AlfredBonusScorePerEpisode_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusScorePerEpisode
    /// </summary>
    public unsafe int AlfredBonusScorePerEpisode_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusScorePerEpisode
    /// </summary>
    public unsafe int AlfredBonusScorePerEpisode_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusScorePerEpisode
    /// </summary>
    public unsafe int AlfredBonusScorePerEpisode_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusScorePerEpisode
    /// </summary>
    public unsafe int AlfredBonusScorePerEpisode_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusScorePerEpisode
    /// </summary>
    public unsafe int AlfredBonusScorePerEpisode_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }
    /// <summary>
    /// IntProperty: AlfredBonusScorePerEpisode
    /// </summary>
    public unsafe int AlfredBonusScorePerEpisode_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: AlfredBonusTimeLimitInMinutesPerEpisode
    /// </summary>
    public InlineArray<float> AlfredBonusTimeLimitInMinutesPerEpisode => new(10, Ptr + 196, 4, this);

    /// <summary>
    /// FloatProperty: AlfredBonusTimeLimitInMinutesPerEpisode
    /// </summary>
    public unsafe float AlfredBonusTimeLimitInMinutesPerEpisode_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }
    /// <summary>
    /// FloatProperty: AlfredBonusTimeLimitInMinutesPerEpisode
    /// </summary>
    public unsafe float AlfredBonusTimeLimitInMinutesPerEpisode_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }
    /// <summary>
    /// FloatProperty: AlfredBonusTimeLimitInMinutesPerEpisode
    /// </summary>
    public unsafe float AlfredBonusTimeLimitInMinutesPerEpisode_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
    /// <summary>
    /// FloatProperty: AlfredBonusTimeLimitInMinutesPerEpisode
    /// </summary>
    public unsafe float AlfredBonusTimeLimitInMinutesPerEpisode_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }
    /// <summary>
    /// FloatProperty: AlfredBonusTimeLimitInMinutesPerEpisode
    /// </summary>
    public unsafe float AlfredBonusTimeLimitInMinutesPerEpisode_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }
    /// <summary>
    /// FloatProperty: AlfredBonusTimeLimitInMinutesPerEpisode
    /// </summary>
    public unsafe float AlfredBonusTimeLimitInMinutesPerEpisode_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
    /// <summary>
    /// FloatProperty: AlfredBonusTimeLimitInMinutesPerEpisode
    /// </summary>
    public unsafe float AlfredBonusTimeLimitInMinutesPerEpisode_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }
    /// <summary>
    /// FloatProperty: AlfredBonusTimeLimitInMinutesPerEpisode
    /// </summary>
    public unsafe float AlfredBonusTimeLimitInMinutesPerEpisode_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
    /// <summary>
    /// FloatProperty: AlfredBonusTimeLimitInMinutesPerEpisode
    /// </summary>
    public unsafe float AlfredBonusTimeLimitInMinutesPerEpisode_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }
    /// <summary>
    /// FloatProperty: AlfredBonusTimeLimitInMinutesPerEpisode
    /// </summary>
    public unsafe float AlfredBonusTimeLimitInMinutesPerEpisode_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// IntProperty: AlfredBonusInteractAchievementCount
    /// </summary>
    public unsafe int AlfredBonusInteractAchievementCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// IntProperty: MaxPlayerLevel
    /// </summary>
    public unsafe int MaxPlayerLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// ArrayProperty: FFCThreatLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FThreatLevelRange> FFCThreatLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FThreatLevelRange>>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ArrayProperty: PredatorThreatLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FThreatLevelRange> PredatorThreatLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FThreatLevelRange>>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// ArrayProperty: CombatEfficiency
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatEfficiencyRange> CombatEfficiency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatEfficiencyRange>>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ArrayProperty: PredatorFurtivity
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatEfficiencyRange> PredatorFurtivity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatEfficiencyRange>>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ArrayProperty: CombatPerformance
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatEfficiencyRange> CombatPerformance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatEfficiencyRange>>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ArrayProperty: HitBonusFFC
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatEfficiencyRange> HitBonusFFC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatEfficiencyRange>>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// ArrayProperty: HitBonusPredator
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatEfficiencyRange> HitBonusPredator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatEfficiencyRange>>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// ArrayProperty: TakedownVariationGrade
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatEfficiencyRange> TakedownVariationGrade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatEfficiencyRange>>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// ArrayProperty: CombatGrades
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatGradeRange> CombatGrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatGradeRange>>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// ArrayProperty: CombatGradesPredator
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatGradeRange> CombatGradesPredator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatGradeRange>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: ComboMultiplierThug
    /// </summary>
    public unsafe int ComboMultiplierThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// IntProperty: ComboMultiplierArmoredThug
    /// </summary>
    public unsafe int ComboMultiplierArmoredThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// IntProperty: ComboMultiplierLieutenant
    /// </summary>
    public unsafe int ComboMultiplierLieutenant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// IntProperty: ComboMultiplierArmoredLieutenant
    /// </summary>
    public unsafe int ComboMultiplierArmoredLieutenant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// IntProperty: PerfectFreeFlowGradePoint
    /// </summary>
    public unsafe int PerfectFreeFlowGradePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// IntProperty: UnseenFreelFlowGradePoint
    /// </summary>
    public unsafe int UnseenFreelFlowGradePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// IntProperty: VariationGradePoint
    /// </summary>
    public unsafe int VariationGradePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ArrayProperty: ExperienceLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FExperienceLevel> ExperienceLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FExperienceLevel>>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ArrayProperty: ArkhamCityGameActionXPValue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FGameActionXPValue> ArkhamCityGameActionXPValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FGameActionXPValue>>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// ArrayProperty: ArkhamCityXPCurve
    /// </summary>
    public unsafe BmSDK.TArray<float> ArkhamCityXPCurve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ArrayProperty: ArkhamCityCombatVariationBonus
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FVariationBonus> ArkhamCityCombatVariationBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FVariationBonus>>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// ArrayProperty: ArkhamCityPredatorVariationBonus
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FVariationBonus> ArkhamCityPredatorVariationBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FVariationBonus>>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// FloatProperty: ArkhamCityMaxComboBonusMultiplier
    /// </summary>
    public unsafe float ArkhamCityMaxComboBonusMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// FloatProperty: ArkhamCityMaxGadgeVariationBonusMultiplier
    /// </summary>
    public unsafe float ArkhamCityMaxGadgeVariationBonusMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// FloatProperty: ArkhamCityMaxIntimidationTakedownBonusMultiplier
    /// </summary>
    public unsafe float ArkhamCityMaxIntimidationTakedownBonusMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// Struct: FCombatModifierXPValue
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FCombatModifierXPValue
    {
        /// <summary>
        /// ByteProperty: ModifierType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.FreeFlowCombatModifierType ModifierType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FreeFlowCombatModifierType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: XPValue
        /// </summary>
        public unsafe int XPValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FPredGadgetUsageXPValue
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FPredGadgetUsageXPValue
    {
        /// <summary>
        /// ByteProperty: GadgetType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EPredGadgetBonusType GadgetType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EPredGadgetBonusType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: XPValue
        /// </summary>
        public unsafe int XPValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FPredTakedownXPValue
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FPredTakedownXPValue
    {
        /// <summary>
        /// ByteProperty: TakedownType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EPredTakedownType TakedownType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EPredTakedownType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: XPValue
        /// </summary>
        public unsafe int XPValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FPawnXPValue
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FPawnXPValue
    {
        /// <summary>
        /// ByteProperty: EnemyType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.ECombatPawnType EnemyType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ECombatPawnType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: XPValue
        /// </summary>
        public unsafe int XPValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FGameActionXPValue
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FGameActionXPValue
    {
        /// <summary>
        /// ByteProperty: GameAction
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EGameAction GameAction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: XPValue
        /// </summary>
        public unsafe int XPValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
