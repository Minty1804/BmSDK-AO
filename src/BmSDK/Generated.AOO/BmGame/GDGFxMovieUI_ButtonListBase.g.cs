#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDGFxMovieUI_ButtonListBase<br/>
/// (size = 2036)
/// (flags = 134250646)
/// </summary>
public partial class GDGFxMovieUI_ButtonListBase : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGFxMovieUI_ButtonListBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGFxMovieUI_ButtonListBase.
    /// </summary>
    public static GDGFxMovieUI_ButtonListBase DefaultObject => (GDGFxMovieUI_ButtonListBase)StaticClass().DefaultObject;

    internal GDGFxMovieUI_ButtonListBase() { }

    /// <summary>
    /// Constructs a new GDGFxMovieUI_ButtonListBase
    /// </summary>
    public GDGFxMovieUI_ButtonListBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDGFxMovieUI_ButtonListBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGFxMovieUI_ButtonListBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_ButtonListBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_ButtonListBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_ButtonListBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_ButtonListBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_ButtonListBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_ButtonListBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_ButtonListBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_ButtonListBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_asSetNextUnlocks;
    /// <summary>
    /// Function: asSetNextUnlocks
    /// </summary>
    public unsafe virtual void asSetNextUnlocks(BmSDK.FString UnlockIcon1, BmSDK.FString UnlockIcon2, BmSDK.FString UnlockIcon3, BmSDK.FString UnlockIconPackage1, BmSDK.FString UnlockIconPackage2, BmSDK.FString UnlockIconPackage3)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetNextUnlocks, "BmGame.GDGFxMovieUI_ButtonListBase.asSetNextUnlocks");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockIcon1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockIcon2, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockIcon3, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockIconPackage1, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockIconPackage2, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockIconPackage3, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetPlayerCurrentAndNextLevelText;
    /// <summary>
    /// Function: asSetPlayerCurrentAndNextLevelText
    /// </summary>
    public unsafe virtual void asSetPlayerCurrentAndNextLevelText(BmSDK.FString LocalisedCurrLvl, BmSDK.FString LocalisedNextLvl)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetPlayerCurrentAndNextLevelText, "BmGame.GDGFxMovieUI_ButtonListBase.asSetPlayerCurrentAndNextLevelText");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalisedCurrLvl, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalisedNextLvl, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetProfileFillBarLevel;
    /// <summary>
    /// Function: asSetProfileFillBarLevel
    /// </summary>
    public unsafe virtual void asSetProfileFillBarLevel(float FillFraction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetProfileFillBarLevel, "BmGame.GDGFxMovieUI_ButtonListBase.asSetProfileFillBarLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FillFraction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetPlayerLevelTitleFaction;
    /// <summary>
    /// Function: asSetPlayerLevelTitleFaction
    /// </summary>
    public unsafe virtual void asSetPlayerLevelTitleFaction(BmSDK.FString FactionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetPlayerLevelTitleFaction, "BmGame.GDGFxMovieUI_ButtonListBase.asSetPlayerLevelTitleFaction");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FactionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asTriggerRegistrationOfLevelInfoPanelObjects;
    /// <summary>
    /// Function: asTriggerRegistrationOfLevelInfoPanelObjects
    /// </summary>
    public unsafe virtual void asTriggerRegistrationOfLevelInfoPanelObjects()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asTriggerRegistrationOfLevelInfoPanelObjects, "BmGame.GDGFxMovieUI_ButtonListBase.asTriggerRegistrationOfLevelInfoPanelObjects");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetArkhamOnlineRating;
    /// <summary>
    /// Function: asSetArkhamOnlineRating
    /// </summary>
    public unsafe virtual void asSetArkhamOnlineRating(BmSDK.FString Rating)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetArkhamOnlineRating, "BmGame.GDGFxMovieUI_ButtonListBase.asSetArkhamOnlineRating");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rating, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowUnlockData;
    /// <summary>
    /// Function: ShowUnlockData
    /// </summary>
    public unsafe virtual bool ShowUnlockData(BmSDK.BmGame.GDUnlockUtilities.EUIUnlockType UnlockType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowUnlockData, "BmGame.GDGFxMovieUI_ButtonListBase.ShowUnlockData");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UnlockDataToIconData;
    /// <summary>
    /// Function: UnlockDataToIconData
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FSUnlockIconData> UnlockDataToIconData(BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData> UnlockData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockDataToIconData, "BmGame.GDGFxMovieUI_ButtonListBase.UnlockDataToIconData");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FSUnlockIconData>>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetUnlockIcons;
    /// <summary>
    /// Function: GetUnlockIcons
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FSUnlockIconData> GetUnlockIcons(BmSDK.BmGame.RGameInfo.ELoadoutTeamId LoadoutFaction, int ForLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockIcons, "BmGame.GDGFxMovieUI_ButtonListBase.GetUnlockIcons");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutFaction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForLevel, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FSUnlockIconData>>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetPlayerLevelData;
    /// <summary>
    /// Function: SetPlayerLevelData
    /// </summary>
    public unsafe virtual void SetPlayerLevelData(BmSDK.BmGame.RGameInfo.ELoadoutTeamId LoadoutFaction, BmSDK.GFxUI.GFxObject LevelObject)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerLevelData, "BmGame.GDGFxMovieUI_ButtonListBase.SetPlayerLevelData");
        byte* paramsPtr = stackalloc byte[196];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutFaction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelObject, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetNumGothamBucks;
    /// <summary>
    /// Function: asSetNumGothamBucks
    /// </summary>
    public unsafe virtual void asSetNumGothamBucks(BmSDK.FString NumBucks)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetNumGothamBucks, "BmGame.GDGFxMovieUI_ButtonListBase.asSetNumGothamBucks");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumBucks, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGothamBucksBoxData;
    /// <summary>
    /// Function: GetGothamBucksBoxData
    /// </summary>
    public unsafe virtual void GetGothamBucksBoxData(BmSDK.FString GothamBucksBoxName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGothamBucksBoxData, "BmGame.GDGFxMovieUI_ButtonListBase.GetGothamBucksBoxData");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GothamBucksBoxName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetDefaultOnAllButtonEntries;
    /// <summary>
    /// Function: asSetDefaultOnAllButtonEntries
    /// </summary>
    public unsafe virtual void asSetDefaultOnAllButtonEntries()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetDefaultOnAllButtonEntries, "BmGame.GDGFxMovieUI_ButtonListBase.asSetDefaultOnAllButtonEntries");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetNewInitialValue;
    /// <summary>
    /// Function: asSetNewInitialValue
    /// </summary>
    public unsafe virtual void asSetNewInitialValue(int ButtonIndex, int NewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetNewInitialValue, "BmGame.GDGFxMovieUI_ButtonListBase.asSetNewInitialValue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asRestoreInitialValue;
    /// <summary>
    /// Function: asRestoreInitialValue
    /// </summary>
    public unsafe virtual void asRestoreInitialValue(int ButtonIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asRestoreInitialValue, "BmGame.GDGFxMovieUI_ButtonListBase.asRestoreInitialValue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asGetNumberOfVisibleListElements;
    /// <summary>
    /// Function: asGetNumberOfVisibleListElements
    /// </summary>
    public unsafe virtual int asGetNumberOfVisibleListElements()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetNumberOfVisibleListElements, "BmGame.GDGFxMovieUI_ButtonListBase.asGetNumberOfVisibleListElements");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asUpdateButtonDataInList;
    /// <summary>
    /// Function: asUpdateButtonDataInList
    /// </summary>
    public unsafe virtual void asUpdateButtonDataInList(int ButtonIndex, BmSDK.GFxUI.GFxObject ButtonData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asUpdateButtonDataInList, "BmGame.GDGFxMovieUI_ButtonListBase.asUpdateButtonDataInList");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonData, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asClearButtonList;
    /// <summary>
    /// Function: asClearButtonList
    /// </summary>
    public unsafe virtual void asClearButtonList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asClearButtonList, "BmGame.GDGFxMovieUI_ButtonListBase.asClearButtonList");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetAutoLocalisationForButtonLabel;
    /// <summary>
    /// Function: asSetAutoLocalisationForButtonLabel
    /// </summary>
    public unsafe virtual void asSetAutoLocalisationForButtonLabel(bool bLocalise)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetAutoLocalisationForButtonLabel, "BmGame.GDGFxMovieUI_ButtonListBase.asSetAutoLocalisationForButtonLabel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLocalise, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetButtonLabelSourceMarkup;
    /// <summary>
    /// Function: asSetButtonLabelSourceMarkup
    /// </summary>
    public unsafe virtual void asSetButtonLabelSourceMarkup(BmSDK.FString LabelMarkup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetButtonLabelSourceMarkup, "BmGame.GDGFxMovieUI_ButtonListBase.asSetButtonLabelSourceMarkup");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LabelMarkup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asPopulateButtonList;
    /// <summary>
    /// Function: asPopulateButtonList
    /// </summary>
    public unsafe virtual void asPopulateButtonList(int TextFocusColour, int TextNoFocusColour, int BGFocusColour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asPopulateButtonList, "BmGame.GDGFxMovieUI_ButtonListBase.asPopulateButtonList");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextFocusColour, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextNoFocusColour, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BGFocusColour, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDefaultOnAllButtonEntries;
    /// <summary>
    /// Function: SetDefaultOnAllButtonEntries
    /// </summary>
    public unsafe virtual void SetDefaultOnAllButtonEntries(BmSDK.GFxUI.GFxObject ButtonListObj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDefaultOnAllButtonEntries, "BmGame.GDGFxMovieUI_ButtonListBase.SetDefaultOnAllButtonEntries");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListObj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNewInitialValue;
    /// <summary>
    /// Function: SetNewInitialValue
    /// </summary>
    public unsafe virtual void SetNewInitialValue(BmSDK.GFxUI.GFxObject ButtonListObj, int ButtonIndex, int NewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNewInitialValue, "BmGame.GDGFxMovieUI_ButtonListBase.SetNewInitialValue");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListObj, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestoreInitialOptionValue;
    /// <summary>
    /// Function: RestoreInitialOptionValue
    /// </summary>
    public unsafe virtual void RestoreInitialOptionValue(BmSDK.GFxUI.GFxObject ButtonListObj, int ButtonIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreInitialOptionValue, "BmGame.GDGFxMovieUI_ButtonListBase.RestoreInitialOptionValue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListObj, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNumberOfVisibleListElements;
    /// <summary>
    /// Function: GetNumberOfVisibleListElements
    /// </summary>
    public unsafe virtual int GetNumberOfVisibleListElements(BmSDK.GFxUI.GFxObject ButtonListObj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumberOfVisibleListElements, "BmGame.GDGFxMovieUI_ButtonListBase.GetNumberOfVisibleListElements");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListObj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateButtonDataInList;
    /// <summary>
    /// Function: UpdateButtonDataInList
    /// </summary>
    public unsafe virtual void UpdateButtonDataInList(BmSDK.GFxUI.GFxObject ButtonListObj, int ButtonIndex, BmSDK.GFxUI.GFxObject ButtonData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateButtonDataInList, "BmGame.GDGFxMovieUI_ButtonListBase.UpdateButtonDataInList");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListObj, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonData, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearButtonList;
    /// <summary>
    /// Function: ClearButtonList
    /// </summary>
    public unsafe virtual void ClearButtonList(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.GFxUI.GFxObject ButtonListObj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearButtonList, "BmGame.GDGFxMovieUI_ButtonListBase.ClearButtonList");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListObj, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetAutoLocalisationForButtonLabel;
    /// <summary>
    /// Function: SetAutoLocalisationForButtonLabel
    /// </summary>
    public unsafe virtual void SetAutoLocalisationForButtonLabel(BmSDK.GFxUI.GFxObject ButtonListObj, bool bLocalise)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAutoLocalisationForButtonLabel, "BmGame.GDGFxMovieUI_ButtonListBase.SetAutoLocalisationForButtonLabel");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListObj, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLocalise, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetButtonLabelSourceMarkup;
    /// <summary>
    /// Function: SetButtonLabelSourceMarkup
    /// </summary>
    public unsafe virtual void SetButtonLabelSourceMarkup(BmSDK.GFxUI.GFxObject ButtonListObj, BmSDK.FString LabelMarkup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetButtonLabelSourceMarkup, "BmGame.GDGFxMovieUI_ButtonListBase.SetButtonLabelSourceMarkup");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListObj, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LabelMarkup, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateButtonList;
    /// <summary>
    /// Function: PopulateButtonList
    /// </summary>
    public unsafe virtual void PopulateButtonList(BmSDK.GFxUI.GFxObject ButtonListObj, int TextFocusColour, int TextNoFocusColour, int BGFocusColour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateButtonList, "BmGame.GDGFxMovieUI_ButtonListBase.PopulateButtonList");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListObj, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextFocusColour, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextNoFocusColour, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BGFocusColour, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressStart;
    /// <summary>
    /// Function: OnPressStart
    /// </summary>
    public unsafe virtual void OnPressStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressStart, "BmGame.GDGFxMovieUI_ButtonListBase.OnPressStart");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SecondaryOnButtonFocus;
    /// <summary>
    /// Function: SecondaryOnButtonFocus
    /// </summary>
    public unsafe virtual void SecondaryOnButtonFocus(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SecondaryOnButtonFocus, "BmGame.GDGFxMovieUI_ButtonListBase.SecondaryOnButtonFocus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLostFocus;
    /// <summary>
    /// Function: OnLostFocus
    /// </summary>
    public unsafe override void OnLostFocus(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLostFocus, "BmGame.GDGFxMovieUI_ButtonListBase.OnLostFocus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnButtonFocus;
    /// <summary>
    /// Function: OnButtonFocus
    /// </summary>
    public unsafe override void OnButtonFocus(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnButtonFocus, "BmGame.GDGFxMovieUI_ButtonListBase.OnButtonFocus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ListButtonLoseFocus;
    /// <summary>
    /// Function: ListButtonLoseFocus
    /// </summary>
    public unsafe virtual void ListButtonLoseFocus(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListButtonLoseFocus, "BmGame.GDGFxMovieUI_ButtonListBase.ListButtonLoseFocus");
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
    public unsafe virtual void ListButtonSetFocus(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListButtonSetFocus, "BmGame.GDGFxMovieUI_ButtonListBase.ListButtonSetFocus");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClicked;
    /// <summary>
    /// Function: OnClicked
    /// </summary>
    public unsafe override void OnClicked(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClicked, "BmGame.GDGFxMovieUI_ButtonListBase.OnClicked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmGame.GDGFxMovieUI_ButtonListBase.CloseScreen");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCustomisationColourPickerButton;
    /// <summary>
    /// Function: AddCustomisationColourPickerButton
    /// </summary>
    public unsafe virtual void AddCustomisationColourPickerButton(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.FString VarName, int Id, BmSDK.FString SelectAudio, BmSDK.FString PlatformsIgnore, int CustomisationFlags, int Colour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCustomisationColourPickerButton, "BmGame.GDGFxMovieUI_ButtonListBase.AddCustomisationColourPickerButton");
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectAudio, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomisationFlags, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Colour, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddStorePurchaseButton;
    /// <summary>
    /// Function: AddStorePurchaseButton
    /// </summary>
    public unsafe virtual void AddStorePurchaseButton(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.FString VarName, int Id, BmSDK.FString SelectAudio, BmSDK.FString PlatformsIgnore, int ItemCost)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddStorePurchaseButton, "BmGame.GDGFxMovieUI_ButtonListBase.AddStorePurchaseButton");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectAudio, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemCost, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddCustomisationButton;
    /// <summary>
    /// Function: AddCustomisationButton
    /// </summary>
    public unsafe virtual void AddCustomisationButton(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.FString VarName, int Id, BmSDK.FString SelectAudio, BmSDK.FString PlatformsIgnore, int CustomisationFlags, BmSDK.FString LocalisedLockedString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCustomisationButton, "BmGame.GDGFxMovieUI_ButtonListBase.AddCustomisationButton");
        byte* paramsPtr = stackalloc byte[236];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectAudio, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomisationFlags, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalisedLockedString, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddScoreboardTeamHeaderButton;
    /// <summary>
    /// Function: AddScoreboardTeamHeaderButton
    /// </summary>
    public unsafe virtual void AddScoreboardTeamHeaderButton(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.FString VarName, int Id, int Colour, BmSDK.FString PlatformsIgnore, BmSDK.FString TeamName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddScoreboardTeamHeaderButton, "BmGame.GDGFxMovieUI_ButtonListBase.AddScoreboardTeamHeaderButton");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Colour, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamName, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddScoreboardPlayerButton;
    /// <summary>
    /// Function: AddScoreboardPlayerButton
    /// </summary>
    public unsafe virtual void AddScoreboardPlayerButton(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.FString VarName, int Id, BmSDK.FString SelectAudio, BmSDK.FString PlatformsIgnore, int ButtonFlags, int LocalPlayerNoFocusColour, BmSDK.GFxUI.GFxObject PlayerKOData, BmSDK.GFxUI.GFxObject PlayerIconData, BmSDK.GFxUI.GFxObject PlayerXPData, BmSDK.GFxUI.GFxObject PlayerARData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddScoreboardPlayerButton, "BmGame.GDGFxMovieUI_ButtonListBase.AddScoreboardPlayerButton");
        byte* paramsPtr = stackalloc byte[244];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectAudio, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonFlags, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalPlayerNoFocusColour, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerKOData, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIconData, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerXPData, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerARData, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddLobbyConsumableButton;
    /// <summary>
    /// Function: AddLobbyConsumableButton
    /// </summary>
    public unsafe virtual void AddLobbyConsumableButton(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.FString VarName, int Id, BmSDK.FString SelectAudio, BmSDK.FString PlatformsIgnore, int NumConsumable, bool bConsumableUsed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLobbyConsumableButton, "BmGame.GDGFxMovieUI_ButtonListBase.AddLobbyConsumableButton");
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectAudio, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumConsumable, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bConsumableUsed, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddLobbyLoadoutButton;
    /// <summary>
    /// Function: AddLobbyLoadoutButton
    /// </summary>
    public unsafe virtual void AddLobbyLoadoutButton(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.FString VarName, int Id, BmSDK.FString SelectAudio, BmSDK.FString PlatformsIgnore, int LoadoutFlags)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLobbyLoadoutButton, "BmGame.GDGFxMovieUI_ButtonListBase.AddLobbyLoadoutButton");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectAudio, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutFlags, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddLobbyVoteButton;
    /// <summary>
    /// Function: AddLobbyVoteButton
    /// </summary>
    public unsafe virtual void AddLobbyVoteButton(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.FString VarName, int Id, BmSDK.FString SelectAudio, BmSDK.FString PlatformsIgnore, int VoteNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLobbyVoteButton, "BmGame.GDGFxMovieUI_ButtonListBase.AddLobbyVoteButton");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectAudio, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VoteNum, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddLobbyPlayerButton;
    /// <summary>
    /// Function: AddLobbyPlayerButton
    /// </summary>
    public unsafe virtual void AddLobbyPlayerButton(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.FString VarName, int Id, BmSDK.FString SelectAudio, BmSDK.FString PlatformsIgnore, int LobbyFlags, int LocalPlayerNoFocusColour, BmSDK.FString PlayerFaction, int FactionColour, BmSDK.GFxUI.GFxObject PlayerLevelData, BmSDK.GFxUI.GFxObject PlayerVOIPData, BmSDK.GFxUI.GFxObject PlayerARData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLobbyPlayerButton, "BmGame.GDGFxMovieUI_ButtonListBase.AddLobbyPlayerButton");
        byte* paramsPtr = stackalloc byte[256];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectAudio, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyFlags, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalPlayerNoFocusColour, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerFaction, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FactionColour, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLevelData, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerVOIPData, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerARData, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddHeaderButton;
    /// <summary>
    /// Function: AddHeaderButton
    /// </summary>
    public unsafe virtual void AddHeaderButton(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.FString VarName, int Id, int Colour, BmSDK.FString PlatformsIgnore)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddHeaderButton, "BmGame.GDGFxMovieUI_ButtonListBase.AddHeaderButton");
        byte* paramsPtr = stackalloc byte[212];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Colour, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddSliderButton;
    /// <summary>
    /// Function: AddSliderButton
    /// </summary>
    public unsafe virtual void AddSliderButton(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.FString VarName, int Id, bool bPlaySound, int StepPercent, BmSDK.FString PlatformsIgnore)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSliderButton, "BmGame.GDGFxMovieUI_ButtonListBase.AddSliderButton");
        byte* paramsPtr = stackalloc byte[216];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlaySound, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StepPercent, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddStepperButton;
    /// <summary>
    /// Function: AddStepperButton
    /// </summary>
    public unsafe virtual void AddStepperButton(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.FString VarName, int Id, BmSDK.FString StepperItemList, BmSDK.FString PlatformsIgnore, int BtnFlags = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddStepperButton, "BmGame.GDGFxMovieUI_ButtonListBase.AddStepperButton");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StepperItemList, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BtnFlags, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddPopupButton;
    /// <summary>
    /// Function: AddPopupButton
    /// </summary>
    public unsafe virtual void AddPopupButton(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.FString VarName, int Id, BmSDK.FString SelectAudio, BmSDK.FString PlatformsIgnore, int BtnFlags = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPopupButton, "BmGame.GDGFxMovieUI_ButtonListBase.AddPopupButton");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectAudio, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BtnFlags, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddCommandButton;
    /// <summary>
    /// Function: AddCommandButton
    /// </summary>
    public unsafe virtual void AddCommandButton(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.FString VarName, int Id, BmSDK.FString SelectAudio, BmSDK.FString PlatformsIgnore, int BtnFlags = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCommandButton, "BmGame.GDGFxMovieUI_ButtonListBase.AddCommandButton");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectAudio, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BtnFlags, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddCoreButtonData;
    /// <summary>
    /// Function: AddCoreButtonData
    /// </summary>
    public unsafe void AddCoreButtonData(out BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData BtnData, BmSDK.FString VarName, int Id, BmSDK.FString ButtonType, BmSDK.FString PlatformsIgnore, int BtnFlags, BmSDK.FString SelectAudio)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCoreButtonData, "BmGame.GDGFxMovieUI_ButtonListBase.AddCoreButtonData");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 152);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 164);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonType, paramsPtr + 168);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformsIgnore, paramsPtr + 180);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BtnFlags, paramsPtr + 192);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectAudio, paramsPtr + 196);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BtnData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetButtonIndexFromVariableName;
    /// <summary>
    /// Function: GetButtonIndexFromVariableName
    /// </summary>
    public unsafe virtual int GetButtonIndexFromVariableName(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> srcButtonList, BmSDK.FString VarName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetButtonIndexFromVariableName, "BmGame.GDGFxMovieUI_ButtonListBase.GetButtonIndexFromVariableName");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        srcButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetButtonIDFromVariableName;
    /// <summary>
    /// Function: GetButtonIDFromVariableName
    /// </summary>
    public unsafe virtual int GetButtonIDFromVariableName(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> srcButtonList, BmSDK.FString VarName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetButtonIDFromVariableName, "BmGame.GDGFxMovieUI_ButtonListBase.GetButtonIDFromVariableName");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        srcButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_IsButtonValidForThisPlatform;
    /// <summary>
    /// Function: IsButtonValidForThisPlatform
    /// </summary>
    public unsafe virtual bool IsButtonValidForThisPlatform(BmSDK.FString Platforms)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsButtonValidForThisPlatform, "BmGame.GDGFxMovieUI_ButtonListBase.IsButtonValidForThisPlatform");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Platforms, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PostAddButtonData;
    /// <summary>
    /// Function: PostAddButtonData
    /// </summary>
    public unsafe virtual bool PostAddButtonData(int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostAddButtonData, "BmGame.GDGFxMovieUI_ButtonListBase.PostAddButtonData");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PreAddButtonSpecificData;
    /// <summary>
    /// Function: PreAddButtonSpecificData
    /// </summary>
    public unsafe virtual bool PreAddButtonSpecificData(int ButtonIdx, out BmSDK.GFxUI.GFxObject ButtonDataObject)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreAddButtonSpecificData, "BmGame.GDGFxMovieUI_ButtonListBase.PreAddButtonSpecificData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ButtonDataObject);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonDataObject, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ButtonDataObject = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddButtonSpecificDataToObj;
    /// <summary>
    /// Function: AddButtonSpecificDataToObj
    /// </summary>
    public unsafe virtual void AddButtonSpecificDataToObj(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> srcButtonList, int ButtonIdx, out BmSDK.GFxUI.GFxObject ButtonDataObject)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddButtonSpecificDataToObj, "BmGame.GDGFxMovieUI_ButtonListBase.AddButtonSpecificDataToObj");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ButtonDataObject);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonDataObject, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        srcButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        ButtonDataObject = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_InitialiseButtonListData;
    /// <summary>
    /// Function: InitialiseButtonListData
    /// </summary>
    public unsafe virtual bool InitialiseButtonListData(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> srcButtonList, BmSDK.GFxUI.GFxObject ButtonListObj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseButtonListData, "BmGame.GDGFxMovieUI_ButtonListBase.InitialiseButtonListData");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListObj, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        srcButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetTooltipStringFromVarName;
    /// <summary>
    /// Function: GetTooltipStringFromVarName
    /// </summary>
    public unsafe virtual BmSDK.FString GetTooltipStringFromVarName(BmSDK.FString VariableName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTooltipStringFromVarName, "BmGame.GDGFxMovieUI_ButtonListBase.GetTooltipStringFromVarName");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetButtonListToolTip;
    /// <summary>
    /// Function: SetButtonListToolTip
    /// </summary>
    public unsafe virtual void SetButtonListToolTip(BmSDK.FString VariableName = default, BmSDK.FString StateName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetButtonListToolTip, "BmGame.GDGFxMovieUI_ButtonListBase.SetButtonListToolTip");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 12);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_PlayPrimaryListButtonSelectAudio;
    /// <summary>
    /// Function: PlayPrimaryListButtonSelectAudio
    /// </summary>
    public unsafe virtual void PlayPrimaryListButtonSelectAudio(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayPrimaryListButtonSelectAudio, "BmGame.GDGFxMovieUI_ButtonListBase.PlayPrimaryListButtonSelectAudio");
        byte* paramsPtr = stackalloc byte[32];
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
    public unsafe virtual void TriggerButtonPress(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerButtonPress, "BmGame.GDGFxMovieUI_ButtonListBase.TriggerButtonPress");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ListButtonPressY;
    /// <summary>
    /// Function: ListButtonPressY
    /// </summary>
    public unsafe virtual void ListButtonPressY(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListButtonPressY, "BmGame.GDGFxMovieUI_ButtonListBase.ListButtonPressY");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ListButtonPressX;
    /// <summary>
    /// Function: ListButtonPressX
    /// </summary>
    public unsafe virtual void ListButtonPressX(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListButtonPressX, "BmGame.GDGFxMovieUI_ButtonListBase.ListButtonPressX");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetButtonVarData;
    /// <summary>
    /// Function: SetButtonVarData
    /// </summary>
    public unsafe virtual void SetButtonVarData(BmSDK.FString VariableName, float VarVal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetButtonVarData, "BmGame.GDGFxMovieUI_ButtonListBase.SetButtonVarData");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarVal, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDefaultButtonVarData;
    /// <summary>
    /// Function: GetDefaultButtonVarData
    /// </summary>
    public unsafe virtual int GetDefaultButtonVarData(BmSDK.FString VariableName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultButtonVarData, "BmGame.GDGFxMovieUI_ButtonListBase.GetDefaultButtonVarData");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetCurrentButtonVarData;
    /// <summary>
    /// Function: GetCurrentButtonVarData
    /// </summary>
    public unsafe virtual int GetCurrentButtonVarData(BmSDK.FString VariableName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentButtonVarData, "BmGame.GDGFxMovieUI_ButtonListBase.GetCurrentButtonVarData");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RequestScreenTitleMarkupData;
    /// <summary>
    /// Function: RequestScreenTitleMarkupData
    /// </summary>
    public unsafe virtual BmSDK.FString RequestScreenTitleMarkupData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestScreenTitleMarkupData, "BmGame.GDGFxMovieUI_ButtonListBase.RequestScreenTitleMarkupData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AddUScriptDeclaredButtonData;
    /// <summary>
    /// Function: AddUScriptDeclaredButtonData
    /// </summary>
    public unsafe virtual void AddUScriptDeclaredButtonData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUScriptDeclaredButtonData, "BmGame.GDGFxMovieUI_ButtonListBase.AddUScriptDeclaredButtonData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateButtonListData;
    /// <summary>
    /// Function: PopulateButtonListData
    /// </summary>
    public unsafe virtual void PopulateButtonListData(out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> outButtonList, BmSDK.GFxUI.GFxObject ButtonListObj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateButtonListData, "BmGame.GDGFxMovieUI_ButtonListBase.PopulateButtonListData");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListObj, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outButtonList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrimaryButtonListLabelMarkupSource;
    /// <summary>
    /// Function: SetPrimaryButtonListLabelMarkupSource
    /// </summary>
    public unsafe virtual void SetPrimaryButtonListLabelMarkupSource()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrimaryButtonListLabelMarkupSource, "BmGame.GDGFxMovieUI_ButtonListBase.SetPrimaryButtonListLabelMarkupSource");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestButtonListData;
    /// <summary>
    /// Function: RequestButtonListData
    /// </summary>
    public unsafe virtual void RequestButtonListData(BmSDK.FString ButtonListID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestButtonListData, "BmGame.GDGFxMovieUI_ButtonListBase.RequestButtonListData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListID, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.GDGFxMovieUI_ButtonListBase.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StrProperty: DefaultButtonPressAudio
    /// </summary>
    public unsafe BmSDK.FString DefaultButtonPressAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// StrProperty: ScreenTitleMarkup
    /// </summary>
    public unsafe BmSDK.FString ScreenTitleMarkup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// ArrayProperty: PrimaryListOptions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData> PrimaryListOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FButtonListOptionData>>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// StrProperty: CommandButtonName
    /// </summary>
    public unsafe BmSDK.FString CommandButtonName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// StrProperty: PopupButtonName
    /// </summary>
    public unsafe BmSDK.FString PopupButtonName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }

    /// <summary>
    /// StrProperty: StepperButtonName
    /// </summary>
    public unsafe BmSDK.FString StepperButtonName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }

    /// <summary>
    /// StrProperty: SliderButtonName
    /// </summary>
    public unsafe BmSDK.FString SliderButtonName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// StrProperty: HeaderButtonName
    /// </summary>
    public unsafe BmSDK.FString HeaderButtonName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// StrProperty: LobbyVoteButtonName
    /// </summary>
    public unsafe BmSDK.FString LobbyVoteButtonName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// StrProperty: LobbyPlayerButtonName
    /// </summary>
    public unsafe BmSDK.FString LobbyPlayerButtonName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// StrProperty: LobbyLoadoutButtonName
    /// </summary>
    public unsafe BmSDK.FString LobbyLoadoutButtonName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// StrProperty: LobbyConsumableButtonName
    /// </summary>
    public unsafe BmSDK.FString LobbyConsumableButtonName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// StrProperty: ScoreboardButtonName
    /// </summary>
    public unsafe BmSDK.FString ScoreboardButtonName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// StrProperty: ScoreboardTeamHeaderName
    /// </summary>
    public unsafe BmSDK.FString ScoreboardTeamHeaderName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }
    }

    /// <summary>
    /// StrProperty: LoadoutButtonName
    /// </summary>
    public unsafe BmSDK.FString LoadoutButtonName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// StrProperty: StorePuchaseButtonName
    /// </summary>
    public unsafe BmSDK.FString StorePuchaseButtonName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }

    /// <summary>
    /// StrProperty: LoadoutColourPickerButtonName
    /// </summary>
    public unsafe BmSDK.FString LoadoutColourPickerButtonName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// ObjectProperty: CurrentASButtonListObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject CurrentASButtonListObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// ObjectProperty: PrimaryButtonListObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject PrimaryButtonListObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// ObjectProperty: CurrPlayerLevelBoxObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject CurrPlayerLevelBoxObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// ObjectProperty: GothamBucksbox
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject GothamBucksbox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }

    /// <summary>
    /// IntProperty: ColourTextFocus
    /// </summary>
    public unsafe int ColourTextFocus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// IntProperty: ColourTextNoFocus
    /// </summary>
    public unsafe int ColourTextNoFocus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// IntProperty: ColourBackgroundFocus
    /// </summary>
    public unsafe int ColourBackgroundFocus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// IntProperty: ColourDisabledButtonText
    /// </summary>
    public unsafe int ColourDisabledButtonText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// IntProperty: ColourWhite
    /// </summary>
    public unsafe int ColourWhite
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// IntProperty: ColourBlack
    /// </summary>
    public unsafe int ColourBlack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// IntProperty: ColourRed
    /// </summary>
    public unsafe int ColourRed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// IntProperty: ColourGreen
    /// </summary>
    public unsafe int ColourGreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }

    /// <summary>
    /// IntProperty: ColourBlue
    /// </summary>
    public unsafe int ColourBlue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }

    /// <summary>
    /// NameProperty: ProfileKey_FirstBoot
    /// </summary>
    public unsafe BmSDK.FName ProfileKey_FirstBoot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// NameProperty: ProfileKey_IPOVideoWatched
    /// </summary>
    public unsafe BmSDK.FName ProfileKey_IPOVideoWatched
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// NameProperty: ProfileKey_HHVideoWatched
    /// </summary>
    public unsafe BmSDK.FName ProfileKey_HHVideoWatched
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// NameProperty: ProfileKey_JokerIndoc1VideoWatched
    /// </summary>
    public unsafe BmSDK.FName ProfileKey_JokerIndoc1VideoWatched
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// NameProperty: ProfileKey_JokerIndoc2VideoWatched
    /// </summary>
    public unsafe BmSDK.FName ProfileKey_JokerIndoc2VideoWatched
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// NameProperty: ProfileKey_BaneIndoc1VideoWatched
    /// </summary>
    public unsafe BmSDK.FName ProfileKey_BaneIndoc1VideoWatched
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2004); }
    }

    /// <summary>
    /// NameProperty: ProfileKey_BaneIndoc2VideoWatched
    /// </summary>
    public unsafe BmSDK.FName ProfileKey_BaneIndoc2VideoWatched
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// IntProperty: LastSelectedButtonIdx
    /// </summary>
    public unsafe int LastSelectedButtonIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// StrProperty: LastSelectedButtonVarName
    /// </summary>
    public unsafe BmSDK.FString LastSelectedButtonVarName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// Struct: FButtonListOptionData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 152)]
    public partial record struct FButtonListOptionData
    {
        /// <summary>
        /// StrProperty: VariableName
        /// </summary>
        public unsafe BmSDK.FString VariableName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ButtonOptionID
        /// </summary>
        public unsafe int ButtonOptionID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: ButtonType
        /// </summary>
        public unsafe BmSDK.FString ButtonType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: PlatformsToIgnore
        /// </summary>
        public unsafe BmSDK.FString PlatformsToIgnore
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StrProperty: CommandStr
        /// </summary>
        public unsafe BmSDK.FString CommandStr
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: StateFlags
        /// </summary>
        public unsafe int StateFlags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// StrProperty: SelectAudioMarkup
        /// </summary>
        public unsafe BmSDK.FString SelectAudioMarkup
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// IntProperty: MultipurposeInt
        /// </summary>
        public unsafe int MultipurposeInt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// StrProperty: MultipurposeString
        /// </summary>
        public unsafe BmSDK.FString MultipurposeString
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: MultipurposeBool
        /// </summary>
        public unsafe bool MultipurposeBool
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// IntProperty: Colour
        /// </summary>
        public unsafe int Colour
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// StructProperty: LobbyPlayerButtonData
        /// </summary>
        public unsafe BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FstrLobbyPlayerButtonData LobbyPlayerButtonData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FstrLobbyPlayerButtonData>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// StructProperty: ScoreboardData
        /// </summary>
        public unsafe BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FstrScoreboardPlayerButtonData ScoreboardData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_ButtonListBase.FstrScoreboardPlayerButtonData>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }
    }

    /// <summary>
    /// Struct: FstrScoreboardPlayerButtonData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FstrScoreboardPlayerButtonData
    {
        /// <summary>
        /// IntProperty: ScoreboardStateFlags
        /// </summary>
        public unsafe int ScoreboardStateFlags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: LocalPlayerNoFocusColour
        /// </summary>
        public unsafe int LocalPlayerNoFocusColour
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: ButtonPlayerKDInfo
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject ButtonPlayerKDInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: ButtonPlayerIconInfo
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject ButtonPlayerIconInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: ButtonPlayerXPInfo
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject ButtonPlayerXPInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: ButtonPlayerARInfo
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject ButtonPlayerARInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FstrLobbyPlayerButtonData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FstrLobbyPlayerButtonData
    {
        /// <summary>
        /// IntProperty: LobbyStateFlags
        /// </summary>
        public unsafe int LobbyStateFlags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: LocalPlayerNoFocusColour
        /// </summary>
        public unsafe int LocalPlayerNoFocusColour
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: ButtonPlayerLevelInfo
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject ButtonPlayerLevelInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: ButtonPlayerVOIPInfo
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject ButtonPlayerVOIPInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: ButtonPlayerARInfo
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject ButtonPlayerARInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: PlayerFactionName
        /// </summary>
        public unsafe BmSDK.FString PlayerFactionName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: PlayerFactionColour
        /// </summary>
        public unsafe int PlayerFactionColour
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FSUnlockIconData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FSUnlockIconData
    {
        /// <summary>
        /// StrProperty: IconName
        /// </summary>
        public unsafe BmSDK.FString IconName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: IconPackage
        /// </summary>
        public unsafe BmSDK.FString IconPackage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }
}
