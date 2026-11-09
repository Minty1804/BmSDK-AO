#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MGFxTweener<br/>
/// (size = 612)
/// (flags = 134217886)
/// </summary>
public partial class MGFxTweener : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MGFxTweener", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGFxTweener.
    /// </summary>
    public static MGFxTweener DefaultObject => (MGFxTweener)StaticClass().DefaultObject;

    internal MGFxTweener() { }

    /// <summary>
    /// Constructs a new MGFxTweener
    /// </summary>
    public MGFxTweener(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxTweener Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxTweener(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxTweener>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxTweener>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxTweener>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxTweener>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxTweener>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxTweener>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxTweener>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxTweener>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_TweenEnd;
    /// <summary>
    /// Function: TweenEnd
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGFxWidget TweenEnd(BmSDK.BmGame.MGFxWidget MC, bool premise)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TweenEnd, "BmGame.MGFxTweener.TweenEnd");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(premise, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MGFxWidget>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TweenFrom;
    /// <summary>
    /// Function: TweenFrom
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGFxWidget TweenFrom(BmSDK.BmGame.MGFxWidget MC, BmSDK.GFxUI.GFxObject propsFrom, BmSDK.FString Duration, System.IntPtr easeFunc, System.IntPtr endCallback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TweenFrom, "BmGame.MGFxTweener.TweenFrom");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(propsFrom, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(easeFunc, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(endCallback, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MGFxWidget>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_TweenTo;
    /// <summary>
    /// Function: TweenTo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGFxWidget TweenTo(BmSDK.BmGame.MGFxWidget MC, BmSDK.GFxUI.GFxObject propsTo, BmSDK.FString Duration, System.IntPtr easeFunc, System.IntPtr endCallback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TweenTo, "BmGame.MGFxTweener.TweenTo");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(propsTo, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(easeFunc, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(endCallback, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MGFxWidget>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_InitTween;
    /// <summary>
    /// Function: InitTween
    /// </summary>
    public unsafe virtual void InitTween()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitTween, "BmGame.MGFxTweener.InitTween");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.MGFxTweener.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_clearTimeout;
    /// <summary>
    /// Function: clearTimeout
    /// </summary>
    public unsafe virtual void clearTimeout(float Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_clearTimeout, "BmGame.MGFxTweener.clearTimeout");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_setTimeoutInternal;
    /// <summary>
    /// Function: setTimeoutInternal
    /// </summary>
    public unsafe virtual float setTimeoutInternal(BmSDK.GFxUI.GFxObject func, int durationMs)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_setTimeoutInternal, "BmGame.MGFxTweener.setTimeoutInternal");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(func, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(durationMs, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_setTimeout;
    /// <summary>
    /// Function: setTimeout
    /// </summary>
    public unsafe virtual float setTimeout(System.IntPtr Listener, int durationMs)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_setTimeout, "BmGame.MGFxTweener.setTimeout");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Listener, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(durationMs, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_clearInterval;
    /// <summary>
    /// Function: clearInterval
    /// </summary>
    public unsafe virtual void clearInterval(float Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_clearInterval, "BmGame.MGFxTweener.clearInterval");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_setIntervalInternal;
    /// <summary>
    /// Function: setIntervalInternal
    /// </summary>
    public unsafe virtual float setIntervalInternal(BmSDK.GFxUI.GFxObject O, BmSDK.FString MethodName, int durationMs)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_setIntervalInternal, "BmGame.MGFxTweener.setIntervalInternal");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MethodName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(durationMs, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_setInterval;
    /// <summary>
    /// Function: setInterval
    /// </summary>
    public unsafe virtual int setInterval(System.IntPtr Listener, int durationMs)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_setInterval, "BmGame.MGFxTweener.setInterval");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Listener, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(durationMs, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SetListener;
    /// <summary>
    /// Function: SetListener
    /// </summary>
    public unsafe void SetListener(BmSDK.GFxUI.GFxObject O, BmSDK.FString Member, System.IntPtr Listener)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetListener, "BmGame.MGFxTweener.SetListener");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Member, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Listener, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Ease;
    /// <summary>
    /// Function: Ease
    /// </summary>
    public unsafe virtual void Ease(float T, float B, float C, float D)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Ease, "BmGame.MGFxTweener.Ease");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// DelegateProperty: __EventListener__Delegate
    /// </summary>
    public unsafe System.IntPtr __EventListener__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// DelegateProperty: __Ease__Delegate
    /// </summary>
    public unsafe System.IntPtr __Ease__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    private static BmSDK.Function __fn_EventListener;
    /// <summary>
    /// Function: EventListener
    /// </summary>
    public unsafe virtual void EventListener(BmSDK.GFxUI.GFxObject eventobj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EventListener, "BmGame.MGFxTweener.EventListener");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eventobj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
