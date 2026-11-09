#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MCombatMove_ArmouredLieutenantCloseRangeAttack<br/>
/// (size = 1060)
/// (flags = 8388630)
/// </summary>
public partial class MCombatMove_ArmouredLieutenantCloseRangeAttack : BmSDK.BmScript.MCombatMove_ArmouredLieutenantAttackBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MCombatMove_ArmouredLieutenantCloseRangeAttack.
    /// </summary>
    public static MCombatMove_ArmouredLieutenantCloseRangeAttack DefaultObject => (MCombatMove_ArmouredLieutenantCloseRangeAttack)StaticClass().DefaultObject;

    internal MCombatMove_ArmouredLieutenantCloseRangeAttack() { }

    /// <summary>
    /// Constructs a new MCombatMove_ArmouredLieutenantCloseRangeAttack
    /// </summary>
    public MCombatMove_ArmouredLieutenantCloseRangeAttack(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MCombatMove_ArmouredLieutenantCloseRangeAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatMove_ArmouredLieutenantCloseRangeAttack>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_ArmouredLieutenantCloseRangeAttack>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatMove_ArmouredLieutenantCloseRangeAttack>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_ArmouredLieutenantCloseRangeAttack>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_ArmouredLieutenantCloseRangeAttack>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_ArmouredLieutenantCloseRangeAttack>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatMove_ArmouredLieutenantCloseRangeAttack>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_ArmouredLieutenantCloseRangeAttack>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ExitMove;
    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe override void ExitMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMove, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack.ExitMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitPlayer;
    /// <summary>
    /// Function: ExitPlayer
    /// </summary>
    public unsafe virtual void ExitPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitPlayer, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack.ExitPlayer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanReceiveFloorTakedownIfNotRagdoll;
    /// <summary>
    /// Function: CanReceiveFloorTakedownIfNotRagdoll
    /// </summary>
    public unsafe override bool CanReceiveFloorTakedownIfNotRagdoll(BmSDK.BmGame.RPawnCombat TestPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveFloorTakedownIfNotRagdoll, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack.CanReceiveFloorTakedownIfNotRagdoll");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MoveOverridenForPawn;
    /// <summary>
    /// Function: MoveOverridenForPawn
    /// </summary>
    public unsafe override void MoveOverridenForPawn(BmSDK.BmGame.RPawnCombat OverridenPawn, BmSDK.BmGame.RCombatMove NewMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveOverridenForPawn, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack.MoveOverridenForPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridenPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_E3HackCanReceiveAttackFromPawn;
    /// <summary>
    /// Function: E3HackCanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool E3HackCanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_E3HackCanReceiveAttackFromPawn, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack.E3HackCanReceiveAttackFromPawn");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DamagePlayer;
    /// <summary>
    /// Function: DamagePlayer
    /// </summary>
    public unsafe virtual void DamagePlayer(float DmgAmount, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagePlayer, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack.DamagePlayer");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsStriking;
    /// <summary>
    /// Function: IsStriking
    /// </summary>
    public unsafe override bool IsStriking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStriking, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack.IsStriking");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PunchHead_LHand;
    /// <summary>
    /// Function: PunchHead_LHand
    /// </summary>
    public unsafe virtual void PunchHead_LHand()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PunchHead_LHand, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack.PunchHead_LHand");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PunchHead_RHand;
    /// <summary>
    /// Function: PunchHead_RHand
    /// </summary>
    public unsafe virtual void PunchHead_RHand()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PunchHead_RHand, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack.PunchHead_RHand");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayGrabAnim;
    /// <summary>
    /// Function: PlayGrabAnim
    /// </summary>
    public unsafe virtual void PlayGrabAnim(BmSDK.FName tranAnimName, BmSDK.FName IdleAnimName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayGrabAnim, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack.PlayGrabAnim");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(tranAnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdleAnimName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForWallHit;
    /// <summary>
    /// Function: CheckForWallHit
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor CheckForWallHit(float WallColRange, System.Numerics.Vector3 Extent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForWallHit, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack.CheckForWallHit");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallColRange, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_DamageCollisionBetween;
    /// <summary>
    /// Function: DamageCollisionBetween
    /// </summary>
    public unsafe override void DamageCollisionBetween(BmSDK.BmGame.RPawnCombat Pawn1, BmSDK.BmGame.RPawnCombat Pawn2, System.Numerics.Vector3 DamageDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageCollisionBetween, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack.DamageCollisionBetween");
        byte* paramsPtr = stackalloc byte[292];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn2, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageDir, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack.Initialise");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanTriggerGrab;
    /// <summary>
    /// Function: CanTriggerGrab
    /// </summary>
    public unsafe virtual bool CanTriggerGrab(BmSDK.BmGame.RBMCombatManager CombatManager, BmSDK.BmGame.RPawnCombat User, BmSDK.BmGame.RPawnCombat NewTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTriggerGrab, "BmScript.MCombatMove_ArmouredLieutenantCloseRangeAttack.CanTriggerGrab");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatManager, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// StructProperty: StrikeID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId StrikeID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 660);

    /// <summary>
    /// StructProperty: GrabTranID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId GrabTranID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 664);

    /// <summary>
    /// StructProperty: GrabSlamTranID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId GrabSlamTranID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 668);

    /// <summary>
    /// StructProperty: GrabEscapeTranID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId GrabEscapeTranID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 672);

    /// <summary>
    /// StructProperty: VillainSlamOutTranID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId VillainSlamOutTranID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 676);

    /// <summary>
    /// StructProperty: TargetSlamOutTranID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId TargetSlamOutTranID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 680);

    /// <summary>
    /// StructProperty: VillainGrabFailTranID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId VillainGrabFailTranID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 684);

    /// <summary>
    /// ArrayProperty: HitTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> HitTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// FloatProperty: LastTransitionRotation
    /// </summary>
    public unsafe float LastTransitionRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: GrabTimer
    /// </summary>
    public unsafe float GrabTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// FloatProperty: UnconsciousTimer
    /// </summary>
    public unsafe float UnconsciousTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// IntProperty: ButtonMashed
    /// </summary>
    public unsafe int ButtonMashed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// FloatProperty: AngleToAttack
    /// </summary>
    public unsafe float AngleToAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: HitActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor HitActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// StructProperty: TraceHitLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TraceHitLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 724);

    /// <summary>
    /// StructProperty: TraceHitNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TraceHitNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 736);

    /// <summary>
    /// BoolProperty: PlayWallChokeAnimations
    /// </summary>
    public unsafe bool PlayWallChokeAnimations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bStartPlayingGrabSound
    /// </summary>
    public unsafe bool bStartPlayingGrabSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// FloatProperty: GrabRadius
    /// </summary>
    public unsafe float GrabRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StructProperty: TranTargetPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TranTargetPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 756);

    /// <summary>
    /// StructProperty: TranTargetRot
    /// </summary>
    public unsafe ref BmSDK.Rotator TranTargetRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 768);

    /// <summary>
    /// FloatProperty: TimerForGrabOverTime
    /// </summary>
    public unsafe float TimerForGrabOverTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// FloatProperty: TimerForDmgWhileGrabbed
    /// </summary>
    public unsafe float TimerForDmgWhileGrabbed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// NameProperty: ChokeIdleAnimName
    /// </summary>
    public unsafe BmSDK.FName ChokeIdleAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ArrayProperty: GrabbedPunchAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> GrabbedPunchAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: CollRadius
    /// </summary>
    public unsafe float CollRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: ImpluseMul
    /// </summary>
    public unsafe float ImpluseMul
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: StunTimePostImpact
    /// </summary>
    public unsafe float StunTimePostImpact
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: DamageGiven
    /// </summary>
    public InlineArray<float> DamageGiven => new(3, Ptr + 820, 4, this);

    /// <summary>
    /// FloatProperty: DamageGiven
    /// </summary>
    public unsafe float DamageGiven_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }
    /// <summary>
    /// FloatProperty: DamageGiven
    /// </summary>
    public unsafe float DamageGiven_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
    /// <summary>
    /// FloatProperty: DamageGiven
    /// </summary>
    public unsafe float DamageGiven_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// FloatProperty: RadiusOfImpact
    /// </summary>
    public unsafe float RadiusOfImpact
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// FloatProperty: GrabTime
    /// </summary>
    public unsafe float GrabTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// FloatProperty: UnconsciousOnFloorTime
    /// </summary>
    public unsafe float UnconsciousOnFloorTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// IntProperty: MinButtonMashToExitGrab
    /// </summary>
    public unsafe int MinButtonMashToExitGrab
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// FloatProperty: FacingAngleToAttack
    /// </summary>
    public unsafe float FacingAngleToAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: GrabSmashDamageAmount
    /// </summary>
    public InlineArray<float> GrabSmashDamageAmount => new(3, Ptr + 852, 4, this);

    /// <summary>
    /// FloatProperty: GrabSmashDamageAmount
    /// </summary>
    public unsafe float GrabSmashDamageAmount_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }
    /// <summary>
    /// FloatProperty: GrabSmashDamageAmount
    /// </summary>
    public unsafe float GrabSmashDamageAmount_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }
    /// <summary>
    /// FloatProperty: GrabSmashDamageAmount
    /// </summary>
    public unsafe float GrabSmashDamageAmount_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// NameProperty: VillainAnticipationChokeIn
    /// </summary>
    public unsafe BmSDK.FName VillainAnticipationChokeIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// NameProperty: VillainAnticipationPunchIn
    /// </summary>
    public unsafe BmSDK.FName VillainAnticipationPunchIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// NameProperty: VillainChokeFail
    /// </summary>
    public unsafe BmSDK.FName VillainChokeFail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// NameProperty: CommonChokeBackIn
    /// </summary>
    public unsafe BmSDK.FName CommonChokeBackIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// NameProperty: CommonChokeFrontIn
    /// </summary>
    public unsafe BmSDK.FName CommonChokeFrontIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// NameProperty: CommonChokeIdle
    /// </summary>
    public unsafe BmSDK.FName CommonChokeIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// NameProperty: CommonGrabEscape
    /// </summary>
    public unsafe BmSDK.FName CommonGrabEscape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// NameProperty: VillainGetUp
    /// </summary>
    public unsafe BmSDK.FName VillainGetUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// NameProperty: CommonGrabSmash
    /// </summary>
    public unsafe BmSDK.FName CommonGrabSmash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// NameProperty: CommonGrabSmashOut
    /// </summary>
    public unsafe BmSDK.FName CommonGrabSmashOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// NameProperty: VillainGroundShockwave
    /// </summary>
    public unsafe BmSDK.FName VillainGroundShockwave
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// NameProperty: PlayerShockwaveHitReaction
    /// </summary>
    public unsafe BmSDK.FName PlayerShockwaveHitReaction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: GrabWallCollideRange
    /// </summary>
    public unsafe float GrabWallCollideRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// NameProperty: CommonWallChokeBackIn
    /// </summary>
    public unsafe BmSDK.FName CommonWallChokeBackIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// NameProperty: CommonWallChokeFrontIn
    /// </summary>
    public unsafe BmSDK.FName CommonWallChokeFrontIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// NameProperty: CommonWallChokeIdle
    /// </summary>
    public unsafe BmSDK.FName CommonWallChokeIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// NameProperty: CommonWallGrabEscape
    /// </summary>
    public unsafe BmSDK.FName CommonWallGrabEscape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: RotationInterpRate
    /// </summary>
    public unsafe float RotationInterpRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeGrabOverTimeStarts
    /// </summary>
    public unsafe float TimeBeforeGrabOverTimeStarts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenGrabOverTimeDmg
    /// </summary>
    public unsafe float TimeBetweenGrabOverTimeDmg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: GrabOverTimeDmgVal
    /// </summary>
    public InlineArray<float> GrabOverTimeDmgVal => new(3, Ptr + 1008, 4, this);

    /// <summary>
    /// FloatProperty: GrabOverTimeDmgVal
    /// </summary>
    public unsafe float GrabOverTimeDmgVal_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }
    /// <summary>
    /// FloatProperty: GrabOverTimeDmgVal
    /// </summary>
    public unsafe float GrabOverTimeDmgVal_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }
    /// <summary>
    /// FloatProperty: GrabOverTimeDmgVal
    /// </summary>
    public unsafe float GrabOverTimeDmgVal_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ArrayProperty: GrabbedPunchAnims_NoWalls
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> GrabbedPunchAnims_NoWalls
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// ArrayProperty: GrabbedPunchAnims_Walls
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> GrabbedPunchAnims_Walls
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// IntProperty: MaxPunchInSuccession
    /// </summary>
    public unsafe int MaxPunchInSuccession
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// IntProperty: NoOfGrabPunchWithOneHand
    /// </summary>
    public unsafe int NoOfGrabPunchWithOneHand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// IntProperty: PrevGrabPunch
    /// </summary>
    public unsafe int PrevGrabPunch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeCheer
    /// </summary>
    public unsafe float TimeBeforeCheer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }
}
