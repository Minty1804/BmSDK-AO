#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RForensicsDevice<br/>
/// (size = 1124)
/// (flags = 144703634)
/// </summary>
public partial class RForensicsDevice : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RForensicsDevice", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RForensicsDevice.
    /// </summary>
    public static RForensicsDevice DefaultObject => (RForensicsDevice)StaticClass().DefaultObject;

    internal RForensicsDevice() { }

    /// <summary>
    /// Constructs a new RForensicsDevice
    /// </summary>
    public RForensicsDevice(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RForensicsDevice(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetCameraPulseFxActive;
    /// <summary>
    /// Function: SetCameraPulseFxActive
    /// </summary>
    public unsafe virtual void SetCameraPulseFxActive(bool is_active)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCameraPulseFxActive, "BmGame.RForensicsDevice.SetCameraPulseFxActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyScanFx;
    /// <summary>
    /// Function: DestroyScanFx
    /// </summary>
    public unsafe virtual void DestroyScanFx()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyScanFx, "BmGame.RForensicsDevice.DestroyScanFx");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateScanFx;
    /// <summary>
    /// Function: ActivateScanFx
    /// </summary>
    public unsafe virtual void ActivateScanFx()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateScanFx, "BmGame.RForensicsDevice.ActivateScanFx");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Deactivate, "BmGame.RForensicsDevice.Deactivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnXray;
    /// <summary>
    /// Function: TurnOnXray
    /// </summary>
    public unsafe virtual void TurnOnXray()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnXray, "BmGame.RForensicsDevice.TurnOnXray");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsDetectiveMode;
    /// <summary>
    /// Function: IsDetectiveMode
    /// </summary>
    public unsafe virtual bool IsDetectiveMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDetectiveMode, "BmGame.RForensicsDevice.IsDetectiveMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ExitScanMode;
    /// <summary>
    /// Function: ExitScanMode
    /// </summary>
    public unsafe virtual void ExitScanMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitScanMode, "BmGame.RForensicsDevice.ExitScanMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCaseFileDetectiveMode;
    /// <summary>
    /// Function: SetCaseFileDetectiveMode
    /// </summary>
    public unsafe virtual void SetCaseFileDetectiveMode(bool IsEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCaseFileDetectiveMode, "BmGame.RForensicsDevice.SetCaseFileDetectiveMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterScanMode;
    /// <summary>
    /// Function: EnterScanMode
    /// </summary>
    public unsafe virtual void EnterScanMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterScanMode, "BmGame.RForensicsDevice.EnterScanMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceXraysOff;
    /// <summary>
    /// Function: ForceXraysOff
    /// </summary>
    public unsafe virtual void ForceXraysOff()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceXraysOff, "BmGame.RForensicsDevice.ForceXraysOff");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleFilter;
    /// <summary>
    /// Function: ToggleFilter
    /// </summary>
    public unsafe virtual void ToggleFilter(bool TurnOff = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleFilter, "BmGame.RForensicsDevice.ToggleFilter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnOff, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerActivateEvent;
    /// <summary>
    /// Function: TriggerActivateEvent
    /// </summary>
    public unsafe virtual void TriggerActivateEvent(int Output)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerActivateEvent, "BmGame.RForensicsDevice.TriggerActivateEvent");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Output, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEvidenceLevelsForScanMode;
    /// <summary>
    /// Function: SetEvidenceLevelsForScanMode
    /// </summary>
    public unsafe virtual void SetEvidenceLevelsForScanMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEvidenceLevelsForScanMode, "BmGame.RForensicsDevice.SetEvidenceLevelsForScanMode");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEvidenceLevelsForFilterMode;
    /// <summary>
    /// Function: SetEvidenceLevelsForFilterMode
    /// </summary>
    public unsafe virtual void SetEvidenceLevelsForFilterMode(bool IsOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEvidenceLevelsForFilterMode, "BmGame.RForensicsDevice.SetEvidenceLevelsForFilterMode");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsEvidenceInView;
    /// <summary>
    /// Function: IsEvidenceInView
    /// </summary>
    public unsafe virtual bool IsEvidenceInView(BmSDK.BmGame.RForensicDnaSplatStatic DNASplat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsEvidenceInView, "BmGame.RForensicsDevice.IsEvidenceInView");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DNASplat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RestoreMaterialsForXray;
    /// <summary>
    /// Function: RestoreMaterialsForXray
    /// </summary>
    public unsafe virtual void RestoreMaterialsForXray(bool force_swap = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreMaterialsForXray, "BmGame.RForensicsDevice.RestoreMaterialsForXray");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(force_swap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetAllLightEnvironments;
    /// <summary>
    /// Function: ResetAllLightEnvironments
    /// </summary>
    public unsafe virtual void ResetAllLightEnvironments()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetAllLightEnvironments, "BmGame.RForensicsDevice.ResetAllLightEnvironments");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_SwapMaterialsForXray;
    /// <summary>
    /// Function: SwapMaterialsForXray
    /// </summary>
    public unsafe virtual void SwapMaterialsForXray(bool force_swap = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwapMaterialsForXray, "BmGame.RForensicsDevice.SwapMaterialsForXray");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(force_swap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetForensicsRenderType;
    /// <summary>
    /// Function: SetForensicsRenderType
    /// </summary>
    public unsafe virtual void SetForensicsRenderType(bool On)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetForensicsRenderType, "BmGame.RForensicsDevice.SetForensicsRenderType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwapMaterialsForGlitchedXray;
    /// <summary>
    /// Function: SwapMaterialsForGlitchedXray
    /// </summary>
    public unsafe virtual void SwapMaterialsForGlitchedXray(bool force_swap = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwapMaterialsForGlitchedXray, "BmGame.RForensicsDevice.SwapMaterialsForGlitchedXray");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(force_swap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwapMaterialsForJammedXray;
    /// <summary>
    /// Function: SwapMaterialsForJammedXray
    /// </summary>
    public unsafe virtual void SwapMaterialsForJammedXray(bool force_swap = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwapMaterialsForJammedXray, "BmGame.RForensicsDevice.SwapMaterialsForJammedXray");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(force_swap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsUsingFilterView;
    /// <summary>
    /// Function: IsUsingFilterView
    /// </summary>
    public unsafe virtual bool IsUsingFilterView()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsUsingFilterView, "BmGame.RForensicsDevice.IsUsingFilterView");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EvidenceItemIdentified;
    /// <summary>
    /// Function: EvidenceItemIdentified
    /// </summary>
    public unsafe virtual void EvidenceItemIdentified()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EvidenceItemIdentified, "BmGame.RForensicsDevice.EvidenceItemIdentified");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddScannedItemToMap;
    /// <summary>
    /// Function: AddScannedItemToMap
    /// </summary>
    public unsafe virtual void AddScannedItemToMap(BmSDK.FString EvidenceTrailName, System.Numerics.Vector3 Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddScannedItemToMap, "BmGame.RForensicsDevice.AddScannedItemToMap");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvidenceTrailName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendDisruptorLocationsToHud;
    /// <summary>
    /// Function: SendDisruptorLocationsToHud
    /// </summary>
    public unsafe virtual void SendDisruptorLocationsToHud()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendDisruptorLocationsToHud, "BmGame.RForensicsDevice.SendDisruptorLocationsToHud");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetVirtualDisruptorLocation;
    /// <summary>
    /// Function: GetVirtualDisruptorLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetVirtualDisruptorLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVirtualDisruptorLocation, "BmGame.RForensicsDevice.GetVirtualDisruptorLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetZeroToOnePitchScore;
    /// <summary>
    /// Function: GetZeroToOnePitchScore
    /// </summary>
    public unsafe virtual float GetZeroToOnePitchScore(System.Numerics.Vector3 TargetVector)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetZeroToOnePitchScore, "BmGame.RForensicsDevice.GetZeroToOnePitchScore");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetVector, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetSpecialTrackingModeDistance;
    /// <summary>
    /// Function: SetSpecialTrackingModeDistance
    /// </summary>
    public unsafe virtual void SetSpecialTrackingModeDistance(float new_distance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSpecialTrackingModeDistance, "BmGame.RForensicsDevice.SetSpecialTrackingModeDistance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_distance, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD(BmSDK.Engine.Canvas Canvas)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.RForensicsDevice.DrawHUD");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckJamming;
    /// <summary>
    /// Function: CheckJamming
    /// </summary>
    public unsafe virtual bool CheckJamming()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckJamming, "BmGame.RForensicsDevice.CheckJamming");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SendJammerToHud;
    /// <summary>
    /// Function: SendJammerToHud
    /// </summary>
    public unsafe virtual void SendJammerToHud(BmSDK.Engine.Canvas Canvas, BmSDK.BmGame.RJammerInterface JammerInterface)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendJammerToHud, "BmGame.RForensicsDevice.SendJammerToHud");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JammerInterface, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAngularDistanceToTarget;
    /// <summary>
    /// Function: GetAngularDistanceToTarget
    /// </summary>
    public unsafe virtual float GetAngularDistanceToTarget(System.Numerics.Vector3 target_location)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAngularDistanceToTarget, "BmGame.RForensicsDevice.GetAngularDistanceToTarget");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_location, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetDistanceToTarget;
    /// <summary>
    /// Function: GetDistanceToTarget
    /// </summary>
    public unsafe virtual float GetDistanceToTarget(System.Numerics.Vector3 target_location)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDistanceToTarget, "BmGame.RForensicsDevice.GetDistanceToTarget");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_location, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetCommsDisruptorMinigameStringForInitialDisruption;
    /// <summary>
    /// Function: GetCommsDisruptorMinigameStringForInitialDisruption
    /// </summary>
    public unsafe virtual BmSDK.FString GetCommsDisruptorMinigameStringForInitialDisruption()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCommsDisruptorMinigameStringForInitialDisruption, "BmGame.RForensicsDevice.GetCommsDisruptorMinigameStringForInitialDisruption");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCommsDisruptorMinigameString;
    /// <summary>
    /// Function: GetCommsDisruptorMinigameString
    /// </summary>
    public unsafe virtual BmSDK.FString GetCommsDisruptorMinigameString()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCommsDisruptorMinigameString, "BmGame.RForensicsDevice.GetCommsDisruptorMinigameString");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveActorFromCommsDisruptorList;
    /// <summary>
    /// Function: RemoveActorFromCommsDisruptorList
    /// </summary>
    public unsafe virtual void RemoveActorFromCommsDisruptorList(BmSDK.BmGame.RJammerTowerLocation the_actor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveActorFromCommsDisruptorList, "BmGame.RForensicsDevice.RemoveActorFromCommsDisruptorList");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_actor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddActorToCommsDisruptorList;
    /// <summary>
    /// Function: AddActorToCommsDisruptorList
    /// </summary>
    public unsafe virtual void AddActorToCommsDisruptorList(BmSDK.BmGame.RJammerTowerLocation the_actor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddActorToCommsDisruptorList, "BmGame.RForensicsDevice.AddActorToCommsDisruptorList");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_actor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindClosestActiveJammerSource;
    /// <summary>
    /// Function: FindClosestActiveJammerSource
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 FindClosestActiveJammerSource()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindClosestActiveJammerSource, "BmGame.RForensicsDevice.FindClosestActiveJammerSource");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveActorFromJammerList;
    /// <summary>
    /// Function: RemoveActorFromJammerList
    /// </summary>
    public unsafe virtual void RemoveActorFromJammerList(BmSDK.Engine.Actor the_actor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveActorFromJammerList, "BmGame.RForensicsDevice.RemoveActorFromJammerList");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_actor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddActorToJammerList;
    /// <summary>
    /// Function: AddActorToJammerList
    /// </summary>
    public unsafe virtual void AddActorToJammerList(BmSDK.Engine.Actor the_actor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddActorToJammerList, "BmGame.RForensicsDevice.AddActorToJammerList");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_actor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLevelChange;
    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe virtual void OnLevelChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLevelChange, "BmGame.RForensicsDevice.OnLevelChange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsActorValidJammer;
    /// <summary>
    /// Function: IsActorValidJammer
    /// </summary>
    public unsafe virtual bool IsActorValidJammer(BmSDK.BmGame.RJammerInterface JammerInterface)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActorValidJammer, "BmGame.RForensicsDevice.IsActorValidJammer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JammerInterface, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetCommsJammedMovieString;
    /// <summary>
    /// Function: GetCommsJammedMovieString
    /// </summary>
    public unsafe virtual BmSDK.FString GetCommsJammedMovieString()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCommsJammedMovieString, "BmGame.RForensicsDevice.GetCommsJammedMovieString");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsCommsJammed;
    /// <summary>
    /// Function: IsCommsJammed
    /// </summary>
    public unsafe virtual bool IsCommsJammed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCommsJammed, "BmGame.RForensicsDevice.IsCommsJammed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCompassAngleToLocation;
    /// <summary>
    /// Function: GetCompassAngleToLocation
    /// </summary>
    public unsafe virtual float GetCompassAngleToLocation(System.Numerics.Vector3 TargetLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCompassAngleToLocation, "BmGame.RForensicsDevice.GetCompassAngleToLocation");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetDistanceFromFreezeLocation;
    /// <summary>
    /// Function: GetDistanceFromFreezeLocation
    /// </summary>
    public unsafe virtual float GetDistanceFromFreezeLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDistanceFromFreezeLocation, "BmGame.RForensicsDevice.GetDistanceFromFreezeLocation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayerTick;
    /// <summary>
    /// Function: PlayerTick
    /// </summary>
    public unsafe virtual void PlayerTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerTick, "BmGame.RForensicsDevice.PlayerTick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeFilter;
    /// <summary>
    /// Function: ChangeFilter
    /// </summary>
    public unsafe virtual void ChangeFilter(float DeltaTime, bool bFlashOutro)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeFilter, "BmGame.RForensicsDevice.ChangeFilter");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFlashOutro, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeFilterLock;
    /// <summary>
    /// Function: ChangeFilterLock
    /// </summary>
    public unsafe virtual void ChangeFilterLock(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeFilterLock, "BmGame.RForensicsDevice.ChangeFilterLock");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInvestigateMovieInfo;
    /// <summary>
    /// Function: SetInvestigateMovieInfo
    /// </summary>
    public unsafe virtual void SetInvestigateMovieInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvestigateMovieInfo, "BmGame.RForensicsDevice.SetInvestigateMovieInfo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeFilterSettings;
    /// <summary>
    /// Function: ChangeFilterSettings
    /// </summary>
    public unsafe virtual void ChangeFilterSettings()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeFilterSettings, "BmGame.RForensicsDevice.ChangeFilterSettings");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVisualHudMode;
    /// <summary>
    /// Function: SetVisualHudMode
    /// </summary>
    public unsafe virtual void SetVisualHudMode(BmSDK.BmGame.RForensicsDevice.VisualHudMode new_mode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVisualHudMode, "BmGame.RForensicsDevice.SetVisualHudMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_mode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVisualHudModeAuto;
    /// <summary>
    /// Function: SetVisualHudModeAuto
    /// </summary>
    public unsafe virtual void SetVisualHudModeAuto()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVisualHudModeAuto, "BmGame.RForensicsDevice.SetVisualHudModeAuto");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayZoomSound;
    /// <summary>
    /// Function: PlayZoomSound
    /// </summary>
    public unsafe virtual void PlayZoomSound(bool ZoomingIn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayZoomSound, "BmGame.RForensicsDevice.PlayZoomSound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ZoomingIn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsReady;
    /// <summary>
    /// Function: IsReady
    /// </summary>
    public unsafe virtual bool IsReady()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsReady, "BmGame.RForensicsDevice.IsReady");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartupScan;
    /// <summary>
    /// Function: StartupScan
    /// </summary>
    public unsafe virtual void StartupScan(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartupScan, "BmGame.RForensicsDevice.StartupScan");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCaseFileMaterialForXray;
    /// <summary>
    /// Function: SetCaseFileMaterialForXray
    /// </summary>
    public unsafe virtual void SetCaseFileMaterialForXray(bool TurnOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCaseFileMaterialForXray, "BmGame.RForensicsDevice.SetCaseFileMaterialForXray");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe virtual void Initialise(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.RForensicsDevice.Initialise");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEvidenceTrailInactive;
    /// <summary>
    /// Function: SetEvidenceTrailInactive
    /// </summary>
    public unsafe virtual void SetEvidenceTrailInactive(BmSDK.FString EvidenceNameString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEvidenceTrailInactive, "BmGame.RForensicsDevice.SetEvidenceTrailInactive");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvidenceNameString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEvidenceTrailActive;
    /// <summary>
    /// Function: SetEvidenceTrailActive
    /// </summary>
    public unsafe virtual void SetEvidenceTrailActive(BmSDK.BmGame.RForensicDnaSplatStatic DNASplat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEvidenceTrailActive, "BmGame.RForensicsDevice.SetEvidenceTrailActive");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DNASplat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsEvidenceTrailActive;
    /// <summary>
    /// Function: IsEvidenceTrailActive
    /// </summary>
    public unsafe virtual bool IsEvidenceTrailActive(BmSDK.BmGame.MForensicDnaSplatTrail DNATrail)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsEvidenceTrailActive, "BmGame.RForensicsDevice.IsEvidenceTrailActive");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DNATrail, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckEvidenceScanable;
    /// <summary>
    /// Function: CheckEvidenceScanable
    /// </summary>
    public unsafe virtual bool CheckEvidenceScanable(BmSDK.BmGame.REvidenceInterface evidence, out float NotFullyVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckEvidenceScanable, "BmGame.RForensicsDevice.CheckEvidenceScanable");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(evidence, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NotFullyVisible);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotFullyVisible, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NotFullyVisible = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RForensicsDevice.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: VisualHudMode
    /// </summary>
    public enum VisualHudMode : byte
    {
        VHM_NormalView = 0,
        VHM_DetectiveMode = 1,
        VHM_ScanMode = 2,
        VHM_MAX = 3,
    }

    /// <summary>
    /// Enum: SpecialTrackingMode
    /// </summary>
    public enum SpecialTrackingMode : byte
    {
        SPM_None = 0,
        SPM_Pheromone = 1,
        SPM_RadioReceiver = 2,
        SPM_FreezeLocation = 3,
        SPM_CommsDisruptorTower = 4,
        SPM_NinjaBloodTrail = 5,
        SPM_MAX = 6,
    }

    /// <summary>
    /// Enum: FlashStates
    /// </summary>
    public enum FlashStates : byte
    {
        FlS_Up = 0,
        FlS_Hold = 1,
        FlS_Down = 2,
        FlS_End = 3,
        FlS_MAX = 4,
    }

    /// <summary>
    /// Enum: EvidenceDisplayState
    /// </summary>
    public enum EvidenceDisplayState : byte
    {
        EDS_ScannerNonScan = 0,
        EDS_Scanner = 1,
        EDS_Filter = 2,
        EDS_MAX = 3,
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ArrayProperty: ViewPP
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RViewPostProcess> ViewPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RViewPostProcess>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// BoolProperty: bHideDetectiveDataInNormalMode
    /// </summary>
    public unsafe bool bHideDetectiveDataInNormalMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bIsInFilterMode
    /// </summary>
    public unsafe bool bIsInFilterMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bFilterShutdownRequested
    /// </summary>
    public unsafe bool bFilterShutdownRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bScanRequested
    /// </summary>
    public unsafe bool bScanRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bIsFlashOutro
    /// </summary>
    public unsafe bool bIsFlashOutro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bInScanMode
    /// </summary>
    public unsafe bool bInScanMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bFilterChangeRequested
    /// </summary>
    public unsafe bool bFilterChangeRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bFilterLockMode
    /// </summary>
    public unsafe bool bFilterLockMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bCameraPulseActive
    /// </summary>
    public unsafe bool bCameraPulseActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bCanUseForensicsDeviceDirectly
    /// </summary>
    public unsafe bool bCanUseForensicsDeviceDirectly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bDisableForensicHUDMovie
    /// </summary>
    public unsafe bool bDisableForensicHUDMovie
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bDisableForensicHUDText
    /// </summary>
    public unsafe bool bDisableForensicHUDText
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bIsCommunicationDisrupted
    /// </summary>
    public unsafe bool bIsCommunicationDisrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bSuppressForensicsOffSound
    /// </summary>
    public unsafe bool bSuppressForensicsOffSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bDetectiveModeJammingSoundActive
    /// </summary>
    public unsafe bool bDetectiveModeJammingSoundActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: mbIsGlitchesEnable
    /// </summary>
    public unsafe bool mbIsGlitchesEnable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: mExitedCaseFile
    /// </summary>
    public unsafe bool mExitedCaseFile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: SpecialTrackingModeAlertsEnabled
    /// </summary>
    public unsafe bool SpecialTrackingModeAlertsEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: LastEvidenceTrailActivationState
    /// </summary>
    public unsafe bool LastEvidenceTrailActivationState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bIsBatman
    /// </summary>
    public unsafe bool bIsBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bIsRobin
    /// </summary>
    public unsafe bool bIsRobin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// FloatProperty: ScanTimer
    /// </summary>
    public unsafe float ScanTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ByteProperty: RequestedFilterMode
    /// </summary>
    public unsafe BmSDK.BmGame.REvidence.DevicePostProcessEffects RequestedFilterMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REvidence.DevicePostProcessEffects>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// ByteProperty: CurrentFilterMode
    /// </summary>
    public unsafe BmSDK.BmGame.REvidence.DevicePostProcessEffects CurrentFilterMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REvidence.DevicePostProcessEffects>(Ptr + 477); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 477); }
    }

    /// <summary>
    /// ByteProperty: RequestedFilterModeForDetectiveMode
    /// </summary>
    public unsafe BmSDK.BmGame.REvidence.DevicePostProcessEffects RequestedFilterModeForDetectiveMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REvidence.DevicePostProcessEffects>(Ptr + 478); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 478); }
    }

    /// <summary>
    /// ByteProperty: CurrentSpecialTrackingMode
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsDevice.SpecialTrackingMode CurrentSpecialTrackingMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsDevice.SpecialTrackingMode>(Ptr + 479); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 479); }
    }

    /// <summary>
    /// ByteProperty: TrackingModePostProcess
    /// </summary>
    public unsafe BmSDK.BmGame.REvidence.DevicePostProcessEffects TrackingModePostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REvidence.DevicePostProcessEffects>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ByteProperty: CurrentVisualHudMode
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsDevice.VisualHudMode CurrentVisualHudMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsDevice.VisualHudMode>(Ptr + 481); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 481); }
    }

    /// <summary>
    /// ByteProperty: CurrentFlashState
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsDevice.FlashStates CurrentFlashState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsDevice.FlashStates>(Ptr + 482); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 482); }
    }

    /// <summary>
    /// FloatProperty: FilterChangeTimer
    /// </summary>
    public unsafe float FilterChangeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// IntProperty: HasSetFilterMovieMode
    /// </summary>
    public unsafe int HasSetFilterMovieMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// FloatProperty: FilterModeOldEvidenceTimer
    /// </summary>
    public unsafe float FilterModeOldEvidenceTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// ComponentProperty: ScanFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ScanFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ComponentProperty: CameraPulseFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent CameraPulseFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// FloatProperty: CurrentScannerPower
    /// </summary>
    public unsafe float CurrentScannerPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// FloatProperty: TimeForFlash
    /// </summary>
    public unsafe float TimeForFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// FloatProperty: DistanceToTrailProximityNode
    /// </summary>
    public unsafe float DistanceToTrailProximityNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// FloatProperty: DistanceToTrailProximityNodeLast
    /// </summary>
    public unsafe float DistanceToTrailProximityNodeLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// FloatProperty: AngularDistanceFromProximityNode
    /// </summary>
    public unsafe float AngularDistanceFromProximityNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ObjectProperty: FilterNoiseOn
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FilterNoiseOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// ObjectProperty: FilterNoiseOff
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FilterNoiseOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// ObjectProperty: ZoomInNoise
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ZoomInNoise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ObjectProperty: ZoomOutNoise
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ZoomOutNoise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// StrProperty: TrailName
    /// </summary>
    public unsafe BmSDK.FString TrailName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: ChangeFilterModeSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChangeFilterModeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastForensicsRequest
    /// </summary>
    public unsafe float TimeSinceLastForensicsRequest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ArrayProperty: JammingActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJammerInterface> JammingActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJammerInterface>>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// InterfaceProperty: ClosestJammerActor
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerInterface ClosestJammerActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerInterface>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// ArrayProperty: CommsDisruptorActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJammerTowerLocation> CommsDisruptorActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJammerTowerLocation>>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeJammingOn
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DetectiveModeJammingOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeJammingOff
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DetectiveModeJammingOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ObjectProperty: mCaseFileDeactivateSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent mCaseFileDeactivateSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ObjectProperty: mCaseFileActivateSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent mCaseFileActivateSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ObjectProperty: ForensicTrailList
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass ForensicTrailList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// StrProperty: SpecialTrackingModeName
    /// </summary>
    public unsafe BmSDK.FString SpecialTrackingModeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// StrProperty: SpecialTrackingModeNameDatabase
    /// </summary>
    public unsafe BmSDK.FString SpecialTrackingModeNameDatabase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// FloatProperty: SpecialTrackingModeAlertThreshold
    /// </summary>
    public unsafe float SpecialTrackingModeAlertThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// FloatProperty: SpecialTrackingModeCurrentBestDistance
    /// </summary>
    public unsafe float SpecialTrackingModeCurrentBestDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// StrProperty: LastEvidenceTrailQueried
    /// </summary>
    public unsafe BmSDK.FString LastEvidenceTrailQueried
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// ObjectProperty: FreezeLocationMarker
    /// </summary>
    public unsafe BmSDK.Engine.Actor FreezeLocationMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ObjectProperty: RadioLocationMarker
    /// </summary>
    public unsafe BmSDK.Engine.Actor RadioLocationMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// StructProperty: vVirtualDisruptorTowerLocationStart
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vVirtualDisruptorTowerLocationStart
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 664);

    /// <summary>
    /// StructProperty: vVirtualDisruptorTowerLocationEnd
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vVirtualDisruptorTowerLocationEnd
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 676);

    /// <summary>
    /// FloatProperty: fVirtualDisruptorTowerTimer
    /// </summary>
    public unsafe float fVirtualDisruptorTowerTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// FloatProperty: fJammedDetectiveModeGlitchTimer
    /// </summary>
    public unsafe float fJammedDetectiveModeGlitchTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// IntProperty: iJammedDetectiveModeGlitchCount
    /// </summary>
    public unsafe int iJammedDetectiveModeGlitchCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: DetectiveModeFOVModifier
    /// </summary>
    public unsafe float DetectiveModeFOVModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// StructProperty: PostProcessOverride
    /// </summary>
    public unsafe ref BmSDK.Engine.PostProcessVolume.FPostProcessSettings PostProcessOverride
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 704);
}
