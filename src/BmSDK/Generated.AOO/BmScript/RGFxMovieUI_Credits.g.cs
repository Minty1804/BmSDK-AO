#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_Credits<br/>
/// (size = 1924)
/// (flags = 32786)
/// </summary>
public partial class RGFxMovieUI_Credits : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_Credits", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_Credits.
    /// </summary>
    public static RGFxMovieUI_Credits DefaultObject => (RGFxMovieUI_Credits)StaticClass().DefaultObject;

    internal RGFxMovieUI_Credits() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_Credits
    /// </summary>
    public RGFxMovieUI_Credits(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_Credits Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_Credits(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_Credits>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_Credits>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_Credits>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_Credits>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_Credits>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_Credits>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_Credits>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_Credits>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_asShowJobCreadit;
    /// <summary>
    /// Function: asShowJobCreadit
    /// </summary>
    public unsafe virtual float asShowJobCreadit(BmSDK.FString EmployeeNameStr, BmSDK.FString JobTitleStr)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asShowJobCreadit, "BmScript.RGFxMovieUI_Credits.asShowJobCreadit");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EmployeeNameStr, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JobTitleStr, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_asShowSubDepartmentCredit;
    /// <summary>
    /// Function: asShowSubDepartmentCredit
    /// </summary>
    public unsafe virtual float asShowSubDepartmentCredit(BmSDK.FString SubDepartmentStr)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asShowSubDepartmentCredit, "BmScript.RGFxMovieUI_Credits.asShowSubDepartmentCredit");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubDepartmentStr, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_asShowDepartmentCredit;
    /// <summary>
    /// Function: asShowDepartmentCredit
    /// </summary>
    public unsafe virtual float asShowDepartmentCredit(BmSDK.FString DepartmentStr)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asShowDepartmentCredit, "BmScript.RGFxMovieUI_Credits.asShowDepartmentCredit");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DepartmentStr, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_asShowHeaderCredit;
    /// <summary>
    /// Function: asShowHeaderCredit
    /// </summary>
    public unsafe virtual float asShowHeaderCredit(BmSDK.FString HeaderStr)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asShowHeaderCredit, "BmScript.RGFxMovieUI_Credits.asShowHeaderCredit");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeaderStr, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_asShowImageCredit;
    /// <summary>
    /// Function: asShowImageCredit
    /// </summary>
    public unsafe virtual float asShowImageCredit(BmSDK.FString ImageName, BmSDK.FString ImagePackage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asShowImageCredit, "BmScript.RGFxMovieUI_Credits.asShowImageCredit");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImageName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImagePackage, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_asSetCreditPixPerSec;
    /// <summary>
    /// Function: asSetCreditPixPerSec
    /// </summary>
    public unsafe virtual void asSetCreditPixPerSec(float PixPerSec)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetCreditPixPerSec, "BmScript.RGFxMovieUI_Credits.asSetCreditPixPerSec");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PixPerSec, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asRemoveAllCredits;
    /// <summary>
    /// Function: asRemoveAllCredits
    /// </summary>
    public unsafe virtual void asRemoveAllCredits()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asRemoveAllCredits, "BmScript.RGFxMovieUI_Credits.asRemoveAllCredits");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowNewCredit;
    /// <summary>
    /// Function: ShowNewCredit
    /// </summary>
    public unsafe virtual float ShowNewCredit(BmSDK.BmScript.RGFxMovieUI_Credits.CreditType NewCreditType, BmSDK.FString CreditStr, BmSDK.FString CreditParam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowNewCredit, "BmScript.RGFxMovieUI_Credits.ShowNewCredit");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCreditType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CreditStr, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CreditParam, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetNextCreditPauseDuration;
    /// <summary>
    /// Function: GetNextCreditPauseDuration
    /// </summary>
    public unsafe virtual float GetNextCreditPauseDuration(BmSDK.BmScript.RGFxMovieUI_Credits.CreditType CurrCredit, BmSDK.BmScript.RGFxMovieUI_Credits.CreditType NextCredit)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextCreditPauseDuration, "BmScript.RGFxMovieUI_Credits.GetNextCreditPauseDuration");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrCredit, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextCredit, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FormatCredit;
    /// <summary>
    /// Function: FormatCredit
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RGFxMovieUI_Credits.CreditType FormatCredit(out BmSDK.FString Credit, out BmSDK.FString Param)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FormatCredit, "BmScript.RGFxMovieUI_Credits.FormatCredit");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Credit = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        Param = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RGFxMovieUI_Credits.CreditType>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetNextCreditEntry;
    /// <summary>
    /// Function: GetNextCreditEntry
    /// </summary>
    public unsafe virtual bool GetNextCreditEntry(out BmSDK.FString Credit, bool bPreviewNextCredit)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextCreditEntry, "BmScript.RGFxMovieUI_Credits.GetNextCreditEntry");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPreviewNextCredit, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Credit = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_StartNextCreditWaitTimer;
    /// <summary>
    /// Function: StartNextCreditWaitTimer
    /// </summary>
    public unsafe virtual void StartNextCreditWaitTimer(float WaitTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartNextCreditWaitTimer, "BmScript.RGFxMovieUI_Credits.StartNextCreditWaitTimer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaitTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNextCredit;
    /// <summary>
    /// Function: GetNextCredit
    /// </summary>
    public unsafe void GetNextCredit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextCredit, "BmScript.RGFxMovieUI_Credits.GetNextCredit");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LastCreditFinished;
    /// <summary>
    /// Function: LastCreditFinished
    /// </summary>
    public unsafe virtual void LastCreditFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LastCreditFinished, "BmScript.RGFxMovieUI_Credits.LastCreditFinished");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitailiseCreditScreenDefaults;
    /// <summary>
    /// Function: InitailiseCreditScreenDefaults
    /// </summary>
    public unsafe virtual void InitailiseCreditScreenDefaults()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitailiseCreditScreenDefaults, "BmScript.RGFxMovieUI_Credits.InitailiseCreditScreenDefaults");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScreenReadyForCredits;
    /// <summary>
    /// Function: ScreenReadyForCredits
    /// </summary>
    public unsafe virtual void ScreenReadyForCredits(BmSDK.FString CreditListObjName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScreenReadyForCredits, "BmScript.RGFxMovieUI_Credits.ScreenReadyForCredits");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CreditListObjName, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBack, "BmScript.RGFxMovieUI_Credits.OnBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClosed, "BmScript.RGFxMovieUI_Credits.OnClosed");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.RGFxMovieUI_Credits.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// InlineArray{StructProperty}: CreditPixelGaps
    /// </summary>
    public InlineArray<BmSDK.BmScript.RGFxMovieUI_Credits.FCreditPixelPauses> CreditPixelGaps => new(5, Ptr + 1708, 20, this);

    /// <summary>
    /// StructProperty: CreditPixelGaps
    /// </summary>
    public unsafe ref BmSDK.BmScript.RGFxMovieUI_Credits.FCreditPixelPauses CreditPixelGaps_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RGFxMovieUI_Credits.FCreditPixelPauses>(Ptr + 1708);
    /// <summary>
    /// StructProperty: CreditPixelGaps
    /// </summary>
    public unsafe ref BmSDK.BmScript.RGFxMovieUI_Credits.FCreditPixelPauses CreditPixelGaps_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RGFxMovieUI_Credits.FCreditPixelPauses>(Ptr + 1728);
    /// <summary>
    /// StructProperty: CreditPixelGaps
    /// </summary>
    public unsafe ref BmSDK.BmScript.RGFxMovieUI_Credits.FCreditPixelPauses CreditPixelGaps_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RGFxMovieUI_Credits.FCreditPixelPauses>(Ptr + 1748);
    /// <summary>
    /// StructProperty: CreditPixelGaps
    /// </summary>
    public unsafe ref BmSDK.BmScript.RGFxMovieUI_Credits.FCreditPixelPauses CreditPixelGaps_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RGFxMovieUI_Credits.FCreditPixelPauses>(Ptr + 1768);
    /// <summary>
    /// StructProperty: CreditPixelGaps
    /// </summary>
    public unsafe ref BmSDK.BmScript.RGFxMovieUI_Credits.FCreditPixelPauses CreditPixelGaps_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RGFxMovieUI_Credits.FCreditPixelPauses>(Ptr + 1788);

    /// <summary>
    /// ObjectProperty: CreditListObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject CreditListObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// ArrayProperty: CreditsOrderList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CreditsOrderList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// StrProperty: CreditsFilename
    /// </summary>
    public unsafe BmSDK.FString CreditsFilename
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// IntProperty: CurrentCreditSectionListIdx
    /// </summary>
    public unsafe int CurrentCreditSectionListIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// IntProperty: CurrentCreditSectionNum
    /// </summary>
    public unsafe int CurrentCreditSectionNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// BoolProperty: bLastCredit
    /// </summary>
    public unsafe bool bLastCredit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1844) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1844); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1844); }
    }

    /// <summary>
    /// BoolProperty: bCreditsActive
    /// </summary>
    public unsafe bool bCreditsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1844) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1844); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1844); }
    }

    /// <summary>
    /// IntProperty: CreditIDTextLen
    /// </summary>
    public unsafe int CreditIDTextLen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// StrProperty: ImageCreditIDStr
    /// </summary>
    public unsafe BmSDK.FString ImageCreditIDStr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// StrProperty: HeaderCreditIDStr
    /// </summary>
    public unsafe BmSDK.FString HeaderCreditIDStr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }
    }

    /// <summary>
    /// StrProperty: DepartmentCreditIDStr
    /// </summary>
    public unsafe BmSDK.FString DepartmentCreditIDStr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// StrProperty: SubDepartmentCreditIDStr
    /// </summary>
    public unsafe BmSDK.FString SubDepartmentCreditIDStr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }

    /// <summary>
    /// StrProperty: NameCreditIDStr
    /// </summary>
    public unsafe BmSDK.FString NameCreditIDStr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// FloatProperty: CreditPixPerSec
    /// </summary>
    public unsafe float CreditPixPerSec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// ObjectProperty: NextCreditTimer
    /// </summary>
    public unsafe BmSDK.SDEngine.SDTimer NextCreditTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDTimer>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// FloatProperty: CreditStartPause
    /// </summary>
    public unsafe float CreditStartPause
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// Struct: FCreditPixelPauses
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FCreditPixelPauses
    {
        /// <summary>
        /// IntProperty: Image
        /// </summary>
        public unsafe int Image
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Header
        /// </summary>
        public unsafe int Header
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Department
        /// </summary>
        public unsafe int Department
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: SubDepartment
        /// </summary>
        public unsafe int SubDepartment
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Name
        /// </summary>
        public unsafe int Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Enum: CreditType
    /// </summary>
    public enum CreditType : byte
    {
        CT_Image = 0,
        CT_Header = 1,
        CT_Department = 2,
        CT_SubDepartment = 3,
        CT_Name = 4,
        CT_MAX = 5,
    }
}
