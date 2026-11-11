#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayerBmBase<br/>
/// (size = 7440)
/// (flags = 144736438)
/// </summary>
public partial class RPawnPlayerBmBase : BmSDK.BmGame.GDPawnHeroBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerBmBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayerBmBase.
    /// </summary>
    public static RPawnPlayerBmBase DefaultObject => (RPawnPlayerBmBase)StaticClass().DefaultObject;

    internal RPawnPlayerBmBase() { }

    /// <summary>
    /// Constructs a new RPawnPlayerBmBase
    /// </summary>
    public RPawnPlayerBmBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerBmBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SimulatedInitNewPose;
    /// <summary>
    /// Function: SimulatedInitNewPose
    /// </summary>
    public unsafe override void SimulatedInitNewPose(BmSDK.FName NewPose, bool NewPoseMirrored, BmSDK.FName OldPose, bool OldPoseMirrored)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimulatedInitNewPose, "BmGame.RPawnPlayerBmBase.SimulatedInitNewPose");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPose, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPoseMirrored, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldPose, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldPoseMirrored, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SimulatedStopGrappling;
    /// <summary>
    /// Function: SimulatedStopGrappling
    /// </summary>
    public unsafe virtual void SimulatedStopGrappling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimulatedStopGrappling, "BmGame.RPawnPlayerBmBase.SimulatedStopGrappling");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyForensicsUpdateRequired;
    /// <summary>
    /// Function: NotifyForensicsUpdateRequired
    /// </summary>
    public unsafe virtual void NotifyForensicsUpdateRequired()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyForensicsUpdateRequired, "BmGame.RPawnPlayerBmBase.NotifyForensicsUpdateRequired");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EyeMaterialUpdated;
    /// <summary>
    /// Function: EyeMaterialUpdated
    /// </summary>
    public unsafe virtual void EyeMaterialUpdated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EyeMaterialUpdated, "BmGame.RPawnPlayerBmBase.EyeMaterialUpdated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CapeChangeGeneral;
    /// <summary>
    /// Function: CapeChangeGeneral
    /// </summary>
    public unsafe virtual void CapeChangeGeneral(BmSDK.BmGame.RPhysUtil.FCapeChangeData ChangeData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CapeChangeGeneral, "BmGame.RPawnPlayerBmBase.CapeChangeGeneral");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChangeData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CapeChangeStateGeneral;
    /// <summary>
    /// Function: CapeChangeStateGeneral
    /// </summary>
    public unsafe virtual int CapeChangeStateGeneral(BmSDK.BmGame.RPhysUtil.FCapeStateChangeData StateChangeData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CapeChangeStateGeneral, "BmGame.RPawnPlayerBmBase.CapeChangeStateGeneral");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateChangeData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_CapeStartInState;
    /// <summary>
    /// Function: CapeStartInState
    /// </summary>
    public unsafe virtual int CapeStartInState(BmSDK.FName NewCapeStateName, float AnimStartTime = default, float AnimPlayRate = default, BmSDK.BmGame.RPhysUtil.ECapeMirroredType MirroredType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CapeStartInState, "BmGame.RPawnPlayerBmBase.CapeStartInState");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCapeStateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimStartTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPlayRate, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_CapeChangeStateAnim;
    /// <summary>
    /// Function: CapeChangeStateAnim
    /// </summary>
    public unsafe virtual int CapeChangeStateAnim(BmSDK.FName NewCapeStateName, BmSDK.FName NewCapeAnimName, float AnimStartTime = default, float AnimPlayRate = default, BmSDK.BmGame.RPhysUtil.ECapeMirroredType MirroredType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CapeChangeStateAnim, "BmGame.RPawnPlayerBmBase.CapeChangeStateAnim");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCapeStateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCapeAnimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimStartTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPlayRate, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredType, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_CapeChangeState;
    /// <summary>
    /// Function: CapeChangeState
    /// </summary>
    public unsafe virtual int CapeChangeState(BmSDK.FName NewCapeStateName, float AnimStartTime = default, float AnimPlayRate = default, BmSDK.BmGame.RPhysUtil.ECapeMirroredType MirroredType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CapeChangeState, "BmGame.RPawnPlayerBmBase.CapeChangeState");
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCapeStateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimStartTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPlayRate, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetGlideKickPosition;
    /// <summary>
    /// Function: GetGlideKickPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGlideKickPosition(BmSDK.BmGame.RPawnPlayer DesiredKickTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlideKickPosition, "BmGame.RPawnPlayerBmBase.GetGlideKickPosition");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredKickTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SimulatedGrappleMovment;
    /// <summary>
    /// Function: SimulatedGrappleMovment
    /// </summary>
    public unsafe virtual void SimulatedGrappleMovment(float DeltaTime, bool bTryingToGrappleLaunch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimulatedGrappleMovment, "BmGame.RPawnPlayerBmBase.SimulatedGrappleMovment");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTryingToGrappleLaunch, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SimulatedGrappleLaunch;
    /// <summary>
    /// Function: SimulatedGrappleLaunch
    /// </summary>
    public unsafe virtual void SimulatedGrappleLaunch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimulatedGrappleLaunch, "BmGame.RPawnPlayerBmBase.SimulatedGrappleLaunch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SimulatedDoGrappleMovement;
    /// <summary>
    /// Function: SimulatedDoGrappleMovement
    /// </summary>
    public unsafe virtual void SimulatedDoGrappleMovement(float DeltaTime, bool bTryingToGrappleLaunch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimulatedDoGrappleMovement, "BmGame.RPawnPlayerBmBase.SimulatedDoGrappleMovement");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTryingToGrappleLaunch, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SimulatedCapeGlideMovement;
    /// <summary>
    /// Function: SimulatedCapeGlideMovement
    /// </summary>
    public unsafe virtual void SimulatedCapeGlideMovement(BmSDK.Engine.Actor AttackTarget, float DeltaTime, bool BoostGlide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimulatedCapeGlideMovement, "BmGame.RPawnPlayerBmBase.SimulatedCapeGlideMovement");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoostGlide, paramsPtr + 8);
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

    private static BmSDK.Function __fn_CalculateCapeGlideAltitude;
    /// <summary>
    /// Function: CalculateCapeGlideAltitude
    /// </summary>
    public unsafe virtual float CalculateCapeGlideAltitude()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateCapeGlideAltitude, "BmGame.RPawnPlayerBmBase.CalculateCapeGlideAltitude");
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

    private static BmSDK.Function __fn_DoPoseSpecificMovement;
    /// <summary>
    /// Function: DoPoseSpecificMovement
    /// </summary>
    public unsafe override void DoPoseSpecificMovement(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPoseSpecificMovement, "BmGame.RPawnPlayerBmBase.DoPoseSpecificMovement");
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

    private static BmSDK.Function __fn_CapeGetPoseMirroredType;
    /// <summary>
    /// Function: CapeGetPoseMirroredType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPhysUtil.ECapeMirroredType CapeGetPoseMirroredType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CapeGetPoseMirroredType, "BmGame.RPawnPlayerBmBase.CapeGetPoseMirroredType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPhysUtil.ECapeMirroredType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCapeCurrentStateChangeIndex;
    /// <summary>
    /// Function: GetCapeCurrentStateChangeIndex
    /// </summary>
    public unsafe virtual int GetCapeCurrentStateChangeIndex()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCapeCurrentStateChangeIndex, "BmGame.RPawnPlayerBmBase.GetCapeCurrentStateChangeIndex");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCinematicCapeStateName;
    /// <summary>
    /// Function: GetCinematicCapeStateName
    /// </summary>
    public unsafe virtual BmSDK.FName GetCinematicCapeStateName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCinematicCapeStateName, "BmGame.RPawnPlayerBmBase.GetCinematicCapeStateName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentCapeStateName;
    /// <summary>
    /// Function: GetCurrentCapeStateName
    /// </summary>
    public unsafe virtual BmSDK.FName GetCurrentCapeStateName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentCapeStateName, "BmGame.RPawnPlayerBmBase.GetCurrentCapeStateName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPropsInThermal;
    /// <summary>
    /// Function: SetPropsInThermal
    /// </summary>
    public unsafe virtual void SetPropsInThermal(bool bActivate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPropsInThermal, "BmGame.RPawnPlayerBmBase.SetPropsInThermal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPropsInXray;
    /// <summary>
    /// Function: SetPropsInXray
    /// </summary>
    public unsafe virtual void SetPropsInXray(bool bActivate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPropsInXray, "BmGame.RPawnPlayerBmBase.SetPropsInXray");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyXRayToSelf;
    /// <summary>
    /// Function: ApplyXRayToSelf
    /// </summary>
    public unsafe virtual void ApplyXRayToSelf()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyXRayToSelf, "BmGame.RPawnPlayerBmBase.ApplyXRayToSelf");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestoreDefaultXRayMICToMeshes;
    /// <summary>
    /// Function: RestoreDefaultXRayMICToMeshes
    /// </summary>
    public unsafe override void RestoreDefaultXRayMICToMeshes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreDefaultXRayMICToMeshes, "BmGame.RPawnPlayerBmBase.RestoreDefaultXRayMICToMeshes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyXRayMICToMeshes;
    /// <summary>
    /// Function: ApplyXRayMICToMeshes
    /// </summary>
    public unsafe override void ApplyXRayMICToMeshes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyXRayMICToMeshes, "BmGame.RPawnPlayerBmBase.ApplyXRayMICToMeshes");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResumeExpensivePhysicsThings;
    /// <summary>
    /// Function: ResumeExpensivePhysicsThings
    /// </summary>
    public unsafe override void ResumeExpensivePhysicsThings()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResumeExpensivePhysicsThings, "BmGame.RPawnPlayerBmBase.ResumeExpensivePhysicsThings");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PauseExpensivePhysicsThings;
    /// <summary>
    /// Function: PauseExpensivePhysicsThings
    /// </summary>
    public unsafe override void PauseExpensivePhysicsThings()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PauseExpensivePhysicsThings, "BmGame.RPawnPlayerBmBase.PauseExpensivePhysicsThings");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ImmuneToBatarang;
    /// <summary>
    /// Function: ImmuneToBatarang
    /// </summary>
    public unsafe override bool ImmuneToBatarang(bool ActualHit, BmSDK.BmGame.RPawnPlayer Thrower)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ImmuneToBatarang, "BmGame.RPawnPlayerBmBase.ImmuneToBatarang");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActualHit, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SpawnIceSphere;
    /// <summary>
    /// Function: SpawnIceSphere
    /// </summary>
    public unsafe virtual BmSDK.Engine.FogVolumeSphericalDensityInfo SpawnIceSphere(System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnIceSphere, "BmGame.RPawnPlayerBmBase.SpawnIceSphere");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.FogVolumeSphericalDensityInfo>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_PlayShieldHit;
    /// <summary>
    /// Function: PlayShieldHit
    /// </summary>
    public unsafe virtual void PlayShieldHit(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, System.Numerics.Vector3 HitLocation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayShieldHit, "BmGame.RPawnPlayerBmBase.PlayShieldHit");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 244);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WillHitShield;
    /// <summary>
    /// Function: WillHitShield
    /// </summary>
    public unsafe virtual bool WillHitShield(System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WillHitShield, "BmGame.RPawnPlayerBmBase.WillHitShield");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_MatineeTeleport;
    /// <summary>
    /// Function: MatineeTeleport
    /// </summary>
    public unsafe override void MatineeTeleport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatineeTeleport, "BmGame.RPawnPlayerBmBase.MatineeTeleport");
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

    private static BmSDK.Function __fn_OnDestroyPhysicsAssetInstance;
    /// <summary>
    /// Function: OnDestroyPhysicsAssetInstance
    /// </summary>
    public unsafe override void OnDestroyPhysicsAssetInstance(BmSDK.Engine.SkeletalMeshComponent AffectedComponent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDestroyPhysicsAssetInstance, "BmGame.RPawnPlayerBmBase.OnDestroyPhysicsAssetInstance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AffectedComponent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnCreatePhysicsAssetInstance;
    /// <summary>
    /// Function: OnCreatePhysicsAssetInstance
    /// </summary>
    public unsafe override void OnCreatePhysicsAssetInstance(BmSDK.Engine.SkeletalMeshComponent AffectedComponent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCreatePhysicsAssetInstance, "BmGame.RPawnPlayerBmBase.OnCreatePhysicsAssetInstance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AffectedComponent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_EyesNormal;
    /// <summary>
    /// Function: EyesNormal
    /// </summary>
    public unsafe virtual bool EyesNormal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EyesNormal, "BmGame.RPawnPlayerBmBase.EyesNormal");
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

    /// <summary>
    /// BoolProperty: bUseDamageMeshes
    /// </summary>
    public unsafe bool bUseDamageMeshes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7076) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7076); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7076); }
    }

    /// <summary>
    /// BoolProperty: DemonTrialsVulnerable
    /// </summary>
    public unsafe bool DemonTrialsVulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7076) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7076); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7076); }
    }

    /// <summary>
    /// BoolProperty: bCanTurnAndRun
    /// </summary>
    public unsafe bool bCanTurnAndRun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7076) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7076); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7076); }
    }

    /// <summary>
    /// BoolProperty: HasJustComeOutOfDive
    /// </summary>
    public unsafe bool HasJustComeOutOfDive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7076) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7076); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7076); }
    }

    /// <summary>
    /// BoolProperty: bFirstGrappleFrame
    /// </summary>
    public unsafe bool bFirstGrappleFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7076) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7076); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7076); }
    }

    /// <summary>
    /// ComponentProperty: CapeSkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent CapeSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7080); }
    }

    /// <summary>
    /// ComponentProperty: CapeComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeComponent CapeComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeComponent>(Ptr + 7084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7084); }
    }

    /// <summary>
    /// ComponentProperty: CapeRenderingComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeRenderingComponent CapeRenderingComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeRenderingComponent>(Ptr + 7088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7088); }
    }

    /// <summary>
    /// IntProperty: CapeNotifyChangeCount
    /// </summary>
    public unsafe int CapeNotifyChangeCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7092); }
    }

    /// <summary>
    /// ObjectProperty: EyesMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant EyesMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 7096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7096); }
    }

    /// <summary>
    /// ObjectProperty: EyesMaterial2
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant EyesMaterial2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 7100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7100); }
    }

    /// <summary>
    /// StructProperty: EyeGlowColour
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor EyeGlowColour
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 7104);

    /// <summary>
    /// ObjectProperty: GlideDirectionalDirectionNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlendDirectional GlideDirectionalDirectionNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlendDirectional>(Ptr + 7120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7120); }
    }

    /// <summary>
    /// ObjectProperty: GlideDirectionalStrengthNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend GlideDirectionalStrengthNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 7124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7124); }
    }

    /// <summary>
    /// ObjectProperty: GlideRetractBlendNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend GlideRetractBlendNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 7128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7128); }
    }

    /// <summary>
    /// ObjectProperty: GlideBaseNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNode GlideBaseNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNode>(Ptr + 7132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7132); }
    }

    /// <summary>
    /// ObjectProperty: GlideRetractBlendMixer
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlendPerBone GlideRetractBlendMixer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlendPerBone>(Ptr + 7136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7136); }
    }

    /// <summary>
    /// ObjectProperty: GlideFlutterStrengthNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend GlideFlutterStrengthNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 7140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7140); }
    }

    /// <summary>
    /// FloatProperty: DivePullUpAnimStrength
    /// </summary>
    public unsafe float DivePullUpAnimStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7144); }
    }

    /// <summary>
    /// ArrayProperty: DemonSafeObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> DemonSafeObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 7148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7148); }
    }

    /// <summary>
    /// FloatProperty: CurrentPoisonFaceLevel
    /// </summary>
    public unsafe float CurrentPoisonFaceLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7160); }
    }

    /// <summary>
    /// FloatProperty: PoisonFaceLevelBlendTime
    /// </summary>
    public unsafe float PoisonFaceLevelBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7164); }
    }

    /// <summary>
    /// ComponentProperty: LeftWingTipTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent LeftWingTipTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7168); }
    }

    /// <summary>
    /// ComponentProperty: RightWingTipTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent RightWingTipTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7172); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideTerminalVelocity
    /// </summary>
    public unsafe float CapeGlideTerminalVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7176); }
    }

    /// <summary>
    /// FloatProperty: MaxCapeGlideTerminalVelocity
    /// </summary>
    public unsafe float MaxCapeGlideTerminalVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7180); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideAccelRate
    /// </summary>
    public unsafe float CapeGlideAccelRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7184); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideMaxLevelOffAlt
    /// </summary>
    public unsafe float CapeGlideMaxLevelOffAlt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7188); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideMinLevelOffAlt
    /// </summary>
    public unsafe float CapeGlideMinLevelOffAlt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7192); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideBoostSoundParam
    /// </summary>
    public unsafe float CapeGlideBoostSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7196); }
    }

    /// <summary>
    /// FloatProperty: GlideBoostSoundParamRampUpTime
    /// </summary>
    public unsafe float GlideBoostSoundParamRampUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7200); }
    }

    /// <summary>
    /// IntProperty: BoostGlideMinCameraPitch
    /// </summary>
    public unsafe int BoostGlideMinCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7204); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideCameraTurnSpeed
    /// </summary>
    public unsafe float CapeGlideCameraTurnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7208); }
    }

    /// <summary>
    /// ObjectProperty: CurrentAltitudeVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RAltitudeVolume CurrentAltitudeVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAltitudeVolume>(Ptr + 7212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7212); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideTurnProp
    /// </summary>
    public unsafe float CapeGlideTurnProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7216); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideRollSpeed
    /// </summary>
    public unsafe float CapeGlideRollSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7220); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideYawRollRate
    /// </summary>
    public unsafe float CapeGlideYawRollRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7224); }
    }

    /// <summary>
    /// IntProperty: CapeGlideMaxPitch
    /// </summary>
    public unsafe int CapeGlideMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7228); }
    }

    /// <summary>
    /// IntProperty: CapeGlideMinPitch
    /// </summary>
    public unsafe int CapeGlideMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7232); }
    }

    /// <summary>
    /// IntProperty: CapeBoostMaxPitch
    /// </summary>
    public unsafe int CapeBoostMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7236); }
    }

    /// <summary>
    /// FloatProperty: CapeGlidePitchRate
    /// </summary>
    public unsafe float CapeGlidePitchRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7240); }
    }

    /// <summary>
    /// FloatProperty: CapeGlidePitchAccel
    /// </summary>
    public unsafe float CapeGlidePitchAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7244); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideMinSpeed
    /// </summary>
    public unsafe float CapeGlideMinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7248); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideMaxSpeed
    /// </summary>
    public unsafe float CapeGlideMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7252); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideAccel
    /// </summary>
    public unsafe float CapeGlideAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7256); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideDecel
    /// </summary>
    public unsafe float CapeGlideDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7260); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideQuickAccel
    /// </summary>
    public unsafe float CapeGlideQuickAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7264); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideOverworldMinSpeed
    /// </summary>
    public unsafe float CapeGlideOverworldMinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7268); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideMinDipTime
    /// </summary>
    public unsafe float CapeGlideMinDipTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7272); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideMaxDipTime
    /// </summary>
    public unsafe float CapeGlideMaxDipTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7276); }
    }

    /// <summary>
    /// IntProperty: CapeGlideDippedMaxPitch
    /// </summary>
    public unsafe int CapeGlideDippedMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7280); }
    }

    /// <summary>
    /// IntProperty: MinVantagePointGlidePitch
    /// </summary>
    public unsafe int MinVantagePointGlidePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7284); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringMaxPitchVelocityDiff
    /// </summary>
    public unsafe float CapeSoaringMaxPitchVelocityDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7288); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringMaxPitchPower
    /// </summary>
    public unsafe float CapeSoaringMaxPitchPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7292); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringMaxAngle
    /// </summary>
    public unsafe float CapeSoaringMaxAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7296); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringVelocityPower
    /// </summary>
    public unsafe float CapeSoaringVelocityPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7300); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringMinSpeed
    /// </summary>
    public unsafe float CapeSoaringMinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7304); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringDecelPower
    /// </summary>
    public unsafe float CapeSoaringDecelPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7308); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringExtraDecel
    /// </summary>
    public unsafe float CapeSoaringExtraDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7312); }
    }

    /// <summary>
    /// FloatProperty: CapeGlidePitchPower
    /// </summary>
    public unsafe float CapeGlidePitchPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7316); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringExtraPullUp
    /// </summary>
    public unsafe float CapeSoaringExtraPullUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7320); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringPullUpAssist
    /// </summary>
    public unsafe float CapeSoaringPullUpAssist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7324); }
    }

    /// <summary>
    /// FloatProperty: CapeSoaringPullUpAssistTime
    /// </summary>
    public unsafe float CapeSoaringPullUpAssistTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7328); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideCameraTurnStrength
    /// </summary>
    public unsafe float CapeGlideCameraTurnStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7332); }
    }

    /// <summary>
    /// FloatProperty: BoostGlideAccelModifier
    /// </summary>
    public unsafe float BoostGlideAccelModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7336); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideOrientationBlendTime
    /// </summary>
    public unsafe float CapeGlideOrientationBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7340); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideSlideTurn
    /// </summary>
    public unsafe float CapeGlideSlideTurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7344); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideSpeed
    /// </summary>
    public unsafe float CapeGlideSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7348); }
    }

    /// <summary>
    /// FloatProperty: CapeGlidePitchSpeed
    /// </summary>
    public unsafe float CapeGlidePitchSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7352); }
    }

    /// <summary>
    /// FloatProperty: TimeInCapeGlide
    /// </summary>
    public unsafe float TimeInCapeGlide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7356); }
    }

    /// <summary>
    /// FloatProperty: CurrentGlideLevelOff
    /// </summary>
    public unsafe float CurrentGlideLevelOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7360); }
    }

    /// <summary>
    /// FloatProperty: GrapplePullStrength
    /// </summary>
    public unsafe float GrapplePullStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7364); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideLeftArmPullIn
    /// </summary>
    public unsafe float CapeGlideLeftArmPullIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7368); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideRightArmPullIn
    /// </summary>
    public unsafe float CapeGlideRightArmPullIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7372); }
    }

    /// <summary>
    /// StructProperty: GlideRotator
    /// </summary>
    public unsafe ref BmSDK.Rotator GlideRotator
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 7376);

    /// <summary>
    /// StructProperty: PawnVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PawnVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7388);

    /// <summary>
    /// StructProperty: CapeGlidePawnRotError
    /// </summary>
    public unsafe ref BmSDK.Rotator CapeGlidePawnRotError
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 7400);

    /// <summary>
    /// StructProperty: GrappleLaunchLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleLaunchLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7412);

    /// <summary>
    /// StructProperty: GrapplePullDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrapplePullDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7424);

    /// <summary>
    /// ObjectProperty: CapeXrayMatInstConst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant CapeXrayMatInstConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 7436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7436); }
    }
}
