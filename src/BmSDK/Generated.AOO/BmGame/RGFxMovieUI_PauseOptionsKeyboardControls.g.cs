#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_PauseOptionsKeyboardControls<br/>
/// (size = 2064)
/// (flags = 32790)
/// </summary>
public partial class RGFxMovieUI_PauseOptionsKeyboardControls : BmSDK.BmGame.RGFxMovieUI_PauseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_PauseOptionsKeyboardControls", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_PauseOptionsKeyboardControls.
    /// </summary>
    public static RGFxMovieUI_PauseOptionsKeyboardControls DefaultObject => (RGFxMovieUI_PauseOptionsKeyboardControls)StaticClass().DefaultObject;

    internal RGFxMovieUI_PauseOptionsKeyboardControls() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_PauseOptionsKeyboardControls
    /// </summary>
    public RGFxMovieUI_PauseOptionsKeyboardControls(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_PauseOptionsKeyboardControls Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_PauseOptionsKeyboardControls(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsKeyboardControls>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsKeyboardControls>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsKeyboardControls>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsKeyboardControls>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsKeyboardControls>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsKeyboardControls>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsKeyboardControls>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PauseOptionsKeyboardControls>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnBack;
    /// <summary>
    /// Function: OnBack
    /// </summary>
    public unsafe override void OnBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBack, "BmGame.RGFxMovieUI_PauseOptionsKeyboardControls.OnBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAssigningKeys;
    /// <summary>
    /// Function: SetAssigningKeys
    /// </summary>
    public unsafe virtual void SetAssigningKeys(bool IsAssigningKeys)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAssigningKeys, "BmGame.RGFxMovieUI_PauseOptionsKeyboardControls.SetAssigningKeys");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsAssigningKeys, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmGame.RGFxMovieUI_PauseOptionsKeyboardControls.CloseScreen");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestSetBindByAbility;
    /// <summary>
    /// Function: RequestSetBindByAbility
    /// </summary>
    public unsafe virtual void RequestSetBindByAbility(int AbilityId, int PreviousKeyCode, int KeyId, bool IsPrimary)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestSetBindByAbility, "BmGame.RGFxMovieUI_PauseOptionsKeyboardControls.RequestSetBindByAbility");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousKeyCode, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyId, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsPrimary, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestSetBindsByAbilityAndGetKeyNames;
    /// <summary>
    /// Function: RequestSetBindsByAbilityAndGetKeyNames
    /// </summary>
    public unsafe virtual void RequestSetBindsByAbilityAndGetKeyNames(int AbilityId, int PreviousKey1Code, int PreviousKey2Code, int Key1Code, int Key2Code, BmSDK.FString ReturnKeyNamePath1, BmSDK.FString ReturnKeyNamePath2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestSetBindsByAbilityAndGetKeyNames, "BmGame.RGFxMovieUI_PauseOptionsKeyboardControls.RequestSetBindsByAbilityAndGetKeyNames");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousKey1Code, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousKey2Code, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key1Code, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key2Code, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReturnKeyNamePath1, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReturnKeyNamePath2, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestRemoveBind;
    /// <summary>
    /// Function: RequestRemoveBind
    /// </summary>
    public unsafe virtual void RequestRemoveBind(int AbilityId, int KeyId, bool IsPrimary)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestRemoveBind, "BmGame.RGFxMovieUI_PauseOptionsKeyboardControls.RequestRemoveBind");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsPrimary, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldApplyKeyBindsInGame;
    /// <summary>
    /// Function: ShouldApplyKeyBindsInGame
    /// </summary>
    public unsafe virtual bool ShouldApplyKeyBindsInGame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldApplyKeyBindsInGame, "BmGame.RGFxMovieUI_PauseOptionsKeyboardControls.ShouldApplyKeyBindsInGame");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DisplayAreYouSure;
    /// <summary>
    /// Function: DisplayAreYouSure
    /// </summary>
    public unsafe virtual void DisplayAreYouSure(BmSDK.FString Path, int KeyCodeToSet)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayAreYouSure, "BmGame.RGFxMovieUI_PauseOptionsKeyboardControls.DisplayAreYouSure");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyCodeToSet, paramsPtr + 12);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmGame.RGFxMovieUI_PauseOptionsKeyboardControls.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestGetKeyNameFromKeyCode;
    /// <summary>
    /// Function: RequestGetKeyNameFromKeyCode
    /// </summary>
    public unsafe virtual void RequestGetKeyNameFromKeyCode(BmSDK.FString Path, int KeyCode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestGetKeyNameFromKeyCode, "BmGame.RGFxMovieUI_PauseOptionsKeyboardControls.RequestGetKeyNameFromKeyCode");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyCode, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDefaultKeyCode;
    /// <summary>
    /// Function: GetDefaultKeyCode
    /// </summary>
    public unsafe virtual int GetDefaultKeyCode(bool IsPrimary, int AbilityId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultKeyCode, "BmGame.RGFxMovieUI_PauseOptionsKeyboardControls.GetDefaultKeyCode");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsPrimary, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RequestControlData;
    /// <summary>
    /// Function: RequestControlData
    /// </summary>
    public unsafe virtual void RequestControlData(BmSDK.FString AbilityNamesPath, BmSDK.FString KeysPath, BmSDK.FString AbilityIdsPath, BmSDK.FString KeyCodesPath, BmSDK.FString Keys2Path, BmSDK.FString KeyCodes2Path)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestControlData, "BmGame.RGFxMovieUI_PauseOptionsKeyboardControls.RequestControlData");
        byte* paramsPtr = stackalloc byte[164];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityNamesPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeysPath, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityIdsPath, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyCodesPath, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Keys2Path, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyCodes2Path, paramsPtr + 60);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieUI_PauseOptionsKeyboardControls.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: keyCodeForSetting
    /// </summary>
    public unsafe int keyCodeForSetting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// StrProperty: functionPath
    /// </summary>
    public unsafe BmSDK.FString functionPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }
}
