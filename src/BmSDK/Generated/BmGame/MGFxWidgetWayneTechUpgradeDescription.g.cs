#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MGFxWidgetWayneTechUpgradeDescription<br/>
/// (size = 300)
/// (flags = 18)
/// </summary>
public partial class MGFxWidgetWayneTechUpgradeDescription : BmSDK.BmGame.MGFxWidget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MGFxWidgetWayneTechUpgradeDescription", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGFxWidgetWayneTechUpgradeDescription.
    /// </summary>
    public static MGFxWidgetWayneTechUpgradeDescription DefaultObject => (MGFxWidgetWayneTechUpgradeDescription)StaticClass().DefaultObject;

    internal MGFxWidgetWayneTechUpgradeDescription() { }

    /// <summary>
    /// Constructs a new MGFxWidgetWayneTechUpgradeDescription
    /// </summary>
    public MGFxWidgetWayneTechUpgradeDescription(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxWidgetWayneTechUpgradeDescription Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxWidgetWayneTechUpgradeDescription(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetWayneTechUpgradeDescription>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetWayneTechUpgradeDescription>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetWayneTechUpgradeDescription>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetWayneTechUpgradeDescription>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetWayneTechUpgradeDescription>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetWayneTechUpgradeDescription>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetWayneTechUpgradeDescription>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetWayneTechUpgradeDescription>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetTextandAutosizeWithBox;
    /// <summary>
    /// Function: SetTextandAutosizeWithBox
    /// </summary>
    public unsafe virtual float SetTextandAutosizeWithBox(BmSDK.GFxUI.GFxObject O, BmSDK.FString Text, bool isDescription, float increasedTextWidth, out float Width)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTextandAutosizeWithBox, "BmGame.MGFxWidgetWayneTechUpgradeDescription.SetTextandAutosizeWithBox");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isDescription, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(increasedTextWidth, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Width);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Width, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Width = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_SetDescription;
    /// <summary>
    /// Function: SetDescription
    /// </summary>
    public unsafe virtual void SetDescription(BmSDK.BmGame.MGFxWidgetWayneTechUpgrade Upgrade, BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability, BmSDK.BmGame.MWayneTechUpgradeSystem.EWayneTechCategory cat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDescription, "BmGame.MGFxWidgetWayneTechUpgradeDescription.SetDescription");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Upgrade, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cat, paramsPtr + 5);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.BmGame.RGameInfo pRGI, BmSDK.BmGame.MGFxMovieControllerBCScreen parentMovieController)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.MGFxWidgetWayneTechUpgradeDescription.Init");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pRGI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(parentMovieController, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetUnloaded, "BmGame.MGFxWidgetWayneTechUpgradeDescription.WidgetUnloaded");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetInitialized, "BmGame.MGFxWidgetWayneTechUpgradeDescription.WidgetInitialized");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// ObjectProperty: Section
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject Section
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ObjectProperty: Section_Box
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject Section_Box
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// ObjectProperty: Title
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject Title
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ObjectProperty: Title_Box
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject Title_Box
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ObjectProperty: Description
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject Description
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ObjectProperty: Prompts
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject Prompts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// ObjectProperty: Prompts_Description
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject Prompts_Description
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ObjectProperty: SmallPromptManager
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidgetPromptManager SmallPromptManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidgetPromptManager>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// ObjectProperty: FrameBox
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject FrameBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// IntProperty: DESCRIPTION_DEFAULT_WIDTH
    /// </summary>
    public unsafe int DESCRIPTION_DEFAULT_WIDTH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// IntProperty: PROMPT_AVAILABLE_WIDTH
    /// </summary>
    public unsafe int PROMPT_AVAILABLE_WIDTH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// IntProperty: PROMPT_TEXT_MARGIN_LEFT
    /// </summary>
    public unsafe int PROMPT_TEXT_MARGIN_LEFT
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// IntProperty: PROMPT_TEXT_LEADING
    /// </summary>
    public unsafe int PROMPT_TEXT_LEADING
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// IntProperty: PROMPT_ITEM_MARGIN_TOP
    /// </summary>
    public unsafe int PROMPT_ITEM_MARGIN_TOP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// IntProperty: PROMPT_SCALING
    /// </summary>
    public unsafe int PROMPT_SCALING
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// IntProperty: TEXT_MARGING
    /// </summary>
    public unsafe int TEXT_MARGING
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }
}
