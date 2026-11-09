#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: GFxMovieBenchmarking<br/>
/// (size = 588)
/// (flags = 22)
/// </summary>
public partial class GFxMovieBenchmarking : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.GFxMovieBenchmarking", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GFxMovieBenchmarking.
    /// </summary>
    public static GFxMovieBenchmarking DefaultObject => (GFxMovieBenchmarking)StaticClass().DefaultObject;

    internal GFxMovieBenchmarking() { }

    /// <summary>
    /// Constructs a new GFxMovieBenchmarking
    /// </summary>
    public GFxMovieBenchmarking(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GFxMovieBenchmarking Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GFxMovieBenchmarking(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GFxMovieBenchmarking>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SendStatusToFlashWithVsyncWarning;
    /// <summary>
    /// Function: SendStatusToFlashWithVsyncWarning
    /// </summary>
    public unsafe virtual void SendStatusToFlashWithVsyncWarning(bool BenchmarkingActive, int BenchmarkMin, BmSDK.FString BenchmarkMax, int BenchmarkAverage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendStatusToFlashWithVsyncWarning, "BmScript.GFxMovieBenchmarking.SendStatusToFlashWithVsyncWarning");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkingActive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkMin, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkMax, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkAverage, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendStatusToFlash;
    /// <summary>
    /// Function: SendStatusToFlash
    /// </summary>
    public unsafe virtual void SendStatusToFlash(bool BenchmarkingActive, int BenchmarkMin, int BenchmarkMax, int BenchmarkAverage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendStatusToFlash, "BmScript.GFxMovieBenchmarking.SendStatusToFlash");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkingActive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkMin, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkMax, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BenchmarkAverage, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCloseHUD;
    /// <summary>
    /// Function: OnCloseHUD
    /// </summary>
    public unsafe virtual void OnCloseHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCloseHUD, "BmScript.GFxMovieBenchmarking.OnCloseHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe virtual void CloseScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmScript.GFxMovieBenchmarking.CloseScreen");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Hide;
    /// <summary>
    /// Function: Hide
    /// </summary>
    public unsafe virtual void Hide()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Hide, "BmScript.GFxMovieBenchmarking.Hide");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_show;
    /// <summary>
    /// Function: show
    /// </summary>
    public unsafe virtual void show()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_show, "BmScript.GFxMovieBenchmarking.show");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideItem;
    /// <summary>
    /// Function: HideItem
    /// </summary>
    public unsafe virtual void HideItem(BmSDK.FString ItemName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideItem, "BmScript.GFxMovieBenchmarking.HideItem");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowItem;
    /// <summary>
    /// Function: ShowItem
    /// </summary>
    public unsafe virtual void ShowItem(BmSDK.FString ItemName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowItem, "BmScript.GFxMovieBenchmarking.ShowItem");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KismetControlsInOut;
    /// <summary>
    /// Function: KismetControlsInOut
    /// </summary>
    public unsafe virtual void KismetControlsInOut(bool bTrue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KismetControlsInOut, "BmScript.GFxMovieBenchmarking.KismetControlsInOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTrue, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.GFxMovieBenchmarking.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
