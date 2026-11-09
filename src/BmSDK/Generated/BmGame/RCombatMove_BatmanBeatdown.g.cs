#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatMove_BatmanBeatdown<br/>
/// (size = 1144)
/// (flags = 142606482)
/// </summary>
public partial class RCombatMove_BatmanBeatdown : BmSDK.BmGame.RCombatMove_BatmanStrike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_BatmanBeatdown", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCombatMove_BatmanBeatdown.
    /// </summary>
    public static RCombatMove_BatmanBeatdown DefaultObject => (RCombatMove_BatmanBeatdown)StaticClass().DefaultObject;

    internal RCombatMove_BatmanBeatdown() { }

    /// <summary>
    /// Constructs a new RCombatMove_BatmanBeatdown
    /// </summary>
    public RCombatMove_BatmanBeatdown(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_BatmanBeatdown(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanBeatdown>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanBeatdown>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanBeatdown>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanBeatdown>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanBeatdown>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanBeatdown>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanBeatdown>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanBeatdown>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ExitMove;
    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe override void ExitMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMove, "BmGame.RCombatMove_BatmanBeatdown.ExitMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffRelativeTransition;
    /// <summary>
    /// Function: TurnOffRelativeTransition
    /// </summary>
    public unsafe override void TurnOffRelativeTransition(BmSDK.BmGame.RPawnCombat TransitionPawn, BmSDK.BmGame.RAnimUtil.FTransitionId TestID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffRelativeTransition, "BmGame.RCombatMove_BatmanBeatdown.TurnOffRelativeTransition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanForceSlowStrike;
    /// <summary>
    /// Function: CanForceSlowStrike
    /// </summary>
    public unsafe override bool CanForceSlowStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanForceSlowStrike, "BmGame.RCombatMove_BatmanBeatdown.CanForceSlowStrike");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeAnimSet;
    /// <summary>
    /// Function: GetStrikeAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetStrikeAnimSet()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeAnimSet, "BmGame.RCombatMove_BatmanBeatdown.GetStrikeAnimSet");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeAnim;
    /// <summary>
    /// Function: GetStrikeAnim
    /// </summary>
    public unsafe override BmSDK.FName GetStrikeAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeAnim, "BmGame.RCombatMove_BatmanBeatdown.GetStrikeAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateSlowMo;
    /// <summary>
    /// Function: UpdateSlowMo
    /// </summary>
    public unsafe override void UpdateSlowMo(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSlowMo, "BmGame.RCombatMove_BatmanBeatdown.UpdateSlowMo");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayStrike;
    /// <summary>
    /// Function: PlayStrike
    /// </summary>
    public unsafe override void PlayStrike(bool bQueue, bool bSimulated)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayStrike, "BmGame.RCombatMove_BatmanBeatdown.PlayStrike");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bQueue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSimulated, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldSetEnvironmentalInfo;
    /// <summary>
    /// Function: ShouldSetEnvironmentalInfo
    /// </summary>
    public unsafe override bool ShouldSetEnvironmentalInfo(BmSDK.BmGame.RPawnPlayerCombat.StrikeStrength Strength)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSetEnvironmentalInfo, "BmGame.RCombatMove_BatmanBeatdown.ShouldSetEnvironmentalInfo");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetDamageInfo;
    /// <summary>
    /// Function: SetDamageInfo
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.FDamageInfo SetDamageInfo(BmSDK.BmGame.RPawnCombat DamageReceiver, float DmgAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDamageInfo, "BmGame.RCombatMove_BatmanBeatdown.SetDamageInfo");
        byte* paramsPtr = stackalloc byte[536];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetStrikeTargetLocation;
    /// <summary>
    /// Function: GetStrikeTargetLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetStrikeTargetLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeTargetLocation, "BmGame.RCombatMove_BatmanBeatdown.GetStrikeTargetLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTrailPS;
    /// <summary>
    /// Function: GetTrailPS
    /// </summary>
    public unsafe override BmSDK.Engine.ParticleSystem GetTrailPS()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTrailPS, "BmGame.RCombatMove_BatmanBeatdown.GetTrailPS");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetImpactPS;
    /// <summary>
    /// Function: GetImpactPS
    /// </summary>
    public unsafe override BmSDK.Engine.ParticleSystem GetImpactPS(BmSDK.BmGame.RPawnCombat.DamageResult DmgResult, BmSDK.BmGame.RPawnCombat HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetImpactPS, "BmGame.RCombatMove_BatmanBeatdown.GetImpactPS");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_StrikeContact;
    /// <summary>
    /// Function: StrikeContact
    /// </summary>
    public unsafe override void StrikeContact(bool bPreStrike)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrikeContact, "BmGame.RCombatMove_BatmanBeatdown.StrikeContact");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPreStrike, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveAttackFromPawn, "BmGame.RCombatMove_BatmanBeatdown.CanReceiveAttackFromPawn");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanNewAttackBeStarted, "BmGame.RCombatMove_BatmanBeatdown.CanNewAttackBeStarted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformTakedownWithStun;
    /// <summary>
    /// Function: CanPerformTakedownWithStun
    /// </summary>
    public unsafe override bool CanPerformTakedownWithStun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformTakedownWithStun, "BmGame.RCombatMove_BatmanBeatdown.CanPerformTakedownWithStun");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformTakedownWithCounter;
    /// <summary>
    /// Function: CanPerformTakedownWithCounter
    /// </summary>
    public unsafe override bool CanPerformTakedownWithCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformTakedownWithCounter, "BmGame.RCombatMove_BatmanBeatdown.CanPerformTakedownWithCounter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformNextComboMove;
    /// <summary>
    /// Function: CanPerformNextComboMove
    /// </summary>
    public unsafe override bool CanPerformNextComboMove(bool bSpecialMove = default, bool bStrike = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformNextComboMove, "BmGame.RCombatMove_BatmanBeatdown.CanPerformNextComboMove");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStrike, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TriggerCounterAttempted;
    /// <summary>
    /// Function: TriggerCounterAttempted
    /// </summary>
    public unsafe override bool TriggerCounterAttempted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCounterAttempted, "BmGame.RCombatMove_BatmanBeatdown.TriggerCounterAttempted");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerStrikeAttempted, "BmGame.RCombatMove_BatmanBeatdown.TriggerStrikeAttempted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStun, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryQueuedMove;
    /// <summary>
    /// Function: TryQueuedMove
    /// </summary>
    public unsafe virtual void TryQueuedMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryQueuedMove, "BmGame.RCombatMove_BatmanBeatdown.TryQueuedMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPerformNextMove;
    /// <summary>
    /// Function: CanPerformNextMove
    /// </summary>
    public unsafe virtual void CanPerformNextMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformNextMove, "BmGame.RCombatMove_BatmanBeatdown.CanPerformNextMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BotTryStrike;
    /// <summary>
    /// Function: BotTryStrike
    /// </summary>
    public unsafe virtual void BotTryStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BotTryStrike, "BmGame.RCombatMove_BatmanBeatdown.BotTryStrike");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowNextStrike;
    /// <summary>
    /// Function: AllowNextStrike
    /// </summary>
    public unsafe override void AllowNextStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowNextStrike, "BmGame.RCombatMove_BatmanBeatdown.AllowNextStrike");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetComboIncrease;
    /// <summary>
    /// Function: GetComboIncrease
    /// </summary>
    public unsafe override void GetComboIncrease(out int ComboIncrease, out int SpecialMoveCountIncrease)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboIncrease, "BmGame.RCombatMove_BatmanBeatdown.GetComboIncrease");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ComboIncrease);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboIncrease, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SpecialMoveCountIncrease);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMoveCountIncrease, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ComboIncrease = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        SpecialMoveCountIncrease = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_ShouldIncCombo;
    /// <summary>
    /// Function: ShouldIncCombo
    /// </summary>
    public unsafe override bool ShouldIncCombo(out int ComboIncrease, out int SpecialMoveCountIncrease)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldIncCombo, "BmGame.RCombatMove_BatmanBeatdown.ShouldIncCombo");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ComboIncrease);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboIncrease, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SpecialMoveCountIncrease);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMoveCountIncrease, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ComboIncrease = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        SpecialMoveCountIncrease = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDamageAmount;
    /// <summary>
    /// Function: GetDamageAmount
    /// </summary>
    public unsafe override float GetDamageAmount(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageAmount, "BmGame.RCombatMove_BatmanBeatdown.GetDamageAmount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DamagePawn;
    /// <summary>
    /// Function: DamagePawn
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagePawn(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagePawn, "BmGame.RCombatMove_BatmanBeatdown.DamagePawn");
        byte* paramsPtr = stackalloc byte[22];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayImpactSound;
    /// <summary>
    /// Function: PlayImpactSound
    /// </summary>
    public unsafe override void PlayImpactSound(BmSDK.BmGame.RPawnCombat DamageReceiver, BmSDK.BmGame.RPawnCombat.DamageResult DmgResult)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayImpactSound, "BmGame.RCombatMove_BatmanBeatdown.PlayImpactSound");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.RCombatMove_BatmanBeatdown.Initialise");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeatdownHit;
    /// <summary>
    /// Function: BeatdownHit
    /// </summary>
    public unsafe virtual void BeatdownHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeatdownHit, "BmGame.RCombatMove_BatmanBeatdown.BeatdownHit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStrikeInfoScore;
    /// <summary>
    /// Function: GetStrikeInfoScore
    /// </summary>
    public unsafe override int GetStrikeInfoScore(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike, BmSDK.BmGame.RPawnPlayerCombat.StrikeDirection StrikeDir, BmSDK.BmGame.RPawnPlayerCombat.StrikeStrength StrikeStrength, BmSDK.BmGame.RPawnPlayerCombat.StrikeRange StrikeRange, bool bCanTravelBeyondTarget, bool bIsPoseMirrored)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeInfoScore, "BmGame.RCombatMove_BatmanBeatdown.GetStrikeInfoScore");
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDir, paramsPtr + 124);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeStrength, paramsPtr + 125);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeRange, paramsPtr + 126);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanTravelBeyondTarget, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPoseMirrored, paramsPtr + 132);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 136);
    }

    private static BmSDK.Function __fn_ShouldKillInstantly;
    /// <summary>
    /// Function: ShouldKillInstantly
    /// </summary>
    public unsafe virtual bool ShouldKillInstantly()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldKillInstantly, "BmGame.RCombatMove_BatmanBeatdown.ShouldKillInstantly");
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
    /// FloatProperty: Delay
    /// </summary>
    public unsafe float Delay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bQueueStrike
    /// </summary>
    public unsafe bool bQueueStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bQueueCounter
    /// </summary>
    public unsafe bool bQueueCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsFinalHit
    /// </summary>
    public unsafe bool bIsFinalHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bCanBecomeTakedown
    /// </summary>
    public unsafe bool bCanBecomeTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bTakedownWithCounterNotified
    /// </summary>
    public unsafe bool bTakedownWithCounterNotified
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bTakedownWithStunNotified
    /// </summary>
    public unsafe bool bTakedownWithStunNotified
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bIsGrabBeatDown
    /// </summary>
    public unsafe bool bIsGrabBeatDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bBackToIdleOnFinalHit
    /// </summary>
    public unsafe bool bBackToIdleOnFinalHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1080); }
    }

    /// <summary>
    /// FloatProperty: TimeAddedToQueue
    /// </summary>
    public unsafe float TimeAddedToQueue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// FloatProperty: TotalHitsToKOTarget
    /// </summary>
    public unsafe float TotalHitsToKOTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// IntProperty: CurrentBeatDownStrike
    /// </summary>
    public unsafe int CurrentBeatDownStrike
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// StructProperty: TargetStrikeID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId TargetStrikeID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1096);

    /// <summary>
    /// ByteProperty: BeatdownTargetType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.StrikeTargetType BeatdownTargetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeTargetType>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: BeatdownCameraAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BeatdownCameraAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// StructProperty: AnimPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AnimPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1108);

    /// <summary>
    /// StructProperty: AnimRot
    /// </summary>
    public unsafe ref BmSDK.Rotator AnimRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1120);

    /// <summary>
    /// ClassProperty: BeatDownStartDmg
    /// </summary>
    public unsafe BmSDK.Class BeatDownStartDmg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ClassProperty: BeatDownEndDmg
    /// </summary>
    public unsafe BmSDK.Class BeatDownEndDmg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ClassProperty: BeatDownDmg
    /// </summary>
    public unsafe BmSDK.Class BeatDownDmg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }
}
