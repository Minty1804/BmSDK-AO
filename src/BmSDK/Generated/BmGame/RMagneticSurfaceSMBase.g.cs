#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMagneticSurfaceSMBase<br/>
/// (size = 672)
/// (flags = 142606482)
/// </summary>
public partial class RMagneticSurfaceSMBase : BmSDK.Engine.Actor, BmSDK.BmGame.RMatineeController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMagneticSurfaceSMBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RMagneticSurfaceSMBase.
    /// </summary>
    public static RMagneticSurfaceSMBase DefaultObject => (RMagneticSurfaceSMBase)StaticClass().DefaultObject;

    internal RMagneticSurfaceSMBase() { }

    /// <summary>
    /// Constructs a new RMagneticSurfaceSMBase
    /// </summary>
    public RMagneticSurfaceSMBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMagneticSurfaceSMBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticSurfaceSMBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_EmergencyStop;
    /// <summary>
    /// Function: EmergencyStop
    /// </summary>
    public unsafe virtual bool EmergencyStop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EmergencyStop, "BmGame.RMagneticSurfaceSMBase.EmergencyStop");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetFXLocation;
    /// <summary>
    /// Function: SetFXLocation
    /// </summary>
    public unsafe virtual void SetFXLocation(BmSDK.Engine.PrimitiveComponent MotorComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFXLocation, "BmGame.RMagneticSurfaceSMBase.SetFXLocation");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MotorComp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBlockingPlayerInteraction;
    /// <summary>
    /// Function: IsBlockingPlayerInteraction
    /// </summary>
    public unsafe virtual bool IsBlockingPlayerInteraction(BmSDK.BmGame.RPawnPlayer Player, bool bDebugDraw = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBlockingPlayerInteraction, "BmGame.RMagneticSurfaceSMBase.IsBlockingPlayerInteraction");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UnlinkToActor;
    /// <summary>
    /// Function: UnlinkToActor
    /// </summary>
    public unsafe override bool UnlinkToActor(BmSDK.Engine.Actor LinkTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlinkToActor, "BmGame.RMagneticSurfaceSMBase.UnlinkToActor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_LinkToActor;
    /// <summary>
    /// Function: LinkToActor
    /// </summary>
    public unsafe override bool LinkToActor(BmSDK.Engine.Actor LinkTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LinkToActor, "BmGame.RMagneticSurfaceSMBase.LinkToActor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetClosestPoint;
    /// <summary>
    /// Function: GetClosestPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetClosestPoint(System.Numerics.Vector3 TestPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestPoint, "BmGame.RMagneticSurfaceSMBase.GetClosestPoint");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetInvestigateHighlighted;
    /// <summary>
    /// Function: SetInvestigateHighlighted
    /// </summary>
    public unsafe override void SetInvestigateHighlighted(BmSDK.Engine.MaterialInstanceConstant highMat, bool On)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvestigateHighlighted, "BmGame.RMagneticSurfaceSMBase.SetInvestigateHighlighted");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(highMat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RMagneticSurfaceSMBase.Tick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StressTest;
    /// <summary>
    /// Function: StressTest
    /// </summary>
    public unsafe virtual void StressTest()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StressTest, "BmGame.RMagneticSurfaceSMBase.StressTest");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_converge;
    /// <summary>
    /// Function: converge
    /// </summary>
    public unsafe virtual void converge(out float Value, float Target, float Speed, float tolerance = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_converge, "BmGame.RMagneticSurfaceSMBase.converge");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(tolerance, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_HitWhileDeactivated;
    /// <summary>
    /// Function: HitWhileDeactivated
    /// </summary>
    public unsafe virtual void HitWhileDeactivated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitWhileDeactivated, "BmGame.RMagneticSurfaceSMBase.HitWhileDeactivated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Recover;
    /// <summary>
    /// Function: Recover
    /// </summary>
    public unsafe virtual void Recover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Recover, "BmGame.RMagneticSurfaceSMBase.Recover");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRecoveryTime;
    /// <summary>
    /// Function: SetRecoveryTime
    /// </summary>
    public unsafe virtual void SetRecoveryTime(float RecoveryTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRecoveryTime, "BmGame.RMagneticSurfaceSMBase.SetRecoveryTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecoveryTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMagStr;
    /// <summary>
    /// Function: SetMagStr
    /// </summary>
    public unsafe virtual void SetMagStr(float NewStr, bool bInitialFrame, BmSDK.BmGame.RPawnPlayer Player, BmSDK.BmGame.RMagneticSurfaceSMBase CallFromMaster = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMagStr, "BmGame.RMagneticSurfaceSMBase.SetMagStr");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStr, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInitialFrame, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CallFromMaster, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopMotor;
    /// <summary>
    /// Function: StopMotor
    /// </summary>
    public unsafe virtual void StopMotor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopMotor, "BmGame.RMagneticSurfaceSMBase.StopMotor");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayMotorDown;
    /// <summary>
    /// Function: PlayMotorDown
    /// </summary>
    public unsafe virtual void PlayMotorDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayMotorDown, "BmGame.RMagneticSurfaceSMBase.PlayMotorDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayMotorUp;
    /// <summary>
    /// Function: PlayMotorUp
    /// </summary>
    public unsafe virtual void PlayMotorUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayMotorUp, "BmGame.RMagneticSurfaceSMBase.PlayMotorUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInfluencedVillains;
    /// <summary>
    /// Function: GetInfluencedVillains
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RPawnVillain> GetInfluencedVillains(BmSDK.BmGame.RPawnPlayer Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInfluencedVillains, "BmGame.RMagneticSurfaceSMBase.GetInfluencedVillains");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBeamEffectsTargets;
    /// <summary>
    /// Function: GetBeamEffectsTargets
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.Engine.Actor> GetBeamEffectsTargets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBeamEffectsTargets, "BmGame.RMagneticSurfaceSMBase.GetBeamEffectsTargets");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInfluencedDynamicObjects;
    /// <summary>
    /// Function: GetInfluencedDynamicObjects
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RMagneticBlastInterface> GetInfluencedDynamicObjects(bool bInitialFrame)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInfluencedDynamicObjects, "BmGame.RMagneticSurfaceSMBase.GetInfluencedDynamicObjects");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInitialFrame, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RMagneticBlastInterface>>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetAccumulatedMagStr;
    /// <summary>
    /// Function: GetAccumulatedMagStr
    /// </summary>
    public unsafe virtual float GetAccumulatedMagStr()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAccumulatedMagStr, "BmGame.RMagneticSurfaceSMBase.GetAccumulatedMagStr");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMasterGenerator;
    /// <summary>
    /// Function: GetMasterGenerator
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RMagneticSurfaceSMBase GetMasterGenerator()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMasterGenerator, "BmGame.RMagneticSurfaceSMBase.GetMasterGenerator");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RMagneticSurfaceSMBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearMatinee;
    /// <summary>
    /// Function: ClearMatinee
    /// </summary>
    public unsafe virtual void ClearMatinee()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearMatinee, "BmGame.RMagneticSurfaceSMBase.ClearMatinee");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMatinee;
    /// <summary>
    /// Function: SetMatinee
    /// </summary>
    public unsafe virtual void SetMatinee(BmSDK.Engine.SeqAct_Interp M)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMatinee, "BmGame.RMagneticSurfaceSMBase.SetMatinee");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(M, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RMagneticSurfaceSMBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBlowUpState;
    /// <summary>
    /// Function: SetBlowUpState
    /// </summary>
    public unsafe virtual void SetBlowUpState(bool bNewBlownUp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBlowUpState, "BmGame.RMagneticSurfaceSMBase.SetBlowUpState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewBlownUp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlowUp;
    /// <summary>
    /// Function: BlowUp
    /// </summary>
    public unsafe virtual void BlowUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlowUp, "BmGame.RMagneticSurfaceSMBase.BlowUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetActive;
    /// <summary>
    /// Function: SetActive
    /// </summary>
    public unsafe virtual void SetActive(bool _active)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActive, "BmGame.RMagneticSurfaceSMBase.SetActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveCurrentReceiver;
    /// <summary>
    /// Function: RemoveCurrentReceiver
    /// </summary>
    public unsafe virtual void RemoveCurrentReceiver(BmSDK.BmGame.RMagneticBlastReceiver OldReceiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCurrentReceiver, "BmGame.RMagneticSurfaceSMBase.RemoveCurrentReceiver");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentReceiver;
    /// <summary>
    /// Function: SetCurrentReceiver
    /// </summary>
    public unsafe virtual void SetCurrentReceiver(BmSDK.BmGame.RMagneticBlastReceiver NewReceiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentReceiver, "BmGame.RMagneticSurfaceSMBase.SetCurrentReceiver");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggle;
    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe virtual void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggle, "BmGame.RMagneticSurfaceSMBase.OnToggle");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFOVCheckLocation;
    /// <summary>
    /// Function: GetFOVCheckLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetFOVCheckLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFOVCheckLocation, "BmGame.RMagneticSurfaceSMBase.GetFOVCheckLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAutoTargetLocation;
    /// <summary>
    /// Function: GetAutoTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAutoTargetLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAutoTargetLocation, "BmGame.RMagneticSurfaceSMBase.GetAutoTargetLocation");
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

    private static BmSDK.Function __fn_GetClosestTriangle;
    /// <summary>
    /// Function: GetClosestTriangle
    /// </summary>
    public unsafe virtual void GetClosestTriangle(System.Numerics.Vector3 P, out System.Numerics.Vector3 v0, out System.Numerics.Vector3 v1, out System.Numerics.Vector3 v2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestTriangle, "BmGame.RMagneticSurfaceSMBase.GetClosestTriangle");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out v0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(v0, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out v1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(v1, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out v2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(v2, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        v0 = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        v1 = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        v2 = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        return;
    }

    private static BmSDK.Function __fn_GetMatineeLength;
    /// <summary>
    /// Function: GetMatineeLength
    /// </summary>
    public unsafe virtual float GetMatineeLength()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMatineeLength, "BmGame.RMagneticSurfaceSMBase.GetMatineeLength");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMatineePosition;
    /// <summary>
    /// Function: GetMatineePosition
    /// </summary>
    public unsafe virtual float GetMatineePosition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMatineePosition, "BmGame.RMagneticSurfaceSMBase.GetMatineePosition");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StepMatinee;
    /// <summary>
    /// Function: StepMatinee
    /// </summary>
    public unsafe virtual bool StepMatinee(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StepMatinee, "BmGame.RMagneticSurfaceSMBase.StepMatinee");
        byte* paramsPtr = stackalloc byte[24];
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateEditorComponents;
    /// <summary>
    /// Function: UpdateEditorComponents
    /// </summary>
    public unsafe virtual void UpdateEditorComponents()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateEditorComponents, "BmGame.RMagneticSurfaceSMBase.UpdateEditorComponents");
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

    private static BmSDK.Function __fn_ConvertPosToActorSpace;
    /// <summary>
    /// Function: ConvertPosToActorSpace
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 ConvertPosToActorSpace(BmSDK.Engine.Actor Object, System.Numerics.Vector3 WorldPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConvertPosToActorSpace, "BmGame.RMagneticSurfaceSMBase.ConvertPosToActorSpace");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Object, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldPosition, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    /// <summary>
    /// Enum: EEmergencyStopMode
    /// </summary>
    public enum EEmergencyStopMode : byte
    {
        EESM_AlwaysStop = 0,
        EESM_StopWhenMatineePlaysForward = 1,
        EESM_StopWhenMatineePlaysBackward = 2,
        EESM_MAX = 3,
    }

    /// <summary>
    /// Enum: EForceFieldAxis
    /// </summary>
    public enum EForceFieldAxis : byte
    {
        EFFA_None = 0,
        EFFA_X_Axis = 1,
        EFFA_Y_Axis = 2,
        EFFA_Z_Axis = 3,
        EFFA_MAX = 4,
    }

    /// <summary>
    /// ComponentProperty: SkeletalMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent SkeletalMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ComponentProperty: DestroyedMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent DestroyedMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: BlowUpFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BlowUpFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ObjectProperty: BlowUpSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BlowUpSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// FloatProperty: CurrentMagStr
    /// </summary>
    public unsafe float CurrentMagStr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// FloatProperty: AccumulatedMagStr
    /// </summary>
    public unsafe float AccumulatedMagStr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// FloatProperty: EnergyDrainPerSecond
    /// </summary>
    public unsafe float EnergyDrainPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// ObjectProperty: AreaOfInfluence
    /// </summary>
    public unsafe BmSDK.Engine.Volume AreaOfInfluence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ObjectProperty: Matinee
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp Matinee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// FloatProperty: MatineeSpeed
    /// </summary>
    public unsafe float MatineeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// FloatProperty: DesiredMatineeSpeed
    /// </summary>
    public unsafe float DesiredMatineeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// FloatProperty: MatineeAttractPlaybackSpeed
    /// </summary>
    public unsafe float MatineeAttractPlaybackSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// FloatProperty: MatineeRepelPlaybackSpeed
    /// </summary>
    public unsafe float MatineeRepelPlaybackSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// FloatProperty: MatineeAttractAcceleration
    /// </summary>
    public unsafe float MatineeAttractAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// FloatProperty: MatineeRepelAcceleration
    /// </summary>
    public unsafe float MatineeRepelAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// FloatProperty: MatineeDeceleration
    /// </summary>
    public unsafe float MatineeDeceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// BoolProperty: bMatineeAutoAttract
    /// </summary>
    public unsafe bool bMatineeAutoAttract
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bMatineeAutoRepel
    /// </summary>
    public unsafe bool bMatineeAutoRepel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bActive
    /// </summary>
    public unsafe bool bActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bBlownUp
    /// </summary>
    public unsafe bool bBlownUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bCameraTargetActive
    /// </summary>
    public unsafe bool bCameraTargetActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bIsCharged
    /// </summary>
    public unsafe bool bIsCharged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bNeedsTicking
    /// </summary>
    public unsafe bool bNeedsTicking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bNeedsMaterialUpdate
    /// </summary>
    public unsafe bool bNeedsMaterialUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bNeedsAnimationUpdate
    /// </summary>
    public unsafe bool bNeedsAnimationUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bIsMotor
    /// </summary>
    public unsafe bool bIsMotor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bOpenLeftRight
    /// </summary>
    public unsafe bool bOpenLeftRight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bMotorFlipLowerRaisePrompts
    /// </summary>
    public unsafe bool bMotorFlipLowerRaisePrompts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bForceOpenDoorPrompt
    /// </summary>
    public unsafe bool bForceOpenDoorPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bIsMagnet
    /// </summary>
    public unsafe bool bIsMagnet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bDisableUntilGiveGadget
    /// </summary>
    public unsafe bool bDisableUntilGiveGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bActivateMatineeWhenStepping
    /// </summary>
    public unsafe bool bActivateMatineeWhenStepping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bCacheDestroyGeneratorPointsDone
    /// </summary>
    public unsafe bool bCacheDestroyGeneratorPointsDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bFlipQuickFiredRECImpulses
    /// </summary>
    public unsafe bool bFlipQuickFiredRECImpulses
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// FloatProperty: OverrideMagneticChargeTime
    /// </summary>
    public unsafe float OverrideMagneticChargeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// FloatProperty: AttractForceFactor
    /// </summary>
    public unsafe float AttractForceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// FloatProperty: RepelForceFactor
    /// </summary>
    public unsafe float RepelForceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// FloatProperty: MinimumPlayerDistance
    /// </summary>
    public unsafe float MinimumPlayerDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ObjectProperty: BlockPlayerInteractionVolume
    /// </summary>
    public unsafe BmSDK.Engine.Volume BlockPlayerInteractionVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ArrayProperty: BlockPlayerInteractionVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Volume> BlockPlayerInteractionVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Volume>>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// InterfaceProperty: MatineeControl
    /// </summary>
    public unsafe BmSDK.BmGame.RMatineeController MatineeControl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMatineeController>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ObjectProperty: CachedInterpData
    /// </summary>
    public unsafe BmSDK.Engine.InterpData CachedInterpData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpData>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ComponentProperty: MinimumPlayerDistanceSphere
    /// </summary>
    public unsafe BmSDK.Engine.DrawSphereComponent MinimumPlayerDistanceSphere
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DrawSphereComponent>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ComponentProperty: TargetOffsetSphere
    /// </summary>
    public unsafe BmSDK.Engine.DrawSphereComponent TargetOffsetSphere
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DrawSphereComponent>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ObjectProperty: CameraTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CameraTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// StructProperty: CameraTargetOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraTargetOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 576);

    /// <summary>
    /// ObjectProperty: CurrentReceiver
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlastReceiver CurrentReceiver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlastReceiver>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ComponentProperty: LightEnvironment
    /// </summary>
    public unsafe BmSDK.Engine.DynamicLightEnvironmentComponent LightEnvironment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DynamicLightEnvironmentComponent>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ByteProperty: ForceFieldAxis
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticSurfaceSMBase.EForceFieldAxis ForceFieldAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticSurfaceSMBase.EForceFieldAxis>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ByteProperty: EmergencyStopMode
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticSurfaceSMBase.EEmergencyStopMode EmergencyStopMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticSurfaceSMBase.EEmergencyStopMode>(Ptr + 597); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 597); }
    }

    /// <summary>
    /// ObjectProperty: Master
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticSurfaceSMBase Master
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticSurfaceSMBase>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ObjectProperty: Slave
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticSurfaceSMBase Slave
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticSurfaceSMBase>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// FloatProperty: RecoverTime
    /// </summary>
    public unsafe float RecoverTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// StructProperty: MagneticSourceOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MagneticSourceOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 612);

    /// <summary>
    /// ComponentProperty: MagBlastInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent MagBlastInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// ArrayProperty: BeamEffectsTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> BeamEffectsTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: InfluenceRadius
    /// </summary>
    public unsafe float InfluenceRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ComponentProperty: MovingFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MovingFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// ComponentProperty: JammedFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent JammedFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ArrayProperty: CachedDestroyPoints
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> CachedDestroyPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// ObjectProperty: PredShootTargetPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget PredShootTargetPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// FloatProperty: MagneticEffectsDelay
    /// </summary>
    public unsafe float MagneticEffectsDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }
}
