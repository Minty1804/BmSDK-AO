#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudExtensionInvestigate<br/>
/// (size = 272)
/// (flags = 32786)
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

    private static BmSDK.Function __fn_EvidenceItemIdentified;
    /// <summary>
    /// Function: EvidenceItemIdentified
    /// </summary>
    public unsafe virtual void EvidenceItemIdentified()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EvidenceItemIdentified, "BmGame.RHudExtensionInvestigate.EvidenceItemIdentified");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EvidenceScanClose;
    /// <summary>
    /// Function: EvidenceScanClose
    /// </summary>
    public unsafe virtual void EvidenceScanClose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EvidenceScanClose, "BmGame.RHudExtensionInvestigate.EvidenceScanClose");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

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

    private static BmSDK.Function __fn_EvidenceScanned;
    /// <summary>
    /// Function: EvidenceScanned
    /// </summary>
    public unsafe virtual void EvidenceScanned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EvidenceScanned, "BmGame.RHudExtensionInvestigate.EvidenceScanned");
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

    private static BmSDK.Function __fn_SetMovieFocus;
    /// <summary>
    /// Function: SetMovieFocus
    /// </summary>
    public unsafe virtual void SetMovieFocus(bool State)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMovieFocus, "BmGame.RHudExtensionInvestigate.SetMovieFocus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEvidenceDetail;
    /// <summary>
    /// Function: SetEvidenceDetail
    /// </summary>
    public unsafe virtual void SetEvidenceDetail(BmSDK.FString _CurrentEvidenceDetailString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEvidenceDetail, "BmGame.RHudExtensionInvestigate.SetEvidenceDetail");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_CurrentEvidenceDetailString, paramsPtr + 0);
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
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(contents_type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetContentsVisible;
    /// <summary>
    /// Function: SetContentsVisible
    /// </summary>
    public unsafe virtual void SetContentsVisible(bool bVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetContentsVisible, "BmGame.RHudExtensionInvestigate.SetContentsVisible");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MarkGrundyDrumBeat;
    /// <summary>
    /// Function: MarkGrundyDrumBeat
    /// </summary>
    public unsafe virtual void MarkGrundyDrumBeat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MarkGrundyDrumBeat, "BmGame.RHudExtensionInvestigate.MarkGrundyDrumBeat");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
    public unsafe virtual void StartScanning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartScanning, "BmGame.RHudExtensionInvestigate.StartScanning");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
    public unsafe virtual void SetScannerCursor(float X, float Y, BmSDK.FString EvidenceName, bool bNewItem, bool bScanned, bool bUnscannable, int NotFullyVisible, BmSDK.FString MessageTitle, BmSDK.FString Message)
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
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUnscannable, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotFullyVisible, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageTitle, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 48);
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

    private static BmSDK.Function __fn_SetEvidenceCursor;
    /// <summary>
    /// Function: SetEvidenceCursor
    /// </summary>
    public unsafe virtual void SetEvidenceCursor(float X, float Y, BmSDK.FString EvidenceName, BmSDK.FString actorName, bool bScanned, bool bShowLine)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEvidenceCursor, "BmGame.RHudExtensionInvestigate.SetEvidenceCursor");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvidenceName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actorName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bScanned, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowLine, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEvidenceCursorNone;
    /// <summary>
    /// Function: SetEvidenceCursorNone
    /// </summary>
    public unsafe virtual void SetEvidenceCursorNone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEvidenceCursorNone, "BmGame.RHudExtensionInvestigate.SetEvidenceCursorNone");
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
    public unsafe virtual void SwitchToMode(int Mode, bool bInDesiredMode, BmSDK.FString TrailName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchToMode, "BmGame.RHudExtensionInvestigate.SwitchToMode");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInDesiredMode, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrailName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateNPCCounts;
    /// <summary>
    /// Function: UpdateNPCCounts
    /// </summary>
    public unsafe virtual void UpdateNPCCounts(int Armed, int UnArmed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateNPCCounts, "BmGame.RHudExtensionInvestigate.UpdateNPCCounts");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Armed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnArmed, paramsPtr + 4);
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
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionInvestigate.EvidenceDisplayType>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ByteProperty: CurrentScannerPromptVal
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionInvestigate.ScannerPrompt CurrentScannerPromptVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionInvestigate.ScannerPrompt>(Ptr + 137); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 137); }
    }

    /// <summary>
    /// ObjectProperty: ScannerEventSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ScannerEventSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: ScanModeEventSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ScanModeEventSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// IntProperty: NPC_Armed
    /// </summary>
    public unsafe int NPC_Armed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// IntProperty: NPC_UnArmed
    /// </summary>
    public unsafe int NPC_UnArmed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// StrProperty: DisplayedContentsTypeString
    /// </summary>
    public unsafe BmSDK.FString DisplayedContentsTypeString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// StrProperty: CurrentEvidenceDetailString
    /// </summary>
    public unsafe BmSDK.FString CurrentEvidenceDetailString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StrProperty: LoadedContentsTypeString
    /// </summary>
    public unsafe BmSDK.FString LoadedContentsTypeString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ObjectProperty: MovieInfo
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie MovieInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetEvidenceCursor
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetEvidenceCursor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetInfoCursor
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetInfoCursor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetNPCInfoCursor
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetNPCInfoCursor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetScannerCursor
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetScannerCursor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetSmokePercentage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetSmokePercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StrProperty: CachedVariable_MasterDepth
    /// </summary>
    public unsafe BmSDK.FString CachedVariable_MasterDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// FloatProperty: CurrentRendererDepth
    /// </summary>
    public unsafe float CurrentRendererDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
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
        ENPCType_BossMrFreeze = 9,
        ENPCType_BossGrundy = 10,
        ENPCType_BossClayface = 11,
        ENPCType_BossClayfaceDrone = 12,
        ENPCType_BossPenguin = 13,
        ENPCType_BossPenguinIceberg = 14,
        ENPCType_FrozenNora = 15,
        ENPCType_TwoFace = 16,
        ENPCType_Robot = 17,
        ENPCType_MAX = 18,
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
