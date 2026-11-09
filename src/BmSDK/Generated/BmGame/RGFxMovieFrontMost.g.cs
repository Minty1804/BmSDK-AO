#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieFrontMost<br/>
/// (size = 632)
/// (flags = 134217878)
/// </summary>
public partial class RGFxMovieFrontMost : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieFrontMost", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieFrontMost.
    /// </summary>
    public static RGFxMovieFrontMost DefaultObject => (RGFxMovieFrontMost)StaticClass().DefaultObject;

    internal RGFxMovieFrontMost() { }

    /// <summary>
    /// Constructs a new RGFxMovieFrontMost
    /// </summary>
    public RGFxMovieFrontMost(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieFrontMost Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieFrontMost(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieFrontMost>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DeactivateFade;
    /// <summary>
    /// Function: DeactivateFade
    /// </summary>
    public unsafe virtual void DeactivateFade(bool Deactivate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateFade, "BmGame.RGFxMovieFrontMost.DeactivateFade");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Deactivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PromptClicked;
    /// <summary>
    /// Function: PromptClicked
    /// </summary>
    public unsafe virtual void PromptClicked(int PromptId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PromptClicked, "BmGame.RGFxMovieFrontMost.PromptClicked");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PromptId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPromptManagerObject;
    /// <summary>
    /// Function: GetPromptManagerObject
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGFxWidgetPromptManager GetPromptManagerObject()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPromptManagerObject, "BmGame.RGFxMovieFrontMost.GetPromptManagerObject");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MGFxWidgetPromptManager>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPromptMode;
    /// <summary>
    /// Function: SetPromptMode
    /// </summary>
    public unsafe virtual void SetPromptMode(bool bLeft, bool bVertical)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPromptMode, "BmGame.RGFxMovieFrontMost.SetPromptMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeft, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVertical, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMainPromptAtY;
    /// <summary>
    /// Function: SetMainPromptAtY
    /// </summary>
    public unsafe virtual void SetMainPromptAtY(float atY)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMainPromptAtY, "BmGame.RGFxMovieFrontMost.SetMainPromptAtY");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReFetchAndRebuildAllPrompts;
    /// <summary>
    /// Function: ReFetchAndRebuildAllPrompts
    /// </summary>
    public unsafe virtual void ReFetchAndRebuildAllPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReFetchAndRebuildAllPrompts, "BmGame.RGFxMovieFrontMost.ReFetchAndRebuildAllPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReFetchAndBuildPrompts;
    /// <summary>
    /// Function: ReFetchAndBuildPrompts
    /// </summary>
    public unsafe virtual void ReFetchAndBuildPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReFetchAndBuildPrompts, "BmGame.RGFxMovieFrontMost.ReFetchAndBuildPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RebuildPrompts;
    /// <summary>
    /// Function: RebuildPrompts
    /// </summary>
    public unsafe virtual void RebuildPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RebuildPrompts, "BmGame.RGFxMovieFrontMost.RebuildPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMainPrompt;
    /// <summary>
    /// Function: SetMainPrompt
    /// </summary>
    public unsafe virtual void SetMainPrompt(int Id, BmSDK.FString Label, float Alpha, float TextAlpha)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMainPrompt, "BmGame.RGFxMovieFrontMost.SetMainPrompt");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextAlpha, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrompt;
    /// <summary>
    /// Function: SetPrompt
    /// </summary>
    public unsafe virtual void SetPrompt(int Id, BmSDK.FString Label, float Alpha, float TextAlpha)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrompt, "BmGame.RGFxMovieFrontMost.SetPrompt");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextAlpha, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReLayoutPrompts;
    /// <summary>
    /// Function: ReLayoutPrompts
    /// </summary>
    public unsafe virtual void ReLayoutPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReLayoutPrompts, "BmGame.RGFxMovieFrontMost.ReLayoutPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPrompts;
    /// <summary>
    /// Function: ClearPrompts
    /// </summary>
    public unsafe virtual void ClearPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPrompts, "BmGame.RGFxMovieFrontMost.ClearPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowMouseRequest;
    /// <summary>
    /// Function: ShowMouseRequest
    /// </summary>
    public unsafe virtual void ShowMouseRequest(bool bShowMouse)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowMouseRequest, "BmGame.RGFxMovieFrontMost.ShowMouseRequest");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowMouse, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMouseCursorEnabled;
    /// <summary>
    /// Function: SetMouseCursorEnabled
    /// </summary>
    public unsafe virtual void SetMouseCursorEnabled(bool is_enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMouseCursorEnabled, "BmGame.RGFxMovieFrontMost.SetMouseCursorEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSavingError;
    /// <summary>
    /// Function: TriggerSavingError
    /// </summary>
    public unsafe virtual void TriggerSavingError()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSavingError, "BmGame.RGFxMovieFrontMost.TriggerSavingError");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsGameSaving;
    /// <summary>
    /// Function: IsGameSaving
    /// </summary>
    public unsafe virtual int IsGameSaving()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGameSaving, "BmGame.RGFxMovieFrontMost.IsGameSaving");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsSaving;
    /// <summary>
    /// Function: IsSaving
    /// </summary>
    public unsafe virtual int IsSaving()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSaving, "BmGame.RGFxMovieFrontMost.IsSaving");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShowLoadingPrompt;
    /// <summary>
    /// Function: ShowLoadingPrompt
    /// </summary>
    public unsafe virtual void ShowLoadingPrompt(bool bShow, bool bForceOff = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowLoadingPrompt, "BmGame.RGFxMovieFrontMost.ShowLoadingPrompt");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSkipPrompt;
    /// <summary>
    /// Function: ShowSkipPrompt
    /// </summary>
    public unsafe virtual void ShowSkipPrompt(bool bShow, bool bForceOff = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSkipPrompt, "BmGame.RGFxMovieFrontMost.ShowSkipPrompt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleSavingIcon;
    /// <summary>
    /// Function: ToggleSavingIcon
    /// </summary>
    public unsafe virtual void ToggleSavingIcon(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleSavingIcon, "BmGame.RGFxMovieFrontMost.ToggleSavingIcon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSimpleFadeRGB;
    /// <summary>
    /// Function: SetSimpleFadeRGB
    /// </summary>
    public unsafe virtual void SetSimpleFadeRGB(float Opacity, byte ColorR, byte ColorG, byte ColorB)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSimpleFadeRGB, "BmGame.RGFxMovieFrontMost.SetSimpleFadeRGB");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Opacity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ColorR, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ColorG, paramsPtr + 5);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ColorB, paramsPtr + 6);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSimpleFadeLastRGB;
    /// <summary>
    /// Function: GetSimpleFadeLastRGB
    /// </summary>
    public unsafe virtual float GetSimpleFadeLastRGB()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSimpleFadeLastRGB, "BmGame.RGFxMovieFrontMost.GetSimpleFadeLastRGB");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSimpleFadeLastOpacity;
    /// <summary>
    /// Function: GetSimpleFadeLastOpacity
    /// </summary>
    public unsafe virtual float GetSimpleFadeLastOpacity()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSimpleFadeLastOpacity, "BmGame.RGFxMovieFrontMost.GetSimpleFadeLastOpacity");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetSimpleFade;
    /// <summary>
    /// Function: SetSimpleFade
    /// </summary>
    public unsafe virtual void SetSimpleFade(float Opacity, int RGB = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSimpleFade, "BmGame.RGFxMovieFrontMost.SetSimpleFade");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Opacity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RGB, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeInRGB;
    /// <summary>
    /// Function: FadeInRGB
    /// </summary>
    public unsafe virtual void FadeInRGB(float OverSecs, int RGB = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeInRGB, "BmGame.RGFxMovieFrontMost.FadeInRGB");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverSecs, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RGB, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeOutRGB;
    /// <summary>
    /// Function: FadeOutRGB
    /// </summary>
    public unsafe virtual void FadeOutRGB(float OverSecs, int RGB = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeOutRGB, "BmGame.RGFxMovieFrontMost.FadeOutRGB");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverSecs, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RGB, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeAnimatedDone_CB;
    /// <summary>
    /// Function: FadeAnimatedDone_CB
    /// </summary>
    public unsafe virtual void FadeAnimatedDone_CB(bool bBlackscreen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeAnimatedDone_CB, "BmGame.RGFxMovieFrontMost.FadeAnimatedDone_CB");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlackscreen, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeCallbackMe;
    /// <summary>
    /// Function: FadeCallbackMe
    /// </summary>
    public unsafe virtual void FadeCallbackMe(BmSDK.BmGame.RGFxMovie CallMeBack)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeCallbackMe, "BmGame.RGFxMovieFrontMost.FadeCallbackMe");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CallMeBack, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerFadeIn;
    /// <summary>
    /// Function: TriggerFadeIn
    /// </summary>
    public unsafe virtual void TriggerFadeIn(BmSDK.BmGame.RGFxMovieFrontMost.AnimatedFadeType FadeType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFadeIn, "BmGame.RGFxMovieFrontMost.TriggerFadeIn");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerFadeOut;
    /// <summary>
    /// Function: TriggerFadeOut
    /// </summary>
    public unsafe virtual void TriggerFadeOut(BmSDK.BmGame.RGFxMovieFrontMost.AnimatedFadeType FadeType, bool bInstantly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFadeOut, "BmGame.RGFxMovieFrontMost.TriggerFadeOut");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstantly, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSubtitles;
    /// <summary>
    /// Function: SetSubtitles
    /// </summary>
    public unsafe virtual void SetSubtitles(BmSDK.FString TheText, int Justification, int TextColour = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSubtitles, "BmGame.RGFxMovieFrontMost.SetSubtitles");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheText, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Justification, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextColour, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSubtitles_set;
    /// <summary>
    /// Function: SetSubtitles_set
    /// </summary>
    public unsafe virtual void SetSubtitles_set(BmSDK.FString TheText, int Justification, int TextColour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSubtitles_set, "BmGame.RGFxMovieFrontMost.SetSubtitles_set");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheText, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Justification, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextColour, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearTutorialHint;
    /// <summary>
    /// Function: ClearTutorialHint
    /// </summary>
    public unsafe virtual void ClearTutorialHint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearTutorialHint, "BmGame.RGFxMovieFrontMost.ClearTutorialHint");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTutorialHint;
    /// <summary>
    /// Function: SetTutorialHint
    /// </summary>
    public unsafe virtual void SetTutorialHint(BmSDK.FString TheText, float XPosition, float YPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTutorialHint, "BmGame.RGFxMovieFrontMost.SetTutorialHint");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheText, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPosition, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YPosition, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetToolTip;
    /// <summary>
    /// Function: SetToolTip
    /// </summary>
    public unsafe override void SetToolTip(BmSDK.FString TheText = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetToolTip, "BmGame.RGFxMovieFrontMost.SetToolTip");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheText, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_FadeInMC;
    /// <summary>
    /// Function: FadeInMC
    /// </summary>
    public unsafe virtual void FadeInMC(BmSDK.FString FadeName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeInMC, "BmGame.RGFxMovieFrontMost.FadeInMC");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeOutMC;
    /// <summary>
    /// Function: FadeOutMC
    /// </summary>
    public unsafe virtual void FadeOutMC(BmSDK.FString FadeName, bool bInstantly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeOutMC, "BmGame.RGFxMovieFrontMost.FadeOutMC");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstantly, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSafeFrame;
    /// <summary>
    /// Function: ShowSafeFrame
    /// </summary>
    public unsafe virtual void ShowSafeFrame(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSafeFrame, "BmGame.RGFxMovieFrontMost.ShowSafeFrame");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopLoopRGBShift;
    /// <summary>
    /// Function: StopLoopRGBShift
    /// </summary>
    public unsafe virtual void StopLoopRGBShift()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLoopRGBShift, "BmGame.RGFxMovieFrontMost.StopLoopRGBShift");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartLoopRGBShift;
    /// <summary>
    /// Function: StartLoopRGBShift
    /// </summary>
    public unsafe virtual void StartLoopRGBShift()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartLoopRGBShift, "BmGame.RGFxMovieFrontMost.StartLoopRGBShift");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerLoopRGBShift;
    /// <summary>
    /// Function: TriggerLoopRGBShift
    /// </summary>
    public unsafe virtual void TriggerLoopRGBShift()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerLoopRGBShift, "BmGame.RGFxMovieFrontMost.TriggerLoopRGBShift");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCameraRGBShift;
    /// <summary>
    /// Function: TriggerCameraRGBShift
    /// </summary>
    public unsafe virtual void TriggerCameraRGBShift()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCameraRGBShift, "BmGame.RGFxMovieFrontMost.TriggerCameraRGBShift");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerTransitionRGBShift;
    /// <summary>
    /// Function: TriggerTransitionRGBShift
    /// </summary>
    public unsafe virtual void TriggerTransitionRGBShift()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerTransitionRGBShift, "BmGame.RGFxMovieFrontMost.TriggerTransitionRGBShift");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRGBShiftParams;
    /// <summary>
    /// Function: SetRGBShiftParams
    /// </summary>
    public unsafe virtual void SetRGBShiftParams(int RdX, int RdY, int GdX, int GdY, int BdX, int BdY)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRGBShiftParams, "BmGame.RGFxMovieFrontMost.SetRGBShiftParams");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RdX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RdY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GdX, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GdY, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BdX, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BdY, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieFrontMost.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetUnloaded, "BmGame.RGFxMovieFrontMost.WidgetUnloaded");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetInitialized, "BmGame.RGFxMovieFrontMost.WidgetInitialized");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ShouldFade;
    /// <summary>
    /// Function: ShouldFade
    /// </summary>
    public unsafe virtual bool ShouldFade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldFade, "BmGame.RGFxMovieFrontMost.ShouldFade");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: SubtitleJustify
    /// </summary>
    public enum SubtitleJustify : byte
    {
        SUBS_LeftAlign = 0,
        SUBS_Centered = 1,
        SUBS_RightAlign = 2,
        SUBS_MAX = 3,
    }

    /// <summary>
    /// ArrayProperty: FadeNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> FadeNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: RGBShifter
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidget RGBShifter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidget>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ObjectProperty: OnFadedMovieToCallback
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovie OnFadedMovieToCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovie>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// StrProperty: SubtitlesLast
    /// </summary>
    public unsafe BmSDK.FString SubtitlesLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: LastFadeOpacity
    /// </summary>
    public unsafe float LastFadeOpacity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: LastFadeRGB
    /// </summary>
    public unsafe float LastFadeRGB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// BoolProperty: CanPause
    /// </summary>
    public unsafe bool CanPause
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 628); }
    }

    /// <summary>
    /// Enum: AnimatedFadeType
    /// </summary>
    public enum AnimatedFadeType : byte
    {
        AF_Fade_Bats = 0,
        AF_Fade_Riddler = 1,
        AF_Fade_MAX = 2,
    }
}
