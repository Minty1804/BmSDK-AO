#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_MainMenu<br/>
/// (size = 848)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_MainMenu : BmSDK.BmGame.RGFxMovieUI_MainMenuBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_MainMenu", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_MainMenu.
    /// </summary>
    public static RGFxMovieUI_MainMenu DefaultObject => (RGFxMovieUI_MainMenu)StaticClass().DefaultObject;

    internal RGFxMovieUI_MainMenu() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_MainMenu
    /// </summary>
    public RGFxMovieUI_MainMenu(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_MainMenu Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_MainMenu(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_MainMenu>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_StartMOTDTicker;
    /// <summary>
    /// Function: StartMOTDTicker
    /// </summary>
    public unsafe virtual void StartMOTDTicker(BmSDK.TArray<BmSDK.FString> motdMessages)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartMOTDTicker, "BmScript.RGFxMovieUI_MainMenu.StartMOTDTicker");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(motdMessages, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTickerData;
    /// <summary>
    /// Function: GetTickerData
    /// </summary>
    public unsafe virtual void GetTickerData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTickerData, "BmScript.RGFxMovieUI_MainMenu.GetTickerData");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshFocusedList;
    /// <summary>
    /// Function: RefreshFocusedList
    /// </summary>
    public unsafe virtual void RefreshFocusedList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshFocusedList, "BmScript.RGFxMovieUI_MainMenu.RefreshFocusedList");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetASFocus;
    /// <summary>
    /// Function: GetASFocus
    /// </summary>
    public unsafe virtual BmSDK.FString GetASFocus()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetASFocus, "BmScript.RGFxMovieUI_MainMenu.GetASFocus");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckInfoTicker;
    /// <summary>
    /// Function: CheckInfoTicker
    /// </summary>
    public unsafe virtual BmSDK.FString CheckInfoTicker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckInfoTicker, "BmScript.RGFxMovieUI_MainMenu.CheckInfoTicker");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FetchCurrentProfileData;
    /// <summary>
    /// Function: FetchCurrentProfileData
    /// </summary>
    public unsafe virtual int FetchCurrentProfileData(BmSDK.FString TargetPathFull)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FetchCurrentProfileData, "BmScript.RGFxMovieUI_MainMenu.FetchCurrentProfileData");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPathFull, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetCurrentPercentage;
    /// <summary>
    /// Function: GetCurrentPercentage
    /// </summary>
    public unsafe virtual BmSDK.FString GetCurrentPercentage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentPercentage, "BmScript.RGFxMovieUI_MainMenu.GetCurrentPercentage");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FetchNickname;
    /// <summary>
    /// Function: FetchNickname
    /// </summary>
    public unsafe virtual BmSDK.FString FetchNickname()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FetchNickname, "BmScript.RGFxMovieUI_MainMenu.FetchNickname");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGridButtonContext;
    /// <summary>
    /// Function: GetGridButtonContext
    /// </summary>
    public unsafe override BmSDK.FString GetGridButtonContext(int ButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGridButtonContext, "BmScript.RGFxMovieUI_MainMenu.GetGridButtonContext");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnListWrapperDestroyed;
    /// <summary>
    /// Function: OnListWrapperDestroyed
    /// </summary>
    public unsafe virtual void OnListWrapperDestroyed(BmSDK.GFxUI.GFxObject ListWrapper)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnListWrapperDestroyed, "BmScript.RGFxMovieUI_MainMenu.OnListWrapperDestroyed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ListWrapper, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnListWrapperInited;
    /// <summary>
    /// Function: OnListWrapperInited
    /// </summary>
    public unsafe virtual void OnListWrapperInited(BmSDK.GFxUI.GFxObject ListWrapper)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnListWrapperInited, "BmScript.RGFxMovieUI_MainMenu.OnListWrapperInited");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ListWrapper, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopUpUnlockMessage;
    /// <summary>
    /// Function: PopUpUnlockMessage
    /// </summary>
    public unsafe override bool PopUpUnlockMessage(BmSDK.FString Prompt, BmSDK.FString Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopUpUnlockMessage, "BmScript.RGFxMovieUI_MainMenu.PopUpUnlockMessage");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_OnTick;
    /// <summary>
    /// Function: OnTick
    /// </summary>
    public unsafe override void OnTick()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTick, "BmScript.RGFxMovieUI_MainMenu.OnTick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFadeCompleted_Callback;
    /// <summary>
    /// Function: OnFadeCompleted_Callback
    /// </summary>
    public unsafe override void OnFadeCompleted_Callback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFadeCompleted_Callback, "BmScript.RGFxMovieUI_MainMenu.OnFadeCompleted_Callback");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PS3SignIn;
    /// <summary>
    /// Function: PS3SignIn
    /// </summary>
    public unsafe virtual void PS3SignIn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PS3SignIn, "BmScript.RGFxMovieUI_MainMenu.PS3SignIn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmScript.RGFxMovieUI_MainMenu.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeTrigger;
    /// <summary>
    /// Function: FadeTrigger
    /// </summary>
    public unsafe virtual void FadeTrigger(BmSDK.BmScript.RGFxMovieUI_MainMenu.EFadeMode Mode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeTrigger, "BmScript.RGFxMovieUI_MainMenu.FadeTrigger");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ControllerImageLoaded_CB;
    /// <summary>
    /// Function: ControllerImageLoaded_CB
    /// </summary>
    public unsafe override void ControllerImageLoaded_CB()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ControllerImageLoaded_CB, "BmScript.RGFxMovieUI_MainMenu.ControllerImageLoaded_CB");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleMultiplayer;
    /// <summary>
    /// Function: HandleMultiplayer
    /// </summary>
    public unsafe virtual void HandleMultiplayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleMultiplayer, "BmScript.RGFxMovieUI_MainMenu.HandleMultiplayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleWBID;
    /// <summary>
    /// Function: HandleWBID
    /// </summary>
    public unsafe virtual void HandleWBID()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleWBID, "BmScript.RGFxMovieUI_MainMenu.HandleWBID");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClicked;
    /// <summary>
    /// Function: OnClicked
    /// </summary>
    public unsafe override void OnClicked(int inID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClicked, "BmScript.RGFxMovieUI_MainMenu.OnClicked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inID, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClosed, "BmScript.RGFxMovieUI_MainMenu.OnClosed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenMarketPlace;
    /// <summary>
    /// Function: OpenMarketPlace
    /// </summary>
    public unsafe virtual void OpenMarketPlace()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenMarketPlace, "BmScript.RGFxMovieUI_MainMenu.OpenMarketPlace");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnY;
    /// <summary>
    /// Function: OnY
    /// </summary>
    public unsafe virtual void OnY()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnY, "BmScript.RGFxMovieUI_MainMenu.OnY");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenDebugLevelSelect;
    /// <summary>
    /// Function: OpenDebugLevelSelect
    /// </summary>
    public unsafe virtual void OpenDebugLevelSelect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenDebugLevelSelect, "BmScript.RGFxMovieUI_MainMenu.OpenDebugLevelSelect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateDLCPrompt;
    /// <summary>
    /// Function: UpdateDLCPrompt
    /// </summary>
    public unsafe virtual void UpdateDLCPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDLCPrompt, "BmScript.RGFxMovieUI_MainMenu.UpdateDLCPrompt");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.RGFxMovieUI_MainMenu.Init");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBack, "BmScript.RGFxMovieUI_MainMenu.OnBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TransitionForwards;
    /// <summary>
    /// Function: TransitionForwards
    /// </summary>
    public unsafe override void TransitionForwards(BmSDK.FString EventName, bool bClose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransitionForwards, "BmScript.RGFxMovieUI_MainMenu.TransitionForwards");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClose, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: FadeMode
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_MainMenu.EFadeMode FadeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_MainMenu.EFadeMode>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ByteProperty: PopupType
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_MainMenu.MMPopTypes PopupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_MainMenu.MMPopTypes>(Ptr + 817); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 817); }
    }

    /// <summary>
    /// ByteProperty: HeadedTo
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_MainMenu.MMHeadedTo HeadedTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_MainMenu.MMHeadedTo>(Ptr + 818); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 818); }
    }

    /// <summary>
    /// BoolProperty: bPS3BeginSignIn
    /// </summary>
    public unsafe bool bPS3BeginSignIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: bPS3LoggingIn
    /// </summary>
    public unsafe bool bPS3LoggingIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: bIsSaveInProgress
    /// </summary>
    public unsafe bool bIsSaveInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: RefreshDLCHandled
    /// </summary>
    public unsafe bool RefreshDLCHandled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: DLCStoryNew
    /// </summary>
    public unsafe bool DLCStoryNew
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: CMan
    /// </summary>
    public unsafe BmSDK.BmGame.RChallengeManager CMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChallengeManager>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ObjectProperty: ActivePopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ActivePopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// StrProperty: LastFocusedList
    /// </summary>
    public unsafe BmSDK.FString LastFocusedList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// IntProperty: DLCStoryCount
    /// </summary>
    public unsafe int DLCStoryCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// Enum: MMHeadedTo
    /// </summary>
    public enum MMHeadedTo : byte
    {
        MMHeadedNowhere = 0,
        MMHeadedToPSN = 1,
        MMHeadedToWBID = 2,
        MMHeadedToMultiplayer = 3,
        MMHeadedTo_MAX = 4,
    }

    /// <summary>
    /// Enum: EFadeMode
    /// </summary>
    public enum EFadeMode : byte
    {
        EFM_Exit = 0,
        EFM_MAX = 1,
    }

    /// <summary>
    /// Enum: MMPopTypes
    /// </summary>
    public enum MMPopTypes : byte
    {
        MMPopType_None = 0,
        MMPopType_Exit = 1,
        MMPopType_BackFromMain = 2,
        MMPopType_PS3_Riddler = 3,
        MMPopType_NewGame_VS = 4,
        MMPopType_GoToStore = 5,
        MMPopType_GoOnlineForStore = 6,
        MMPopType_PS3SignIn = 7,
        MMPopType_PS3_WBID = 8,
        MMPopType_MultiPlayer = 9,
        MMPopType_NoMultiPlayer = 10,
        MMPopType_NotSignedIn = 11,
        MMPopType_PS3_MultiplayerSignin = 12,
        MMPopType_IOSUnlock = 13,
        MMPopType_MAX = 14,
    }

    /// <summary>
    /// Enum: MainMenuItems
    /// </summary>
    public enum MainMenuItems : byte
    {
        MMI_None = 0,
        MMI_WBID = 1,
        MMI_MultiPlayer = 2,
        MMI_LIVE = 3,
        MMI_Exit = 4,
        MMI_StoryMenu = 5,
        MMI_OptionsMenu = 6,
        MMI_ExtrasMenu = 7,
        MMI_VSlice = 8,
        MMI_InGameStore = 9,
        MMI_DLC_Cash = 10,
        MMI_InstallVoicePack = 11,
        MMI_MAX = 12,
    }
}
