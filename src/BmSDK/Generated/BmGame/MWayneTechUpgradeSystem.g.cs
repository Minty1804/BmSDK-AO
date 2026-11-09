#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MWayneTechUpgradeSystem<br/>
/// (size = 136)
/// (flags = 134217878)
/// </summary>
public partial class MWayneTechUpgradeSystem : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MWayneTechUpgradeSystem", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MWayneTechUpgradeSystem.
    /// </summary>
    public static MWayneTechUpgradeSystem DefaultObject => (MWayneTechUpgradeSystem)StaticClass().DefaultObject;

    internal MWayneTechUpgradeSystem() { }

    /// <summary>
    /// Constructs a new MWayneTechUpgradeSystem
    /// </summary>
    public MWayneTechUpgradeSystem(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MWayneTechUpgradeSystem Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MWayneTechUpgradeSystem(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MWayneTechUpgradeSystem>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MWayneTechUpgradeSystem>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MWayneTechUpgradeSystem>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MWayneTechUpgradeSystem>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MWayneTechUpgradeSystem>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MWayneTechUpgradeSystem>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MWayneTechUpgradeSystem>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MWayneTechUpgradeSystem>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DebugAbilityStates;
    /// <summary>
    /// Function: DebugAbilityStates
    /// </summary>
    public unsafe virtual void DebugAbilityStates(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility eAbility)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugAbilityStates, "BmGame.MWayneTechUpgradeSystem.DebugAbilityStates");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eAbility, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InternalAbilityChanged;
    /// <summary>
    /// Function: InternalAbilityChanged
    /// </summary>
    public unsafe virtual void InternalAbilityChanged(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability, int changedflag)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalAbilityChanged, "BmGame.MWayneTechUpgradeSystem.InternalAbilityChanged");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(changedflag, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupFlags;
    /// <summary>
    /// Function: SetupFlags
    /// </summary>
    public unsafe virtual void SetupFlags(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupFlags, "BmGame.MWayneTechUpgradeSystem.SetupFlags");
        byte* paramsPtr = stackalloc byte[105];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForAllUpgradesAchievement;
    /// <summary>
    /// Function: CheckForAllUpgradesAchievement
    /// </summary>
    public unsafe virtual void CheckForAllUpgradesAchievement()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForAllUpgradesAchievement, "BmGame.MWayneTechUpgradeSystem.CheckForAllUpgradesAchievement");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CallCallbacks;
    /// <summary>
    /// Function: CallCallbacks
    /// </summary>
    public unsafe virtual void CallCallbacks(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability, int changedflags)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CallCallbacks, "BmGame.MWayneTechUpgradeSystem.CallCallbacks");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(changedflags, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockGadgetForStoryMode;
    /// <summary>
    /// Function: UnlockGadgetForStoryMode
    /// </summary>
    public unsafe virtual void UnlockGadgetForStoryMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockGadgetForStoryMode, "BmGame.MWayneTechUpgradeSystem.UnlockGadgetForStoryMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockGadgetForGamePlusMode;
    /// <summary>
    /// Function: UnlockGadgetForGamePlusMode
    /// </summary>
    public unsafe virtual void UnlockGadgetForGamePlusMode(bool bIsIABMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockGadgetForGamePlusMode, "BmGame.MWayneTechUpgradeSystem.UnlockGadgetForGamePlusMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsIABMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldLockGadgetForNewGamePlusMode;
    /// <summary>
    /// Function: ShouldLockGadgetForNewGamePlusMode
    /// </summary>
    public unsafe virtual void ShouldLockGadgetForNewGamePlusMode(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability, BmSDK.FString NGPFlag, bool bIsIABMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldLockGadgetForNewGamePlusMode, "BmGame.MWayneTechUpgradeSystem.ShouldLockGadgetForNewGamePlusMode");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NGPFlag, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsIABMode, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NewGamePlusDefaults;
    /// <summary>
    /// Function: NewGamePlusDefaults
    /// </summary>
    public unsafe virtual void NewGamePlusDefaults()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NewGamePlusDefaults, "BmGame.MWayneTechUpgradeSystem.NewGamePlusDefaults");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EditorDefaults;
    /// <summary>
    /// Function: EditorDefaults
    /// </summary>
    public unsafe virtual void EditorDefaults()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EditorDefaults, "BmGame.MWayneTechUpgradeSystem.EditorDefaults");
        byte* paramsPtr = stackalloc byte[45];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChallengesDefaults;
    /// <summary>
    /// Function: ChallengesDefaults
    /// </summary>
    public unsafe virtual void ChallengesDefaults()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChallengesDefaults, "BmGame.MWayneTechUpgradeSystem.ChallengesDefaults");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Defaults;
    /// <summary>
    /// Function: Defaults
    /// </summary>
    public unsafe virtual void Defaults()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Defaults, "BmGame.MWayneTechUpgradeSystem.Defaults");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupFromURL;
    /// <summary>
    /// Function: SetupFromURL
    /// </summary>
    public unsafe virtual void SetupFromURL(BmSDK.FString Params)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupFromURL, "BmGame.MWayneTechUpgradeSystem.SetupFromURL");
        byte* paramsPtr = stackalloc byte[45];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugActivateAllGadgets;
    /// <summary>
    /// Function: DebugActivateAllGadgets
    /// </summary>
    public unsafe virtual void DebugActivateAllGadgets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugActivateAllGadgets, "BmGame.MWayneTechUpgradeSystem.DebugActivateAllGadgets");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugRevealAll;
    /// <summary>
    /// Function: DebugRevealAll
    /// </summary>
    public unsafe virtual void DebugRevealAll(bool Reveal = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugRevealAll, "BmGame.MWayneTechUpgradeSystem.DebugRevealAll");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reveal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugUpgradeAll;
    /// <summary>
    /// Function: DebugUpgradeAll
    /// </summary>
    public unsafe virtual void DebugUpgradeAll(bool Upgrade = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugUpgradeAll, "BmGame.MWayneTechUpgradeSystem.DebugUpgradeAll");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Upgrade, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugUnlockAll;
    /// <summary>
    /// Function: DebugUnlockAll
    /// </summary>
    public unsafe virtual void DebugUnlockAll(bool Unlock = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugUnlockAll, "BmGame.MWayneTechUpgradeSystem.DebugUnlockAll");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Unlock, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCategoryEnum;
    /// <summary>
    /// Function: GetCategoryEnum
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MWayneTechUpgradeSystem.EWayneTechCategory GetCategoryEnum(BmSDK.FName Key)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCategoryEnum, "BmGame.MWayneTechUpgradeSystem.GetCategoryEnum");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MWayneTechUpgradeSystem.EWayneTechCategory>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetAbilityEnum;
    /// <summary>
    /// Function: GetAbilityEnum
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility GetAbilityEnum(BmSDK.FName Key)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAbilityEnum, "BmGame.MWayneTechUpgradeSystem.GetAbilityEnum");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPromptList;
    /// <summary>
    /// Function: GetPromptList
    /// </summary>
    public unsafe virtual void GetPromptList(out BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechPrompt> PromptList, BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPromptList, "BmGame.MWayneTechUpgradeSystem.GetPromptList");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PromptList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechPrompt>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_CategoryHasAvailableUpgrades;
    /// <summary>
    /// Function: CategoryHasAvailableUpgrades
    /// </summary>
    public unsafe virtual bool CategoryHasAvailableUpgrades(BmSDK.BmGame.MWayneTechUpgradeSystem.EWayneTechCategory Category, BmSDK.FName SubCategory = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CategoryHasAvailableUpgrades, "BmGame.MWayneTechUpgradeSystem.CategoryHasAvailableUpgrades");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Category, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubCategory, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CategoryHasNewUpgrade;
    /// <summary>
    /// Function: CategoryHasNewUpgrade
    /// </summary>
    public unsafe virtual bool CategoryHasNewUpgrade(BmSDK.BmGame.MWayneTechUpgradeSystem.EWayneTechCategory Category, BmSDK.FName SubCategory = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CategoryHasNewUpgrade, "BmGame.MWayneTechUpgradeSystem.CategoryHasNewUpgrade");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Category, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubCategory, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CountByCategory;
    /// <summary>
    /// Function: CountByCategory
    /// </summary>
    public unsafe virtual void CountByCategory(out int Count, out int Total, BmSDK.BmGame.MWayneTechUpgradeSystem.EWayneTechCategory Category, BmSDK.FName SubCategory = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CountByCategory, "BmGame.MWayneTechUpgradeSystem.CountByCategory");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Count);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Total);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Total, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Category, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubCategory, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Count = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        Total = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_Count;
    /// <summary>
    /// Function: Count
    /// </summary>
    public unsafe virtual void Count(out int _Count)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Count, "BmGame.MWayneTechUpgradeSystem.Count");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out _Count);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_Count, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        _Count = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetTotalUpgradesSpending;
    /// <summary>
    /// Function: GetTotalUpgradesSpending
    /// </summary>
    public unsafe virtual int GetTotalUpgradesSpending()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTotalUpgradesSpending, "BmGame.MWayneTechUpgradeSystem.GetTotalUpgradesSpending");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTotalUpgradesNum;
    /// <summary>
    /// Function: GetTotalUpgradesNum
    /// </summary>
    public unsafe virtual int GetTotalUpgradesNum()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTotalUpgradesNum, "BmGame.MWayneTechUpgradeSystem.GetTotalUpgradesNum");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUpgradeByKey;
    /// <summary>
    /// Function: GetUpgradeByKey
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechUpgrade GetUpgradeByKey(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUpgradeByKey, "BmGame.MWayneTechUpgradeSystem.GetUpgradeByKey");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechUpgrade>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetUpgradesByCategory;
    /// <summary>
    /// Function: GetUpgradesByCategory
    /// </summary>
    public unsafe virtual void GetUpgradesByCategory(out BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechUpgrade> upgradeList, BmSDK.BmGame.MWayneTechUpgradeSystem.EWayneTechCategory Category, BmSDK.FName SubCategory = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUpgradesByCategory, "BmGame.MWayneTechUpgradeSystem.GetUpgradesByCategory");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Category, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubCategory, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        upgradeList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechUpgrade>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetAllUpgrades;
    /// <summary>
    /// Function: GetAllUpgrades
    /// </summary>
    public unsafe virtual void GetAllUpgrades(out BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechUpgrade> upgradeList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAllUpgrades, "BmGame.MWayneTechUpgradeSystem.GetAllUpgrades");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        upgradeList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechUpgrade>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_HasTutorial;
    /// <summary>
    /// Function: HasTutorial
    /// </summary>
    public unsafe virtual bool HasTutorial(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasTutorial, "BmGame.MWayneTechUpgradeSystem.HasTutorial");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsAvailable;
    /// <summary>
    /// Function: IsAvailable
    /// </summary>
    public unsafe virtual bool IsAvailable(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAvailable, "BmGame.MWayneTechUpgradeSystem.IsAvailable");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MakeAvailable;
    /// <summary>
    /// Function: MakeAvailable
    /// </summary>
    public unsafe virtual void MakeAvailable(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeAvailable, "BmGame.MWayneTechUpgradeSystem.MakeAvailable");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsRevealed;
    /// <summary>
    /// Function: IsRevealed
    /// </summary>
    public unsafe virtual bool IsRevealed(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRevealed, "BmGame.MWayneTechUpgradeSystem.IsRevealed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Reveal;
    /// <summary>
    /// Function: Reveal
    /// </summary>
    public unsafe virtual void Reveal(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reveal, "BmGame.MWayneTechUpgradeSystem.Reveal");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasUpgrade;
    /// <summary>
    /// Function: HasUpgrade
    /// </summary>
    public unsafe virtual bool HasUpgrade(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasUpgrade, "BmGame.MWayneTechUpgradeSystem.HasUpgrade");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UndoUpgrade;
    /// <summary>
    /// Function: UndoUpgrade
    /// </summary>
    public unsafe virtual void UndoUpgrade(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UndoUpgrade, "BmGame.MWayneTechUpgradeSystem.UndoUpgrade");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessIndividualChallengeModeUnlock;
    /// <summary>
    /// Function: ProcessIndividualChallengeModeUnlock
    /// </summary>
    public unsafe virtual bool ProcessIndividualChallengeModeUnlock(BmSDK.BmGame.MWayneTechUpgradeSystem.FChallengeUnlockWayneTech challengeUnlockWT, bool showMessage = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessIndividualChallengeModeUnlock, "BmGame.MWayneTechUpgradeSystem.ProcessIndividualChallengeModeUnlock");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(challengeUnlockWT, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(showMessage, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ProcessChallengeModeUnlocks;
    /// <summary>
    /// Function: ProcessChallengeModeUnlocks
    /// </summary>
    public unsafe virtual void ProcessChallengeModeUnlocks(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessChallengeModeUnlocks, "BmGame.MWayneTechUpgradeSystem.ProcessChallengeModeUnlocks");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Upgrade;
    /// <summary>
    /// Function: Upgrade
    /// </summary>
    public unsafe virtual void Upgrade(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Upgrade, "BmGame.MWayneTechUpgradeSystem.Upgrade");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsViewed;
    /// <summary>
    /// Function: IsViewed
    /// </summary>
    public unsafe virtual bool IsViewed(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsViewed, "BmGame.MWayneTechUpgradeSystem.IsViewed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_View;
    /// <summary>
    /// Function: View
    /// </summary>
    public unsafe virtual void View(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_View, "BmGame.MWayneTechUpgradeSystem.View");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPurchased;
    /// <summary>
    /// Function: IsPurchased
    /// </summary>
    public unsafe virtual bool IsPurchased(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPurchased, "BmGame.MWayneTechUpgradeSystem.IsPurchased");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Purchase;
    /// <summary>
    /// Function: Purchase
    /// </summary>
    public unsafe virtual void Purchase(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Purchase, "BmGame.MWayneTechUpgradeSystem.Purchase");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsRevealedByMostWanted;
    /// <summary>
    /// Function: IsRevealedByMostWanted
    /// </summary>
    public unsafe virtual bool IsRevealedByMostWanted(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRevealedByMostWanted, "BmGame.MWayneTechUpgradeSystem.IsRevealedByMostWanted");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HideByMostWanted;
    /// <summary>
    /// Function: HideByMostWanted
    /// </summary>
    public unsafe virtual void HideByMostWanted(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideByMostWanted, "BmGame.MWayneTechUpgradeSystem.HideByMostWanted");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RevealByMostWanted;
    /// <summary>
    /// Function: RevealByMostWanted
    /// </summary>
    public unsafe virtual void RevealByMostWanted(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RevealByMostWanted, "BmGame.MWayneTechUpgradeSystem.RevealByMostWanted");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsRevealedByChallenges;
    /// <summary>
    /// Function: IsRevealedByChallenges
    /// </summary>
    public unsafe virtual bool IsRevealedByChallenges(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRevealedByChallenges, "BmGame.MWayneTechUpgradeSystem.IsRevealedByChallenges");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HideByChallenges;
    /// <summary>
    /// Function: HideByChallenges
    /// </summary>
    public unsafe virtual void HideByChallenges(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideByChallenges, "BmGame.MWayneTechUpgradeSystem.HideByChallenges");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RevealByChallenges;
    /// <summary>
    /// Function: RevealByChallenges
    /// </summary>
    public unsafe virtual void RevealByChallenges(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RevealByChallenges, "BmGame.MWayneTechUpgradeSystem.RevealByChallenges");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsRevealedByStory;
    /// <summary>
    /// Function: IsRevealedByStory
    /// </summary>
    public unsafe virtual bool IsRevealedByStory(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRevealedByStory, "BmGame.MWayneTechUpgradeSystem.IsRevealedByStory");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HideByStory;
    /// <summary>
    /// Function: HideByStory
    /// </summary>
    public unsafe virtual void HideByStory(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideByStory, "BmGame.MWayneTechUpgradeSystem.HideByStory");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RevealByStory;
    /// <summary>
    /// Function: RevealByStory
    /// </summary>
    public unsafe virtual void RevealByStory(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RevealByStory, "BmGame.MWayneTechUpgradeSystem.RevealByStory");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsUnlocked;
    /// <summary>
    /// Function: IsUnlocked
    /// </summary>
    public unsafe virtual bool IsUnlocked(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsUnlocked, "BmGame.MWayneTechUpgradeSystem.IsUnlocked");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Unlock;
    /// <summary>
    /// Function: Unlock
    /// </summary>
    public unsafe virtual void Unlock(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Unlock, "BmGame.MWayneTechUpgradeSystem.Unlock");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFlagSet;
    /// <summary>
    /// Function: IsFlagSet
    /// </summary>
    public unsafe virtual bool IsFlagSet(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability, int Flags)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFlagSet, "BmGame.MWayneTechUpgradeSystem.IsFlagSet");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Flags, paramsPtr + 4);
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

    private static BmSDK.Function __fn_UnSetFlags;
    /// <summary>
    /// Function: UnSetFlags
    /// </summary>
    public unsafe virtual void UnSetFlags(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability, int Flags)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnSetFlags, "BmGame.MWayneTechUpgradeSystem.UnSetFlags");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Flags, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFlags;
    /// <summary>
    /// Function: SetFlags
    /// </summary>
    public unsafe virtual void SetFlags(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability, int Flags)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFlags, "BmGame.MWayneTechUpgradeSystem.SetFlags");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Flags, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAllUpgraded;
    /// <summary>
    /// Function: IsAllUpgraded
    /// </summary>
    public unsafe virtual bool IsAllUpgraded(BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility> AbilityList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAllUpgraded, "BmGame.MWayneTechUpgradeSystem.IsAllUpgraded");
        byte* paramsPtr = stackalloc byte[37];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityList, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsAllPurchased;
    /// <summary>
    /// Function: IsAllPurchased
    /// </summary>
    public unsafe virtual bool IsAllPurchased(BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility> AbilityList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAllPurchased, "BmGame.MWayneTechUpgradeSystem.IsAllPurchased");
        byte* paramsPtr = stackalloc byte[37];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityList, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetPlayerController;
    /// <summary>
    /// Function: SetPlayerController
    /// </summary>
    public unsafe virtual void SetPlayerController(BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerController, "BmGame.MWayneTechUpgradeSystem.SetPlayerController");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.MWayneTechUpgradeSystem.Init");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FChallengeUnlockWayneTech
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FChallengeUnlockWayneTech
    {
        /// <summary>
        /// ArrayProperty: Upgrades
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility> Upgrades
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: UnlockIds
        /// </summary>
        public unsafe BmSDK.TArray<int> UnlockIds
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// BoolProperty: UnlockAll
    /// </summary>
    public unsafe bool UnlockAll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }
    }

    /// <summary>
    /// BoolProperty: RevealAll
    /// </summary>
    public unsafe bool RevealAll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }
    }

    /// <summary>
    /// BoolProperty: UpgradeAll
    /// </summary>
    public unsafe bool UpgradeAll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }
    }

    /// <summary>
    /// ObjectProperty: mGameInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo mGameInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ObjectProperty: WorldInfo
    /// </summary>
    public unsafe BmSDK.Engine.WorldInfo WorldInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// ObjectProperty: mGameRepInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI mGameRepInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ObjectProperty: mFlagManager
    /// </summary>
    public unsafe BmSDK.BmGame.RFlagManager mFlagManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFlagManager>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// ObjectProperty: mPlayerController
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController mPlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// ArrayProperty: UpgradeData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechUpgrade> UpgradeData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechUpgrade>>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// ArrayProperty: Data
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechUpgrade> Data
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechUpgrade>>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// ArrayProperty: UnlockData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechUnlockLookup> UnlockData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechUnlockLookup>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: UpgradePrompts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechPrompt> UpgradePrompts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechPrompt>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// IntProperty: TotalUpgradesNum
    /// </summary>
    public unsafe int TotalUpgradesNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// IntProperty: TotalUpgradesSpending
    /// </summary>
    public unsafe int TotalUpgradesSpending
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// ArrayProperty: ChallengeUnlocksWayneTech
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FChallengeUnlockWayneTech> ChallengeUnlocksWayneTech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FChallengeUnlockWayneTech>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// Struct: FWayneTechUnlockLookup
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FWayneTechUnlockLookup
    {
        /// <summary>
        /// ByteProperty: Key
        /// </summary>
        public unsafe BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility Key
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: UpgradesToCheck
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechUpgrade> UpgradesToCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.FWayneTechUpgrade>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FWayneTechUpgrade
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FWayneTechUpgrade
    {
        /// <summary>
        /// ByteProperty: Key
        /// </summary>
        public unsafe BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility Key
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: Category
        /// </summary>
        public unsafe BmSDK.BmGame.MWayneTechUpgradeSystem.EWayneTechCategory Category
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWayneTechUpgradeSystem.EWayneTechCategory>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// NameProperty: SubCategory
        /// </summary>
        public unsafe BmSDK.FName SubCategory
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Cost
        /// </summary>
        public unsafe int Cost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: UnlockedBy
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility> UnlockedBy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ArrayProperty: Secrets
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.EWayneTechSecretTypes> Secrets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MWayneTechUpgradeSystem.EWayneTechSecretTypes>>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ByteProperty: Tutorial
        /// </summary>
        public unsafe BmSDK.BmGame.RPersistentData.ETutorialType Tutorial
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ETutorialType>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ArrayProperty: PromptList
        /// </summary>
        public unsafe BmSDK.TArray<int> PromptList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StrProperty: USM
        /// </summary>
        public unsafe BmSDK.FString USM
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Enum: EWayneTechSecretTypes
    /// </summary>
    public enum EWayneTechSecretTypes : byte
    {
        WayneTechSecretTypes_Story = 0,
        WayneTechSecretTypes_Challenges = 1,
        WayneTechSecretTypes_MostWanted = 2,
        WayneTechSecretTypes_MAX = 3,
    }

    /// <summary>
    /// Struct: FWayneTechPrompt
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FWayneTechPrompt
    {
        /// <summary>
        /// ByteProperty: Id
        /// </summary>
        public unsafe BmSDK.BmGame.RHUDPrompt.EControlIcon Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Label
        /// </summary>
        public unsafe BmSDK.FString Label
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EWayneTechCategory
    /// </summary>
    public enum EWayneTechCategory : byte
    {
        WayneTechCategory_None = 0,
        WayneTechCategory_BasicMoves = 1,
        WayneTechCategory_CombatVsMelee = 2,
        WayneTechCategory_CombatVsWeapons = 3,
        WayneTechCategory_Predator = 4,
        WayneTechCategory_MAX = 5,
    }

    /// <summary>
    /// Enum: ECharacterAbility
    /// </summary>
    public enum ECharacterAbility : byte
    {
        CharacterAbility_None = 0,
        Batman_Movement = 1,
        Batman_DetectiveMode = 2,
        Batman_Slide = 3,
        Batman_Grapple = 4,
        Batman_Glide = 5,
        Batman_InformantScanner = 6,
        Batman_GrapnelBoost = 7,
        Batman_EnvironmentAnalysis = 8,
        Batman_DropAttack = 9,
        Batman_DiveBoost = 10,
        Batman_GlideKick = 11,
        Batman_InformantInterrogation = 12,
        Batman_Strike = 13,
        Batman_Counter = 14,
        Batman_Evade = 15,
        Batman_Redirect = 16,
        Batman_CapeStun = 17,
        Batman_ProjectileCounter = 18,
        Batman_GroundTakedown = 19,
        Batman_Beatdown = 20,
        Batman_AerialAttack = 21,
        Batman_SuperStun = 22,
        Batman_Takedowns = 23,
        Batman_BladeCounter = 24,
        Batman_Batarang = 25,
        Batman_MultiTargetBatarang = 26,
        Batman_Batclaw = 27,
        Batman_RemoteClaw = 28,
        Batman_CryptographicSequencer = 29,
        Batman_SmokePellets = 30,
        Batman_ShockGloves = 31,
        Batman_WeaponDisruptor = 32,
        Batman_GlueGrenade = 33,
        Batman_ConcussionDetonator = 34,
        Batman_ExplosiveGel = 35,
        Batman_GrappleGun = 36,
        Batman_RemoteControlBatarang = 37,
        Batman_RemoteControlBatarangBoost = 38,
        Batman_SonicBatarangDistract = 39,
        Batman_RemoteClawVantagePointThug = 40,
        Batman_CornerCover = 41,
        Batman_SilentTakedown = 42,
        Batman_KnockoutSmash = 43,
        Batman_DoubleTakedown = 44,
        Batman_InvertedTakedown = 45,
        Batman_GrateTakedown = 46,
        Batman_LedgeTakedown = 47,
        Batman_HangingLedgeTakedown = 48,
        Batman_WindowTakedown = 49,
        Batman_WoodenWallTakedown = 50,
        Batman_VentTakedown = 51,
        Batman_CornerCoverTakedown = 52,
        Batman_MeleeArmor1 = 53,
        Batman_MeleeArmor2 = 54,
        Batman_ShockGlovesAdditionalPunches = 55,
        Batman_ShockGlovesRegenerationTime = 56,
        Batman_MeleeArmor3 = 57,
        Batman_MeleeArmor4 = 58,
        Batman_CriticalStrikes = 59,
        Batman_FreeFlowFocus = 60,
        Batman_BatarangDamage = 61,
        Batman_FreeFlowPowerGadgets = 62,
        Batman_ConcussionDetonatorDuration = 63,
        Batman_ConcussionDetonatorRadius = 64,
        Batman_CounterCriticalStrikes = 65,
        Batman_SpecialComboMultipleTakedown = 66,
        Batman_GlueGrenadeCluster = 67,
        Batman_GlueGrenadeClusterProximityMine = 68,
        Batman_DoubleSpecialCombatMove = 69,
        Batman_SmokePelletsRadius = 70,
        Batman_GrapnelBoostTakeDown = 71,
        Batman_SmokePelletsDuration = 72,
        Batman_BladeDodgeTakedown = 73,
        Batman_ShockGlovesCounterStunStick = 74,
        Batman_ShockGlovesCounterShield = 75,
        Batman_SpecialComboDisarmAndDestroy = 76,
        Batman_BallisticArmor1 = 77,
        Batman_BallisticArmor2 = 78,
        Batman_BatclawDisarm = 79,
        Batman_BallisticArmor3 = 80,
        Batman_BallisticArmor4 = 81,
        Batman_WeaponDisruptorDetonateMine = 82,
        Batman_WeaponDisruptorExtraAmmo = 83,
        Batman_WeaponDisruptorWeaponBox = 84,
        Batman_Shockwave = 85,
        Batman_SpecialComboBatSwarm = 86,
        Batman_SpecialComboBoost = 87,
        Batman_ExplosiveGelMultipleFrequencyDetonator = 88,
        Batman_RemoteClawRopeAndZiplineTakedown = 89,
        Batman_BatarangStunTime = 90,
        Batman_MultiTargetBatarangDouble = 91,
        Batman_HeatSignatureMask = 92,
        Batman_MultiTargetBatarangTripple = 93,
        Batman_SonicBatarang = 94,
        Batman_IntimidationTakedown = 95,
        Batman_WeaponDisruptorTannoyBox = 96,
        Batman_SonicBatarangShock = 97,
        Batman_BatarangReverse = 98,
        Batman_GlideBoostAttack = 99,
        Batman_ExplosiveGelProximityDetonator = 100,
        Batman_CryptographicSequencerRangeAmplifier = 101,
        Batman_CryptographicSequencerPowerAmplifier = 102,
        Batman_RemoteClawRemoteTakedown = 103,
        Batman_GlueGrenadeProximityMine = 104,
        Batman_GlueGrenadeDuration = 105,
        Batman_RemoteClawAdditionalWire = 106,
        Batman_SilentKnockoutSmash = 107,
        Batman_MovementStealth = 108,
        Batman_LookZoomTrigCam = 109,
        Batman_CombatGrading = 110,
        Batman_RedirectAttack = 111,
        Batman_Interrogation = 112,
        Batman_PredatorGrading = 113,
        Joker_RazorCard = 114,
        Joker_RictusGrinCard = 115,
        Joker_PepperSprayCard = 116,
        Joker_ChatteringTeeth = 117,
        Joker_RemoteBomb = 118,
        Joker_PinWheel = 119,
        Joker_RedirectCounter = 120,
        DEPRECATED_Batman_QuickGel = 121,
        DEPRECATED_Batman_LineLauncher = 122,
        DEPRECATED_Batman_LineLauncherTightRope = 123,
        DEPRECATED_Batman_HarpoonGun = 124,
        DEPRECATED_Batman_HarpoonGunLvl2 = 125,
        DEPRECATED_Batman_ResonatorTuner = 126,
        DEPRECATED_Batman_ResonatorTunerRange = 127,
        DEPRECATED_Batman_MagneticBlast = 128,
        DEPRECATED_Batman_MagneticBlastLevel2 = 129,
        DEPRECATED_Batman_AnytimeTd = 130,
        DEPRECATED_Batman_ComboTakedownDrone = 131,
        DEPRECATED_Batman_ControllableBatarangTut = 132,
        ECharacterAbility_MAX = 133,
    }
}
