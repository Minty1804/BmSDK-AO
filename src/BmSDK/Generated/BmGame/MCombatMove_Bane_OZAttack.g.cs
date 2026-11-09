#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MCombatMove_Bane_OZAttack<br/>
/// (size = 640)
/// (flags = 8388626)
/// </summary>
public partial class MCombatMove_Bane_OZAttack : BmSDK.BmGame.MCombatMove_OZBaneAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MCombatMove_Bane_OZAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MCombatMove_Bane_OZAttack.
    /// </summary>
    public static MCombatMove_Bane_OZAttack DefaultObject => (MCombatMove_Bane_OZAttack)StaticClass().DefaultObject;

    internal MCombatMove_Bane_OZAttack() { }

    /// <summary>
    /// Constructs a new MCombatMove_Bane_OZAttack
    /// </summary>
    public MCombatMove_Bane_OZAttack(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MCombatMove_Bane_OZAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatMove_Bane_OZAttack>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_Bane_OZAttack>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatMove_Bane_OZAttack>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_Bane_OZAttack>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_Bane_OZAttack>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_Bane_OZAttack>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatMove_Bane_OZAttack>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_Bane_OZAttack>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ExitMove;
    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe override void ExitMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMove, "BmGame.MCombatMove_Bane_OZAttack.ExitMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanRedirect;
    /// <summary>
    /// Function: CanRedirect
    /// </summary>
    public unsafe override bool CanRedirect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRedirect, "BmGame.MCombatMove_Bane_OZAttack.CanRedirect");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCounterAnim;
    /// <summary>
    /// Function: GetCounterAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetCounterAnim(bool IsFront)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterAnim, "BmGame.MCombatMove_Bane_OZAttack.GetCounterAnim");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsFront, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetAttackAnimset;
    /// <summary>
    /// Function: GetAttackAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetAttackAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAttackAnimset, "BmGame.MCombatMove_Bane_OZAttack.GetAttackAnimset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAttackAnim;
    /// <summary>
    /// Function: GetAttackAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetAttackAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAttackAnim, "BmGame.MCombatMove_Bane_OZAttack.GetAttackAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ActivateCollisionRight;
    /// <summary>
    /// Function: ActivateCollisionRight
    /// </summary>
    public unsafe virtual void ActivateCollisionRight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateCollisionRight, "BmGame.MCombatMove_Bane_OZAttack.ActivateCollisionRight");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateCollisionLeft, "BmGame.MCombatMove_Bane_OZAttack.ActivateCollisionLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyDamage;
    /// <summary>
    /// Function: ApplyDamage
    /// </summary>
    public unsafe virtual void ApplyDamage(BmSDK.BmGame.RPawnCombat PawnToHit, System.Numerics.Vector3 DamageDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyDamage, "BmGame.MCombatMove_Bane_OZAttack.ApplyDamage");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnToHit, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageDir, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCounterStop;
    /// <summary>
    /// Function: CanCounterStop
    /// </summary>
    public unsafe override void CanCounterStop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCounterStop, "BmGame.MCombatMove_Bane_OZAttack.CanCounterStop");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnHighlight;
    /// <summary>
    /// Function: TurnOnHighlight
    /// </summary>
    public unsafe override void TurnOnHighlight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnHighlight, "BmGame.MCombatMove_Bane_OZAttack.TurnOnHighlight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHitPS;
    /// <summary>
    /// Function: GetHitPS
    /// </summary>
    public unsafe override BmSDK.Engine.ParticleSystem GetHitPS()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitPS, "BmGame.MCombatMove_Bane_OZAttack.GetHitPS");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DamageCollisionBetween;
    /// <summary>
    /// Function: DamageCollisionBetween
    /// </summary>
    public unsafe override void DamageCollisionBetween(BmSDK.BmGame.RPawnCombat Pawn1, BmSDK.BmGame.RPawnCombat Pawn2, System.Numerics.Vector3 DamageDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageCollisionBetween, "BmGame.MCombatMove_Bane_OZAttack.DamageCollisionBetween");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn2, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageDir, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TargetMovingAway;
    /// <summary>
    /// Function: TargetMovingAway
    /// </summary>
    public unsafe virtual bool TargetMovingAway()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargetMovingAway, "BmGame.MCombatMove_Bane_OZAttack.TargetMovingAway");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MoveCountered;
    /// <summary>
    /// Function: MoveCountered
    /// </summary>
    public unsafe override void MoveCountered()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveCountered, "BmGame.MCombatMove_Bane_OZAttack.MoveCountered");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.MCombatMove_Bane_OZAttack.Initialise");
        byte* paramsPtr = stackalloc byte[16];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeUsed, "BmGame.MCombatMove_Bane_OZAttack.CanBeUsed");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatManager, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// ArrayProperty: MeleeAttackAnim
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> MeleeAttackAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ArrayProperty: FrontCounterAnim
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FrontCounterAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// ArrayProperty: BackCounterAnim
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BackCounterAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ArrayProperty: HitTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> HitTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ObjectProperty: HitPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat HitPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ObjectProperty: BanePawn
    /// </summary>
    public unsafe BmSDK.BmGame.MPawnBossBane_OZBase BanePawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MPawnBossBane_OZBase>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// BoolProperty: bAttackHasBeenCountered
    /// </summary>
    public unsafe bool bAttackHasBeenCountered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// BoolProperty: bTrackTarget
    /// </summary>
    public unsafe bool bTrackTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }
    }

    /// <summary>
    /// StructProperty: AttackAnimID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId AttackAnimID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 572);

    /// <summary>
    /// IntProperty: AttackAnimIndex
    /// </summary>
    public unsafe int AttackAnimIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// IntProperty: VenomMinAnimIndex
    /// </summary>
    public unsafe int VenomMinAnimIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// StructProperty: PlayerDamageDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PlayerDamageDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 584);

    /// <summary>
    /// StructProperty: FirstTransitionLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FirstTransitionLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 596);

    /// <summary>
    /// StructProperty: LastTransitionLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastTransitionLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 608);

    /// <summary>
    /// FloatProperty: LastTransitionRotation
    /// </summary>
    public unsafe float LastTransitionRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: AttackRange
    /// </summary>
    public unsafe float AttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// StructProperty: PunchDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PunchDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 628);
}
