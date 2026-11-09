#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MCombatMove_OverpowerAttack<br/>
/// (size = 676)
/// (flags = 8388630)
/// </summary>
public partial class MCombatMove_OverpowerAttack : BmSDK.BmGame.RCombatMove_VillainAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MCombatMove_OverpowerAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MCombatMove_OverpowerAttack.
    /// </summary>
    public static MCombatMove_OverpowerAttack DefaultObject => (MCombatMove_OverpowerAttack)StaticClass().DefaultObject;

    internal MCombatMove_OverpowerAttack() { }

    /// <summary>
    /// Constructs a new MCombatMove_OverpowerAttack
    /// </summary>
    public MCombatMove_OverpowerAttack(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MCombatMove_OverpowerAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatMove_OverpowerAttack>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_OverpowerAttack>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatMove_OverpowerAttack>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_OverpowerAttack>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_OverpowerAttack>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_OverpowerAttack>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatMove_OverpowerAttack>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_OverpowerAttack>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ExitMove;
    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe override void ExitMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMove, "BmScript.MCombatMove_OverpowerAttack.ExitMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EscapeContextSensitiveAction;
    /// <summary>
    /// Function: EscapeContextSensitiveAction
    /// </summary>
    public unsafe virtual void EscapeContextSensitiveAction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EscapeContextSensitiveAction, "BmScript.MCombatMove_OverpowerAttack.EscapeContextSensitiveAction");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EscapePrompt;
    /// <summary>
    /// Function: EscapePrompt
    /// </summary>
    public unsafe virtual bool EscapePrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EscapePrompt, "BmScript.MCombatMove_OverpowerAttack.EscapePrompt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldTurnOver;
    /// <summary>
    /// Function: ShouldTurnOver
    /// </summary>
    public unsafe virtual bool ShouldTurnOver()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldTurnOver, "BmScript.MCombatMove_OverpowerAttack.ShouldTurnOver");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ApplyDamage;
    /// <summary>
    /// Function: ApplyDamage
    /// </summary>
    public unsafe virtual void ApplyDamage(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.BmGame.RPawnCombat PawnToHit, float DamageAmount, BmSDK.Class dmgTypeClass = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyDamage, "BmScript.MCombatMove_OverpowerAttack.ApplyDamage");
        byte* paramsPtr = stackalloc byte[288];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnToHit, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgTypeClass, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAnimation;
    /// <summary>
    /// Function: PlayAnimation
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId PlayAnimation(BmSDK.FName TransitionName, BmSDK.FName MovementStance = default, BmSDK.FName IdleName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAnimation, "BmScript.MCombatMove_OverpowerAttack.PlayAnimation");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdleName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat DamageReceiver, BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmScript.MCombatMove_OverpowerAttack.DamagedBy");
        byte* paramsPtr = stackalloc byte[308];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 260);
    }

    private static BmSDK.Function __fn_OverrideHitReaction;
    /// <summary>
    /// Function: OverrideHitReaction
    /// </summary>
    public unsafe override bool OverrideHitReaction(BmSDK.BmGame.RPawnCombat HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideHitReaction, "BmScript.MCombatMove_OverpowerAttack.OverrideHitReaction");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_BlockedStun;
    /// <summary>
    /// Function: BlockedStun
    /// </summary>
    public unsafe virtual bool BlockedStun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlockedStun, "BmScript.MCombatMove_OverpowerAttack.BlockedStun");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPrepareToBlock;
    /// <summary>
    /// Function: CanPrepareToBlock
    /// </summary>
    public unsafe override bool CanPrepareToBlock()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPrepareToBlock, "BmScript.MCombatMove_OverpowerAttack.CanPrepareToBlock");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverrideRedirect;
    /// <summary>
    /// Function: OverrideRedirect
    /// </summary>
    public unsafe override bool OverrideRedirect(BmSDK.BmGame.RPawnCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideRedirect, "BmScript.MCombatMove_OverpowerAttack.OverrideRedirect");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmScript.MCombatMove_OverpowerAttack.Initialise");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeUsed;
    /// <summary>
    /// Function: CanBeUsed
    /// </summary>
    public unsafe static bool CanBeUsed(BmSDK.BmGame.RBMCombatManager CombatManager, BmSDK.BmGame.RPawnCombat User, BmSDK.BmGame.RPawnCombat NewTarget)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeUsed, "BmScript.MCombatMove_OverpowerAttack.CanBeUsed");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatManager, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveAttackFromPawn, "BmScript.MCombatMove_OverpowerAttack.CanReceiveAttackFromPawn");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanNewAttackBeStarted;
    /// <summary>
    /// Function: CanNewAttackBeStarted
    /// </summary>
    public unsafe override bool CanNewAttackBeStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanNewAttackBeStarted, "BmScript.MCombatMove_OverpowerAttack.CanNewAttackBeStarted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ImpactHitRightHand;
    /// <summary>
    /// Function: ImpactHitRightHand
    /// </summary>
    public unsafe override void ImpactHitRightHand()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ImpactHitRightHand, "BmScript.MCombatMove_OverpowerAttack.ImpactHitRightHand");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowNextStrike;
    /// <summary>
    /// Function: AllowNextStrike
    /// </summary>
    public unsafe virtual void AllowNextStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowNextStrike, "BmScript.MCombatMove_OverpowerAttack.AllowNextStrike");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowMovementExit;
    /// <summary>
    /// Function: AllowMovementExit
    /// </summary>
    public unsafe virtual void AllowMovementExit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowMovementExit, "BmScript.MCombatMove_OverpowerAttack.AllowMovementExit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterBeatdownThugToRagdoll;
    /// <summary>
    /// Function: CounterBeatdownThugToRagdoll
    /// </summary>
    public unsafe virtual void CounterBeatdownThugToRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterBeatdownThugToRagdoll, "BmScript.MCombatMove_OverpowerAttack.CounterBeatdownThugToRagdoll");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterVenomThugToRagdoll;
    /// <summary>
    /// Function: CounterVenomThugToRagdoll
    /// </summary>
    public unsafe virtual void CounterVenomThugToRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterVenomThugToRagdoll, "BmScript.MCombatMove_OverpowerAttack.CounterVenomThugToRagdoll");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterVenomThug;
    /// <summary>
    /// Function: CounterVenomThug
    /// </summary>
    public unsafe virtual void CounterVenomThug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterVenomThug, "BmScript.MCombatMove_OverpowerAttack.CounterVenomThug");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Venom_Grab_Beatdown;
    /// <summary>
    /// Function: Venom_Grab_Beatdown
    /// </summary>
    public unsafe virtual void Venom_Grab_Beatdown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Venom_Grab_Beatdown, "BmScript.MCombatMove_OverpowerAttack.Venom_Grab_Beatdown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Venom_Grab_Smash;
    /// <summary>
    /// Function: Venom_Grab_Smash
    /// </summary>
    public unsafe virtual void Venom_Grab_Smash()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Venom_Grab_Smash, "BmScript.MCombatMove_OverpowerAttack.Venom_Grab_Smash");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Venom_Grab_Impact;
    /// <summary>
    /// Function: Venom_Grab_Impact
    /// </summary>
    public unsafe virtual void Venom_Grab_Impact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Venom_Grab_Impact, "BmScript.MCombatMove_OverpowerAttack.Venom_Grab_Impact");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bReadyToHit
    /// </summary>
    public unsafe bool bReadyToHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }
    }

    /// <summary>
    /// BoolProperty: bStopHoming
    /// </summary>
    public unsafe bool bStopHoming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }
    }

    /// <summary>
    /// BoolProperty: bHaveCharge
    /// </summary>
    public unsafe bool bHaveCharge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }
    }

    /// <summary>
    /// BoolProperty: ReadyToExitState
    /// </summary>
    public unsafe bool ReadyToExitState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }
    }

    /// <summary>
    /// BoolProperty: bTargetIsAcquired
    /// </summary>
    public unsafe bool bTargetIsAcquired
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }
    }

    /// <summary>
    /// StructProperty: VillainAnimID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId VillainAnimID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 512);

    /// <summary>
    /// StructProperty: ChargeDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChargeDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 516);

    /// <summary>
    /// FloatProperty: HoldTimeout
    /// </summary>
    public unsafe float HoldTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// FloatProperty: BeatdownTimeout
    /// </summary>
    public unsafe float BeatdownTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// StructProperty: AnimPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AnimPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 536);

    /// <summary>
    /// StructProperty: AnimEndPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AnimEndPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 548);

    /// <summary>
    /// FloatProperty: AnimYaw
    /// </summary>
    public unsafe float AnimYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// IntProperty: CounterCount
    /// </summary>
    public unsafe int CounterCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// StructProperty: LastAdditiveAnim
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId LastAdditiveAnim
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 568);

    /// <summary>
    /// ObjectProperty: BeatdownPuncher
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain BeatdownPuncher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// IntProperty: DifficultyLevel
    /// </summary>
    public unsafe int DifficultyLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// FloatProperty: PuncherStopApproachingSqrDistance
    /// </summary>
    public unsafe float PuncherStopApproachingSqrDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ObjectProperty: PlayThroatGrabChokeLoop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent PlayThroatGrabChokeLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: StopThroatGrabChokeLoop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StopThroatGrabChokeLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// FloatProperty: AttackRange
    /// </summary>
    public unsafe float AttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// FloatProperty: ChargeRange
    /// </summary>
    public unsafe float ChargeRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// FloatProperty: HomingRange
    /// </summary>
    public unsafe float HomingRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// FloatProperty: RotationInterpRate
    /// </summary>
    public unsafe float RotationInterpRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// IntProperty: MinimumCounterCountToSucceed
    /// </summary>
    public unsafe int MinimumCounterCountToSucceed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: HoldTimeoutPerDifficulty
    /// </summary>
    public InlineArray<float> HoldTimeoutPerDifficulty => new(3, Ptr + 616, 4, this);

    /// <summary>
    /// FloatProperty: HoldTimeoutPerDifficulty
    /// </summary>
    public unsafe float HoldTimeoutPerDifficulty_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }
    /// <summary>
    /// FloatProperty: HoldTimeoutPerDifficulty
    /// </summary>
    public unsafe float HoldTimeoutPerDifficulty_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }
    /// <summary>
    /// FloatProperty: HoldTimeoutPerDifficulty
    /// </summary>
    public unsafe float HoldTimeoutPerDifficulty_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: BeatdownTimeoutPerDifficulty
    /// </summary>
    public InlineArray<float> BeatdownTimeoutPerDifficulty => new(3, Ptr + 628, 4, this);

    /// <summary>
    /// FloatProperty: BeatdownTimeoutPerDifficulty
    /// </summary>
    public unsafe float BeatdownTimeoutPerDifficulty_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }
    /// <summary>
    /// FloatProperty: BeatdownTimeoutPerDifficulty
    /// </summary>
    public unsafe float BeatdownTimeoutPerDifficulty_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }
    /// <summary>
    /// FloatProperty: BeatdownTimeoutPerDifficulty
    /// </summary>
    public unsafe float BeatdownTimeoutPerDifficulty_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: VenomGrabImpactDamagePerDifficulty
    /// </summary>
    public InlineArray<float> VenomGrabImpactDamagePerDifficulty => new(3, Ptr + 640, 4, this);

    /// <summary>
    /// FloatProperty: VenomGrabImpactDamagePerDifficulty
    /// </summary>
    public unsafe float VenomGrabImpactDamagePerDifficulty_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }
    /// <summary>
    /// FloatProperty: VenomGrabImpactDamagePerDifficulty
    /// </summary>
    public unsafe float VenomGrabImpactDamagePerDifficulty_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }
    /// <summary>
    /// FloatProperty: VenomGrabImpactDamagePerDifficulty
    /// </summary>
    public unsafe float VenomGrabImpactDamagePerDifficulty_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: VenomGrabSmashDamagePerDifficulty
    /// </summary>
    public InlineArray<float> VenomGrabSmashDamagePerDifficulty => new(3, Ptr + 652, 4, this);

    /// <summary>
    /// FloatProperty: VenomGrabSmashDamagePerDifficulty
    /// </summary>
    public unsafe float VenomGrabSmashDamagePerDifficulty_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }
    /// <summary>
    /// FloatProperty: VenomGrabSmashDamagePerDifficulty
    /// </summary>
    public unsafe float VenomGrabSmashDamagePerDifficulty_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }
    /// <summary>
    /// FloatProperty: VenomGrabSmashDamagePerDifficulty
    /// </summary>
    public unsafe float VenomGrabSmashDamagePerDifficulty_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: VenomGrabBeatdownDamagePerDifficulty
    /// </summary>
    public InlineArray<float> VenomGrabBeatdownDamagePerDifficulty => new(3, Ptr + 664, 4, this);

    /// <summary>
    /// FloatProperty: VenomGrabBeatdownDamagePerDifficulty
    /// </summary>
    public unsafe float VenomGrabBeatdownDamagePerDifficulty_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }
    /// <summary>
    /// FloatProperty: VenomGrabBeatdownDamagePerDifficulty
    /// </summary>
    public unsafe float VenomGrabBeatdownDamagePerDifficulty_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }
    /// <summary>
    /// FloatProperty: VenomGrabBeatdownDamagePerDifficulty
    /// </summary>
    public unsafe float VenomGrabBeatdownDamagePerDifficulty_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }
}
