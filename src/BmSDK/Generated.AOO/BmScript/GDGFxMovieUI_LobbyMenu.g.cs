#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: GDGFxMovieUI_LobbyMenu<br/>
/// (size = 2404)
/// (flags = 32790)
/// </summary>
public partial class GDGFxMovieUI_LobbyMenu : BmSDK.BmScript.GDGFxMovieUI_LobbyBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.GDGFxMovieUI_LobbyMenu", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGFxMovieUI_LobbyMenu.
    /// </summary>
    public static GDGFxMovieUI_LobbyMenu DefaultObject => (GDGFxMovieUI_LobbyMenu)StaticClass().DefaultObject;

    internal GDGFxMovieUI_LobbyMenu() { }

    /// <summary>
    /// Constructs a new GDGFxMovieUI_LobbyMenu
    /// </summary>
    public GDGFxMovieUI_LobbyMenu(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDGFxMovieUI_LobbyMenu Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGFxMovieUI_LobbyMenu(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyMenu>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyMenu>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyMenu>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyMenu>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyMenu>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyMenu>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyMenu>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyMenu>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UnMutePlayer;
    /// <summary>
    /// Function: UnMutePlayer
    /// </summary>
    public unsafe void UnMutePlayer(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnMutePlayer, "BmScript.GDGFxMovieUI_LobbyMenu.UnMutePlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MutePlayer;
    /// <summary>
    /// Function: MutePlayer
    /// </summary>
    public unsafe void MutePlayer(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MutePlayer, "BmScript.GDGFxMovieUI_LobbyMenu.MutePlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBackgroundUpdate;
    /// <summary>
    /// Function: OnBackgroundUpdate
    /// </summary>
    public unsafe virtual void OnBackgroundUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBackgroundUpdate, "BmScript.GDGFxMovieUI_LobbyMenu.OnBackgroundUpdate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupScreenPrompts;
    /// <summary>
    /// Function: SetupScreenPrompts
    /// </summary>
    public unsafe override void SetupScreenPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupScreenPrompts, "BmScript.GDGFxMovieUI_LobbyMenu.SetupScreenPrompts");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshScreenPromptOnLoadoutListFocus;
    /// <summary>
    /// Function: RefreshScreenPromptOnLoadoutListFocus
    /// </summary>
    public unsafe virtual void RefreshScreenPromptOnLoadoutListFocus(int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshScreenPromptOnLoadoutListFocus, "BmScript.GDGFxMovieUI_LobbyMenu.RefreshScreenPromptOnLoadoutListFocus");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshScreenPromptOnPlayerListFocus;
    /// <summary>
    /// Function: RefreshScreenPromptOnPlayerListFocus
    /// </summary>
    public unsafe virtual void RefreshScreenPromptOnPlayerListFocus(int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshScreenPromptOnPlayerListFocus, "BmScript.GDGFxMovieUI_LobbyMenu.RefreshScreenPromptOnPlayerListFocus");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLoadoutSelectionBoxData;
    /// <summary>
    /// Function: SetLoadoutSelectionBoxData
    /// </summary>
    public unsafe void SetLoadoutSelectionBoxData(int LoadoutIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLoadoutSelectionBoxData, "BmScript.GDGFxMovieUI_LobbyMenu.SetLoadoutSelectionBoxData");
        byte* paramsPtr = stackalloc byte[192];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePlayerLoadoutTabData;
    /// <summary>
    /// Function: UpdatePlayerLoadoutTabData
    /// </summary>
    public unsafe int UpdatePlayerLoadoutTabData(int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePlayerLoadoutTabData, "BmScript.GDGFxMovieUI_LobbyMenu.UpdatePlayerLoadoutTabData");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HandleButtonPressInMapVoteMode;
    /// <summary>
    /// Function: HandleButtonPressInMapVoteMode
    /// </summary>
    public unsafe bool HandleButtonPressInMapVoteMode(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleButtonPressInMapVoteMode, "BmScript.GDGFxMovieUI_LobbyMenu.HandleButtonPressInMapVoteMode");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_HandleButtonPressInLoadoutListMode;
    /// <summary>
    /// Function: HandleButtonPressInLoadoutListMode
    /// </summary>
    public unsafe bool HandleButtonPressInLoadoutListMode(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleButtonPressInLoadoutListMode, "BmScript.GDGFxMovieUI_LobbyMenu.HandleButtonPressInLoadoutListMode");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_DeactivateAndRemoveAnyUsedConsumable;
    /// <summary>
    /// Function: DeactivateAndRemoveAnyUsedConsumable
    /// </summary>
    public unsafe void DeactivateAndRemoveAnyUsedConsumable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateAndRemoveAnyUsedConsumable, "BmScript.GDGFxMovieUI_LobbyMenu.DeactivateAndRemoveAnyUsedConsumable");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleButtonPressInConsumableMode;
    /// <summary>
    /// Function: HandleButtonPressInConsumableMode
    /// </summary>
    public unsafe bool HandleButtonPressInConsumableMode(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleButtonPressInConsumableMode, "BmScript.GDGFxMovieUI_LobbyMenu.HandleButtonPressInConsumableMode");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_HandleButtonPressInPlayerListMode;
    /// <summary>
    /// Function: HandleButtonPressInPlayerListMode
    /// </summary>
    public unsafe bool HandleButtonPressInPlayerListMode(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleButtonPressInPlayerListMode, "BmScript.GDGFxMovieUI_LobbyMenu.HandleButtonPressInPlayerListMode");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_TriggerButtonPress;
    /// <summary>
    /// Function: TriggerButtonPress
    /// </summary>
    public unsafe override void TriggerButtonPress(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerButtonPress, "BmScript.GDGFxMovieUI_LobbyMenu.TriggerButtonPress");
        byte* paramsPtr = stackalloc byte[36];
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
    public unsafe override void ListButtonPressY(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListButtonPressY, "BmScript.GDGFxMovieUI_LobbyMenu.ListButtonPressY");
        byte* paramsPtr = stackalloc byte[240];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleButtonFocusInConsumablesListMode;
    /// <summary>
    /// Function: HandleButtonFocusInConsumablesListMode
    /// </summary>
    public unsafe void HandleButtonFocusInConsumablesListMode(int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleButtonFocusInConsumablesListMode, "BmScript.GDGFxMovieUI_LobbyMenu.HandleButtonFocusInConsumablesListMode");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleButtonFocusInMapVoteListMode;
    /// <summary>
    /// Function: HandleButtonFocusInMapVoteListMode
    /// </summary>
    public unsafe void HandleButtonFocusInMapVoteListMode(int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleButtonFocusInMapVoteListMode, "BmScript.GDGFxMovieUI_LobbyMenu.HandleButtonFocusInMapVoteListMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleButtonFocusInLoadoutListMode;
    /// <summary>
    /// Function: HandleButtonFocusInLoadoutListMode
    /// </summary>
    public unsafe void HandleButtonFocusInLoadoutListMode(int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleButtonFocusInLoadoutListMode, "BmScript.GDGFxMovieUI_LobbyMenu.HandleButtonFocusInLoadoutListMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleButtonFocusInPlayerListMode;
    /// <summary>
    /// Function: HandleButtonFocusInPlayerListMode
    /// </summary>
    public unsafe void HandleButtonFocusInPlayerListMode(int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleButtonFocusInPlayerListMode, "BmScript.GDGFxMovieUI_LobbyMenu.HandleButtonFocusInPlayerListMode");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListButtonLoseFocus, "BmScript.GDGFxMovieUI_LobbyMenu.ListButtonLoseFocus");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListButtonSetFocus, "BmScript.GDGFxMovieUI_LobbyMenu.ListButtonSetFocus");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmScript.GDGFxMovieUI_LobbyMenu.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLobbyInformationPanelOnListUpdate;
    /// <summary>
    /// Function: SetLobbyInformationPanelOnListUpdate
    /// </summary>
    public unsafe void SetLobbyInformationPanelOnListUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLobbyInformationPanelOnListUpdate, "BmScript.GDGFxMovieUI_LobbyMenu.SetLobbyInformationPanelOnListUpdate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateLobbyList;
    /// <summary>
    /// Function: PopulateLobbyList
    /// </summary>
    public unsafe void PopulateLobbyList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateLobbyList, "BmScript.GDGFxMovieUI_LobbyMenu.PopulateLobbyList");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLobbyListType;
    /// <summary>
    /// Function: SetLobbyListType
    /// </summary>
    public unsafe void SetLobbyListType(BmSDK.BmScript.GDGFxMovieUI_LobbyMenu.LobbyMenuListType ListType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLobbyListType, "BmScript.GDGFxMovieUI_LobbyMenu.SetLobbyListType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ListType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CycleLobbyListType;
    /// <summary>
    /// Function: CycleLobbyListType
    /// </summary>
    public unsafe virtual void CycleLobbyListType(bool bLeft)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CycleLobbyListType, "BmScript.GDGFxMovieUI_LobbyMenu.CycleLobbyListType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeft, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ListLeftTrigger;
    /// <summary>
    /// Function: ListLeftTrigger
    /// </summary>
    public unsafe virtual void ListLeftTrigger(BmSDK.FString ListID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListLeftTrigger, "BmScript.GDGFxMovieUI_LobbyMenu.ListLeftTrigger");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ListID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ListRightTrigger;
    /// <summary>
    /// Function: ListRightTrigger
    /// </summary>
    public unsafe virtual void ListRightTrigger(BmSDK.FString ListID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListRightTrigger, "BmScript.GDGFxMovieUI_LobbyMenu.ListRightTrigger");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ListID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressMapVote;
    /// <summary>
    /// Function: OnPressMapVote
    /// </summary>
    public unsafe virtual void OnPressMapVote()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressMapVote, "BmScript.GDGFxMovieUI_LobbyMenu.OnPressMapVote");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressLoadouts;
    /// <summary>
    /// Function: OnPressLoadouts
    /// </summary>
    public unsafe virtual void OnPressLoadouts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressLoadouts, "BmScript.GDGFxMovieUI_LobbyMenu.OnPressLoadouts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressConsumables;
    /// <summary>
    /// Function: OnPressConsumables
    /// </summary>
    public unsafe virtual void OnPressConsumables()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressConsumables, "BmScript.GDGFxMovieUI_LobbyMenu.OnPressConsumables");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPressPlayers;
    /// <summary>
    /// Function: OnPressPlayers
    /// </summary>
    public unsafe virtual void OnPressPlayers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPressPlayers, "BmScript.GDGFxMovieUI_LobbyMenu.OnPressPlayers");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndOfMapVote;
    /// <summary>
    /// Function: EndOfMapVote
    /// </summary>
    public unsafe override void EndOfMapVote()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndOfMapVote, "BmScript.GDGFxMovieUI_LobbyMenu.EndOfMapVote");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnHostCreated;
    /// <summary>
    /// Function: OnHostCreated
    /// </summary>
    public unsafe override void OnHostCreated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnHostCreated, "BmScript.GDGFxMovieUI_LobbyMenu.OnHostCreated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CountdownTimerStarted;
    /// <summary>
    /// Function: CountdownTimerStarted
    /// </summary>
    public unsafe override void CountdownTimerStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CountdownTimerStarted, "BmScript.GDGFxMovieUI_LobbyMenu.CountdownTimerStarted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateLobbyMapVoteList;
    /// <summary>
    /// Function: PopulateLobbyMapVoteList
    /// </summary>
    public unsafe void PopulateLobbyMapVoteList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateLobbyMapVoteList, "BmScript.GDGFxMovieUI_LobbyMenu.PopulateLobbyMapVoteList");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLoadoutButtonsForFaction;
    /// <summary>
    /// Function: SetLoadoutButtonsForFaction
    /// </summary>
    public unsafe int SetLoadoutButtonsForFaction(BmSDK.BmGame.RGameInfo.ELoadoutTeamId TeamID, out int LoadoutCount, out int ButtonCount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLoadoutButtonsForFaction, "BmScript.GDGFxMovieUI_LobbyMenu.SetLoadoutButtonsForFaction");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamID, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out LoadoutCount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutCount, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ButtonCount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonCount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        LoadoutCount = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        ButtonCount = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PopulateLobbyLoadoutList;
    /// <summary>
    /// Function: PopulateLobbyLoadoutList
    /// </summary>
    public unsafe void PopulateLobbyLoadoutList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateLobbyLoadoutList, "BmScript.GDGFxMovieUI_LobbyMenu.PopulateLobbyLoadoutList");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateLobbyConsumablesList;
    /// <summary>
    /// Function: PopulateLobbyConsumablesList
    /// </summary>
    public unsafe void PopulateLobbyConsumablesList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateLobbyConsumablesList, "BmScript.GDGFxMovieUI_LobbyMenu.PopulateLobbyConsumablesList");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SortConsumablesBySortIndex;
    /// <summary>
    /// Function: SortConsumablesBySortIndex
    /// </summary>
    public unsafe virtual int SortConsumablesBySortIndex(BmSDK.BmGame.GDInventorySystem.FGDInventoryItem A, BmSDK.BmGame.GDInventorySystem.FGDInventoryItem B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortConsumablesBySortIndex, "BmScript.GDGFxMovieUI_LobbyMenu.SortConsumablesBySortIndex");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetLobbyPlayerStateValues;
    /// <summary>
    /// Function: GetLobbyPlayerStateValues
    /// </summary>
    public unsafe int GetLobbyPlayerStateValues(BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember LobbyEntry)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyPlayerStateValues, "BmScript.GDGFxMovieUI_LobbyMenu.GetLobbyPlayerStateValues");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyEntry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_IsReadyToStartPrivateGame;
    /// <summary>
    /// Function: IsReadyToStartPrivateGame
    /// </summary>
    public unsafe bool IsReadyToStartPrivateGame(int NumPlayers)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsReadyToStartPrivateGame, "BmScript.GDGFxMovieUI_LobbyMenu.IsReadyToStartPrivateGame");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumPlayers, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PopulateLobbyListTeam;
    /// <summary>
    /// Function: PopulateLobbyListTeam
    /// </summary>
    public unsafe void PopulateLobbyListTeam(int RequiredTeamSize)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateLobbyListTeam, "BmScript.GDGFxMovieUI_LobbyMenu.PopulateLobbyListTeam");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequiredTeamSize, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlayerFactionIconName;
    /// <summary>
    /// Function: GetPlayerFactionIconName
    /// </summary>
    public unsafe BmSDK.FString GetPlayerFactionIconName(int PlayerListIdx, out int teamColour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerFactionIconName, "BmScript.GDGFxMovieUI_LobbyMenu.GetPlayerFactionIconName");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerListIdx, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out teamColour);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(teamColour, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        teamColour = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetIsPlayerMuted;
    /// <summary>
    /// Function: GetIsPlayerMuted
    /// </summary>
    public unsafe bool GetIsPlayerMuted(int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIsPlayerMuted, "BmScript.GDGFxMovieUI_LobbyMenu.GetIsPlayerMuted");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPlayerButtonAddtionalInformation;
    /// <summary>
    /// Function: GetPlayerButtonAddtionalInformation
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject GetPlayerButtonAddtionalInformation(BmSDK.BmScript.GDGFxMovieUI_LobbyBase.EUILobbyPlayerInfoType InfoType, int ButtonIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerButtonAddtionalInformation, "BmScript.GDGFxMovieUI_LobbyMenu.GetPlayerButtonAddtionalInformation");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfoType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetCoreNewListData;
    /// <summary>
    /// Function: SetCoreNewListData
    /// </summary>
    public unsafe void SetCoreNewListData(BmSDK.BmScript.GDGFxMovieUI_LobbyMenu.LobbyMenuListType NewListType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCoreNewListData, "BmScript.GDGFxMovieUI_LobbyMenu.SetCoreNewListData");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewListType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateMapVoteList;
    /// <summary>
    /// Function: PopulateMapVoteList
    /// </summary>
    public unsafe virtual void PopulateMapVoteList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateMapVoteList, "BmScript.GDGFxMovieUI_LobbyMenu.PopulateMapVoteList");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateLoadoutList;
    /// <summary>
    /// Function: PopulateLoadoutList
    /// </summary>
    public unsafe virtual void PopulateLoadoutList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateLoadoutList, "BmScript.GDGFxMovieUI_LobbyMenu.PopulateLoadoutList");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateConsumablesList;
    /// <summary>
    /// Function: PopulateConsumablesList
    /// </summary>
    public unsafe virtual void PopulateConsumablesList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateConsumablesList, "BmScript.GDGFxMovieUI_LobbyMenu.PopulateConsumablesList");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulatePlayerList;
    /// <summary>
    /// Function: PopulatePlayerList
    /// </summary>
    public unsafe virtual void PopulatePlayerList(int RequiredPlayers)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulatePlayerList, "BmScript.GDGFxMovieUI_LobbyMenu.PopulatePlayerList");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequiredPlayers, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateVoip;
    /// <summary>
    /// Function: UpdateVoip
    /// </summary>
    public unsafe virtual void UpdateVoip()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateVoip, "BmScript.GDGFxMovieUI_LobbyMenu.UpdateVoip");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopVOIPPollUpdate;
    /// <summary>
    /// Function: StopVOIPPollUpdate
    /// </summary>
    public unsafe void StopVOIPPollUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopVOIPPollUpdate, "BmScript.GDGFxMovieUI_LobbyMenu.StopVOIPPollUpdate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartVOIPPollUpdate;
    /// <summary>
    /// Function: StartVOIPPollUpdate
    /// </summary>
    public unsafe void StartVOIPPollUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartVOIPPollUpdate, "BmScript.GDGFxMovieUI_LobbyMenu.StartVOIPPollUpdate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCachedLobbyPlayersList;
    /// <summary>
    /// Function: SetCachedLobbyPlayersList
    /// </summary>
    public unsafe void SetCachedLobbyPlayersList(BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember> NewMemberList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCachedLobbyPlayersList, "BmScript.GDGFxMovieUI_LobbyMenu.SetCachedLobbyPlayersList");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMemberList, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LobbyMembersListChange;
    /// <summary>
    /// Function: LobbyMembersListChange
    /// </summary>
    public unsafe virtual void LobbyMembersListChange(BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember> NewMemberList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LobbyMembersListChange, "BmScript.GDGFxMovieUI_LobbyMenu.LobbyMembersListChange");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMemberList, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCountdown;
    /// <summary>
    /// Function: OnCountdown
    /// </summary>
    public unsafe virtual void OnCountdown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCountdown, "BmScript.GDGFxMovieUI_LobbyMenu.OnCountdown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddUScriptDeclaredButtonData;
    /// <summary>
    /// Function: AddUScriptDeclaredButtonData
    /// </summary>
    public unsafe override void AddUScriptDeclaredButtonData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUScriptDeclaredButtonData, "BmScript.GDGFxMovieUI_LobbyMenu.AddUScriptDeclaredButtonData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLobbyDestroyed;
    /// <summary>
    /// Function: OnLobbyDestroyed
    /// </summary>
    public unsafe virtual void OnLobbyDestroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbyDestroyed, "BmScript.GDGFxMovieUI_LobbyMenu.OnLobbyDestroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoadoutChanged;
    /// <summary>
    /// Function: OnLoadoutChanged
    /// </summary>
    public unsafe virtual void OnLoadoutChanged(in BmSDK.BmGame.GDLobbySystemSteam.FGDLoadout ChangedLoadout)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoadoutChanged, "BmScript.GDGFxMovieUI_LobbyMenu.OnLoadoutChanged");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChangedLoadout, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOnLoadoutChangedCallback;
    /// <summary>
    /// Function: SetOnLoadoutChangedCallback
    /// </summary>
    public unsafe virtual void SetOnLoadoutChangedCallback(BmSDK.BmGame.GDLobbySystemSteam Lobby)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOnLoadoutChangedCallback, "BmScript.GDGFxMovieUI_LobbyMenu.SetOnLoadoutChangedCallback");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Lobby, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLobbyDelegates;
    /// <summary>
    /// Function: ClearLobbyDelegates
    /// </summary>
    public unsafe override void ClearLobbyDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLobbyDelegates, "BmScript.GDGFxMovieUI_LobbyMenu.ClearLobbyDelegates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLobbyDelegates;
    /// <summary>
    /// Function: AddLobbyDelegates
    /// </summary>
    public unsafe override void AddLobbyDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLobbyDelegates, "BmScript.GDGFxMovieUI_LobbyMenu.AddLobbyDelegates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBack, "BmScript.GDGFxMovieUI_LobbyMenu.OnBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClosed, "BmScript.GDGFxMovieUI_LobbyMenu.OnClosed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestScreenTitleMarkupData;
    /// <summary>
    /// Function: RequestScreenTitleMarkupData
    /// </summary>
    public unsafe override BmSDK.FString RequestScreenTitleMarkupData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestScreenTitleMarkupData, "BmScript.GDGFxMovieUI_LobbyMenu.RequestScreenTitleMarkupData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.GDGFxMovieUI_LobbyMenu.Init");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FPlayerListDataObjects
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FPlayerListDataObjects
    {
        /// <summary>
        /// ArrayProperty: PlayerListDataObj
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> PlayerListDataObj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: LobbyMenuListType
    /// </summary>
    public enum LobbyMenuListType : byte
    {
        LMLT_Players = 0,
        LMLT_Consumables = 1,
        LMLT_Loadout = 2,
        LMLT_MapVote = 3,
        LMLT_MAX = 4,
    }

    /// <summary>
    /// ObjectProperty: FailsafePlayerListInitTimer
    /// </summary>
    public unsafe BmSDK.SDEngine.SDTimer FailsafePlayerListInitTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDTimer>(Ptr + 2228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2228); }
    }

    /// <summary>
    /// ObjectProperty: BackgroundUpdateTimer
    /// </summary>
    public unsafe BmSDK.SDEngine.SDTimer BackgroundUpdateTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDTimer>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// ObjectProperty: VOIPPollTimer
    /// </summary>
    public unsafe BmSDK.SDEngine.SDTimer VOIPPollTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDTimer>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// FloatProperty: VOIPPollTime
    /// </summary>
    public unsafe float VOIPPollTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// BoolProperty: bConsumablePicked
    /// </summary>
    public unsafe bool bConsumablePicked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2244) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2244); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2244); }
    }

    /// <summary>
    /// BoolProperty: bLobbyReadyForButtonData
    /// </summary>
    public unsafe bool bLobbyReadyForButtonData
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2244) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2244); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2244); }
    }

    /// <summary>
    /// StrProperty: LobbyPlayerListTitleMarkup
    /// </summary>
    public unsafe BmSDK.FString LobbyPlayerListTitleMarkup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// StrProperty: LobbyConsumeablesListMarkup
    /// </summary>
    public unsafe BmSDK.FString LobbyConsumeablesListMarkup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// StrProperty: LobbyLoadoutListMarkup
    /// </summary>
    public unsafe BmSDK.FString LobbyLoadoutListMarkup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// StrProperty: LobbyMapVoteListMarkup
    /// </summary>
    public unsafe BmSDK.FString LobbyMapVoteListMarkup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// IntProperty: InvitePlayerButtonID
    /// </summary>
    public unsafe int InvitePlayerButtonID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// IntProperty: InvitePartyButtonID
    /// </summary>
    public unsafe int InvitePartyButtonID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// IntProperty: InviteStartGameButtonID
    /// </summary>
    public unsafe int InviteStartGameButtonID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// IntProperty: CurrentJokerLoadoutIdx
    /// </summary>
    public unsafe int CurrentJokerLoadoutIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// IntProperty: CurrentBaneLoadoutIdx
    /// </summary>
    public unsafe int CurrentBaneLoadoutIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// ByteProperty: PrevLoadoutTeamID
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.ELoadoutTeamId PrevLoadoutTeamID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ELoadoutTeamId>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// ByteProperty: LobbyListType
    /// </summary>
    public unsafe BmSDK.BmScript.GDGFxMovieUI_LobbyMenu.LobbyMenuListType LobbyListType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.GDGFxMovieUI_LobbyMenu.LobbyMenuListType>(Ptr + 2317); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2317); }
    }

    /// <summary>
    /// StrProperty: CachedLocalPlayerName
    /// </summary>
    public unsafe BmSDK.FString CachedLocalPlayerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// IntProperty: CachedLocalPlayerRoundCount
    /// </summary>
    public unsafe int CachedLocalPlayerRoundCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// IntProperty: CurrentButtonIdx
    /// </summary>
    public unsafe int CurrentButtonIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// IntProperty: MaxNumberOfLobbyPlayers
    /// </summary>
    public unsafe int MaxNumberOfLobbyPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: PlayerDataObjects
    /// </summary>
    public InlineArray<BmSDK.BmScript.GDGFxMovieUI_LobbyMenu.FPlayerListDataObjects> PlayerDataObjects => new(4, Ptr + 2344, 12, this);

    /// <summary>
    /// StructProperty: PlayerDataObjects
    /// </summary>
    public unsafe ref BmSDK.BmScript.GDGFxMovieUI_LobbyMenu.FPlayerListDataObjects PlayerDataObjects_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.GDGFxMovieUI_LobbyMenu.FPlayerListDataObjects>(Ptr + 2344);
    /// <summary>
    /// StructProperty: PlayerDataObjects
    /// </summary>
    public unsafe ref BmSDK.BmScript.GDGFxMovieUI_LobbyMenu.FPlayerListDataObjects PlayerDataObjects_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.GDGFxMovieUI_LobbyMenu.FPlayerListDataObjects>(Ptr + 2356);
    /// <summary>
    /// StructProperty: PlayerDataObjects
    /// </summary>
    public unsafe ref BmSDK.BmScript.GDGFxMovieUI_LobbyMenu.FPlayerListDataObjects PlayerDataObjects_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.GDGFxMovieUI_LobbyMenu.FPlayerListDataObjects>(Ptr + 2368);
    /// <summary>
    /// StructProperty: PlayerDataObjects
    /// </summary>
    public unsafe ref BmSDK.BmScript.GDGFxMovieUI_LobbyMenu.FPlayerListDataObjects PlayerDataObjects_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.GDGFxMovieUI_LobbyMenu.FPlayerListDataObjects>(Ptr + 2380);

    /// <summary>
    /// DelegateProperty: __SortConsumablesBySortIndex__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortConsumablesBySortIndex__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }
}
