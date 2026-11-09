#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: MPawnBossBane_OZBase<br/>
/// (size = 4660)
/// (flags = 144703671)
/// </summary>
public partial class MPawnBossBane_OZBase : BmSDK.BmGame.RPawnVillainCombat, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MPawnBossBane_OZBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnBossBane_OZBase.
    /// </summary>
    public static MPawnBossBane_OZBase DefaultObject => (MPawnBossBane_OZBase)StaticClass().DefaultObject;

    internal MPawnBossBane_OZBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnBossBane_OZBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnBossBane_OZBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBane_OZBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnBossBane_OZBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBane_OZBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBane_OZBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBane_OZBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnBossBane_OZBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBane_OZBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetCenterOfArena;
    /// <summary>
    /// Function: GetCenterOfArena
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCenterOfArena()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCenterOfArena, "BmGame.MPawnBossBane_OZBase.GetCenterOfArena");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHeartBeatType;
    /// <summary>
    /// Function: GetHeartBeatType
    /// </summary>
    public unsafe override int GetHeartBeatType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeartBeatType, "BmGame.MPawnBossBane_OZBase.GetHeartBeatType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DecrementAttackCount;
    /// <summary>
    /// Function: DecrementAttackCount
    /// </summary>
    public unsafe virtual void DecrementAttackCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DecrementAttackCount, "BmGame.MPawnBossBane_OZBase.DecrementAttackCount");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncrementAttackCount;
    /// <summary>
    /// Function: IncrementAttackCount
    /// </summary>
    public unsafe virtual void IncrementAttackCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncrementAttackCount, "BmGame.MPawnBossBane_OZBase.IncrementAttackCount");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestFellOutOfCombatArea;
    /// <summary>
    /// Function: TestFellOutOfCombatArea
    /// </summary>
    public unsafe virtual bool TestFellOutOfCombatArea()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestFellOutOfCombatArea, "BmGame.MPawnBossBane_OZBase.TestFellOutOfCombatArea");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FellOutOfWorld;
    /// <summary>
    /// Function: FellOutOfWorld
    /// </summary>
    public unsafe override void FellOutOfWorld(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FellOutOfWorld, "BmGame.MPawnBossBane_OZBase.FellOutOfWorld");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAnimDurationScale;
    /// <summary>
    /// Function: GetAnimDurationScale
    /// </summary>
    public unsafe virtual float GetAnimDurationScale()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimDurationScale, "BmGame.MPawnBossBane_OZBase.GetAnimDurationScale");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHitPS;
    /// <summary>
    /// Function: GetHitPS
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetHitPS()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitPS, "BmGame.MPawnBossBane_OZBase.GetHitPS");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopCamera;
    /// <summary>
    /// Function: StopCamera
    /// </summary>
    public unsafe virtual void StopCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCamera, "BmGame.MPawnBossBane_OZBase.StopCamera");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterruptCamera, "BmGame.MPawnBossBane_OZBase.InterruptCamera");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddScreenShake, "BmGame.MPawnBossBane_OZBase.AddScreenShake");
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
    public unsafe virtual bool PlayClosestCamera(BmSDK.TArray<BmSDK.FName> CamAnimList, System.Numerics.Vector3 CamLocation, BmSDK.Rotator camRotation, float BlendInTime, float BlendOutTime, bool ComputeBestLocation, out System.Numerics.Vector3 BestLocation, out BmSDK.FName UsedAnimName, float FOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayClosestCamera, "BmGame.MPawnBossBane_OZBase.PlayClosestCamera");
        byte* paramsPtr = stackalloc byte[176];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamAnimList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(camRotation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendInTime, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutTime, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComputeBestLocation, paramsPtr + 44);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestLocation, paramsPtr + 48);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out UsedAnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UsedAnimName, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 48);
        UsedAnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 60);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_PlayCamera;
    /// <summary>
    /// Function: PlayCamera
    /// </summary>
    public unsafe virtual bool PlayCamera(BmSDK.FName CamAnimName, System.Numerics.Vector3 CamLocation, BmSDK.Rotator camRotation, float BlendInTime, float BlendOutTime, bool ComputeBestLocation, out System.Numerics.Vector3 BestLocation, float FOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCamera, "BmGame.MPawnBossBane_OZBase.PlayCamera");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamAnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(camRotation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendInTime, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutTime, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComputeBestLocation, paramsPtr + 40);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestLocation, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 44);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_ComputeCameraOffset;
    /// <summary>
    /// Function: ComputeCameraOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 ComputeCameraOffset(BmSDK.BmGame.RInGameCinematicCam CinematicCamera, float CameraTimeNormalised, System.Numerics.Vector3 CamLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ComputeCameraOffset, "BmGame.MPawnBossBane_OZBase.ComputeCameraOffset");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ComputeCameraInitLocation, "BmGame.MPawnBossBane_OZBase.ComputeCameraInitLocation");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoesCameraMaintainLos, "BmGame.MPawnBossBane_OZBase.DoesCameraMaintainLos");
        byte* paramsPtr = stackalloc byte[36];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCameraSeePoint, "BmGame.MPawnBossBane_OZBase.CanCameraSeePoint");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraTarget, "BmGame.MPawnBossBane_OZBase.GetCameraTarget");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckEyes, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetCounterBlockImpactOverrideEvent;
    /// <summary>
    /// Function: GetCounterBlockImpactOverrideEvent
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent GetCounterBlockImpactOverrideEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterBlockImpactOverrideEvent, "BmGame.MPawnBossBane_OZBase.GetCounterBlockImpactOverrideEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBodyImpactOverrideEvent;
    /// <summary>
    /// Function: GetBodyImpactOverrideEvent
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent GetBodyImpactOverrideEvent(bool bIsPunch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBodyImpactOverrideEvent, "BmGame.MPawnBossBane_OZBase.GetBodyImpactOverrideEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetHeadImpactOverrideEvent;
    /// <summary>
    /// Function: GetHeadImpactOverrideEvent
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent GetHeadImpactOverrideEvent(bool bIsPunch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeadImpactOverrideEvent, "BmGame.MPawnBossBane_OZBase.GetHeadImpactOverrideEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StopFlashingAttackingFX;
    /// <summary>
    /// Function: StopFlashingAttackingFX
    /// </summary>
    public unsafe virtual void StopFlashingAttackingFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFlashingAttackingFX, "BmGame.MPawnBossBane_OZBase.StopFlashingAttackingFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartFlashingAttackingFX;
    /// <summary>
    /// Function: StartFlashingAttackingFX
    /// </summary>
    public unsafe virtual void StartFlashingAttackingFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFlashingAttackingFX, "BmGame.MPawnBossBane_OZBase.StartFlashingAttackingFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBlockGadgetAnim;
    /// <summary>
    /// Function: GetBlockGadgetAnim
    /// </summary>
    public unsafe virtual void GetBlockGadgetAnim(out BmSDK.FName AnimName, out BmSDK.Engine.AnimSet AnimPackage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBlockGadgetAnim, "BmGame.MPawnBossBane_OZBase.GetBlockGadgetAnim");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AnimPackage);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPackage, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        AnimPackage = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_GetCombatBehaviourClass;
    /// <summary>
    /// Function: GetCombatBehaviourClass
    /// </summary>
    public unsafe override BmSDK.Class GetCombatBehaviourClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatBehaviourClass, "BmGame.MPawnBossBane_OZBase.GetCombatBehaviourClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentAttack;
    /// <summary>
    /// Function: GetCurrentAttack
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MCombatMove_Bane_OZAttack GetCurrentAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentAttack, "BmGame.MPawnBossBane_OZBase.GetCurrentAttack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MCombatMove_Bane_OZAttack>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DeactivateCollision;
    /// <summary>
    /// Function: DeactivateCollision
    /// </summary>
    public unsafe virtual void DeactivateCollision()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateCollision, "BmGame.MPawnBossBane_OZBase.DeactivateCollision");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateCollisionRight;
    /// <summary>
    /// Function: ActivateCollisionRight
    /// </summary>
    public unsafe virtual void ActivateCollisionRight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateCollisionRight, "BmGame.MPawnBossBane_OZBase.ActivateCollisionRight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateCollisionLeft;
    /// <summary>
    /// Function: ActivateCollisionLeft
    /// </summary>
    public unsafe virtual void ActivateCollisionLeft()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateCollisionLeft, "BmGame.MPawnBossBane_OZBase.ActivateCollisionLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowsToAttack;
    /// <summary>
    /// Function: AllowsToAttack
    /// </summary>
    public unsafe virtual bool AllowsToAttack(BmSDK.BmGame.RPawnCombat Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowsToAttack, "BmGame.MPawnBossBane_OZBase.AllowsToAttack");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanBeInSimultaneousAttack;
    /// <summary>
    /// Function: CanBeInSimultaneousAttack
    /// </summary>
    public unsafe override bool CanBeInSimultaneousAttack(BmSDK.BmGame.RPawnCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeInSimultaneousAttack, "BmGame.MPawnBossBane_OZBase.CanBeInSimultaneousAttack");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsVulnerableToTakedown;
    /// <summary>
    /// Function: IsVulnerableToTakedown
    /// </summary>
    public unsafe override bool IsVulnerableToTakedown(BmSDK.FString takedown)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVulnerableToTakedown, "BmGame.MPawnBossBane_OZBase.IsVulnerableToTakedown");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CheckBossCounter;
    /// <summary>
    /// Function: CheckBossCounter
    /// </summary>
    public unsafe override bool CheckBossCounter(BmSDK.BmGame.RPawnVillain targ)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckBossCounter, "BmGame.MPawnBossBane_OZBase.CheckBossCounter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(targ, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnSpecialAttack;
    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe override bool SpawnSpecialAttack(BmSDK.BmGame.RPawnCombat PlayerPawn, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialAttack, "BmGame.MPawnBossBane_OZBase.SpawnSpecialAttack");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DoSpecialAttack;
    /// <summary>
    /// Function: DoSpecialAttack
    /// </summary>
    public unsafe virtual void DoSpecialAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoSpecialAttack, "BmGame.MPawnBossBane_OZBase.DoSpecialAttack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.MPawnBossBane_OZBase.Tick");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartDustVFX;
    /// <summary>
    /// Function: StartDustVFX
    /// </summary>
    public unsafe virtual void StartDustVFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartDustVFX, "BmGame.MPawnBossBane_OZBase.StartDustVFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivatePhaseOutput;
    /// <summary>
    /// Function: ActivatePhaseOutput
    /// </summary>
    public unsafe virtual void ActivatePhaseOutput()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivatePhaseOutput, "BmGame.MPawnBossBane_OZBase.ActivatePhaseOutput");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldActivateOutputOnNotify;
    /// <summary>
    /// Function: ShouldActivateOutputOnNotify
    /// </summary>
    public unsafe virtual bool ShouldActivateOutputOnNotify()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldActivateOutputOnNotify, "BmGame.MPawnBossBane_OZBase.ShouldActivateOutputOnNotify");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldDrawHelpPrompt;
    /// <summary>
    /// Function: ShouldDrawHelpPrompt
    /// </summary>
    public unsafe virtual bool ShouldDrawHelpPrompt(out BmSDK.FString Text, out BmSDK.BmGame.RHUDPrompt.EControlIcon Icon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldDrawHelpPrompt, "BmGame.MPawnBossBane_OZBase.ShouldDrawHelpPrompt");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Icon);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Text = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        Icon = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_PlayChargePunchSpeech;
    /// <summary>
    /// Function: PlayChargePunchSpeech
    /// </summary>
    public unsafe virtual void PlayChargePunchSpeech()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayChargePunchSpeech, "BmGame.MPawnBossBane_OZBase.PlayChargePunchSpeech");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayBossSpeech;
    /// <summary>
    /// Function: PlayBossSpeech
    /// </summary>
    public unsafe virtual void PlayBossSpeech(BmSDK.Engine.RDialogueLine Line)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBossSpeech, "BmGame.MPawnBossBane_OZBase.PlayBossSpeech");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Line, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryPlayJokerTaunt;
    /// <summary>
    /// Function: TryPlayJokerTaunt
    /// </summary>
    public unsafe virtual void TryPlayJokerTaunt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryPlayJokerTaunt, "BmGame.MPawnBossBane_OZBase.TryPlayJokerTaunt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyAttackPathNotFound;
    /// <summary>
    /// Function: NotifyAttackPathNotFound
    /// </summary>
    public unsafe virtual void NotifyAttackPathNotFound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyAttackPathNotFound, "BmGame.MPawnBossBane_OZBase.NotifyAttackPathNotFound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyThrowThugAttackSpawned;
    /// <summary>
    /// Function: NotifyThrowThugAttackSpawned
    /// </summary>
    public unsafe virtual void NotifyThrowThugAttackSpawned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyThrowThugAttackSpawned, "BmGame.MPawnBossBane_OZBase.NotifyThrowThugAttackSpawned");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyBackBreakerSpawned;
    /// <summary>
    /// Function: NotifyBackBreakerSpawned
    /// </summary>
    public unsafe virtual void NotifyBackBreakerSpawned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyBackBreakerSpawned, "BmGame.MPawnBossBane_OZBase.NotifyBackBreakerSpawned");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifySpecialAttackSpawned;
    /// <summary>
    /// Function: NotifySpecialAttackSpawned
    /// </summary>
    public unsafe virtual void NotifySpecialAttackSpawned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifySpecialAttackSpawned, "BmGame.MPawnBossBane_OZBase.NotifySpecialAttackSpawned");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyChargeAttackSpawned;
    /// <summary>
    /// Function: NotifyChargeAttackSpawned
    /// </summary>
    public unsafe virtual void NotifyChargeAttackSpawned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyChargeAttackSpawned, "BmGame.MPawnBossBane_OZBase.NotifyChargeAttackSpawned");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPunchAttackSpawned;
    /// <summary>
    /// Function: NotifyPunchAttackSpawned
    /// </summary>
    public unsafe virtual void NotifyPunchAttackSpawned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPunchAttackSpawned, "BmGame.MPawnBossBane_OZBase.NotifyPunchAttackSpawned");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyHarpoonHit;
    /// <summary>
    /// Function: NotifyHarpoonHit
    /// </summary>
    public unsafe virtual void NotifyHarpoonHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyHarpoonHit, "BmGame.MPawnBossBane_OZBase.NotifyHarpoonHit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnBatclawCounter;
    /// <summary>
    /// Function: SpawnBatclawCounter
    /// </summary>
    public unsafe virtual void SpawnBatclawCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBatclawCounter, "BmGame.MPawnBossBane_OZBase.SpawnBatclawCounter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnBatmanCounter;
    /// <summary>
    /// Function: SpawnBatmanCounter
    /// </summary>
    public unsafe virtual void SpawnBatmanCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBatmanCounter, "BmGame.MPawnBossBane_OZBase.SpawnBatmanCounter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnBlockAttack;
    /// <summary>
    /// Function: SpawnBlockAttack
    /// </summary>
    public unsafe virtual void SpawnBlockAttack(BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBlockAttack, "BmGame.MPawnBossBane_OZBase.SpawnBlockAttack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyBlockProjectile;
    /// <summary>
    /// Function: NotifyBlockProjectile
    /// </summary>
    public unsafe virtual void NotifyBlockProjectile(BmSDK.BmGame.RPawnCombat NewAttacker, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyBlockProjectile, "BmGame.MPawnBossBane_OZBase.NotifyBlockProjectile");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnVenomBoost;
    /// <summary>
    /// Function: SpawnVenomBoost
    /// </summary>
    public unsafe virtual void SpawnVenomBoost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnVenomBoost, "BmGame.MPawnBossBane_OZBase.SpawnVenomBoost");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetCountBeforeCounter;
    /// <summary>
    /// Function: ResetCountBeforeCounter
    /// </summary>
    public unsafe virtual void ResetCountBeforeCounter(bool ForceResetThreshold = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetCountBeforeCounter, "BmGame.MPawnBossBane_OZBase.ResetCountBeforeCounter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceResetThreshold, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTargetPriority;
    /// <summary>
    /// Function: GetTargetPriority
    /// </summary>
    public unsafe override float GetTargetPriority(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetPriority, "BmGame.MPawnBossBane_OZBase.GetTargetPriority");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetBeatdownHitsCount;
    /// <summary>
    /// Function: GetBeatdownHitsCount
    /// </summary>
    public unsafe virtual int GetBeatdownHitsCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBeatdownHitsCount, "BmGame.MPawnBossBane_OZBase.GetBeatdownHitsCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldTargetOnTakedown;
    /// <summary>
    /// Function: ShouldTargetOnTakedown
    /// </summary>
    public unsafe override bool ShouldTargetOnTakedown(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldTargetOnTakedown, "BmGame.MPawnBossBane_OZBase.ShouldTargetOnTakedown");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanCounterBatmanAttack;
    /// <summary>
    /// Function: CanCounterBatmanAttack
    /// </summary>
    public unsafe virtual bool CanCounterBatmanAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCounterBatmanAttack, "BmGame.MPawnBossBane_OZBase.CanCounterBatmanAttack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CloseHUD;
    /// <summary>
    /// Function: CloseHUD
    /// </summary>
    public unsafe virtual void CloseHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseHUD, "BmGame.MPawnBossBane_OZBase.CloseHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitHUD;
    /// <summary>
    /// Function: InitHUD
    /// </summary>
    public unsafe virtual void InitHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitHUD, "BmGame.MPawnBossBane_OZBase.InitHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.MPawnBossBane_OZBase.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerNextStage;
    /// <summary>
    /// Function: TriggerNextStage
    /// </summary>
    public unsafe virtual void TriggerNextStage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerNextStage, "BmGame.MPawnBossBane_OZBase.TriggerNextStage");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHealth;
    /// <summary>
    /// Function: SetHealth
    /// </summary>
    public unsafe override void SetHealth()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealth, "BmGame.MPawnBossBane_OZBase.SetHealth");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupBaneFFCCamera;
    /// <summary>
    /// Function: SetupBaneFFCCamera
    /// </summary>
    public unsafe virtual void SetupBaneFFCCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupBaneFFCCamera, "BmGame.MPawnBossBane_OZBase.SetupBaneFFCCamera");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayJokerFightStartDelayed;
    /// <summary>
    /// Function: PlayJokerFightStartDelayed
    /// </summary>
    public unsafe virtual void PlayJokerFightStartDelayed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayJokerFightStartDelayed, "BmGame.MPawnBossBane_OZBase.PlayJokerFightStartDelayed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayBane2IntroDelayed;
    /// <summary>
    /// Function: PlayBane2IntroDelayed
    /// </summary>
    public unsafe virtual void PlayBane2IntroDelayed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBane2IntroDelayed, "BmGame.MPawnBossBane_OZBase.PlayBane2IntroDelayed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNextPhase;
    /// <summary>
    /// Function: SetNextPhase
    /// </summary>
    public unsafe virtual void SetNextPhase()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNextPhase, "BmGame.MPawnBossBane_OZBase.SetNextPhase");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JokerPlayBarkHalfCharge;
    /// <summary>
    /// Function: JokerPlayBarkHalfCharge
    /// </summary>
    public unsafe virtual void JokerPlayBarkHalfCharge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JokerPlayBarkHalfCharge, "BmGame.MPawnBossBane_OZBase.JokerPlayBarkHalfCharge");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVenomScalarParameter;
    /// <summary>
    /// Function: SetVenomScalarParameter
    /// </summary>
    public unsafe virtual void SetVenomScalarParameter(float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVenomScalarParameter, "BmGame.MPawnBossBane_OZBase.SetVenomScalarParameter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnVenomFx;
    /// <summary>
    /// Function: TurnVenomFx
    /// </summary>
    public unsafe virtual void TurnVenomFx(bool TurnOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnVenomFx, "BmGame.MPawnBossBane_OZBase.TurnVenomFx");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayInjectDialog;
    /// <summary>
    /// Function: PlayInjectDialog
    /// </summary>
    public unsafe virtual void PlayInjectDialog()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayInjectDialog, "BmGame.MPawnBossBane_OZBase.PlayInjectDialog");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyVenomButtonPressed;
    /// <summary>
    /// Function: NotifyVenomButtonPressed
    /// </summary>
    public unsafe virtual void NotifyVenomButtonPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyVenomButtonPressed, "BmGame.MPawnBossBane_OZBase.NotifyVenomButtonPressed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchRageState;
    /// <summary>
    /// Function: SwitchRageState
    /// </summary>
    public unsafe virtual void SwitchRageState(bool TurnOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchRageState, "BmGame.MPawnBossBane_OZBase.SwitchRageState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldPlayLineOnJoker;
    /// <summary>
    /// Function: ShouldPlayLineOnJoker
    /// </summary>
    public unsafe virtual bool ShouldPlayLineOnJoker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPlayLineOnJoker, "BmGame.MPawnBossBane_OZBase.ShouldPlayLineOnJoker");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayGadgetSuccessDialogue;
    /// <summary>
    /// Function: PlayGadgetSuccessDialogue
    /// </summary>
    public unsafe virtual void PlayGadgetSuccessDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayGadgetSuccessDialogue, "BmGame.MPawnBossBane_OZBase.PlayGadgetSuccessDialogue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayRagingDialogue;
    /// <summary>
    /// Function: PlayRagingDialogue
    /// </summary>
    public unsafe virtual void PlayRagingDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRagingDialogue, "BmGame.MPawnBossBane_OZBase.PlayRagingDialogue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayRageStartDialogue;
    /// <summary>
    /// Function: PlayRageStartDialogue
    /// </summary>
    public unsafe virtual void PlayRageStartDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRageStartDialogue, "BmGame.MPawnBossBane_OZBase.PlayRageStartDialogue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchVenomState;
    /// <summary>
    /// Function: SwitchVenomState
    /// </summary>
    public unsafe virtual void SwitchVenomState(bool bForcePose = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchVenomState, "BmGame.MPawnBossBane_OZBase.SwitchVenomState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForcePose, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHealthBar;
    /// <summary>
    /// Function: UpdateHealthBar
    /// </summary>
    public unsafe virtual void UpdateHealthBar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHealthBar, "BmGame.MPawnBossBane_OZBase.UpdateHealthBar");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveAttackFromPawn, "BmGame.MPawnBossBane_OZBase.CanReceiveAttackFromPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// ComponentProperty: ExhaustVfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ExhaustVfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4000); }
    }

    /// <summary>
    /// ComponentProperty: ButtonVfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ButtonVfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4004); }
    }

    /// <summary>
    /// ComponentProperty: OutsideSteamVfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent OutsideSteamVfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4008); }
    }

    /// <summary>
    /// ObjectProperty: InRageShockwaveVfxInRegent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem InRageShockwaveVfxInRegent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4012); }
    }

    /// <summary>
    /// ObjectProperty: OutRageShockwaveVfxInRegent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem OutRageShockwaveVfxInRegent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4016); }
    }

    /// <summary>
    /// ObjectProperty: InRageShockwaveVfxInBlackgate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem InRageShockwaveVfxInBlackgate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4020); }
    }

    /// <summary>
    /// ObjectProperty: OutRageShockwaveVfxInBlackgate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem OutRageShockwaveVfxInBlackgate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4024); }
    }

    /// <summary>
    /// ObjectProperty: RageRunVfxInBlackgate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem RageRunVfxInBlackgate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4028); }
    }

    /// <summary>
    /// ObjectProperty: RageRunVfxInRegent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem RageRunVfxInRegent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4032); }
    }

    /// <summary>
    /// ObjectProperty: RageTurnVfxInBlackgate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem RageTurnVfxInBlackgate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4036); }
    }

    /// <summary>
    /// ObjectProperty: RageTurnVfxInRegent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem RageTurnVfxInRegent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }

    /// <summary>
    /// NameProperty: ExhaustSocketNames
    /// </summary>
    public unsafe BmSDK.FName ExhaustSocketNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }

    /// <summary>
    /// ClassProperty: CharacterBane2
    /// </summary>
    public unsafe BmSDK.Class CharacterBane2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4052); }
    }

    /// <summary>
    /// FloatProperty: BossMaxHealth
    /// </summary>
    public unsafe float BossMaxHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4056); }
    }

    /// <summary>
    /// FloatProperty: CombatRange
    /// </summary>
    public unsafe float CombatRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4060); }
    }

    /// <summary>
    /// FloatProperty: HelpPromptRange
    /// </summary>
    public unsafe float HelpPromptRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4064); }
    }

    /// <summary>
    /// FloatProperty: TakedownRange
    /// </summary>
    public unsafe float TakedownRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4068); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: MinCountToCounterNoVenom
    /// </summary>
    public InlineArray<float> MinCountToCounterNoVenom => new(3, Ptr + 4072, 4, this);

    /// <summary>
    /// FloatProperty: MinCountToCounterNoVenom
    /// </summary>
    public unsafe float MinCountToCounterNoVenom_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4072); }
    }
    /// <summary>
    /// FloatProperty: MinCountToCounterNoVenom
    /// </summary>
    public unsafe float MinCountToCounterNoVenom_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4076); }
    }
    /// <summary>
    /// FloatProperty: MinCountToCounterNoVenom
    /// </summary>
    public unsafe float MinCountToCounterNoVenom_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4080); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: MaxCountToCounterNoVenom
    /// </summary>
    public InlineArray<float> MaxCountToCounterNoVenom => new(3, Ptr + 4084, 4, this);

    /// <summary>
    /// FloatProperty: MaxCountToCounterNoVenom
    /// </summary>
    public unsafe float MaxCountToCounterNoVenom_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4084); }
    }
    /// <summary>
    /// FloatProperty: MaxCountToCounterNoVenom
    /// </summary>
    public unsafe float MaxCountToCounterNoVenom_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4088); }
    }
    /// <summary>
    /// FloatProperty: MaxCountToCounterNoVenom
    /// </summary>
    public unsafe float MaxCountToCounterNoVenom_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4092); }
    }

    /// <summary>
    /// FloatProperty: ThrowThugAttackInterval
    /// </summary>
    public unsafe float ThrowThugAttackInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4096); }
    }

    /// <summary>
    /// FloatProperty: ThrowThugAttackIntervalBlackGate
    /// </summary>
    public unsafe float ThrowThugAttackIntervalBlackGate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// FloatProperty: PunchAttackInterval
    /// </summary>
    public unsafe float PunchAttackInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4104); }
    }

    /// <summary>
    /// FloatProperty: PunchAttackIntervalOnVenom
    /// </summary>
    public unsafe float PunchAttackIntervalOnVenom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4108); }
    }

    /// <summary>
    /// FloatProperty: PunchAttackIntervalBlackGate
    /// </summary>
    public unsafe float PunchAttackIntervalBlackGate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4112); }
    }

    /// <summary>
    /// FloatProperty: ChargeAttackInterval
    /// </summary>
    public unsafe float ChargeAttackInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4116); }
    }

    /// <summary>
    /// FloatProperty: ChargeAttackIntervalOnVenom
    /// </summary>
    public unsafe float ChargeAttackIntervalOnVenom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4120); }
    }

    /// <summary>
    /// FloatProperty: ChargeAttackIntervalBlackGate
    /// </summary>
    public unsafe float ChargeAttackIntervalBlackGate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4124); }
    }

    /// <summary>
    /// FloatProperty: SpecialAttackInterval
    /// </summary>
    public unsafe float SpecialAttackInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4128); }
    }

    /// <summary>
    /// FloatProperty: SpecialAttackIntervalOnVenom
    /// </summary>
    public unsafe float SpecialAttackIntervalOnVenom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }

    /// <summary>
    /// FloatProperty: SpecialAttackIntervalBlackGate
    /// </summary>
    public unsafe float SpecialAttackIntervalBlackGate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4136); }
    }

    /// <summary>
    /// FloatProperty: BackBreakerInterval
    /// </summary>
    public unsafe float BackBreakerInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4140); }
    }

    /// <summary>
    /// FloatProperty: BackBreakerIntervalBlackGate
    /// </summary>
    public unsafe float BackBreakerIntervalBlackGate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4144); }
    }

    /// <summary>
    /// FloatProperty: IntervalFactorOnRage
    /// </summary>
    public unsafe float IntervalFactorOnRage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// FloatProperty: AnimDurationFactorOnRage
    /// </summary>
    public unsafe float AnimDurationFactorOnRage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }

    /// <summary>
    /// IntProperty: BeatdownHitsCount
    /// </summary>
    public unsafe int BeatdownHitsCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4156); }
    }

    /// <summary>
    /// IntProperty: BeatdownHitsCountBlackGate
    /// </summary>
    public unsafe int BeatdownHitsCountBlackGate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4160); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: NextAttackDelayByStun
    /// </summary>
    public InlineArray<float> NextAttackDelayByStun => new(3, Ptr + 4164, 4, this);

    /// <summary>
    /// FloatProperty: NextAttackDelayByStun
    /// </summary>
    public unsafe float NextAttackDelayByStun_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4164); }
    }
    /// <summary>
    /// FloatProperty: NextAttackDelayByStun
    /// </summary>
    public unsafe float NextAttackDelayByStun_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4168); }
    }
    /// <summary>
    /// FloatProperty: NextAttackDelayByStun
    /// </summary>
    public unsafe float NextAttackDelayByStun_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4172); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: NextAttackDelayByStunBlackGate
    /// </summary>
    public InlineArray<float> NextAttackDelayByStunBlackGate => new(3, Ptr + 4176, 4, this);

    /// <summary>
    /// FloatProperty: NextAttackDelayByStunBlackGate
    /// </summary>
    public unsafe float NextAttackDelayByStunBlackGate_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4176); }
    }
    /// <summary>
    /// FloatProperty: NextAttackDelayByStunBlackGate
    /// </summary>
    public unsafe float NextAttackDelayByStunBlackGate_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4180); }
    }
    /// <summary>
    /// FloatProperty: NextAttackDelayByStunBlackGate
    /// </summary>
    public unsafe float NextAttackDelayByStunBlackGate_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4184); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: NextAttackDelayByJump
    /// </summary>
    public InlineArray<float> NextAttackDelayByJump => new(3, Ptr + 4188, 4, this);

    /// <summary>
    /// FloatProperty: NextAttackDelayByJump
    /// </summary>
    public unsafe float NextAttackDelayByJump_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4188); }
    }
    /// <summary>
    /// FloatProperty: NextAttackDelayByJump
    /// </summary>
    public unsafe float NextAttackDelayByJump_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4192); }
    }
    /// <summary>
    /// FloatProperty: NextAttackDelayByJump
    /// </summary>
    public unsafe float NextAttackDelayByJump_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4196); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: NextAttackDelayByJumpBlackGate
    /// </summary>
    public InlineArray<float> NextAttackDelayByJumpBlackGate => new(3, Ptr + 4200, 4, this);

    /// <summary>
    /// FloatProperty: NextAttackDelayByJumpBlackGate
    /// </summary>
    public unsafe float NextAttackDelayByJumpBlackGate_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4200); }
    }
    /// <summary>
    /// FloatProperty: NextAttackDelayByJumpBlackGate
    /// </summary>
    public unsafe float NextAttackDelayByJumpBlackGate_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4204); }
    }
    /// <summary>
    /// FloatProperty: NextAttackDelayByJumpBlackGate
    /// </summary>
    public unsafe float NextAttackDelayByJumpBlackGate_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4208); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceAttackPostInterruptWithThugs
    /// </summary>
    public unsafe float TimeSinceAttackPostInterruptWithThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4212); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceAttackPostInterruptAlone
    /// </summary>
    public unsafe float TimeSinceAttackPostInterruptAlone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4216); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceAttackPostInterruptBlackGate
    /// </summary>
    public unsafe float TimeSinceAttackPostInterruptBlackGate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4220); }
    }

    /// <summary>
    /// FloatProperty: JokerTauntInterval
    /// </summary>
    public unsafe float JokerTauntInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4224); }
    }

    /// <summary>
    /// FloatProperty: VenomFadeInTime
    /// </summary>
    public unsafe float VenomFadeInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// FloatProperty: VenomFadeOutTime
    /// </summary>
    public unsafe float VenomFadeOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4232); }
    }

    /// <summary>
    /// FloatProperty: DamageDirMaxAngle
    /// </summary>
    public unsafe float DamageDirMaxAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4236); }
    }

    /// <summary>
    /// FloatProperty: ScreenCoverageToBeBlindedBySmoke
    /// </summary>
    public unsafe float ScreenCoverageToBeBlindedBySmoke
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4240); }
    }

    /// <summary>
    /// FloatProperty: DelaySuperStunHelpPromptWhenOnVenom
    /// </summary>
    public unsafe float DelaySuperStunHelpPromptWhenOnVenom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4244); }
    }

    /// <summary>
    /// FloatProperty: TimeoutEvadeHelpPromptWhenOnRage
    /// </summary>
    public unsafe float TimeoutEvadeHelpPromptWhenOnRage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4248); }
    }

    /// <summary>
    /// FloatProperty: TimeoutEvadeHelpPromptWhenOnJumpAttack
    /// </summary>
    public unsafe float TimeoutEvadeHelpPromptWhenOnJumpAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4252); }
    }

    /// <summary>
    /// IntProperty: ChargePunchBossBarkProbability
    /// </summary>
    public unsafe int ChargePunchBossBarkProbability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4256); }
    }

    /// <summary>
    /// IntProperty: JokerTauntBossBarkProbability
    /// </summary>
    public unsafe int JokerTauntBossBarkProbability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4260); }
    }

    /// <summary>
    /// IntProperty: JokerBane1MinimumTimeBeforeBark
    /// </summary>
    public unsafe int JokerBane1MinimumTimeBeforeBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4264); }
    }

    /// <summary>
    /// IntProperty: JokerBane2MinimumTimeBeforeBark
    /// </summary>
    public unsafe int JokerBane2MinimumTimeBeforeBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4268); }
    }

    /// <summary>
    /// ByteProperty: FreeCamBaneLookAtSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtSpeed FreeCamBaneLookAtSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtSpeed>(Ptr + 4272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4272); }
    }

    /// <summary>
    /// ByteProperty: HelpPromptIcon
    /// </summary>
    public unsafe BmSDK.BmGame.RHUDPrompt.EControlIcon HelpPromptIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(Ptr + 4273); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4273); }
    }

    /// <summary>
    /// ComponentProperty: FrontGaugeLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent FrontGaugeLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 4276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4276); }
    }

    /// <summary>
    /// IntProperty: AttackCountToTriggerJumpAttack
    /// </summary>
    public unsafe int AttackCountToTriggerJumpAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }

    /// <summary>
    /// IntProperty: AttackCountToTriggerRageMode
    /// </summary>
    public unsafe int AttackCountToTriggerRageMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4284); }
    }

    /// <summary>
    /// BoolProperty: bOnVenom
    /// </summary>
    public unsafe bool bOnVenom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bOnRage
    /// </summary>
    public unsafe bool bOnRage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bTargetVenomState
    /// </summary>
    public unsafe bool bTargetVenomState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bVenomFxOn
    /// </summary>
    public unsafe bool bVenomFxOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bCanFight
    /// </summary>
    public unsafe bool bCanFight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bForceCounterAttack
    /// </summary>
    public unsafe bool bForceCounterAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bIsBlackGate
    /// </summary>
    public unsafe bool bIsBlackGate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bIsFinalRageAttack
    /// </summary>
    public unsafe bool bIsFinalRageAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bValidCamera
    /// </summary>
    public unsafe bool bValidCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bDisplayDebugCamera
    /// </summary>
    public unsafe bool bDisplayDebugCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bCanUseThrowThug
    /// </summary>
    public unsafe bool bCanUseThrowThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bCanUseSpecialAttack
    /// </summary>
    public unsafe bool bCanUseSpecialAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bCanUseBackBreaker
    /// </summary>
    public unsafe bool bCanUseBackBreaker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bCanUsePunchAttack
    /// </summary>
    public unsafe bool bCanUsePunchAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bCanUseChargeAttack
    /// </summary>
    public unsafe bool bCanUseChargeAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bUseAntiWallCamera
    /// </summary>
    public unsafe bool bUseAntiWallCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bUseAutoLookAt
    /// </summary>
    public unsafe bool bUseAutoLookAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bIsPhaseComplete
    /// </summary>
    public unsafe bool bIsPhaseComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bOutputLinkActivated
    /// </summary>
    public unsafe bool bOutputLinkActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bHidePreRageChargeStomp
    /// </summary>
    public unsafe bool bHidePreRageChargeStomp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: PlayerNeedsToGoToRagdoll
    /// </summary>
    public unsafe bool PlayerNeedsToGoToRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// BoolProperty: bIsFirstChargePunch
    /// </summary>
    public unsafe bool bIsFirstChargePunch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4288); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4288); }
    }

    /// <summary>
    /// FloatProperty: MinHealthRatio
    /// </summary>
    public unsafe float MinHealthRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4292); }
    }

    /// <summary>
    /// FloatProperty: BeatdownHelpTimeout
    /// </summary>
    public unsafe float BeatdownHelpTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// FloatProperty: SuperStunHelpTimer
    /// </summary>
    public unsafe float SuperStunHelpTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// FloatProperty: EvadeHelpTimer
    /// </summary>
    public unsafe float EvadeHelpTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4304); }
    }

    /// <summary>
    /// FloatProperty: UseThrowThugTimer
    /// </summary>
    public unsafe float UseThrowThugTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4308); }
    }

    /// <summary>
    /// FloatProperty: UsePunchAttackTimer
    /// </summary>
    public unsafe float UsePunchAttackTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4312); }
    }

    /// <summary>
    /// FloatProperty: UseChargeAttackTimer
    /// </summary>
    public unsafe float UseChargeAttackTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }

    /// <summary>
    /// FloatProperty: UseSpecialAttackTimer
    /// </summary>
    public unsafe float UseSpecialAttackTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4320); }
    }

    /// <summary>
    /// FloatProperty: UseBackBreakerTimer
    /// </summary>
    public unsafe float UseBackBreakerTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4324); }
    }

    /// <summary>
    /// FloatProperty: JokerTauntTimer
    /// </summary>
    public unsafe float JokerTauntTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4328); }
    }

    /// <summary>
    /// FloatProperty: DisplaySuperStunHelpPromptTimer
    /// </summary>
    public unsafe float DisplaySuperStunHelpPromptTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4332); }
    }

    /// <summary>
    /// IntProperty: FightPhase
    /// </summary>
    public unsafe int FightPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4336); }
    }

    /// <summary>
    /// IntProperty: hitCountBeforeCounter
    /// </summary>
    public unsafe int hitCountBeforeCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4340); }
    }

    /// <summary>
    /// IntProperty: hitThresholdBeforeCounter
    /// </summary>
    public unsafe int hitThresholdBeforeCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4344); }
    }

    /// <summary>
    /// FloatProperty: MinAttackDelayWithThugs
    /// </summary>
    public unsafe float MinAttackDelayWithThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4348); }
    }

    /// <summary>
    /// FloatProperty: MinAttackDelayAlone
    /// </summary>
    public unsafe float MinAttackDelayAlone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4352); }
    }

    /// <summary>
    /// IntProperty: TakedownFrontIndex
    /// </summary>
    public unsafe int TakedownFrontIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4356); }
    }

    /// <summary>
    /// FloatProperty: VenomFadeInTimer
    /// </summary>
    public unsafe float VenomFadeInTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4360); }
    }

    /// <summary>
    /// FloatProperty: VenomFadeOutTimer
    /// </summary>
    public unsafe float VenomFadeOutTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4364); }
    }

    /// <summary>
    /// FloatProperty: CameraBlendOutTime
    /// </summary>
    public unsafe float CameraBlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// NameProperty: LastBoostCameraAnim
    /// </summary>
    public unsafe BmSDK.FName LastBoostCameraAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4372); }
    }

    /// <summary>
    /// NameProperty: MovementStance
    /// </summary>
    public unsafe BmSDK.FName MovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4380); }
    }

    /// <summary>
    /// NameProperty: BeatdownFinalHitAnimName
    /// </summary>
    public unsafe BmSDK.FName BeatdownFinalHitAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4388); }
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 4396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4396); }
    }

    /// <summary>
    /// ObjectProperty: BossCombatAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BossCombatAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4400); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCombatAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerCombatAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4404); }
    }

    /// <summary>
    /// ObjectProperty: CameraCombatAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CameraCombatAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4408); }
    }

    /// <summary>
    /// ObjectProperty: VenomSpecificAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VenomSpecificAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4412); }
    }

    /// <summary>
    /// ObjectProperty: BaneThrowAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BaneThrowAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4416); }
    }

    /// <summary>
    /// ObjectProperty: ThugThrowAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ThugThrowAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4420); }
    }

    /// <summary>
    /// ObjectProperty: ImpactCue_BodyOnVenom
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactCue_BodyOnVenom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4424); }
    }

    /// <summary>
    /// ObjectProperty: ImpactCue_HeadOnVenom
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactCue_HeadOnVenom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4428); }
    }

    /// <summary>
    /// ObjectProperty: ImpactCue_BlockOnVenom
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactCue_BlockOnVenom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4432); }
    }

    /// <summary>
    /// ObjectProperty: ImpactCue_ThrownThug
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactCue_ThrownThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4436); }
    }

    /// <summary>
    /// ObjectProperty: BaneSfx_VenomOut
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BaneSfx_VenomOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4440); }
    }

    /// <summary>
    /// ObjectProperty: BaneSfx_PlayVenomIdle
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BaneSfx_PlayVenomIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4444); }
    }

    /// <summary>
    /// ObjectProperty: BaneSfx_StopVenomIdle
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BaneSfx_StopVenomIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4448); }
    }

    /// <summary>
    /// ObjectProperty: AudioSwitch_VenomOn
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName AudioSwitch_VenomOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 4452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4452); }
    }

    /// <summary>
    /// ObjectProperty: AudioSwitch_VenomOff
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName AudioSwitch_VenomOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 4456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4456); }
    }

    /// <summary>
    /// ObjectProperty: HitImpactNoVenom
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HitImpactNoVenom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4460); }
    }

    /// <summary>
    /// ObjectProperty: HitImpactOnVenom
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HitImpactOnVenom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4464); }
    }

    /// <summary>
    /// IntProperty: MinHealthForPhase
    /// </summary>
    public unsafe int MinHealthForPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4468); }
    }

    /// <summary>
    /// ObjectProperty: BaneBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.MBMBehaviour_CombatBaneBase BaneBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MBMBehaviour_CombatBaneBase>(Ptr + 4472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4472); }
    }

    /// <summary>
    /// IntProperty: AttackCount
    /// </summary>
    public unsafe int AttackCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4476); }
    }

    /// <summary>
    /// ObjectProperty: BaneChestMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BaneChestMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }

    /// <summary>
    /// ObjectProperty: BanePipesMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BanePipesMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4484); }
    }

    /// <summary>
    /// ObjectProperty: BaneEyesMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BaneEyesMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4488); }
    }

    /// <summary>
    /// ObjectProperty: BaneStuffMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BaneStuffMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4492); }
    }

    /// <summary>
    /// ObjectProperty: DefaultXRayPipesMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant DefaultXRayPipesMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4496); }
    }

    /// <summary>
    /// ObjectProperty: DefaultXRayBoneMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant DefaultXRayBoneMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4500); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_BlindedBySmokePellet
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_BlindedBySmokePellet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4504); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_ChargePunch
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_ChargePunch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4508); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_DodgeBMGadget
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_DodgeBMGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4512); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_FightStartStage1
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_FightStartStage1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4516); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_FightStartStage2
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_FightStartStage2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4520); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_Grab
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_Grab
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4524); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_VEN_AttackThug
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_VEN_AttackThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4528); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_VEN_BackBreaker
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_VEN_BackBreaker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4532); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_VEN_BatclawThrow
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_VEN_BatclawThrow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4536); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_VEN_BlindedbySmokePellet
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_VEN_BlindedbySmokePellet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4540); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_VEN_Button
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_VEN_Button
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4544); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_VEN_ChargePunch
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_VEN_ChargePunch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4548); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_VEN_Grab
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_VEN_Grab
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4552); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_VEN_Inject
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_VEN_Inject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4556); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_VEN_RageStart
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_VEN_RageStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_VEN_Raging
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_VEN_Raging
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4564); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_VEN_JumpAttack
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_VEN_JumpAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4568); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_ThrowThug
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_ThrowThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4572); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_VEN_WallThrowBM
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_VEN_WallThrowBM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4576); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_B1_WallThrowBM
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_B1_WallThrowBM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4580); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_Joker_B1_BlindedBySmokePellet
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_Joker_B1_BlindedBySmokePellet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4584); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_Joker_B1_KOThug
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_Joker_B1_KOThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4588); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_Joker_B1_ThrowsThug
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_Joker_B1_ThrowsThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4592); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_Joker_BM_GadgetFail
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_Joker_BM_GadgetFail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4596); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_Joker_BM_GadgetSuccess
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_Joker_BM_GadgetSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4600); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_Joker_BM_Thrown
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_Joker_BM_Thrown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4604); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_Joker_JokerIntro
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_Joker_JokerIntro
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4608); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_Joker_SummonThugs
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_Joker_SummonThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4612); }
    }

    /// <summary>
    /// ObjectProperty: Bane1Barks_Joker_Taunts
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane1Barks_Joker_Taunts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4616); }
    }

    /// <summary>
    /// ObjectProperty: Bane2Barks_Joker_ChairAlmostFull
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane2Barks_Joker_ChairAlmostFull
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4620); }
    }

    /// <summary>
    /// ObjectProperty: Bane2Barks_Joker_ChairHalfCharged
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane2Barks_Joker_ChairHalfCharged
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4624); }
    }

    /// <summary>
    /// ObjectProperty: Bane2Barks_Joker_FightStart
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane2Barks_Joker_FightStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4628); }
    }

    /// <summary>
    /// ObjectProperty: Bane2Barks_Joker_Taunts
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane2Barks_Joker_Taunts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4632); }
    }

    /// <summary>
    /// ObjectProperty: Bane2Barks_Joker_VEN_RageStart
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane2Barks_Joker_VEN_RageStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4636); }
    }

    /// <summary>
    /// ObjectProperty: Bane2Barks_Joker_VEN_Raging
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane2Barks_Joker_VEN_Raging
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4640); }
    }

    /// <summary>
    /// ObjectProperty: Bane2Episodic_FightStart
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine Bane2Episodic_FightStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4644); }
    }

    /// <summary>
    /// ObjectProperty: JokerActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor JokerActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4648); }
    }

    /// <summary>
    /// FloatProperty: JokerBossBarkTimer
    /// </summary>
    public unsafe float JokerBossBarkTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4652); }
    }

    /// <summary>
    /// ObjectProperty: ThugToThrow
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain ThugToThrow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 4656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4656); }
    }
}
