#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: GDGFxMovieUI_CustomisationAppearanceItemList<br/>
/// (size = 2169)
/// (flags = 32790)
/// </summary>
public partial class GDGFxMovieUI_CustomisationAppearanceItemList : BmSDK.BmScript.GDGFxMovieUI_CustomisationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGFxMovieUI_CustomisationAppearanceItemList.
    /// </summary>
    public static GDGFxMovieUI_CustomisationAppearanceItemList DefaultObject => (GDGFxMovieUI_CustomisationAppearanceItemList)StaticClass().DefaultObject;

    internal GDGFxMovieUI_CustomisationAppearanceItemList() { }

    /// <summary>
    /// Constructs a new GDGFxMovieUI_CustomisationAppearanceItemList
    /// </summary>
    public GDGFxMovieUI_CustomisationAppearanceItemList(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDGFxMovieUI_CustomisationAppearanceItemList Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGFxMovieUI_CustomisationAppearanceItemList(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationAppearanceItemList>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationAppearanceItemList>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationAppearanceItemList>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationAppearanceItemList>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationAppearanceItemList>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationAppearanceItemList>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationAppearanceItemList>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationAppearanceItemList>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CheckSkinRequiresPurchase;
    /// <summary>
    /// Function: CheckSkinRequiresPurchase
    /// </summary>
    public unsafe virtual bool CheckSkinRequiresPurchase(BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo CustomPartInfo, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSkinRequiresPurchase, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.CheckSkinRequiresPurchase");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 92);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 96);
    }

    private static BmSDK.Function __fn_SkinHasGameplayEffector;
    /// <summary>
    /// Function: SkinHasGameplayEffector
    /// </summary>
    public unsafe virtual bool SkinHasGameplayEffector(BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo CustomPartInfo, int SkinIndex, out BmSDK.BmGame.GDConsumableGameplayEffectorBase.GameplayEffectorType OutType, out float OutEffectAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SkinHasGameplayEffector, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.SkinHasGameplayEffector");
        byte* paramsPtr = stackalloc byte[168];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 92);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutType);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutType, paramsPtr + 96);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutEffectAmount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutEffectAmount, paramsPtr + 100);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutType = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDConsumableGameplayEffectorBase.GameplayEffectorType>(paramsPtr + 96);
        OutEffectAmount = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 100);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 104);
    }

    private static BmSDK.Function __fn_ItemHasGameplayEffector;
    /// <summary>
    /// Function: ItemHasGameplayEffector
    /// </summary>
    public unsafe virtual bool ItemHasGameplayEffector(BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo CustomPartInfo, out BmSDK.BmGame.GDConsumableGameplayEffectorBase.GameplayEffectorType OutType, out float OutEffectAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemHasGameplayEffector, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.ItemHasGameplayEffector");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartInfo, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutType);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutType, paramsPtr + 92);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutEffectAmount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutEffectAmount, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutType = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDConsumableGameplayEffectorBase.GameplayEffectorType>(paramsPtr + 92);
        OutEffectAmount = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 96);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 100);
    }

    private static BmSDK.Function __fn_ItemRequiresPurchase;
    /// <summary>
    /// Function: ItemRequiresPurchase
    /// </summary>
    public unsafe virtual bool ItemRequiresPurchase(BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo CustomPartInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemRequiresPurchase, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.ItemRequiresPurchase");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 92);
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedFlag;
    /// <summary>
    /// Function: ClearRecentlyUnlockedFlag
    /// </summary>
    public unsafe virtual void ClearRecentlyUnlockedFlag(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedFlag, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.ClearRecentlyUnlockedFlag");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ListButtonLoseFocus;
    /// <summary>
    /// Function: ListButtonLoseFocus
    /// </summary>
    public unsafe override void ListButtonLoseFocus(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListButtonLoseFocus, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.ListButtonLoseFocus");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ListButtonSetFocus;
    /// <summary>
    /// Function: ListButtonSetFocus
    /// </summary>
    public unsafe override void ListButtonSetFocus(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListButtonSetFocus, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.ListButtonSetFocus");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerButtonPress;
    /// <summary>
    /// Function: TriggerButtonPress
    /// </summary>
    public unsafe override void TriggerButtonPress(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerButtonPress, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.TriggerButtonPress");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckCustomisationAchievements;
    /// <summary>
    /// Function: CheckCustomisationAchievements
    /// </summary>
    public unsafe virtual void CheckCustomisationAchievements(BmSDK.BmGame.GDCharCustomizationManager Manager)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckCustomisationAchievements, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.CheckCustomisationAchievements");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Manager, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClosed;
    /// <summary>
    /// Function: OnClosed
    /// </summary>
    public unsafe override void OnClosed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClosed, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.OnClosed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCurrentCustomisationName;
    /// <summary>
    /// Function: GetCurrentCustomisationName
    /// </summary>
    public unsafe BmSDK.FString GetCurrentCustomisationName(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType PartType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentCustomisationName, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.GetCurrentCustomisationName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RequestScreenTitleMarkupData;
    /// <summary>
    /// Function: RequestScreenTitleMarkupData
    /// </summary>
    public unsafe override BmSDK.FString RequestScreenTitleMarkupData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestScreenTitleMarkupData, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.RequestScreenTitleMarkupData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPrimaryButtonListLabelMarkupSource;
    /// <summary>
    /// Function: SetPrimaryButtonListLabelMarkupSource
    /// </summary>
    public unsafe override void SetPrimaryButtonListLabelMarkupSource()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrimaryButtonListLabelMarkupSource, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.SetPrimaryButtonListLabelMarkupSource");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LocaliseAppearanceItemFromName;
    /// <summary>
    /// Function: LocaliseAppearanceItemFromName
    /// </summary>
    public unsafe BmSDK.FString LocaliseAppearanceItemFromName(BmSDK.FString ApperanceItemName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LocaliseAppearanceItemFromName, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.LocaliseAppearanceItemFromName");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ApperanceItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PopulateButtonListData;
    /// <summary>
    /// Function: PopulateButtonListData
    /// </summary>
    public unsafe override void PopulateButtonListData(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.GFxUI.GFxObject ButtonListObj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateButtonListData, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.PopulateButtonListData");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListObj, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetIsPartEquipped;
    /// <summary>
    /// Function: GetIsPartEquipped
    /// </summary>
    public unsafe bool GetIsPartEquipped(int CurrTeamIdx, int CurrBankIdx, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CurrPartType, BmSDK.FName PartID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIsPartEquipped, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.GetIsPartEquipped");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrTeamIdx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrBankIdx, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrPartType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetPartAppliedSkin;
    /// <summary>
    /// Function: GetPartAppliedSkin
    /// </summary>
    public unsafe int GetPartAppliedSkin(int CurrTeamIdx, int CurrBankIdx, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CurrPartType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPartAppliedSkin, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.GetPartAppliedSkin");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrTeamIdx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrBankIdx, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrPartType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AddUScriptDeclaredButtonData;
    /// <summary>
    /// Function: AddUScriptDeclaredButtonData
    /// </summary>
    public unsafe override void AddUScriptDeclaredButtonData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUScriptDeclaredButtonData, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.AddUScriptDeclaredButtonData");
        byte* paramsPtr = stackalloc byte[196];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestButtonListData;
    /// <summary>
    /// Function: RequestButtonListData
    /// </summary>
    public unsafe override void RequestButtonListData(BmSDK.FString ButtonListID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestButtonListData, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.RequestButtonListData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseCustomisationScreen;
    /// <summary>
    /// Function: CloseCustomisationScreen
    /// </summary>
    public unsafe override void CloseCustomisationScreen(bool bSelectItem)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseCustomisationScreen, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.CloseCustomisationScreen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSelectItem, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBack;
    /// <summary>
    /// Function: OnBack
    /// </summary>
    public unsafe override void OnBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBack, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.OnBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.Init");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: CustomisationInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.FUICustomisationData> CustomisationInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.GDGFxMovieUI_CustomisationAppearanceItemList.FUICustomisationData>>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// IntProperty: CurrentCustomPartIndex
    /// </summary>
    public unsafe int CurrentCustomPartIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// IntProperty: CurrentColorIndex
    /// </summary>
    public unsafe int CurrentColorIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// StructProperty: CurrentColour
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor CurrentColour
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 2152);

    /// <summary>
    /// ArrayProperty: ColorList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FColor> ColorList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FColor>>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// ByteProperty: CustomisationPartType
    /// </summary>
    public unsafe BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CustomisationPartType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }

    /// <summary>
    /// Struct: FUICustomisationData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FUICustomisationData
    {
        /// <summary>
        /// StructProperty: BasicButtonData
        /// </summary>
        public unsafe BmSDK.BmScript.GDGFxMovieUI_CustomisationBase.FBasicLoadoutButtonData BasicButtonData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.GDGFxMovieUI_CustomisationBase.FBasicLoadoutButtonData>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: ResrcId
        /// </summary>
        public unsafe BmSDK.FName ResrcId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: partIdx
        /// </summary>
        public unsafe int partIdx
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: PreviewPartIndex
        /// </summary>
        public unsafe int PreviewPartIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StrProperty: PartName
        /// </summary>
        public unsafe BmSDK.FString PartName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StrProperty: Description
        /// </summary>
        public unsafe BmSDK.FString Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// IntProperty: NumSkins
        /// </summary>
        public unsafe int NumSkins
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// IntProperty: SkinIndex
        /// </summary>
        public unsafe int SkinIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: HasColor
        /// </summary>
        public unsafe bool HasColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: RequiresPurchase
        /// </summary>
        public unsafe bool RequiresPurchase
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bIsEquipped
        /// </summary>
        public unsafe bool bIsEquipped
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }
    }
}
