#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_WarnerID_Login_Script<br/>
/// (size = 1000)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_WarnerID_Login_Script : BmSDK.BmGame.RGFxMovieUI_WarnerID_Login, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_WarnerID_Login_Script", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_WarnerID_Login_Script.
    /// </summary>
    public static RGFxMovieUI_WarnerID_Login_Script DefaultObject => (RGFxMovieUI_WarnerID_Login_Script)StaticClass().DefaultObject;

    internal RGFxMovieUI_WarnerID_Login_Script() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_WarnerID_Login_Script
    /// </summary>
    public RGFxMovieUI_WarnerID_Login_Script(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_WarnerID_Login_Script Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_WarnerID_Login_Script(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WarnerID_Login_Script>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WarnerID_Login_Script>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WarnerID_Login_Script>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WarnerID_Login_Script>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WarnerID_Login_Script>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WarnerID_Login_Script>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WarnerID_Login_Script>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_WarnerID_Login_Script>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmScript.RGFxMovieUI_WarnerID_Login_Script.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoginChange;
    /// <summary>
    /// Function: OnLoginChange
    /// </summary>
    public unsafe virtual void OnLoginChange(byte userNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoginChange, "BmScript.RGFxMovieUI_WarnerID_Login_Script.OnLoginChange");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(userNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnConnectionStatusChange;
    /// <summary>
    /// Function: OnConnectionStatusChange
    /// </summary>
    public unsafe virtual void OnConnectionStatusChange(BmSDK.Engine.OnlineSubsystem.EOnlineServerConnectionStatus ConnectionStatus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnConnectionStatusChange, "BmScript.RGFxMovieUI_WarnerID_Login_Script.OnConnectionStatusChange");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConnectionStatus, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLinkStatusChange;
    /// <summary>
    /// Function: OnLinkStatusChange
    /// </summary>
    public unsafe virtual void OnLinkStatusChange(bool bIsConnected)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLinkStatusChange, "BmScript.RGFxMovieUI_WarnerID_Login_Script.OnLinkStatusChange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsConnected, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetForgotPasswordText;
    /// <summary>
    /// Function: SetForgotPasswordText
    /// </summary>
    public unsafe virtual void SetForgotPasswordText(BmSDK.FString ForgotPasswordText)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetForgotPasswordText, "BmScript.RGFxMovieUI_WarnerID_Login_Script.SetForgotPasswordText");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForgotPasswordText, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetForgotPasswordText;
    /// <summary>
    /// Function: GetForgotPasswordText
    /// </summary>
    public unsafe virtual void GetForgotPasswordText()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetForgotPasswordText, "BmScript.RGFxMovieUI_WarnerID_Login_Script.GetForgotPasswordText");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPrivacyText;
    /// <summary>
    /// Function: ClearPrivacyText
    /// </summary>
    public unsafe virtual void ClearPrivacyText()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPrivacyText, "BmScript.RGFxMovieUI_WarnerID_Login_Script.ClearPrivacyText");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrivacyParagraph;
    /// <summary>
    /// Function: SetPrivacyParagraph
    /// </summary>
    public unsafe virtual void SetPrivacyParagraph(int pg_index, BmSDK.FString pg_string)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrivacyParagraph, "BmScript.RGFxMovieUI_WarnerID_Login_Script.SetPrivacyParagraph");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pg_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pg_string, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrivacyText;
    /// <summary>
    /// Function: SetPrivacyText
    /// </summary>
    public unsafe virtual void SetPrivacyText(BmSDK.FString PrivacyText)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrivacyText, "BmScript.RGFxMovieUI_WarnerID_Login_Script.SetPrivacyText");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrivacyText, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowWindow;
    /// <summary>
    /// Function: ShowWindow
    /// </summary>
    public unsafe virtual void ShowWindow(BmSDK.FString Window, BmSDK.FString InputBoxText = default, bool IsPassword = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWindow, "BmScript.RGFxMovieUI_WarnerID_Login_Script.ShowWindow");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Window, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InputBoxText, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsPassword, paramsPtr + 24);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_PrivacyTextCallback;
    /// <summary>
    /// Function: PrivacyTextCallback
    /// </summary>
    public unsafe override void PrivacyTextCallback(BmSDK.FString PrivacyText)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrivacyTextCallback, "BmScript.RGFxMovieUI_WarnerID_Login_Script.PrivacyTextCallback");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrivacyText, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnTick;
    /// <summary>
    /// Function: OnTick
    /// </summary>
    public unsafe override void OnTick()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTick, "BmScript.RGFxMovieUI_WarnerID_Login_Script.OnTick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWbidLoginTimeout;
    /// <summary>
    /// Function: OnWbidLoginTimeout
    /// </summary>
    public unsafe virtual void OnWbidLoginTimeout()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWbidLoginTimeout, "BmScript.RGFxMovieUI_WarnerID_Login_Script.OnWbidLoginTimeout");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnTickLogin;
    /// <summary>
    /// Function: OnTickLogin
    /// </summary>
    public unsafe virtual void OnTickLogin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTickLogin, "BmScript.RGFxMovieUI_WarnerID_Login_Script.OnTickLogin");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WBIDCallback;
    /// <summary>
    /// Function: WBIDCallback
    /// </summary>
    public unsafe override void WBIDCallback(BmSDK.BmGame.RGFxMovieUI_WarnerID_Login.WBIDErrorCode ErrorCode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WBIDCallback, "BmScript.RGFxMovieUI_WarnerID_Login_Script.WBIDCallback");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ErrorCode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ValidateResetPassword;
    /// <summary>
    /// Function: ValidateResetPassword
    /// </summary>
    public unsafe virtual void ValidateResetPassword()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ValidateResetPassword, "BmScript.RGFxMovieUI_WarnerID_Login_Script.ValidateResetPassword");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ValidateCreateNewAccount;
    /// <summary>
    /// Function: ValidateCreateNewAccount
    /// </summary>
    public unsafe virtual void ValidateCreateNewAccount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ValidateCreateNewAccount, "BmScript.RGFxMovieUI_WarnerID_Login_Script.ValidateCreateNewAccount");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ValidateLoginAttempt;
    /// <summary>
    /// Function: ValidateLoginAttempt
    /// </summary>
    public unsafe virtual void ValidateLoginAttempt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ValidateLoginAttempt, "BmScript.RGFxMovieUI_WarnerID_Login_Script.ValidateLoginAttempt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPasswordEntered;
    /// <summary>
    /// Function: OnPasswordEntered
    /// </summary>
    public unsafe virtual void OnPasswordEntered(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPasswordEntered, "BmScript.RGFxMovieUI_WarnerID_Login_Script.OnPasswordEntered");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnEmailAddressEntered;
    /// <summary>
    /// Function: OnEmailAddressEntered
    /// </summary>
    public unsafe virtual void OnEmailAddressEntered(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEmailAddressEntered, "BmScript.RGFxMovieUI_WarnerID_Login_Script.OnEmailAddressEntered");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsValidEmailAddress;
    /// <summary>
    /// Function: IsValidEmailAddress
    /// </summary>
    public unsafe virtual bool IsValidEmailAddress(BmSDK.FString AddressString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidEmailAddress, "BmScript.RGFxMovieUI_WarnerID_Login_Script.IsValidEmailAddress");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddressString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_HasIllegalFullstops;
    /// <summary>
    /// Function: HasIllegalFullstops
    /// </summary>
    public unsafe virtual bool HasIllegalFullstops(BmSDK.FString AddressString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasIllegalFullstops, "BmScript.RGFxMovieUI_WarnerID_Login_Script.HasIllegalFullstops");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddressString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_OnClicked;
    /// <summary>
    /// Function: OnClicked
    /// </summary>
    public unsafe override void OnClicked(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClicked, "BmScript.RGFxMovieUI_WarnerID_Login_Script.OnClicked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupScreenPrompts, "BmScript.RGFxMovieUI_WarnerID_Login_Script.SetupScreenPrompts");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBack, "BmScript.RGFxMovieUI_WarnerID_Login_Script.OnBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLostFocus, "BmScript.RGFxMovieUI_WarnerID_Login_Script.OnLostFocus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFocus;
    /// <summary>
    /// Function: OnFocus
    /// </summary>
    public unsafe override void OnFocus(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFocus, "BmScript.RGFxMovieUI_WarnerID_Login_Script.OnFocus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentState;
    /// <summary>
    /// Function: SetCurrentState
    /// </summary>
    public unsafe virtual void SetCurrentState(BmSDK.BmScript.RGFxMovieUI_WarnerID_Login_Script.WarnerIDState NewState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentState, "BmScript.RGFxMovieUI_WarnerID_Login_Script.SetCurrentState");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishWBIDLinkage;
    /// <summary>
    /// Function: FinishWBIDLinkage
    /// </summary>
    public unsafe virtual void FinishWBIDLinkage(bool bSuccess)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishWBIDLinkage, "BmScript.RGFxMovieUI_WarnerID_Login_Script.FinishWBIDLinkage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccess, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWBIDTimeout;
    /// <summary>
    /// Function: OnWBIDTimeout
    /// </summary>
    public unsafe virtual void OnWBIDTimeout()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWBIDTimeout, "BmScript.RGFxMovieUI_WarnerID_Login_Script.OnWBIDTimeout");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLinkWbidAndFireteamCB;
    /// <summary>
    /// Function: OnLinkWbidAndFireteamCB
    /// </summary>
    public unsafe virtual void OnLinkWbidAndFireteamCB(BmSDK.Engine.SDHttpRequest Request, BmSDK.FString Data)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLinkWbidAndFireteamCB, "BmScript.RGFxMovieUI_WarnerID_Login_Script.OnLinkWbidAndFireteamCB");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LinkWbidAndFireteam;
    /// <summary>
    /// Function: LinkWbidAndFireteam
    /// </summary>
    public unsafe virtual void LinkWbidAndFireteam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LinkWbidAndFireteam, "BmScript.RGFxMovieUI_WarnerID_Login_Script.LinkWbidAndFireteam");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLegalText;
    /// <summary>
    /// Function: GetLegalText
    /// </summary>
    public unsafe virtual void GetLegalText(bool getTOS)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLegalText, "BmScript.RGFxMovieUI_WarnerID_Login_Script.GetLegalText");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(getTOS, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLegalTextFont;
    /// <summary>
    /// Function: SetLegalTextFont
    /// </summary>
    public unsafe virtual void SetLegalTextFont(BmSDK.FString FontName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLegalTextFont, "BmScript.RGFxMovieUI_WarnerID_Login_Script.SetLegalTextFont");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FontName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPathPP;
    /// <summary>
    /// Function: GetPathPP
    /// </summary>
    public unsafe virtual BmSDK.FString GetPathPP(BmSDK.FString Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPathPP, "BmScript.RGFxMovieUI_WarnerID_Login_Script.GetPathPP");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetPathTOS;
    /// <summary>
    /// Function: GetPathTOS
    /// </summary>
    public unsafe virtual BmSDK.FString GetPathTOS(BmSDK.FString Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPathTOS, "BmScript.RGFxMovieUI_WarnerID_Login_Script.GetPathTOS");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmScript.RGFxMovieUI_WarnerID_Login_Script.CloseScreen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllDone;
    /// <summary>
    /// Function: AllDone
    /// </summary>
    public unsafe override void AllDone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllDone, "BmScript.RGFxMovieUI_WarnerID_Login_Script.AllDone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAllDone;
    /// <summary>
    /// Function: SetAllDone
    /// </summary>
    public unsafe virtual void SetAllDone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllDone, "BmScript.RGFxMovieUI_WarnerID_Login_Script.SetAllDone");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.RGFxMovieUI_WarnerID_Login_Script.Init");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsNotConsole;
    /// <summary>
    /// Function: IsNotConsole
    /// </summary>
    public unsafe virtual bool IsNotConsole()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNotConsole, "BmScript.RGFxMovieUI_WarnerID_Login_Script.IsNotConsole");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetConsoleString;
    /// <summary>
    /// Function: GetConsoleString
    /// </summary>
    public unsafe virtual BmSDK.FString GetConsoleString()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetConsoleString, "BmScript.RGFxMovieUI_WarnerID_Login_Script.GetConsoleString");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPS3;
    /// <summary>
    /// Function: IsPS3
    /// </summary>
    public unsafe virtual bool IsPS3()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPS3, "BmScript.RGFxMovieUI_WarnerID_Login_Script.IsPS3");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: WarnerIDState
    /// </summary>
    public enum WarnerIDState : byte
    {
        WBID_None = 0,
        WBID_WaitingForSteamTicket = 1,
        WBID_AutoLogin = 2,
        WBID_Intro = 3,
        WBID_CreateOrSkip = 4,
        WBID_ContinueOrSkip = 5,
        WBID_ConfirmSkip = 6,
        WBID_TermsOfService = 7,
        WBID_PrivacyPolicy = 8,
        WBID_Instructions = 9,
        WBID_GetEmail = 10,
        WBID_GotEmail = 11,
        WBID_GetPassword = 12,
        WBID_GotPassword = 13,
        WBID_ConfirmPassword = 14,
        WBID_ConfirmedPassword = 15,
        WBID_CheckingLogin = 16,
        WBID_LoginFailed = 17,
        WBID_CreatingNewAccount = 18,
        WBID_ForgotPassword = 19,
        WBID_InvalidEmail = 20,
        WBID_EmailInUse = 21,
        WBID_InvalidPassword = 22,
        WBID_PasswordNoMatch = 23,
        WBID_GetNewPassword = 24,
        WBID_GotNewPassword = 25,
        WBID_ResettingPassword = 26,
        WBID_AccountCreated = 27,
        WBID_LoggedIn = 28,
        WBID_LoggedInVerified = 29,
        WBID_SubscriptionInfo = 30,
        WBID_AutoLoginSubscriptionInfo = 31,
        WBID_FetchThirdPartyTicket = 32,
        WBID_FireteamAssociation = 33,
        WBID_Underage = 34,
        WBID_InvalidCountry = 35,
        WBID_UnexpectedError = 36,
        WBID_AlreadySignedUp = 37,
        WBID_LoginingIn = 38,
        WBID_MAX = 39,
    }

    /// <summary>
    /// InterfaceProperty: PlayerInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlinePlayerInterface PlayerInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePlayerInterface>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bFlashInitalised
    /// </summary>
    public unsafe bool bFlashInitalised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bAllDone
    /// </summary>
    public unsafe bool bAllDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: CreateOrSkipChoiceIsCreateVsLogin
    /// </summary>
    public unsafe bool CreateOrSkipChoiceIsCreateVsLogin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: PasswordResetCallbackReceived
    /// </summary>
    public unsafe bool PasswordResetCallbackReceived
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: CreateVsContinue
    /// </summary>
    public unsafe bool CreateVsContinue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: IsOnline
    /// </summary>
    public unsafe bool IsOnline
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bPS3LoggingIn
    /// </summary>
    public unsafe bool bPS3LoggingIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bPS3LoginFailed
    /// </summary>
    public unsafe bool bPS3LoginFailed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: HasInitializedBackend
    /// </summary>
    public unsafe bool HasInitializedBackend
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bFetchThirdpartyTicket
    /// </summary>
    public unsafe bool bFetchThirdpartyTicket
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: WbidLoginTimeoutSet
    /// </summary>
    public unsafe bool WbidLoginTimeoutSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// ByteProperty: CurrentState
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_WarnerID_Login_Script.WarnerIDState CurrentState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_WarnerID_Login_Script.WarnerIDState>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ByteProperty: KeyboardReturnState
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_WarnerID_Login_Script.WarnerIDState KeyboardReturnState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_WarnerID_Login_Script.WarnerIDState>(Ptr + 945); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 945); }
    }

    /// <summary>
    /// FloatProperty: WbidLoginTimer
    /// </summary>
    public unsafe float WbidLoginTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// DelegateProperty: __GetPathTOS__Delegate
    /// </summary>
    public unsafe System.IntPtr __GetPathTOS__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// DelegateProperty: __GetPathPP__Delegate
    /// </summary>
    public unsafe System.IntPtr __GetPathPP__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// DelegateProperty: __OnEmailAddressEntered__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnEmailAddressEntered__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// DelegateProperty: __OnPasswordEntered__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnPasswordEntered__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }
}
