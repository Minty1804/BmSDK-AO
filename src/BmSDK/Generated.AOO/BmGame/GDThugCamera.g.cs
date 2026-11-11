#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDThugCamera<br/>
/// (size = 14132)
/// (flags = 10518550)
/// </summary>
public partial class GDThugCamera : BmSDK.BmGame.GDBaseThugCamera, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDThugCamera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDThugCamera.
    /// </summary>
    public static GDThugCamera DefaultObject => (GDThugCamera)StaticClass().DefaultObject;

    internal GDThugCamera() { }

    /// <summary>
    /// Constructs a new GDThugCamera
    /// </summary>
    public GDThugCamera(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDThugCamera(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDThugCamera>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDThugCamera>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDThugCamera>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDThugCamera>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDThugCamera>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDThugCamera>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDThugCamera>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDThugCamera>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_AddYawToCameraViewRotation;
    /// <summary>
    /// Function: AddYawToCameraViewRotation
    /// </summary>
    public unsafe virtual void AddYawToCameraViewRotation(int YawInc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddYawToCameraViewRotation, "BmGame.GDThugCamera.AddYawToCameraViewRotation");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YawInc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerFollowsCamera;
    /// <summary>
    /// Function: PlayerFollowsCamera
    /// </summary>
    public unsafe virtual void PlayerFollowsCamera(bool bFollow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerFollowsCamera, "BmGame.GDThugCamera.PlayerFollowsCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFollow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LockToPlayer;
    /// <summary>
    /// Function: LockToPlayer
    /// </summary>
    public unsafe virtual void LockToPlayer(bool bLock)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockToPlayer, "BmGame.GDThugCamera.LockToPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLock, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearCameraLock;
    /// <summary>
    /// Function: ClearCameraLock
    /// </summary>
    public unsafe virtual void ClearCameraLock(float CameraTransitionTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCameraLock, "BmGame.GDThugCamera.ClearCameraLock");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraTransitionTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: WalkThugCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig WalkThugCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 13220);

    /// <summary>
    /// StructProperty: WalkThugOverShoulderOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WalkThugOverShoulderOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13344);

    /// <summary>
    /// FloatProperty: WalkSmoothingConfigStrength
    /// </summary>
    public unsafe float WalkSmoothingConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13356); }
    }

    /// <summary>
    /// StructProperty: JogThugCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig JogThugCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 13360);

    /// <summary>
    /// StructProperty: JogThugOverShoulderOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 JogThugOverShoulderOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13484);

    /// <summary>
    /// FloatProperty: JogSmoothingConfigStrength
    /// </summary>
    public unsafe float JogSmoothingConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13496); }
    }

    /// <summary>
    /// StructProperty: RunThugCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RunThugCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 13500);

    /// <summary>
    /// StructProperty: RunThugOverShoulderOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RunThugOverShoulderOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13624);

    /// <summary>
    /// FloatProperty: RunSmoothingConfigStrength
    /// </summary>
    public unsafe float RunSmoothingConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13636); }
    }

    /// <summary>
    /// FloatProperty: RunningCameraSpeed
    /// </summary>
    public unsafe float RunningCameraSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13640); }
    }

    /// <summary>
    /// FloatProperty: RunningCameraInitialSpeed
    /// </summary>
    public unsafe float RunningCameraInitialSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13644); }
    }

    /// <summary>
    /// FloatProperty: RunningCameraTimeToMaxSpeedSeconds
    /// </summary>
    public unsafe float RunningCameraTimeToMaxSpeedSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13648); }
    }

    /// <summary>
    /// FloatProperty: RunningCameraTimeToMaxSpeedSeconds180
    /// </summary>
    public unsafe float RunningCameraTimeToMaxSpeedSeconds180
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13652); }
    }

    /// <summary>
    /// FloatProperty: RunningCameraPitchMultiplier
    /// </summary>
    public unsafe float RunningCameraPitchMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13656); }
    }

    /// <summary>
    /// BoolProperty: EnableRunningCameraFOV
    /// </summary>
    public unsafe bool EnableRunningCameraFOV
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13660) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13660); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 13660); }
    }

    /// <summary>
    /// BoolProperty: EnableRunShake
    /// </summary>
    public unsafe bool EnableRunShake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13660) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13660); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 13660); }
    }

    /// <summary>
    /// BoolProperty: EnablePelvisSway
    /// </summary>
    public unsafe bool EnablePelvisSway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13660) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13660); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 13660); }
    }

    /// <summary>
    /// BoolProperty: CameraStart
    /// </summary>
    public unsafe bool CameraStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13660) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13660); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 13660); }
    }

    /// <summary>
    /// BoolProperty: EnableCameraOffsetExtremeOrientation
    /// </summary>
    public unsafe bool EnableCameraOffsetExtremeOrientation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13660) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13660); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 13660); }
    }

    /// <summary>
    /// BoolProperty: SkipCameraLock
    /// </summary>
    public unsafe bool SkipCameraLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13660) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13660); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 13660); }
    }

    /// <summary>
    /// FloatProperty: RunningCameraFOV
    /// </summary>
    public unsafe float RunningCameraFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13664); }
    }

    /// <summary>
    /// FloatProperty: RunningCameraFOVZoomSpeed
    /// </summary>
    public unsafe float RunningCameraFOVZoomSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13668); }
    }

    /// <summary>
    /// FloatProperty: DashOverlayCameraBlendInTime
    /// </summary>
    public unsafe float DashOverlayCameraBlendInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13672); }
    }

    /// <summary>
    /// FloatProperty: DashOverlayCameraBlendOutTime
    /// </summary>
    public unsafe float DashOverlayCameraBlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13676); }
    }

    /// <summary>
    /// StructProperty: RunCameraShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct RunCameraShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 13680);

    /// <summary>
    /// FloatProperty: RunShakeBlendInTime
    /// </summary>
    public unsafe float RunShakeBlendInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13824); }
    }

    /// <summary>
    /// StructProperty: UltrasonicPulseGadgetThugOverShoulderOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 UltrasonicPulseGadgetThugOverShoulderOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13828);

    /// <summary>
    /// FloatProperty: UltrasonicPulseGadgetCameraTransitionTime
    /// </summary>
    public unsafe float UltrasonicPulseGadgetCameraTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13840); }
    }

    /// <summary>
    /// FloatProperty: UltrasonicPulseGadgetCameraTurnSpeed
    /// </summary>
    public unsafe float UltrasonicPulseGadgetCameraTurnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13844); }
    }

    /// <summary>
    /// FloatProperty: UltrasonicPulseGadgetCameraYawAngleOffset
    /// </summary>
    public unsafe float UltrasonicPulseGadgetCameraYawAngleOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13848); }
    }

    /// <summary>
    /// FloatProperty: UltrasonicPulseGadgetCameraPitchAngleOffset
    /// </summary>
    public unsafe float UltrasonicPulseGadgetCameraPitchAngleOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13852); }
    }

    /// <summary>
    /// StructProperty: FullCoverOverShoulderOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FullCoverOverShoulderOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13856);

    /// <summary>
    /// StructProperty: HalfCoverOverShoulderOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HalfCoverOverShoulderOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13868);

    /// <summary>
    /// StructProperty: LeanFullCoverOverShoulderOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LeanFullCoverOverShoulderOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13880);

    /// <summary>
    /// StructProperty: LeanHalfCoverOverShoulderOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LeanHalfCoverOverShoulderOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13892);

    /// <summary>
    /// StructProperty: LastSlotFullCoverOverShoulderOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSlotFullCoverOverShoulderOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13904);

    /// <summary>
    /// StructProperty: LastSlotHalfCoverOverShoulderOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSlotHalfCoverOverShoulderOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13916);

    /// <summary>
    /// StructProperty: PopUpCoverOverShoulderOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PopUpCoverOverShoulderOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13928);

    /// <summary>
    /// StructProperty: CoverPopUpOffsetUp
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CoverPopUpOffsetUp
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13940);

    /// <summary>
    /// StructProperty: CoverPopUpOffsetDown
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CoverPopUpOffsetDown
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13952);

    /// <summary>
    /// StructProperty: CoverPopUpPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CoverPopUpPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13964);

    /// <summary>
    /// IntProperty: MaxPitchCoverPopUpCamera
    /// </summary>
    public unsafe int MaxPitchCoverPopUpCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13976); }
    }

    /// <summary>
    /// IntProperty: MinPitchCoverPopUpCamera
    /// </summary>
    public unsafe int MinPitchCoverPopUpCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13980); }
    }

    /// <summary>
    /// StructProperty: ExtremeUpOffsetCoverPopUp
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ExtremeUpOffsetCoverPopUp
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13984);

    /// <summary>
    /// StructProperty: ExtremeDownOffsetCoverPopUp
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ExtremeDownOffsetCoverPopUp
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13996);

    /// <summary>
    /// IntProperty: MaxPitchFullCoverLeanCamera
    /// </summary>
    public unsafe int MaxPitchFullCoverLeanCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 14008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14008); }
    }

    /// <summary>
    /// IntProperty: MinPitchFullCoverLeanCamera
    /// </summary>
    public unsafe int MinPitchFullCoverLeanCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 14012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14012); }
    }

    /// <summary>
    /// StructProperty: ExtremeUpOffsetFullCoverLean
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ExtremeUpOffsetFullCoverLean
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14016);

    /// <summary>
    /// StructProperty: ExtremeDownOffsetFullCoverLean
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ExtremeDownOffsetFullCoverLean
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14028);

    /// <summary>
    /// IntProperty: MaxPitchHalfCoverLeanCamera
    /// </summary>
    public unsafe int MaxPitchHalfCoverLeanCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 14040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14040); }
    }

    /// <summary>
    /// IntProperty: MinPitchHalfCoverLeanCamera
    /// </summary>
    public unsafe int MinPitchHalfCoverLeanCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 14044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14044); }
    }

    /// <summary>
    /// StructProperty: ExtremeUpOffsetHalfCoverLean
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ExtremeUpOffsetHalfCoverLean
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14048);

    /// <summary>
    /// StructProperty: ExtremeDownOffsetHalfCoverLean
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ExtremeDownOffsetHalfCoverLean
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14060);

    /// <summary>
    /// FloatProperty: CameraHeadOffsetFullCoverNoTowardCover
    /// </summary>
    public unsafe float CameraHeadOffsetFullCoverNoTowardCover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14072); }
    }

    /// <summary>
    /// FloatProperty: CameraOffsetExtremeOrientationAngleLimit
    /// </summary>
    public unsafe float CameraOffsetExtremeOrientationAngleLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14076); }
    }

    /// <summary>
    /// StructProperty: ExitDoorCamOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ExitDoorCamOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 14080);

    /// <summary>
    /// StructProperty: ExitDoorCamRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator ExitDoorCamRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 14092);

    /// <summary>
    /// FloatProperty: ExitDoorCamBlendTime
    /// </summary>
    public unsafe float ExitDoorCamBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14104); }
    }

    /// <summary>
    /// IntProperty: RunShakeId
    /// </summary>
    public unsafe int RunShakeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 14108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14108); }
    }

    /// <summary>
    /// FloatProperty: CameraTimeToMax
    /// </summary>
    public unsafe float CameraTimeToMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14112); }
    }

    /// <summary>
    /// FloatProperty: OriginalCameraFOV
    /// </summary>
    public unsafe float OriginalCameraFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14116); }
    }

    /// <summary>
    /// FloatProperty: ExtremeLeftOffsetValue
    /// </summary>
    public unsafe float ExtremeLeftOffsetValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14120); }
    }

    /// <summary>
    /// FloatProperty: ExtremeRightOffsetValue
    /// </summary>
    public unsafe float ExtremeRightOffsetValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14124); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraOffsetExtremeOrientationAngleLimit
    /// </summary>
    public unsafe float CurrentCameraOffsetExtremeOrientationAngleLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 14128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14128); }
    }
}
