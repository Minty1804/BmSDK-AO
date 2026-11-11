#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDMatchSettings<br/>
/// (size = 296)
/// (flags = 2129938)
/// </summary>
public partial class GDMatchSettings : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDMatchSettings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDMatchSettings.
    /// </summary>
    public static GDMatchSettings DefaultObject => (GDMatchSettings)StaticClass().DefaultObject;

    internal GDMatchSettings() { }

    /// <summary>
    /// Constructs a new GDMatchSettings
    /// </summary>
    public GDMatchSettings(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDMatchSettings Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDMatchSettings(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDMatchSettings>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDMatchSettings>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDMatchSettings>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDMatchSettings>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDMatchSettings>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDMatchSettings>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDMatchSettings>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDMatchSettings>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ScoreLimitToValue;
    /// <summary>
    /// Function: ScoreLimitToValue
    /// </summary>
    public unsafe static int ScoreLimitToValue(BmSDK.BmGame.GDMatchSettings.EScoreLimit Limit)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScoreLimitToValue, "BmGame.GDMatchSettings.ScoreLimitToValue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Limit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetScoreLimitValue;
    /// <summary>
    /// Function: GetScoreLimitValue
    /// </summary>
    public unsafe virtual int GetScoreLimitValue(bool bHeroScoreLimit = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreLimitValue, "BmGame.GDMatchSettings.GetScoreLimitValue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHeroScoreLimit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TimeLimitToValue;
    /// <summary>
    /// Function: TimeLimitToValue
    /// </summary>
    public unsafe static float TimeLimitToValue(BmSDK.BmGame.GDMatchSettings.ETimeLimit Limit)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TimeLimitToValue, "BmGame.GDMatchSettings.TimeLimitToValue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Limit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTimeLimitValue;
    /// <summary>
    /// Function: GetTimeLimitValue
    /// </summary>
    public unsafe virtual float GetTimeLimitValue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeLimitValue, "BmGame.GDMatchSettings.GetTimeLimitValue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    /// <summary>
    /// NameProperty: PresetName
    /// </summary>
    public unsafe BmSDK.FName PresetName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ByteProperty: TimeLimit
    /// </summary>
    public unsafe BmSDK.BmGame.GDMatchSettings.ETimeLimit TimeLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDMatchSettings.ETimeLimit>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ByteProperty: ScoreLimit
    /// </summary>
    public unsafe BmSDK.BmGame.GDMatchSettings.EScoreLimit ScoreLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDMatchSettings.EScoreLimit>(Ptr + 57); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 57); }
    }

    /// <summary>
    /// ByteProperty: ScoringAsThugs
    /// </summary>
    public unsafe BmSDK.BmGame.GDMatchSettings.EScoringMethod ScoringAsThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDMatchSettings.EScoringMethod>(Ptr + 58); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 58); }
    }

    /// <summary>
    /// ByteProperty: ScoringAsHeroes
    /// </summary>
    public unsafe BmSDK.BmGame.GDMatchSettings.EScoringMethod ScoringAsHeroes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDMatchSettings.EScoringMethod>(Ptr + 59); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 59); }
    }

    /// <summary>
    /// ByteProperty: HeroScoreLimit
    /// </summary>
    public unsafe BmSDK.BmGame.GDMatchSettings.EScoreLimit HeroScoreLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDMatchSettings.EScoreLimit>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// IntProperty: CustomTimeLimitMinutes
    /// </summary>
    public unsafe int CustomTimeLimitMinutes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: bFriendlyFire
    /// </summary>
    public unsafe bool bFriendlyFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bFreeForAll
    /// </summary>
    public unsafe bool bFreeForAll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bApplyAssistScoresToTeam
    /// </summary>
    public unsafe bool bApplyAssistScoresToTeam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bHeroesUseDefaultScoreLimit
    /// </summary>
    public unsafe bool bHeroesUseDefaultScoreLimit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bCanBeRecaptured
    /// </summary>
    public unsafe bool bCanBeRecaptured
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bGrenadePickupsEnabled
    /// </summary>
    public unsafe bool bGrenadePickupsEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bAllowGrenadeSpawnReplacement
    /// </summary>
    public unsafe bool bAllowGrenadeSpawnReplacement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// FloatProperty: RespawnProtectionTime
    /// </summary>
    public unsafe float RespawnProtectionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// IntProperty: CustomScoreLimit
    /// </summary>
    public unsafe int CustomScoreLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// FloatProperty: ScoreLimitWarningRatio
    /// </summary>
    public unsafe float ScoreLimitWarningRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// IntProperty: ScoreForThugKill
    /// </summary>
    public unsafe int ScoreForThugKill
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: ScoreForSpecialCharacterKill
    /// </summary>
    public unsafe int ScoreForSpecialCharacterKill
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// IntProperty: ScoreForThugAssist
    /// </summary>
    public unsafe int ScoreForThugAssist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// IntProperty: ScoreForSpecialCharacterAssist
    /// </summary>
    public unsafe int ScoreForSpecialCharacterAssist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: ThugScoreBankRatio
    /// </summary>
    public unsafe float ThugScoreBankRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// IntProperty: HeroScoreForNormalKill
    /// </summary>
    public unsafe int HeroScoreForNormalKill
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// IntProperty: HeroScoreForAssist
    /// </summary>
    public unsafe int HeroScoreForAssist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: HeroScoreForTakedownKill
    /// </summary>
    public InlineArray<int> HeroScoreForTakedownKill => new(15, Ptr + 112, 4, this);

    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }
    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }
    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
    /// <summary>
    /// IntProperty: HeroScoreForTakedownKill
    /// </summary>
    public unsafe int HeroScoreForTakedownKill_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// IntProperty: HeroCustomScoreLimit
    /// </summary>
    public unsafe int HeroCustomScoreLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// FloatProperty: HeroScoreLimitWarningRatio
    /// </summary>
    public unsafe float HeroScoreLimitWarningRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// IntProperty: HeroScoreLimitHighWarning
    /// </summary>
    public unsafe int HeroScoreLimitHighWarning
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: HeroScoreLossOnDeath
    /// </summary>
    public unsafe int HeroScoreLossOnDeath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// IntProperty: HeroCaptainKillScoreBonus
    /// </summary>
    public unsafe int HeroCaptainKillScoreBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// FloatProperty: HeroScoreBankRatio
    /// </summary>
    public unsafe float HeroScoreBankRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StructProperty: ComboModifierValues
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDMatchSettings.FSHeroComboModifiers ComboModifierValues
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDMatchSettings.FSHeroComboModifiers>(Ptr + 196);

    /// <summary>
    /// IntProperty: HeroSupervillainTakedownBonus
    /// </summary>
    public unsafe int HeroSupervillainTakedownBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// IntProperty: HeroMinScoreLossOnDeath
    /// </summary>
    public unsafe int HeroMinScoreLossOnDeath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// ArrayProperty: AvailableCharacters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDMatchSettings.FSAvailableCharacter> AvailableCharacters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDMatchSettings.FSAvailableCharacter>>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ObjectProperty: SpawnDirector
    /// </summary>
    public unsafe BmSDK.BmGame.GDSpawnDirector SpawnDirector
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDSpawnDirector>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// ObjectProperty: OpacityScaling
    /// </summary>
    public unsafe BmSDK.BmGame.GDSkillToOpacityHelper OpacityScaling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDSkillToOpacityHelper>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ArrayProperty: MatchIntroObjectiveText
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText> MatchIntroObjectiveText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// ArrayProperty: MatchTimeWarningText
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText> MatchTimeWarningText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDGIBase.FSMatchObjectiveText>>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: ObjectiveTextDisplayDuration
    /// </summary>
    public unsafe float ObjectiveTextDisplayDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// FloatProperty: ControlPointCaptureTime
    /// </summary>
    public unsafe float ControlPointCaptureTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// FloatProperty: CapturingXPPulseTime
    /// </summary>
    public unsafe float CapturingXPPulseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// FloatProperty: GrenadePickupEnableDelay
    /// </summary>
    public unsafe float GrenadePickupEnableDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// FloatProperty: EarlyHeroGrenadeNotificationDelay
    /// </summary>
    public unsafe float EarlyHeroGrenadeNotificationDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// IntProperty: StartingGrenadeCount
    /// </summary>
    public unsafe int StartingGrenadeCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// FloatProperty: CaptainXPAwardInterval
    /// </summary>
    public unsafe float CaptainXPAwardInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// IntProperty: CaptainXPMultiplierPerTick
    /// </summary>
    public unsafe int CaptainXPMultiplierPerTick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// Struct: FSHeroComboModifiers
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSHeroComboModifiers
    {
        /// <summary>
        /// FloatProperty: DoubleTakedownModifier
        /// </summary>
        public unsafe float DoubleTakedownModifier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: SneakyTakedownBonus
        /// </summary>
        public unsafe int SneakyTakedownBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: FirstUseBonus
        /// </summary>
        public unsafe int FirstUseBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: VariationBonusPerTakedown
        /// </summary>
        public unsafe int VariationBonusPerTakedown
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FSAvailableCharacter
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FSAvailableCharacter
    {
        /// <summary>
        /// ByteProperty: Character
        /// </summary>
        public unsafe BmSDK.BmGame.GDMatchSettings.ESpecialCharacters Character
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDMatchSettings.ESpecialCharacters>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: TransitionToMethod
        /// </summary>
        public unsafe BmSDK.BmGame.GDMatchSettings.ESpecialCharacterTransition TransitionToMethod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDMatchSettings.ESpecialCharacterTransition>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// ByteProperty: ScoringAsSpecialChar
        /// </summary>
        public unsafe BmSDK.BmGame.GDMatchSettings.EScoringMethod ScoringAsSpecialChar
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDMatchSettings.EScoringMethod>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }

        /// <summary>
        /// IntProperty: ScoreForThugKill
        /// </summary>
        public unsafe int ScoreForThugKill
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: ScoreForSpecialCharacterKill
        /// </summary>
        public unsafe int ScoreForSpecialCharacterKill
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: ApplyToTeams
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDGIBase.ETeamType> ApplyToTeams
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDGIBase.ETeamType>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: Durations
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDMatchSettings.ESpecialCharacterDuration> Durations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDMatchSettings.ESpecialCharacterDuration>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: SpecialGear
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDMatchSettings.FSSpecialGear> SpecialGear
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDMatchSettings.FSSpecialGear>>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Struct: FSSpecialGear
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FSSpecialGear
    {
        /// <summary>
        /// ByteProperty: Availability
        /// </summary>
        public unsafe BmSDK.BmGame.GDMatchSettings.ESpecialCharacterSpecialGear Availability
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDMatchSettings.ESpecialCharacterSpecialGear>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ClassProperty: GadgetType
        /// </summary>
        public unsafe BmSDK.Class GadgetType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: ESpecialCharacterSpecialGear
    /// </summary>
    public enum ESpecialCharacterSpecialGear : byte
    {
        ESpecialCharacterSpecialGear_None = 0,
        ESpecialCharacterSpecialGear_ExtraGadget = 1,
        ESpecialCharacterSpecialGear_RestrictedGadget = 2,
        ESpecialCharacterSpecialGear_MAX = 3,
    }

    /// <summary>
    /// Enum: ESpecialCharacterDuration
    /// </summary>
    public enum ESpecialCharacterDuration : byte
    {
        ESpecialCharacterDuration_OneShot = 0,
        ESpecialCharacterDuration_UntilDead = 1,
        ESpecialCharacterDuration_SimpleTimeExtend = 2,
        ESpecialCharacterDuration_RelativeTimeExtend = 3,
        ESpecialCharacterDuration_ThugInduced = 4,
        ESpecialCharacterDuration_MAX = 5,
    }

    /// <summary>
    /// Enum: ESpecialCharacterTransition
    /// </summary>
    public enum ESpecialCharacterTransition : byte
    {
        ESpecialCharacterTransition_Deadshot = 0,
        ESpecialCharacterTransition_Zsasz = 1,
        ESpecialCharacterTransition_Catwoman = 2,
        ESpecialCharacterTransition_Clayface = 3,
        ESpecialCharacterTransition_Riddler = 4,
        ESpecialCharacterTransition_MAX = 5,
    }

    /// <summary>
    /// Enum: ESpecialCharacters
    /// </summary>
    public enum ESpecialCharacters : byte
    {
        ESpecialCharacters_Batman = 0,
        ESpecialCharacters_Robin = 1,
        ESpecialCharacters_Bane = 2,
        ESpecialCharacters_Joker = 3,
        ESpecialCharacters_MAX = 4,
    }

    /// <summary>
    /// Enum: EScoringMethod
    /// </summary>
    public enum EScoringMethod : byte
    {
        EScoringMethod_PerKill = 0,
        EScoringMethod_PerKillHeat = 1,
        EScoringMethod_WeakestLink = 2,
        EScoringMethod_IntimidationMeter = 3,
        EScoringMethod_GameMode = 4,
        EScoringMethod_MAX = 5,
    }

    /// <summary>
    /// Enum: EScoreLimit
    /// </summary>
    public enum EScoreLimit : byte
    {
        EScoreLimit_10 = 0,
        EScoreLimit_25 = 1,
        EScoreLimit_50 = 2,
        EScoreLimit_Infinite = 3,
        EScoreLimit_Custom = 4,
        EScoreLimit_MAX = 5,
    }

    /// <summary>
    /// Enum: ETimeLimit
    /// </summary>
    public enum ETimeLimit : byte
    {
        ETimeLimit_5Min = 0,
        ETimeLimit_10Min = 1,
        ETimeLimit_15Min = 2,
        ETimeLimit_Infinite = 3,
        ETimeLimit_Custom = 4,
        ETimeLimit_MAX = 5,
    }
}
