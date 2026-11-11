#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: GDGFxMovieUI_StorePurchaseCelebration<br/>
/// (size = 1720)
/// (flags = 32786)
/// </summary>
public partial class GDGFxMovieUI_StorePurchaseCelebration : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.GDGFxMovieUI_StorePurchaseCelebration", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGFxMovieUI_StorePurchaseCelebration.
    /// </summary>
    public static GDGFxMovieUI_StorePurchaseCelebration DefaultObject => (GDGFxMovieUI_StorePurchaseCelebration)StaticClass().DefaultObject;

    internal GDGFxMovieUI_StorePurchaseCelebration() { }

    /// <summary>
    /// Constructs a new GDGFxMovieUI_StorePurchaseCelebration
    /// </summary>
    public GDGFxMovieUI_StorePurchaseCelebration(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDGFxMovieUI_StorePurchaseCelebration Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGFxMovieUI_StorePurchaseCelebration(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_StorePurchaseCelebration>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_StorePurchaseCelebration>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_StorePurchaseCelebration>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_StorePurchaseCelebration>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_StorePurchaseCelebration>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_StorePurchaseCelebration>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_StorePurchaseCelebration>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_StorePurchaseCelebration>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_asSetPurchaseStatusText;
    /// <summary>
    /// Function: asSetPurchaseStatusText
    /// </summary>
    public unsafe virtual void asSetPurchaseStatusText(BmSDK.FString LocPurchaseStatusText)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetPurchaseStatusText, "BmScript.GDGFxMovieUI_StorePurchaseCelebration.asSetPurchaseStatusText");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPurchaseStatusText, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetPurchaseItemIcon;
    /// <summary>
    /// Function: asSetPurchaseItemIcon
    /// </summary>
    public unsafe virtual void asSetPurchaseItemIcon(BmSDK.FString PurchaseItemIconName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetPurchaseItemIcon, "BmScript.GDGFxMovieUI_StorePurchaseCelebration.asSetPurchaseItemIcon");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PurchaseItemIconName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDisconnection;
    /// <summary>
    /// Function: OnDisconnection
    /// </summary>
    public unsafe override void OnDisconnection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDisconnection, "BmScript.GDGFxMovieUI_StorePurchaseCelebration.OnDisconnection");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBack, "BmScript.GDGFxMovieUI_StorePurchaseCelebration.OnBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReturnToStoreOnPurchaseError;
    /// <summary>
    /// Function: ReturnToStoreOnPurchaseError
    /// </summary>
    public unsafe void ReturnToStoreOnPurchaseError()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReturnToStoreOnPurchaseError, "BmScript.GDGFxMovieUI_StorePurchaseCelebration.ReturnToStoreOnPurchaseError");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnTransactionFailed;
    /// <summary>
    /// Function: OnTransactionFailed
    /// </summary>
    public unsafe virtual void OnTransactionFailed(BmSDK.FString Reason)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTransactionFailed, "BmScript.GDGFxMovieUI_StorePurchaseCelebration.OnTransactionFailed");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPurchaseCompleted;
    /// <summary>
    /// Function: OnPurchaseCompleted
    /// </summary>
    public unsafe virtual void OnPurchaseCompleted(BmSDK.TArray<BmSDK.SDEngine.SDInventorySystem.FSDInventoryItemCount> NewItems)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPurchaseCompleted, "BmScript.GDGFxMovieUI_StorePurchaseCelebration.OnPurchaseCompleted");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewItems, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnVoucherTransationCompleted;
    /// <summary>
    /// Function: OnVoucherTransationCompleted
    /// </summary>
    public unsafe virtual void OnVoucherTransationCompleted(BmSDK.SDEngine.SDCreateVoucherTransactionRequest.EVoucherResponseType ResponseType, BmSDK.TArray<BmSDK.SDEngine.SDInventorySystem.FSDInventoryItemCount> NewItems)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnVoucherTransationCompleted, "BmScript.GDGFxMovieUI_StorePurchaseCelebration.OnVoucherTransationCompleted");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResponseType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewItems, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitailisePurchaseCelebrationScreen;
    /// <summary>
    /// Function: InitailisePurchaseCelebrationScreen
    /// </summary>
    public unsafe bool InitailisePurchaseCelebrationScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitailisePurchaseCelebrationScreen, "BmScript.GDGFxMovieUI_StorePurchaseCelebration.InitailisePurchaseCelebrationScreen");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EndOfSuccessAnim;
    /// <summary>
    /// Function: EndOfSuccessAnim
    /// </summary>
    public unsafe virtual void EndOfSuccessAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndOfSuccessAnim, "BmScript.GDGFxMovieUI_StorePurchaseCelebration.EndOfSuccessAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForPurchaseCompletetionOnAnimLoop;
    /// <summary>
    /// Function: CheckForPurchaseCompletetionOnAnimLoop
    /// </summary>
    public unsafe virtual bool CheckForPurchaseCompletetionOnAnimLoop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForPurchaseCompletetionOnAnimLoop, "BmScript.GDGFxMovieUI_StorePurchaseCelebration.CheckForPurchaseCompletetionOnAnimLoop");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPurchaseCelebrationIconName;
    /// <summary>
    /// Function: GetPurchaseCelebrationIconName
    /// </summary>
    public unsafe BmSDK.FString GetPurchaseCelebrationIconName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPurchaseCelebrationIconName, "BmScript.GDGFxMovieUI_StorePurchaseCelebration.GetPurchaseCelebrationIconName");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitPurchaseCelebrationData;
    /// <summary>
    /// Function: InitPurchaseCelebrationData
    /// </summary>
    public unsafe virtual void InitPurchaseCelebrationData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitPurchaseCelebrationData, "BmScript.GDGFxMovieUI_StorePurchaseCelebration.InitPurchaseCelebrationData");
        byte* paramsPtr = stackalloc byte[32];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.GDGFxMovieUI_StorePurchaseCelebration.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bPurchaseComplete
    /// </summary>
    public unsafe bool bPurchaseComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1708) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1708); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1708); }
    }

    /// <summary>
    /// BoolProperty: bIsVoucherRedeem
    /// </summary>
    public unsafe bool bIsVoucherRedeem
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1708) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1708); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1708); }
    }

    /// <summary>
    /// IntProperty: PurchaseLoopCount
    /// </summary>
    public unsafe int PurchaseLoopCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// IntProperty: MaxLoopCount
    /// </summary>
    public unsafe int MaxLoopCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }
}
