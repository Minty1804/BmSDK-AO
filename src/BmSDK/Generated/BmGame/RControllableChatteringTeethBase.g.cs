#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RControllableChatteringTeethBase<br/>
/// (size = 1172)
/// (flags = 142607030)
/// </summary>
public partial class RControllableChatteringTeethBase : BmSDK.Engine.Pawn, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RControllableChatteringTeethBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RControllableChatteringTeethBase.
    /// </summary>
    public static RControllableChatteringTeethBase DefaultObject => (RControllableChatteringTeethBase)StaticClass().DefaultObject;

    internal RControllableChatteringTeethBase() { }

    /// <summary>
    /// Constructs a new RControllableChatteringTeethBase
    /// </summary>
    public RControllableChatteringTeethBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RControllableChatteringTeethBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RControllableChatteringTeethBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RControllableChatteringTeethBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RControllableChatteringTeethBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RControllableChatteringTeethBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RControllableChatteringTeethBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RControllableChatteringTeethBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RControllableChatteringTeethBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RControllableChatteringTeethBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_AlertPeopleToExplosion;
    /// <summary>
    /// Function: AlertPeopleToExplosion
    /// </summary>
    public unsafe virtual void AlertPeopleToExplosion()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertPeopleToExplosion, "BmGame.RControllableChatteringTeethBase.AlertPeopleToExplosion");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamageNearbyFractureWalls;
    /// <summary>
    /// Function: DamageNearbyFractureWalls
    /// </summary>
    public unsafe virtual void DamageNearbyFractureWalls()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageNearbyFractureWalls, "BmGame.RControllableChatteringTeethBase.DamageNearbyFractureWalls");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamageNearbyPeople;
    /// <summary>
    /// Function: DamageNearbyPeople
    /// </summary>
    public unsafe virtual void DamageNearbyPeople()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageNearbyPeople, "BmGame.RControllableChatteringTeethBase.DamageNearbyPeople");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerExplodeEffects;
    /// <summary>
    /// Function: TriggerExplodeEffects
    /// </summary>
    public unsafe virtual void TriggerExplodeEffects()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerExplodeEffects, "BmGame.RControllableChatteringTeethBase.TriggerExplodeEffects");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerDropSound;
    /// <summary>
    /// Function: TriggerDropSound
    /// </summary>
    public unsafe virtual void TriggerDropSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerDropSound, "BmGame.RControllableChatteringTeethBase.TriggerDropSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerExplosionRumble;
    /// <summary>
    /// Function: TriggerExplosionRumble
    /// </summary>
    public unsafe virtual void TriggerExplosionRumble()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerExplosionRumble, "BmGame.RControllableChatteringTeethBase.TriggerExplosionRumble");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyExplosionCameraShake;
    /// <summary>
    /// Function: ApplyExplosionCameraShake
    /// </summary>
    public unsafe virtual void ApplyExplosionCameraShake()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyExplosionCameraShake, "BmGame.RControllableChatteringTeethBase.ApplyExplosionCameraShake");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveTeethPhysics;
    /// <summary>
    /// Function: RemoveTeethPhysics
    /// </summary>
    public unsafe virtual void RemoveTeethPhysics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveTeethPhysics, "BmGame.RControllableChatteringTeethBase.RemoveTeethPhysics");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishStandSpecialMove;
    /// <summary>
    /// Function: FinishStandSpecialMove
    /// </summary>
    public unsafe virtual void FinishStandSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishStandSpecialMove, "BmGame.RControllableChatteringTeethBase.FinishStandSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyTeethCamera;
    /// <summary>
    /// Function: DestroyTeethCamera
    /// </summary>
    public unsafe virtual void DestroyTeethCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyTeethCamera, "BmGame.RControllableChatteringTeethBase.DestroyTeethCamera");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyTeeth;
    /// <summary>
    /// Function: DestroyTeeth
    /// </summary>
    public unsafe virtual void DestroyTeeth()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyTeeth, "BmGame.RControllableChatteringTeethBase.DestroyTeeth");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayWalkAnim;
    /// <summary>
    /// Function: PlayWalkAnim
    /// </summary>
    public unsafe virtual void PlayWalkAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayWalkAnim, "BmGame.RControllableChatteringTeethBase.PlayWalkAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayJumpAnim;
    /// <summary>
    /// Function: PlayJumpAnim
    /// </summary>
    public unsafe virtual void PlayJumpAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayJumpAnim, "BmGame.RControllableChatteringTeethBase.PlayJumpAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayPreExplodeAnim;
    /// <summary>
    /// Function: PlayPreExplodeAnim
    /// </summary>
    public unsafe virtual void PlayPreExplodeAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayPreExplodeAnim, "BmGame.RControllableChatteringTeethBase.PlayPreExplodeAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: TeethState
    /// </summary>
    public unsafe BmSDK.BmGame.RControllableChatteringTeethBase.EChatteringTeethState TeethState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RControllableChatteringTeethBase.EChatteringTeethState>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// ByteProperty: ExplosionOutcome
    /// </summary>
    public unsafe BmSDK.BmGame.RControllableChatteringTeethBase.EExplosionOutcome ExplosionOutcome
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RControllableChatteringTeethBase.EExplosionOutcome>(Ptr + 1117); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1117); }
    }

    /// <summary>
    /// ObjectProperty: Input
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerInput Input
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerInput>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bExploded
    /// </summary>
    public unsafe bool bExploded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bExplosionTriggered
    /// </summary>
    public unsafe bool bExplosionTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// FloatProperty: MinJumpingFloorAngle
    /// </summary>
    public unsafe float MinJumpingFloorAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// FloatProperty: JumpBlendTime
    /// </summary>
    public unsafe float JumpBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: MinVillainDistanceBeforeAutoExplode
    /// </summary>
    public unsafe float MinVillainDistanceBeforeAutoExplode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// FloatProperty: MaxTurnSpeed
    /// </summary>
    public unsafe float MaxTurnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// FloatProperty: AutoExplodeTimer
    /// </summary>
    public unsafe float AutoExplodeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// FloatProperty: AutoExplodeDelay
    /// </summary>
    public unsafe float AutoExplodeDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// FloatProperty: ActualExplodeDelay
    /// </summary>
    public unsafe float ActualExplodeDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ObjectProperty: SpawnGadget
    /// </summary>
    public unsafe BmSDK.Engine.Actor SpawnGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// ObjectProperty: TeethCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RControllableChatteringTeethCamera TeethCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RControllableChatteringTeethCamera>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ObjectProperty: WalkLoopEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WalkLoopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// FloatProperty: PostExplodeDelay
    /// </summary>
    public unsafe float PostExplodeDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// Enum: EExplosionOutcome
    /// </summary>
    public enum EExplosionOutcome : byte
    {
        EXPLOSIONOUTCOME_NotExploded = 0,
        EXPLOSIONOUTCOME_None = 1,
        EXPLOSIONOUTCOME_HitSelf = 2,
        EXPLOSIONOUTCOME_Celebration = 3,
        EXPLOSIONOUTCOME_MAX = 4,
    }

    /// <summary>
    /// Enum: EChatteringTeethState
    /// </summary>
    public enum EChatteringTeethState : byte
    {
        CHATTERINGTEETHSTATE_Walking = 0,
        CHATTERINGTEETHSTATE_TriggerExplode = 1,
        CHATTERINGTEETHSTATE_ExplodeDelay = 2,
        CHATTERINGTEETHSTATE_Explode = 3,
        CHATTERINGTEETHSTATE_PostExplodeDelay = 4,
        CHATTERINGTEETHSTATE_Destroy = 5,
        CHATTERINGTEETHSTATE_MAX = 6,
    }
}
