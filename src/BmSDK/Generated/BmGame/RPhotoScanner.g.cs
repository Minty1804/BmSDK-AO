#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPhotoScanner<br/>
/// (size = 651)
/// (flags = 142606482)
/// </summary>
public partial class RPhotoScanner : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPhotoScanner", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPhotoScanner.
    /// </summary>
    public static RPhotoScanner DefaultObject => (RPhotoScanner)StaticClass().DefaultObject;

    internal RPhotoScanner() { }

    /// <summary>
    /// Constructs a new RPhotoScanner
    /// </summary>
    public RPhotoScanner(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPhotoScanner(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhotoScanner>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhotoScanner>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhotoScanner>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhotoScanner>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhotoScanner>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhotoScanner>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhotoScanner>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhotoScanner>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetScannerPower;
    /// <summary>
    /// Function: GetScannerPower
    /// </summary>
    public unsafe virtual float GetScannerPower()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScannerPower, "BmGame.RPhotoScanner.GetScannerPower");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.RPhotoScanner.DrawHUD");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetZoom;
    /// <summary>
    /// Function: ResetZoom
    /// </summary>
    public unsafe virtual void ResetZoom()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetZoom, "BmGame.RPhotoScanner.ResetZoom");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopScanning, "BmGame.RPhotoScanner.StopScanning");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LockScanning;
    /// <summary>
    /// Function: LockScanning
    /// </summary>
    public unsafe virtual void LockScanning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockScanning, "BmGame.RPhotoScanner.LockScanning");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartScanning;
    /// <summary>
    /// Function: StartScanning
    /// </summary>
    public unsafe virtual bool StartScanning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartScanning, "BmGame.RPhotoScanner.StartScanning");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopZoom;
    /// <summary>
    /// Function: StopZoom
    /// </summary>
    public unsafe virtual void StopZoom()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopZoom, "BmGame.RPhotoScanner.StopZoom");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartZoom;
    /// <summary>
    /// Function: StartZoom
    /// </summary>
    public unsafe virtual void StartZoom()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartZoom, "BmGame.RPhotoScanner.StartZoom");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScannerPercentageUpdate;
    /// <summary>
    /// Function: ScannerPercentageUpdate
    /// </summary>
    public unsafe virtual void ScannerPercentageUpdate(int NewCompletionPercentage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScannerPercentageUpdate, "BmGame.RPhotoScanner.ScannerPercentageUpdate");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCompletionPercentage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CompleteAnimFinished;
    /// <summary>
    /// Function: CompleteAnimFinished
    /// </summary>
    public unsafe virtual void CompleteAnimFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CompleteAnimFinished, "BmGame.RPhotoScanner.CompleteAnimFinished");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScanMovieComplete;
    /// <summary>
    /// Function: ScanMovieComplete
    /// </summary>
    public unsafe virtual void ScanMovieComplete(bool useRelease = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScanMovieComplete, "BmGame.RPhotoScanner.ScanMovieComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(useRelease, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEvidenceScanned;
    /// <summary>
    /// Function: SetEvidenceScanned
    /// </summary>
    public unsafe virtual void SetEvidenceScanned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEvidenceScanned, "BmGame.RPhotoScanner.SetEvidenceScanned");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReconstructionComplete;
    /// <summary>
    /// Function: ReconstructionComplete
    /// </summary>
    public unsafe virtual void ReconstructionComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReconstructionComplete, "BmGame.RPhotoScanner.ReconstructionComplete");
        byte* paramsPtr = stackalloc byte[20];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScanComplete, "BmGame.RPhotoScanner.ScanComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScannerCursorVisible;
    /// <summary>
    /// Function: SetScannerCursorVisible
    /// </summary>
    public unsafe virtual void SetScannerCursorVisible(bool isVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScannerCursorVisible, "BmGame.RPhotoScanner.SetScannerCursorVisible");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMarkerPositionPercentage;
    /// <summary>
    /// Function: SetMarkerPositionPercentage
    /// </summary>
    public unsafe virtual void SetMarkerPositionPercentage(float Percent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMarkerPositionPercentage, "BmGame.RPhotoScanner.SetMarkerPositionPercentage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScannerPercentageComplete;
    /// <summary>
    /// Function: SetScannerPercentageComplete
    /// </summary>
    public unsafe virtual void SetScannerPercentageComplete(float Percent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScannerPercentageComplete, "BmGame.RPhotoScanner.SetScannerPercentageComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeselectEvidenceSection;
    /// <summary>
    /// Function: DeselectEvidenceSection
    /// </summary>
    public unsafe virtual void DeselectEvidenceSection(int timeIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeselectEvidenceSection, "BmGame.RPhotoScanner.DeselectEvidenceSection");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeIndex, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCaseFileMode, "BmGame.RPhotoScanner.SetCaseFileMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectEvidenceSection;
    /// <summary>
    /// Function: SelectEvidenceSection
    /// </summary>
    public unsafe virtual void SelectEvidenceSection(int timeIndex, int ScanState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectEvidenceSection, "BmGame.RPhotoScanner.SelectEvidenceSection");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(timeIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanState, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddEvidenceSection, "BmGame.RPhotoScanner.AddEvidenceSection");
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
    public unsafe virtual void AddSimpleEvidenceSection(int Percentage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSimpleEvidenceSection, "BmGame.RPhotoScanner.AddSimpleEvidenceSection");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percentage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeKeypointEvidence;
    /// <summary>
    /// Function: ChangeKeypointEvidence
    /// </summary>
    public unsafe virtual void ChangeKeypointEvidence(BmSDK.BmGame.RForensicDnaSplatStatic DNASplat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeKeypointEvidence, "BmGame.RPhotoScanner.ChangeKeypointEvidence");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DNASplat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasDNABeenScanned;
    /// <summary>
    /// Function: HasDNABeenScanned
    /// </summary>
    public unsafe virtual bool HasDNABeenScanned(BmSDK.BmGame.RForensicDnaSplatStatic DNASplat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasDNABeenScanned, "BmGame.RPhotoScanner.HasDNABeenScanned");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DNASplat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDNASplat;
    /// <summary>
    /// Function: GetDNASplat
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RForensicDnaSplatStatic GetDNASplat(int EvidenceIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDNASplat, "BmGame.RPhotoScanner.GetDNASplat");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvidenceIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RForensicDnaSplatStatic>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_JumpToNextEvidence;
    /// <summary>
    /// Function: JumpToNextEvidence
    /// </summary>
    public unsafe virtual void JumpToNextEvidence()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JumpToNextEvidence, "BmGame.RPhotoScanner.JumpToNextEvidence");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JumpToPreviousEvidence;
    /// <summary>
    /// Function: JumpToPreviousEvidence
    /// </summary>
    public unsafe virtual void JumpToPreviousEvidence()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JumpToPreviousEvidence, "BmGame.RPhotoScanner.JumpToPreviousEvidence");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChooseReplayCamera;
    /// <summary>
    /// Function: ChooseReplayCamera
    /// </summary>
    public unsafe virtual void ChooseReplayCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChooseReplayCamera, "BmGame.RPhotoScanner.ChooseReplayCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerTick;
    /// <summary>
    /// Function: PlayerTick
    /// </summary>
    public unsafe virtual void PlayerTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerTick, "BmGame.RPhotoScanner.PlayerTick");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsRunning;
    /// <summary>
    /// Function: IsRunning
    /// </summary>
    public unsafe virtual bool IsRunning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRunning, "BmGame.RPhotoScanner.IsRunning");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RPhotoScanner.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Deactivate;
    /// <summary>
    /// Function: Deactivate
    /// </summary>
    public unsafe virtual void Deactivate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Deactivate, "BmGame.RPhotoScanner.Deactivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateAvailableEvidence;
    /// <summary>
    /// Function: UpdateAvailableEvidence
    /// </summary>
    public unsafe virtual void UpdateAvailableEvidence()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAvailableEvidence, "BmGame.RPhotoScanner.UpdateAvailableEvidence");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Activate;
    /// <summary>
    /// Function: Activate
    /// </summary>
    public unsafe virtual void Activate(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Activate, "BmGame.RPhotoScanner.Activate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestPos;
    /// <summary>
    /// Function: TestPos
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 TestPos(System.Numerics.Vector3 TestPosition, BmSDK.Engine.Canvas Canvas)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestPos, "BmGame.RPhotoScanner.TestPos");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsSelectedByCursor;
    /// <summary>
    /// Function: IsSelectedByCursor
    /// </summary>
    public unsafe virtual bool IsSelectedByCursor(BmSDK.Engine.StaticMeshComponent testMesh, System.Numerics.Vector3 Origin, float Scale, BmSDK.Engine.Canvas Canvas, out System.Numerics.Vector2 cmin, out System.Numerics.Vector2 cmax)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSelectedByCursor, "BmGame.RPhotoScanner.IsSelectedByCursor");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(testMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out cmin);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cmin, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out cmax);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cmax, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        cmin = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector2>(paramsPtr + 24);
        cmax = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector2>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// Enum: ScanningState
    /// </summary>
    public enum ScanningState : byte
    {
        SCAN_Ready = 0,
        SCAN_SimpleScan = 1,
        SCAN_Reconstruct = 2,
        SCAN_Playback = 3,
        SCAN_MAX = 4,
    }

    /// <summary>
    /// BoolProperty: bIsActive
    /// </summary>
    public unsafe bool bIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: bEndScanCalled
    /// </summary>
    public unsafe bool bEndScanCalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: bIsProcessing
    /// </summary>
    public unsafe bool bIsProcessing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: bInZoom
    /// </summary>
    public unsafe bool bInZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: mIgnoreDefaultZoom
    /// </summary>
    public unsafe bool mIgnoreDefaultZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: mIsScanActive
    /// </summary>
    public unsafe bool mIsScanActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: mIsAutoPlaybackActive
    /// </summary>
    public unsafe bool mIsAutoPlaybackActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: mIsTimelineActive
    /// </summary>
    public unsafe bool mIsTimelineActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: mPlayBackwards
    /// </summary>
    public unsafe bool mPlayBackwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: mHadInput
    /// </summary>
    public unsafe bool mHadInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: mScannerCursorVisible
    /// </summary>
    public unsafe bool mScannerCursorVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: mNeedToStartScannerCursor
    /// </summary>
    public unsafe bool mNeedToStartScannerCursor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: bInScanMovie
    /// </summary>
    public unsafe bool bInScanMovie
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: bPaused
    /// </summary>
    public unsafe bool bPaused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: bLockScanning
    /// </summary>
    public unsafe bool bLockScanning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// ObjectProperty: FlashPP
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess FlashPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// FloatProperty: TimeRunning
    /// </summary>
    public unsafe float TimeRunning
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// StructProperty: OldRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator OldRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 468);

    /// <summary>
    /// ArrayProperty: EvidenceArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.REvidenceInterface> EvidenceArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.REvidenceInterface>>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// InterfaceProperty: EvidenceLast
    /// </summary>
    public unsafe BmSDK.BmGame.REvidenceInterface EvidenceLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REvidenceInterface>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// InterfaceProperty: EvidenceBeingScanned
    /// </summary>
    public unsafe BmSDK.BmGame.REvidenceInterface EvidenceBeingScanned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REvidenceInterface>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// StructProperty: MovingSound
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle MovingSound
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 508);

    /// <summary>
    /// FloatProperty: TimeSinceLastScan
    /// </summary>
    public unsafe float TimeSinceLastScan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// IntProperty: FramesStopped
    /// </summary>
    public unsafe int FramesStopped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// ObjectProperty: ForensicEvidenceList
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass ForensicEvidenceList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StructProperty: CursorMin
    /// </summary>
    public unsafe ref System.Numerics.Vector2 CursorMin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 532);

    /// <summary>
    /// StructProperty: CursorMax
    /// </summary>
    public unsafe ref System.Numerics.Vector2 CursorMax
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 540);

    /// <summary>
    /// FloatProperty: OriginalZoom
    /// </summary>
    public unsafe float OriginalZoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// StructProperty: OriginalView
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OriginalView
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 552);

    /// <summary>
    /// StructProperty: OriginalViewRPC
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OriginalViewRPC
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 564);

    /// <summary>
    /// FloatProperty: RecoverZoom
    /// </summary>
    public unsafe float RecoverZoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// FloatProperty: NeededZoom
    /// </summary>
    public unsafe float NeededZoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// FloatProperty: FovToSizeRatio
    /// </summary>
    public unsafe float FovToSizeRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// FloatProperty: ZoomSize
    /// </summary>
    public unsafe float ZoomSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// FloatProperty: mPlayRate
    /// </summary>
    public unsafe float mPlayRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// InterfaceProperty: mKeyPointEvidence
    /// </summary>
    public unsafe BmSDK.BmGame.REvidenceInterface mKeyPointEvidence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REvidenceInterface>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// StrProperty: EvidenceTitle
    /// </summary>
    public unsafe BmSDK.FString EvidenceTitle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// StrProperty: EvidenceBody
    /// </summary>
    public unsafe BmSDK.FString EvidenceBody
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// StrProperty: EvidenceName
    /// </summary>
    public unsafe BmSDK.FString EvidenceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// IntProperty: CompletionPercentage
    /// </summary>
    public unsafe int CompletionPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// IntProperty: mJumpToEvidenceDirection
    /// </summary>
    public unsafe int mJumpToEvidenceDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// ByteProperty: mSelectedCamera
    /// </summary>
    public unsafe BmSDK.BmGame.MSeqAct_CaseFileControl.CaseFileCameraSelect mSelectedCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MSeqAct_CaseFileControl.CaseFileCameraSelect>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ByteProperty: mRequestedCamera
    /// </summary>
    public unsafe BmSDK.BmGame.MSeqAct_CaseFileControl.CaseFileCameraSelect mRequestedCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MSeqAct_CaseFileControl.CaseFileCameraSelect>(Ptr + 649); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 649); }
    }

    /// <summary>
    /// ByteProperty: mScanningState
    /// </summary>
    public unsafe BmSDK.BmGame.RPhotoScanner.ScanningState mScanningState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhotoScanner.ScanningState>(Ptr + 650); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 650); }
    }
}
