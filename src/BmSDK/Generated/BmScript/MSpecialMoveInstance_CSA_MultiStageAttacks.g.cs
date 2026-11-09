#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MSpecialMoveInstance_CSA_MultiStageAttacks<br/>
/// (size = 644)
/// (flags = 8388626)
/// </summary>
public partial class MSpecialMoveInstance_CSA_MultiStageAttacks : BmSDK.BmScript.MSpecialMoveInstance_CSA_MultiTargets, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MSpecialMoveInstance_CSA_MultiStageAttacks", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MSpecialMoveInstance_CSA_MultiStageAttacks.
    /// </summary>
    public static MSpecialMoveInstance_CSA_MultiStageAttacks DefaultObject => (MSpecialMoveInstance_CSA_MultiStageAttacks)StaticClass().DefaultObject;

    internal MSpecialMoveInstance_CSA_MultiStageAttacks() { }

    /// <summary>
    /// Constructs a new MSpecialMoveInstance_CSA_MultiStageAttacks
    /// </summary>
    public MSpecialMoveInstance_CSA_MultiStageAttacks(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MSpecialMoveInstance_CSA_MultiStageAttacks(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_CSA_MultiStageAttacks>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_CSA_MultiStageAttacks>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_CSA_MultiStageAttacks>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_CSA_MultiStageAttacks>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_CSA_MultiStageAttacks>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_CSA_MultiStageAttacks>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_CSA_MultiStageAttacks>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_CSA_MultiStageAttacks>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SlowMoStop;
    /// <summary>
    /// Function: SlowMoStop
    /// </summary>
    public unsafe virtual void SlowMoStop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlowMoStop, "BmScript.MSpecialMoveInstance_CSA_MultiStageAttacks.SlowMoStop");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlowMoStart;
    /// <summary>
    /// Function: SlowMoStart
    /// </summary>
    public unsafe virtual void SlowMoStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlowMoStart, "BmScript.MSpecialMoveInstance_CSA_MultiStageAttacks.SlowMoStart");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleAction;
    /// <summary>
    /// Function: HandleAction
    /// </summary>
    public unsafe override void HandleAction(BmSDK.FName ActionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleAction, "BmScript.MSpecialMoveInstance_CSA_MultiStageAttacks.HandleAction");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamagePlayer;
    /// <summary>
    /// Function: DamagePlayer
    /// </summary>
    public unsafe virtual void DamagePlayer(float DmgAmount, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagePlayer, "BmScript.MSpecialMoveInstance_CSA_MultiStageAttacks.DamagePlayer");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverrideHitReaction;
    /// <summary>
    /// Function: OverrideHitReaction
    /// </summary>
    public unsafe override bool OverrideHitReaction(BmSDK.BmGame.RPawnCombat HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideHitReaction, "BmScript.MSpecialMoveInstance_CSA_MultiStageAttacks.OverrideHitReaction");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CombatAnimHit;
    /// <summary>
    /// Function: CombatAnimHit
    /// </summary>
    public unsafe virtual void CombatAnimHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatAnimHit, "BmScript.MSpecialMoveInstance_CSA_MultiStageAttacks.CombatAnimHit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayIndividualAnim;
    /// <summary>
    /// Function: PlayIndividualAnim
    /// </summary>
    public unsafe virtual void PlayIndividualAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayIndividualAnim, "BmScript.MSpecialMoveInstance_CSA_MultiStageAttacks.PlayIndividualAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayMSAnim;
    /// <summary>
    /// Function: PlayMSAnim
    /// </summary>
    public unsafe virtual void PlayMSAnim(BmSDK.FName Transition_Player, BmSDK.FName Idle_Player, BmSDK.FName Transition_Target, BmSDK.FName Idle_Target, BmSDK.Engine.AnimSet PlayerAnimset, BmSDK.Engine.AnimSet TargetAnimSet)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayMSAnim, "BmScript.MSpecialMoveInstance_CSA_MultiStageAttacks.PlayMSAnim");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Transition_Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idle_Player, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Transition_Target, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idle_Target, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerAnimset, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetAnimSet, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialize;
    /// <summary>
    /// Function: Initialize
    /// </summary>
    public unsafe override void Initialize(BmSDK.BmGame.RPawnVillain TargetVillain, System.Numerics.Vector3 RefLoc, BmSDK.Rotator RefRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialize, "BmScript.MSpecialMoveInstance_CSA_MultiStageAttacks.Initialize");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetVillain, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefLoc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefRot, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmScript.MSpecialMoveInstance_CSA_MultiStageAttacks.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: MyConfig
    /// </summary>
    public unsafe BmSDK.BmScript.MSpecialMoveConfig_CSA_MultiStageAttacks MyConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MSpecialMoveConfig_CSA_MultiStageAttacks>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// StructProperty: MSTransitionID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId MSTransitionID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 632);

    /// <summary>
    /// IntProperty: Index
    /// </summary>
    public unsafe int Index
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// BoolProperty: AttackPressed
    /// </summary>
    public unsafe bool AttackPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 640); }
    }

    /// <summary>
    /// BoolProperty: CanCounter
    /// </summary>
    public unsafe bool CanCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 640); }
    }
}
