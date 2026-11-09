#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_SinglePlayerMenu<br/>
/// (size = 832)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_SinglePlayerMenu : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_SinglePlayerMenu", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_SinglePlayerMenu.
    /// </summary>
    public static RGFxMovieUI_SinglePlayerMenu DefaultObject => (RGFxMovieUI_SinglePlayerMenu)StaticClass().DefaultObject;

    internal RGFxMovieUI_SinglePlayerMenu() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_SinglePlayerMenu
    /// </summary>
    public RGFxMovieUI_SinglePlayerMenu(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_SinglePlayerMenu Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_SinglePlayerMenu(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SinglePlayerMenu>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SinglePlayerMenu>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SinglePlayerMenu>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SinglePlayerMenu>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SinglePlayerMenu>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SinglePlayerMenu>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SinglePlayerMenu>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_SinglePlayerMenu>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_StartNewGamePlus;
    /// <summary>
    /// Function: StartNewGamePlus
    /// </summary>
    public unsafe virtual void StartNewGamePlus(BmSDK.BmGame.RSaveGameManager.StorySlots storySlot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartNewGamePlus, "BmScript.RGFxMovieUI_SinglePlayerMenu.StartNewGamePlus");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(storySlot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoRiddler;
    /// <summary>
    /// Function: GotoRiddler
    /// </summary>
    public unsafe virtual void GotoRiddler()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoRiddler, "BmScript.RGFxMovieUI_SinglePlayerMenu.GotoRiddler");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsNewChallenge;
    /// <summary>
    /// Function: IsNewChallenge
    /// </summary>
    public unsafe virtual bool IsNewChallenge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNewChallenge, "BmScript.RGFxMovieUI_SinglePlayerMenu.IsNewChallenge");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsChallengeLocked;
    /// <summary>
    /// Function: IsChallengeLocked
    /// </summary>
    public unsafe virtual bool IsChallengeLocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsChallengeLocked, "BmScript.RGFxMovieUI_SinglePlayerMenu.IsChallengeLocked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsStoryDLCNew;
    /// <summary>
    /// Function: IsStoryDLCNew
    /// </summary>
    public unsafe virtual bool IsStoryDLCNew()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStoryDLCNew, "BmScript.RGFxMovieUI_SinglePlayerMenu.IsStoryDLCNew");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsJustStory;
    /// <summary>
    /// Function: IsJustStory
    /// </summary>
    public unsafe virtual bool IsJustStory(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsJustStory, "BmScript.RGFxMovieUI_SinglePlayerMenu.IsJustStory");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsStoryDLCUnlocked;
    /// <summary>
    /// Function: IsStoryDLCUnlocked
    /// </summary>
    public unsafe virtual bool IsStoryDLCUnlocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStoryDLCUnlocked, "BmScript.RGFxMovieUI_SinglePlayerMenu.IsStoryDLCUnlocked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsNewCatwomanEpisode;
    /// <summary>
    /// Function: IsNewCatwomanEpisode
    /// </summary>
    public unsafe virtual bool IsNewCatwomanEpisode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNewCatwomanEpisode, "BmScript.RGFxMovieUI_SinglePlayerMenu.IsNewCatwomanEpisode");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CatwomanRequiredToPlay;
    /// <summary>
    /// Function: CatwomanRequiredToPlay
    /// </summary>
    public unsafe virtual void CatwomanRequiredToPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CatwomanRequiredToPlay, "BmScript.RGFxMovieUI_SinglePlayerMenu.CatwomanRequiredToPlay");
        byte* paramsPtr = stackalloc byte[16];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFadeCompleted_Callback, "BmScript.RGFxMovieUI_SinglePlayerMenu.OnFadeCompleted_Callback");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeTrigger;
    /// <summary>
    /// Function: FadeTrigger
    /// </summary>
    public unsafe virtual void FadeTrigger(BmSDK.BmScript.RGFxMovieUI_SinglePlayerMenu.ESPFadeMode Mode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeTrigger, "BmScript.RGFxMovieUI_SinglePlayerMenu.FadeTrigger");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmScript.RGFxMovieUI_SinglePlayerMenu.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGridButtonContext;
    /// <summary>
    /// Function: GetGridButtonContext
    /// </summary>
    public unsafe override BmSDK.FString GetGridButtonContext(int ButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGridButtonContext, "BmScript.RGFxMovieUI_SinglePlayerMenu.GetGridButtonContext");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnClicked;
    /// <summary>
    /// Function: OnClicked
    /// </summary>
    public unsafe override void OnClicked(int inID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClicked, "BmScript.RGFxMovieUI_SinglePlayerMenu.OnClicked");
        byte* paramsPtr = stackalloc byte[32];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClosed, "BmScript.RGFxMovieUI_SinglePlayerMenu.OnClosed");
        byte* paramsPtr = stackalloc byte[16];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBack, "BmScript.RGFxMovieUI_SinglePlayerMenu.OnBack");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransitionForwards, "BmScript.RGFxMovieUI_SinglePlayerMenu.TransitionForwards");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClose, paramsPtr + 12);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.RGFxMovieUI_SinglePlayerMenu.Init");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsGameStartedInSlot;
    /// <summary>
    /// Function: IsGameStartedInSlot
    /// </summary>
    public unsafe virtual bool IsGameStartedInSlot(BmSDK.BmGame.RSaveGameManager.StorySlots Slot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGameStartedInSlot, "BmScript.RGFxMovieUI_SinglePlayerMenu.IsGameStartedInSlot");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Slot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// ByteProperty: FadeMode
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_SinglePlayerMenu.ESPFadeMode FadeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_SinglePlayerMenu.ESPFadeMode>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ByteProperty: PopupType
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_SinglePlayerMenu.SPMPopTypes PopupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_SinglePlayerMenu.SPMPopTypes>(Ptr + 817); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 817); }
    }

    /// <summary>
    /// IntProperty: DLCStoryCount
    /// </summary>
    public unsafe int DLCStoryCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: bDLCStoriesNew
    /// </summary>
    public unsafe bool bDLCStoriesNew
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// BoolProperty: bChallengesNew
    /// </summary>
    public unsafe bool bChallengesNew
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 824); }
    }

    /// <summary>
    /// IntProperty: UnlockedChallengeCount
    /// </summary>
    public unsafe int UnlockedChallengeCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// Enum: ESPFadeMode
    /// </summary>
    public enum ESPFadeMode : byte
    {
        ESPFM_Continue = 0,
        ESPFM_NewGame_VS = 1,
        ESPFM_NewGamePlus = 2,
        ESPFM_NewGamePlusIAB = 3,
        ESPFM_NewStory1 = 4,
        ESPFM_MAX = 5,
    }

    /// <summary>
    /// Enum: SPMPopTypes
    /// </summary>
    public enum SPMPopTypes : byte
    {
        SPMPopType_None = 0,
        SPMPopType_NewGame = 1,
        SPMPopType_NewGamePlus = 2,
        SPMPopType_NewGamePlusIAB = 3,
        SPMPopType_NoContinueWithoutCatwoman = 4,
        SPMPopType_CatwomanInfo = 5,
        SPMPopType_Story1New = 6,
        SPMPopType_MAX = 7,
    }

    /// <summary>
    /// Enum: SinglePlayerMenuItems
    /// </summary>
    public enum SinglePlayerMenuItems : byte
    {
        SPMI_None = 0,
        SPMI_NewGame = 1,
        SPMI_Continue = 2,
        SPMI_NewGamePlus = 3,
        SPMI_ContinuePlus = 4,
        SPMI_NewGamePlusIAB = 5,
        SPMI_ContinuePlusIAB = 6,
        SPMI_StoryDLC1New = 7,
        SPMI_StoryDLC1Continue = 8,
        SPMI_StoryDLCMenu = 9,
        SPMI_Riddler = 10,
        SPMI_MAX = 11,
    }
}
