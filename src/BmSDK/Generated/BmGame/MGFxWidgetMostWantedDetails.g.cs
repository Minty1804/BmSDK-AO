#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MGFxWidgetMostWantedDetails<br/>
/// (size = 340)
/// (flags = 134217874)
/// </summary>
public partial class MGFxWidgetMostWantedDetails : BmSDK.BmGame.MGFxWidget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MGFxWidgetMostWantedDetails", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGFxWidgetMostWantedDetails.
    /// </summary>
    public static MGFxWidgetMostWantedDetails DefaultObject => (MGFxWidgetMostWantedDetails)StaticClass().DefaultObject;

    internal MGFxWidgetMostWantedDetails() { }

    /// <summary>
    /// Constructs a new MGFxWidgetMostWantedDetails
    /// </summary>
    public MGFxWidgetMostWantedDetails(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxWidgetMostWantedDetails Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxWidgetMostWantedDetails(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMostWantedDetails>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMostWantedDetails>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMostWantedDetails>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMostWantedDetails>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMostWantedDetails>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMostWantedDetails>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMostWantedDetails>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMostWantedDetails>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetDefaultPrompts;
    /// <summary>
    /// Function: SetDefaultPrompts
    /// </summary>
    public unsafe virtual void SetDefaultPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDefaultPrompts, "BmGame.MGFxWidgetMostWantedDetails.SetDefaultPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Terminate;
    /// <summary>
    /// Function: Terminate
    /// </summary>
    public unsafe virtual void Terminate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Terminate, "BmGame.MGFxWidgetMostWantedDetails.Terminate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayDataHandlerRevealStep2;
    /// <summary>
    /// Function: PlayDataHandlerRevealStep2
    /// </summary>
    public unsafe virtual void PlayDataHandlerRevealStep2()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDataHandlerRevealStep2, "BmGame.MGFxWidgetMostWantedDetails.PlayDataHandlerRevealStep2");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayDataHandlerRevealStep1;
    /// <summary>
    /// Function: PlayDataHandlerRevealStep1
    /// </summary>
    public unsafe virtual void PlayDataHandlerRevealStep1()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDataHandlerRevealStep1, "BmGame.MGFxWidgetMostWantedDetails.PlayDataHandlerRevealStep1");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowHQ;
    /// <summary>
    /// Function: ShowHQ
    /// </summary>
    public unsafe virtual void ShowHQ()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowHQ, "BmGame.MGFxWidgetMostWantedDetails.ShowHQ");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMiniMap;
    /// <summary>
    /// Function: UpdateMiniMap
    /// </summary>
    public unsafe virtual void UpdateMiniMap(int District)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMiniMap, "BmGame.MGFxWidgetMostWantedDetails.UpdateMiniMap");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(District, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueMostWantedHitCheck;
    /// <summary>
    /// Function: QueueMostWantedHitCheck
    /// </summary>
    public unsafe virtual void QueueMostWantedHitCheck()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueMostWantedHitCheck, "BmGame.MGFxWidgetMostWantedDetails.QueueMostWantedHitCheck");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadMostWantedCursor;
    /// <summary>
    /// Function: LoadMostWantedCursor
    /// </summary>
    public unsafe virtual void LoadMostWantedCursor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadMostWantedCursor, "BmGame.MGFxWidgetMostWantedDetails.LoadMostWantedCursor");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCursorState;
    /// <summary>
    /// Function: SetCursorState
    /// </summary>
    public unsafe virtual void SetCursorState(bool bVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCursorState, "BmGame.MGFxWidgetMostWantedDetails.SetCursorState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushListData;
    /// <summary>
    /// Function: PushListData
    /// </summary>
    public unsafe virtual void PushListData(BmSDK.GFxUI.GFxObject Target, BmSDK.TArray<BmSDK.FString> listData, int mostWantedState, int selected, BmSDK.FString listTitle, BmSDK.TArray<BmSDK.FString> States)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushListData, "BmGame.MGFxWidgetMostWantedDetails.PushListData");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(listData, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mostWantedState, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(selected, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(listTitle, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(States, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadEnigmaSubScreen;
    /// <summary>
    /// Function: LoadEnigmaSubScreen
    /// </summary>
    public unsafe virtual void LoadEnigmaSubScreen(BmSDK.BmGame.MGFxWidgetMostWantedDetails.E_EnigmaSubMenus State)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadEnigmaSubScreen, "BmGame.MGFxWidgetMostWantedDetails.LoadEnigmaSubScreen");
        byte* paramsPtr = stackalloc byte[137];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadCriminalInfo;
    /// <summary>
    /// Function: LoadCriminalInfo
    /// </summary>
    public unsafe virtual bool LoadCriminalInfo(BmSDK.BmGame.MMostWantedSystem.E_MostWantedCriminal criminalToLoad)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadCriminalInfo, "BmGame.MGFxWidgetMostWantedDetails.LoadCriminalInfo");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(criminalToLoad, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SelectEnigmaSubMenuItem;
    /// <summary>
    /// Function: SelectEnigmaSubMenuItem
    /// </summary>
    public unsafe virtual void SelectEnigmaSubMenuItem(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectEnigmaSubMenuItem, "BmGame.MGFxWidgetMostWantedDetails.SelectEnigmaSubMenuItem");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPackInside;
    /// <summary>
    /// Function: IsPackInside
    /// </summary>
    public unsafe virtual bool IsPackInside(BmSDK.FString PackId, out BmSDK.FString locName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPackInside, "BmGame.MGFxWidgetMostWantedDetails.IsPackInside");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        locName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ChangeSubSelector;
    /// <summary>
    /// Function: ChangeSubSelector
    /// </summary>
    public unsafe virtual void ChangeSubSelector(int Direction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeSubSelector, "BmGame.MGFxWidgetMostWantedDetails.ChangeSubSelector");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsEnigmaDetails;
    /// <summary>
    /// Function: IsEnigmaDetails
    /// </summary>
    public unsafe virtual bool IsEnigmaDetails()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsEnigmaDetails, "BmGame.MGFxWidgetMostWantedDetails.IsEnigmaDetails");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateEnigmaProgressWidget;
    /// <summary>
    /// Function: UpdateEnigmaProgressWidget
    /// </summary>
    public unsafe virtual void UpdateEnigmaProgressWidget(int listId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateEnigmaProgressWidget, "BmGame.MGFxWidgetMostWantedDetails.UpdateEnigmaProgressWidget");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(listId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCriminalProgress;
    /// <summary>
    /// Function: UpdateCriminalProgress
    /// </summary>
    public unsafe virtual void UpdateCriminalProgress(BmSDK.BmGame.MMostWantedSystem.FCriminalInfo CRIMINAL, int criminalId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCriminalProgress, "BmGame.MGFxWidgetMostWantedDetails.UpdateCriminalProgress");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CRIMINAL, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(criminalId, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateEnigmaSubMenu;
    /// <summary>
    /// Function: UpdateEnigmaSubMenu
    /// </summary>
    public unsafe virtual void UpdateEnigmaSubMenu(int enigmaState, int Length, int selectedIndex, BmSDK.TArray<int> itemStates)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateEnigmaSubMenu, "BmGame.MGFxWidgetMostWantedDetails.UpdateEnigmaSubMenu");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(enigmaState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Length, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(selectedIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(itemStates, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ListChangedCallback;
    /// <summary>
    /// Function: ListChangedCallback
    /// </summary>
    public unsafe virtual void ListChangedCallback(int listId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListChangedCallback, "BmGame.MGFxWidgetMostWantedDetails.ListChangedCallback");
        byte* paramsPtr = stackalloc byte[153];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(listId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ItemSelectedCallback;
    /// <summary>
    /// Function: ItemSelectedCallback
    /// </summary>
    public unsafe virtual void ItemSelectedCallback(int listId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemSelectedCallback, "BmGame.MGFxWidgetMostWantedDetails.ItemSelectedCallback");
        byte* paramsPtr = stackalloc byte[45];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(listId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetActive;
    /// <summary>
    /// Function: SetActive
    /// </summary>
    public unsafe virtual void SetActive(int NextState, int enigmaSubState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActive, "BmGame.MGFxWidgetMostWantedDetails.SetActive");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(enigmaSubState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnloadMostWanted;
    /// <summary>
    /// Function: UnloadMostWanted
    /// </summary>
    public unsafe virtual void UnloadMostWanted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnloadMostWanted, "BmGame.MGFxWidgetMostWantedDetails.UnloadMostWanted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadCriminal;
    /// <summary>
    /// Function: LoadCriminal
    /// </summary>
    public unsafe virtual void LoadCriminal(BmSDK.BmGame.MMostWantedSystem.E_MostWantedCriminal Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadCriminal, "BmGame.MGFxWidgetMostWantedDetails.LoadCriminal");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadMostWanted;
    /// <summary>
    /// Function: LoadMostWanted
    /// </summary>
    public unsafe virtual void LoadMostWanted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadMostWanted, "BmGame.MGFxWidgetMostWantedDetails.LoadMostWanted");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyEventListeners;
    /// <summary>
    /// Function: DestroyEventListeners
    /// </summary>
    public unsafe virtual void DestroyEventListeners()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyEventListeners, "BmGame.MGFxWidgetMostWantedDetails.DestroyEventListeners");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupEventListeners;
    /// <summary>
    /// Function: SetupEventListeners
    /// </summary>
    public unsafe virtual void SetupEventListeners()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupEventListeners, "BmGame.MGFxWidgetMostWantedDetails.SetupEventListeners");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WidgetInitComplete;
    /// <summary>
    /// Function: WidgetInitComplete
    /// </summary>
    public unsafe virtual void WidgetInitComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetInitComplete, "BmGame.MGFxWidgetMostWantedDetails.WidgetInitComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.BmGame.RGameInfo pRGI, BmSDK.BmGame.MGFxMovieControllerBCScreen parentMovieController)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.MGFxWidgetMostWantedDetails.Init");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pRGI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(parentMovieController, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WidgetUnloaded;
    /// <summary>
    /// Function: WidgetUnloaded
    /// </summary>
    public unsafe override bool WidgetUnloaded(BmSDK.FName WidgetName, BmSDK.FName WidgetPath, BmSDK.GFxUI.GFxObject Widget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetUnloaded, "BmGame.MGFxWidgetMostWantedDetails.WidgetUnloaded");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_WidgetInitialized;
    /// <summary>
    /// Function: WidgetInitialized
    /// </summary>
    public unsafe override bool WidgetInitialized(BmSDK.FName WidgetName, BmSDK.FName WidgetPath, BmSDK.GFxUI.GFxObject Widget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetInitialized, "BmGame.MGFxWidgetMostWantedDetails.WidgetInitialized");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// IntProperty: CurrentState
    /// </summary>
    public unsafe int CurrentState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// IntProperty: CurrentEnigmaSubState
    /// </summary>
    public unsafe int CurrentEnigmaSubState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// IntProperty: CurrentCriminal
    /// </summary>
    public unsafe int CurrentCriminal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// IntProperty: SubSelectorIndex
    /// </summary>
    public unsafe int SubSelectorIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// IntProperty: CurrentSetLength
    /// </summary>
    public unsafe int CurrentSetLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// IntProperty: CurrentSubMenuIndex
    /// </summary>
    public unsafe int CurrentSubMenuIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// IntProperty: CurrentEnigmaDetailsState
    /// </summary>
    public unsafe int CurrentEnigmaDetailsState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// IntProperty: DistrictToLoad
    /// </summary>
    public unsafe int DistrictToLoad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// IntProperty: CurrentListLength
    /// </summary>
    public unsafe int CurrentListLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ObjectProperty: MostWantedOverlay
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject MostWantedOverlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ObjectProperty: ProgressRef
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject ProgressRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ObjectProperty: CursorRef
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject CursorRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ObjectProperty: PromptManagerRef
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidgetPromptManager PromptManagerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidgetPromptManager>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ObjectProperty: MapSystem
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidgetMapSystem MapSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidgetMapSystem>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// ObjectProperty: MostWantedControllerRef
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxMovieControllerMostWanted MostWantedControllerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxMovieControllerMostWanted>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ObjectProperty: InfoDescriptionBar
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidgetDescriptionBar InfoDescriptionBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidgetDescriptionBar>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// ObjectProperty: MugShotImage
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidgetImage MugShotImage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidgetImage>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// ObjectProperty: ArrowUp
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject ArrowUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// ObjectProperty: ArrowDown
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject ArrowDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ArrayProperty: LocCriminalNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LocCriminalNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// ArrayProperty: CurrentDataSet
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CurrentDataSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bRevealAnimToPlay
    /// </summary>
    public unsafe bool bRevealAnimToPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: bListChanged
    /// </summary>
    public unsafe bool bListChanged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: bCanMarkSet
    /// </summary>
    public unsafe bool bCanMarkSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: bCanSetCurrentObjective
    /// </summary>
    public unsafe bool bCanSetCurrentObjective
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// Enum: E_EnigmaSelectionStates
    /// </summary>
    public enum E_EnigmaSelectionStates : byte
    {
        MWSS_Enigma_SpyNetwork = 0,
        MWSS_Enigma_DataSets = 1,
        MWSS_Enigma_MAX = 2,
    }

    /// <summary>
    /// Enum: E_EnigmaSubMenus
    /// </summary>
    public enum E_EnigmaSubMenus : byte
    {
        MW_Enigma_Overview = 0,
        MW_Enigma_Details = 1,
        MW_Enigma_MAX = 2,
    }

    /// <summary>
    /// Enum: E_MostWantedStates
    /// </summary>
    public enum E_MostWantedStates : byte
    {
        MWS_Enigma = 0,
        MWS_Criminal = 1,
        MWS_MAX = 2,
    }
}
