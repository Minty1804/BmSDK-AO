#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: R3rdPersonCamera<br/>
/// (size = 13152)
/// (flags = 144736406)
/// </summary>
public partial class R3rdPersonCamera : BmSDK.Engine.Camera, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.R3rdPersonCamera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as R3rdPersonCamera.
    /// </summary>
    public static R3rdPersonCamera DefaultObject => (R3rdPersonCamera)StaticClass().DefaultObject;

    internal R3rdPersonCamera() { }

    /// <summary>
    /// Constructs a new R3rdPersonCamera
    /// </summary>
    public R3rdPersonCamera(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected R3rdPersonCamera(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpdateCameraPosition;
    /// <summary>
    /// Function: UpdateCameraPosition
    /// </summary>
    public unsafe virtual void UpdateCameraPosition(float DeltaTime, bool ProperReset = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCameraPosition, "BmGame.R3rdPersonCamera.UpdateCameraPosition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProperReset, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetYawAnchorRotation;
    /// <summary>
    /// Function: GetYawAnchorRotation
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetYawAnchorRotation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetYawAnchorRotation, "BmGame.R3rdPersonCamera.GetYawAnchorRotation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTunnelCameraDirection;
    /// <summary>
    /// Function: GetTunnelCameraDirection
    /// </summary>
    public unsafe virtual void GetTunnelCameraDirection(out System.Numerics.Vector3 InDirection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTunnelCameraDirection, "BmGame.R3rdPersonCamera.GetTunnelCameraDirection");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InDirection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDirection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        InDirection = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetOverrideMotionBlur;
    /// <summary>
    /// Function: SetOverrideMotionBlur
    /// </summary>
    public unsafe virtual void SetOverrideMotionBlur(float NewMBAmount, float MBTransitionTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverrideMotionBlur, "BmGame.R3rdPersonCamera.SetOverrideMotionBlur");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMBAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MBTransitionTime, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetOverrideFOV;
    /// <summary>
    /// Function: ResetOverrideFOV
    /// </summary>
    public unsafe virtual void ResetOverrideFOV(float FOVTransitionTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetOverrideFOV, "BmGame.R3rdPersonCamera.ResetOverrideFOV");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOVTransitionTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOverrideFOV;
    /// <summary>
    /// Function: SetOverrideFOV
    /// </summary>
    public unsafe virtual void SetOverrideFOV(float NewFOV, float FOVTransitionTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverrideFOV, "BmGame.R3rdPersonCamera.SetOverrideFOV");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFOV, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOVTransitionTime, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTargetActor;
    /// <summary>
    /// Function: GetTargetActor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetTargetActor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetActor, "BmGame.R3rdPersonCamera.GetTargetActor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnlockCamera;
    /// <summary>
    /// Function: UnlockCamera
    /// </summary>
    public unsafe virtual void UnlockCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockCamera, "BmGame.R3rdPersonCamera.UnlockCamera");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LockCamera;
    /// <summary>
    /// Function: LockCamera
    /// </summary>
    public unsafe virtual void LockCamera(float LockedTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockCamera, "BmGame.R3rdPersonCamera.LockCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LockedTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffMotionBlur;
    /// <summary>
    /// Function: TurnOffMotionBlur
    /// </summary>
    public unsafe virtual void TurnOffMotionBlur()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffMotionBlur, "BmGame.R3rdPersonCamera.TurnOffMotionBlur");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FillCameraCache;
    /// <summary>
    /// Function: FillCameraCache
    /// </summary>
    public unsafe override void FillCameraCache(in BmSDK.GameObject.FTPOV NewPOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FillCameraCache, "BmGame.R3rdPersonCamera.FillCameraCache");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideClippingObjects;
    /// <summary>
    /// Function: HideClippingObjects
    /// </summary>
    public unsafe virtual void HideClippingObjects(in BmSDK.GameObject.FTPOV NewPOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideClippingObjects, "BmGame.R3rdPersonCamera.HideClippingObjects");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPOV, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateZoomFocus;
    /// <summary>
    /// Function: UpdateZoomFocus
    /// </summary>
    public unsafe virtual void UpdateZoomFocus(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateZoomFocus, "BmGame.R3rdPersonCamera.UpdateZoomFocus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetViewTarget;
    /// <summary>
    /// Function: SetViewTarget
    /// </summary>
    public unsafe override void SetViewTarget(BmSDK.Engine.Actor NewViewTarget, BmSDK.Engine.Camera.FViewTargetTransitionParams TransitionParams = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetViewTarget, "BmGame.R3rdPersonCamera.SetViewTarget");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewViewTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionParams, paramsPtr + 4);
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

    private static BmSDK.Function __fn_BlendViewTargets;
    /// <summary>
    /// Function: BlendViewTargets
    /// </summary>
    public unsafe override BmSDK.GameObject.FTPOV BlendViewTargets(in BmSDK.Engine.Camera.FTViewTarget A, in BmSDK.Engine.Camera.FTViewTarget B, float Alpha)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlendViewTargets, "BmGame.R3rdPersonCamera.BlendViewTargets");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 88);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FTPOV>(paramsPtr + 92);
    }

    private static BmSDK.Function __fn_SetRasFOV;
    /// <summary>
    /// Function: SetRasFOV
    /// </summary>
    public unsafe virtual void SetRasFOV(float NewFOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRasFOV, "BmGame.R3rdPersonCamera.SetRasFOV");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RecordCameraMove;
    /// <summary>
    /// Function: RecordCameraMove
    /// </summary>
    public unsafe virtual void RecordCameraMove(BmSDK.Rotator DeltaRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecordCameraMove, "BmGame.R3rdPersonCamera.RecordCameraMove");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaRotation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.R3rdPersonCamera.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelBlockedZoom;
    /// <summary>
    /// Function: CancelBlockedZoom
    /// </summary>
    public unsafe virtual void CancelBlockedZoom()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelBlockedZoom, "BmGame.R3rdPersonCamera.CancelBlockedZoom");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelAndBlockZoom;
    /// <summary>
    /// Function: CancelAndBlockZoom
    /// </summary>
    public unsafe virtual void CancelAndBlockZoom(float T = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelAndBlockZoom, "BmGame.R3rdPersonCamera.CancelAndBlockZoom");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelZoom;
    /// <summary>
    /// Function: CancelZoom
    /// </summary>
    public unsafe virtual void CancelZoom()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelZoom, "BmGame.R3rdPersonCamera.CancelZoom");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceZoomCamera;
    /// <summary>
    /// Function: ForceZoomCamera
    /// </summary>
    public unsafe virtual void ForceZoomCamera(float OverrideZoomFOV = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceZoomCamera, "BmGame.R3rdPersonCamera.ForceZoomCamera");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideZoomFOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleCameraZoom;
    /// <summary>
    /// Function: ToggleCameraZoom
    /// </summary>
    public unsafe virtual void ToggleCameraZoom()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleCameraZoom, "BmGame.R3rdPersonCamera.ToggleCameraZoom");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleAlternativeWalkCamera;
    /// <summary>
    /// Function: ToggleAlternativeWalkCamera
    /// </summary>
    public unsafe virtual void ToggleAlternativeWalkCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleAlternativeWalkCamera, "BmGame.R3rdPersonCamera.ToggleAlternativeWalkCamera");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SettingsChanged;
    /// <summary>
    /// Function: SettingsChanged
    /// </summary>
    public unsafe virtual void SettingsChanged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SettingsChanged, "BmGame.R3rdPersonCamera.SettingsChanged");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraZoomOut;
    /// <summary>
    /// Function: DebugCameraZoomOut
    /// </summary>
    public unsafe virtual void DebugCameraZoomOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraZoomOut, "BmGame.R3rdPersonCamera.DebugCameraZoomOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraZoomIn;
    /// <summary>
    /// Function: DebugCameraZoomIn
    /// </summary>
    public unsafe virtual void DebugCameraZoomIn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraZoomIn, "BmGame.R3rdPersonCamera.DebugCameraZoomIn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraBack;
    /// <summary>
    /// Function: DebugCameraBack
    /// </summary>
    public unsafe virtual void DebugCameraBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraBack, "BmGame.R3rdPersonCamera.DebugCameraBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraForward;
    /// <summary>
    /// Function: DebugCameraForward
    /// </summary>
    public unsafe virtual void DebugCameraForward()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraForward, "BmGame.R3rdPersonCamera.DebugCameraForward");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraRight;
    /// <summary>
    /// Function: DebugCameraRight
    /// </summary>
    public unsafe virtual void DebugCameraRight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraRight, "BmGame.R3rdPersonCamera.DebugCameraRight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraLeft;
    /// <summary>
    /// Function: DebugCameraLeft
    /// </summary>
    public unsafe virtual void DebugCameraLeft()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraLeft, "BmGame.R3rdPersonCamera.DebugCameraLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraUp;
    /// <summary>
    /// Function: DebugCameraUp
    /// </summary>
    public unsafe virtual void DebugCameraUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraUp, "BmGame.R3rdPersonCamera.DebugCameraUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraDown;
    /// <summary>
    /// Function: DebugCameraDown
    /// </summary>
    public unsafe virtual void DebugCameraDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraDown, "BmGame.R3rdPersonCamera.DebugCameraDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetToPlayerCam;
    /// <summary>
    /// Function: ResetToPlayerCam
    /// </summary>
    public unsafe virtual void ResetToPlayerCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetToPlayerCam, "BmGame.R3rdPersonCamera.ResetToPlayerCam");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatEnableCameraDrag;
    /// <summary>
    /// Function: CombatEnableCameraDrag
    /// </summary>
    public unsafe virtual void CombatEnableCameraDrag()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatEnableCameraDrag, "BmGame.R3rdPersonCamera.CombatEnableCameraDrag");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatDisableCameraDrag;
    /// <summary>
    /// Function: CombatDisableCameraDrag
    /// </summary>
    public unsafe virtual void CombatDisableCameraDrag(float Time = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatDisableCameraDrag, "BmGame.R3rdPersonCamera.CombatDisableCameraDrag");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableCameraDragHardReset;
    /// <summary>
    /// Function: EnableCameraDragHardReset
    /// </summary>
    public unsafe virtual void EnableCameraDragHardReset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableCameraDragHardReset, "BmGame.R3rdPersonCamera.EnableCameraDragHardReset");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableCameraDragHardReset;
    /// <summary>
    /// Function: DisableCameraDragHardReset
    /// </summary>
    public unsafe virtual void DisableCameraDragHardReset(float Time = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableCameraDragHardReset, "BmGame.R3rdPersonCamera.DisableCameraDragHardReset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableCameraDrag;
    /// <summary>
    /// Function: EnableCameraDrag
    /// </summary>
    public unsafe virtual void EnableCameraDrag()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableCameraDrag, "BmGame.R3rdPersonCamera.EnableCameraDrag");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableCameraDrag;
    /// <summary>
    /// Function: DisableCameraDrag
    /// </summary>
    public unsafe virtual void DisableCameraDrag(float Time = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableCameraDrag, "BmGame.R3rdPersonCamera.DisableCameraDrag");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
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

    private static BmSDK.Function __fn_EnableCameraCollision;
    /// <summary>
    /// Function: EnableCameraCollision
    /// </summary>
    public unsafe virtual void EnableCameraCollision()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableCameraCollision, "BmGame.R3rdPersonCamera.EnableCameraCollision");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableCameraCollision;
    /// <summary>
    /// Function: DisableCameraCollision
    /// </summary>
    public unsafe virtual void DisableCameraCollision(float DisableTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableCameraCollision, "BmGame.R3rdPersonCamera.DisableCameraCollision");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisableTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideCamRefresh;
    /// <summary>
    /// Function: HideCamRefresh
    /// </summary>
    public unsafe virtual void HideCamRefresh()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideCamRefresh, "BmGame.R3rdPersonCamera.HideCamRefresh");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeDof;
    /// <summary>
    /// Function: ChangeDof
    /// </summary>
    public unsafe virtual void ChangeDof(BmSDK.BmGame.RDOFManager.FDofStruct newDof)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeDof, "BmGame.R3rdPersonCamera.ChangeDof");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newDof, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetDof;
    /// <summary>
    /// Function: ResetDof
    /// </summary>
    public unsafe virtual void ResetDof()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetDof, "BmGame.R3rdPersonCamera.ResetDof");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyCameraModifiers;
    /// <summary>
    /// Function: ApplyCameraModifiers
    /// </summary>
    public unsafe override void ApplyCameraModifiers(float DeltaTime, out BmSDK.GameObject.FTPOV OutPOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyCameraModifiers, "BmGame.R3rdPersonCamera.ApplyCameraModifiers");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutPOV);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutPOV, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutPOV = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FTPOV>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_ApplyModifiers;
    /// <summary>
    /// Function: ApplyModifiers
    /// </summary>
    public unsafe virtual void ApplyModifiers(float DeltaTime, out BmSDK.GameObject.FTPOV OutPOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyModifiers, "BmGame.R3rdPersonCamera.ApplyModifiers");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutPOV);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutPOV, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutPOV = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FTPOV>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_Reset;
    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe override void Reset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reset, "BmGame.R3rdPersonCamera.Reset");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRotationFromPawn;
    /// <summary>
    /// Function: GetRotationFromPawn
    /// </summary>
    public unsafe virtual void GetRotationFromPawn(out BmSDK.Engine.Camera.FTViewTarget OutVT, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRotationFromPawn, "BmGame.R3rdPersonCamera.GetRotationFromPawn");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutVT);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutVT, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutVT = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Camera.FTViewTarget>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetGameViewportClient;
    /// <summary>
    /// Function: GetGameViewportClient
    /// </summary>
    public unsafe virtual BmSDK.Engine.GameViewportClient GetGameViewportClient()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameViewportClient, "BmGame.R3rdPersonCamera.GetGameViewportClient");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.GameViewportClient>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EndJumpCam;
    /// <summary>
    /// Function: EndJumpCam
    /// </summary>
    public unsafe virtual void EndJumpCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndJumpCam, "BmGame.R3rdPersonCamera.EndJumpCam");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartJumpCam;
    /// <summary>
    /// Function: StartJumpCam
    /// </summary>
    public unsafe virtual void StartJumpCam(float Time = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartJumpCam, "BmGame.R3rdPersonCamera.StartJumpCam");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGlidingCameraSmoothingStrength;
    /// <summary>
    /// Function: GetGlidingCameraSmoothingStrength
    /// </summary>
    public unsafe virtual float GetGlidingCameraSmoothingStrength(BmSDK.FName StateName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlidingCameraSmoothingStrength, "BmGame.R3rdPersonCamera.GetGlidingCameraSmoothingStrength");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_LeaveTunnel;
    /// <summary>
    /// Function: LeaveTunnel
    /// </summary>
    public unsafe virtual void LeaveTunnel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LeaveTunnel, "BmGame.R3rdPersonCamera.LeaveTunnel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterTunnel;
    /// <summary>
    /// Function: EnterTunnel
    /// </summary>
    public unsafe virtual void EnterTunnel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterTunnel, "BmGame.R3rdPersonCamera.EnterTunnel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessOverLook;
    /// <summary>
    /// Function: ProcessOverLook
    /// </summary>
    public unsafe virtual void ProcessOverLook()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessOverLook, "BmGame.R3rdPersonCamera.ProcessOverLook");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombatDistModifier;
    /// <summary>
    /// Function: SetCombatDistModifier
    /// </summary>
    public unsafe virtual void SetCombatDistModifier(float NewDistModifier)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombatDistModifier, "BmGame.R3rdPersonCamera.SetCombatDistModifier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDistModifier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombatFOV;
    /// <summary>
    /// Function: SetCombatFOV
    /// </summary>
    public unsafe virtual void SetCombatFOV(float NewFOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombatFOV, "BmGame.R3rdPersonCamera.SetCombatFOV");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombatCamera;
    /// <summary>
    /// Function: SetCombatCamera
    /// </summary>
    public unsafe virtual void SetCombatCamera(bool setFlag)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombatCamera, "BmGame.R3rdPersonCamera.SetCombatCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(setFlag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RevertCameraTarget;
    /// <summary>
    /// Function: RevertCameraTarget
    /// </summary>
    public unsafe virtual void RevertCameraTarget(float BlendTime = default, bool bResetCam = default, bool BlendBatmanRelativePosition = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RevertCameraTarget, "BmGame.R3rdPersonCamera.RevertCameraTarget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetCam, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendBatmanRelativePosition, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCameraTarget;
    /// <summary>
    /// Function: SetCameraTarget
    /// </summary>
    public unsafe virtual void SetCameraTarget(BmSDK.Engine.Actor Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCameraTarget, "BmGame.R3rdPersonCamera.SetCameraTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlendToCameraTarget;
    /// <summary>
    /// Function: BlendToCameraTarget
    /// </summary>
    public unsafe virtual void BlendToCameraTarget(BmSDK.Engine.Actor Target, float BlendTime, bool bResetCam = default, BmSDK.Rotator ResetRotation = default, bool BlendBatmanRelativePosition = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlendToCameraTarget, "BmGame.R3rdPersonCamera.BlendToCameraTarget");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetCam, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResetRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendBatmanRelativePosition, paramsPtr + 24);
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

    private static BmSDK.Function __fn_UpdateFreeCam;
    /// <summary>
    /// Function: UpdateFreeCam
    /// </summary>
    public unsafe virtual void UpdateFreeCam(System.Numerics.Vector3 DesiredCameraPosition, BmSDK.Rotator DesiredCameraRotation, float DesiredCameraFOV, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFreeCam, "BmGame.R3rdPersonCamera.UpdateFreeCam");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraFOV, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 28);
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

    private static BmSDK.Function __fn_TransitionInterpolate;
    /// <summary>
    /// Function: TransitionInterpolate
    /// </summary>
    public unsafe virtual void TransitionInterpolate(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransitionInterpolate, "BmGame.R3rdPersonCamera.TransitionInterpolate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ResetCamera;
    /// <summary>
    /// Function: ResetCamera
    /// </summary>
    public unsafe virtual void ResetCamera(BmSDK.Rotator ResetRotation = default, bool bResetForBlend = default, bool bResetSmoother = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetCamera, "BmGame.R3rdPersonCamera.ResetCamera");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResetRotation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetForBlend, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetSmoother, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateViewTarget;
    /// <summary>
    /// Function: UpdateViewTarget
    /// </summary>
    public unsafe override void UpdateViewTarget(out BmSDK.Engine.Camera.FTViewTarget OutVT, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateViewTarget, "BmGame.R3rdPersonCamera.UpdateViewTarget");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutVT);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutVT, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutVT = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Camera.FTViewTarget>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateViewTargetCameraActor;
    /// <summary>
    /// Function: UpdateViewTargetCameraActor
    /// </summary>
    public unsafe virtual void UpdateViewTargetCameraActor(out BmSDK.Engine.Camera.FTViewTarget OutVT, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateViewTargetCameraActor, "BmGame.R3rdPersonCamera.UpdateViewTargetCameraActor");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutVT);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutVT, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutVT = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Camera.FTViewTarget>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AdjustDesiredRotation;
    /// <summary>
    /// Function: AdjustDesiredRotation
    /// </summary>
    public unsafe virtual void AdjustDesiredRotation(BmSDK.BmGame.RPawnPlayer PawnTarget, out BmSDK.Rotator DesiredRotation, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustDesiredRotation, "BmGame.R3rdPersonCamera.AdjustDesiredRotation");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnTarget, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DesiredRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredRotation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DesiredRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_UpdateCurrentCamera;
    /// <summary>
    /// Function: UpdateCurrentCamera
    /// </summary>
    public unsafe virtual void UpdateCurrentCamera(System.Numerics.Vector3 DesiredCameraPosition, BmSDK.Rotator DesiredCameraRotation, float DesiredCameraFOV, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCurrentCamera, "BmGame.R3rdPersonCamera.UpdateCurrentCamera");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraFOV, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessViewRotation;
    /// <summary>
    /// Function: ProcessViewRotation
    /// </summary>
    public unsafe override void ProcessViewRotation(float DeltaTime, out BmSDK.Rotator out_ViewRotation, out BmSDK.Rotator out_DeltaRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessViewRotation, "BmGame.R3rdPersonCamera.ProcessViewRotation");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_ViewRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_ViewRotation, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_DeltaRot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_DeltaRot, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_ViewRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 4);
        out_DeltaRot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_UpdateCamera;
    /// <summary>
    /// Function: UpdateCamera
    /// </summary>
    public unsafe override void UpdateCamera(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCamera, "BmGame.R3rdPersonCamera.UpdateCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FollowCameraRotation;
    /// <summary>
    /// Function: FollowCameraRotation
    /// </summary>
    public unsafe virtual bool FollowCameraRotation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FollowCameraRotation, "BmGame.R3rdPersonCamera.FollowCameraRotation");
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

    private static BmSDK.Function __fn_LookAround;
    /// <summary>
    /// Function: LookAround
    /// </summary>
    public unsafe virtual void LookAround(float DeltaTime, BmSDK.Rotator LookInput)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookAround, "BmGame.R3rdPersonCamera.LookAround");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookInput, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitializeFor;
    /// <summary>
    /// Function: InitializeFor
    /// </summary>
    public unsafe override void InitializeFor(BmSDK.Engine.PlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitializeFor, "BmGame.R3rdPersonCamera.InitializeFor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.R3rdPersonCamera.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopLoopy;
    /// <summary>
    /// Function: StopLoopy
    /// </summary>
    public unsafe virtual void StopLoopy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLoopy, "BmGame.R3rdPersonCamera.StopLoopy");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GoLoopy;
    /// <summary>
    /// Function: GoLoopy
    /// </summary>
    public unsafe virtual void GoLoopy(float inLoopyTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoLoopy, "BmGame.R3rdPersonCamera.GoLoopy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inLoopyTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SaveFreeCameraConfig;
    /// <summary>
    /// Function: SaveFreeCameraConfig
    /// </summary>
    public unsafe virtual void SaveFreeCameraConfig(out BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig ConfigToSave)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveFreeCameraConfig, "BmGame.R3rdPersonCamera.SaveFreeCameraConfig");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ConfigToSave);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConfigToSave, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ConfigToSave = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetFreeCameraConfig;
    /// <summary>
    /// Function: SetFreeCameraConfig
    /// </summary>
    public unsafe virtual void SetFreeCameraConfig(BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig NewConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFreeCameraConfig, "BmGame.R3rdPersonCamera.SetFreeCameraConfig");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewConfig, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StopCameraWander;
    /// <summary>
    /// Function: StopCameraWander
    /// </summary>
    public unsafe virtual void StopCameraWander()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCameraWander, "BmGame.R3rdPersonCamera.StopCameraWander");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartCameraWander;
    /// <summary>
    /// Function: StartCameraWander
    /// </summary>
    public unsafe virtual void StartCameraWander(BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings NewSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCameraWander, "BmGame.R3rdPersonCamera.StartCameraWander");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSettings, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveAllCameraEmitters;
    /// <summary>
    /// Function: RemoveAllCameraEmitters
    /// </summary>
    public unsafe virtual void RemoveAllCameraEmitters()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAllCameraEmitters, "BmGame.R3rdPersonCamera.RemoveAllCameraEmitters");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveCameraEmitter;
    /// <summary>
    /// Function: RemoveCameraEmitter
    /// </summary>
    public unsafe virtual void RemoveCameraEmitter(BmSDK.BmGame.RBMCameraEmitter Emitter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCameraEmitter, "BmGame.R3rdPersonCamera.RemoveCameraEmitter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Emitter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCameraEmitter;
    /// <summary>
    /// Function: AddCameraEmitter
    /// </summary>
    public unsafe virtual void AddCameraEmitter(BmSDK.BmGame.RBMCameraEmitter Emitter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCameraEmitter, "BmGame.R3rdPersonCamera.AddCameraEmitter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Emitter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopLookAt;
    /// <summary>
    /// Function: StopLookAt
    /// </summary>
    public unsafe virtual void StopLookAt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLookAt, "BmGame.R3rdPersonCamera.StopLookAt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LookAtCommon;
    /// <summary>
    /// Function: LookAtCommon
    /// </summary>
    public unsafe virtual bool LookAtCommon(BmSDK.BmGame.RGameInfo.CameraLookAtStrength Strength, bool FollowPitch, bool FollowYaw, float Duration, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed Speed, bool bUseOffset, bool bAllowZoom = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookAtCommon, "BmGame.R3rdPersonCamera.LookAtCommon");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowPitch, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowYaw, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseOffset, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowZoom, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_LookAtPosition;
    /// <summary>
    /// Function: LookAtPosition
    /// </summary>
    public unsafe virtual void LookAtPosition(System.Numerics.Vector3 LookLocation, BmSDK.BmGame.RGameInfo.CameraLookAtStrength Strength = default, bool FollowPitch = default, bool FollowYaw = default, float Duration = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed Speed = default, bool bUseOffset = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookAtPosition, "BmGame.R3rdPersonCamera.LookAtPosition");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowPitch, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowYaw, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseOffset, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LookAtActor;
    /// <summary>
    /// Function: LookAtActor
    /// </summary>
    public unsafe virtual void LookAtActor(BmSDK.Engine.Actor LookActor, System.Numerics.Vector3 Offset = default, BmSDK.BmGame.RGameInfo.CameraLookAtStrength Strength = default, bool FollowPitch = default, bool FollowYaw = default, float Duration = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed Speed = default, bool bUseOffset = default, bool bAllowZoom = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookAtActor, "BmGame.R3rdPersonCamera.LookAtActor");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Offset, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowPitch, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowYaw, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseOffset, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowZoom, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LookInDirection;
    /// <summary>
    /// Function: LookInDirection
    /// </summary>
    public unsafe virtual void LookInDirection(BmSDK.Rotator Direction, BmSDK.BmGame.RGameInfo.CameraLookAtStrength Strength = default, bool FollowPitch = default, bool FollowYaw = default, float Duration = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed Speed = default, bool bUseOffset = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookInDirection, "BmGame.R3rdPersonCamera.LookInDirection");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowPitch, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowYaw, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseOffset, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceLookInDirection;
    /// <summary>
    /// Function: ForceLookInDirection
    /// </summary>
    public unsafe override void ForceLookInDirection(BmSDK.Rotator Direction, bool FollowPitch = default, bool FollowYaw = default, float Duration = default, bool bUseOffset = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceLookInDirection, "BmGame.R3rdPersonCamera.ForceLookInDirection");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowPitch, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowYaw, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseOffset, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowZoomCamera;
    /// <summary>
    /// Function: AllowZoomCamera
    /// </summary>
    public unsafe virtual bool AllowZoomCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowZoomCamera, "BmGame.R3rdPersonCamera.AllowZoomCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateBatarangOutOfRangeFX;
    /// <summary>
    /// Function: UpdateBatarangOutOfRangeFX
    /// </summary>
    public unsafe virtual void UpdateBatarangOutOfRangeFX(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBatarangOutOfRangeFX, "BmGame.R3rdPersonCamera.UpdateBatarangOutOfRangeFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBatarangOutOfRangeFX;
    /// <summary>
    /// Function: SetBatarangOutOfRangeFX
    /// </summary>
    public unsafe virtual void SetBatarangOutOfRangeFX(float Strength)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatarangOutOfRangeFX, "BmGame.R3rdPersonCamera.SetBatarangOutOfRangeFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckLocation;
    /// <summary>
    /// Function: CheckLocation
    /// </summary>
    public unsafe virtual void CheckLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckLocation, "BmGame.R3rdPersonCamera.CheckLocation");
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

    private static BmSDK.Function __fn_ResetSmoother;
    /// <summary>
    /// Function: ResetSmoother
    /// </summary>
    public unsafe virtual void ResetSmoother()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetSmoother, "BmGame.R3rdPersonCamera.ResetSmoother");
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

    private static BmSDK.Function __fn_UpdateCameraWander;
    /// <summary>
    /// Function: UpdateCameraWander
    /// </summary>
    public unsafe virtual void UpdateCameraWander(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCameraWander, "BmGame.R3rdPersonCamera.UpdateCameraWander");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ShouldClipPlayerPawn;
    /// <summary>
    /// Function: ShouldClipPlayerPawn
    /// </summary>
    public unsafe virtual bool ShouldClipPlayerPawn(in BmSDK.GameObject.FTPOV NewPOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldClipPlayerPawn, "BmGame.R3rdPersonCamera.ShouldClipPlayerPawn");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPOV, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Struct: FCameraSmoother
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FCameraSmoother
    {
        /// <summary>
        /// FloatProperty: LastSmoothDistance
        /// </summary>
        public unsafe float LastSmoothDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: CurrentSmootherIndex
        /// </summary>
        public unsafe int CurrentSmootherIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: MinSmootherIndex
        /// </summary>
        public unsafe int MinSmootherIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: DirectionDistance
        /// </summary>
        public unsafe float DirectionDistance_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// FloatProperty: DirectionDistance
        /// </summary>
        public unsafe float DirectionDistance_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// FloatProperty: DirectionDistance
        /// </summary>
        public unsafe float DirectionDistance_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
        /// <summary>
        /// FloatProperty: DirectionDistance
        /// </summary>
        public unsafe float DirectionDistance_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FVector3WithTime
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FVector3WithTime
    {
        /// <summary>
        /// FloatProperty: X
        /// </summary>
        public unsafe float X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Y
        /// </summary>
        public unsafe float Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Z
        /// </summary>
        public unsafe float Z
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: W
        /// </summary>
        public unsafe float W
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FCameraLookAtSpeedDescriptor
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FCameraLookAtSpeedDescriptor
    {
        /// <summary>
        /// FloatProperty: DegreesPerSecond
        /// </summary>
        public unsafe float DegreesPerSecond
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: SlowDownAngle
        /// </summary>
        public unsafe float SlowDownAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: AccelerationModifier
        /// </summary>
        public unsafe float AccelerationModifier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: DecelerationModifier
        /// </summary>
        public unsafe float DecelerationModifier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FCameraWanderSettings
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FCameraWanderSettings
    {
        /// <summary>
        /// FloatProperty: CameraWanderMagnitude
        /// </summary>
        public unsafe float CameraWanderMagnitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderFOVMagnitude
        /// </summary>
        public unsafe float CameraWanderFOVMagnitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderXMagnitude
        /// </summary>
        public unsafe float CameraWanderXMagnitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderRotationMagnitude
        /// </summary>
        public unsafe float CameraWanderRotationMagnitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderRollMagnitude
        /// </summary>
        public unsafe float CameraWanderRollMagnitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderSinComponent1
        /// </summary>
        public unsafe float CameraWanderSinComponent1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderSinComponent2
        /// </summary>
        public unsafe float CameraWanderSinComponent2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderSinComponent3
        /// </summary>
        public unsafe float CameraWanderSinComponent3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderZOffset
        /// </summary>
        public unsafe float CameraWanderZOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: Priority
        /// </summary>
        public unsafe float Priority
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bOnceOnly
        /// </summary>
        public unsafe bool bOnceOnly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: bOneWayWander
        /// </summary>
        public unsafe bool bOneWayWander
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: OneWayTimer
        /// </summary>
        public unsafe float OneWayTimer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: OriginalY
        /// </summary>
        public unsafe float OriginalY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: OriginalZ
        /// </summary>
        public unsafe float OriginalZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: OriginalRoll
        /// </summary>
        public unsafe float OriginalRoll
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// FloatProperty: OriginalPitch
        /// </summary>
        public unsafe float OriginalPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: OriginalYaw
        /// </summary>
        public unsafe float OriginalYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// BoolProperty: bTurnedInTunnel
    /// </summary>
    public unsafe bool bTurnedInTunnel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: CameraOffsetUseUpDown
    /// </summary>
    public unsafe bool CameraOffsetUseUpDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bOverrideCameraFOV
    /// </summary>
    public unsafe bool bOverrideCameraFOV
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: LockInPlace
    /// </summary>
    public unsafe bool LockInPlace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bHidePlayer
    /// </summary>
    public unsafe bool bHidePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bInterpPos
    /// </summary>
    public unsafe bool bInterpPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bDisallowRoll
    /// </summary>
    public unsafe bool bDisallowRoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bAffectsControllerRotation
    /// </summary>
    public unsafe bool bAffectsControllerRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bTemporarilyDisableCameraDrag
    /// </summary>
    public unsafe bool bTemporarilyDisableCameraDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bStatePermanentlyDragsCamera
    /// </summary>
    public unsafe bool bStatePermanentlyDragsCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bDragOnlyFollowsDeliberateDirection
    /// </summary>
    public unsafe bool bDragOnlyFollowsDeliberateDirection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bStatePermanentlyDisablesCameraDrag
    /// </summary>
    public unsafe bool bStatePermanentlyDisablesCameraDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bUseTightFocusPoints
    /// </summary>
    public unsafe bool bUseTightFocusPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bDisableCameraSmoothing
    /// </summary>
    public unsafe bool bDisableCameraSmoothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bFollowPelvis
    /// </summary>
    public unsafe bool bFollowPelvis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bOnlyFollowPelvisZ
    /// </summary>
    public unsafe bool bOnlyFollowPelvisZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bDisableCameraCollision
    /// </summary>
    public unsafe bool bDisableCameraCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bSwayWithPelvis
    /// </summary>
    public unsafe bool bSwayWithPelvis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bDisableCamerCollisionDuringBlend
    /// </summary>
    public unsafe bool bDisableCamerCollisionDuringBlend
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bCameraDebug
    /// </summary>
    public unsafe bool bCameraDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bCameraDebugCollision
    /// </summary>
    public unsafe bool bCameraDebugCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bDebugPlayerPath
    /// </summary>
    public unsafe bool bDebugPlayerPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bDebugCameraSmoothing
    /// </summary>
    public unsafe bool bDebugCameraSmoothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bForce3rdPersonCamera
    /// </summary>
    public unsafe bool bForce3rdPersonCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bDontModifySitOffsetWhenLookingUp
    /// </summary>
    public unsafe bool bDontModifySitOffsetWhenLookingUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bUseAbsoluteHeadOffset
    /// </summary>
    public unsafe bool bUseAbsoluteHeadOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bActuallyUsingAbsoluteHeadRot
    /// </summary>
    public unsafe bool bActuallyUsingAbsoluteHeadRot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bInterpingHeadRot
    /// </summary>
    public unsafe bool bInterpingHeadRot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: ResetInterpPos
    /// </summary>
    public unsafe bool ResetInterpPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: InterpOnlyZPos
    /// </summary>
    public unsafe bool InterpOnlyZPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bAlternativeCam
    /// </summary>
    public unsafe bool bAlternativeCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bDontClipPlayer
    /// </summary>
    public unsafe bool bDontClipPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1268); }
    }

    /// <summary>
    /// BoolProperty: bCameraWandering
    /// </summary>
    public unsafe bool bCameraWandering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bCamOverrideDof
    /// </summary>
    public unsafe bool bCamOverrideDof
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bEnableMotionBlur
    /// </summary>
    public unsafe bool bEnableMotionBlur
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bForceZoom
    /// </summary>
    public unsafe bool bForceZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: CameraLocked
    /// </summary>
    public unsafe bool CameraLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: CameraBlendBatmanRelativePosition
    /// </summary>
    public unsafe bool CameraBlendBatmanRelativePosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bIsCombatCamera
    /// </summary>
    public unsafe bool bIsCombatCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bIsVenomCamera
    /// </summary>
    public unsafe bool bIsVenomCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: EnableCameraAssist
    /// </summary>
    public unsafe bool EnableCameraAssist
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bForceCameraDragOn
    /// </summary>
    public unsafe bool bForceCameraDragOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bCombatDisableCameraDrag
    /// </summary>
    public unsafe bool bCombatDisableCameraDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bOverrideTransitionIn
    /// </summary>
    public unsafe bool bOverrideTransitionIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: PawnHiddenByCamera
    /// </summary>
    public unsafe bool PawnHiddenByCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: LookAtUsesDefaultOffset
    /// </summary>
    public unsafe bool LookAtUsesDefaultOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: UsePitchForLookAt
    /// </summary>
    public unsafe bool UsePitchForLookAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: UseYawForLookAt
    /// </summary>
    public unsafe bool UseYawForLookAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bCeilingRetainOffsetDuringZoom
    /// </summary>
    public unsafe bool bCeilingRetainOffsetDuringZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: DontDrawClosePawns
    /// </summary>
    public unsafe bool DontDrawClosePawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bPauseAndPanCamera
    /// </summary>
    public unsafe bool bPauseAndPanCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bModifyPPForResonatorSreen
    /// </summary>
    public unsafe bool bModifyPPForResonatorSreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bUseFullSway
    /// </summary>
    public unsafe bool bUseFullSway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bRetainOffsetDuringZoom
    /// </summary>
    public unsafe bool bRetainOffsetDuringZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bUseHeadOffsetCheck
    /// </summary>
    public unsafe bool bUseHeadOffsetCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bOverrideCrouchHeadCheck
    /// </summary>
    public unsafe bool bOverrideCrouchHeadCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bBatmanFacesCamera
    /// </summary>
    public unsafe bool bBatmanFacesCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bCustomCameraZoomAllowed
    /// </summary>
    public unsafe bool bCustomCameraZoomAllowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bDontSaveConfig
    /// </summary>
    public unsafe bool bDontSaveConfig
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: Debug_TurnOffZoomDof
    /// </summary>
    public unsafe bool Debug_TurnOffZoomDof
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bForceFollowFullPelvisZ
    /// </summary>
    public unsafe bool bForceFollowFullPelvisZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// BoolProperty: bPreventLoopy
    /// </summary>
    public unsafe bool bPreventLoopy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1272); }
    }

    /// <summary>
    /// StructProperty: CameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1276);

    /// <summary>
    /// StructProperty: CameraOffsetUp
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraOffsetUp
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1288);

    /// <summary>
    /// StructProperty: CameraOffsetDown
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraOffsetDown
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1300);

    /// <summary>
    /// FloatProperty: CameraFOVAngle
    /// </summary>
    public unsafe float CameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// FloatProperty: OverrideCameraFOVAngle
    /// </summary>
    public unsafe float OverrideCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// FloatProperty: OverrideCameraFOVTime
    /// </summary>
    public unsafe float OverrideCameraFOVTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// FloatProperty: OverrideCameraFOVTimer
    /// </summary>
    public unsafe float OverrideCameraFOVTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// FloatProperty: LastOverrideCameraFOVAngle
    /// </summary>
    public unsafe float LastOverrideCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// FloatProperty: CurrentOverrideCameraFOVAngle
    /// </summary>
    public unsafe float CurrentOverrideCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// FloatProperty: OverrideMotionBlurBlendTime
    /// </summary>
    public unsafe float OverrideMotionBlurBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// FloatProperty: OverrideMotionBlurAmount
    /// </summary>
    public unsafe float OverrideMotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// FloatProperty: OldMotionBlurBlendTime
    /// </summary>
    public unsafe float OldMotionBlurBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// FloatProperty: OldMotionBlurAmount
    /// </summary>
    public unsafe float OldMotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// FloatProperty: bOverrideMotionBlurSettings
    /// </summary>
    public unsafe float bOverrideMotionBlurSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// StructProperty: ExtraCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ExtraCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1356);

    /// <summary>
    /// StructProperty: DefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator DefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1368);

    /// <summary>
    /// StructProperty: CameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1380);

    /// <summary>
    /// StructProperty: HeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1392);

    /// <summary>
    /// FloatProperty: ExtraCameraZ
    /// </summary>
    public unsafe float ExtraCameraZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// StructProperty: SmoothClientRotator
    /// </summary>
    public unsafe ref BmSDK.Rotator SmoothClientRotator
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1408);

    /// <summary>
    /// FloatProperty: LastClientRotatorUpdateTime
    /// </summary>
    public unsafe float LastClientRotatorUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// StructProperty: CurrentHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1424);

    /// <summary>
    /// StructProperty: CurrentExtraCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CurrentExtraCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1436);

    /// <summary>
    /// FloatProperty: CurrentExtraCameraZ
    /// </summary>
    public unsafe float CurrentExtraCameraZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// ObjectProperty: DOFManager
    /// </summary>
    public unsafe BmSDK.BmGame.RDOFManager DOFManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDOFManager>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// FloatProperty: TargetFOV
    /// </summary>
    public unsafe float TargetFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// ArrayProperty: CameraEmitters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCameraEmitter> CameraEmitters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCameraEmitter>>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// StructProperty: CurrentCameraPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentCameraPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1472);

    /// <summary>
    /// StructProperty: CurrentCameraRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CurrentCameraRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1484);

    /// <summary>
    /// FloatProperty: CurrentCameraFOVAngle
    /// </summary>
    public unsafe float CurrentCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// StructProperty: CurrentCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1500);

    /// <summary>
    /// StructProperty: ActualCameraPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ActualCameraPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1512);

    /// <summary>
    /// StructProperty: ActualCameraRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator ActualCameraRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1524);

    /// <summary>
    /// StructProperty: LastVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1536);

    /// <summary>
    /// FloatProperty: TimeInCurrentState
    /// </summary>
    public unsafe float TimeInCurrentState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// FloatProperty: TransitionTime
    /// </summary>
    public unsafe float TransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }

    /// <summary>
    /// IntProperty: maxPitch
    /// </summary>
    public unsafe int maxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// IntProperty: MinPitch
    /// </summary>
    public unsafe int MinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// IntProperty: MaxYaw
    /// </summary>
    public unsafe int MaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// IntProperty: MinYaw
    /// </summary>
    public unsafe int MinYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxYaw
    /// </summary>
    public unsafe float CurrentMaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// FloatProperty: CurrentMinYaw
    /// </summary>
    public unsafe float CurrentMinYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxPitch
    /// </summary>
    public unsafe float CurrentMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// FloatProperty: CurrentMinPitch
    /// </summary>
    public unsafe float CurrentMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// StructProperty: RotationSpeed
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RotationSpeed
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1588);

    /// <summary>
    /// FloatProperty: YawAccel
    /// </summary>
    public unsafe float YawAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }

    /// <summary>
    /// FloatProperty: PitchAccel
    /// </summary>
    public unsafe float PitchAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }

    /// <summary>
    /// FloatProperty: YawDecel
    /// </summary>
    public unsafe float YawDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// FloatProperty: PitchDecel
    /// </summary>
    public unsafe float PitchDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// FloatProperty: CameraCeilingLimit
    /// </summary>
    public unsafe float CameraCeilingLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// FloatProperty: CameraFloorLimit
    /// </summary>
    public unsafe float CameraFloorLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// StructProperty: WalkStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WalkStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1624);

    /// <summary>
    /// FloatProperty: WalkStateCameraFOVAngle
    /// </summary>
    public unsafe float WalkStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// StructProperty: WalkStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator WalkStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1640);

    /// <summary>
    /// StructProperty: DialogueStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DialogueStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1652);

    /// <summary>
    /// FloatProperty: DialogueStateCameraFOVAngle
    /// </summary>
    public unsafe float DialogueStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// StructProperty: DialogueStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator DialogueStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1668);

    /// <summary>
    /// StructProperty: ForensicsScanStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ForensicsScanStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1680);

    /// <summary>
    /// FloatProperty: ForensicsScanStateCameraFOVAngle
    /// </summary>
    public unsafe float ForensicsScanStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// StructProperty: ForensicsScanStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ForensicsScanStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1696);

    /// <summary>
    /// StructProperty: UsingSpotlightStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 UsingSpotlightStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1708);

    /// <summary>
    /// FloatProperty: UsingSpotlightStateCameraFOVAngle
    /// </summary>
    public unsafe float UsingSpotlightStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// StructProperty: UsingSpotlightStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator UsingSpotlightStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1724);

    /// <summary>
    /// StructProperty: ForensicsFilterStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ForensicsFilterStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1736);

    /// <summary>
    /// FloatProperty: ForensicsFilterStateCameraFOVAngle
    /// </summary>
    public unsafe float ForensicsFilterStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// StructProperty: ForensicsFilterStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ForensicsFilterStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1752);

    /// <summary>
    /// StructProperty: RunStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RunStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1764);

    /// <summary>
    /// FloatProperty: RunStateCameraFOVAngle
    /// </summary>
    public unsafe float RunStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// FloatProperty: BoostRunFOVAngle
    /// </summary>
    public unsafe float BoostRunFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// StructProperty: RunStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator RunStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1784);

    /// <summary>
    /// StructProperty: PairedAnimationStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PairedAnimationStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1796);

    /// <summary>
    /// FloatProperty: PairedAnimationStateCameraFOVAngle
    /// </summary>
    public unsafe float PairedAnimationStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// StructProperty: PairedAnimationStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator PairedAnimationStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1812);

    /// <summary>
    /// StructProperty: StealthStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StealthStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1824);

    /// <summary>
    /// FloatProperty: StealthStateCameraFOVAngle
    /// </summary>
    public unsafe float StealthStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// FloatProperty: OverworldStealthStateCameraFOVAngle
    /// </summary>
    public unsafe float OverworldStealthStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// StructProperty: StealthStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator StealthStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1844);

    /// <summary>
    /// StructProperty: TunnelStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TunnelStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1856);

    /// <summary>
    /// FloatProperty: TunnelStateCameraFOVAngle
    /// </summary>
    public unsafe float TunnelStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// StructProperty: TunnelStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator TunnelStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1872);

    /// <summary>
    /// StructProperty: TunnelStateCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TunnelStateCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1884);

    /// <summary>
    /// StructProperty: GrappleDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator GrappleDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1896);

    /// <summary>
    /// StructProperty: FallingStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FallingStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1908);

    /// <summary>
    /// FloatProperty: FallingStateCameraFOVAngle
    /// </summary>
    public unsafe float FallingStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// StructProperty: FallingDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator FallingDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1924);

    /// <summary>
    /// FloatProperty: FallingStateSwingSmoothingStrength
    /// </summary>
    public unsafe float FallingStateSwingSmoothingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// FloatProperty: FallingStateSwingTransitionTime
    /// </summary>
    public unsafe float FallingStateSwingTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// StructProperty: GrappleAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1944);

    /// <summary>
    /// FloatProperty: GrappleAimCameraFOVAngle
    /// </summary>
    public unsafe float GrappleAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }

    /// <summary>
    /// StructProperty: GrappleAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator GrappleAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1960);

    /// <summary>
    /// IntProperty: GrappleAimMaxPitch
    /// </summary>
    public unsafe int GrappleAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// IntProperty: GrappleAimMinPitch
    /// </summary>
    public unsafe int GrappleAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// StructProperty: HarpoonAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HarpoonAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1980);

    /// <summary>
    /// FloatProperty: HarpoonAimCameraFOVAngle
    /// </summary>
    public unsafe float HarpoonAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }

    /// <summary>
    /// StructProperty: HarpoonAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator HarpoonAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1996);

    /// <summary>
    /// IntProperty: HarpoonAimMaxPitch
    /// </summary>
    public unsafe int HarpoonAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }
    }

    /// <summary>
    /// IntProperty: HarpoonAimMinPitch
    /// </summary>
    public unsafe int HarpoonAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// StructProperty: MagneticBlastAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MagneticBlastAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2016);

    /// <summary>
    /// FloatProperty: MagneticBlastAimCameraFOVAngle
    /// </summary>
    public unsafe float MagneticBlastAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// StructProperty: MagneticBlastAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator MagneticBlastAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2032);

    /// <summary>
    /// IntProperty: MagneticBlastAimMaxPitch
    /// </summary>
    public unsafe int MagneticBlastAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// IntProperty: MagneticBlastAimMinPitch
    /// </summary>
    public unsafe int MagneticBlastAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// StructProperty: FreezeJammerAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreezeJammerAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2052);

    /// <summary>
    /// FloatProperty: FreezeJammerAimCameraFOVAngle
    /// </summary>
    public unsafe float FreezeJammerAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// StructProperty: FreezeJammerAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator FreezeJammerAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2068);

    /// <summary>
    /// IntProperty: FreezeJammerAimMaxPitch
    /// </summary>
    public unsafe int FreezeJammerAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// IntProperty: FreezeJammerAimMinPitch
    /// </summary>
    public unsafe int FreezeJammerAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// StructProperty: JokerGunAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 JokerGunAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2088);

    /// <summary>
    /// FloatProperty: JokerGunAimCameraFOVAngle
    /// </summary>
    public unsafe float JokerGunAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// IntProperty: JokerGunAimMaxPitch
    /// </summary>
    public unsafe int JokerGunAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// IntProperty: JokerGunAimMinPitch
    /// </summary>
    public unsafe int JokerGunAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// StructProperty: LineLauncherAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LineLauncherAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2112);

    /// <summary>
    /// FloatProperty: LineLauncherAimCameraFOVAngle
    /// </summary>
    public unsafe float LineLauncherAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// StructProperty: LineLauncherAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator LineLauncherAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2128);

    /// <summary>
    /// IntProperty: LineLauncherAimMaxPitch
    /// </summary>
    public unsafe int LineLauncherAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// IntProperty: LineLauncherAimMinPitch
    /// </summary>
    public unsafe int LineLauncherAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// StructProperty: BatarangAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatarangAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2148);

    /// <summary>
    /// FloatProperty: BatarangAimCameraFOVAngle
    /// </summary>
    public unsafe float BatarangAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// StructProperty: BatarangAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator BatarangAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2164);

    /// <summary>
    /// IntProperty: BatarangAimMaxPitch
    /// </summary>
    public unsafe int BatarangAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// IntProperty: BatarangAimMinPitch
    /// </summary>
    public unsafe int BatarangAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// StructProperty: WallClimbStartCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallClimbStartCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2184);

    /// <summary>
    /// FloatProperty: WallClimbStartCameraFOVAngle
    /// </summary>
    public unsafe float WallClimbStartCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// StructProperty: WallClimbHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallClimbHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2200);

    /// <summary>
    /// StructProperty: PounceCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PounceCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2212);

    /// <summary>
    /// FloatProperty: PounceCameraFOVAngle
    /// </summary>
    public unsafe float PounceCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// StructProperty: PounceHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PounceHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2228);

    /// <summary>
    /// StructProperty: VantageClimbHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VantageClimbHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2240);

    /// <summary>
    /// StructProperty: BatTrackerAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatTrackerAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2252);

    /// <summary>
    /// FloatProperty: BatTrackerAimCameraFOVAngle
    /// </summary>
    public unsafe float BatTrackerAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// StructProperty: BatTrackerAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator BatTrackerAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2268);

    /// <summary>
    /// StructProperty: BatTrackerAimTargetOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatTrackerAimTargetOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2280);

    /// <summary>
    /// FloatProperty: CorridorCombatStateCameraFOVAngle
    /// </summary>
    public unsafe float CorridorCombatStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }

    /// <summary>
    /// FloatProperty: HighCombatStateCameraFOVAngle
    /// </summary>
    public unsafe float HighCombatStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// StructProperty: LookStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LookStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2300);

    /// <summary>
    /// FloatProperty: LookStateCameraFOVAngle
    /// </summary>
    public unsafe float LookStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// StructProperty: LookStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator LookStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2316);

    /// <summary>
    /// IntProperty: LookStateMaxPitch
    /// </summary>
    public unsafe int LookStateMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }

    /// <summary>
    /// IntProperty: LookStateMinPitch
    /// </summary>
    public unsafe int LookStateMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// FloatProperty: LookModeScale
    /// </summary>
    public unsafe float LookModeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// FloatProperty: LookSpringBack
    /// </summary>
    public unsafe float LookSpringBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }

    /// <summary>
    /// FloatProperty: GrappleLookSpringBack
    /// </summary>
    public unsafe float GrappleLookSpringBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }
    }

    /// <summary>
    /// FloatProperty: GrappleCameraFOVAngle
    /// </summary>
    public unsafe float GrappleCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// FloatProperty: ZoomStateCameraFOVAngle
    /// </summary>
    public unsafe float ZoomStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// StructProperty: CoverRightCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CoverRightCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2356);

    /// <summary>
    /// FloatProperty: CoverRightCameraFOVAngle
    /// </summary>
    public unsafe float CoverRightCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// StructProperty: CoverRightCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CoverRightCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2372);

    /// <summary>
    /// StructProperty: AlcoveCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AlcoveCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2384);

    /// <summary>
    /// FloatProperty: AlcoveCameraFOVAngle
    /// </summary>
    public unsafe float AlcoveCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// StructProperty: AlcoveCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator AlcoveCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2400);

    /// <summary>
    /// StructProperty: AlcoveCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AlcoveCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2412);

    /// <summary>
    /// StructProperty: GlidingCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GlidingCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2424);

    /// <summary>
    /// FloatProperty: GlidingCameraFOVAngle
    /// </summary>
    public unsafe float GlidingCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// FloatProperty: GlidingCameraExtraFOVAngle
    /// </summary>
    public unsafe float GlidingCameraExtraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// StructProperty: GlidingCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator GlidingCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2444);

    /// <summary>
    /// FloatProperty: GlideLagStrength
    /// </summary>
    public unsafe float GlideLagStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// FloatProperty: GlideLagBoostStrength
    /// </summary>
    public unsafe float GlideLagBoostStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// FloatProperty: GlideLagStrengthBlendTime
    /// </summary>
    public unsafe float GlideLagStrengthBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// FloatProperty: DiveCameraOrientationTime
    /// </summary>
    public unsafe float DiveCameraOrientationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// StructProperty: GlideKickOffWallHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GlideKickOffWallHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2472);

    /// <summary>
    /// StructProperty: BoostGlidingCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BoostGlidingCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2484);

    /// <summary>
    /// FloatProperty: BoostGlidingCameraFOVAngle
    /// </summary>
    public unsafe float BoostGlidingCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// StructProperty: BoostGlidingCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator BoostGlidingCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2500);

    /// <summary>
    /// StructProperty: PouncingCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PouncingCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2512);

    /// <summary>
    /// StructProperty: SilentPredCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SilentPredCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2524);

    /// <summary>
    /// StructProperty: SilentPredCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SilentPredCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2536);

    /// <summary>
    /// FloatProperty: SilentPredCameraFOVAngle
    /// </summary>
    public unsafe float SilentPredCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// StructProperty: SilentPredDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator SilentPredDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2552);

    /// <summary>
    /// FloatProperty: ZoomSilentPredCameraFOVAngle
    /// </summary>
    public unsafe float ZoomSilentPredCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// StructProperty: ZoomSilentPredCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomSilentPredCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2568);

    /// <summary>
    /// StructProperty: HangCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HangCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2580);

    /// <summary>
    /// FloatProperty: HangCameraFOVAngle
    /// </summary>
    public unsafe float HangCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// StructProperty: HangDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator HangDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2596);

    /// <summary>
    /// FloatProperty: MinFreeCameraDistance
    /// </summary>
    public unsafe float MinFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// FloatProperty: MaxFreeCameraDistance
    /// </summary>
    public unsafe float MaxFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// FloatProperty: ShortCamSpringConst
    /// </summary>
    public unsafe float ShortCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// FloatProperty: LongCamSpringConst
    /// </summary>
    public unsafe float LongCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2620); }
    }

    /// <summary>
    /// StructProperty: LastLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2624);

    /// <summary>
    /// FloatProperty: CurrentShortCamSpringConst
    /// </summary>
    public unsafe float CurrentShortCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// FloatProperty: CurrentLongCamSpringConst
    /// </summary>
    public unsafe float CurrentLongCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// StructProperty: CameraPivotOffsetDef
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraPivotOffsetDef
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2644);

    /// <summary>
    /// IntProperty: MaxFreeCameraPitch
    /// </summary>
    public unsafe int MaxFreeCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// IntProperty: MinFreeCameraPitch
    /// </summary>
    public unsafe int MinFreeCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2660); }
    }

    /// <summary>
    /// FloatProperty: ZoomSensitivityMod
    /// </summary>
    public unsafe float ZoomSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// FloatProperty: LookSensitivityMod
    /// </summary>
    public unsafe float LookSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2668); }
    }

    /// <summary>
    /// FloatProperty: HarpoonSensitivityMod
    /// </summary>
    public unsafe float HarpoonSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// FloatProperty: JokerGunSensitivityMod
    /// </summary>
    public unsafe float JokerGunSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2676); }
    }

    /// <summary>
    /// StructProperty: BaseCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BaseCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2680);

    /// <summary>
    /// StructProperty: ExtraCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ExtraCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2692);

    /// <summary>
    /// StructProperty: FreeCamBobLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCamBobLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2704);

    /// <summary>
    /// StructProperty: LastDesiredCamPositionForDrag
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastDesiredCamPositionForDrag
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2716);

    /// <summary>
    /// StructProperty: ZipLineCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZipLineCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2728);

    /// <summary>
    /// FloatProperty: ZipLineCameraFOVAngle
    /// </summary>
    public unsafe float ZipLineCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2740); }
    }

    /// <summary>
    /// StructProperty: ZipLineDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ZipLineDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2744);

    /// <summary>
    /// StructProperty: ZipLineTargetOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZipLineTargetOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2756);

    /// <summary>
    /// StructProperty: HarpoonPullCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HarpoonPullCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2768);

    /// <summary>
    /// FloatProperty: HarpoonPullCameraFOVAngle
    /// </summary>
    public unsafe float HarpoonPullCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2780); }
    }

    /// <summary>
    /// StructProperty: HarpoonPullDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator HarpoonPullDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2784);

    /// <summary>
    /// StructProperty: HarpoonPullTargetOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HarpoonPullTargetOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2796);

    /// <summary>
    /// StructProperty: FixedCameraHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FixedCameraHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2808);

    /// <summary>
    /// StructProperty: FreeCameraHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCameraHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2820);

    /// <summary>
    /// StructProperty: AlcoveCameraHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AlcoveCameraHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2832);

    /// <summary>
    /// StructProperty: SwingingFromAboveCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SwingingFromAboveCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2844);

    /// <summary>
    /// FloatProperty: SwingingFromAboveCameraFOVAngle
    /// </summary>
    public unsafe float SwingingFromAboveCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2856); }
    }

    /// <summary>
    /// StructProperty: SwingingFromAboveCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator SwingingFromAboveCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2860);

    /// <summary>
    /// FloatProperty: CeilingClimbCamFOVAngle
    /// </summary>
    public unsafe float CeilingClimbCamFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2872); }
    }

    /// <summary>
    /// StructProperty: CeilingClimbCamHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CeilingClimbCamHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2876);

    /// <summary>
    /// StructProperty: CeilingClimbCamRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CeilingClimbCamRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2888);

    /// <summary>
    /// FloatProperty: ZoomFOV
    /// </summary>
    public unsafe float ZoomFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2900); }
    }

    /// <summary>
    /// FloatProperty: ZoomTime
    /// </summary>
    public unsafe float ZoomTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2904); }
    }

    /// <summary>
    /// FloatProperty: RaftPullFOVAngle
    /// </summary>
    public unsafe float RaftPullFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2908); }
    }

    /// <summary>
    /// IntProperty: ForcedPitch
    /// </summary>
    public unsafe int ForcedPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2912); }
    }

    /// <summary>
    /// StructProperty: TransitionOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TransitionOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2916);

    /// <summary>
    /// StructProperty: TransitionRotatorOffset
    /// </summary>
    public unsafe ref BmSDK.Rotator TransitionRotatorOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2928);

    /// <summary>
    /// FloatProperty: TransitionFOV
    /// </summary>
    public unsafe float TransitionFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2940); }
    }

    /// <summary>
    /// FloatProperty: CurrentMinFreeCameraDistance
    /// </summary>
    public unsafe float CurrentMinFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2944); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxFreeCameraDistance
    /// </summary>
    public unsafe float CurrentMaxFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2948); }
    }

    /// <summary>
    /// ObjectProperty: ScreenShakeModifier
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier ScreenShakeModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier>(Ptr + 2952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2952); }
    }

    /// <summary>
    /// StructProperty: GrateCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrateCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2956);

    /// <summary>
    /// StructProperty: FreeCameraSitOffsetMin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCameraSitOffsetMin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2968);

    /// <summary>
    /// StructProperty: FreeCameraSitOffsetMax
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCameraSitOffsetMax
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2980);

    /// <summary>
    /// StructProperty: FreeCameraPullOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCameraPullOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2992);

    /// <summary>
    /// FloatProperty: CurrentSitOffsetPower
    /// </summary>
    public unsafe float CurrentSitOffsetPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3004); }
    }

    /// <summary>
    /// StructProperty: StateFreeCameraSitOffsetMin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StateFreeCameraSitOffsetMin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3008);

    /// <summary>
    /// StructProperty: StateFreeCameraSitOffsetMax
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StateFreeCameraSitOffsetMax
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3020);

    /// <summary>
    /// StructProperty: StateFreeCameraPullOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StateFreeCameraPullOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3032);

    /// <summary>
    /// FloatProperty: StateSitOffsetPower
    /// </summary>
    public unsafe float StateSitOffsetPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3044); }
    }

    /// <summary>
    /// FloatProperty: StateDefaultCameraPitch
    /// </summary>
    public unsafe float StateDefaultCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3048); }
    }

    /// <summary>
    /// FloatProperty: CurrentDefaultCameraPitch
    /// </summary>
    public unsafe float CurrentDefaultCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3052); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraFollowPelvisXY
    /// </summary>
    public unsafe float CurrentCameraFollowPelvisXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3056); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraFollowPelvisZ
    /// </summary>
    public unsafe float CurrentCameraFollowPelvisZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3060); }
    }

    /// <summary>
    /// FloatProperty: CurrentPelvisSway
    /// </summary>
    public unsafe float CurrentPelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3064); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3068);

    /// <summary>
    /// FloatProperty: EdgeSwingCameraFOVAngle
    /// </summary>
    public unsafe float EdgeSwingCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3080); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator EdgeSwingCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3084);

    /// <summary>
    /// StructProperty: CurrentAbsoluteHeadRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CurrentAbsoluteHeadRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3096);

    /// <summary>
    /// StructProperty: LastAnchorRot
    /// </summary>
    public unsafe ref BmSDK.Rotator LastAnchorRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3108);

    /// <summary>
    /// StructProperty: BaseZoomDOFSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.RDOFManager.FDofStruct BaseZoomDOFSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RDOFManager.FDofStruct>(Ptr + 3120);

    /// <summary>
    /// FloatProperty: MinZoomFarBlur
    /// </summary>
    public unsafe float MinZoomFarBlur
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }
    }

    /// <summary>
    /// StructProperty: ZoomedDOFSetting
    /// </summary>
    public unsafe ref BmSDK.BmGame.RDOFManager.FDofStruct ZoomedDOFSetting
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RDOFManager.FDofStruct>(Ptr + 3188);

    /// <summary>
    /// FloatProperty: VenomHenchmenCombatCameraFOVAngle
    /// </summary>
    public unsafe float VenomHenchmenCombatCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3252); }
    }

    /// <summary>
    /// FloatProperty: PenguinBeatdownFOVAngle
    /// </summary>
    public unsafe float PenguinBeatdownFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3256); }
    }

    /// <summary>
    /// StructProperty: WalkCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig WalkCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3260);

    /// <summary>
    /// StructProperty: AgilityWalkCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig AgilityWalkCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3384);

    /// <summary>
    /// StructProperty: RunCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RunCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3508);

    /// <summary>
    /// StructProperty: RooftopRunCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RooftopRunCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3632);

    /// <summary>
    /// StructProperty: DemonTrialsCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig DemonTrialsCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3756);

    /// <summary>
    /// StructProperty: CombatWalkCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CombatWalkCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3880);

    /// <summary>
    /// StructProperty: StandingHoldCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig StandingHoldCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4004);

    /// <summary>
    /// StructProperty: StandingGrabCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig StandingGrabCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4128);

    /// <summary>
    /// StructProperty: GrappleCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig GrappleCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4252);

    /// <summary>
    /// StructProperty: GrappleRescueCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig GrappleRescueCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4376);

    /// <summary>
    /// StructProperty: CapeChuteConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CapeChuteConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4500);

    /// <summary>
    /// StructProperty: LedgeHangCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig LedgeHangCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4624);

    /// <summary>
    /// StructProperty: LedgeHangKickedByThugCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig LedgeHangKickedByThugCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4748);

    /// <summary>
    /// StructProperty: LedgeHangTakedownStartCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig LedgeHangTakedownStartCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4872);

    /// <summary>
    /// StructProperty: LedgeHangTakedownCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig LedgeHangTakedownCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4996);

    /// <summary>
    /// StructProperty: QuickTakedownCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig QuickTakedownCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5120);

    /// <summary>
    /// StructProperty: GenericFarFreeCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig GenericFarFreeCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5244);

    /// <summary>
    /// StructProperty: RaftPullCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RaftPullCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5368);

    /// <summary>
    /// StructProperty: VantagePointSwingCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig VantagePointSwingCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5492);

    /// <summary>
    /// StructProperty: HangPointCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig HangPointCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5616);

    /// <summary>
    /// StructProperty: StealthCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig StealthCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5740);

    /// <summary>
    /// StructProperty: StealthWallCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig StealthWallCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5864);

    /// <summary>
    /// StructProperty: CrouchUnderObstacleCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CrouchUnderObstacleCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5988);

    /// <summary>
    /// StructProperty: RailingCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RailingCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6112);

    /// <summary>
    /// StructProperty: FloorAttackCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FloorAttackCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6236);

    /// <summary>
    /// StructProperty: IntroCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig IntroCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6360);

    /// <summary>
    /// StructProperty: SwingingCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig SwingingCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6484);

    /// <summary>
    /// StructProperty: WallClimbCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig WallClimbCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6608);

    /// <summary>
    /// StructProperty: WallClimbStartCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig WallClimbStartCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6732);

    /// <summary>
    /// StructProperty: PounceCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig PounceCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6856);

    /// <summary>
    /// StructProperty: VantageClimbCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig VantageClimbCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6980);

    /// <summary>
    /// StructProperty: SwingingFromAboveCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig SwingingFromAboveCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7104);

    /// <summary>
    /// StructProperty: TakedownFromAboveCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig TakedownFromAboveCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7228);

    /// <summary>
    /// StructProperty: SilentPredatorCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig SilentPredatorCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7352);

    /// <summary>
    /// StructProperty: CorridorCombatCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CorridorCombatCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7476);

    /// <summary>
    /// StructProperty: HighCombatCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig HighCombatCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7600);

    /// <summary>
    /// StructProperty: LookDownCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig LookDownCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7724);

    /// <summary>
    /// StructProperty: LineLauncherCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig LineLauncherCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7848);

    /// <summary>
    /// StructProperty: BatarangCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig BatarangCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7972);

    /// <summary>
    /// StructProperty: HarpoonAimConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig HarpoonAimConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8096);

    /// <summary>
    /// StructProperty: MagneticBlastAimConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig MagneticBlastAimConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8220);

    /// <summary>
    /// StructProperty: FreezeJammerAimConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreezeJammerAimConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8344);

    /// <summary>
    /// StructProperty: JokerGunAimConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig JokerGunAimConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8468);

    /// <summary>
    /// StructProperty: GrateCameraConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig GrateCameraConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8592);

    /// <summary>
    /// StructProperty: HighGrateCameraConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig HighGrateCameraConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8716);

    /// <summary>
    /// StructProperty: VenomHenchmenCombatCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig VenomHenchmenCombatCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8840);

    /// <summary>
    /// StructProperty: VenomHenchmenRideCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig VenomHenchmenRideCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8964);

    /// <summary>
    /// StructProperty: SlideCameraConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig SlideCameraConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9088);

    /// <summary>
    /// StructProperty: GrundyCombatCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig GrundyCombatCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9212);

    /// <summary>
    /// StructProperty: ClayfaceCombatCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig ClayfaceCombatCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9336);

    /// <summary>
    /// StructProperty: ClayfaceCoupCombatCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig ClayfaceCoupCombatCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9460);

    /// <summary>
    /// StructProperty: RasChokeCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RasChokeCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9584);

    /// <summary>
    /// StructProperty: RasManoCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RasManoCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9708);

    /// <summary>
    /// StructProperty: RasFuryCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RasFuryCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9832);

    /// <summary>
    /// StructProperty: RasBurlyCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RasBurlyCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9956);

    /// <summary>
    /// StructProperty: RasSwordCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RasSwordCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10080);

    /// <summary>
    /// StructProperty: CeilingClimbCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CeilingClimbCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10204);

    /// <summary>
    /// StructProperty: CeilingToLedgeHangCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CeilingToLedgeHangCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10328);

    /// <summary>
    /// StructProperty: CeilingToCatwalkCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CeilingToCatwalkCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10452);

    /// <summary>
    /// StructProperty: CeilingBatarangCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CeilingBatarangCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10576);

    /// <summary>
    /// StructProperty: LedgeSwingCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig LedgeSwingCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10700);

    /// <summary>
    /// StructProperty: DeepFallLandCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig DeepFallLandCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10824);

    /// <summary>
    /// StructProperty: HelicopterCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig HelicopterCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10948);

    /// <summary>
    /// StructProperty: PenguinBeatdownCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig PenguinBeatdownCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 11072);

    /// <summary>
    /// FloatProperty: LookDownVantageCamFOVAngle
    /// </summary>
    public unsafe float LookDownVantageCamFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11196); }
    }

    /// <summary>
    /// StructProperty: LookDownDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator LookDownDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11200);

    /// <summary>
    /// StructProperty: AlternativeWalkCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig AlternativeWalkCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 11212);

    /// <summary>
    /// FloatProperty: AlternativeWalkCamFOV
    /// </summary>
    public unsafe float AlternativeWalkCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11336); }
    }

    /// <summary>
    /// FloatProperty: SlideStateCameraFOVAngle
    /// </summary>
    public unsafe float SlideStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11340); }
    }

    /// <summary>
    /// StructProperty: DiveOverRailingPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DiveOverRailingPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11344);

    /// <summary>
    /// FloatProperty: DiveOverRailingPitch
    /// </summary>
    public unsafe float DiveOverRailingPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11356); }
    }

    /// <summary>
    /// FloatProperty: CameraWanderTimer
    /// </summary>
    public unsafe float CameraWanderTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11360); }
    }

    /// <summary>
    /// StructProperty: CameraWander
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraWander
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11364);

    /// <summary>
    /// StructProperty: CameraWanderRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CameraWanderRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11376);

    /// <summary>
    /// FloatProperty: CameraWanderFOV
    /// </summary>
    public unsafe float CameraWanderFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11388); }
    }

    /// <summary>
    /// StructProperty: CurrentCameraWanderSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings CurrentCameraWanderSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings>(Ptr + 11392);

    /// <summary>
    /// StructProperty: ResonatorWanderSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings ResonatorWanderSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings>(Ptr + 11460);

    /// <summary>
    /// StructProperty: ScarecrowWanderSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings ScarecrowWanderSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings>(Ptr + 11528);

    /// <summary>
    /// StructProperty: GlideWanderSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings GlideWanderSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings>(Ptr + 11596);

    /// <summary>
    /// StructProperty: GlideCameraShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct GlideCameraShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 11664);

    /// <summary>
    /// StructProperty: BoostGlideCameraShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct BoostGlideCameraShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 11808);

    /// <summary>
    /// IntProperty: GlideShakeId
    /// </summary>
    public unsafe int GlideShakeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11952); }
    }

    /// <summary>
    /// FloatProperty: Test
    /// </summary>
    public unsafe float Test
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11956); }
    }

    /// <summary>
    /// ObjectProperty: MotionBlurEffect
    /// </summary>
    public unsafe BmSDK.Engine.RockOn MotionBlurEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockOn>(Ptr + 11960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11960); }
    }

    /// <summary>
    /// ObjectProperty: UberEffect
    /// </summary>
    public unsafe BmSDK.Engine.RockOn UberEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockOn>(Ptr + 11964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11964); }
    }

    /// <summary>
    /// IntProperty: GrappleMaxPitch
    /// </summary>
    public unsafe int GrappleMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11968); }
    }

    /// <summary>
    /// StructProperty: CameraBlendRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CameraBlendRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11972);

    /// <summary>
    /// StructProperty: CameraBlendInitialRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CameraBlendInitialRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11984);

    /// <summary>
    /// StructProperty: ExtraDeltaRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ExtraDeltaRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11996);

    /// <summary>
    /// StructProperty: CornerStateOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CornerStateOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12008);

    /// <summary>
    /// FloatProperty: CornerStateFOVAngle
    /// </summary>
    public unsafe float CornerStateFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12020); }
    }

    /// <summary>
    /// StructProperty: CornerStateDefaultRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CornerStateDefaultRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12024);

    /// <summary>
    /// StructProperty: CornerStateCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CornerStateCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12036);

    /// <summary>
    /// FloatProperty: ZoomedFOVAngle
    /// </summary>
    public unsafe float ZoomedFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12048); }
    }

    /// <summary>
    /// FloatProperty: ZoomProp
    /// </summary>
    public unsafe float ZoomProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12052); }
    }

    /// <summary>
    /// FloatProperty: ForceZoomFOVAngle
    /// </summary>
    public unsafe float ForceZoomFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12056); }
    }

    /// <summary>
    /// FloatProperty: MotionBlurAmount
    /// </summary>
    public unsafe float MotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12060); }
    }

    /// <summary>
    /// FloatProperty: MotionBlurBlendTime
    /// </summary>
    public unsafe float MotionBlurBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12064); }
    }

    /// <summary>
    /// FloatProperty: InitialMotionBlurAmount
    /// </summary>
    public unsafe float InitialMotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12068); }
    }

    /// <summary>
    /// FloatProperty: InitialMotionBlurMaxVelocity
    /// </summary>
    public unsafe float InitialMotionBlurMaxVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12072); }
    }

    /// <summary>
    /// FloatProperty: MinCameraMotionBlur
    /// </summary>
    public unsafe float MinCameraMotionBlur
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12076); }
    }

    /// <summary>
    /// StructProperty: ResonatorCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ResonatorCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12080);

    /// <summary>
    /// FloatProperty: ResonatorFOVAngle
    /// </summary>
    public unsafe float ResonatorFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12092); }
    }

    /// <summary>
    /// StructProperty: ResonatorCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ResonatorCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12096);

    /// <summary>
    /// StructProperty: LastCameraPivotPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastCameraPivotPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12108);

    /// <summary>
    /// FloatProperty: OverrideBloomValue
    /// </summary>
    public unsafe float OverrideBloomValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12120); }
    }

    /// <summary>
    /// FloatProperty: LoadedAspectRatio
    /// </summary>
    public unsafe float LoadedAspectRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12124); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraAssistStrength
    /// </summary>
    public unsafe float CurrentCameraAssistStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12128); }
    }

    /// <summary>
    /// FloatProperty: CameraAssistBuildUpTime
    /// </summary>
    public unsafe float CameraAssistBuildUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12132); }
    }

    /// <summary>
    /// StructProperty: CurrentDefaultPelvisDiff
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentDefaultPelvisDiff
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12136);

    /// <summary>
    /// StructProperty: DefaultPelvisDiff
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DefaultPelvisDiff
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12148);

    /// <summary>
    /// FloatProperty: LastStepUpOffset
    /// </summary>
    public unsafe float LastStepUpOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12160); }
    }

    /// <summary>
    /// ArrayProperty: RetainZoomStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> RetainZoomStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 12164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12164); }
    }

    /// <summary>
    /// ArrayProperty: ForceUnZoomStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ForceUnZoomStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 12176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12176); }
    }

    /// <summary>
    /// FloatProperty: OverrideTransitionInDuration
    /// </summary>
    public unsafe float OverrideTransitionInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12188); }
    }

    /// <summary>
    /// StructProperty: CameraCullingExtents
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraCullingExtents
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12192);

    /// <summary>
    /// ArrayProperty: LookAtSpeeds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.R3rdPersonCamera.FCameraLookAtSpeedDescriptor> LookAtSpeeds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.R3rdPersonCamera.FCameraLookAtSpeedDescriptor>>(Ptr + 12204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12204); }
    }

    /// <summary>
    /// ByteProperty: LookAtSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtSpeed LookAtSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtSpeed>(Ptr + 12216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12216); }
    }

    /// <summary>
    /// ByteProperty: LookAtType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtType LookAtType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtType>(Ptr + 12217); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12217); }
    }

    /// <summary>
    /// ByteProperty: LookAtStrength
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtStrength LookAtStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtStrength>(Ptr + 12218); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12218); }
    }

    /// <summary>
    /// ByteProperty: CurrentZoomPoint
    /// </summary>
    public unsafe byte CurrentZoomPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12219); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12219); }
    }

    /// <summary>
    /// FloatProperty: CustomLookAtAccelerationModifier
    /// </summary>
    public unsafe float CustomLookAtAccelerationModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12220); }
    }

    /// <summary>
    /// StructProperty: DesiredLookRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator DesiredLookRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12224);

    /// <summary>
    /// StructProperty: DesiredLookLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DesiredLookLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12236);

    /// <summary>
    /// ObjectProperty: DesiredLookActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor DesiredLookActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 12248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12248); }
    }

    /// <summary>
    /// StructProperty: ZoomOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12252);

    /// <summary>
    /// StructProperty: ZoomCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12264);

    /// <summary>
    /// StructProperty: CeilingZoomOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CeilingZoomOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12276);

    /// <summary>
    /// StructProperty: CeilingCameraZoomOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CeilingCameraZoomOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12288);

    /// <summary>
    /// FloatProperty: ZoomFocusSpeed
    /// </summary>
    public unsafe float ZoomFocusSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12300); }
    }

    /// <summary>
    /// FloatProperty: MaxZoomFocusDistance
    /// </summary>
    public unsafe float MaxZoomFocusDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12304); }
    }

    /// <summary>
    /// ArrayProperty: CameraHiddenActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> CameraHiddenActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 12308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12308); }
    }

    /// <summary>
    /// ArrayProperty: CameraHideClasses
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> CameraHideClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 12320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12320); }
    }

    /// <summary>
    /// NameProperty: RunOverlayName
    /// </summary>
    public unsafe BmSDK.FName RunOverlayName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 12332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12332); }
    }

    /// <summary>
    /// FloatProperty: RunOverlayStrength
    /// </summary>
    public unsafe float RunOverlayStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12340); }
    }

    /// <summary>
    /// FloatProperty: RunOverlayZeroFrame
    /// </summary>
    public unsafe float RunOverlayZeroFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12344); }
    }

    /// <summary>
    /// FloatProperty: HelicopterCameraFOVAngle
    /// </summary>
    public unsafe float HelicopterCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12348); }
    }

    /// <summary>
    /// ObjectProperty: InterpBase
    /// </summary>
    public unsafe BmSDK.Engine.Actor InterpBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 12352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12352); }
    }

    /// <summary>
    /// FloatProperty: ResonatorPPFactor
    /// </summary>
    public unsafe float ResonatorPPFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12356); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_HighlightsMod
    /// </summary>
    public unsafe float ResonatorScreenScene_HighlightsMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12360); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_MidTonesMod
    /// </summary>
    public unsafe float ResonatorScreenScene_MidTonesMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12364); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_ShadowsMod
    /// </summary>
    public unsafe float ResonatorScreenScene_ShadowsMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12368); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFNear
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFNear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12372); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFFar
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12376); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFFalloff
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12380); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFRadius
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12384); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFDistance
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12388); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: CameraSmoothingBuffer
    /// </summary>
    public InlineArray<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime> CameraSmoothingBuffer => new(10, Ptr + 12392, 16, this);

    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12392);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12408);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12424);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12440);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12456);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12472);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12488);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12504);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12520);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12536);

    /// <summary>
    /// IntProperty: CameraSmoothingCount
    /// </summary>
    public unsafe int CameraSmoothingCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12552); }
    }

    /// <summary>
    /// FloatProperty: SmoothingConfigMaxVelocity
    /// </summary>
    public unsafe float SmoothingConfigMaxVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12556); }
    }

    /// <summary>
    /// FloatProperty: SmoothingConfigStrength
    /// </summary>
    public unsafe float SmoothingConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12560); }
    }

    /// <summary>
    /// FloatProperty: SmoothingConfigMaxAccel
    /// </summary>
    public unsafe float SmoothingConfigMaxAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12564); }
    }

    /// <summary>
    /// FloatProperty: CurrentSmoothingConfigStrength
    /// </summary>
    public unsafe float CurrentSmoothingConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12568); }
    }

    /// <summary>
    /// FloatProperty: OverworldRunningConfigStrength
    /// </summary>
    public unsafe float OverworldRunningConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12572); }
    }

    /// <summary>
    /// FloatProperty: NormalConfigStrength
    /// </summary>
    public unsafe float NormalConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12576); }
    }

    /// <summary>
    /// StructProperty: ChasePosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChasePosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12580);

    /// <summary>
    /// StructProperty: ChaseVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChaseVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12592);

    /// <summary>
    /// FloatProperty: LastCameraMoveTime
    /// </summary>
    public unsafe float LastCameraMoveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12604); }
    }

    /// <summary>
    /// FloatProperty: PelvisFollowZ
    /// </summary>
    public unsafe float PelvisFollowZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12608); }
    }

    /// <summary>
    /// FloatProperty: PelvisFollowXY
    /// </summary>
    public unsafe float PelvisFollowXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12612); }
    }

    /// <summary>
    /// FloatProperty: PelvisSway
    /// </summary>
    public unsafe float PelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12616); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: ZoomPoints
    /// </summary>
    public InlineArray<float> ZoomPoints => new(9, Ptr + 12620, 4, this);

    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12620); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12624); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12628); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12632); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12636); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12640); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12644); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12648); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12652); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ZoomPointDir
    /// </summary>
    public InlineArray<System.Numerics.Vector3> ZoomPointDir => new(9, Ptr + 12656, 12, this);

    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12656);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12668);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12680);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12692);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12704);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12716);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12728);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12740);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12752);

    /// <summary>
    /// InlineArray{StructProperty}: TightZoomPointDir
    /// </summary>
    public InlineArray<System.Numerics.Vector3> TightZoomPointDir => new(9, Ptr + 12764, 12, this);

    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12764);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12776);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12788);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12800);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12812);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12824);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12836);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12848);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12860);

    /// <summary>
    /// FloatProperty: ZoomPointAngle
    /// </summary>
    public unsafe float ZoomPointAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12872); }
    }

    /// <summary>
    /// FloatProperty: TightZoomPointAngle
    /// </summary>
    public unsafe float TightZoomPointAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12876); }
    }

    /// <summary>
    /// StructProperty: Smoother
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraSmoother Smoother
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraSmoother>(Ptr + 12880);

    /// <summary>
    /// FloatProperty: RunStatePelvisXY
    /// </summary>
    public unsafe float RunStatePelvisXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12908); }
    }

    /// <summary>
    /// FloatProperty: RunStatePelvisZ
    /// </summary>
    public unsafe float RunStatePelvisZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12912); }
    }

    /// <summary>
    /// FloatProperty: RunStatePelvisSway
    /// </summary>
    public unsafe float RunStatePelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12916); }
    }

    /// <summary>
    /// FloatProperty: DefaultPelvisFollowZ
    /// </summary>
    public unsafe float DefaultPelvisFollowZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12920); }
    }

    /// <summary>
    /// FloatProperty: DefaultPelvisFollowXY
    /// </summary>
    public unsafe float DefaultPelvisFollowXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12924); }
    }

    /// <summary>
    /// FloatProperty: DefaultPelvisSway
    /// </summary>
    public unsafe float DefaultPelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12928); }
    }

    /// <summary>
    /// FloatProperty: LastCollisionDistSqr
    /// </summary>
    public unsafe float LastCollisionDistSqr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12932); }
    }

    /// <summary>
    /// FloatProperty: MaxCollisionDist
    /// </summary>
    public unsafe float MaxCollisionDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12936); }
    }

    /// <summary>
    /// StructProperty: CustomCameraConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CustomCameraConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 12940);

    /// <summary>
    /// StructProperty: CustomCameraExtraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CustomCameraExtraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 13064);

    /// <summary>
    /// FloatProperty: CustomCameraFOV
    /// </summary>
    public unsafe float CustomCameraFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13076); }
    }

    /// <summary>
    /// FloatProperty: CustomCameraZoomFOV
    /// </summary>
    public unsafe float CustomCameraZoomFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13080); }
    }

    /// <summary>
    /// StructProperty: CustomCameraRotationSpeed
    /// </summary>
    public unsafe ref BmSDK.Rotator CustomCameraRotationSpeed
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 13084);

    /// <summary>
    /// FloatProperty: CustomCameraTransitionTime
    /// </summary>
    public unsafe float CustomCameraTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13096); }
    }

    /// <summary>
    /// StructProperty: DefaultRotationSpeed
    /// </summary>
    public unsafe ref BmSDK.Rotator DefaultRotationSpeed
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 13100);

    /// <summary>
    /// ObjectProperty: ViewPP
    /// </summary>
    public unsafe BmSDK.BmGame.RRCBatarangViewPostProcess ViewPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRCBatarangViewPostProcess>(Ptr + 13112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13112); }
    }

    /// <summary>
    /// FloatProperty: BatarangOutOfRangeFXStrength
    /// </summary>
    public unsafe float BatarangOutOfRangeFXStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13116); }
    }

    /// <summary>
    /// ObjectProperty: OverlayPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RCameraOverlayPlayer OverlayPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCameraOverlayPlayer>(Ptr + 13120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13120); }
    }

    /// <summary>
    /// FloatProperty: PitchDragSpeed
    /// </summary>
    public unsafe float PitchDragSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13124); }
    }

    /// <summary>
    /// FloatProperty: DefaultPitchDragSpeed
    /// </summary>
    public unsafe float DefaultPitchDragSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13128); }
    }

    /// <summary>
    /// FloatProperty: FallingPitchDragSpeed
    /// </summary>
    public unsafe float FallingPitchDragSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13132); }
    }

    /// <summary>
    /// IntProperty: CurrentLoopyRollRotator
    /// </summary>
    public unsafe int CurrentLoopyRollRotator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13136); }
    }

    /// <summary>
    /// IntProperty: TotalLoopyRollRotator
    /// </summary>
    public unsafe int TotalLoopyRollRotator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13140); }
    }

    /// <summary>
    /// IntProperty: RemainingLoopyRollRotator
    /// </summary>
    public unsafe int RemainingLoopyRollRotator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13144); }
    }

    /// <summary>
    /// FloatProperty: LoopyTime
    /// </summary>
    public unsafe float LoopyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13148); }
    }

    /// <summary>
    /// Struct: FFreeCameraConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 124)]
    public partial record struct FFreeCameraConfig
    {
        /// <summary>
        /// StructProperty: StateFreeCameraSitOffsetMin
        /// </summary>
        public unsafe System.Numerics.Vector3 StateFreeCameraSitOffsetMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: StateFreeCameraSitOffsetMax
        /// </summary>
        public unsafe System.Numerics.Vector3 StateFreeCameraSitOffsetMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: StateFreeCameraPullOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 StateFreeCameraPullOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: CameraPivotOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 CameraPivotOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: ZoomedOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 ZoomedOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: maxPitch
        /// </summary>
        public unsafe float maxPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: MinPitch
        /// </summary>
        public unsafe float MinPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: MinFreeCameraDistance
        /// </summary>
        public unsafe float MinFreeCameraDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// FloatProperty: MaxFreeCameraDistance
        /// </summary>
        public unsafe float MaxFreeCameraDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: ShortCamSpringConst
        /// </summary>
        public unsafe float ShortCamSpringConst
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// FloatProperty: LongCamSpringConst
        /// </summary>
        public unsafe float LongCamSpringConst
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: DefaultCameraPitch
        /// </summary>
        public unsafe float DefaultCameraPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// FloatProperty: CameraSitOffsetPower
        /// </summary>
        public unsafe float CameraSitOffsetPower
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// BoolProperty: bUseSeparate43Settings
        /// </summary>
        public unsafe bool bUseSeparate43Settings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }; }
        }

        /// <summary>
        /// StructProperty: StateFreeCamera43SitOffsetMax
        /// </summary>
        public unsafe System.Numerics.Vector3 StateFreeCamera43SitOffsetMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// StructProperty: StateFreeCamera43SitOffsetMin
        /// </summary>
        public unsafe System.Numerics.Vector3 StateFreeCamera43SitOffsetMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }

        /// <summary>
        /// BoolProperty: bDontModifySitOffsetWhenLookingUp
        /// </summary>
        public unsafe bool bDontModifySitOffsetWhenLookingUp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }; }
        }
    }
}
