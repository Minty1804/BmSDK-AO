#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MGFxMovieControllerDarkKnightMain<br/>
/// (size = 776)
/// (flags = 30)
/// </summary>
public partial class MGFxMovieControllerDarkKnightMain : BmSDK.BmGame.MGFxMovieControllerBCScreen, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MGFxMovieControllerDarkKnightMain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGFxMovieControllerDarkKnightMain.
    /// </summary>
    public static MGFxMovieControllerDarkKnightMain DefaultObject => (MGFxMovieControllerDarkKnightMain)StaticClass().DefaultObject;

    internal MGFxMovieControllerDarkKnightMain() { }

    /// <summary>
    /// Constructs a new MGFxMovieControllerDarkKnightMain
    /// </summary>
    public MGFxMovieControllerDarkKnightMain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxMovieControllerDarkKnightMain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxMovieControllerDarkKnightMain(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDarkKnightMain>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDarkKnightMain>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDarkKnightMain>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDarkKnightMain>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDarkKnightMain>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDarkKnightMain>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDarkKnightMain>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDarkKnightMain>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ChangeStates;
    /// <summary>
    /// Function: ChangeStates
    /// </summary>
    public unsafe override void ChangeStates(int Direction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeStates, "BmGame.MGFxMovieControllerDarkKnightMain.ChangeStates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBack;
    /// <summary>
    /// Function: OnBack
    /// </summary>
    public unsafe override bool OnBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBack, "BmGame.MGFxMovieControllerDarkKnightMain.OnBack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnA;
    /// <summary>
    /// Function: OnA
    /// </summary>
    public unsafe override bool OnA()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnA, "BmGame.MGFxMovieControllerDarkKnightMain.OnA");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NavigateTo;
    /// <summary>
    /// Function: NavigateTo
    /// </summary>
    public unsafe virtual void NavigateTo(BmSDK.GFxUI.GFxObject Event)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavigateTo, "BmGame.MGFxMovieControllerDarkKnightMain.NavigateTo");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IntroComplete;
    /// <summary>
    /// Function: IntroComplete
    /// </summary>
    public unsafe override void IntroComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IntroComplete, "BmGame.MGFxMovieControllerDarkKnightMain.IntroComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScreenButton_Selected;
    /// <summary>
    /// Function: ScreenButton_Selected
    /// </summary>
    public unsafe virtual void ScreenButton_Selected(BmSDK.GFxUI.GFxObject Event)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScreenButton_Selected, "BmGame.MGFxMovieControllerDarkKnightMain.ScreenButton_Selected");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScreenButton_Clicked;
    /// <summary>
    /// Function: ScreenButton_Clicked
    /// </summary>
    public unsafe virtual void ScreenButton_Clicked(BmSDK.GFxUI.GFxObject Event)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScreenButton_Clicked, "BmGame.MGFxMovieControllerDarkKnightMain.ScreenButton_Clicked");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetUnloaded, "BmGame.MGFxMovieControllerDarkKnightMain.WidgetUnloaded");
        byte* paramsPtr = stackalloc byte[44];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetInitialized, "BmGame.MGFxMovieControllerDarkKnightMain.WidgetInitialized");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// ArrayProperty: ScreenButtons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MGFxWidgetDarkKnightScreenButton> ScreenButtons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MGFxWidgetDarkKnightScreenButton>>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ObjectProperty: InfoDescriptionBar
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidgetDescriptionBar InfoDescriptionBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidgetDescriptionBar>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: DarkKnightMain
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidget DarkKnightMain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidget>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ObjectProperty: LastRecievedSelectEvent
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject LastRecievedSelectEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }
}
