#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Attack<br/>
/// (size = 532)
/// (flags = 8388626)
/// </summary>
public partial class RAEC_Attack : BmSDK.BmGame.RAEC_Attack_Base, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Attack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_Attack.
    /// </summary>
    public static RAEC_Attack DefaultObject => (RAEC_Attack)StaticClass().DefaultObject;

    internal RAEC_Attack() { }

    /// <summary>
    /// Constructs a new RAEC_Attack
    /// </summary>
    public RAEC_Attack(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Attack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PlayExclaim;
    /// <summary>
    /// Function: PlayExclaim
    /// </summary>
    public unsafe virtual void PlayExclaim(System.Numerics.Vector3 EventCentre)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayExclaim, "BmGame.RAEC_Attack.PlayExclaim");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventCentre, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateSmokeAEC;
    /// <summary>
    /// Function: CreateSmokeAEC
    /// </summary>
    public unsafe override BmSDK.BmGame.RAEC_Attack_Smoke CreateSmokeAEC(BmSDK.BmGame.RSmokeScreen NewSmokeScreen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateSmokeAEC, "BmGame.RAEC_Attack.CreateSmokeAEC");
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
    public unsafe override void PlayerDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerDead, "BmGame.RAEC_Attack.PlayerDead");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmanVantageEscape;
    /// <summary>
    /// Function: BatmanVantageEscape
    /// </summary>
    public unsafe override void BatmanVantageEscape()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanVantageEscape, "BmGame.RAEC_Attack.BatmanVantageEscape");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnregisterSniperAEC;
    /// <summary>
    /// Function: UnregisterSniperAEC
    /// </summary>
    public unsafe virtual void UnregisterSniperAEC(BmSDK.BmGame.RAEC_Search_Sub_Sniper ExSniperAEC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterSniperAEC, "BmGame.RAEC_Attack.UnregisterSniperAEC");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExSniperAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterSniperAEC;
    /// <summary>
    /// Function: RegisterSniperAEC
    /// </summary>
    public unsafe virtual void RegisterSniperAEC(BmSDK.BmGame.RAEC_Search_Sub_Sniper NewSniperAEC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterSniperAEC, "BmGame.RAEC_Attack.RegisterSniperAEC");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSniperAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugsAttacking;
    /// <summary>
    /// Function: ThugsAttacking
    /// </summary>
    public unsafe virtual bool ThugsAttacking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugsAttacking, "BmGame.RAEC_Attack.ThugsAttacking");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AreAttackersActive;
    /// <summary>
    /// Function: AreAttackersActive
    /// </summary>
    public unsafe override BmSDK.BmGame.RGameRI.EPredAttackState AreAttackersActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreAttackersActive, "BmGame.RAEC_Attack.AreAttackersActive");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameRI.EPredAttackState>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AttackEventFinished;
    /// <summary>
    /// Function: AttackEventFinished
    /// </summary>
    public unsafe virtual void AttackEventFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttackEventFinished, "BmGame.RAEC_Attack.AttackEventFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepChase;
    /// <summary>
    /// Function: PrepChase
    /// </summary>
    public unsafe virtual void PrepChase()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepChase, "BmGame.RAEC_Attack.PrepChase");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialBarkAvailable;
    /// <summary>
    /// Function: SpecialBarkAvailable
    /// </summary>
    public unsafe virtual void SpecialBarkAvailable(BmSDK.BmGame.RBMAIController.BarkType TypeOfSpecialBark)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialBarkAvailable, "BmGame.RAEC_Attack.SpecialBarkAvailable");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TypeOfSpecialBark, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialMoveEndNotify;
    /// <summary>
    /// Function: SpecialMoveEndNotify
    /// </summary>
    public unsafe override void SpecialMoveEndNotify(System.Numerics.Vector3 NotifyLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialMoveEndNotify, "BmGame.RAEC_Attack.SpecialMoveEndNotify");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleGadgetImpactNoise;
    /// <summary>
    /// Function: HandleGadgetImpactNoise
    /// </summary>
    public unsafe override bool HandleGadgetImpactNoise(System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, float ReactRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleGadgetImpactNoise, "BmGame.RAEC_Attack.HandleGadgetImpactNoise");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReactRange, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ThugEscapedTakedown;
    /// <summary>
    /// Function: ThugEscapedTakedown
    /// </summary>
    public unsafe override void ThugEscapedTakedown(BmSDK.BmGame.RBMAIController NewMember)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugEscapedTakedown, "BmGame.RAEC_Attack.ThugEscapedTakedown");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddAttacker;
    /// <summary>
    /// Function: AddAttacker
    /// </summary>
    public unsafe override void AddAttacker(BmSDK.BmGame.RBMAIController NewMember, bool bPlaySpottedLine = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddAttacker, "BmGame.RAEC_Attack.AddAttacker");
        byte* paramsPtr = stackalloc byte[28];
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
    public unsafe override void PropogateStartled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PropogateStartled, "BmGame.RAEC_Attack.PropogateStartled");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugSawPlayer;
    /// <summary>
    /// Function: ThugSawPlayer
    /// </summary>
    public unsafe override void ThugSawPlayer(BmSDK.BmGame.RBMAIController NewMember)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugSawPlayer, "BmGame.RAEC_Attack.ThugSawPlayer");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FakeGroupFlee;
    /// <summary>
    /// Function: FakeGroupFlee
    /// </summary>
    public unsafe override void FakeGroupFlee(System.Numerics.Vector3 EscapeLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeGroupFlee, "BmGame.RAEC_Attack.FakeGroupFlee");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EscapeLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PauseAndLookTowardsAlert;
    /// <summary>
    /// Function: PauseAndLookTowardsAlert
    /// </summary>
    public unsafe override void PauseAndLookTowardsAlert(System.Numerics.Vector3 AlertLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PauseAndLookTowardsAlert, "BmGame.RAEC_Attack.PauseAndLookTowardsAlert");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlertLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceNearbyAttackLook;
    /// <summary>
    /// Function: ForceNearbyAttackLook
    /// </summary>
    public unsafe override void ForceNearbyAttackLook()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceNearbyAttackLook, "BmGame.RAEC_Attack.ForceNearbyAttackLook");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceStartAttack;
    /// <summary>
    /// Function: ForceStartAttack
    /// </summary>
    public unsafe override void ForceStartAttack(bool bForceRestart = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceStartAttack, "BmGame.RAEC_Attack.ForceStartAttack");
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
    public unsafe override void IndirectAlertTriggered(System.Numerics.Vector3 AlertLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IndirectAlertTriggered, "BmGame.RAEC_Attack.IndirectAlertTriggered");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlertLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveChild;
    /// <summary>
    /// Function: RemoveChild
    /// </summary>
    public unsafe override void RemoveChild(BmSDK.BmGame.RAlertEventCoordinatorBase RemAEC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveChild, "BmGame.RAEC_Attack.RemoveChild");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VillainStolen;
    /// <summary>
    /// Function: VillainStolen
    /// </summary>
    public unsafe override void VillainStolen(BmSDK.BmGame.RBMAIController Stolen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainStolen, "BmGame.RAEC_Attack.VillainStolen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stolen, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetChaseChild;
    /// <summary>
    /// Function: GetChaseChild
    /// </summary>
    public unsafe override BmSDK.BmGame.RAEC_Attack_Chase GetChaseChild()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChaseChild, "BmGame.RAEC_Attack.GetChaseChild");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAEC_Attack_Chase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetConvergeChild;
    /// <summary>
    /// Function: GetConvergeChild
    /// </summary>
    public unsafe override BmSDK.BmGame.RAEC_Attack_Converge GetConvergeChild()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetConvergeChild, "BmGame.RAEC_Attack.GetConvergeChild");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAEC_Attack_Converge>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TargetPlayerUpdated;
    /// <summary>
    /// Function: TargetPlayerUpdated
    /// </summary>
    public unsafe override void TargetPlayerUpdated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargetPlayerUpdated, "BmGame.RAEC_Attack.TargetPlayerUpdated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateChildren;
    /// <summary>
    /// Function: CreateChildren
    /// </summary>
    public unsafe override void CreateChildren()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateChildren, "BmGame.RAEC_Attack.CreateChildren");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: PrimaryAttackChild
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_Converge PrimaryAttackChild
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_Converge>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ObjectProperty: ChaseChild
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_Chase ChaseChild
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_Chase>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// ObjectProperty: GargChild
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_CheckGarg GargChild
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_CheckGarg>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ObjectProperty: StartleChild
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_Startle StartleChild
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_Startle>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// ObjectProperty: PauseAndLookChild
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_GroupPauseAndLook PauseAndLookChild
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_GroupPauseAndLook>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// BoolProperty: bSpottedThisConverge
    /// </summary>
    public unsafe bool bSpottedThisConverge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bAttackStarted
    /// </summary>
    public unsafe bool bAttackStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bVantageEscapePlayed
    /// </summary>
    public unsafe bool bVantageEscapePlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 516); }
    }

    /// <summary>
    /// ArrayProperty: ActiveSnipers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_Search_Sub_Sniper> ActiveSnipers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_Search_Sub_Sniper>>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }
}
