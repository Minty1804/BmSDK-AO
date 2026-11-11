#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDHudExtensionGamemodeHunterHunted<br/>
/// (size = 394)
/// (flags = 134250642)
/// </summary>
public partial class GDHudExtensionGamemodeHunterHunted : BmSDK.BmGame.GDHudExtension_GameModeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDHudExtensionGamemodeHunterHunted", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDHudExtensionGamemodeHunterHunted.
    /// </summary>
    public static GDHudExtensionGamemodeHunterHunted DefaultObject => (GDHudExtensionGamemodeHunterHunted)StaticClass().DefaultObject;

    internal GDHudExtensionGamemodeHunterHunted() { }

    /// <summary>
    /// Constructs a new GDHudExtensionGamemodeHunterHunted
    /// </summary>
    public GDHudExtensionGamemodeHunterHunted(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDHudExtensionGamemodeHunterHunted Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDHudExtensionGamemodeHunterHunted(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeHunterHunted>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeHunterHunted>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeHunterHunted>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeHunterHunted>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeHunterHunted>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeHunterHunted>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeHunterHunted>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeHunterHunted>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_asGetHeroIconMovie;
    /// <summary>
    /// Function: asGetHeroIconMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetHeroIconMovie()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetHeroIconMovie, "BmGame.GDHudExtensionGamemodeHunterHunted.asGetHeroIconMovie");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetYouAnimationMovie;
    /// <summary>
    /// Function: asGetYouAnimationMovie
    /// </summary>
    public unsafe override BmSDK.GFxUI.GFxObject asGetYouAnimationMovie()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetYouAnimationMovie, "BmGame.GDHudExtensionGamemodeHunterHunted.asGetYouAnimationMovie");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCPStateChangeStateAndColour;
    /// <summary>
    /// Function: GetCPStateChangeStateAndColour
    /// </summary>
    public unsafe override bool GetCPStateChangeStateAndColour(int CPIndex, BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState NewState, out BmSDK.BmGame.GDHudExtension_GameModeBase.EControlPointUIStateChange StateChange, out int ColourChange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCPStateChangeStateAndColour, "BmGame.GDHudExtensionGamemodeHunterHunted.GetCPStateChangeStateAndColour");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StateChange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateChange, paramsPtr + 44);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ColourChange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ColourChange, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StateChange = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDHudExtension_GameModeBase.EControlPointUIStateChange>(paramsPtr + 44);
        ColourChange = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_CheckBatmanIconState;
    /// <summary>
    /// Function: CheckBatmanIconState
    /// </summary>
    public unsafe virtual void CheckBatmanIconState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckBatmanIconState, "BmGame.GDHudExtensionGamemodeHunterHunted.CheckBatmanIconState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoStateUpdate;
    /// <summary>
    /// Function: DoStateUpdate
    /// </summary>
    public unsafe override void DoStateUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoStateUpdate, "BmGame.GDHudExtensionGamemodeHunterHunted.DoStateUpdate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.GDHudExtensionGamemodeHunterHunted.Close");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateMovieObjects;
    /// <summary>
    /// Function: PopulateMovieObjects
    /// </summary>
    public unsafe override void PopulateMovieObjects()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateMovieObjects, "BmGame.GDHudExtensionGamemodeHunterHunted.PopulateMovieObjects");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayerRespawn;
    /// <summary>
    /// Function: CanPlayerRespawn
    /// </summary>
    public unsafe override bool CanPlayerRespawn(BmSDK.BmGame.RPlayerRI RPRI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayerRespawn, "BmGame.GDHudExtensionGamemodeHunterHunted.CanPlayerRespawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPRI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetBatmanIcon;
    /// <summary>
    /// Function: SetBatmanIcon
    /// </summary>
    public unsafe void SetBatmanIcon(BmSDK.BmGame.GDHudExtension_GameModeBase.EPlayerIconState IconState, bool bLocalPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatmanIcon, "BmGame.GDHudExtensionGamemodeHunterHunted.SetBatmanIcon");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLocalPlayer, paramsPtr + 4);
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

    /// <summary>
    /// ObjectProperty: HeroIconObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject HeroIconObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ByteProperty: BatmanIconState
    /// </summary>
    public unsafe BmSDK.BmGame.GDHudExtension_GameModeBase.EPlayerIconState BatmanIconState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDHudExtension_GameModeBase.EPlayerIconState>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ByteProperty: PreviousBatmanIconState
    /// </summary>
    public unsafe BmSDK.BmGame.GDHudExtension_GameModeBase.EPlayerIconState PreviousBatmanIconState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDHudExtension_GameModeBase.EPlayerIconState>(Ptr + 393); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 393); }
    }
}
