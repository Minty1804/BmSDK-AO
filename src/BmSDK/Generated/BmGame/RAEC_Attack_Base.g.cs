#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Attack_Base<br/>
/// (size = 496)
/// (flags = 142606482)
/// </summary>
public partial class RAEC_Attack_Base : BmSDK.BmGame.RAlertEventCoordinatorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Attack_Base", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_Attack_Base.
    /// </summary>
    public static RAEC_Attack_Base DefaultObject => (RAEC_Attack_Base)StaticClass().DefaultObject;

    internal RAEC_Attack_Base() { }

    /// <summary>
    /// Constructs a new RAEC_Attack_Base
    /// </summary>
    public RAEC_Attack_Base(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Attack_Base(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Base>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CreateSmokeAEC;
    /// <summary>
    /// Function: CreateSmokeAEC
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAEC_Attack_Smoke CreateSmokeAEC(BmSDK.BmGame.RSmokeScreen NewSmokeScreen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateSmokeAEC, "BmGame.RAEC_Attack_Base.CreateSmokeAEC");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSmokeScreen, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAEC_Attack_Smoke>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayerDead;
    /// <summary>
    /// Function: PlayerDead
    /// </summary>
    public unsafe virtual void PlayerDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerDead, "BmGame.RAEC_Attack_Base.PlayerDead");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialMoveEndNotify;
    /// <summary>
    /// Function: SpecialMoveEndNotify
    /// </summary>
    public unsafe virtual void SpecialMoveEndNotify(System.Numerics.Vector3 NotifyLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialMoveEndNotify, "BmGame.RAEC_Attack_Base.SpecialMoveEndNotify");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmanVantageEscape;
    /// <summary>
    /// Function: BatmanVantageEscape
    /// </summary>
    public unsafe virtual void BatmanVantageEscape()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanVantageEscape, "BmGame.RAEC_Attack_Base.BatmanVantageEscape");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugEscapedTakedown;
    /// <summary>
    /// Function: ThugEscapedTakedown
    /// </summary>
    public unsafe virtual void ThugEscapedTakedown(BmSDK.BmGame.RBMAIController NewMember)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugEscapedTakedown, "BmGame.RAEC_Attack_Base.ThugEscapedTakedown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleGadgetImpactNoise;
    /// <summary>
    /// Function: HandleGadgetImpactNoise
    /// </summary>
    public unsafe virtual bool HandleGadgetImpactNoise(System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, float ReactRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleGadgetImpactNoise, "BmGame.RAEC_Attack_Base.HandleGadgetImpactNoise");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReactRange, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_AddAttacker;
    /// <summary>
    /// Function: AddAttacker
    /// </summary>
    public unsafe virtual void AddAttacker(BmSDK.BmGame.RBMAIController NewMember, bool bPlaySpottedLine = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddAttacker, "BmGame.RAEC_Attack_Base.AddAttacker");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlaySpottedLine, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PropogateStartled;
    /// <summary>
    /// Function: PropogateStartled
    /// </summary>
    public unsafe virtual void PropogateStartled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PropogateStartled, "BmGame.RAEC_Attack_Base.PropogateStartled");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AlertAndAddAttacker;
    /// <summary>
    /// Function: AlertAndAddAttacker
    /// </summary>
    public unsafe virtual void AlertAndAddAttacker(BmSDK.BmGame.RBMAIController NewMember)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertAndAddAttacker, "BmGame.RAEC_Attack_Base.AlertAndAddAttacker");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FakeGroupFlee;
    /// <summary>
    /// Function: FakeGroupFlee
    /// </summary>
    public unsafe virtual void FakeGroupFlee(System.Numerics.Vector3 AlertLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeGroupFlee, "BmGame.RAEC_Attack_Base.FakeGroupFlee");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlertLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PauseAndLookTowardsAlert;
    /// <summary>
    /// Function: PauseAndLookTowardsAlert
    /// </summary>
    public unsafe virtual void PauseAndLookTowardsAlert(System.Numerics.Vector3 AlertLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PauseAndLookTowardsAlert, "BmGame.RAEC_Attack_Base.PauseAndLookTowardsAlert");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlertLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugSawPlayer;
    /// <summary>
    /// Function: ThugSawPlayer
    /// </summary>
    public unsafe virtual void ThugSawPlayer(BmSDK.BmGame.RBMAIController NewMember)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugSawPlayer, "BmGame.RAEC_Attack_Base.ThugSawPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceNearbyAttackLook;
    /// <summary>
    /// Function: ForceNearbyAttackLook
    /// </summary>
    public unsafe virtual void ForceNearbyAttackLook()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceNearbyAttackLook, "BmGame.RAEC_Attack_Base.ForceNearbyAttackLook");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceStartAttack;
    /// <summary>
    /// Function: ForceStartAttack
    /// </summary>
    public unsafe virtual void ForceStartAttack(bool bForceRestart = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceStartAttack, "BmGame.RAEC_Attack_Base.ForceStartAttack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceRestart, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IndirectAlertTriggered;
    /// <summary>
    /// Function: IndirectAlertTriggered
    /// </summary>
    public unsafe virtual void IndirectAlertTriggered(System.Numerics.Vector3 AlertLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IndirectAlertTriggered, "BmGame.RAEC_Attack_Base.IndirectAlertTriggered");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlertLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AreAttackersActive;
    /// <summary>
    /// Function: AreAttackersActive
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameRI.EPredAttackState AreAttackersActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreAttackersActive, "BmGame.RAEC_Attack_Base.AreAttackersActive");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameRI.EPredAttackState>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnregisterGuardAEC;
    /// <summary>
    /// Function: UnregisterGuardAEC
    /// </summary>
    public unsafe virtual void UnregisterGuardAEC(BmSDK.BmGame.RAEC_Search_Sub_Guard ExGuardAEC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterGuardAEC, "BmGame.RAEC_Attack_Base.UnregisterGuardAEC");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExGuardAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterGuardAEC;
    /// <summary>
    /// Function: RegisterGuardAEC
    /// </summary>
    public unsafe virtual void RegisterGuardAEC(BmSDK.BmGame.RAEC_Search_Sub_Guard NewGuardAEC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterGuardAEC, "BmGame.RAEC_Attack_Base.RegisterGuardAEC");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGuardAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmGame.RAEC_Attack_Base.GetThoughts");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetChaseChild;
    /// <summary>
    /// Function: GetChaseChild
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAEC_Attack_Chase GetChaseChild()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChaseChild, "BmGame.RAEC_Attack_Base.GetChaseChild");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAEC_Attack_Chase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetConvergeChild;
    /// <summary>
    /// Function: GetConvergeChild
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAEC_Attack_Converge GetConvergeChild()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetConvergeChild, "BmGame.RAEC_Attack_Base.GetConvergeChild");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAEC_Attack_Converge>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TargetPlayerUpdated;
    /// <summary>
    /// Function: TargetPlayerUpdated
    /// </summary>
    public unsafe virtual void TargetPlayerUpdated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargetPlayerUpdated, "BmGame.RAEC_Attack_Base.TargetPlayerUpdated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitForPlayer;
    /// <summary>
    /// Function: InitForPlayer
    /// </summary>
    public unsafe virtual void InitForPlayer(BmSDK.BmGame.RPawnPlayer NewTargetPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitForPlayer, "BmGame.RAEC_Attack_Base.InitForPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTargetPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitializeAttackReaction;
    /// <summary>
    /// Function: InitializeAttackReaction
    /// </summary>
    public unsafe virtual void InitializeAttackReaction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitializeAttackReaction, "BmGame.RAEC_Attack_Base.InitializeAttackReaction");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateChildren;
    /// <summary>
    /// Function: CreateChildren
    /// </summary>
    public unsafe virtual void CreateChildren()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateChildren, "BmGame.RAEC_Attack_Base.CreateChildren");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: TargetPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer TargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ArrayProperty: ActiveGuards
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_Search_Sub_Guard> ActiveGuards
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_Search_Sub_Guard>>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }
}
