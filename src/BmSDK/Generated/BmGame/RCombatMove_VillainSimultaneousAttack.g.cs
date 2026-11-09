#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatMove_VillainSimultaneousAttack<br/>
/// (size = 856)
/// (flags = 142606482)
/// </summary>
public partial class RCombatMove_VillainSimultaneousAttack : BmSDK.BmGame.RCombatMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_VillainSimultaneousAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCombatMove_VillainSimultaneousAttack.
    /// </summary>
    public static RCombatMove_VillainSimultaneousAttack DefaultObject => (RCombatMove_VillainSimultaneousAttack)StaticClass().DefaultObject;

    internal RCombatMove_VillainSimultaneousAttack() { }

    /// <summary>
    /// Constructs a new RCombatMove_VillainSimultaneousAttack
    /// </summary>
    public RCombatMove_VillainSimultaneousAttack(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_VillainSimultaneousAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainSimultaneousAttack>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ImpactHitTwoHand;
    /// <summary>
    /// Function: ImpactHitTwoHand
    /// </summary>
    public unsafe override void ImpactHitTwoHand()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ImpactHitTwoHand, "BmGame.RCombatMove_VillainSimultaneousAttack.ImpactHitTwoHand");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ImpactHitRightHand;
    /// <summary>
    /// Function: ImpactHitRightHand
    /// </summary>
    public unsafe override void ImpactHitRightHand()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ImpactHitRightHand, "BmGame.RCombatMove_VillainSimultaneousAttack.ImpactHitRightHand");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ImpactHitLeftHand;
    /// <summary>
    /// Function: ImpactHitLeftHand
    /// </summary>
    public unsafe override void ImpactHitLeftHand()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ImpactHitLeftHand, "BmGame.RCombatMove_VillainSimultaneousAttack.ImpactHitLeftHand");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterHit;
    /// <summary>
    /// Function: CounterHit
    /// </summary>
    public unsafe override void CounterHit(BmSDK.BmGame.RPawnCombat.BoneNameList CounterDamageBone, BmSDK.BmGame.RPawnCombat.BoneNameList CounterImpactBone, BmSDK.BmGame.RPawnPlayerCombat.HitStrength HitStrength, BmSDK.FName CapeStateName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterHit, "BmGame.RCombatMove_VillainSimultaneousAttack.CounterHit");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterDamageBone, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterImpactBone, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitStrength, paramsPtr + 2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CapeStateName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSpawnSuperStrike;
    /// <summary>
    /// Function: CanSpawnSuperStrike
    /// </summary>
    public unsafe override bool CanSpawnSuperStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSpawnSuperStrike, "BmGame.RCombatMove_VillainSimultaneousAttack.CanSpawnSuperStrike");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerStrikeAttempted;
    /// <summary>
    /// Function: TriggerStrikeAttempted
    /// </summary>
    public unsafe override void TriggerStrikeAttempted(bool bStun = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerStrikeAttempted, "BmGame.RCombatMove_VillainSimultaneousAttack.TriggerStrikeAttempted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStun, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFaceFX;
    /// <summary>
    /// Function: StopFaceFX
    /// </summary>
    public unsafe virtual void StopFaceFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFaceFX, "BmGame.RCombatMove_VillainSimultaneousAttack.StopFaceFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartFaceFX;
    /// <summary>
    /// Function: StartFaceFX
    /// </summary>
    public unsafe virtual void StartFaceFX(float StrainAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFaceFX, "BmGame.RCombatMove_VillainSimultaneousAttack.StartFaceFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrainAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitMove;
    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe override void ExitMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMove, "BmGame.RCombatMove_VillainSimultaneousAttack.ExitMove");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateSlowMo;
    /// <summary>
    /// Function: UpdateSlowMo
    /// </summary>
    public unsafe virtual bool UpdateSlowMo(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSlowMo, "BmGame.RCombatMove_VillainSimultaneousAttack.UpdateSlowMo");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StopSlowMo;
    /// <summary>
    /// Function: StopSlowMo
    /// </summary>
    public unsafe virtual void StopSlowMo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSlowMo, "BmGame.RCombatMove_VillainSimultaneousAttack.StopSlowMo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSlowMo;
    /// <summary>
    /// Function: StartSlowMo
    /// </summary>
    public unsafe virtual void StartSlowMo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSlowMo, "BmGame.RCombatMove_VillainSimultaneousAttack.StartSlowMo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldSlowMo;
    /// <summary>
    /// Function: ShouldSlowMo
    /// </summary>
    public unsafe virtual bool ShouldSlowMo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSlowMo, "BmGame.RCombatMove_VillainSimultaneousAttack.ShouldSlowMo");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartAttackSimulated;
    /// <summary>
    /// Function: StartAttackSimulated
    /// </summary>
    public unsafe virtual void StartAttackSimulated(BmSDK.BmGame.RPawnCombat.SimultaneousCounterFormation FormationType, int InfoIndex, System.Numerics.Vector3 TransitionLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAttackSimulated, "BmGame.RCombatMove_VillainSimultaneousAttack.StartAttackSimulated");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FormationType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfoIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBoneName;
    /// <summary>
    /// Function: GetBoneName
    /// </summary>
    public unsafe virtual BmSDK.FName GetBoneName(BmSDK.BmGame.RPawnCombat.BoneNameList BoneID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoneName, "BmGame.RCombatMove_VillainSimultaneousAttack.GetBoneName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTransitionDurationScale;
    /// <summary>
    /// Function: GetTransitionDurationScale
    /// </summary>
    public unsafe virtual float GetTransitionDurationScale(BmSDK.BmGame.RPawnVillain Villain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionDurationScale, "BmGame.RCombatMove_VillainSimultaneousAttack.GetTransitionDurationScale");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ExitMoveForPawn;
    /// <summary>
    /// Function: ExitMoveForPawn
    /// </summary>
    public unsafe override void ExitMoveForPawn(BmSDK.BmGame.RPawnCombat PawnToExit)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMoveForPawn, "BmGame.RCombatMove_VillainSimultaneousAttack.ExitMoveForPawn");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnToExit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveOverridenForPawn;
    /// <summary>
    /// Function: MoveOverridenForPawn
    /// </summary>
    public unsafe override void MoveOverridenForPawn(BmSDK.BmGame.RPawnCombat OverridenPawn, BmSDK.BmGame.RCombatMove NewMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveOverridenForPawn, "BmGame.RCombatMove_VillainSimultaneousAttack.MoveOverridenForPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridenPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InterruptsBeatdown;
    /// <summary>
    /// Function: InterruptsBeatdown
    /// </summary>
    public unsafe override bool InterruptsBeatdown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterruptsBeatdown, "BmGame.RCombatMove_VillainSimultaneousAttack.InterruptsBeatdown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFormationTargetLocation;
    /// <summary>
    /// Function: GetFormationTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFormationTargetLocation(int Idx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFormationTargetLocation, "BmGame.RCombatMove_VillainSimultaneousAttack.GetFormationTargetLocation");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCounterLimb;
    /// <summary>
    /// Function: GetCounterLimb
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.CounterLimb GetCounterLimb(BmSDK.BmGame.RPawnCombat TestPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterLimb, "BmGame.RCombatMove_VillainSimultaneousAttack.GetCounterLimb");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.CounterLimb>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsValidGroupFloorTakedownTarget;
    /// <summary>
    /// Function: IsValidGroupFloorTakedownTarget
    /// </summary>
    public unsafe virtual bool IsValidGroupFloorTakedownTarget(BmSDK.BmGame.RPawnCombat IsStunnedPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidGroupFloorTakedownTarget, "BmGame.RCombatMove_VillainSimultaneousAttack.IsValidGroupFloorTakedownTarget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsStunnedPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanPerformNextComboMove;
    /// <summary>
    /// Function: CanPerformNextComboMove
    /// </summary>
    public unsafe override bool CanPerformNextComboMove(bool bSpecialMove = default, bool bStrike = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformNextComboMove, "BmGame.RCombatMove_VillainSimultaneousAttack.CanPerformNextComboMove");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStrike, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OverridenBySpecialMove;
    /// <summary>
    /// Function: OverridenBySpecialMove
    /// </summary>
    public unsafe virtual void OverridenBySpecialMove(BmSDK.BmGame.RPawnVillain SpecialMoveTarget = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverridenBySpecialMove, "BmGame.RCombatMove_VillainSimultaneousAttack.OverridenBySpecialMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMoveTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPerformWeaponDestroy;
    /// <summary>
    /// Function: CanPerformWeaponDestroy
    /// </summary>
    public unsafe virtual bool CanPerformWeaponDestroy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformWeaponDestroy, "BmGame.RCombatMove_VillainSimultaneousAttack.CanPerformWeaponDestroy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformTakedownWithStun;
    /// <summary>
    /// Function: CanPerformTakedownWithStun
    /// </summary>
    public unsafe virtual bool CanPerformTakedownWithStun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformTakedownWithStun, "BmGame.RCombatMove_VillainSimultaneousAttack.CanPerformTakedownWithStun");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DamageCollisionBetween;
    /// <summary>
    /// Function: DamageCollisionBetween
    /// </summary>
    public unsafe override void DamageCollisionBetween(BmSDK.BmGame.RPawnCombat Pawn1, BmSDK.BmGame.RPawnCombat Pawn2, System.Numerics.Vector3 DamageDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageCollisionBetween, "BmGame.RCombatMove_VillainSimultaneousAttack.DamageCollisionBetween");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn2, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageDir, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayThugCounter;
    /// <summary>
    /// Function: PlayThugCounter
    /// </summary>
    public unsafe virtual void PlayThugCounter(int Idx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayThugCounter, "BmGame.RCombatMove_VillainSimultaneousAttack.PlayThugCounter");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySettle;
    /// <summary>
    /// Function: PlaySettle
    /// </summary>
    public unsafe virtual void PlaySettle(BmSDK.BmGame.RPawnVillain Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySettle, "BmGame.RCombatMove_VillainSimultaneousAttack.PlaySettle");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetVillainAnimName;
    /// <summary>
    /// Function: GetVillainAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetVillainAnimName(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVillainAnimName, "BmGame.RCombatMove_VillainSimultaneousAttack.GetVillainAnimName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AllowAnotherAttacker;
    /// <summary>
    /// Function: AllowAnotherAttacker
    /// </summary>
    public unsafe override bool AllowAnotherAttacker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowAnotherAttacker, "BmGame.RCombatMove_VillainSimultaneousAttack.AllowAnotherAttacker");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DamageCurrentPlayer;
    /// <summary>
    /// Function: DamageCurrentPlayer
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult DamageCurrentPlayer(BmSDK.BmGame.RPawnCombat Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageCurrentPlayer, "BmGame.RCombatMove_VillainSimultaneousAttack.DamageCurrentPlayer");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetGrabbed;
    /// <summary>
    /// Function: SetGrabbed
    /// </summary>
    public unsafe virtual void SetGrabbed(BmSDK.BmGame.RBMPawnAI GrabbedVillain, bool bPawnGrabbed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGrabbed, "BmGame.RCombatMove_VillainSimultaneousAttack.SetGrabbed");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrabbedVillain, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPawnGrabbed, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowMovementExit, "BmGame.RCombatMove_VillainSimultaneousAttack.AllowMovementExit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BotTryNextStrike;
    /// <summary>
    /// Function: BotTryNextStrike
    /// </summary>
    public unsafe virtual void BotTryNextStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BotTryNextStrike, "BmGame.RCombatMove_VillainSimultaneousAttack.BotTryNextStrike");
        byte* paramsPtr = stackalloc byte[20];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowNextStrike, "BmGame.RCombatMove_VillainSimultaneousAttack.AllowNextStrike");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveSuccessfullyFinished;
    /// <summary>
    /// Function: MoveSuccessfullyFinished
    /// </summary>
    public unsafe virtual void MoveSuccessfullyFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveSuccessfullyFinished, "BmGame.RCombatMove_VillainSimultaneousAttack.MoveSuccessfullyFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VillainGoRagdoll;
    /// <summary>
    /// Function: VillainGoRagdoll
    /// </summary>
    public unsafe virtual void VillainGoRagdoll(BmSDK.BmGame.RPawnVillain RagdollVillain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainGoRagdoll, "BmGame.RCombatMove_VillainSimultaneousAttack.VillainGoRagdoll");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RagdollVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRagdollNotify;
    /// <summary>
    /// Function: OnRagdollNotify
    /// </summary>
    public unsafe virtual void OnRagdollNotify(BmSDK.BmGame.RBMPawnAI RagdollVillain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRagdollNotify, "BmGame.RCombatMove_VillainSimultaneousAttack.OnRagdollNotify");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RagdollVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDamageAmount;
    /// <summary>
    /// Function: GetDamageAmount
    /// </summary>
    public unsafe virtual float GetDamageAmount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageAmount, "BmGame.RCombatMove_VillainSimultaneousAttack.GetDamageAmount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DamageCollisionDeactivated;
    /// <summary>
    /// Function: DamageCollisionDeactivated
    /// </summary>
    public unsafe virtual void DamageCollisionDeactivated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageCollisionDeactivated, "BmGame.RCombatMove_VillainSimultaneousAttack.DamageCollisionDeactivated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AnimHit;
    /// <summary>
    /// Function: AnimHit
    /// </summary>
    public unsafe virtual void AnimHit(BmSDK.BmGame.RBMPawnAI VillainPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimHit, "BmGame.RCombatMove_VillainSimultaneousAttack.AnimHit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCounterStop;
    /// <summary>
    /// Function: CanCounterStop
    /// </summary>
    public unsafe virtual void CanCounterStop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCounterStop, "BmGame.RCombatMove_VillainSimultaneousAttack.CanCounterStop");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCounterStart;
    /// <summary>
    /// Function: CanCounterStart
    /// </summary>
    public unsafe virtual void CanCounterStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCounterStart, "BmGame.RCombatMove_VillainSimultaneousAttack.CanCounterStart");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeTargettedByPlayer;
    /// <summary>
    /// Function: CanBeTargettedByPlayer
    /// </summary>
    public unsafe override bool CanBeTargettedByPlayer(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTargettedByPlayer, "BmGame.RCombatMove_VillainSimultaneousAttack.CanBeTargettedByPlayer");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetCounterable;
    /// <summary>
    /// Function: SetCounterable
    /// </summary>
    public unsafe virtual void SetCounterable(BmSDK.BmGame.RBMPawnAI VillainPawn, bool bCounterable, bool bSuccess = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCounterable, "BmGame.RCombatMove_VillainSimultaneousAttack.SetCounterable");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCounterable, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccess, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSimultaneousCounterStop;
    /// <summary>
    /// Function: CanSimultaneousCounterStop
    /// </summary>
    public unsafe virtual void CanSimultaneousCounterStop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSimultaneousCounterStop, "BmGame.RCombatMove_VillainSimultaneousAttack.CanSimultaneousCounterStop");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSimultaneousCounterStart;
    /// <summary>
    /// Function: CanSimultaneousCounterStart
    /// </summary>
    public unsafe virtual void CanSimultaneousCounterStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSimultaneousCounterStart, "BmGame.RCombatMove_VillainSimultaneousAttack.CanSimultaneousCounterStart");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterFXPunch;
    /// <summary>
    /// Function: CounterFXPunch
    /// </summary>
    public unsafe virtual void CounterFXPunch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterFXPunch, "BmGame.RCombatMove_VillainSimultaneousAttack.CounterFXPunch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterFXHit;
    /// <summary>
    /// Function: CounterFXHit
    /// </summary>
    public unsafe virtual void CounterFXHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterFXHit, "BmGame.RCombatMove_VillainSimultaneousAttack.CounterFXHit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterFXBlock;
    /// <summary>
    /// Function: CounterFXBlock
    /// </summary>
    public unsafe virtual void CounterFXBlock()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterFXBlock, "BmGame.RCombatMove_VillainSimultaneousAttack.CounterFXBlock");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopTargetting;
    /// <summary>
    /// Function: StopTargetting
    /// </summary>
    public unsafe virtual void StopTargetting(BmSDK.BmGame.RPawnVillain VillainPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopTargetting, "BmGame.RCombatMove_VillainSimultaneousAttack.StopTargetting");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllStopTargetting;
    /// <summary>
    /// Function: AllStopTargetting
    /// </summary>
    public unsafe virtual void AllStopTargetting()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllStopTargetting, "BmGame.RCombatMove_VillainSimultaneousAttack.AllStopTargetting");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllStartTargetting;
    /// <summary>
    /// Function: AllStartTargetting
    /// </summary>
    public unsafe virtual void AllStartTargetting()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllStartTargetting, "BmGame.RCombatMove_VillainSimultaneousAttack.AllStartTargetting");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncCountered;
    /// <summary>
    /// Function: IncCountered
    /// </summary>
    public unsafe virtual void IncCountered()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncCountered, "BmGame.RCombatMove_VillainSimultaneousAttack.IncCountered");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterPressedSimulated;
    /// <summary>
    /// Function: CounterPressedSimulated
    /// </summary>
    public unsafe virtual void CounterPressedSimulated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterPressedSimulated, "BmGame.RCombatMove_VillainSimultaneousAttack.CounterPressedSimulated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientCounterPressedSimulated;
    /// <summary>
    /// Function: ClientCounterPressedSimulated
    /// </summary>
    public unsafe virtual void ClientCounterPressedSimulated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientCounterPressedSimulated, "BmGame.RCombatMove_VillainSimultaneousAttack.ClientCounterPressedSimulated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CounterPressed;
    /// <summary>
    /// Function: CounterPressed
    /// </summary>
    public unsafe virtual void CounterPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterPressed, "BmGame.RCombatMove_VillainSimultaneousAttack.CounterPressed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayBatmanCounter;
    /// <summary>
    /// Function: PlayBatmanCounter
    /// </summary>
    public unsafe virtual void PlayBatmanCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBatmanCounter, "BmGame.RCombatMove_VillainSimultaneousAttack.PlayBatmanCounter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartCounterSimulated;
    /// <summary>
    /// Function: StartCounterSimulated
    /// </summary>
    public unsafe virtual void StartCounterSimulated(BmSDK.BmGame.RPawnCombat.SimultaneousCounterFormation FormationType, int InfoIndex, System.Numerics.Vector3 AnimLocation, BmSDK.Rotator AnimRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCounterSimulated, "BmGame.RCombatMove_VillainSimultaneousAttack.StartCounterSimulated");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FormationType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfoIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRotation, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientStartCounterSimulated;
    /// <summary>
    /// Function: ClientStartCounterSimulated
    /// </summary>
    public unsafe virtual void ClientStartCounterSimulated(BmSDK.BmGame.RPawnCombat.SimultaneousCounterFormation FormationType, int InfoIndex, System.Numerics.Vector3 AnimLocation, BmSDK.Rotator AnimRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientStartCounterSimulated, "BmGame.RCombatMove_VillainSimultaneousAttack.ClientStartCounterSimulated");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FormationType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfoIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRotation, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartCounter;
    /// <summary>
    /// Function: StartCounter
    /// </summary>
    public unsafe virtual void StartCounter(float TimeInitiatedByPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCounter, "BmGame.RCombatMove_VillainSimultaneousAttack.StartCounter");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCounter;
    /// <summary>
    /// Function: CanCounter
    /// </summary>
    public unsafe virtual bool CanCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCounter, "BmGame.RCombatMove_VillainSimultaneousAttack.CanCounter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveAttackFromPawn, "BmGame.RCombatMove_VillainSimultaneousAttack.CanReceiveAttackFromPawn");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanNewAttackBeStarted;
    /// <summary>
    /// Function: CanNewAttackBeStarted
    /// </summary>
    public unsafe override bool CanNewAttackBeStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanNewAttackBeStarted, "BmGame.RCombatMove_VillainSimultaneousAttack.CanNewAttackBeStarted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TurnOffRelativeTransition;
    /// <summary>
    /// Function: TurnOffRelativeTransition
    /// </summary>
    public unsafe virtual void TurnOffRelativeTransition(BmSDK.BmGame.RPawnCombat TransitionPawn, BmSDK.BmGame.RAnimUtil.FTransitionId TestID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffRelativeTransition, "BmGame.RCombatMove_VillainSimultaneousAttack.TurnOffRelativeTransition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MulticastAddVillain;
    /// <summary>
    /// Function: MulticastAddVillain
    /// </summary>
    public unsafe virtual void MulticastAddVillain(BmSDK.BmGame.RPawnVillain Villain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MulticastAddVillain, "BmGame.RCombatMove_VillainSimultaneousAttack.MulticastAddVillain");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitFormationVecList;
    /// <summary>
    /// Function: InitFormationVecList
    /// </summary>
    public unsafe virtual void InitFormationVecList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitFormationVecList, "BmGame.RCombatMove_VillainSimultaneousAttack.InitFormationVecList");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialiseSimulated;
    /// <summary>
    /// Function: InitialiseSimulated
    /// </summary>
    public unsafe virtual void InitialiseSimulated(BmSDK.BmGame.RPawnCombat TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseSimulated, "BmGame.RCombatMove_VillainSimultaneousAttack.InitialiseSimulated");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawVecs;
    /// <summary>
    /// Function: DrawVecs
    /// </summary>
    public unsafe virtual void DrawVecs()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawVecs, "BmGame.RCombatMove_VillainSimultaneousAttack.DrawVecs");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.RCombatMove_VillainSimultaneousAttack.Initialise");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetId;
    /// <summary>
    /// Function: SetId
    /// </summary>
    public unsafe virtual void SetId(BmSDK.BmGame.RPawnCombat.SimultaneousCounterFormation FormationType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetId, "BmGame.RCombatMove_VillainSimultaneousAttack.SetId");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FormationType, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetFormationType;
    /// <summary>
    /// Function: GetFormationType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.SimultaneousCounterFormation GetFormationType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFormationType, "BmGame.RCombatMove_VillainSimultaneousAttack.GetFormationType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.SimultaneousCounterFormation>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateFormationRotation;
    /// <summary>
    /// Function: UpdateFormationRotation
    /// </summary>
    public unsafe virtual void UpdateFormationRotation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFormationRotation, "BmGame.RCombatMove_VillainSimultaneousAttack.UpdateFormationRotation");
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

    private static BmSDK.Function __fn_UpdateFormationVec;
    /// <summary>
    /// Function: UpdateFormationVec
    /// </summary>
    public unsafe virtual void UpdateFormationVec()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFormationVec, "BmGame.RCombatMove_VillainSimultaneousAttack.UpdateFormationVec");
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

    private static BmSDK.Function __fn_SetCounterInfo;
    /// <summary>
    /// Function: SetCounterInfo
    /// </summary>
    public unsafe virtual void SetCounterInfo(int CounterInfoIndex, bool bTrackUsage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCounterInfo, "BmGame.RCombatMove_VillainSimultaneousAttack.SetCounterInfo");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterInfoIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTrackUsage, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetCounterInfo;
    /// <summary>
    /// Function: GetCounterInfo
    /// </summary>
    public unsafe virtual int GetCounterInfo(BmSDK.BmGame.RPawnCombat.SimultaneousCounterFormation FormationType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterInfo, "BmGame.RCombatMove_VillainSimultaneousAttack.GetCounterInfo");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FormationType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Struct: FIndexDistArray
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FIndexDistArray
    {
        /// <summary>
        /// ArrayProperty: IndexArray
        /// </summary>
        public unsafe BmSDK.TArray<int> IndexArray
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: DistArray
        /// </summary>
        public unsafe BmSDK.TArray<float> DistArray
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FVillainInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial record struct FVillainInfo
    {
        /// <summary>
        /// ObjectProperty: Pawn
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnVillain Pawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bTrackTarget
        /// </summary>
        public unsafe bool bTrackTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bCanCounter
        /// </summary>
        public unsafe bool bCanCounter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bCountered
        /// </summary>
        public unsafe bool bCountered
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bGrabbed
        /// </summary>
        public unsafe bool bGrabbed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: AnimId
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FTransitionId AnimId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: InitStrikeDir
        /// </summary>
        public unsafe System.Numerics.Vector3 InitStrikeDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: LastTransitionRotation
        /// </summary>
        public unsafe float LastTransitionRotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bRagdolled
        /// </summary>
        public unsafe bool bRagdolled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: VecSpot
        /// </summary>
        public unsafe int VecSpot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: AttackDelay
        /// </summary>
        public unsafe float AttackDelay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: bAttackStarted
        /// </summary>
        public unsafe bool bAttackStarted
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// NameProperty: ImpactBone
        /// </summary>
        public unsafe BmSDK.FName ImpactBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: GetInPositionTime
        /// </summary>
        public unsafe float GetInPositionTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bInPosition
        /// </summary>
        public unsafe bool bInPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: Target
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat Target
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// StructProperty: BatmanAnimID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId BatmanAnimID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 492);

    /// <summary>
    /// IntProperty: NumCountered
    /// </summary>
    public unsafe int NumCountered
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// StructProperty: CounterLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CounterLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 500);

    /// <summary>
    /// StructProperty: CounterRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CounterRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 512);

    /// <summary>
    /// FloatProperty: DamageAmount
    /// </summary>
    public unsafe float DamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// FloatProperty: DmgImpulseVal
    /// </summary>
    public unsafe float DmgImpulseVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StructProperty: SCInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnCombat.FSimultaneousCounterInfo SCInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnCombat.FSimultaneousCounterInfo>(Ptr + 532);

    /// <summary>
    /// NameProperty: StrikeHitBone
    /// </summary>
    public unsafe BmSDK.FName StrikeHitBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ArrayProperty: VillainsWhoHitBatman
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> VillainsWhoHitBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ArrayProperty: FormationVecList
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> FormationVecList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// StructProperty: FirstTransitionLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FirstTransitionLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 636);

    /// <summary>
    /// BoolProperty: bAllowNextStrike
    /// </summary>
    public unsafe bool bAllowNextStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 648); }
    }

    /// <summary>
    /// BoolProperty: bAllowMovementExit
    /// </summary>
    public unsafe bool bAllowMovementExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 648); }
    }

    /// <summary>
    /// BoolProperty: bCounterPromptOn
    /// </summary>
    public unsafe bool bCounterPromptOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 648); }
    }

    /// <summary>
    /// BoolProperty: bHitPlayer
    /// </summary>
    public unsafe bool bHitPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 648); }
    }

    /// <summary>
    /// BoolProperty: bHitPerfectStrike
    /// </summary>
    public unsafe bool bHitPerfectStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 648); }
    }

    /// <summary>
    /// BoolProperty: bSlowMo
    /// </summary>
    public unsafe bool bSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 648); }
    }

    /// <summary>
    /// BoolProperty: bInSlowMo
    /// </summary>
    public unsafe bool bInSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 648); }
    }

    /// <summary>
    /// BoolProperty: bOverridenBySpecialMove
    /// </summary>
    public unsafe bool bOverridenBySpecialMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 648); }
    }

    /// <summary>
    /// FloatProperty: AttackTime
    /// </summary>
    public unsafe float AttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// FloatProperty: TransitionDurationScale
    /// </summary>
    public unsafe float TransitionDurationScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// IntProperty: NumInPosition
    /// </summary>
    public unsafe int NumInPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: MeetingPointOffset
    /// </summary>
    public unsafe float MeetingPointOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// FloatProperty: BatmanMoveTimer
    /// </summary>
    public unsafe float BatmanMoveTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ArrayProperty: SlowMoHitTimes
    /// </summary>
    public unsafe BmSDK.TArray<float> SlowMoHitTimes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// FloatProperty: CounterTime
    /// </summary>
    public unsafe float CounterTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// IntProperty: NumCounterHits
    /// </summary>
    public unsafe int NumCounterHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// IntProperty: CurrCounterHit
    /// </summary>
    public unsafe int CurrCounterHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 696);

    /// <summary>
    /// ArrayProperty: VillainList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatMove_VillainSimultaneousAttack.FVillainInfo> VillainList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatMove_VillainSimultaneousAttack.FVillainInfo>>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// FloatProperty: TrackingRangeSq
    /// </summary>
    public unsafe float TrackingRangeSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }
}
