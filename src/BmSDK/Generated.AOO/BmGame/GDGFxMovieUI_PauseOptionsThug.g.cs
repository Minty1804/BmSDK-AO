#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDGFxMovieUI_PauseOptionsThug<br/>
/// (size = 2048)
/// (flags = 32790)
/// </summary>
public partial class GDGFxMovieUI_PauseOptionsThug : BmSDK.BmGame.RGFxMovieUI_PauseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGFxMovieUI_PauseOptionsThug", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGFxMovieUI_PauseOptionsThug.
    /// </summary>
    public static GDGFxMovieUI_PauseOptionsThug DefaultObject => (GDGFxMovieUI_PauseOptionsThug)StaticClass().DefaultObject;

    internal GDGFxMovieUI_PauseOptionsThug() { }

    /// <summary>
    /// Constructs a new GDGFxMovieUI_PauseOptionsThug
    /// </summary>
    public GDGFxMovieUI_PauseOptionsThug(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDGFxMovieUI_PauseOptionsThug Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGFxMovieUI_PauseOptionsThug(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_PauseOptionsThug>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_PauseOptionsThug>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_PauseOptionsThug>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_PauseOptionsThug>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_PauseOptionsThug>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_PauseOptionsThug>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_PauseOptionsThug>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_PauseOptionsThug>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetButtonVarData;
    /// <summary>
    /// Function: SetButtonVarData
    /// </summary>
    public unsafe override void SetButtonVarData(BmSDK.FString VariableName, float VarVal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetButtonVarData, "BmGame.GDGFxMovieUI_PauseOptionsThug.SetButtonVarData");
        byte* paramsPtr = stackalloc byte[36];
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
    public unsafe override int GetDefaultButtonVarData(BmSDK.FString VariableName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultButtonVarData, "BmGame.GDGFxMovieUI_PauseOptionsThug.GetDefaultButtonVarData");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetCurrentButtonVarData;
    /// <summary>
    /// Function: GetCurrentButtonVarData
    /// </summary>
    public unsafe override int GetCurrentButtonVarData(BmSDK.FString VariableName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentButtonVarData, "BmGame.GDGFxMovieUI_PauseOptionsThug.GetCurrentButtonVarData");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ListButtonPressY;
    /// <summary>
    /// Function: ListButtonPressY
    /// </summary>
    public unsafe override void ListButtonPressY(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListButtonPressY, "BmGame.GDGFxMovieUI_PauseOptionsThug.ListButtonPressY");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListButtonSetFocus, "BmGame.GDGFxMovieUI_PauseOptionsThug.ListButtonSetFocus");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetButtonListToolTip;
    /// <summary>
    /// Function: SetButtonListToolTip
    /// </summary>
    public unsafe override void SetButtonListToolTip(BmSDK.FString VariableName = default, BmSDK.FString StateName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetButtonListToolTip, "BmGame.GDGFxMovieUI_PauseOptionsThug.SetButtonListToolTip");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 12);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_ControllerImageLoaded_CB;
    /// <summary>
    /// Function: ControllerImageLoaded_CB
    /// </summary>
    public unsafe override void ControllerImageLoaded_CB()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ControllerImageLoaded_CB, "BmGame.GDGFxMovieUI_PauseOptionsThug.ControllerImageLoaded_CB");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerButtonPress, "BmGame.GDGFxMovieUI_PauseOptionsThug.TriggerButtonPress");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClosed, "BmGame.GDGFxMovieUI_PauseOptionsThug.OnClosed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmGame.GDGFxMovieUI_PauseOptionsThug.CloseScreen");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUScriptDeclaredButtonData, "BmGame.GDGFxMovieUI_PauseOptionsThug.AddUScriptDeclaredButtonData");
        byte* paramsPtr = stackalloc byte[20];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.GDGFxMovieUI_PauseOptionsThug.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: CTOMenuItem
    /// </summary>
    public enum CTOMenuItem : byte
    {
        PCTO_None = 0,
        PCTO_AutoSwitchEmptyWeapon = 1,
        PCTO_InvertLook = 2,
        PCTO_LookSensitivityX = 3,
        PCTO_LookSensitivityY = 4,
        PCTO_AimAssistance = 5,
        PCTO_TriggerBumperSwap = 6,
        PCTO_InvertGagdetFlight = 7,
        PCTO_LRStickClickSwap = 8,
        PCTO_ControlMap = 9,
        PCTO_Back = 10,
        PCTO_MAX = 11,
    }
}
