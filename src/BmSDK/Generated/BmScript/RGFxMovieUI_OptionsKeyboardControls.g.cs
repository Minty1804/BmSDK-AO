#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_OptionsKeyboardControls<br/>
/// (size = 832)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_OptionsKeyboardControls : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_OptionsKeyboardControls", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_OptionsKeyboardControls.
    /// </summary>
    public static RGFxMovieUI_OptionsKeyboardControls DefaultObject => (RGFxMovieUI_OptionsKeyboardControls)StaticClass().DefaultObject;

    internal RGFxMovieUI_OptionsKeyboardControls() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_OptionsKeyboardControls
    /// </summary>
    public RGFxMovieUI_OptionsKeyboardControls(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_OptionsKeyboardControls Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_OptionsKeyboardControls(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsKeyboardControls>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsKeyboardControls>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsKeyboardControls>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsKeyboardControls>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsKeyboardControls>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsKeyboardControls>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsKeyboardControls>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_OptionsKeyboardControls>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: SetAssigningKeys
    /// </summary>
    public unsafe virtual void SetAssigningKeys(bool IsAssigningKeys)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsKeyboardControls.SetAssigningKeys", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsAssigningKeys, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsKeyboardControls.CloseScreen", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RequestSetBindByAbility
    /// </summary>
    public unsafe virtual void RequestSetBindByAbility(int AbilityId, int PreviousKeyCode, int KeyId, bool IsPrimary)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsKeyboardControls.RequestSetBindByAbility", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousKeyCode, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyId, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsPrimary, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RequestSetBindsByAbilityAndGetKeyNames
    /// </summary>
    public unsafe virtual void RequestSetBindsByAbilityAndGetKeyNames(int AbilityId, int PreviousKey1Code, int PreviousKey2Code, int Key1Code, int Key2Code, BmSDK.FString ReturnKeyNamePath1, BmSDK.FString ReturnKeyNamePath2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsKeyboardControls.RequestSetBindsByAbilityAndGetKeyNames", true);
        byte* paramsPtr = stackalloc byte[64];
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

    /// <summary>
    /// Function: RequestRemoveBind
    /// </summary>
    public unsafe virtual void RequestRemoveBind(int AbilityId, int KeyId, bool IsPrimary)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsKeyboardControls.RequestRemoveBind", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsPrimary, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisplayAreYouSure
    /// </summary>
    public unsafe virtual void DisplayAreYouSure(BmSDK.FString Path, int KeyCodeToSet)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsKeyboardControls.DisplayAreYouSure", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyCodeToSet, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsKeyboardControls.PopupRequester_Callback", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RequestGetKeyNameFromKeyCode
    /// </summary>
    public unsafe virtual void RequestGetKeyNameFromKeyCode(BmSDK.FString Path, int keyCode)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsKeyboardControls.RequestGetKeyNameFromKeyCode", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(keyCode, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDefaultKeyCode
    /// </summary>
    public unsafe virtual int GetDefaultKeyCode(bool IsPrimary, int KeyIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsKeyboardControls.GetDefaultKeyCode", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsPrimary, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: RequestControlData
    /// </summary>
    public unsafe virtual void RequestControlData(BmSDK.FString AbilityNamesPath, BmSDK.FString KeysPath, BmSDK.FString ModifiersPath, BmSDK.FString KeyCodesPath, BmSDK.FString Keys2Path, BmSDK.FString Modifiers2Path, BmSDK.FString KeyCodes2Path, BmSDK.FString HoldsPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsKeyboardControls.RequestControlData", true);
        byte* paramsPtr = stackalloc byte[196];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityNamesPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeysPath, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ModifiersPath, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyCodesPath, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Keys2Path, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Modifiers2Path, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyCodes2Path, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HoldsPath, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsKeyboardControls.Init", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: keyCodeForSetting
    /// </summary>
    public unsafe int keyCodeForSetting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// StrProperty: functionPath
    /// </summary>
    public unsafe BmSDK.FString functionPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }
}
