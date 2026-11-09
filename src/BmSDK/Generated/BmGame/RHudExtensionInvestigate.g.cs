#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudExtensionInvestigate<br/>
/// (size = 164)
/// (flags = 18)
/// </summary>
public partial class RHudExtensionInvestigate : BmSDK.BmGame.RHudExtension, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudExtensionInvestigate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudExtensionInvestigate.
    /// </summary>
    public static RHudExtensionInvestigate DefaultObject => (RHudExtensionInvestigate)StaticClass().DefaultObject;

    internal RHudExtensionInvestigate() { }

    /// <summary>
    /// Constructs a new RHudExtensionInvestigate
    /// </summary>
    public RHudExtensionInvestigate(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudExtensionInvestigate Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudExtensionInvestigate(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ScanComplete;
    /// <summary>
    /// Function: ScanComplete
    /// </summary>
    public unsafe virtual void ScanComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScanComplete, "BmGame.RHudExtensionInvestigate.ScanComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideGadgetHUD;
    /// <summary>
    /// Function: HideGadgetHUD
    /// </summary>
    public unsafe virtual void HideGadgetHUD(bool bHide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideGadgetHUD, "BmGame.RHudExtensionInvestigate.HideGadgetHUD");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHide, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrompt;
    /// <summary>
    /// Function: SetPrompt
    /// </summary>
    public unsafe virtual void SetPrompt(BmSDK.BmGame.RHudExtensionInvestigate.ScannerPrompt ScanID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrompt, "BmGame.RHudExtensionInvestigate.SetPrompt");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetContentsType;
    /// <summary>
    /// Function: SetContentsType
    /// </summary>
    public unsafe virtual void SetContentsType(BmSDK.FString contents_type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetContentsType, "BmGame.RHudExtensionInvestigate.SetContentsType");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(contents_type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DimScanner;
    /// <summary>
    /// Function: DimScanner
    /// </summary>
    public unsafe virtual void DimScanner(float scanLength)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DimScanner, "BmGame.RHudExtensionInvestigate.DimScanner");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(scanLength, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScannerVisible;
    /// <summary>
    /// Function: SetScannerVisible
    /// </summary>
    public unsafe virtual void SetScannerVisible(bool bVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScannerVisible, "BmGame.RHudExtensionInvestigate.SetScannerVisible");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScannerBecomesVisibleFlag;
    /// <summary>
    /// Function: SetScannerBecomesVisibleFlag
    /// </summary>
    public unsafe virtual void SetScannerBecomesVisibleFlag(bool Visible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScannerBecomesVisibleFlag, "BmGame.RHudExtensionInvestigate.SetScannerBecomesVisibleFlag");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Visible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AbortScanning;
    /// <summary>
    /// Function: AbortScanning
    /// </summary>
    public unsafe virtual void AbortScanning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AbortScanning, "BmGame.RHudExtensionInvestigate.AbortScanning");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopScanning;
    /// <summary>
    /// Function: StopScanning
    /// </summary>
    public unsafe virtual void StopScanning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopScanning, "BmGame.RHudExtensionInvestigate.StopScanning");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartScanning;
    /// <summary>
    /// Function: StartScanning
    /// </summary>
    public unsafe virtual void StartScanning(bool isCaseFile, int scanMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartScanning, "BmGame.RHudExtensionInvestigate.StartScanning");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isCaseFile, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(scanMode, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeselectEvidenceSection;
    /// <summary>
    /// Function: DeselectEvidenceSection
    /// </summary>
    public unsafe virtual void DeselectEvidenceSection(int percentIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeselectEvidenceSection, "BmGame.RHudExtensionInvestigate.DeselectEvidenceSection");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(percentIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectEvidenceSection;
    /// <summary>
    /// Function: SelectEvidenceSection
    /// </summary>
    public unsafe virtual void SelectEvidenceSection(int percentIndex, int ScanState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectEvidenceSection, "BmGame.RHudExtensionInvestigate.SelectEvidenceSection");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(percentIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveEvidenceSection;
    /// <summary>
    /// Function: RemoveEvidenceSection
    /// </summary>
    public unsafe virtual void RemoveEvidenceSection(int percentIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveEvidenceSection, "BmGame.RHudExtensionInvestigate.RemoveEvidenceSection");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(percentIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddEvidenceSection;
    /// <summary>
    /// Function: AddEvidenceSection
    /// </summary>
    public unsafe virtual void AddEvidenceSection(int StartIndex, int endIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddEvidenceSection, "BmGame.RHudExtensionInvestigate.AddEvidenceSection");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(endIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddSimpleEvidenceSection;
    /// <summary>
    /// Function: AddSimpleEvidenceSection
    /// </summary>
    public unsafe virtual void AddSimpleEvidenceSection(int percentIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSimpleEvidenceSection, "BmGame.RHudExtensionInvestigate.AddSimpleEvidenceSection");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(percentIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowTimeline;
    /// <summary>
    /// Function: ShowTimeline
    /// </summary>
    public unsafe virtual void ShowTimeline()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowTimeline, "BmGame.RHudExtensionInvestigate.ShowTimeline");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCaseFileMode;
    /// <summary>
    /// Function: SetCaseFileMode
    /// </summary>
    public unsafe virtual void SetCaseFileMode(int ScanState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCaseFileMode, "BmGame.RHudExtensionInvestigate.SetCaseFileMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMarkerPositionPercentage;
    /// <summary>
    /// Function: SetMarkerPositionPercentage
    /// </summary>
    public unsafe virtual void SetMarkerPositionPercentage(float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMarkerPositionPercentage, "BmGame.RHudExtensionInvestigate.SetMarkerPositionPercentage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScannerPercentageComplete;
    /// <summary>
    /// Function: SetScannerPercentageComplete
    /// </summary>
    public unsafe virtual void SetScannerPercentageComplete(float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScannerPercentageComplete, "BmGame.RHudExtensionInvestigate.SetScannerPercentageComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSmokePercentageInternal;
    /// <summary>
    /// Function: SetSmokePercentageInternal
    /// </summary>
    public unsafe virtual void SetSmokePercentageInternal(int SmokePercentage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSmokePercentageInternal, "BmGame.RHudExtensionInvestigate.SetSmokePercentageInternal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmokePercentage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSmokePercentage;
    /// <summary>
    /// Function: SetSmokePercentage
    /// </summary>
    public unsafe virtual void SetSmokePercentage(int SmokePercentage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSmokePercentage, "BmGame.RHudExtensionInvestigate.SetSmokePercentage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmokePercentage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScannerCursor;
    /// <summary>
    /// Function: SetScannerCursor
    /// </summary>
    public unsafe virtual void SetScannerCursor(float X, float Y, BmSDK.FString EvidenceName, bool bNewItem, bool bScanned, BmSDK.FString MessageTitle, BmSDK.FString Message, int BillboardType, int EvidenceIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScannerCursor, "BmGame.RHudExtensionInvestigate.SetScannerCursor");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvidenceName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewItem, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bScanned, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageTitle, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BillboardType, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvidenceIndex, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScannerCursorNone;
    /// <summary>
    /// Function: SetScannerCursorNone
    /// </summary>
    public unsafe virtual void SetScannerCursorNone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScannerCursorNone, "BmGame.RHudExtensionInvestigate.SetScannerCursorNone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNPCCountString;
    /// <summary>
    /// Function: SetNPCCountString
    /// </summary>
    public unsafe virtual void SetNPCCountString(int Total, BmSDK.FString Str)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNPCCountString, "BmGame.RHudExtensionInvestigate.SetNPCCountString");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Total, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Str, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNPCInfoCursor;
    /// <summary>
    /// Function: SetNPCInfoCursor
    /// </summary>
    public unsafe virtual void SetNPCInfoCursor(float X, float Y, BmSDK.FString actorName, int NpcType, int HeartBeatType, int WeaponType, bool bIsArmoured)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNPCInfoCursor, "BmGame.RHudExtensionInvestigate.SetNPCInfoCursor");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actorName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NpcType, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeartBeatType, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponType, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsArmoured, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNPCInfoCursorNone;
    /// <summary>
    /// Function: SetNPCInfoCursorNone
    /// </summary>
    public unsafe virtual void SetNPCInfoCursorNone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNPCInfoCursorNone, "BmGame.RHudExtensionInvestigate.SetNPCInfoCursorNone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInfoCursor;
    /// <summary>
    /// Function: SetInfoCursor
    /// </summary>
    public unsafe virtual void SetInfoCursor(float X, float Y, BmSDK.FString actorName, BmSDK.FString Title, BmSDK.FString Message, bool bWarningColour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInfoCursor, "BmGame.RHudExtensionInvestigate.SetInfoCursor");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actorName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWarningColour, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInfoCursorNone;
    /// <summary>
    /// Function: SetInfoCursorNone
    /// </summary>
    public unsafe virtual void SetInfoCursorNone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInfoCursorNone, "BmGame.RHudExtensionInvestigate.SetInfoCursorNone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseCurrentCursor;
    /// <summary>
    /// Function: CloseCurrentCursor
    /// </summary>
    public unsafe virtual void CloseCurrentCursor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseCurrentCursor, "BmGame.RHudExtensionInvestigate.CloseCurrentCursor");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseCurrentCursorUnless;
    /// <summary>
    /// Function: CloseCurrentCursorUnless
    /// </summary>
    public unsafe virtual void CloseCurrentCursorUnless(BmSDK.BmGame.RHudExtensionInvestigate.EvidenceDisplayType type_exception)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseCurrentCursorUnless, "BmGame.RHudExtensionInvestigate.CloseCurrentCursorUnless");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(type_exception, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchToMode;
    /// <summary>
    /// Function: SwitchToMode
    /// </summary>
    public unsafe virtual void SwitchToMode(int Mode, BmSDK.FString extraCharacterAccronym = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchToMode, "BmGame.RHudExtensionInvestigate.SwitchToMode");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(extraCharacterAccronym, paramsPtr + 4);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_UpdateNPCCounts;
    /// <summary>
    /// Function: UpdateNPCCounts
    /// </summary>
    public unsafe virtual void UpdateNPCCounts(int Armed, int UnArmed, int Drone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateNPCCounts, "BmGame.RHudExtensionInvestigate.UpdateNPCCounts");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Armed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnArmed, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Drone, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetDroneProgressBar;
    /// <summary>
    /// Function: ResetDroneProgressBar
    /// </summary>
    public unsafe virtual void ResetDroneProgressBar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetDroneProgressBar, "BmGame.RHudExtensionInvestigate.ResetDroneProgressBar");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DroneLockedOnTarget;
    /// <summary>
    /// Function: DroneLockedOnTarget
    /// </summary>
    public unsafe virtual void DroneLockedOnTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DroneLockedOnTarget, "BmGame.RHudExtensionInvestigate.DroneLockedOnTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDroneScanProgressBar;
    /// <summary>
    /// Function: SetDroneScanProgressBar
    /// </summary>
    public unsafe virtual void SetDroneScanProgressBar(float Percentage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDroneScanProgressBar, "BmGame.RHudExtensionInvestigate.SetDroneScanProgressBar");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percentage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScreenDepth;
    /// <summary>
    /// Function: SetScreenDepth
    /// </summary>
    public unsafe virtual void SetScreenDepth(float inDepth)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScreenDepth, "BmGame.RHudExtensionInvestigate.SetScreenDepth");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inDepth, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.RHudExtensionInvestigate.Close");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTimeLine;
    /// <summary>
    /// Function: GetTimeLine
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject GetTimeLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeLine, "BmGame.RHudExtensionInvestigate.GetTimeLine");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMaster;
    /// <summary>
    /// Function: GetMaster
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject GetMaster()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaster, "BmGame.RHudExtensionInvestigate.GetMaster");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RHudExtensionInvestigate.Init");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// ByteProperty: CurrentDisplayType
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionInvestigate.EvidenceDisplayType CurrentDisplayType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionInvestigate.EvidenceDisplayType>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ByteProperty: CurrentScannerPromptVal
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionInvestigate.ScannerPrompt CurrentScannerPromptVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionInvestigate.ScannerPrompt>(Ptr + 101); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 101); }
    }

    /// <summary>
    /// ObjectProperty: ScannerEventSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ScannerEventSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ObjectProperty: ScanModeEventSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ScanModeEventSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// IntProperty: NPC_Armed
    /// </summary>
    public unsafe int NPC_Armed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// IntProperty: NPC_UnArmed
    /// </summary>
    public unsafe int NPC_UnArmed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// IntProperty: NPC_Drone
    /// </summary>
    public unsafe int NPC_Drone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// StrProperty: CurrentEvidenceDetailString
    /// </summary>
    public unsafe BmSDK.FString CurrentEvidenceDetailString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StrProperty: LoadedContentsTypeString
    /// </summary>
    public unsafe BmSDK.FString LoadedContentsTypeString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ObjectProperty: MovieInfo
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie MovieInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: MasterCached
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject MasterCached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ObjectProperty: mcTimeLineCached
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject mcTimeLineCached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: CurrentRendererDepth
    /// </summary>
    public unsafe float CurrentRendererDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// Enum: EvidenceDisplayType
    /// </summary>
    public enum EvidenceDisplayType : byte
    {
        EEDT_None = 0,
        EEDT_NPC = 1,
        EEDT_Info = 2,
        EEDT_Evidence = 3,
        EEDT_MAX = 4,
    }

    /// <summary>
    /// Enum: ENPCType
    /// </summary>
    public enum ENPCType : byte
    {
        ENPCType_None = 0,
        ENPCType_Thug = 1,
        ENPCType_Guard = 2,
        ENPCType_Lunatic = 3,
        ENPCType_Henchman = 4,
        ENPCType_Undead = 5,
        ENPCType_ThugJammer = 6,
        ENPCType_ThugMines = 7,
        ENPCType_ThugThermalVision = 8,
        ENPCType_BossDeathstroke = 9,
        ENPCType_BossBane = 10,
        ENPCType_BossFirefly = 11,
        ENPCType_BossDeadshot = 12,
        ENPCType_BossShiva = 13,
        ENPCType_BossAnarky = 14,
        ENPCType_BossCroc = 15,
        ENPCType_BossBird = 16,
        ENPCType_BossJoker = 17,
        ENPCType_Branden = 18,
        ENPCType_Tiffany = 19,
        ENPCType_Warden = 20,
        ENPCType_Gordon = 21,
        ENPCType_Barbara = 22,
        ENPCType_Tracey = 23,
        ENPCType_Sionis = 24,
        ENPCType_MAX = 25,
    }

    /// <summary>
    /// Enum: EHeartBeatType
    /// </summary>
    public enum EHeartBeatType : byte
    {
        EHeartBeatType_Fine = 0,
        EHeartBeatType_Nervous = 1,
        EHeartBeatType_Terrified = 2,
        EHeartBeatType_Unconscious = 3,
        EHeartBeatType_Crazy = 4,
        EHeartBeatType_Undead = 5,
        EHeartBeatType_Injured = 6,
        EHeartBeatType_Frozen = 7,
        EHeartBeatType_MrFreezeWithoutSuit = 8,
        EHeartBeatType_MrFreezeNormal = 9,
        EHeartBeatType_RobotDead = 10,
        EHeartBeatType_RobotDormant = 11,
        EHeartBeatType_RobotActive = 12,
        EHeartBeatType_Agitated = 13,
        EHeartBeatType_GrundyDead = 14,
        EHeartBeatType_GrundyNormal = 15,
        EHeartBeatType_GrundyOnFire = 16,
        EHeartBeatType_Unknown = 17,
        EHeartBeatType_MAX = 18,
    }

    /// <summary>
    /// Enum: ScannerPrompt
    /// </summary>
    public enum ScannerPrompt : byte
    {
        ScannerPrompt_None = 0,
        ScannerPrompt_PressAndHoldToScan = 1,
        ScannerPrompt_PressAToClose = 2,
        ScannerPrompt_MAX = 3,
    }
}
