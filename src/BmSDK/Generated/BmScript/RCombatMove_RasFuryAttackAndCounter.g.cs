#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// ABSTRACT Class: RCombatMove_RasFuryAttackAndCounter<br/>
/// (size = 680)
/// (flags = 8388627)
/// </summary>
public partial class RCombatMove_RasFuryAttackAndCounter : BmSDK.BmGame.RCombatMove_VillainAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCombatMove_RasFuryAttackAndCounter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCombatMove_RasFuryAttackAndCounter.
    /// </summary>
    public static RCombatMove_RasFuryAttackAndCounter DefaultObject => (RCombatMove_RasFuryAttackAndCounter)StaticClass().DefaultObject;

    internal RCombatMove_RasFuryAttackAndCounter() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_RasFuryAttackAndCounter(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RasFuryAttackAndCounter>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RasFuryAttackAndCounter>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RasFuryAttackAndCounter>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RasFuryAttackAndCounter>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RasFuryAttackAndCounter>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RasFuryAttackAndCounter>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RasFuryAttackAndCounter>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RasFuryAttackAndCounter>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_StartCamera;
    /// <summary>
    /// Function: StartCamera
    /// </summary>
    public unsafe virtual void StartCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCamera, "BmScript.RCombatMove_RasFuryAttackAndCounter.StartCamera");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGlobalSpeed;
    /// <summary>
    /// Function: UpdateGlobalSpeed
    /// </summary>
    public unsafe virtual void UpdateGlobalSpeed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGlobalSpeed, "BmScript.RCombatMove_RasFuryAttackAndCounter.UpdateGlobalSpeed");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncrementNumAttacks;
    /// <summary>
    /// Function: IncrementNumAttacks
    /// </summary>
    public unsafe virtual void IncrementNumAttacks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncrementNumAttacks, "BmScript.RCombatMove_RasFuryAttackAndCounter.IncrementNumAttacks");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopSwordTrail;
    /// <summary>
    /// Function: StopSwordTrail
    /// </summary>
    public unsafe virtual void StopSwordTrail()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSwordTrail, "BmScript.RCombatMove_RasFuryAttackAndCounter.StopSwordTrail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSwordTrail;
    /// <summary>
    /// Function: StartSwordTrail
    /// </summary>
    public unsafe virtual void StartSwordTrail()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSwordTrail, "BmScript.RCombatMove_RasFuryAttackAndCounter.StartSwordTrail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckGotoAttack;
    /// <summary>
    /// Function: CheckGotoAttack
    /// </summary>
    public unsafe virtual void CheckGotoAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckGotoAttack, "BmScript.RCombatMove_RasFuryAttackAndCounter.CheckGotoAttack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GlobalSpeed;
    /// <summary>
    /// Function: GlobalSpeed
    /// </summary>
    public unsafe virtual void GlobalSpeed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GlobalSpeed, "BmScript.RCombatMove_RasFuryAttackAndCounter.GlobalSpeed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeBack;
    /// <summary>
    /// Function: TakeBack
    /// </summary>
    public unsafe virtual void TakeBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeBack, "BmScript.RCombatMove_RasFuryAttackAndCounter.TakeBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Swing;
    /// <summary>
    /// Function: Swing
    /// </summary>
    public unsafe virtual void Swing()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Swing, "BmScript.RCombatMove_RasFuryAttackAndCounter.Swing");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAllGameSpeedTimers;
    /// <summary>
    /// Function: ClearAllGameSpeedTimers
    /// </summary>
    public unsafe virtual void ClearAllGameSpeedTimers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAllGameSpeedTimers, "BmScript.RCombatMove_RasFuryAttackAndCounter.ClearAllGameSpeedTimers");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmanReady;
    /// <summary>
    /// Function: BatmanReady
    /// </summary>
    public unsafe virtual void BatmanReady()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanReady, "BmScript.RCombatMove_RasFuryAttackAndCounter.BatmanReady");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMove, "BmScript.RCombatMove_RasFuryAttackAndCounter.ExitMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override bool GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmScript.RCombatMove_RasFuryAttackAndCounter.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ResetSpeed;
    /// <summary>
    /// Function: ResetSpeed
    /// </summary>
    public unsafe virtual void ResetSpeed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetSpeed, "BmScript.RCombatMove_RasFuryAttackAndCounter.ResetSpeed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PoseSpeed;
    /// <summary>
    /// Function: PoseSpeed
    /// </summary>
    public unsafe virtual void PoseSpeed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PoseSpeed, "BmScript.RCombatMove_RasFuryAttackAndCounter.PoseSpeed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_bLocked;
    /// <summary>
    /// Function: bLocked
    /// </summary>
    public unsafe virtual void bLocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_bLocked, "BmScript.RCombatMove_RasFuryAttackAndCounter.bLocked");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamagePlayer;
    /// <summary>
    /// Function: DamagePlayer
    /// </summary>
    public unsafe virtual void DamagePlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagePlayer, "BmScript.RCombatMove_RasFuryAttackAndCounter.DamagePlayer");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoHit;
    /// <summary>
    /// Function: DoHit
    /// </summary>
    public unsafe virtual void DoHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoHit, "BmScript.RCombatMove_RasFuryAttackAndCounter.DoHit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCounterAttempted;
    /// <summary>
    /// Function: TriggerCounterAttempted
    /// </summary>
    public unsafe override bool TriggerCounterAttempted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCounterAttempted, "BmScript.RCombatMove_RasFuryAttackAndCounter.TriggerCounterAttempted");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformNextComboMove, "BmScript.RCombatMove_RasFuryAttackAndCounter.CanPerformNextComboMove");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStrike, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetCounterLimb;
    /// <summary>
    /// Function: GetCounterLimb
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.CounterLimb GetCounterLimb(BmSDK.BmGame.RPawnCombat TestPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterLimb, "BmScript.RCombatMove_RasFuryAttackAndCounter.GetCounterLimb");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.CounterLimb>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MoveOverridenForPawn;
    /// <summary>
    /// Function: MoveOverridenForPawn
    /// </summary>
    public unsafe override void MoveOverridenForPawn(BmSDK.BmGame.RPawnCombat OverridenPawn, BmSDK.BmGame.RCombatMove NewMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveOverridenForPawn, "BmScript.RCombatMove_RasFuryAttackAndCounter.MoveOverridenForPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridenPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAttackInfo;
    /// <summary>
    /// Function: SetAttackInfo
    /// </summary>
    public unsafe virtual void SetAttackInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAttackInfo, "BmScript.RCombatMove_RasFuryAttackAndCounter.SetAttackInfo");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetJumpFromLocation;
    /// <summary>
    /// Function: GetJumpFromLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetJumpFromLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJumpFromLocation, "BmScript.RCombatMove_RasFuryAttackAndCounter.GetJumpFromLocation");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmScript.RCombatMove_RasFuryAttackAndCounter.Initialise");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FAttackInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FAttackInfo
    {
        /// <summary>
        /// NameProperty: CounterAnim
        /// </summary>
        public unsafe BmSDK.FName CounterAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: CounterIdleAnim
        /// </summary>
        public unsafe BmSDK.FName CounterIdleAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// StructProperty: VillainAnimID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId VillainAnimID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 508);

    /// <summary>
    /// StructProperty: TargetAnimID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId TargetAnimID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 512);

    /// <summary>
    /// ObjectProperty: VillainCounterAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainCounterAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// ObjectProperty: TargetCounterAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TargetCounterAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ArrayProperty: AttackInfoList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RCombatMove_RasFuryAttackAndCounter.FAttackInfo> AttackInfoList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RCombatMove_RasFuryAttackAndCounter.FAttackInfo>>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// StructProperty: CurrentAttack
    /// </summary>
    public unsafe ref BmSDK.BmScript.RCombatMove_RasFuryAttackAndCounter.FAttackInfo CurrentAttack
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmScript.RCombatMove_RasFuryAttackAndCounter.FAttackInfo>(Ptr + 536);

    /// <summary>
    /// IntProperty: NumAttacks
    /// </summary>
    public unsafe int NumAttacks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: NumCountered
    /// </summary>
    public unsafe int NumCountered
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// IntProperty: NumToCounter
    /// </summary>
    public unsafe int NumToCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// FloatProperty: JumpInSlowMoSpeed
    /// </summary>
    public unsafe float JumpInSlowMoSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// FloatProperty: ButtonBashSpeedReq
    /// </summary>
    public unsafe float ButtonBashSpeedReq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// FloatProperty: LastPressTime
    /// </summary>
    public unsafe float LastPressTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// StructProperty: AnimPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AnimPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 576);

    /// <summary>
    /// FloatProperty: AnimYaw
    /// </summary>
    public unsafe float AnimYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: bChoke
    /// </summary>
    public unsafe bool bChoke
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: bJumpInCountered
    /// </summary>
    public unsafe bool bJumpInCountered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: bBMSuccess
    /// </summary>
    public unsafe bool bBMSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: bDoSmokeBomb
    /// </summary>
    public unsafe bool bDoSmokeBomb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// NameProperty: CounterIn
    /// </summary>
    public unsafe BmSDK.FName CounterIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// FloatProperty: GlobalGameSpeed
    /// </summary>
    public unsafe float GlobalGameSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// FloatProperty: MaxGameSpeed
    /// </summary>
    public unsafe float MaxGameSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// StructProperty: CameraDOFSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.RDOFManager.FDofStruct CameraDOFSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RDOFManager.FDofStruct>(Ptr + 612);

    /// <summary>
    /// FloatProperty: MinYawDiffDeg
    /// </summary>
    public unsafe float MinYawDiffDeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }
}
