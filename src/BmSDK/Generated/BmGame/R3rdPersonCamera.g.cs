#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: R3rdPersonCamera<br/>
/// (size = 14868)
/// (flags = 144703646)
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

    /// <summary>
    /// Function: UpdateCameraPosition
    /// </summary>
    public unsafe virtual void UpdateCameraPosition(float DeltaTime, bool ProperReset = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateCameraPosition", true);
        byte* paramsPtr = stackalloc byte[8];
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

    /// <summary>
    /// Function: GetYawAnchorRotation
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetYawAnchorRotation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.GetYawAnchorRotation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetTunnelCameraDirection
    /// </summary>
    public unsafe virtual void GetTunnelCameraDirection(out System.Numerics.Vector3 InDirection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.GetTunnelCameraDirection", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        InDirection = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: DisplayDebug
    /// </summary>
    public unsafe override void DisplayDebug(BmSDK.Engine.HUD HUD, out float out_YL, out float out_YPos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DisplayDebug", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HUD, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_YL = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        out_YPos = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: SetOverrideMotionBlur
    /// </summary>
    public unsafe virtual void SetOverrideMotionBlur(float NewMBAmount, float MBTransitionTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetOverrideMotionBlur", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMBAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MBTransitionTime, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetOverrideFOV
    /// </summary>
    public unsafe virtual void ResetOverrideFOV(float FOVTransitionTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ResetOverrideFOV", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOVTransitionTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetOverrideFOV
    /// </summary>
    public unsafe virtual void SetOverrideFOV(float NewFOV, float FOVTransitionTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetOverrideFOV", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFOV, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOVTransitionTime, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetTargetActor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetTargetActor()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.GetTargetActor", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UnlockCamera
    /// </summary>
    public unsafe virtual void UnlockCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UnlockCamera", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LockCamera
    /// </summary>
    public unsafe virtual void LockCamera(float LockedTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.LockCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LockedTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOffMotionBlur
    /// </summary>
    public unsafe virtual void TurnOffMotionBlur()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.TurnOffMotionBlur", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FillCameraCache
    /// </summary>
    public unsafe override void FillCameraCache(out BmSDK.GameObject.FTPOV NewPOV)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.FillCameraCache", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NewPOV = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FTPOV>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: HideClippingObjects
    /// </summary>
    public unsafe virtual void HideClippingObjects(out BmSDK.GameObject.FTPOV NewPOV)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.HideClippingObjects", true);
        byte* paramsPtr = stackalloc byte[28];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NewPOV = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FTPOV>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: UpdateZoomFocus
    /// </summary>
    public unsafe virtual void UpdateZoomFocus(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateZoomFocus", true);
        byte* paramsPtr = stackalloc byte[4];
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

    /// <summary>
    /// Function: SetViewTarget
    /// </summary>
    public unsafe override void SetViewTarget(BmSDK.Engine.Actor NewViewTarget, BmSDK.Engine.Camera.FViewTargetTransitionParams TransitionParams = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetViewTarget", true);
        byte* paramsPtr = stackalloc byte[20];
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

    /// <summary>
    /// Function: BlendViewTargets
    /// </summary>
    public unsafe override BmSDK.GameObject.FTPOV BlendViewTargets(out BmSDK.Engine.Camera.FTViewTarget A, out BmSDK.Engine.Camera.FTViewTarget B, float Alpha)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.BlendViewTargets", true);
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 88);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        A = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Camera.FTViewTarget>(paramsPtr + 0);
        B = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Camera.FTViewTarget>(paramsPtr + 44);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FTPOV>(paramsPtr + 92);
    }

    /// <summary>
    /// Function: SetRasFOV
    /// </summary>
    public unsafe virtual void SetRasFOV(float NewFOV)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetRasFOV", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CancelBlockedZoom
    /// </summary>
    public unsafe virtual void CancelBlockedZoom()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.CancelBlockedZoom", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CancelAndBlockZoom
    /// </summary>
    public unsafe virtual void CancelAndBlockZoom(float T = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.CancelAndBlockZoom", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CancelZoom
    /// </summary>
    public unsafe virtual void CancelZoom()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.CancelZoom", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ForceZoomCamera
    /// </summary>
    public unsafe virtual void ForceZoomCamera(float OverrideZoomFOV = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ForceZoomCamera", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideZoomFOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ToggleCameraZoom
    /// </summary>
    public unsafe virtual void ToggleCameraZoom()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ToggleCameraZoom", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ToggleAlternativeWalkCamera
    /// </summary>
    public unsafe virtual void ToggleAlternativeWalkCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ToggleAlternativeWalkCamera", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SettingsChanged
    /// </summary>
    public unsafe virtual void SettingsChanged()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SettingsChanged", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraZoomOut
    /// </summary>
    public unsafe virtual void DebugCameraZoomOut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraZoomOut", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraZoomIn
    /// </summary>
    public unsafe virtual void DebugCameraZoomIn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraZoomIn", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraBack
    /// </summary>
    public unsafe virtual void DebugCameraBack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraBack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraForward
    /// </summary>
    public unsafe virtual void DebugCameraForward()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraForward", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraRight
    /// </summary>
    public unsafe virtual void DebugCameraRight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraRight", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraLeft
    /// </summary>
    public unsafe virtual void DebugCameraLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraLeft", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraUp
    /// </summary>
    public unsafe virtual void DebugCameraUp()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraUp", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraDown
    /// </summary>
    public unsafe virtual void DebugCameraDown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraDown", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetToPlayerCam
    /// </summary>
    public unsafe virtual void ResetToPlayerCam()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ResetToPlayerCam", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CombatEnableCameraDrag
    /// </summary>
    public unsafe virtual void CombatEnableCameraDrag()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.CombatEnableCameraDrag", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CombatDisableCameraDrag
    /// </summary>
    public unsafe virtual void CombatDisableCameraDrag(float Time = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.CombatDisableCameraDrag", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableCameraDragHardReset
    /// </summary>
    public unsafe virtual void EnableCameraDragHardReset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.EnableCameraDragHardReset", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableCameraDragHardReset
    /// </summary>
    public unsafe virtual void DisableCameraDragHardReset(float Time = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DisableCameraDragHardReset", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableCameraDrag
    /// </summary>
    public unsafe virtual void EnableCameraDrag()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.EnableCameraDrag", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableCameraDrag
    /// </summary>
    public unsafe virtual void DisableCameraDrag(float Time = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DisableCameraDrag", true);
        byte* paramsPtr = stackalloc byte[4];
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

    /// <summary>
    /// Function: EnableCameraCollision
    /// </summary>
    public unsafe virtual void EnableCameraCollision()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.EnableCameraCollision", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableCameraCollision
    /// </summary>
    public unsafe virtual void DisableCameraCollision(float DisableTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DisableCameraCollision", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisableTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideCamRefresh
    /// </summary>
    public unsafe virtual void HideCamRefresh()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.HideCamRefresh", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChangeDof
    /// </summary>
    public unsafe virtual void ChangeDof(BmSDK.BmGame.RDOFManager.FDofStruct newDof)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ChangeDof", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newDof, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetDof
    /// </summary>
    public unsafe virtual void ResetDof()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ResetDof", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ApplyCameraModifiers
    /// </summary>
    public unsafe override void ApplyCameraModifiers(float DeltaTime, out BmSDK.GameObject.FTPOV OutPOV)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ApplyCameraModifiers", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutPOV = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FTPOV>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: ApplyModifiers
    /// </summary>
    public unsafe virtual void ApplyModifiers(float DeltaTime, out BmSDK.GameObject.FTPOV OutPOV)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ApplyModifiers", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutPOV = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FTPOV>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe override void Reset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.Reset", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EndJumpCam
    /// </summary>
    public unsafe virtual void EndJumpCam()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.EndJumpCam", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetGlidingCameraSmoothingStrength
    /// </summary>
    public unsafe virtual float GetGlidingCameraSmoothingStrength(BmSDK.FName StateName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.GetGlidingCameraSmoothingStrength", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: LeaveTunnel
    /// </summary>
    public unsafe virtual void LeaveTunnel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.LeaveTunnel", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnterTunnel
    /// </summary>
    public unsafe virtual void EnterTunnel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.EnterTunnel", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ProcessOverLook
    /// </summary>
    public unsafe virtual void ProcessOverLook()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ProcessOverLook", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCombatDistModifier
    /// </summary>
    public unsafe virtual void SetCombatDistModifier(float NewDistModifier)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetCombatDistModifier", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDistModifier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCombatFOV
    /// </summary>
    public unsafe virtual void SetCombatFOV(float NewFOV)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetCombatFOV", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCombatCamera
    /// </summary>
    public unsafe virtual void SetCombatCamera(bool setFlag)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetCombatCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(setFlag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RevertCameraTarget
    /// </summary>
    public unsafe virtual void RevertCameraTarget(float BlendTime = default, bool bResetCam = default, bool BlendBatmanRelativePosition = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.RevertCameraTarget", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetCam, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendBatmanRelativePosition, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCameraTarget
    /// </summary>
    public unsafe virtual void SetCameraTarget(BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetCameraTarget", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BlendToCameraTarget
    /// </summary>
    public unsafe virtual void BlendToCameraTarget(BmSDK.Engine.Actor Target, float BlendTime, bool bResetCam = default, BmSDK.Rotator ResetRotation = default, bool BlendBatmanRelativePosition = default, bool LockOutgoing = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.BlendToCameraTarget", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetCam, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResetRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendBatmanRelativePosition, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LockOutgoing, paramsPtr + 28);
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
    /// Function: UpdateFreeCam
    /// </summary>
    public unsafe virtual void UpdateFreeCam(System.Numerics.Vector3 DesiredCameraPosition, BmSDK.Rotator DesiredCameraRotation, float DesiredCameraFOV, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateFreeCam", true);
        byte* paramsPtr = stackalloc byte[32];
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

    /// <summary>
    /// Function: TransitionInterpolate
    /// </summary>
    public unsafe virtual void TransitionInterpolate(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.TransitionInterpolate", true);
        byte* paramsPtr = stackalloc byte[4];
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

    /// <summary>
    /// Function: ResetCamera
    /// </summary>
    public unsafe virtual void ResetCamera(BmSDK.Rotator ResetRotation = default, bool bResetForBlend = default, bool bResetSmoother = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ResetCamera", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResetRotation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetForBlend, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetSmoother, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateViewTarget
    /// </summary>
    public unsafe override void UpdateViewTarget(out BmSDK.Engine.Camera.FTViewTarget OutVT, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateViewTarget", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutVT = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Camera.FTViewTarget>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: UpdateViewTargetCameraActor
    /// </summary>
    public unsafe virtual void UpdateViewTargetCameraActor(out BmSDK.Engine.Camera.FTViewTarget OutVT, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateViewTargetCameraActor", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutVT = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Camera.FTViewTarget>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: UpdateCurrentCamera
    /// </summary>
    public unsafe virtual void UpdateCurrentCamera(System.Numerics.Vector3 DesiredCameraPosition, BmSDK.Rotator DesiredCameraRotation, float DesiredCameraFOV, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateCurrentCamera", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraFOV, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ProcessViewRotation
    /// </summary>
    public unsafe override void ProcessViewRotation(float DeltaTime, out BmSDK.Rotator out_ViewRotation, out BmSDK.Rotator out_DeltaRot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ProcessViewRotation", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_ViewRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 4);
        out_DeltaRot = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 16);
        return;
    }

    /// <summary>
    /// Function: UpdateCamera
    /// </summary>
    public unsafe override void UpdateCamera(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FollowCameraRotation
    /// </summary>
    public unsafe virtual bool FollowCameraRotation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.FollowCameraRotation", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: LookAround
    /// </summary>
    public unsafe virtual void LookAround(float DeltaTime, BmSDK.Rotator LookInput)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.LookAround", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookInput, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitializeFor
    /// </summary>
    public unsafe override void InitializeFor(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.InitializeFor", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SaveFreeCameraConfig
    /// </summary>
    public unsafe virtual void SaveFreeCameraConfig(out BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig ConfigToSave)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SaveFreeCameraConfig", true);
        byte* paramsPtr = stackalloc byte[136];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ConfigToSave = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: SetFreeCameraConfig
    /// </summary>
    public unsafe virtual void SetFreeCameraConfig(BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig NewConfig)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetFreeCameraConfig", true);
        byte* paramsPtr = stackalloc byte[136];
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

    /// <summary>
    /// Function: StopCameraWander
    /// </summary>
    public unsafe virtual void StopCameraWander()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.StopCameraWander", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartCameraWander
    /// </summary>
    public unsafe virtual void StartCameraWander(BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings NewSettings)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.StartCameraWander", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSettings, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveAllCameraEmitters
    /// </summary>
    public unsafe virtual void RemoveAllCameraEmitters()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.RemoveAllCameraEmitters", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveCameraEmitter
    /// </summary>
    public unsafe virtual void RemoveCameraEmitter(BmSDK.BmGame.RBMCameraEmitter Emitter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.RemoveCameraEmitter", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Emitter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddCameraEmitter
    /// </summary>
    public unsafe virtual void AddCameraEmitter(BmSDK.BmGame.RBMCameraEmitter Emitter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.AddCameraEmitter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Emitter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopLookAt
    /// </summary>
    public unsafe virtual void StopLookAt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.StopLookAt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LookAtCommon
    /// </summary>
    public unsafe virtual bool LookAtCommon(BmSDK.BmGame.RGameInfo.CameraLookAtStrength Strength, bool FollowPitch, bool FollowYaw, float Duration, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed Speed, bool bUseOffset, bool bAllowZoom = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.LookAtCommon", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowPitch, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowYaw, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseOffset, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowZoom, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: LookAtPosition
    /// </summary>
    public unsafe virtual void LookAtPosition(System.Numerics.Vector3 LookLocation, BmSDK.BmGame.RGameInfo.CameraLookAtStrength Strength = default, bool FollowPitch = default, bool FollowYaw = default, float Duration = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed Speed = default, bool bUseOffset = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.LookAtPosition", true);
        byte* paramsPtr = stackalloc byte[36];
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

    /// <summary>
    /// Function: LookAtActor
    /// </summary>
    public unsafe virtual void LookAtActor(BmSDK.Engine.Actor LookActor, System.Numerics.Vector3 Offset = default, BmSDK.BmGame.RGameInfo.CameraLookAtStrength Strength = default, bool FollowPitch = default, bool FollowYaw = default, float Duration = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed Speed = default, bool bUseOffset = default, bool bAllowZoom = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.LookAtActor", true);
        byte* paramsPtr = stackalloc byte[44];
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

    /// <summary>
    /// Function: LookInDirection
    /// </summary>
    public unsafe virtual void LookInDirection(BmSDK.Rotator Direction, BmSDK.BmGame.RGameInfo.CameraLookAtStrength Strength = default, bool FollowPitch = default, bool FollowYaw = default, float Duration = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed Speed = default, bool bUseOffset = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.LookInDirection", true);
        byte* paramsPtr = stackalloc byte[36];
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

    /// <summary>
    /// Function: AllowZoomCamera
    /// </summary>
    public unsafe virtual bool AllowZoomCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.AllowZoomCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateBatarangOutOfRangeFX
    /// </summary>
    public unsafe virtual void UpdateBatarangOutOfRangeFX(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateBatarangOutOfRangeFX", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetBatarangOutOfRangeFX
    /// </summary>
    public unsafe virtual void SetBatarangOutOfRangeFX(float Strength)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetBatarangOutOfRangeFX", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddFakeCollisionNormal
    /// </summary>
    public unsafe virtual void AddFakeCollisionNormal(out System.Numerics.Vector3 CollisionNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.AddFakeCollisionNormal", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CollisionNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: CheckLocation
    /// </summary>
    public unsafe virtual void CheckLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.CheckLocation", true);
        byte* paramsPtr = stackalloc byte[0];
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
    /// Function: ResetSmoother
    /// </summary>
    public unsafe virtual void ResetSmoother()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ResetSmoother", true);
        byte* paramsPtr = stackalloc byte[0];
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
    /// Function: UpdateCameraWander
    /// </summary>
    public unsafe virtual void UpdateCameraWander(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateCameraWander", true);
        byte* paramsPtr = stackalloc byte[4];
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

    /// <summary>
    /// Function: SolveCollisionForNearestWall
    /// </summary>
    public unsafe bool SolveCollisionForNearestWall(System.Numerics.Vector3 SideCamTarget, float SideCamMaxDistance, float DistanceFromWall, bool bRotateClockwise, out System.Numerics.Vector3 IdealCamVector)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SolveCollisionForNearestWall", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideCamTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideCamMaxDistance, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistanceFromWall, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRotateClockwise, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        IdealCamVector = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: GetIdealSideCamRotationOld
    /// </summary>
    public unsafe virtual void GetIdealSideCamRotationOld(System.Numerics.Vector3 OpponentLoc, float SideCamMaxDistance, out BmSDK.Rotator out_Rotation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.GetIdealSideCamRotationOld", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OpponentLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideCamMaxDistance, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Rotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 16);
        return;
    }

    /// <summary>
    /// Function: GetIdealSideCamRotation
    /// </summary>
    public unsafe virtual bool GetIdealSideCamRotation(System.Numerics.Vector3 OpponentLoc, float SideCamMaxDistance, float SideCharPitchDeg, float BehindCharPitchDeg, float BehindEnemyPitchDeg, float DesiredRotationYawOffset, float DistanceFromWall, out BmSDK.Rotator out_Rotation, out float Out_YawOffset, out int Out_bHasCollided)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.GetIdealSideCamRotation", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OpponentLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideCamMaxDistance, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideCharPitchDeg, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehindCharPitchDeg, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehindEnemyPitchDeg, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredRotationYawOffset, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistanceFromWall, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Rotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 36);
        Out_YawOffset = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 48);
        Out_bHasCollided = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 52);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 56);
    }

    /// <summary>
    /// Function: WorldGeomCollidesAroundPawn
    /// </summary>
    public unsafe virtual bool WorldGeomCollidesAroundPawn(float Size)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.WorldGeomCollidesAroundPawn", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
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
    /// InlineArray{StructProperty}: FreeCameraStateConfigs
    /// </summary>
    public InlineArray<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig> FreeCameraStateConfigs => new(72, Ptr + 1276, 136, this);

    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 1276);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 1412);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 1548);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 1684);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 1820);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 1956);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 2092);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 2228);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 2364);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 2500);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 2636);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_11
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 2772);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_12
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 2908);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_13
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3044);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_14
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3180);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_15
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3316);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_16
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3452);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_17
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3588);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_18
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3724);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_19
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3860);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_20
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3996);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_21
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4132);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_22
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4268);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_23
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4404);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_24
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4540);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_25
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4676);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_26
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4812);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_27
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4948);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_28
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5084);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_29
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5220);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_30
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5356);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_31
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5492);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_32
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5628);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_33
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5764);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_34
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5900);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_35
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6036);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_36
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6172);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_37
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6308);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_38
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6444);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_39
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6580);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_40
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6716);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_41
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6852);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_42
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6988);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_43
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7124);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_44
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7260);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_45
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7396);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_46
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7532);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_47
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7668);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_48
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7804);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_49
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7940);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_50
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8076);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_51
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8212);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_52
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8348);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_53
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8484);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_54
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8620);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_55
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8756);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_56
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8892);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_57
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9028);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_58
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9164);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_59
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9300);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_60
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9436);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_61
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9572);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_62
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9708);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_63
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9844);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_64
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9980);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_65
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10116);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_66
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10252);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_67
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10388);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_68
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10524);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_69
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10660);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_70
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10796);
    /// <summary>
    /// StructProperty: FreeCameraStateConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreeCameraStateConfigs_71
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10932);

    /// <summary>
    /// InlineArray{StructProperty}: ExtraCollision
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnPlayer.FFakeWall> ExtraCollision => new(2, Ptr + 11068, 16, this);

    /// <summary>
    /// StructProperty: ExtraCollision
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FFakeWall ExtraCollision_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FFakeWall>(Ptr + 11068);
    /// <summary>
    /// StructProperty: ExtraCollision
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FFakeWall ExtraCollision_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FFakeWall>(Ptr + 11084);

    /// <summary>
    /// StructProperty: LastValidCornerLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastValidCornerLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11100);

    /// <summary>
    /// BoolProperty: bIsInSideCamera
    /// </summary>
    public unsafe bool bIsInSideCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bTurnSideCamClockwise
    /// </summary>
    public unsafe bool bTurnSideCamClockwise
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bSideCamInCollision
    /// </summary>
    public unsafe bool bSideCamInCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: CamIsOnRightSide
    /// </summary>
    public unsafe bool CamIsOnRightSide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreTransitionTime
    /// </summary>
    public unsafe bool bIgnoreTransitionTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bTurnedInTunnel
    /// </summary>
    public unsafe bool bTurnedInTunnel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bOverrideCameraFOV
    /// </summary>
    public unsafe bool bOverrideCameraFOV
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: LockInPlace
    /// </summary>
    public unsafe bool LockInPlace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bHidePlayer
    /// </summary>
    public unsafe bool bHidePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bInterpPos
    /// </summary>
    public unsafe bool bInterpPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bDisallowRoll
    /// </summary>
    public unsafe bool bDisallowRoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bAffectsControllerRotation
    /// </summary>
    public unsafe bool bAffectsControllerRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bTemporarilyDisableCameraDrag
    /// </summary>
    public unsafe bool bTemporarilyDisableCameraDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bStatePermanentlyDragsCamera
    /// </summary>
    public unsafe bool bStatePermanentlyDragsCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bStatePermanentlyDisablesCameraDrag
    /// </summary>
    public unsafe bool bStatePermanentlyDisablesCameraDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bUseTightFocusPoints
    /// </summary>
    public unsafe bool bUseTightFocusPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bDisableCameraSmoothing
    /// </summary>
    public unsafe bool bDisableCameraSmoothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bFollowPelvis
    /// </summary>
    public unsafe bool bFollowPelvis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bOnlyFollowPelvisZ
    /// </summary>
    public unsafe bool bOnlyFollowPelvisZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bDisableCameraCollision
    /// </summary>
    public unsafe bool bDisableCameraCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bSwayWithPelvis
    /// </summary>
    public unsafe bool bSwayWithPelvis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bDisableCamerCollisionDuringBlend
    /// </summary>
    public unsafe bool bDisableCamerCollisionDuringBlend
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bCameraDebug
    /// </summary>
    public unsafe bool bCameraDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bCameraDebugCollision
    /// </summary>
    public unsafe bool bCameraDebugCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bDebugPlayerPath
    /// </summary>
    public unsafe bool bDebugPlayerPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bDebugCameraSmoothing
    /// </summary>
    public unsafe bool bDebugCameraSmoothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bForce3rdPersonCamera
    /// </summary>
    public unsafe bool bForce3rdPersonCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bDontModifySitOffsetWhenLookingUp
    /// </summary>
    public unsafe bool bDontModifySitOffsetWhenLookingUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bUseAbsoluteHeadOffset
    /// </summary>
    public unsafe bool bUseAbsoluteHeadOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bActuallyUsingAbsoluteHeadRot
    /// </summary>
    public unsafe bool bActuallyUsingAbsoluteHeadRot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bInterpingHeadRot
    /// </summary>
    public unsafe bool bInterpingHeadRot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bAlternativeCam
    /// </summary>
    public unsafe bool bAlternativeCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11112); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11112); }
    }

    /// <summary>
    /// BoolProperty: bDontClipPlayer
    /// </summary>
    public unsafe bool bDontClipPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bCameraWandering
    /// </summary>
    public unsafe bool bCameraWandering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bCamOverrideDof
    /// </summary>
    public unsafe bool bCamOverrideDof
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bEnableMotionBlur
    /// </summary>
    public unsafe bool bEnableMotionBlur
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bForceZoom
    /// </summary>
    public unsafe bool bForceZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: CameraLocked
    /// </summary>
    public unsafe bool CameraLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: CameraBlendBatmanRelativePosition
    /// </summary>
    public unsafe bool CameraBlendBatmanRelativePosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bIsCombatCamera
    /// </summary>
    public unsafe bool bIsCombatCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bIsVenomCamera
    /// </summary>
    public unsafe bool bIsVenomCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: EnableCameraAssist
    /// </summary>
    public unsafe bool EnableCameraAssist
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bForceCameraDragOn
    /// </summary>
    public unsafe bool bForceCameraDragOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bCombatDisableCameraDrag
    /// </summary>
    public unsafe bool bCombatDisableCameraDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bOverrideTransitionIn
    /// </summary>
    public unsafe bool bOverrideTransitionIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: PawnHiddenByCamera
    /// </summary>
    public unsafe bool PawnHiddenByCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: LookAtUsesDefaultOffset
    /// </summary>
    public unsafe bool LookAtUsesDefaultOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: UsePitchForLookAt
    /// </summary>
    public unsafe bool UsePitchForLookAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: UseYawForLookAt
    /// </summary>
    public unsafe bool UseYawForLookAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bCeilingRetainOffsetDuringZoom
    /// </summary>
    public unsafe bool bCeilingRetainOffsetDuringZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: DontDrawClosePawns
    /// </summary>
    public unsafe bool DontDrawClosePawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bPauseAndPanCamera
    /// </summary>
    public unsafe bool bPauseAndPanCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bModifyPPForResonatorSreen
    /// </summary>
    public unsafe bool bModifyPPForResonatorSreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bUseFullSway
    /// </summary>
    public unsafe bool bUseFullSway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bRetainOffsetDuringZoom
    /// </summary>
    public unsafe bool bRetainOffsetDuringZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bUseHeadOffsetCheck
    /// </summary>
    public unsafe bool bUseHeadOffsetCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bOverrideCrouchHeadCheck
    /// </summary>
    public unsafe bool bOverrideCrouchHeadCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bBatmanFacesCamera
    /// </summary>
    public unsafe bool bBatmanFacesCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bCustomCameraZoomAllowed
    /// </summary>
    public unsafe bool bCustomCameraZoomAllowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bDontSaveConfig
    /// </summary>
    public unsafe bool bDontSaveConfig
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: Debug_TurnOffZoomDof
    /// </summary>
    public unsafe bool Debug_TurnOffZoomDof
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// BoolProperty: bForceFollowFullPelvisZ
    /// </summary>
    public unsafe bool bForceFollowFullPelvisZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11116); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 11116); }
    }

    /// <summary>
    /// FloatProperty: DeathstrokeCamYawTargetMin
    /// </summary>
    public unsafe float DeathstrokeCamYawTargetMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11120); }
    }

    /// <summary>
    /// FloatProperty: DeathstrokeCamYawTargetMax
    /// </summary>
    public unsafe float DeathstrokeCamYawTargetMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11124); }
    }

    /// <summary>
    /// FloatProperty: TurnYawSpeed
    /// </summary>
    public unsafe float TurnYawSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11128); }
    }

    /// <summary>
    /// StructProperty: CameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11132);

    /// <summary>
    /// FloatProperty: CameraFOVAngle
    /// </summary>
    public unsafe float CameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11144); }
    }

    /// <summary>
    /// FloatProperty: OverrideCameraFOVAngle
    /// </summary>
    public unsafe float OverrideCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11148); }
    }

    /// <summary>
    /// FloatProperty: OverrideCameraFOVTime
    /// </summary>
    public unsafe float OverrideCameraFOVTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11152); }
    }

    /// <summary>
    /// FloatProperty: OverrideCameraFOVTimer
    /// </summary>
    public unsafe float OverrideCameraFOVTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11156); }
    }

    /// <summary>
    /// FloatProperty: LastOverrideCameraFOVAngle
    /// </summary>
    public unsafe float LastOverrideCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11160); }
    }

    /// <summary>
    /// FloatProperty: CurrentOverrideCameraFOVAngle
    /// </summary>
    public unsafe float CurrentOverrideCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11164); }
    }

    /// <summary>
    /// FloatProperty: OverrideMotionBlurBlendTime
    /// </summary>
    public unsafe float OverrideMotionBlurBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11168); }
    }

    /// <summary>
    /// FloatProperty: OverrideMotionBlurAmount
    /// </summary>
    public unsafe float OverrideMotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11172); }
    }

    /// <summary>
    /// FloatProperty: OldMotionBlurBlendTime
    /// </summary>
    public unsafe float OldMotionBlurBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11176); }
    }

    /// <summary>
    /// FloatProperty: OldMotionBlurAmount
    /// </summary>
    public unsafe float OldMotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11180); }
    }

    /// <summary>
    /// FloatProperty: bOverrideMotionBlurSettings
    /// </summary>
    public unsafe float bOverrideMotionBlurSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11184); }
    }

    /// <summary>
    /// StructProperty: ExtraCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ExtraCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11188);

    /// <summary>
    /// StructProperty: DefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator DefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11200);

    /// <summary>
    /// StructProperty: CameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11212);

    /// <summary>
    /// StructProperty: HeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11224);

    /// <summary>
    /// FloatProperty: ExtraCameraZ
    /// </summary>
    public unsafe float ExtraCameraZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11236); }
    }

    /// <summary>
    /// StructProperty: CurrentHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11240);

    /// <summary>
    /// StructProperty: CurrentExtraCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CurrentExtraCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11252);

    /// <summary>
    /// FloatProperty: CurrentExtraCameraZ
    /// </summary>
    public unsafe float CurrentExtraCameraZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11264); }
    }

    /// <summary>
    /// ObjectProperty: DOFManager
    /// </summary>
    public unsafe BmSDK.BmGame.RDOFManager DOFManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDOFManager>(Ptr + 11268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11268); }
    }

    /// <summary>
    /// FloatProperty: TargetFOV
    /// </summary>
    public unsafe float TargetFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11272); }
    }

    /// <summary>
    /// ArrayProperty: CameraEmitters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCameraEmitter> CameraEmitters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCameraEmitter>>(Ptr + 11276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11276); }
    }

    /// <summary>
    /// StructProperty: CurrentCameraPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentCameraPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11288);

    /// <summary>
    /// StructProperty: CurrentCameraRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CurrentCameraRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11300);

    /// <summary>
    /// FloatProperty: CurrentCameraFOVAngle
    /// </summary>
    public unsafe float CurrentCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11312); }
    }

    /// <summary>
    /// StructProperty: CurrentCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11316);

    /// <summary>
    /// StructProperty: ActualCameraPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ActualCameraPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11328);

    /// <summary>
    /// StructProperty: ActualCameraRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator ActualCameraRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11340);

    /// <summary>
    /// StructProperty: LastVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11352);

    /// <summary>
    /// FloatProperty: TimeInCurrentState
    /// </summary>
    public unsafe float TimeInCurrentState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11364); }
    }

    /// <summary>
    /// FloatProperty: TransitionTime
    /// </summary>
    public unsafe float TransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11368); }
    }

    /// <summary>
    /// IntProperty: maxPitch
    /// </summary>
    public unsafe int maxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11372); }
    }

    /// <summary>
    /// IntProperty: MinPitch
    /// </summary>
    public unsafe int MinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11376); }
    }

    /// <summary>
    /// IntProperty: MaxYaw
    /// </summary>
    public unsafe int MaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11380); }
    }

    /// <summary>
    /// IntProperty: MinYaw
    /// </summary>
    public unsafe int MinYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11384); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxYaw
    /// </summary>
    public unsafe float CurrentMaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11388); }
    }

    /// <summary>
    /// FloatProperty: CurrentMinYaw
    /// </summary>
    public unsafe float CurrentMinYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11392); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxPitch
    /// </summary>
    public unsafe float CurrentMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11396); }
    }

    /// <summary>
    /// FloatProperty: CurrentMinPitch
    /// </summary>
    public unsafe float CurrentMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11400); }
    }

    /// <summary>
    /// StructProperty: RotationSpeed
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RotationSpeed
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11404);

    /// <summary>
    /// FloatProperty: YawAccel
    /// </summary>
    public unsafe float YawAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11416); }
    }

    /// <summary>
    /// FloatProperty: PitchAccel
    /// </summary>
    public unsafe float PitchAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11420); }
    }

    /// <summary>
    /// FloatProperty: YawDecel
    /// </summary>
    public unsafe float YawDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11424); }
    }

    /// <summary>
    /// FloatProperty: PitchDecel
    /// </summary>
    public unsafe float PitchDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11428); }
    }

    /// <summary>
    /// FloatProperty: CameraCeilingLimit
    /// </summary>
    public unsafe float CameraCeilingLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11432); }
    }

    /// <summary>
    /// FloatProperty: CameraFloorLimit
    /// </summary>
    public unsafe float CameraFloorLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11436); }
    }

    /// <summary>
    /// StructProperty: WalkStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WalkStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11440);

    /// <summary>
    /// FloatProperty: WalkStateCameraFOVAngle
    /// </summary>
    public unsafe float WalkStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11452); }
    }

    /// <summary>
    /// StructProperty: WalkStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator WalkStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11456);

    /// <summary>
    /// StructProperty: DialogueStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DialogueStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11468);

    /// <summary>
    /// FloatProperty: DialogueStateCameraFOVAngle
    /// </summary>
    public unsafe float DialogueStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11480); }
    }

    /// <summary>
    /// StructProperty: DialogueStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator DialogueStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11484);

    /// <summary>
    /// StructProperty: ForensicsScanStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ForensicsScanStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11496);

    /// <summary>
    /// FloatProperty: ForensicsScanStateCameraFOVAngle
    /// </summary>
    public unsafe float ForensicsScanStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11508); }
    }

    /// <summary>
    /// StructProperty: ForensicsScanStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ForensicsScanStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11512);

    /// <summary>
    /// StructProperty: UsingSpotlightStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 UsingSpotlightStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11524);

    /// <summary>
    /// FloatProperty: UsingSpotlightStateCameraFOVAngle
    /// </summary>
    public unsafe float UsingSpotlightStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11536); }
    }

    /// <summary>
    /// StructProperty: UsingSpotlightStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator UsingSpotlightStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11540);

    /// <summary>
    /// StructProperty: ForensicsFilterStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ForensicsFilterStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11552);

    /// <summary>
    /// FloatProperty: ForensicsFilterStateCameraFOVAngle
    /// </summary>
    public unsafe float ForensicsFilterStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11564); }
    }

    /// <summary>
    /// StructProperty: ForensicsFilterStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ForensicsFilterStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11568);

    /// <summary>
    /// StructProperty: RunStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RunStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11580);

    /// <summary>
    /// FloatProperty: RunStateCameraFOVAngle
    /// </summary>
    public unsafe float RunStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11592); }
    }

    /// <summary>
    /// FloatProperty: BoostRunFOVAngle
    /// </summary>
    public unsafe float BoostRunFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11596); }
    }

    /// <summary>
    /// StructProperty: RunStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator RunStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11600);

    /// <summary>
    /// StructProperty: PairedAnimationStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PairedAnimationStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11612);

    /// <summary>
    /// FloatProperty: PairedAnimationStateCameraFOVAngle
    /// </summary>
    public unsafe float PairedAnimationStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11624); }
    }

    /// <summary>
    /// StructProperty: PairedAnimationStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator PairedAnimationStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11628);

    /// <summary>
    /// StructProperty: StealthStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StealthStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11640);

    /// <summary>
    /// FloatProperty: StealthStateCameraFOVAngle
    /// </summary>
    public unsafe float StealthStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11652); }
    }

    /// <summary>
    /// FloatProperty: OverworldStealthStateCameraFOVAngle
    /// </summary>
    public unsafe float OverworldStealthStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11656); }
    }

    /// <summary>
    /// StructProperty: StealthStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator StealthStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11660);

    /// <summary>
    /// StructProperty: TunnelStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TunnelStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11672);

    /// <summary>
    /// FloatProperty: TunnelStateCameraFOVAngle
    /// </summary>
    public unsafe float TunnelStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11684); }
    }

    /// <summary>
    /// StructProperty: TunnelStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator TunnelStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11688);

    /// <summary>
    /// StructProperty: TunnelStateCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TunnelStateCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11700);

    /// <summary>
    /// StructProperty: FallingStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FallingStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11712);

    /// <summary>
    /// FloatProperty: FallingStateCameraFOVAngle
    /// </summary>
    public unsafe float FallingStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11724); }
    }

    /// <summary>
    /// StructProperty: FallingDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator FallingDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11728);

    /// <summary>
    /// FloatProperty: FallingStateSwingSmoothingStrength
    /// </summary>
    public unsafe float FallingStateSwingSmoothingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11740); }
    }

    /// <summary>
    /// FloatProperty: FallingStateSwingTransitionTime
    /// </summary>
    public unsafe float FallingStateSwingTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11744); }
    }

    /// <summary>
    /// StructProperty: GrappleAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11748);

    /// <summary>
    /// FloatProperty: GrappleAimCameraFOVAngle
    /// </summary>
    public unsafe float GrappleAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11760); }
    }

    /// <summary>
    /// StructProperty: GrappleAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator GrappleAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11764);

    /// <summary>
    /// IntProperty: GrappleAimMaxPitch
    /// </summary>
    public unsafe int GrappleAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11776); }
    }

    /// <summary>
    /// IntProperty: GrappleAimMinPitch
    /// </summary>
    public unsafe int GrappleAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11780); }
    }

    /// <summary>
    /// StructProperty: HarpoonAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HarpoonAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11784);

    /// <summary>
    /// FloatProperty: HarpoonAimCameraFOVAngle
    /// </summary>
    public unsafe float HarpoonAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11796); }
    }

    /// <summary>
    /// StructProperty: HarpoonAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator HarpoonAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11800);

    /// <summary>
    /// IntProperty: HarpoonAimMaxPitch
    /// </summary>
    public unsafe int HarpoonAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11812); }
    }

    /// <summary>
    /// IntProperty: HarpoonAimMinPitch
    /// </summary>
    public unsafe int HarpoonAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11816); }
    }

    /// <summary>
    /// StructProperty: MagneticBlastAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MagneticBlastAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11820);

    /// <summary>
    /// FloatProperty: MagneticBlastAimCameraFOVAngle
    /// </summary>
    public unsafe float MagneticBlastAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11832); }
    }

    /// <summary>
    /// StructProperty: MagneticBlastAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator MagneticBlastAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11836);

    /// <summary>
    /// IntProperty: MagneticBlastAimMaxPitch
    /// </summary>
    public unsafe int MagneticBlastAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11848); }
    }

    /// <summary>
    /// IntProperty: MagneticBlastAimMinPitch
    /// </summary>
    public unsafe int MagneticBlastAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11852); }
    }

    /// <summary>
    /// StructProperty: FreezeJammerAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreezeJammerAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11856);

    /// <summary>
    /// FloatProperty: FreezeJammerAimCameraFOVAngle
    /// </summary>
    public unsafe float FreezeJammerAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11868); }
    }

    /// <summary>
    /// StructProperty: FreezeJammerAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator FreezeJammerAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11872);

    /// <summary>
    /// IntProperty: FreezeJammerAimMaxPitch
    /// </summary>
    public unsafe int FreezeJammerAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11884); }
    }

    /// <summary>
    /// IntProperty: FreezeJammerAimMinPitch
    /// </summary>
    public unsafe int FreezeJammerAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11888); }
    }

    /// <summary>
    /// StructProperty: JokerGunAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 JokerGunAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11892);

    /// <summary>
    /// FloatProperty: JokerGunAimCameraFOVAngle
    /// </summary>
    public unsafe float JokerGunAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11904); }
    }

    /// <summary>
    /// IntProperty: JokerGunAimMaxPitch
    /// </summary>
    public unsafe int JokerGunAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11908); }
    }

    /// <summary>
    /// IntProperty: JokerGunAimMinPitch
    /// </summary>
    public unsafe int JokerGunAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11912); }
    }

    /// <summary>
    /// StructProperty: LineLauncherAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LineLauncherAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11916);

    /// <summary>
    /// FloatProperty: LineLauncherAimCameraFOVAngle
    /// </summary>
    public unsafe float LineLauncherAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11928); }
    }

    /// <summary>
    /// StructProperty: LineLauncherAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator LineLauncherAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11932);

    /// <summary>
    /// IntProperty: LineLauncherAimMaxPitch
    /// </summary>
    public unsafe int LineLauncherAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11944); }
    }

    /// <summary>
    /// IntProperty: LineLauncherAimMinPitch
    /// </summary>
    public unsafe int LineLauncherAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11948); }
    }

    /// <summary>
    /// StructProperty: BatarangAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatarangAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11952);

    /// <summary>
    /// FloatProperty: BatarangAimCameraFOVAngle
    /// </summary>
    public unsafe float BatarangAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11964); }
    }

    /// <summary>
    /// StructProperty: BatarangAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator BatarangAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11968);

    /// <summary>
    /// IntProperty: BatarangAimMaxPitch
    /// </summary>
    public unsafe int BatarangAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11980); }
    }

    /// <summary>
    /// IntProperty: BatarangAimMinPitch
    /// </summary>
    public unsafe int BatarangAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11984); }
    }

    /// <summary>
    /// StructProperty: WallClimbStartCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallClimbStartCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11988);

    /// <summary>
    /// FloatProperty: WallClimbStartCameraFOVAngle
    /// </summary>
    public unsafe float WallClimbStartCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12000); }
    }

    /// <summary>
    /// StructProperty: WallClimbHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallClimbHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12004);

    /// <summary>
    /// StructProperty: PounceCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PounceCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12016);

    /// <summary>
    /// FloatProperty: PounceCameraFOVAngle
    /// </summary>
    public unsafe float PounceCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12028); }
    }

    /// <summary>
    /// StructProperty: PounceHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PounceHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12032);

    /// <summary>
    /// StructProperty: VantageClimbHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VantageClimbHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12044);

    /// <summary>
    /// FloatProperty: CorridorCombatStateCameraFOVAngle
    /// </summary>
    public unsafe float CorridorCombatStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12056); }
    }

    /// <summary>
    /// FloatProperty: HighCombatStateCameraFOVAngle
    /// </summary>
    public unsafe float HighCombatStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12060); }
    }

    /// <summary>
    /// StructProperty: LookStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LookStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12064);

    /// <summary>
    /// FloatProperty: LookStateCameraFOVAngle
    /// </summary>
    public unsafe float LookStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12076); }
    }

    /// <summary>
    /// StructProperty: LookStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator LookStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12080);

    /// <summary>
    /// IntProperty: LookStateMaxPitch
    /// </summary>
    public unsafe int LookStateMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12092); }
    }

    /// <summary>
    /// IntProperty: LookStateMinPitch
    /// </summary>
    public unsafe int LookStateMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12096); }
    }

    /// <summary>
    /// FloatProperty: LookModeScale
    /// </summary>
    public unsafe float LookModeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12100); }
    }

    /// <summary>
    /// FloatProperty: LookSpringBack
    /// </summary>
    public unsafe float LookSpringBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12104); }
    }

    /// <summary>
    /// FloatProperty: GrappleCameraFOVAngle
    /// </summary>
    public unsafe float GrappleCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12108); }
    }

    /// <summary>
    /// FloatProperty: ZoomStateCameraFOVAngle
    /// </summary>
    public unsafe float ZoomStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12112); }
    }

    /// <summary>
    /// StructProperty: CoverRightCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CoverRightCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12116);

    /// <summary>
    /// FloatProperty: CoverRightCameraFOVAngle
    /// </summary>
    public unsafe float CoverRightCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12128); }
    }

    /// <summary>
    /// StructProperty: CoverRightCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CoverRightCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12132);

    /// <summary>
    /// StructProperty: AlcoveCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AlcoveCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12144);

    /// <summary>
    /// FloatProperty: AlcoveCameraFOVAngle
    /// </summary>
    public unsafe float AlcoveCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12156); }
    }

    /// <summary>
    /// StructProperty: AlcoveCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator AlcoveCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12160);

    /// <summary>
    /// StructProperty: AlcoveCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AlcoveCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12172);

    /// <summary>
    /// StructProperty: GlidingCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GlidingCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12184);

    /// <summary>
    /// FloatProperty: GlidingCameraFOVAngle
    /// </summary>
    public unsafe float GlidingCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12196); }
    }

    /// <summary>
    /// FloatProperty: GlidingCameraExtraFOVAngle
    /// </summary>
    public unsafe float GlidingCameraExtraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12200); }
    }

    /// <summary>
    /// StructProperty: GlidingCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator GlidingCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12204);

    /// <summary>
    /// FloatProperty: GlideLagStrength
    /// </summary>
    public unsafe float GlideLagStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12216); }
    }

    /// <summary>
    /// FloatProperty: GlideLagBoostStrength
    /// </summary>
    public unsafe float GlideLagBoostStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12220); }
    }

    /// <summary>
    /// FloatProperty: GlideLagStrengthBlendTime
    /// </summary>
    public unsafe float GlideLagStrengthBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12224); }
    }

    /// <summary>
    /// FloatProperty: DiveCameraOrientationTime
    /// </summary>
    public unsafe float DiveCameraOrientationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12228); }
    }

    /// <summary>
    /// StructProperty: GlideKickOffWallHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GlideKickOffWallHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12232);

    /// <summary>
    /// StructProperty: BoostGlidingCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BoostGlidingCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12244);

    /// <summary>
    /// FloatProperty: BoostGlidingCameraFOVAngle
    /// </summary>
    public unsafe float BoostGlidingCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12256); }
    }

    /// <summary>
    /// StructProperty: BoostGlidingCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator BoostGlidingCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12260);

    /// <summary>
    /// StructProperty: PouncingCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PouncingCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12272);

    /// <summary>
    /// StructProperty: SilentPredCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SilentPredCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12284);

    /// <summary>
    /// StructProperty: SilentPredCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SilentPredCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12296);

    /// <summary>
    /// FloatProperty: SilentPredCameraFOVAngle
    /// </summary>
    public unsafe float SilentPredCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12308); }
    }

    /// <summary>
    /// StructProperty: SilentPredDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator SilentPredDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12312);

    /// <summary>
    /// StructProperty: HangCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HangCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12324);

    /// <summary>
    /// FloatProperty: HangCameraFOVAngle
    /// </summary>
    public unsafe float HangCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12336); }
    }

    /// <summary>
    /// StructProperty: HangDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator HangDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12340);

    /// <summary>
    /// FloatProperty: MinFreeCameraDistance
    /// </summary>
    public unsafe float MinFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12352); }
    }

    /// <summary>
    /// FloatProperty: MaxFreeCameraDistance
    /// </summary>
    public unsafe float MaxFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12356); }
    }

    /// <summary>
    /// FloatProperty: ShortCamSpringConst
    /// </summary>
    public unsafe float ShortCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12360); }
    }

    /// <summary>
    /// FloatProperty: LongCamSpringConst
    /// </summary>
    public unsafe float LongCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12364); }
    }

    /// <summary>
    /// StructProperty: LastLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12368);

    /// <summary>
    /// FloatProperty: CurrentShortCamSpringConst
    /// </summary>
    public unsafe float CurrentShortCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12380); }
    }

    /// <summary>
    /// FloatProperty: CurrentLongCamSpringConst
    /// </summary>
    public unsafe float CurrentLongCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12384); }
    }

    /// <summary>
    /// StructProperty: CameraPivotOffsetDef
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraPivotOffsetDef
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12388);

    /// <summary>
    /// IntProperty: MaxFreeCameraPitch
    /// </summary>
    public unsafe int MaxFreeCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12400); }
    }

    /// <summary>
    /// IntProperty: MinFreeCameraPitch
    /// </summary>
    public unsafe int MinFreeCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12404); }
    }

    /// <summary>
    /// FloatProperty: ZoomSensitivityMod
    /// </summary>
    public unsafe float ZoomSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12408); }
    }

    /// <summary>
    /// FloatProperty: LookSensitivityMod
    /// </summary>
    public unsafe float LookSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12412); }
    }

    /// <summary>
    /// FloatProperty: HarpoonSensitivityMod
    /// </summary>
    public unsafe float HarpoonSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12416); }
    }

    /// <summary>
    /// FloatProperty: JokerGunSensitivityMod
    /// </summary>
    public unsafe float JokerGunSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12420); }
    }

    /// <summary>
    /// StructProperty: BaseCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BaseCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12424);

    /// <summary>
    /// StructProperty: ExtraCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ExtraCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12436);

    /// <summary>
    /// StructProperty: FreeCamBobLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCamBobLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12448);

    /// <summary>
    /// StructProperty: LastDesiredCamPositionForDrag
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastDesiredCamPositionForDrag
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12460);

    /// <summary>
    /// StructProperty: ZipLineCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZipLineCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12472);

    /// <summary>
    /// FloatProperty: ZipLineCameraFOVAngle
    /// </summary>
    public unsafe float ZipLineCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12484); }
    }

    /// <summary>
    /// StructProperty: ZipLineDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ZipLineDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12488);

    /// <summary>
    /// StructProperty: ZipLineTargetOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZipLineTargetOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12500);

    /// <summary>
    /// StructProperty: HarpoonPullCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HarpoonPullCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12512);

    /// <summary>
    /// FloatProperty: HarpoonPullCameraFOVAngle
    /// </summary>
    public unsafe float HarpoonPullCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12524); }
    }

    /// <summary>
    /// StructProperty: HarpoonPullDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator HarpoonPullDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12528);

    /// <summary>
    /// StructProperty: HarpoonPullTargetOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HarpoonPullTargetOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12540);

    /// <summary>
    /// StructProperty: FixedCameraHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FixedCameraHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12552);

    /// <summary>
    /// StructProperty: FreeCameraHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCameraHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12564);

    /// <summary>
    /// StructProperty: AlcoveCameraHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AlcoveCameraHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12576);

    /// <summary>
    /// StructProperty: SwingingFromAboveCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SwingingFromAboveCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12588);

    /// <summary>
    /// FloatProperty: SwingingFromAboveCameraFOVAngle
    /// </summary>
    public unsafe float SwingingFromAboveCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12600); }
    }

    /// <summary>
    /// StructProperty: SwingingFromAboveCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator SwingingFromAboveCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12604);

    /// <summary>
    /// FloatProperty: CeilingClimbCamFOVAngle
    /// </summary>
    public unsafe float CeilingClimbCamFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12616); }
    }

    /// <summary>
    /// StructProperty: CeilingClimbCamHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CeilingClimbCamHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12620);

    /// <summary>
    /// StructProperty: CeilingClimbCamRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CeilingClimbCamRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12632);

    /// <summary>
    /// StructProperty: BaneCombatStateFreeCameraSitOffsetMin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BaneCombatStateFreeCameraSitOffsetMin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12644);

    /// <summary>
    /// StructProperty: BaneCombatStateFreeCameraSitOffsetMax
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BaneCombatStateFreeCameraSitOffsetMax
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12656);

    /// <summary>
    /// FloatProperty: BaneCombatDefaultCameraPitch
    /// </summary>
    public unsafe float BaneCombatDefaultCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12668); }
    }

    /// <summary>
    /// FloatProperty: BaneCombatMaxPitch
    /// </summary>
    public unsafe float BaneCombatMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12672); }
    }

    /// <summary>
    /// FloatProperty: BaneCombatMinPitch
    /// </summary>
    public unsafe float BaneCombatMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12676); }
    }

    /// <summary>
    /// FloatProperty: ZoomFOV
    /// </summary>
    public unsafe float ZoomFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12680); }
    }

    /// <summary>
    /// FloatProperty: ZoomTime
    /// </summary>
    public unsafe float ZoomTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12684); }
    }

    /// <summary>
    /// FloatProperty: RaftPullFOVAngle
    /// </summary>
    public unsafe float RaftPullFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12688); }
    }

    /// <summary>
    /// IntProperty: ForcedPitch
    /// </summary>
    public unsafe int ForcedPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12692); }
    }

    /// <summary>
    /// StructProperty: TransitionOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TransitionOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12696);

    /// <summary>
    /// StructProperty: TransitionRotatorOffset
    /// </summary>
    public unsafe ref BmSDK.Rotator TransitionRotatorOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12708);

    /// <summary>
    /// FloatProperty: TransitionFOV
    /// </summary>
    public unsafe float TransitionFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12720); }
    }

    /// <summary>
    /// FloatProperty: CurrentMinFreeCameraDistance
    /// </summary>
    public unsafe float CurrentMinFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12724); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxFreeCameraDistance
    /// </summary>
    public unsafe float CurrentMaxFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12728); }
    }

    /// <summary>
    /// ObjectProperty: ScreenShakeModifier
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier ScreenShakeModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier>(Ptr + 12732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12732); }
    }

    /// <summary>
    /// StructProperty: GrateCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrateCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12736);

    /// <summary>
    /// StructProperty: LastCameraTargetPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastCameraTargetPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12748);

    /// <summary>
    /// StructProperty: FreeCameraSitOffsetMin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCameraSitOffsetMin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12760);

    /// <summary>
    /// StructProperty: FreeCameraSitOffsetMax
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCameraSitOffsetMax
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12772);

    /// <summary>
    /// StructProperty: FreeCameraPullOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCameraPullOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12784);

    /// <summary>
    /// FloatProperty: CurrentSitOffsetPower
    /// </summary>
    public unsafe float CurrentSitOffsetPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12796); }
    }

    /// <summary>
    /// StructProperty: StateFreeCameraSitOffsetMin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StateFreeCameraSitOffsetMin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12800);

    /// <summary>
    /// StructProperty: StateFreeCameraSitOffsetMax
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StateFreeCameraSitOffsetMax
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12812);

    /// <summary>
    /// StructProperty: StateFreeCameraPullOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StateFreeCameraPullOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12824);

    /// <summary>
    /// FloatProperty: StateSitOffsetPower
    /// </summary>
    public unsafe float StateSitOffsetPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12836); }
    }

    /// <summary>
    /// FloatProperty: StateDefaultCameraPitch
    /// </summary>
    public unsafe float StateDefaultCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12840); }
    }

    /// <summary>
    /// FloatProperty: CurrentDefaultCameraPitch
    /// </summary>
    public unsafe float CurrentDefaultCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12844); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraFollowPelvisXY
    /// </summary>
    public unsafe float CurrentCameraFollowPelvisXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12848); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraFollowPelvisZ
    /// </summary>
    public unsafe float CurrentCameraFollowPelvisZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12852); }
    }

    /// <summary>
    /// FloatProperty: CurrentPelvisSway
    /// </summary>
    public unsafe float CurrentPelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12856); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12860);

    /// <summary>
    /// FloatProperty: EdgeSwingCameraFOVAngle
    /// </summary>
    public unsafe float EdgeSwingCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12872); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator EdgeSwingCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12876);

    /// <summary>
    /// StructProperty: CurrentAbsoluteHeadRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CurrentAbsoluteHeadRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12888);

    /// <summary>
    /// StructProperty: LastAnchorRot
    /// </summary>
    public unsafe ref BmSDK.Rotator LastAnchorRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12900);

    /// <summary>
    /// StructProperty: BaseZoomDOFSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.RDOFManager.FDofStruct BaseZoomDOFSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RDOFManager.FDofStruct>(Ptr + 12912);

    /// <summary>
    /// FloatProperty: MinZoomFarBlur
    /// </summary>
    public unsafe float MinZoomFarBlur
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12976); }
    }

    /// <summary>
    /// StructProperty: ZoomedDOFSetting
    /// </summary>
    public unsafe ref BmSDK.BmGame.RDOFManager.FDofStruct ZoomedDOFSetting
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RDOFManager.FDofStruct>(Ptr + 12980);

    /// <summary>
    /// FloatProperty: VenomHenchmenCombatCameraFOVAngle
    /// </summary>
    public unsafe float VenomHenchmenCombatCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13044); }
    }

    /// <summary>
    /// FloatProperty: PenguinBeatdownFOVAngle
    /// </summary>
    public unsafe float PenguinBeatdownFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13048); }
    }

    /// <summary>
    /// FloatProperty: LookDownVantageCamFOVAngle
    /// </summary>
    public unsafe float LookDownVantageCamFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13052); }
    }

    /// <summary>
    /// StructProperty: LookDownDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator LookDownDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 13056);

    /// <summary>
    /// FloatProperty: AlternativeWalkCamFOV
    /// </summary>
    public unsafe float AlternativeWalkCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13068); }
    }

    /// <summary>
    /// FloatProperty: SlideStateCameraFOVAngle
    /// </summary>
    public unsafe float SlideStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13072); }
    }

    /// <summary>
    /// StructProperty: DiveOverRailingPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DiveOverRailingPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13076);

    /// <summary>
    /// FloatProperty: DiveOverRailingPitch
    /// </summary>
    public unsafe float DiveOverRailingPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13088); }
    }

    /// <summary>
    /// FloatProperty: CameraWanderTimer
    /// </summary>
    public unsafe float CameraWanderTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13092); }
    }

    /// <summary>
    /// StructProperty: CameraWander
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraWander
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13096);

    /// <summary>
    /// StructProperty: CameraWanderRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CameraWanderRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 13108);

    /// <summary>
    /// FloatProperty: CameraWanderFOV
    /// </summary>
    public unsafe float CameraWanderFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13120); }
    }

    /// <summary>
    /// StructProperty: CurrentCameraWanderSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings CurrentCameraWanderSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings>(Ptr + 13124);

    /// <summary>
    /// StructProperty: ResonatorWanderSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings ResonatorWanderSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings>(Ptr + 13192);

    /// <summary>
    /// StructProperty: ScarecrowWanderSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings ScarecrowWanderSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings>(Ptr + 13260);

    /// <summary>
    /// StructProperty: GlideWanderSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings GlideWanderSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings>(Ptr + 13328);

    /// <summary>
    /// StructProperty: GlideCameraShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct GlideCameraShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 13396);

    /// <summary>
    /// StructProperty: BoostGlideCameraShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct BoostGlideCameraShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 13540);

    /// <summary>
    /// IntProperty: GlideShakeId
    /// </summary>
    public unsafe int GlideShakeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13684); }
    }

    /// <summary>
    /// FloatProperty: Test
    /// </summary>
    public unsafe float Test
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13688); }
    }

    /// <summary>
    /// ObjectProperty: MotionBlurEffect
    /// </summary>
    public unsafe BmSDK.Engine.RockOn MotionBlurEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockOn>(Ptr + 13692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13692); }
    }

    /// <summary>
    /// ObjectProperty: UberEffect
    /// </summary>
    public unsafe BmSDK.Engine.RockOn UberEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockOn>(Ptr + 13696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13696); }
    }

    /// <summary>
    /// IntProperty: GrappleMaxPitch
    /// </summary>
    public unsafe int GrappleMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13700); }
    }

    /// <summary>
    /// StructProperty: CameraBlendRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CameraBlendRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 13704);

    /// <summary>
    /// StructProperty: CameraBlendInitialRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CameraBlendInitialRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 13716);

    /// <summary>
    /// StructProperty: ExtraDeltaRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ExtraDeltaRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 13728);

    /// <summary>
    /// StructProperty: CornerStateOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CornerStateOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13740);

    /// <summary>
    /// FloatProperty: CornerStateFOVAngle
    /// </summary>
    public unsafe float CornerStateFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13752); }
    }

    /// <summary>
    /// StructProperty: CornerStateDefaultRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CornerStateDefaultRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 13756);

    /// <summary>
    /// StructProperty: CornerStateCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CornerStateCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13768);

    /// <summary>
    /// FloatProperty: ZoomedFOVAngle
    /// </summary>
    public unsafe float ZoomedFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13780); }
    }

    /// <summary>
    /// FloatProperty: ZoomProp
    /// </summary>
    public unsafe float ZoomProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13784); }
    }

    /// <summary>
    /// FloatProperty: ForceZoomFOVAngle
    /// </summary>
    public unsafe float ForceZoomFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13788); }
    }

    /// <summary>
    /// FloatProperty: MotionBlurAmount
    /// </summary>
    public unsafe float MotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13792); }
    }

    /// <summary>
    /// FloatProperty: MotionBlurBlendTime
    /// </summary>
    public unsafe float MotionBlurBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13796); }
    }

    /// <summary>
    /// FloatProperty: InitialMotionBlurAmount
    /// </summary>
    public unsafe float InitialMotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13800); }
    }

    /// <summary>
    /// FloatProperty: InitialMotionBlurMaxVelocity
    /// </summary>
    public unsafe float InitialMotionBlurMaxVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13804); }
    }

    /// <summary>
    /// FloatProperty: MinCameraMotionBlur
    /// </summary>
    public unsafe float MinCameraMotionBlur
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13808); }
    }

    /// <summary>
    /// StructProperty: ResonatorCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ResonatorCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13812);

    /// <summary>
    /// FloatProperty: ResonatorFOVAngle
    /// </summary>
    public unsafe float ResonatorFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13824); }
    }

    /// <summary>
    /// StructProperty: ResonatorCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ResonatorCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13828);

    /// <summary>
    /// StructProperty: LastCameraPivotPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastCameraPivotPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13840);

    /// <summary>
    /// FloatProperty: OverrideBloomValue
    /// </summary>
    public unsafe float OverrideBloomValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13852); }
    }

    /// <summary>
    /// FloatProperty: LoadedAspectRatio
    /// </summary>
    public unsafe float LoadedAspectRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13856); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraAssistStrength
    /// </summary>
    public unsafe float CurrentCameraAssistStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13860); }
    }

    /// <summary>
    /// FloatProperty: CameraAssistBuildUpTime
    /// </summary>
    public unsafe float CameraAssistBuildUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13864); }
    }

    /// <summary>
    /// StructProperty: CurrentDefaultPelvisDiff
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentDefaultPelvisDiff
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13868);

    /// <summary>
    /// StructProperty: DefaultPelvisDiff
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DefaultPelvisDiff
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13880);

    /// <summary>
    /// FloatProperty: LastStepUpOffset
    /// </summary>
    public unsafe float LastStepUpOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13892); }
    }

    /// <summary>
    /// ArrayProperty: RetainZoomStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> RetainZoomStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 13896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13896); }
    }

    /// <summary>
    /// ArrayProperty: ForceUnZoomStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ForceUnZoomStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 13908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13908); }
    }

    /// <summary>
    /// FloatProperty: OverrideTransitionInDuration
    /// </summary>
    public unsafe float OverrideTransitionInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13920); }
    }

    /// <summary>
    /// ArrayProperty: LookAtSpeeds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.R3rdPersonCamera.FCameraLookAtSpeedDescriptor> LookAtSpeeds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.R3rdPersonCamera.FCameraLookAtSpeedDescriptor>>(Ptr + 13924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13924); }
    }

    /// <summary>
    /// ByteProperty: LookAtSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtSpeed LookAtSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtSpeed>(Ptr + 13936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13936); }
    }

    /// <summary>
    /// ByteProperty: LookAtType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtType LookAtType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtType>(Ptr + 13937); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13937); }
    }

    /// <summary>
    /// ByteProperty: LookAtStrength
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtStrength LookAtStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtStrength>(Ptr + 13938); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13938); }
    }

    /// <summary>
    /// ByteProperty: CurrentZoomPoint
    /// </summary>
    public unsafe byte CurrentZoomPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 13939); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13939); }
    }

    /// <summary>
    /// StructProperty: DesiredLookRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator DesiredLookRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 13940);

    /// <summary>
    /// StructProperty: DesiredLookLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DesiredLookLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13952);

    /// <summary>
    /// ObjectProperty: DesiredLookActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor DesiredLookActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 13964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13964); }
    }

    /// <summary>
    /// StructProperty: ZoomOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13968);

    /// <summary>
    /// StructProperty: ZoomCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13980);

    /// <summary>
    /// StructProperty: CeilingZoomOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CeilingZoomOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13992);

    /// <summary>
    /// StructProperty: CeilingCameraZoomOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CeilingCameraZoomOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14004);

    /// <summary>
    /// FloatProperty: ZoomFocusSpeed
    /// </summary>
    public unsafe float ZoomFocusSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14016); }
    }

    /// <summary>
    /// FloatProperty: MaxZoomFocusDistance
    /// </summary>
    public unsafe float MaxZoomFocusDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14020); }
    }

    /// <summary>
    /// FloatProperty: mZoomStartTime
    /// </summary>
    public unsafe float mZoomStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14024); }
    }

    /// <summary>
    /// ArrayProperty: CameraHiddenActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> CameraHiddenActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 14028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14028); }
    }

    /// <summary>
    /// ArrayProperty: CameraHideClasses
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> CameraHideClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 14040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14040); }
    }

    /// <summary>
    /// NameProperty: RunOverlayName
    /// </summary>
    public unsafe BmSDK.FName RunOverlayName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 14052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14052); }
    }

    /// <summary>
    /// FloatProperty: RunOverlayStrength
    /// </summary>
    public unsafe float RunOverlayStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14060); }
    }

    /// <summary>
    /// FloatProperty: RunOverlayZeroFrame
    /// </summary>
    public unsafe float RunOverlayZeroFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14064); }
    }

    /// <summary>
    /// FloatProperty: HelicopterCameraFOVAngle
    /// </summary>
    public unsafe float HelicopterCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14068); }
    }

    /// <summary>
    /// ObjectProperty: InterpBase
    /// </summary>
    public unsafe BmSDK.Engine.Actor InterpBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 14072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14072); }
    }

    /// <summary>
    /// FloatProperty: ResonatorPPFactor
    /// </summary>
    public unsafe float ResonatorPPFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14076); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_HighlightsMod
    /// </summary>
    public unsafe float ResonatorScreenScene_HighlightsMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14080); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_MidTonesMod
    /// </summary>
    public unsafe float ResonatorScreenScene_MidTonesMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14084); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_ShadowsMod
    /// </summary>
    public unsafe float ResonatorScreenScene_ShadowsMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14088); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFNear
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFNear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14092); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFFar
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14096); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFFalloff
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14100); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFRadius
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14104); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFDistance
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14108); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: CameraSmoothingBuffer
    /// </summary>
    public InlineArray<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime> CameraSmoothingBuffer => new(10, Ptr + 14112, 16, this);

    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 14112);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 14128);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 14144);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 14160);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 14176);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 14192);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 14208);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 14224);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 14240);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 14256);

    /// <summary>
    /// IntProperty: CameraSmoothingCount
    /// </summary>
    public unsafe int CameraSmoothingCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 14272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14272); }
    }

    /// <summary>
    /// FloatProperty: SmoothingConfigMaxVelocity
    /// </summary>
    public unsafe float SmoothingConfigMaxVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14276); }
    }

    /// <summary>
    /// FloatProperty: SmoothingConfigStrength
    /// </summary>
    public unsafe float SmoothingConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14280); }
    }

    /// <summary>
    /// FloatProperty: SmoothingConfigMaxAccel
    /// </summary>
    public unsafe float SmoothingConfigMaxAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14284); }
    }

    /// <summary>
    /// FloatProperty: CurrentSmoothingConfigStrength
    /// </summary>
    public unsafe float CurrentSmoothingConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14288); }
    }

    /// <summary>
    /// FloatProperty: OverworldRunningConfigStrength
    /// </summary>
    public unsafe float OverworldRunningConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14292); }
    }

    /// <summary>
    /// FloatProperty: NormalConfigStrength
    /// </summary>
    public unsafe float NormalConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14296); }
    }

    /// <summary>
    /// StructProperty: ChasePosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChasePosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14300);

    /// <summary>
    /// StructProperty: ChaseVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChaseVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14312);

    /// <summary>
    /// FloatProperty: LastCameraMoveTime
    /// </summary>
    public unsafe float LastCameraMoveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14324); }
    }

    /// <summary>
    /// FloatProperty: PelvisFollowZ
    /// </summary>
    public unsafe float PelvisFollowZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14328); }
    }

    /// <summary>
    /// FloatProperty: PelvisFollowXY
    /// </summary>
    public unsafe float PelvisFollowXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14332); }
    }

    /// <summary>
    /// FloatProperty: PelvisSway
    /// </summary>
    public unsafe float PelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14336); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: ZoomPoints
    /// </summary>
    public InlineArray<float> ZoomPoints => new(9, Ptr + 14340, 4, this);

    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14340); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14344); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14348); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14352); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14356); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14360); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14364); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14368); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14372); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ZoomPointDir
    /// </summary>
    public InlineArray<System.Numerics.Vector3> ZoomPointDir => new(9, Ptr + 14376, 12, this);

    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14376);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14388);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14400);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14412);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14424);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14436);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14448);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14460);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14472);

    /// <summary>
    /// InlineArray{StructProperty}: TightZoomPointDir
    /// </summary>
    public InlineArray<System.Numerics.Vector3> TightZoomPointDir => new(9, Ptr + 14484, 12, this);

    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14484);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14496);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14508);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14520);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14532);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14544);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14556);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14568);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14580);

    /// <summary>
    /// FloatProperty: ZoomPointAngle
    /// </summary>
    public unsafe float ZoomPointAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14592); }
    }

    /// <summary>
    /// FloatProperty: TightZoomPointAngle
    /// </summary>
    public unsafe float TightZoomPointAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14596); }
    }

    /// <summary>
    /// StructProperty: Smoother
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraSmoother Smoother
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraSmoother>(Ptr + 14600);

    /// <summary>
    /// FloatProperty: RunStatePelvisXY
    /// </summary>
    public unsafe float RunStatePelvisXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14628); }
    }

    /// <summary>
    /// FloatProperty: RunStatePelvisZ
    /// </summary>
    public unsafe float RunStatePelvisZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14632); }
    }

    /// <summary>
    /// FloatProperty: RunStatePelvisSway
    /// </summary>
    public unsafe float RunStatePelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14636); }
    }

    /// <summary>
    /// FloatProperty: DefaultPelvisFollowZ
    /// </summary>
    public unsafe float DefaultPelvisFollowZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14640); }
    }

    /// <summary>
    /// FloatProperty: DefaultPelvisFollowXY
    /// </summary>
    public unsafe float DefaultPelvisFollowXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14644); }
    }

    /// <summary>
    /// FloatProperty: DefaultPelvisSway
    /// </summary>
    public unsafe float DefaultPelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14648); }
    }

    /// <summary>
    /// FloatProperty: LastCollisionDistSqr
    /// </summary>
    public unsafe float LastCollisionDistSqr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14652); }
    }

    /// <summary>
    /// FloatProperty: MaxCollisionDist
    /// </summary>
    public unsafe float MaxCollisionDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14656); }
    }

    /// <summary>
    /// StructProperty: CustomCameraConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CustomCameraConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 14660);

    /// <summary>
    /// StructProperty: CustomCameraExtraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CustomCameraExtraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 14796);

    /// <summary>
    /// FloatProperty: CustomCameraFOV
    /// </summary>
    public unsafe float CustomCameraFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14808); }
    }

    /// <summary>
    /// FloatProperty: CustomCameraZoomFOV
    /// </summary>
    public unsafe float CustomCameraZoomFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14812); }
    }

    /// <summary>
    /// StructProperty: CustomCameraRotationSpeed
    /// </summary>
    public unsafe ref BmSDK.Rotator CustomCameraRotationSpeed
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 14816);

    /// <summary>
    /// FloatProperty: CustomCameraTransitionTime
    /// </summary>
    public unsafe float CustomCameraTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14828); }
    }

    /// <summary>
    /// StructProperty: DefaultRotationSpeed
    /// </summary>
    public unsafe ref BmSDK.Rotator DefaultRotationSpeed
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 14832);

    /// <summary>
    /// ObjectProperty: ViewPP
    /// </summary>
    public unsafe BmSDK.BmGame.RRCBatarangViewPostProcess ViewPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRCBatarangViewPostProcess>(Ptr + 14844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14844); }
    }

    /// <summary>
    /// FloatProperty: BatarangOutOfRangeFXStrength
    /// </summary>
    public unsafe float BatarangOutOfRangeFXStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14848); }
    }

    /// <summary>
    /// ObjectProperty: OverlayPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RCameraOverlayPlayer OverlayPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCameraOverlayPlayer>(Ptr + 14852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14852); }
    }

    /// <summary>
    /// FloatProperty: PitchDragSpeed
    /// </summary>
    public unsafe float PitchDragSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14856); }
    }

    /// <summary>
    /// FloatProperty: DefaultPitchDragSpeed
    /// </summary>
    public unsafe float DefaultPitchDragSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14860); }
    }

    /// <summary>
    /// FloatProperty: FallingPitchDragSpeed
    /// </summary>
    public unsafe float FallingPitchDragSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14864); }
    }

    /// <summary>
    /// Enum: EFreeCameraStateConfig
    /// </summary>
    public enum EFreeCameraStateConfig : byte
    {
        EFCSC_AlternativeWalk = 0,
        EFCSC_Walk = 1,
        EFCSC_AgilityWalk = 2,
        EFCSC_Run = 3,
        EFCSC_RooftopRun = 4,
        EFCSC_DemonTrials = 5,
        EFCSC_CombatWalk = 6,
        EFCSC_StandingHold = 7,
        EFCSC_StandingGrab = 8,
        EFCSC_Grapple = 9,
        EFCSC_GrappleRescue = 10,
        EFCSC_CapeChute = 11,
        EFCSC_LedgeHang = 12,
        EFCSC_LedgeHangKickedByThug = 13,
        EFCSC_LedgeHangTakedownStart = 14,
        EFCSC_LedgeHangTakedown = 15,
        EFCSC_QuickTakedown = 16,
        EFCSC_GenericFarFree = 17,
        EFCSC_RaftPull = 18,
        EFCSC_VantagePointSwing = 19,
        EFCSC_HangPoint = 20,
        EFCSC_Stealth = 21,
        EFCSC_StealthWall = 22,
        EFCSC_CrouchUnderObstacle = 23,
        EFCSC_Railing = 24,
        EFCSC_FloorAttack = 25,
        EFCSC_Intro = 26,
        EFCSC_Swinging = 27,
        EFCSC_WallClimb = 28,
        EFCSC_WallClimbStart = 29,
        EFCSC_Pounce = 30,
        EFCSC_VantageClimb = 31,
        EFCSC_SwingingFromAbove = 32,
        EFCSC_TakedownFromAbove = 33,
        EFCSC_SilentPredator = 34,
        EFCSC_CorridorCombat = 35,
        EFCSC_HighCombat = 36,
        EFCSC_LookDown = 37,
        EFCSC_LineLauncher = 38,
        EFCSC_Batarang = 39,
        EFCSC_HarpoonAim = 40,
        EFCSC_MagneticBlastAim = 41,
        EFCSC_FreezeJammerAim = 42,
        EFCSC_JokerGunAim = 43,
        EFCSC_Grate = 44,
        EFCSC_HighGrate = 45,
        EFCSC_VenomHenchmenCombat = 46,
        EFCSC_VenomHenchmenRide = 47,
        EFCSC_Slide = 48,
        EFCSC_GrundyCombat = 49,
        EFCSC_ClayfaceCombat = 50,
        EFCSC_ClayfaceCoupCombat = 51,
        EFCSC_RasChoke = 52,
        EFCSC_RasMano = 53,
        EFCSC_RasFury = 54,
        EFCSC_RasBurly = 55,
        EFCSC_RasSword = 56,
        EFCSC_CeilingClimb = 57,
        EFCSC_CeilingToLedgeHang = 58,
        EFCSC_CeilingToCatwalk = 59,
        EFCSC_CeilingBatarang = 60,
        EFCSC_LedgeSwing = 61,
        EFCSC_DeepFallLand = 62,
        EFCSC_Helicopter = 63,
        EFCSC_PenguinBeatdown = 64,
        EFCSC_DeathstrokeFFC = 65,
        EFCSC_BaneTitanChase = 66,
        EFCSC_BaneCombat = 67,
        EFCSC_FireFlyCam = 68,
        EFCSC_FireFlyCam2 = 69,
        EFCSC_CopperheadShoulder = 70,
        EFCSC_BaneTitanAttack = 71,
        EFCSC_FreeCameraStateConfigMAX = 72,
        EFCSC_MAX = 73,
    }

    /// <summary>
    /// Struct: FFreeCameraConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 136)]
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

        /// <summary>
        /// IntProperty: FOV
        /// </summary>
        public unsafe int FOV
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }; }
        }

        /// <summary>
        /// FloatProperty: PlayerHeadOffset
        /// </summary>
        public unsafe float PlayerHeadOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }

        /// <summary>
        /// FloatProperty: TransitionTime
        /// </summary>
        public unsafe float TransitionTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }
    }
}
