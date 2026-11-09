#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: MPawnVillainDeathStrokeBase<br/>
/// (size = 4400)
/// (flags = 144703671)
/// </summary>
public partial class MPawnVillainDeathStrokeBase : BmSDK.BmGame.RPawnVillain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MPawnVillainDeathStrokeBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnVillainDeathStrokeBase.
    /// </summary>
    public static MPawnVillainDeathStrokeBase DefaultObject => (MPawnVillainDeathStrokeBase)StaticClass().DefaultObject;

    internal MPawnVillainDeathStrokeBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnVillainDeathStrokeBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainDeathStrokeBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainDeathStrokeBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainDeathStrokeBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainDeathStrokeBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainDeathStrokeBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainDeathStrokeBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainDeathStrokeBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainDeathStrokeBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsNewGamePlus;
    /// <summary>
    /// Function: IsNewGamePlus
    /// </summary>
    public unsafe virtual bool IsNewGamePlus()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNewGamePlus, "BmGame.MPawnVillainDeathStrokeBase.IsNewGamePlus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncCounterFailed;
    /// <summary>
    /// Function: IncCounterFailed
    /// </summary>
    public unsafe virtual void IncCounterFailed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncCounterFailed, "BmGame.MPawnVillainDeathStrokeBase.IncCounterFailed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayMoveCam;
    /// <summary>
    /// Function: PlayMoveCam
    /// </summary>
    public unsafe virtual void PlayMoveCam(BmSDK.Engine.AnimSet TheCameraAnimSet, BmSDK.Engine.AnimSet ThePlayerAnimSet, BmSDK.FName AnimName, System.Numerics.Vector3 CamRoot, BmSDK.Rotator CamRot, float RealBlendOutTime = default, bool FirstCamOrNothing = default, bool AllowsTeleport = default, float FOV = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayMoveCam, "BmGame.MPawnVillainDeathStrokeBase.PlayMoveCam");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheCameraAnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePlayerAnimSet, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamRoot, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamRot, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RealBlendOutTime, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstCamOrNothing, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowsTeleport, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetHasBeenBatclawSlammed;
    /// <summary>
    /// Function: ResetHasBeenBatclawSlammed
    /// </summary>
    public unsafe virtual void ResetHasBeenBatclawSlammed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetHasBeenBatclawSlammed, "BmGame.MPawnVillainDeathStrokeBase.ResetHasBeenBatclawSlammed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsValidBatclawSlamTarget;
    /// <summary>
    /// Function: IsValidBatclawSlamTarget
    /// </summary>
    public unsafe override bool IsValidBatclawSlamTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidBatclawSlamTarget, "BmGame.MPawnVillainDeathStrokeBase.IsValidBatclawSlamTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ComputeCameraOffset;
    /// <summary>
    /// Function: ComputeCameraOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 ComputeCameraOffset(BmSDK.BmGame.RInGameCinematicCam CinematicCamera, float CameraTimeNormalised, System.Numerics.Vector3 CamLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ComputeCameraOffset, "BmGame.MPawnVillainDeathStrokeBase.ComputeCameraOffset");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicCamera, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraTimeNormalised, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ComputeCameraInitLocation;
    /// <summary>
    /// Function: ComputeCameraInitLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 ComputeCameraInitLocation(BmSDK.BmGame.RInGameCinematicCam CinematicCamera)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ComputeCameraInitLocation, "BmGame.MPawnVillainDeathStrokeBase.ComputeCameraInitLocation");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicCamera, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DoesCameraMaintainLos;
    /// <summary>
    /// Function: DoesCameraMaintainLos
    /// </summary>
    public unsafe virtual bool DoesCameraMaintainLos(BmSDK.BmGame.RInGameCinematicCam CinematicCamera, out float CameraTimeNormalised)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoesCameraMaintainLos, "BmGame.MPawnVillainDeathStrokeBase.DoesCameraMaintainLos");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicCamera, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CameraTimeNormalised);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraTimeNormalised, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CameraTimeNormalised = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanCameraSeePoint;
    /// <summary>
    /// Function: CanCameraSeePoint
    /// </summary>
    public unsafe virtual bool CanCameraSeePoint(BmSDK.BmGame.RInGameCinematicCam CinematicCamera, float CameraTimeNormalised, System.Numerics.Vector3 CameraCheckTarget, BmSDK.Engine.Actor IgnoreThisActor, BmSDK.Engine.Actor IgnoreThisActorToo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCameraSeePoint, "BmGame.MPawnVillainDeathStrokeBase.CanCameraSeePoint");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicCamera, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraTimeNormalised, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraCheckTarget, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreThisActor, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreThisActorToo, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetCameraTarget;
    /// <summary>
    /// Function: GetCameraTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCameraTarget(BmSDK.BmGame.RPawn Pawn, bool CheckEyes)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraTarget, "BmGame.MPawnVillainDeathStrokeBase.GetCameraTarget");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckEyes, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_StopCamera;
    /// <summary>
    /// Function: StopCamera
    /// </summary>
    public unsafe virtual void StopCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCamera, "BmGame.MPawnVillainDeathStrokeBase.StopCamera");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InterruptCamera;
    /// <summary>
    /// Function: InterruptCamera
    /// </summary>
    public unsafe virtual void InterruptCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterruptCamera, "BmGame.MPawnVillainDeathStrokeBase.InterruptCamera");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetSwitchCameraFlag;
    /// <summary>
    /// Function: ResetSwitchCameraFlag
    /// </summary>
    public unsafe virtual void ResetSwitchCameraFlag()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetSwitchCameraFlag, "BmGame.MPawnVillainDeathStrokeBase.ResetSwitchCameraFlag");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddScreenShake;
    /// <summary>
    /// Function: AddScreenShake
    /// </summary>
    public unsafe virtual void AddScreenShake(BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct Shake, float Scale = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddScreenShake, "BmGame.MPawnVillainDeathStrokeBase.AddScreenShake");
        byte* paramsPtr = stackalloc byte[164];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Shake, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 144);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayClosestCamera;
    /// <summary>
    /// Function: PlayClosestCamera
    /// </summary>
    public unsafe virtual bool PlayClosestCamera(BmSDK.Engine.AnimSet TheCameraAnimSet, BmSDK.TArray<BmSDK.FName> CamAnimList, System.Numerics.Vector3 CamLocation, BmSDK.Rotator camRotation, float BlendInTime, float BlendOutTime, bool ComputeBestLocation, out System.Numerics.Vector3 BestLocation, out BmSDK.FName UsedAnimName, float RealBlendOutTime, float FOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayClosestCamera, "BmGame.MPawnVillainDeathStrokeBase.PlayClosestCamera");
        byte* paramsPtr = stackalloc byte[184];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheCameraAnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamAnimList, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(camRotation, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendInTime, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutTime, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComputeBestLocation, paramsPtr + 48);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestLocation, paramsPtr + 52);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out UsedAnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UsedAnimName, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RealBlendOutTime, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 76);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 52);
        UsedAnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 64);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 80);
    }

    private static BmSDK.Function __fn_CanPlayDodgeDialogue;
    /// <summary>
    /// Function: CanPlayDodgeDialogue
    /// </summary>
    public unsafe virtual bool CanPlayDodgeDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayDodgeDialogue, "BmGame.MPawnVillainDeathStrokeBase.CanPlayDodgeDialogue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPlayStaffHitDialogue;
    /// <summary>
    /// Function: CanPlayStaffHitDialogue
    /// </summary>
    public unsafe virtual bool CanPlayStaffHitDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayStaffHitDialogue, "BmGame.MPawnVillainDeathStrokeBase.CanPlayStaffHitDialogue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPlaySwordHitDialogue;
    /// <summary>
    /// Function: CanPlaySwordHitDialogue
    /// </summary>
    public unsafe virtual bool CanPlaySwordHitDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlaySwordHitDialogue, "BmGame.MPawnVillainDeathStrokeBase.CanPlaySwordHitDialogue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldPlay;
    /// <summary>
    /// Function: ShouldPlay
    /// </summary>
    public unsafe virtual bool ShouldPlay(int probability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPlay, "BmGame.MPawnVillainDeathStrokeBase.ShouldPlay");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(probability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBatclawLocation;
    /// <summary>
    /// Function: GetBatclawLocation
    /// </summary>
    public unsafe virtual void GetBatclawLocation(out System.Numerics.Vector3 clawLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatclawLocation, "BmGame.MPawnVillainDeathStrokeBase.GetBatclawLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out clawLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(clawLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        clawLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetMaxTugOfWarTime;
    /// <summary>
    /// Function: GetMaxTugOfWarTime
    /// </summary>
    public unsafe virtual float GetMaxTugOfWarTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxTugOfWarTime, "BmGame.MPawnVillainDeathStrokeBase.GetMaxTugOfWarTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatclawSocket;
    /// <summary>
    /// Function: GetBatclawSocket
    /// </summary>
    public unsafe virtual BmSDK.FName GetBatclawSocket()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatclawSocket, "BmGame.MPawnVillainDeathStrokeBase.GetBatclawSocket");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsTugOfWarStarted;
    /// <summary>
    /// Function: IsTugOfWarStarted
    /// </summary>
    public unsafe virtual bool IsTugOfWarStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTugOfWarStarted, "BmGame.MPawnVillainDeathStrokeBase.IsTugOfWarStarted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanStartTugOfWar;
    /// <summary>
    /// Function: CanStartTugOfWar
    /// </summary>
    public unsafe virtual bool CanStartTugOfWar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanStartTugOfWar, "BmGame.MPawnVillainDeathStrokeBase.CanStartTugOfWar");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WonTugOfWar;
    /// <summary>
    /// Function: WonTugOfWar
    /// </summary>
    public unsafe virtual void WonTugOfWar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WonTugOfWar, "BmGame.MPawnVillainDeathStrokeBase.WonTugOfWar");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LostTugOfWar;
    /// <summary>
    /// Function: LostTugOfWar
    /// </summary>
    public unsafe virtual void LostTugOfWar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LostTugOfWar, "BmGame.MPawnVillainDeathStrokeBase.LostTugOfWar");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartTugOfWar;
    /// <summary>
    /// Function: StartTugOfWar
    /// </summary>
    public unsafe virtual void StartTugOfWar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTugOfWar, "BmGame.MPawnVillainDeathStrokeBase.StartTugOfWar");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartBraceWire;
    /// <summary>
    /// Function: StartBraceWire
    /// </summary>
    public unsafe virtual void StartBraceWire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartBraceWire, "BmGame.MPawnVillainDeathStrokeBase.StartBraceWire");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShootBatclaw;
    /// <summary>
    /// Function: ShootBatclaw
    /// </summary>
    public unsafe virtual void ShootBatclaw(BmSDK.Engine.Actor HarpoonProjectile)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShootBatclaw, "BmGame.MPawnVillainDeathStrokeBase.ShootBatclaw");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HarpoonProjectile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsTugOfWarNeeded;
    /// <summary>
    /// Function: IsTugOfWarNeeded
    /// </summary>
    public unsafe virtual bool IsTugOfWarNeeded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTugOfWarNeeded, "BmGame.MPawnVillainDeathStrokeBase.IsTugOfWarNeeded");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsOnWire;
    /// <summary>
    /// Function: IsOnWire
    /// </summary>
    public unsafe virtual bool IsOnWire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOnWire, "BmGame.MPawnVillainDeathStrokeBase.IsOnWire");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetShootBatclawDistance;
    /// <summary>
    /// Function: GetShootBatclawDistance
    /// </summary>
    public unsafe virtual float GetShootBatclawDistance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetShootBatclawDistance, "BmGame.MPawnVillainDeathStrokeBase.GetShootBatclawDistance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WireLimbAllOff;
    /// <summary>
    /// Function: WireLimbAllOff
    /// </summary>
    public unsafe virtual void WireLimbAllOff()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WireLimbAllOff, "BmGame.MPawnVillainDeathStrokeBase.WireLimbAllOff");
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

    private static BmSDK.Function __fn_WireLimbOnOrOff;
    /// <summary>
    /// Function: WireLimbOnOrOff
    /// </summary>
    public unsafe virtual void WireLimbOnOrOff(BmSDK.BmGame.RPawnPlayer.OverheadRopeControlPointType LimbType, bool bOnOrOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WireLimbOnOrOff, "BmGame.MPawnVillainDeathStrokeBase.WireLimbOnOrOff");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LimbType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnOrOff, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ClearGrapplePointControlPoint;
    /// <summary>
    /// Function: ClearGrapplePointControlPoint
    /// </summary>
    public unsafe virtual void ClearGrapplePointControlPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGrapplePointControlPoint, "BmGame.MPawnVillainDeathStrokeBase.ClearGrapplePointControlPoint");
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

    private static BmSDK.Function __fn_CreateGrappleWireControlPoint;
    /// <summary>
    /// Function: CreateGrappleWireControlPoint
    /// </summary>
    public unsafe virtual void CreateGrappleWireControlPoint(BmSDK.BmGame.RHidePoint_RopeBase Wire, System.Numerics.Vector3 ApproxPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateGrappleWireControlPoint, "BmGame.MPawnVillainDeathStrokeBase.CreateGrappleWireControlPoint");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Wire, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ApproxPosition, paramsPtr + 4);
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

    private static BmSDK.Function __fn_IncrementWireBounce;
    /// <summary>
    /// Function: IncrementWireBounce
    /// </summary>
    public unsafe virtual void IncrementWireBounce(float Speed, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncrementWireBounce, "BmGame.MPawnVillainDeathStrokeBase.IncrementWireBounce");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 4);
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

    private static BmSDK.Function __fn_TurnOffWireBounce;
    /// <summary>
    /// Function: TurnOffWireBounce
    /// </summary>
    public unsafe virtual void TurnOffWireBounce()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffWireBounce, "BmGame.MPawnVillainDeathStrokeBase.TurnOffWireBounce");
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

    private static BmSDK.Function __fn_InitialiseWireBounce;
    /// <summary>
    /// Function: InitialiseWireBounce
    /// </summary>
    public unsafe virtual void InitialiseWireBounce(float InitialBounce)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseWireBounce, "BmGame.MPawnVillainDeathStrokeBase.InitialiseWireBounce");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialBounce, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetClosestPointOnRope;
    /// <summary>
    /// Function: GetClosestPointOnRope
    /// </summary>
    public unsafe virtual void GetClosestPointOnRope(System.Numerics.Vector3 WireStart, System.Numerics.Vector3 WireEnd, System.Numerics.Vector3 TestLocation, out System.Numerics.Vector3 JumpLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestPointOnRope, "BmGame.MPawnVillainDeathStrokeBase.GetClosestPointOnRope");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WireStart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WireEnd, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out JumpLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpLocation, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        JumpLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        return;
    }

    private static BmSDK.Function __fn_GetWireJumpLocation;
    /// <summary>
    /// Function: GetWireJumpLocation
    /// </summary>
    public unsafe virtual void GetWireJumpLocation(out System.Numerics.Vector3 WireStart, out System.Numerics.Vector3 WireEnd, out System.Numerics.Vector3 JumpLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWireJumpLocation, "BmGame.MPawnVillainDeathStrokeBase.GetWireJumpLocation");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WireStart);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WireStart, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WireEnd);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WireEnd, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out JumpLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpLocation, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        WireStart = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        WireEnd = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        JumpLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_GetSwordHitPS;
    /// <summary>
    /// Function: GetSwordHitPS
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetSwordHitPS()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSwordHitPS, "BmGame.MPawnVillainDeathStrokeBase.GetSwordHitPS");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStaffHitPS;
    /// <summary>
    /// Function: GetStaffHitPS
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetStaffHitPS()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStaffHitPS, "BmGame.MPawnVillainDeathStrokeBase.GetStaffHitPS");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentDamageProxy;
    /// <summary>
    /// Function: GetCurrentDamageProxy
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatDamageProxy GetCurrentDamageProxy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentDamageProxy, "BmGame.MPawnVillainDeathStrokeBase.GetCurrentDamageProxy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatDamageProxy>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ActivateStaffCollision;
    /// <summary>
    /// Function: ActivateStaffCollision
    /// </summary>
    public unsafe virtual void ActivateStaffCollision()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateStaffCollision, "BmGame.MPawnVillainDeathStrokeBase.ActivateStaffCollision");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerTookDamage;
    /// <summary>
    /// Function: PlayerTookDamage
    /// </summary>
    public unsafe virtual void PlayerTookDamage(int Damage, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerTookDamage, "BmGame.MPawnVillainDeathStrokeBase.PlayerTookDamage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSwordClass;
    /// <summary>
    /// Function: GetSwordClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetSwordClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSwordClass, "BmGame.MPawnVillainDeathStrokeBase.GetSwordClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStaffClass;
    /// <summary>
    /// Function: GetStaffClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetStaffClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStaffClass, "BmGame.MPawnVillainDeathStrokeBase.GetStaffClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetDodgeCounterStrikeChance;
    /// <summary>
    /// Function: ResetDodgeCounterStrikeChance
    /// </summary>
    public unsafe virtual void ResetDodgeCounterStrikeChance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetDodgeCounterStrikeChance, "BmGame.MPawnVillainDeathStrokeBase.ResetDodgeCounterStrikeChance");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncDodgeCounterStrikeChance;
    /// <summary>
    /// Function: IncDodgeCounterStrikeChance
    /// </summary>
    public unsafe virtual void IncDodgeCounterStrikeChance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncDodgeCounterStrikeChance, "BmGame.MPawnVillainDeathStrokeBase.IncDodgeCounterStrikeChance");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindAndPlayOverridePlayerDeathAnim;
    /// <summary>
    /// Function: FindAndPlayOverridePlayerDeathAnim
    /// </summary>
    public unsafe virtual bool FindAndPlayOverridePlayerDeathAnim(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAndPlayOverridePlayerDeathAnim, "BmGame.MPawnVillainDeathStrokeBase.FindAndPlayOverridePlayerDeathAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SwitchHand;
    /// <summary>
    /// Function: SwitchHand
    /// </summary>
    public unsafe virtual void SwitchHand()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchHand, "BmGame.MPawnVillainDeathStrokeBase.SwitchHand");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRetreatLocation;
    /// <summary>
    /// Function: GetRetreatLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRetreatLocation(out System.Numerics.Vector3 CenterLine)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRetreatLocation, "BmGame.MPawnVillainDeathStrokeBase.GetRetreatLocation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CenterLine);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CenterLine, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CenterLine = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ShouldStartFinalBlowCam;
    /// <summary>
    /// Function: ShouldStartFinalBlowCam
    /// </summary>
    public unsafe override bool ShouldStartFinalBlowCam(float StrikeDamageAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStartFinalBlowCam, "BmGame.MPawnVillainDeathStrokeBase.ShouldStartFinalBlowCam");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDamageAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetRifleClass;
    /// <summary>
    /// Function: GetRifleClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetRifleClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRifleClass, "BmGame.MPawnVillainDeathStrokeBase.GetRifleClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDualClawClass;
    /// <summary>
    /// Function: GetDualClawClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetDualClawClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDualClawClass, "BmGame.MPawnVillainDeathStrokeBase.GetDualClawClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DodgeFireRemoteClaw;
    /// <summary>
    /// Function: DodgeFireRemoteClaw
    /// </summary>
    public unsafe virtual void DodgeFireRemoteClaw(System.Numerics.Vector3 RetreatLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DodgeFireRemoteClaw, "BmGame.MPawnVillainDeathStrokeBase.DodgeFireRemoteClaw");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RetreatLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanShowTutorial;
    /// <summary>
    /// Function: CanShowTutorial
    /// </summary>
    public unsafe virtual bool CanShowTutorial()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanShowTutorial, "BmGame.MPawnVillainDeathStrokeBase.CanShowTutorial");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentPhase;
    /// <summary>
    /// Function: GetCurrentPhase
    /// </summary>
    public unsafe virtual int GetCurrentPhase()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentPhase, "BmGame.MPawnVillainDeathStrokeBase.GetCurrentPhase");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetWeaponDamage;
    /// <summary>
    /// Function: GetWeaponDamage
    /// </summary>
    public unsafe virtual float GetWeaponDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponDamage, "BmGame.MPawnVillainDeathStrokeBase.GetWeaponDamage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SuccessfullAttack;
    /// <summary>
    /// Function: SuccessfullAttack
    /// </summary>
    public unsafe virtual void SuccessfullAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuccessfullAttack, "BmGame.MPawnVillainDeathStrokeBase.SuccessfullAttack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounteringDeathstroke;
    /// <summary>
    /// Function: CounteringDeathstroke
    /// </summary>
    public unsafe virtual bool CounteringDeathstroke()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounteringDeathstroke, "BmGame.MPawnVillainDeathStrokeBase.CounteringDeathstroke");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DebugAdvanceState;
    /// <summary>
    /// Function: DebugAdvanceState
    /// </summary>
    public unsafe virtual void DebugAdvanceState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugAdvanceState, "BmGame.MPawnVillainDeathStrokeBase.DebugAdvanceState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 3996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3996); }
    }

    /// <summary>
    /// ObjectProperty: BatmanRPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController BatmanRPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 4000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4000); }
    }

    /// <summary>
    /// ComponentProperty: StaffTrailCompL
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent StaffTrailCompL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4004); }
    }

    /// <summary>
    /// ComponentProperty: StaffTrailCompR
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent StaffTrailCompR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4008); }
    }

    /// <summary>
    /// ObjectProperty: MaskedSwitchName
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName MaskedSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 4012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4012); }
    }

    /// <summary>
    /// ObjectProperty: UnmaskedSwitchName
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName UnmaskedSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 4016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4016); }
    }

    /// <summary>
    /// ObjectProperty: StrongWeaponImpactSwitchName
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName StrongWeaponImpactSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 4020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4020); }
    }

    /// <summary>
    /// ObjectProperty: WeakWeaponImpactSwitchName
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName WeakWeaponImpactSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 4024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4024); }
    }

    /// <summary>
    /// StructProperty: WireBouncer
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FWireBounceUpdater WireBouncer
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FWireBounceUpdater>(Ptr + 4028);

    /// <summary>
    /// ObjectProperty: CurrentWire
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint_RopeBase CurrentWire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint_RopeBase>(Ptr + 4096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4096); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: OverheadRopeControlPoint
    /// </summary>
    public InlineArray<BmSDK.BmGame.RRope2SimplePhysicsControlPoint> OverheadRopeControlPoint => new(6, Ptr + 4100, 4, this);

    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4104); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4108); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4112); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4116); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4120); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: OverheadRopeControlPointRopePosition
    /// </summary>
    public InlineArray<float> OverheadRopeControlPointRopePosition => new(6, Ptr + 4124, 4, this);

    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4124); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4128); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4136); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4140); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4144); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: OverheadRopeControlPointSocketNames
    /// </summary>
    public InlineArray<BmSDK.FName> OverheadRopeControlPointSocketNames => new(6, Ptr + 4148, 8, this);

    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4156); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4164); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4172); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4180); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4188); }
    }

    /// <summary>
    /// ArrayProperty: DeathStrokeBark_DS_BlindedBySmoke
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> DeathStrokeBark_DS_BlindedBySmoke
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4196); }
    }

    /// <summary>
    /// ArrayProperty: DeathStrokeBark_DS_Dodge
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> DeathStrokeBark_DS_Dodge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4208); }
    }

    /// <summary>
    /// ArrayProperty: DeathStrokeBark_DS_FightStart
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> DeathStrokeBark_DS_FightStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4220); }
    }

    /// <summary>
    /// ArrayProperty: DeathStrokeBark_DS_InstantTakeDown
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> DeathStrokeBark_DS_InstantTakeDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4232); }
    }

    /// <summary>
    /// ArrayProperty: DeathStrokeBark_DS_MaskBreak
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> DeathStrokeBark_DS_MaskBreak
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4244); }
    }

    /// <summary>
    /// ArrayProperty: DeathStrokeBark_DS_StaffBreak
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> DeathStrokeBark_DS_StaffBreak
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4256); }
    }

    /// <summary>
    /// ArrayProperty: DeathStrokeBark_DS_Stage1FuryStart
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> DeathStrokeBark_DS_Stage1FuryStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4268); }
    }

    /// <summary>
    /// ArrayProperty: DeathStrokeBark_DS_Stage1CounterSuccess
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> DeathStrokeBark_DS_Stage1CounterSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }

    /// <summary>
    /// ArrayProperty: DeathStrokeBark_DS_Stage1Taunts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> DeathStrokeBark_DS_Stage1Taunts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4292); }
    }

    /// <summary>
    /// ArrayProperty: DeathStrokeBark_DS_Stage2FuryStart
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> DeathStrokeBark_DS_Stage2FuryStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4304); }
    }

    /// <summary>
    /// ArrayProperty: DeathStrokeBark_DS_Stage2SwordHit
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> DeathStrokeBark_DS_Stage2SwordHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }

    /// <summary>
    /// ArrayProperty: DeathStrokeBark_DS_Stage2CounterSuccess
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> DeathStrokeBark_DS_Stage2CounterSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4328); }
    }

    /// <summary>
    /// ArrayProperty: DeathStrokeBark_DS_Stage2Taunts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> DeathStrokeBark_DS_Stage2Taunts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4340); }
    }

    /// <summary>
    /// ArrayProperty: DeathStrokeBark_DS_Stage3FuryStart
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> DeathStrokeBark_DS_Stage3FuryStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4352); }
    }

    /// <summary>
    /// IntProperty: MaskState
    /// </summary>
    public unsafe int MaskState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4364); }
    }

    /// <summary>
    /// IntProperty: DodgeSpeechProbability
    /// </summary>
    public unsafe int DodgeSpeechProbability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// IntProperty: StaffHitSpeechProbability
    /// </summary>
    public unsafe int StaffHitSpeechProbability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4372); }
    }

    /// <summary>
    /// IntProperty: SwordHitProbability
    /// </summary>
    public unsafe int SwordHitProbability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4376); }
    }

    /// <summary>
    /// BoolProperty: bValidCamera
    /// </summary>
    public unsafe bool bValidCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4380) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4380); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4380); }
    }

    /// <summary>
    /// BoolProperty: bJustBeenBatclawSlammed
    /// </summary>
    public unsafe bool bJustBeenBatclawSlammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4380) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4380); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4380); }
    }

    /// <summary>
    /// BoolProperty: SwitchCamToLeft
    /// </summary>
    public unsafe bool SwitchCamToLeft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4380) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4380); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4380); }
    }

    /// <summary>
    /// BoolProperty: SwitchingCam
    /// </summary>
    public unsafe bool SwitchingCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4380) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4380); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4380); }
    }

    /// <summary>
    /// BoolProperty: InstantSwitchCam
    /// </summary>
    public unsafe bool InstantSwitchCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4380) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4380); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4380); }
    }

    /// <summary>
    /// BoolProperty: bOverrideDontSwitchCameraFlag
    /// </summary>
    public unsafe bool bOverrideDontSwitchCameraFlag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4380) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4380); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4380); }
    }

    /// <summary>
    /// FloatProperty: CameraBlendOutTime
    /// </summary>
    public unsafe float CameraBlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4384); }
    }

    /// <summary>
    /// ComponentProperty: GunProp
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent GunProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 4388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4388); }
    }

    /// <summary>
    /// ComponentProperty: SwordProp
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent SwordProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 4392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4392); }
    }

    /// <summary>
    /// IntProperty: NumberOfFailedCounters
    /// </summary>
    public unsafe int NumberOfFailedCounters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4396); }
    }
}
