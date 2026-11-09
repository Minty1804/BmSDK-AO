#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MGFxMovieControllerDatabaseGothamIntelligence<br/>
/// (size = 792)
/// (flags = 30)
/// </summary>
public partial class MGFxMovieControllerDatabaseGothamIntelligence : BmSDK.BmGame.MGFxMovieControllerBCScreen, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGFxMovieControllerDatabaseGothamIntelligence.
    /// </summary>
    public static MGFxMovieControllerDatabaseGothamIntelligence DefaultObject => (MGFxMovieControllerDatabaseGothamIntelligence)StaticClass().DefaultObject;

    internal MGFxMovieControllerDatabaseGothamIntelligence() { }

    /// <summary>
    /// Constructs a new MGFxMovieControllerDatabaseGothamIntelligence
    /// </summary>
    public MGFxMovieControllerDatabaseGothamIntelligence(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxMovieControllerDatabaseGothamIntelligence Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxMovieControllerDatabaseGothamIntelligence(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDatabaseGothamIntelligence>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDatabaseGothamIntelligence>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDatabaseGothamIntelligence>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDatabaseGothamIntelligence>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDatabaseGothamIntelligence>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDatabaseGothamIntelligence>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDatabaseGothamIntelligence>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxMovieControllerDatabaseGothamIntelligence>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IntroComplete;
    /// <summary>
    /// Function: IntroComplete
    /// </summary>
    public unsafe override void IntroComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IntroComplete, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence.IntroComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupFeedBackPanel;
    /// <summary>
    /// Function: SetupFeedBackPanel
    /// </summary>
    public unsafe override void SetupFeedBackPanel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupFeedBackPanel, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence.SetupFeedBackPanel");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshButtonCallouts;
    /// <summary>
    /// Function: RefreshButtonCallouts
    /// </summary>
    public unsafe override void RefreshButtonCallouts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshButtonCallouts, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence.RefreshButtonCallouts");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateLargeIntelImage;
    /// <summary>
    /// Function: UpdateLargeIntelImage
    /// </summary>
    public unsafe virtual void UpdateLargeIntelImage(int intelId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLargeIntelImage, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence.UpdateLargeIntelImage");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(intelId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnA;
    /// <summary>
    /// Function: OnA
    /// </summary>
    public unsafe override bool OnA()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnA, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence.OnA");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnB;
    /// <summary>
    /// Function: OnB
    /// </summary>
    public unsafe override bool OnB()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnB, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence.OnB");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GoToDescription;
    /// <summary>
    /// Function: GoToDescription
    /// </summary>
    public unsafe virtual void GoToDescription(int goToButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoToDescription, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence.GoToDescription");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(goToButtonId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IntelButton_Clicked;
    /// <summary>
    /// Function: IntelButton_Clicked
    /// </summary>
    public unsafe virtual void IntelButton_Clicked(BmSDK.GFxUI.GFxObject Event)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IntelButton_Clicked, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence.IntelButton_Clicked");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IntelButton_Selected;
    /// <summary>
    /// Function: IntelButton_Selected
    /// </summary>
    public unsafe virtual void IntelButton_Selected(BmSDK.GFxUI.GFxObject Event)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IntelButton_Selected, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence.IntelButton_Selected");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupIntelButton;
    /// <summary>
    /// Function: SetupIntelButton
    /// </summary>
    public unsafe virtual void SetupIntelButton(int intelId, BmSDK.GFxUI.GFxObject Widget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupIntelButton, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence.SetupIntelButton");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(intelId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_getThumbIndex;
    /// <summary>
    /// Function: getThumbIndex
    /// </summary>
    public unsafe virtual int getThumbIndex(BmSDK.FString WidgetName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_getThumbIndex, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence.getThumbIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_WidgetUnloaded;
    /// <summary>
    /// Function: WidgetUnloaded
    /// </summary>
    public unsafe override bool WidgetUnloaded(BmSDK.FName WidgetName, BmSDK.FName WidgetPath, BmSDK.GFxUI.GFxObject Widget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetUnloaded, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence.WidgetUnloaded");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetInitialized, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence.WidgetInitialized");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.MGFxMovieControllerDatabaseGothamIntelligence.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: MainScreen
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidget MainScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidget>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ObjectProperty: PanelTitle
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidget PanelTitle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidget>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: DescriptionText
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidget DescriptionText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidget>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ObjectProperty: LargeImage
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidget LargeImage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidget>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: LastRecievedSelectEvent
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject LastRecievedSelectEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ArrayProperty: Buttons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MGFxWidget> Buttons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MGFxWidget>>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// IntProperty: SelectedButtonID
    /// </summary>
    public unsafe int SelectedButtonID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// IntProperty: SelectedGothamIntel
    /// </summary>
    public unsafe int SelectedGothamIntel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }
}
