#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: MPawnDroneBase<br/>
/// (size = 4388)
/// (flags = 144703671)
/// </summary>
public partial class MPawnDroneBase : BmSDK.BmGame.MPawnFlying, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MPawnDroneBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnDroneBase.
    /// </summary>
    public static MPawnDroneBase DefaultObject => (MPawnDroneBase)StaticClass().DefaultObject;

    internal MPawnDroneBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnDroneBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnDroneBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnDroneBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnDroneBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnDroneBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnDroneBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnDroneBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnDroneBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnDroneBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ChangeGameSpeed;
    /// <summary>
    /// Function: ChangeGameSpeed
    /// </summary>
    public unsafe virtual void ChangeGameSpeed(float NewDesiredGameSpeed, float TransitionDuration = default, float Duration = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeGameSpeed, "BmGame.MPawnDroneBase.ChangeGameSpeed");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDesiredGameSpeed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDuration, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopForwardMovement;
    /// <summary>
    /// Function: StopForwardMovement
    /// </summary>
    public unsafe virtual void StopForwardMovement()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopForwardMovement, "BmGame.MPawnDroneBase.StopForwardMovement");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartForwardMovementAnim;
    /// <summary>
    /// Function: StartForwardMovementAnim
    /// </summary>
    public unsafe virtual void StartForwardMovementAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartForwardMovementAnim, "BmGame.MPawnDroneBase.StartForwardMovementAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveSLControlToCode;
    /// <summary>
    /// Function: GiveSLControlToCode
    /// </summary>
    public unsafe virtual void GiveSLControlToCode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveSLControlToCode, "BmGame.MPawnDroneBase.GiveSLControlToCode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveSLControlToAnimation;
    /// <summary>
    /// Function: GiveSLControlToAnimation
    /// </summary>
    public unsafe virtual void GiveSLControlToAnimation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveSLControlToAnimation, "BmGame.MPawnDroneBase.GiveSLControlToAnimation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerAudioPropellerSFX;
    /// <summary>
    /// Function: TriggerAudioPropellerSFX
    /// </summary>
    public unsafe virtual void TriggerAudioPropellerSFX(int AudioIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerAudioPropellerSFX, "BmGame.MPawnDroneBase.TriggerAudioPropellerSFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateAudioComponent;
    /// <summary>
    /// Function: UpdateAudioComponent
    /// </summary>
    public unsafe virtual void UpdateAudioComponent(BmSDK.BmGame.MPawnDroneBase.DroneAudioParameters AudioParam, int ParamValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAudioComponent, "BmGame.MPawnDroneBase.UpdateAudioComponent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioParam, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerAudioComponent;
    /// <summary>
    /// Function: TriggerAudioComponent
    /// </summary>
    public unsafe virtual void TriggerAudioComponent(bool TurnOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerAudioComponent, "BmGame.MPawnDroneBase.TriggerAudioComponent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SimulateTrajectory;
    /// <summary>
    /// Function: SimulateTrajectory
    /// </summary>
    public unsafe virtual void SimulateTrajectory()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimulateTrajectory, "BmGame.MPawnDroneBase.SimulateTrajectory");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopSimulation;
    /// <summary>
    /// Function: StopSimulation
    /// </summary>
    public unsafe virtual void StopSimulation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSimulation, "BmGame.MPawnDroneBase.StopSimulation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetProjectileClass;
    /// <summary>
    /// Function: GetProjectileClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetProjectileClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProjectileClass, "BmGame.MPawnDroneBase.GetProjectileClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SimulateGlideKick;
    /// <summary>
    /// Function: SimulateGlideKick
    /// </summary>
    public unsafe virtual void SimulateGlideKick(System.Numerics.Vector3 ThrowVector)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimulateGlideKick, "BmGame.MPawnDroneBase.SimulateGlideKick");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowVector, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartGlideKick;
    /// <summary>
    /// Function: StartGlideKick
    /// </summary>
    public unsafe virtual void StartGlideKick(System.Numerics.Vector3 ThrowVector)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGlideKick, "BmGame.MPawnDroneBase.StartGlideKick");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowVector, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartHitByGlue;
    /// <summary>
    /// Function: StartHitByGlue
    /// </summary>
    public unsafe virtual void StartHitByGlue(System.Numerics.Vector3 ThrowVector)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartHitByGlue, "BmGame.MPawnDroneBase.StartHitByGlue");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowVector, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThrowDrone;
    /// <summary>
    /// Function: ThrowDrone
    /// </summary>
    public unsafe virtual void ThrowDrone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowDrone, "BmGame.MPawnDroneBase.ThrowDrone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StunnedDroneOnFloor;
    /// <summary>
    /// Function: StunnedDroneOnFloor
    /// </summary>
    public unsafe virtual void StunnedDroneOnFloor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StunnedDroneOnFloor, "BmGame.MPawnDroneBase.StunnedDroneOnFloor");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReEnableDrone;
    /// <summary>
    /// Function: ReEnableDrone
    /// </summary>
    public unsafe virtual void ReEnableDrone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReEnableDrone, "BmGame.MPawnDroneBase.ReEnableDrone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableDrone;
    /// <summary>
    /// Function: DisableDrone
    /// </summary>
    public unsafe virtual void DisableDrone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableDrone, "BmGame.MPawnDroneBase.DisableDrone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBestThrow;
    /// <summary>
    /// Function: GetBestThrow
    /// </summary>
    public unsafe virtual bool GetBestThrow(System.Numerics.Vector3 TargetLocation, out System.Numerics.Vector3 BestThrowVector)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestThrow, "BmGame.MPawnDroneBase.GetBestThrow");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestThrowVector);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestThrowVector, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BestThrowVector = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_SetUpSimulation;
    /// <summary>
    /// Function: SetUpSimulation
    /// </summary>
    public unsafe virtual void SetUpSimulation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetUpSimulation, "BmGame.MPawnDroneBase.SetUpSimulation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StunDrone;
    /// <summary>
    /// Function: StunDrone
    /// </summary>
    public unsafe virtual void StunDrone(System.Numerics.Vector3 StunDir = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StunDrone, "BmGame.MPawnDroneBase.StunDrone");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResumeVelocity;
    /// <summary>
    /// Function: ResumeVelocity
    /// </summary>
    public unsafe virtual void ResumeVelocity()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResumeVelocity, "BmGame.MPawnDroneBase.ResumeVelocity");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReduceVelocity;
    /// <summary>
    /// Function: ReduceVelocity
    /// </summary>
    public unsafe virtual void ReduceVelocity(float VelocityFactor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReduceVelocity, "BmGame.MPawnDroneBase.ReduceVelocity");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VelocityFactor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopMovement;
    /// <summary>
    /// Function: StopMovement
    /// </summary>
    public unsafe virtual void StopMovement()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopMovement, "BmGame.MPawnDroneBase.StopMovement");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnDroneCoordinator;
    /// <summary>
    /// Function: SpawnDroneCoordinator
    /// </summary>
    public unsafe virtual void SpawnDroneCoordinator(BmSDK.BmGame.RPawnCombat VillainPawn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDroneCoordinator, "BmGame.MPawnDroneBase.SpawnDroneCoordinator");
        byte* paramsPtr = stackalloc byte[200];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyCantBeRestored;
    /// <summary>
    /// Function: NotifyCantBeRestored
    /// </summary>
    public unsafe virtual void NotifyCantBeRestored()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyCantBeRestored, "BmGame.MPawnDroneBase.NotifyCantBeRestored");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnBulletFX;
    /// <summary>
    /// Function: SpawnBulletFX
    /// </summary>
    public unsafe virtual void SpawnBulletFX(System.Numerics.Vector3 StartLoc, BmSDK.Engine.Actor.FImpactInfo Impact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBulletFX, "BmGame.MPawnDroneBase.SpawnBulletFX");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impact, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetImpactMaterial;
    /// <summary>
    /// Function: GetImpactMaterial
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPhysicalMaterialProperty GetImpactMaterial(BmSDK.Engine.Actor.FImpactInfo Impact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetImpactMaterial, "BmGame.MPawnDroneBase.GetImpactMaterial");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impact, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPhysicalMaterialProperty>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_DoShotFX;
    /// <summary>
    /// Function: DoShotFX
    /// </summary>
    public unsafe virtual void DoShotFX(BmSDK.BmGame.RPawnCombat TargetPawn, bool bForceMiss)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoShotFX, "BmGame.MPawnDroneBase.DoShotFX");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceMiss, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerDamageFX;
    /// <summary>
    /// Function: TriggerDamageFX
    /// </summary>
    public unsafe virtual void TriggerDamageFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerDamageFX, "BmGame.MPawnDroneBase.TriggerDamageFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRandDeviance;
    /// <summary>
    /// Function: GetRandDeviance
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRandDeviance(BmSDK.Rotator Heading)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandDeviance, "BmGame.MPawnDroneBase.GetRandDeviance");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heading, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsPotentialThreat;
    /// <summary>
    /// Function: IsPotentialThreat
    /// </summary>
    public unsafe virtual bool IsPotentialThreat(BmSDK.BmGame.RPawnCombat Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPotentialThreat, "BmGame.MPawnDroneBase.IsPotentialThreat");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TriggerCasFoundAlert;
    /// <summary>
    /// Function: TriggerCasFoundAlert
    /// </summary>
    public unsafe virtual void TriggerCasFoundAlert()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCasFoundAlert, "BmGame.MPawnDroneBase.TriggerCasFoundAlert");
        byte* paramsPtr = stackalloc byte[16];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.MPawnDroneBase.Tick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitByJammerGadgetCharge;
    /// <summary>
    /// Function: HitByJammerGadgetCharge
    /// </summary>
    public unsafe virtual void HitByJammerGadgetCharge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByJammerGadgetCharge, "BmGame.MPawnDroneBase.HitByJammerGadgetCharge");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeJammed;
    /// <summary>
    /// Function: CanBeJammed
    /// </summary>
    public unsafe virtual bool CanBeJammed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeJammed, "BmGame.MPawnDroneBase.CanBeJammed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearTarget;
    /// <summary>
    /// Function: ClearTarget
    /// </summary>
    public unsafe virtual void ClearTarget(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearTarget, "BmGame.MPawnDroneBase.ClearTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPotentialTargets;
    /// <summary>
    /// Function: ClearPotentialTargets
    /// </summary>
    public unsafe virtual void ClearPotentialTargets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPotentialTargets, "BmGame.MPawnDroneBase.ClearPotentialTargets");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandlePotentialTarget;
    /// <summary>
    /// Function: HandlePotentialTarget
    /// </summary>
    public unsafe virtual void HandlePotentialTarget(BmSDK.BmGame.RPawnCombat Target, bool IsPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlePotentialTarget, "BmGame.MPawnDroneBase.HandlePotentialTarget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnSawVillain;
    /// <summary>
    /// Function: PawnSawVillain
    /// </summary>
    public unsafe virtual void PawnSawVillain(BmSDK.BmGame.RPawnVillain SeenPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnSawVillain, "BmGame.MPawnDroneBase.PawnSawVillain");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeenPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnSawPlayer;
    /// <summary>
    /// Function: PawnSawPlayer
    /// </summary>
    public unsafe override void PawnSawPlayer(BmSDK.BmGame.AlertInstance.VisibilityCategory Visibility)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnSawPlayer, "BmGame.MPawnDroneBase.PawnSawPlayer");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Visibility, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.MPawnDroneBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPawnViewLocation;
    /// <summary>
    /// Function: GetPawnViewLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetPawnViewLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnViewLocation, "BmGame.MPawnDroneBase.GetPawnViewLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: DroneAudioParameters
    /// </summary>
    public enum DroneAudioParameters : byte
    {
        DroneAudio_Damage = 0,
        DroneAudio_Falling = 1,
        DroneAudio_Pitch = 2,
        DroneAudio_Roll = 3,
        DroneAudio_Wobble = 4,
        DroneAudio_MAX = 5,
    }

    /// <summary>
    /// Enum: DroneHighlightType
    /// </summary>
    public enum DroneHighlightType : byte
    {
        DHT_STANDARD = 0,
        DHT_SCANNABLE = 1,
        DHT_SECONDARY = 2,
        DHT_CONTROL = 3,
        DHT_MAX = 4,
    }

    /// <summary>
    /// Enum: FlyingDirection
    /// </summary>
    public enum FlyingDirection : byte
    {
        FD_LEFT = 0,
        FD_RIGHT = 1,
        FD_UP = 2,
        FD_DOWN = 3,
        FD_FRONT = 4,
        FD_BACK = 5,
        FD_MAX = 6,
    }

    /// <summary>
    /// Enum: FlyingAttackMode
    /// </summary>
    public enum FlyingAttackMode : byte
    {
        FAM_NOT_SHOOTING = 0,
        FAM_WARM_UP_TAZER = 1,
        FAM_FIRING_TAZER = 2,
        FAM_COOLDOWN_TAZER = 3,
        FAM_MAX = 4,
    }

    /// <summary>
    /// ComponentProperty: SpotLightComponent
    /// </summary>
    public unsafe BmSDK.Engine.SpotLightComponent SpotLightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpotLightComponent>(Ptr + 4056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4056); }
    }

    /// <summary>
    /// ComponentProperty: SearchLightMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent SearchLightMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 4060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4060); }
    }

    /// <summary>
    /// ComponentProperty: LensFlareFX
    /// </summary>
    public unsafe BmSDK.Engine.LensFlareComponent LensFlareFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LensFlareComponent>(Ptr + 4064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4064); }
    }

    /// <summary>
    /// FloatProperty: TargetReachTolerance
    /// </summary>
    public unsafe float TargetReachTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4068); }
    }

    /// <summary>
    /// ObjectProperty: SearchLightMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SearchLightMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4072); }
    }

    /// <summary>
    /// ObjectProperty: GunHorBoneController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone GunHorBoneController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 4076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4076); }
    }

    /// <summary>
    /// ObjectProperty: GunVerBoneController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone GunVerBoneController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 4080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4080); }
    }

    /// <summary>
    /// FloatProperty: FrequencyTriangulationTime
    /// </summary>
    public unsafe float FrequencyTriangulationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4084); }
    }

    /// <summary>
    /// BoolProperty: bCantBeRestored
    /// </summary>
    public unsafe bool bCantBeRestored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4088); }
    }

    /// <summary>
    /// BoolProperty: bDamageFxActive
    /// </summary>
    public unsafe bool bDamageFxActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4088); }
    }

    /// <summary>
    /// BoolProperty: mHasExplosiveCharge
    /// </summary>
    public unsafe bool mHasExplosiveCharge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4088); }
    }

    /// <summary>
    /// BoolProperty: ShootFromLeftGun
    /// </summary>
    public unsafe bool ShootFromLeftGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4088); }
    }

    /// <summary>
    /// BoolProperty: bIsAttackingPlayer
    /// </summary>
    public unsafe bool bIsAttackingPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4088); }
    }

    /// <summary>
    /// BoolProperty: mSearchLightControlToAnimation
    /// </summary>
    public unsafe bool mSearchLightControlToAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4088); }
    }

    /// <summary>
    /// BoolProperty: bDisplayingSimulatedArc
    /// </summary>
    public unsafe bool bDisplayingSimulatedArc
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4088); }
    }

    /// <summary>
    /// BoolProperty: mIsAirborneAttackVictim
    /// </summary>
    public unsafe bool mIsAirborneAttackVictim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4088); }
    }

    /// <summary>
    /// BoolProperty: mIsShotByVillain
    /// </summary>
    public unsafe bool mIsShotByVillain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4088); }
    }

    /// <summary>
    /// BoolProperty: IsScanningJammed
    /// </summary>
    public unsafe bool IsScanningJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4088); }
    }

    /// <summary>
    /// ObjectProperty: MDroneConfig
    /// </summary>
    public unsafe BmSDK.BmGame.MDroneConfig MDroneConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDroneConfig>(Ptr + 4092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4092); }
    }

    /// <summary>
    /// StructProperty: DroneWeaponOverlay
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId DroneWeaponOverlay
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 4096);

    /// <summary>
    /// ClassProperty: ProjectileClass
    /// </summary>
    public unsafe BmSDK.Class ProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4104); }
    }

    /// <summary>
    /// NameProperty: LeftGunSocketName
    /// </summary>
    public unsafe BmSDK.FName LeftGunSocketName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4108); }
    }

    /// <summary>
    /// NameProperty: RightGunSocketName
    /// </summary>
    public unsafe BmSDK.FName RightGunSocketName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4116); }
    }

    /// <summary>
    /// ObjectProperty: FireSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4124); }
    }

    /// <summary>
    /// ObjectProperty: FireFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem FireFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4128); }
    }

    /// <summary>
    /// ObjectProperty: DamageFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DamageFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }

    /// <summary>
    /// IntProperty: WalkingMissCount
    /// </summary>
    public unsafe int WalkingMissCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4136); }
    }

    /// <summary>
    /// IntProperty: RunningMissCount
    /// </summary>
    public unsafe int RunningMissCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4140); }
    }

    /// <summary>
    /// FloatProperty: HitShotMaxRange
    /// </summary>
    public unsafe float HitShotMaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4144); }
    }

    /// <summary>
    /// FloatProperty: MissShotMinRange
    /// </summary>
    public unsafe float MissShotMinRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// FloatProperty: MissShotMaxRange
    /// </summary>
    public unsafe float MissShotMaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }

    /// <summary>
    /// IntProperty: DamageHitBySecByThug
    /// </summary>
    public unsafe int DamageHitBySecByThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4156); }
    }

    /// <summary>
    /// IntProperty: DamageFxHealthThreshold
    /// </summary>
    public unsafe int DamageFxHealthThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4160); }
    }

    /// <summary>
    /// FloatProperty: DelayToHitScannedThreat
    /// </summary>
    public unsafe float DelayToHitScannedThreat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4164); }
    }

    /// <summary>
    /// ArrayProperty: AudioPropellerSFX
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkEvent> AudioPropellerSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkEvent>>(Ptr + 4168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4168); }
    }

    /// <summary>
    /// FloatProperty: DesiredLeftRightRotWeight
    /// </summary>
    public unsafe float DesiredLeftRightRotWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4180); }
    }

    /// <summary>
    /// FloatProperty: DesiredUpDownRotWeight
    /// </summary>
    public unsafe float DesiredUpDownRotWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4184); }
    }

    /// <summary>
    /// FloatProperty: DesiredFrontBackRotWeight
    /// </summary>
    public unsafe float DesiredFrontBackRotWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4188); }
    }

    /// <summary>
    /// FloatProperty: DirectionalAnimBlendRate
    /// </summary>
    public unsafe float DirectionalAnimBlendRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4192); }
    }

    /// <summary>
    /// ByteProperty: DroneHLType
    /// </summary>
    public unsafe BmSDK.BmGame.MPawnDroneBase.DroneHighlightType DroneHLType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MPawnDroneBase.DroneHighlightType>(Ptr + 4196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4196); }
    }

    /// <summary>
    /// ObjectProperty: TracerFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem TracerFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4200); }
    }

    /// <summary>
    /// ObjectProperty: ImpactFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ImpactFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4204); }
    }

    /// <summary>
    /// ObjectProperty: mScanFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem mScanFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4208); }
    }

    /// <summary>
    /// ObjectProperty: mDetectiveTraceFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem mDetectiveTraceFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4212); }
    }

    /// <summary>
    /// ObjectProperty: TazerWarningAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TazerWarningAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4216); }
    }

    /// <summary>
    /// ObjectProperty: DamageAudioFxEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DamageAudioFxEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4220); }
    }

    /// <summary>
    /// ObjectProperty: mScanAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent mScanAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4224); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlashComponent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MuzzleFlashComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// ComponentProperty: mScanPSComponent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent mScanPSComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4232); }
    }

    /// <summary>
    /// ObjectProperty: mFrontLightFX_Idle
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem mFrontLightFX_Idle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4236); }
    }

    /// <summary>
    /// ObjectProperty: mFrontLightFX_Aware
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem mFrontLightFX_Aware
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4240); }
    }

    /// <summary>
    /// ObjectProperty: mFrontLightFX_Alert
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem mFrontLightFX_Alert
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4244); }
    }

    /// <summary>
    /// ComponentProperty: mCurrentFrontLightComponent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent mCurrentFrontLightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4248); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 4252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4252); }
    }

    /// <summary>
    /// FloatProperty: LastSniperEventTime
    /// </summary>
    public unsafe float LastSniperEventTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4256); }
    }

    /// <summary>
    /// IntProperty: GunShotCount
    /// </summary>
    public unsafe int GunShotCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4260); }
    }

    /// <summary>
    /// FloatProperty: GunShotTime
    /// </summary>
    public unsafe float GunShotTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4264); }
    }

    /// <summary>
    /// FloatProperty: GunDamage
    /// </summary>
    public unsafe float GunDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4268); }
    }

    /// <summary>
    /// FloatProperty: GunWarmUpTime
    /// </summary>
    public unsafe float GunWarmUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4272); }
    }

    /// <summary>
    /// FloatProperty: GunCoolDownTime
    /// </summary>
    public unsafe float GunCoolDownTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4276); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }

    /// <summary>
    /// FloatProperty: mFlashLightDelay
    /// </summary>
    public unsafe float mFlashLightDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4284); }
    }

    /// <summary>
    /// FloatProperty: mAlertedReactionMaxDistance
    /// </summary>
    public unsafe float mAlertedReactionMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4288); }
    }

    /// <summary>
    /// FloatProperty: mAlertedPerimeterMaxDistance
    /// </summary>
    public unsafe float mAlertedPerimeterMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4292); }
    }

    /// <summary>
    /// ArrayProperty: mPotentialTargetList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> mPotentialTargetList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// ObjectProperty: mTargetScanMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface mTargetScanMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 4308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4308); }
    }

    /// <summary>
    /// StructProperty: mRedirectDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mRedirectDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4312);

    /// <summary>
    /// StructProperty: mRedirectToFloorPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mRedirectToFloorPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4324);

    /// <summary>
    /// ComponentProperty: BrokenMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent BrokenMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 4336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4336); }
    }

    /// <summary>
    /// ObjectProperty: mSimulatedProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.MProjectileBase mSimulatedProjectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MProjectileBase>(Ptr + 4340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4340); }
    }

    /// <summary>
    /// StructProperty: mSimulationStart
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mSimulationStart
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4344);

    /// <summary>
    /// StructProperty: mSimulationDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mSimulationDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4356);

    /// <summary>
    /// ObjectProperty: mActualProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.MProjectileBase mActualProjectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MProjectileBase>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// FloatProperty: mMaximumThrowSpeed
    /// </summary>
    public unsafe float mMaximumThrowSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4372); }
    }

    /// <summary>
    /// FloatProperty: mActualThrowSpeed
    /// </summary>
    public unsafe float mActualThrowSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4376); }
    }

    /// <summary>
    /// FloatProperty: mStartXYPct
    /// </summary>
    public unsafe float mStartXYPct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4380); }
    }

    /// <summary>
    /// ObjectProperty: PropellerMC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant PropellerMC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4384); }
    }
}
