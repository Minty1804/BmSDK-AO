#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPlayerControllerCombat<br/>
/// (size = 6540)
/// (flags = 144703638)
/// </summary>
public partial class RPlayerControllerCombat : BmSDK.BmGame.RPlayerController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPlayerControllerCombat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPlayerControllerCombat.
    /// </summary>
    public static RPlayerControllerCombat DefaultObject => (RPlayerControllerCombat)StaticClass().DefaultObject;

    internal RPlayerControllerCombat() { }

    /// <summary>
    /// Constructs a new RPlayerControllerCombat
    /// </summary>
    public RPlayerControllerCombat(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPlayerControllerCombat(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: NotifyCombatFinished
    /// </summary>
    public unsafe override void NotifyCombatFinished(bool BatmanWasVictorious)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.NotifyCombatFinished", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanWasVictorious, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyCombatStarted
    /// </summary>
    public unsafe override void NotifyCombatStarted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.NotifyCombatStarted", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetProjectileHelpPrompt
    /// </summary>
    public unsafe override void GetProjectileHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetProjectileHelpPrompt", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ForceDodgeProjectile
    /// </summary>
    public unsafe virtual bool ForceDodgeProjectile()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ForceDodgeProjectile", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DoQuickFireSpecialMove
    /// </summary>
    public unsafe override void DoQuickFireSpecialMove(int QuickSpecialMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DoQuickFireSpecialMove", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QuickSpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QuickGadgetB
    /// </summary>
    public unsafe virtual void QuickGadgetB()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.QuickGadgetB", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QuickGadgetX
    /// </summary>
    public unsafe virtual void QuickGadgetX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.QuickGadgetX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QuickGadgetY
    /// </summary>
    public unsafe virtual void QuickGadgetY()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.QuickGadgetY", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QuickGadgetA
    /// </summary>
    public unsafe virtual void QuickGadgetA()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.QuickGadgetA", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GadgetThumbLeft
    /// </summary>
    public unsafe virtual void GadgetThumbLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GadgetThumbLeft", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GadgetThumbRight
    /// </summary>
    public unsafe virtual void GadgetThumbRight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GadgetThumbRight", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QuickGadgetRTFire
    /// </summary>
    public unsafe override void QuickGadgetRTFire()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.QuickGadgetRTFire", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanQuickFireSpecialMove
    /// </summary>
    public unsafe virtual bool CanQuickFireSpecialMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanQuickFireSpecialMove", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanQuickFireGadget
    /// </summary>
    public unsafe virtual bool CanQuickFireGadget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanQuickFireGadget", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ServerDamagePawn
    /// </summary>
    public unsafe virtual void ServerDamagePawn(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerDamagePawn", true);
        byte* paramsPtr = stackalloc byte[260];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerDoHitPawn
    /// </summary>
    public unsafe virtual void ServerDoHitPawn(BmSDK.BmGame.RPawnCombat DamageReceiver, float DmgAmount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerDoHitPawn", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnRegisterComboValueReachedAction
    /// </summary>
    public unsafe virtual void UnRegisterComboValueReachedAction(BmSDK.BmGame.RSeqAct_ComboValueReached OldAction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UnRegisterComboValueReachedAction", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterComboValueReachedAction
    /// </summary>
    public unsafe virtual void RegisterComboValueReachedAction(BmSDK.BmGame.RSeqAct_ComboValueReached NewAction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.RegisterComboValueReachedAction", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LunaticBreakoutFinished
    /// </summary>
    public unsafe virtual void LunaticBreakoutFinished(System.Numerics.Vector3 NewThrowDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.LunaticBreakoutFinished", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewThrowDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableCapeStun
    /// </summary>
    public unsafe virtual void EnableCapeStun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.EnableCapeStun", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableCapeStun
    /// </summary>
    public unsafe override void DisableCapeStun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DisableCapeStun", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanStagger
    /// </summary>
    public unsafe override bool CanStagger()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanStagger", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: MakeBatmanLookAtEnemy
    /// </summary>
    public unsafe override bool MakeBatmanLookAtEnemy(bool bReset = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.MakeBatmanLookAtEnemy", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReset, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ReadyGadgetOrCounterReleased
    /// </summary>
    public unsafe virtual void ReadyGadgetOrCounterReleased()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ReadyGadgetOrCounterReleased", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MouseReadyGadget
    /// </summary>
    public unsafe virtual void MouseReadyGadget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.MouseReadyGadget", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReadyGadgetOrCounterPressed
    /// </summary>
    public unsafe override void ReadyGadgetOrCounterPressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ReadyGadgetOrCounterPressed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GadgetOrQuickStrikePressed
    /// </summary>
    public unsafe virtual void GadgetOrQuickStrikePressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GadgetOrQuickStrikePressed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GrappleOrStrikeGadgetPressed
    /// </summary>
    public unsafe virtual void GrappleOrStrikeGadgetPressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GrappleOrStrikeGadgetPressed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterGameAction
    /// </summary>
    public unsafe override void RegisterGameAction(BmSDK.BmGame.RGameInfo.EGameAction Action, BmSDK.Engine.Actor XPTarget = default, int XPAmount = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.RegisterGameAction", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAmount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.Destroyed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayImpactRumble
    /// </summary>
    public unsafe virtual void PlayImpactRumble(float LeftAmp = default, float RightAmp = default, float Duration = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.PlayImpactRumble", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftAmp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightAmp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NavManWTF
    /// </summary>
    public unsafe virtual void NavManWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.NavManWTF", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AIWTF
    /// </summary>
    public unsafe virtual void AIWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.AIWTF", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TutorialWTF
    /// </summary>
    public unsafe virtual void TutorialWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TutorialWTF", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PairedAnimWTF
    /// </summary>
    public unsafe virtual void PairedAnimWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.PairedAnimWTF", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StrikeWTF
    /// </summary>
    public unsafe virtual void StrikeWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.StrikeWTF", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CombatWTF
    /// </summary>
    public unsafe virtual void CombatWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CombatWTF", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SuppressVenomCamera
    /// </summary>
    public unsafe override bool SuppressVenomCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SuppressVenomCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SuppressCombatCamera
    /// </summary>
    public unsafe override bool SuppressCombatCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SuppressCombatCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShouldGoSlowMoOnNextHit
    /// </summary>
    public unsafe virtual bool ShouldGoSlowMoOnNextHit(int ComboInc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ShouldGoSlowMoOnNextHit", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboInc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: UpdateCombatCameraSuppression
    /// </summary>
    public unsafe virtual void UpdateCombatCameraSuppression()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateCombatCameraSuppression", true);
        byte* paramsPtr = stackalloc byte[0];
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

    /// <summary>
    /// Function: CombatTick
    /// </summary>
    public unsafe override void CombatTick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CombatTick", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnFinishedCombatMove
    /// </summary>
    public unsafe override void SpawnFinishedCombatMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnFinishedCombatMove", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QueueFinishedCombatMove
    /// </summary>
    public unsafe virtual void QueueFinishedCombatMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.QueueFinishedCombatMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateComboTokenHUD
    /// </summary>
    public unsafe virtual void UpdateComboTokenHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateComboTokenHUD", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetComboOnHUD
    /// </summary>
    public unsafe virtual void SetComboOnHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetComboOnHUD", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateComboOnHUD
    /// </summary>
    public unsafe virtual void UpdateComboOnHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateComboOnHUD", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActualClearLastStrikeDir
    /// </summary>
    public unsafe virtual void ActualClearLastStrikeDir()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ActualClearLastStrikeDir", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearLastStrikeDir
    /// </summary>
    public unsafe virtual void ClearLastStrikeDir()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearLastStrikeDir", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetLastStrikeDir
    /// </summary>
    public unsafe virtual void SetLastStrikeDir(System.Numerics.Vector3 StrikeDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetLastStrikeDir", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Untargetted
    /// </summary>
    public unsafe virtual void Untargetted(BmSDK.BmGame.RPawnCombat Targetter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.Untargetted", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Targetter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Targetted
    /// </summary>
    public unsafe virtual void Targetted(BmSDK.BmGame.RPawnCombat Targetter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.Targetted", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Targetter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Zapped
    /// </summary>
    public unsafe virtual void Zapped()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.Zapped", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Stunned
    /// </summary>
    public unsafe virtual void Stunned()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.Stunned", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckDodge
    /// </summary>
    public unsafe virtual void CheckDodge(BmSDK.BmGame.RPawnCombat Attacker)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CheckDodge", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnRunningStun
    /// </summary>
    public unsafe virtual void SpawnRunningStun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnRunningStun", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnRunningStrike
    /// </summary>
    public unsafe virtual void SpawnRunningStrike()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnRunningStrike", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldShowSpecialPrompt
    /// </summary>
    public unsafe virtual bool ShouldShowSpecialPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ShouldShowSpecialPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDoSecondaryGroupCombatMove
    /// </summary>
    public unsafe virtual bool CanDoSecondaryGroupCombatMove(bool bDoComboCountCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoSecondaryGroupCombatMove", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CanDoPrimaryGroupCombatMove
    /// </summary>
    public unsafe virtual bool CanDoPrimaryGroupCombatMove(bool bDoComboCountCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoPrimaryGroupCombatMove", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CanDoWeaponDestroy
    /// </summary>
    public unsafe virtual bool CanDoWeaponDestroy(bool bDoComboCountCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoWeaponDestroy", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CanDoCombatTakedown
    /// </summary>
    public unsafe virtual bool CanDoCombatTakedown(bool bDoComboCountCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoCombatTakedown", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CanDoThrow
    /// </summary>
    public unsafe virtual bool CanDoThrow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoThrow", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ServerSpawnFailMove
    /// </summary>
    public unsafe virtual void ServerSpawnFailMove(BmSDK.FName FailAnim, bool bCanBecomeThrow, bool bCanBecomeTakedown, bool bCanBecomeFloorTakedown, BmSDK.FName FailCapeState, System.Numerics.Vector3 MoveDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerSpawnFailMove", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeThrow, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeTakedown, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeFloorTakedown, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailCapeState, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnInterrogation
    /// </summary>
    public unsafe virtual bool SpawnInterrogation(BmSDK.BmGame.RPawnVillain NewTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnInterrogation", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SpawnTakedown
    /// </summary>
    public unsafe virtual bool SpawnTakedown(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnTakedown", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsValidThrowTarget
    /// </summary>
    public unsafe virtual bool IsValidThrowTarget(BmSDK.BmGame.RPawnVillain Target, System.Numerics.Vector3 MoveDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsValidThrowTarget", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: SpawnWeaponDestroy
    /// </summary>
    public unsafe virtual bool SpawnWeaponDestroy(bool bOverrideCurrentMove = default, BmSDK.BmGame.RPawnVillain NewTarget = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnWeaponDestroy", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ServerCounterPressedSimulated
    /// </summary>
    public unsafe virtual void ServerCounterPressedSimulated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerCounterPressedSimulated", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerStartSimultaneousCounterSimulated
    /// </summary>
    public unsafe virtual void ServerStartSimultaneousCounterSimulated(BmSDK.BmGame.RPawnCombat.SimultaneousCounterFormation FormationType, int InfoIndex, System.Numerics.Vector3 AnimLocation, BmSDK.Rotator CounterRotation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerStartSimultaneousCounterSimulated", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FormationType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfoIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterRotation, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerRequestFailedPairedAnimMove
    /// </summary>
    public unsafe virtual void ServerRequestFailedPairedAnimMove(BmSDK.BmGame.RPawnVillain Target, BmSDK.FName AnimName, System.Numerics.Vector3 AnimPos, BmSDK.Rotator ThrowDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestFailedPairedAnimMove", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerRequestThrow
    /// </summary>
    public unsafe virtual void ServerRequestThrow(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnPlayerCombat.FThrowInfo ThrowInfo, System.Numerics.Vector3 AnimPos, BmSDK.Rotator ThrowDir, bool bSetCapeState, bool bDirectThrow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestThrow", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowInfo, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetCapeState, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDirectThrow, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerRequestIntoThrow
    /// </summary>
    public unsafe virtual void ServerRequestIntoThrow(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargetResponse, BmSDK.Rotator MoveDir, float TargetDist, System.Numerics.Vector3 AnimPos, float AnimRot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestIntoThrow", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetResponse, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDist, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRot, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnThrow
    /// </summary>
    public unsafe virtual bool SpawnThrow(bool bOverrideCurrentMove = default, BmSDK.BmGame.RPawnVillain NewTarget = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnThrow", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ServerRequestFloorTakedownSimulated
    /// </summary>
    public unsafe virtual void ServerRequestFloorTakedownSimulated(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge ChallengeActionToTriggerIfSuccessful, float TargetDist, System.Numerics.Vector3 AnimPos, System.Numerics.Vector3 FacingDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestFloorTakedownSimulated", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeActionToTriggerIfSuccessful, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDist, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryFloorTakedown
    /// </summary>
    public unsafe virtual bool TryFloorTakedown(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryFloorTakedown", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ServerRequestProjectileCounter
    /// </summary>
    public unsafe virtual void ServerRequestProjectileCounter(BmSDK.BmGame.RBMCombatThrownObject ThrownObject)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestProjectileCounter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryBossCounter
    /// </summary>
    public unsafe virtual bool TryBossCounter(BmSDK.BmGame.RPawnVillain targ)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryBossCounter", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(targ, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TryProjectileCounter
    /// </summary>
    public unsafe virtual bool TryProjectileCounter(bool bSpawnCounter = default, BmSDK.BmGame.RBMCombatThrownObject CombatObject = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryProjectileCounter", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpawnCounter, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatObject, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TryCounter
    /// </summary>
    public unsafe virtual bool TryCounter(bool bCanFail, float TimeInitiatedByPlayer = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryCounter", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFail, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TryBeatdownCounter
    /// </summary>
    public unsafe virtual bool TryBeatdownCounter(bool bCanStartMove, float TimeInitiatedByPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryBeatdownCounter", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanStartMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TryCounteringDeathstroke
    /// </summary>
    public unsafe virtual bool TryCounteringDeathstroke(bool bCanStartMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryCounteringDeathstroke", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanStartMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TrySimultaneousCounter
    /// </summary>
    public unsafe virtual bool TrySimultaneousCounter(bool bCanStartMove, float TimeInitiatedByPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TrySimultaneousCounter", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanStartMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TryStun
    /// </summary>
    public unsafe virtual bool TryStun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryStun", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetStunMove
    /// </summary>
    public unsafe virtual BmSDK.Class GetStunMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetStunMove", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ServerSpawnSpecialMove
    /// </summary>
    public unsafe virtual void ServerSpawnSpecialMove(BmSDK.Class MoveClass, System.Numerics.Vector3 AnimPos, BmSDK.Rotator AnimRot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerSpawnSpecialMove", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRot, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsInBeatdown
    /// </summary>
    public unsafe virtual bool IsInBeatdown(BmSDK.BmGame.RPawnVillain testVillain)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsInBeatdown", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(testVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TryStrike
    /// </summary>
    public unsafe virtual bool TryStrike(float TimeInitiatedByPlayer = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryStrike", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetBatclawSlamTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetBatclawSlamTarget(BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetBatclawSlamTarget", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetQuickStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetQuickStrikeDamageType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetQuickStrikeDamageType", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetQuickStrikeType
    /// </summary>
    public unsafe virtual BmSDK.Class GetQuickStrikeType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetQuickStrikeType", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetHeavyStrikeType
    /// </summary>
    public unsafe virtual BmSDK.Class GetHeavyStrikeType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetHeavyStrikeType", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetHeavyStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetHeavyStrikeDamageType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetHeavyStrikeDamageType", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCriticalStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetCriticalStrikeDamageType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetCriticalStrikeDamageType", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCounterCriticalStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetCounterCriticalStrikeDamageType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetCounterCriticalStrikeDamageType", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: VenomFailedCounter
    /// </summary>
    public unsafe virtual void VenomFailedCounter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.VenomFailedCounter", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: VenomDismountOrStunCounter
    /// </summary>
    public unsafe virtual void VenomDismountOrStunCounter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.VenomDismountOrStunCounter", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: VenomCounter
    /// </summary>
    public unsafe virtual void VenomCounter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.VenomCounter", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: VenomAttack
    /// </summary>
    public unsafe virtual void VenomAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.VenomAttack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChargeVenomReleased
    /// </summary>
    public unsafe virtual void ChargeVenomReleased()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ChargeVenomReleased", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChargeVenomPressed
    /// </summary>
    public unsafe virtual void ChargeVenomPressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ChargeVenomPressed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: VenomShockwave
    /// </summary>
    public unsafe virtual void VenomShockwave()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.VenomShockwave", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartRun
    /// </summary>
    public unsafe override void StartRun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.StartRun", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerRideVenom
    /// </summary>
    public unsafe virtual bool TriggerRideVenom()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerRideVenom", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TriggerGroundTakedown
    /// </summary>
    public unsafe override bool TriggerGroundTakedown(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerGroundTakedown", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TriggerCounter
    /// </summary>
    public unsafe virtual bool TriggerCounter(bool bCanFail)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerCounter", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFail, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: RejectStealthTakeDown
    /// </summary>
    public unsafe override void RejectStealthTakeDown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.RejectStealthTakeDown", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryToStartCombatInterrogation
    /// </summary>
    public unsafe virtual bool TryToStartCombatInterrogation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryToStartCombatInterrogation", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TryToStartCombatTakeDown
    /// </summary>
    public unsafe override bool TryToStartCombatTakeDown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryToStartCombatTakeDown", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: BankPoints
    /// </summary>
    public unsafe virtual void BankPoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.BankPoints", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BankPointsInternal
    /// </summary>
    public unsafe virtual void BankPointsInternal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.BankPointsInternal", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GrabReleased
    /// </summary>
    public unsafe override void GrabReleased()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GrabReleased", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GrabHeld
    /// </summary>
    public unsafe virtual void GrabHeld()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GrabHeld", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TrySecondaryGroupCombatMove
    /// </summary>
    public unsafe virtual bool TrySecondaryGroupCombatMove(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TrySecondaryGroupCombatMove", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TryPrimaryGroupCombatMove
    /// </summary>
    public unsafe virtual bool TryPrimaryGroupCombatMove(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryPrimaryGroupCombatMove", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GrabPressed
    /// </summary>
    public unsafe override void GrabPressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GrabPressed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FloorTakedownModifierPressed
    /// </summary>
    public unsafe virtual void FloorTakedownModifierPressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.FloorTakedownModifierPressed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BlockBreakerReleased
    /// </summary>
    public unsafe virtual void BlockBreakerReleased()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.BlockBreakerReleased", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerBlockBreaker
    /// </summary>
    public unsafe virtual void TriggerBlockBreaker()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerBlockBreaker", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerSecondaryGroupCombatMove
    /// </summary>
    public unsafe virtual void TriggerSecondaryGroupCombatMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerSecondaryGroupCombatMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerPrimaryGroupCombatMove
    /// </summary>
    public unsafe virtual void TriggerPrimaryGroupCombatMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerPrimaryGroupCombatMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCombatTakedown
    /// </summary>
    public unsafe virtual void TriggerCombatTakedown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerCombatTakedown", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerWeaponDestroy
    /// </summary>
    public unsafe virtual void TriggerWeaponDestroy()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerWeaponDestroy", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerThrow
    /// </summary>
    public unsafe virtual void TriggerThrow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerThrow", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerQuickStrike
    /// </summary>
    public unsafe override void TriggerQuickStrike()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerQuickStrike", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NewComboMoveStarted
    /// </summary>
    public unsafe virtual void NewComboMoveStarted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.NewComboMoveStarted", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateRunningTimers
    /// </summary>
    public unsafe virtual void UpdateRunningTimers(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateRunningTimers", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe override void OnRoomChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.OnRoomChange", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyTakeDamage
    /// </summary>
    public unsafe override void NotifyTakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.NotifyTakeDamage", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateCombatHitVars
    /// </summary>
    public unsafe virtual void UpdateCombatHitVars(BmSDK.Engine.Controller InstigatedBy, int Damage, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateCombatHitVars", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetScoreOnHud
    /// </summary>
    public unsafe virtual void SetScoreOnHud()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetScoreOnHud", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddScore
    /// </summary>
    public unsafe virtual void AddScore(int Amount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.AddScore", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddScoreForMove
    /// </summary>
    public unsafe virtual void AddScoreForMove(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType, int ComboMultiplier, BmSDK.BmGame.RPawnCombat Target, int numTargets)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.AddScoreForMove", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboMultiplier, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(numTargets, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOffKnifeComboAttackPrompt
    /// </summary>
    public unsafe virtual void TurnOffKnifeComboAttackPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TurnOffKnifeComboAttackPrompt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOnKnifeComboAttackPrompt
    /// </summary>
    public unsafe virtual void TurnOnKnifeComboAttackPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TurnOnKnifeComboAttackPrompt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOffMAComboChainPrompt
    /// </summary>
    public unsafe virtual void TurnOffMAComboChainPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TurnOffMAComboChainPrompt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOnMAComboChainPrompt
    /// </summary>
    public unsafe virtual void TurnOnMAComboChainPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TurnOnMAComboChainPrompt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOffMADoubleCounterPrompt
    /// </summary>
    public unsafe virtual void TurnOffMADoubleCounterPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TurnOffMADoubleCounterPrompt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOnMADoubleCounterPrompt
    /// </summary>
    public unsafe virtual void TurnOnMADoubleCounterPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TurnOnMADoubleCounterPrompt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOffCounterPrompt
    /// </summary>
    public unsafe virtual void TurnOffCounterPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TurnOffCounterPrompt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOnCounterPrompt
    /// </summary>
    public unsafe virtual void TurnOnCounterPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TurnOnCounterPrompt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetComboLevel
    /// </summary>
    public unsafe virtual int GetComboLevel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetComboLevel", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDoSpecialMove
    /// </summary>
    public unsafe virtual bool CanDoSpecialMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoSpecialMove", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearSpecialMove
    /// </summary>
    public unsafe virtual void ClearSpecialMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearSpecialMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DecrementSpecialMove
    /// </summary>
    public unsafe virtual void DecrementSpecialMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DecrementSpecialMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasSpecialMoveToken
    /// </summary>
    public unsafe virtual bool HasSpecialMoveToken()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.HasSpecialMoveToken", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpecialMoveTargetInRange
    /// </summary>
    public unsafe virtual bool SpecialMoveTargetInRange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpecialMoveTargetInRange", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetComboLength
    /// </summary>
    public unsafe virtual int GetComboLength()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetComboLength", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetNumAwayFromCombo
    /// </summary>
    public unsafe virtual int GetNumAwayFromCombo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetNumAwayFromCombo", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsInComboForSuper
    /// </summary>
    public unsafe virtual bool IsInComboForSuper()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsInComboForSuper", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsInCombo
    /// </summary>
    public unsafe virtual bool IsInCombo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsInCombo", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetComboMinLength
    /// </summary>
    public unsafe virtual int GetComboMinLength()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetComboMinLength", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanContinueCombo
    /// </summary>
    public unsafe virtual bool CanContinueCombo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanContinueCombo", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DisableCombo
    /// </summary>
    public unsafe virtual void DisableCombo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DisableCombo", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ContinueComboTimerComplete
    /// </summary>
    public unsafe virtual void ContinueComboTimerComplete()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ContinueComboTimerComplete", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetContinueComboTimer
    /// </summary>
    public unsafe virtual void SetContinueComboTimer(float ComboWindow = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetContinueComboTimer", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboWindow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearCombo
    /// </summary>
    public unsafe virtual void ClearCombo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearCombo", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetServerCombo
    /// </summary>
    public unsafe virtual void SetServerCombo(int NewAmount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetServerCombo", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCombatMoveDurationMulti
    /// </summary>
    public unsafe virtual float GetCombatMoveDurationMulti()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetCombatMoveDurationMulti", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ResetSuperComboMode
    /// </summary>
    public unsafe virtual void ResetSuperComboMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ResetSuperComboMode", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSuperComboMode
    /// </summary>
    public unsafe virtual void SetSuperComboMode(int NewComboAmount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetSuperComboMode", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewComboAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ExitSuperCombo
    /// </summary>
    public unsafe virtual void ExitSuperCombo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ExitSuperCombo", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnterSuperCombo
    /// </summary>
    public unsafe virtual void EnterSuperCombo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.EnterSuperCombo", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetSuperComboModeProportion
    /// </summary>
    public unsafe virtual float GetSuperComboModeProportion(int TestComboSize)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetSuperComboModeProportion", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestComboSize, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetSuperComboModePostProcess
    /// </summary>
    public unsafe virtual void SetSuperComboModePostProcess(float ComboProportion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetSuperComboModePostProcess", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboProportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCombatFOVModifier
    /// </summary>
    public unsafe virtual int GetCombatFOVModifier()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetCombatFOVModifier", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateSuperComboModeFX
    /// </summary>
    public unsafe virtual void UpdateSuperComboModeFX(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateSuperComboModeFX", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncCombo
    /// </summary>
    public unsafe virtual void IncCombo(BmSDK.BmGame.RPawnCombat PawnAttacked = default, int IncAmount = default, int IncSpecialMoveCount = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IncCombo", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnAttacked, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncAmount, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncSpecialMoveCount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetComboIncCue
    /// </summary>
    public unsafe virtual void SetComboIncCue(BmSDK.Engine.SoundCue NewCue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetComboIncCue", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetPerFightStats
    /// </summary>
    public unsafe virtual void ResetPerFightStats()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ResetPerFightStats", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetMaxComboSize
    /// </summary>
    public unsafe virtual void ResetMaxComboSize()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ResetMaxComboSize", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetMaxComboSize
    /// </summary>
    public unsafe virtual int GetMaxComboSize()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetMaxComboSize", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncCombosStarted
    /// </summary>
    public unsafe virtual void IncCombosStarted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IncCombosStarted", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAverageCombo
    /// </summary>
    public unsafe virtual int GetAverageCombo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetAverageCombo", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetNumCombosStarted
    /// </summary>
    public unsafe virtual int GetNumCombosStarted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetNumCombosStarted", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ResetCombosStarted
    /// </summary>
    public unsafe virtual void ResetCombosStarted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ResetCombosStarted", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ExitComboFlow
    /// </summary>
    public unsafe virtual void ExitComboFlow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ExitComboFlow", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnterComboFlow
    /// </summary>
    public unsafe virtual void EnterComboFlow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.EnterComboFlow", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OutputComboMoves
    /// </summary>
    public unsafe virtual void OutputComboMoves()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.OutputComboMoves", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearComboMoves
    /// </summary>
    public unsafe virtual void ClearComboMoves()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearComboMoves", true);
        byte* paramsPtr = stackalloc byte[0];
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

    /// <summary>
    /// Function: SetMaxVariation
    /// </summary>
    public unsafe virtual void SetMaxVariation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetMaxVariation", true);
        byte* paramsPtr = stackalloc byte[0];
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

    /// <summary>
    /// Function: ComputeComboVariation
    /// </summary>
    public unsafe virtual int ComputeComboVariation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ComputeComboVariation", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetMaxComboVariationInChallenge
    /// </summary>
    public unsafe virtual int GetMaxComboVariationInChallenge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetMaxComboVariationInChallenge", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ResetComboMoveTypes
    /// </summary>
    public unsafe virtual void ResetComboMoveTypes()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ResetComboMoveTypes", true);
        byte* paramsPtr = stackalloc byte[0];
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

    /// <summary>
    /// Function: ResetMaxComboVariation
    /// </summary>
    public unsafe virtual void ResetMaxComboVariation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ResetMaxComboVariation", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SaveComboScore
    /// </summary>
    public unsafe virtual void SaveComboScore()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SaveComboScore", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetGadgetVariation
    /// </summary>
    public unsafe virtual void ResetGadgetVariation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ResetGadgetVariation", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetComboGadgetVariationScore
    /// </summary>
    public unsafe virtual int GetComboGadgetVariationScore()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetComboGadgetVariationScore", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetComboVariationScore
    /// </summary>
    public unsafe virtual int GetComboVariationScore()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetComboVariationScore", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: MovePerformed
    /// </summary>
    public unsafe virtual void MovePerformed(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType, BmSDK.BmGame.RPawnCombat Target, bool bAddScore = default, int ComboForScore = default, int NumOfTargets = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.MovePerformed", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddScore, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboForScore, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumOfTargets, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncTutorialProgressForMove
    /// </summary>
    public unsafe virtual void IncTutorialProgressForMove(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType, BmSDK.BmGame.RPawnCombat Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IncTutorialProgressForMove", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BlockedBy
    /// </summary>
    public unsafe virtual void BlockedBy(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.BlockedBy", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldShowAutoCombatHints
    /// </summary>
    public unsafe virtual bool ShouldShowAutoCombatHints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ShouldShowAutoCombatHints", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearHitsSinceCounter
    /// </summary>
    public unsafe virtual void ClearHitsSinceCounter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearHitsSinceCounter", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncHitsSinceCounter
    /// </summary>
    public unsafe virtual void IncHitsSinceCounter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IncHitsSinceCounter", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanDoComboProjectileGadget
    /// </summary>
    public unsafe virtual bool CanDoComboProjectileGadget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoComboProjectileGadget", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDoComboWhip
    /// </summary>
    public unsafe virtual bool CanDoComboWhip()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoComboWhip", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDoComboBatarang
    /// </summary>
    public unsafe virtual bool CanDoComboBatarang()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoComboBatarang", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TryRedirect
    /// </summary>
    public unsafe virtual bool TryRedirect(BmSDK.BmGame.RPawnVillain TargetPawn = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryRedirect", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ServerLockProjectileThrowTarget
    /// </summary>
    public unsafe virtual void ServerLockProjectileThrowTarget(BmSDK.BmGame.RPawnVillain ThrowTarget, BmSDK.Rotator ThrowDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerLockProjectileThrowTarget", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerRequestEvade
    /// </summary>
    public unsafe virtual void ServerRequestEvade(System.Numerics.Vector3 EvadeDir, BmSDK.FName EvadeName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestEvade", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnEvade
    /// </summary>
    public unsafe override void SpawnEvade(bool bCanQueue = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnEvade", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanQueue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryToQueueEvade
    /// </summary>
    public unsafe virtual void TryToQueueEvade()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryToQueueEvade", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetWallEvadeInfo
    /// </summary>
    public unsafe virtual bool GetWallEvadeInfo(System.Numerics.Vector3 Dir, out System.Numerics.Vector3 WallLocation, out System.Numerics.Vector3 WallNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetWallEvadeInfo", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        WallLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        WallNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: DialogueModeTimeout
    /// </summary>
    public unsafe virtual void DialogueModeTimeout()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DialogueModeTimeout", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryingToSetDialogueMode
    /// </summary>
    public unsafe virtual void TryingToSetDialogueMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryingToSetDialogueMode", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoubleTapRun
    /// </summary>
    public unsafe override void DoubleTapRun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DoubleTapRun", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearLastTarget
    /// </summary>
    public unsafe virtual void ClearLastTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearLastTarget", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CombatMoveFinished
    /// </summary>
    public unsafe virtual void CombatMoveFinished(BmSDK.BmGame.RCombatMove FinishedMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CombatMoveFinished", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CombatMoveInitialised
    /// </summary>
    public unsafe virtual void CombatMoveInitialised()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CombatMoveInitialised", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetHelpPrompt", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowTutorial
    /// </summary>
    public unsafe virtual void ShowTutorial(BmSDK.BmGame.RHUDPrompt HelpPrompt, BmSDK.BmGame.RPersistentData.ETutorialType TutorialToShow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ShowTutorial", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TutorialToShow, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetHighestPriorityTutorial
    /// </summary>
    public unsafe virtual void GetHighestPriorityTutorial(out BmSDK.BmGame.RPersistentData.ETutorialType BestTutorial, out BmSDK.FString BestTutorialPrompt, out BmSDK.BmGame.RHUDPrompt.EControlIcon BestControlIcon, out int bShowTutorial)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetHighestPriorityTutorial", true);
        byte* paramsPtr = stackalloc byte[24];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BestTutorial = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ETutorialType>(paramsPtr + 0);
        BestTutorialPrompt = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
        BestControlIcon = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 16);
        bShowTutorial = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
        return;
    }

    /// <summary>
    /// Function: CheckTutorial
    /// </summary>
    public unsafe virtual bool CheckTutorial(BmSDK.BmGame.RPersistentData.ETutorialType CheckTutorialType, out int BestPriority, out BmSDK.BmGame.RPersistentData.ETutorialType BestTutorial, out BmSDK.FString BestPrompt, out int bShowTutorial)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CheckTutorial", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckTutorialType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BestPriority = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        BestTutorial = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ETutorialType>(paramsPtr + 8);
        BestPrompt = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
        bShowTutorial = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: IsInCombat
    /// </summary>
    public unsafe override bool IsInCombat(bool bForceCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsInCombat", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetCM
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMCombatManager GetCM()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetCM", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindFloorTakedownTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain FindFloorTakedownTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.FindFloorTakedownTarget", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: InputHeading
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 InputHeading(bool bCanBeZero = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.InputHeading", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBeZero, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: HasMovementInput
    /// </summary>
    public unsafe virtual bool HasMovementInput()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.HasMovementInput", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsBatarangPrimed
    /// </summary>
    public unsafe virtual bool IsBatarangPrimed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsBatarangPrimed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetZapTime
    /// </summary>
    public unsafe virtual float GetZapTime()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetZapTime", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetStunTime
    /// </summary>
    public unsafe virtual float GetStunTime()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetStunTime", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDoCombatWhileMoveInputIsIgnored
    /// </summary>
    public unsafe virtual bool CanDoCombatWhileMoveInputIsIgnored()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoCombatWhileMoveInputIsIgnored", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDoCombat
    /// </summary>
    public unsafe virtual bool CanDoCombat(bool CheckForEvade = default, bool bDebugOutput = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoCombat", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckForEvade, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugOutput, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsZapped
    /// </summary>
    public unsafe virtual bool IsZapped()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsZapped", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsStunned
    /// </summary>
    public unsafe virtual bool IsStunned()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsStunned", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasBeenHit
    /// </summary>
    public unsafe virtual bool HasBeenHit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.HasBeenHit", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartBeenHitCheck
    /// </summary>
    public unsafe virtual void StartBeenHitCheck()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.StartBeenHitCheck", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasEverBeenHit
    /// </summary>
    public unsafe virtual bool HasEverBeenHit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.HasEverBeenHit", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartEverBeenHitCheck
    /// </summary>
    public unsafe virtual void StartEverBeenHitCheck()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.StartEverBeenHitCheck", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsInCombatForDialogue
    /// </summary>
    public unsafe virtual bool IsInCombatForDialogue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsInCombatForDialogue", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsValidStrikeTarget
    /// </summary>
    public unsafe virtual bool IsValidStrikeTarget(System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType, BmSDK.BmGame.RPawnVillain TestPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsValidStrikeTarget", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: FindStrikeTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain FindStrikeTarget(System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.FindStrikeTarget", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetLookAtEnemy
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat GetLookAtEnemy()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetLookAtEnemy", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetMovesToUnlockSpecial
    /// </summary>
    public unsafe virtual int GetMovesToUnlockSpecial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetMovesToUnlockSpecial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RemoveCounterListener
    /// </summary>
    public unsafe virtual void RemoveCounterListener(System.IntPtr del)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.RemoveCounterListener", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(del, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddCounterListener
    /// </summary>
    public unsafe virtual void AddCounterListener(System.IntPtr del)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.AddCounterListener", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(del, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QuickGadgetThumbLeftTimeout
    /// </summary>
    public unsafe virtual void QuickGadgetThumbLeftTimeout()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.QuickGadgetThumbLeftTimeout", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QuickGadgetThumbRightTimeout
    /// </summary>
    public unsafe virtual void QuickGadgetThumbRightTimeout()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.QuickGadgetThumbRightTimeout", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryCountering
    /// </summary>
    public unsafe virtual bool TryCountering(BmSDK.BmGame.RPlayerControllerCombat Controller, bool bCanStartMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryCountering", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Controller, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanStartMove, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Struct: FComboMoveInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FComboMoveInfo
    {
        /// <summary>
        /// ByteProperty: MoveType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EComboMoveType MoveType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EComboMoveType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: MoveNum
        /// </summary>
        public unsafe int MoveNum
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FStruckInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FStruckInfo
    {
        /// <summary>
        /// ObjectProperty: PawnAttacked
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnCombat PawnAttacked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ConsecutiveHits
        /// </summary>
        public unsafe int ConsecutiveHits
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: CombatManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager CombatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager>(Ptr + 5040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5040); }
    }

    /// <summary>
    /// ArrayProperty: CounteringListeners
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> CounteringListeners
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 5044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5044); }
    }

    /// <summary>
    /// BoolProperty: bStunned
    /// </summary>
    public unsafe bool bStunned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bZapped
    /// </summary>
    public unsafe bool bZapped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bSuppressCombatCameraInCorridor
    /// </summary>
    public unsafe bool bSuppressCombatCameraInCorridor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bPlayFinishedCombatMoveWhenAble
    /// </summary>
    public unsafe bool bPlayFinishedCombatMoveWhenAble
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bAllowCombo
    /// </summary>
    public unsafe bool bAllowCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bForceSpecialCombo
    /// </summary>
    public unsafe bool bForceSpecialCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bHitDuringCombat
    /// </summary>
    public unsafe bool bHitDuringCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bPerfectFreeFlowCombat
    /// </summary>
    public unsafe bool bPerfectFreeFlowCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bCanCheckForPerfectFreeFlowCombat
    /// </summary>
    public unsafe bool bCanCheckForPerfectFreeFlowCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bBeenHit
    /// </summary>
    public unsafe bool bBeenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bEverBeenHit
    /// </summary>
    public unsafe bool bEverBeenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByStunStick
    /// </summary>
    public unsafe bool bBeenHitByStunStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByKnife
    /// </summary>
    public unsafe bool bBeenHitByKnife
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitBySword
    /// </summary>
    public unsafe bool bBeenHitBySword
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByCombatGun
    /// </summary>
    public unsafe bool bBeenHitByCombatGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitBySimultaneousAttack
    /// </summary>
    public unsafe bool bBeenHitBySimultaneousAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByArmouredThug
    /// </summary>
    public unsafe bool bBeenHitByArmouredThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByShieldThug
    /// </summary>
    public unsafe bool bBeenHitByShieldThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByLieutenant
    /// </summary>
    public unsafe bool bBeenHitByLieutenant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByTitanHenchman
    /// </summary>
    public unsafe bool bBeenHitByTitanHenchman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByProjectile
    /// </summary>
    public unsafe bool bBeenHitByProjectile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitBySniper
    /// </summary>
    public unsafe bool bBeenHitBySniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByMine
    /// </summary>
    public unsafe bool bBeenHitByMine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bSpottedByThermal
    /// </summary>
    public unsafe bool bSpottedByThermal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bTryingToSetDialogueMode
    /// </summary>
    public unsafe bool bTryingToSetDialogueMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bShowEvadePrompt
    /// </summary>
    public unsafe bool bShowEvadePrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bCanDoComboBatarang
    /// </summary>
    public unsafe bool bCanDoComboBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bMirroredFailAnim
    /// </summary>
    public unsafe bool bMirroredFailAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bUseComboIncCue
    /// </summary>
    public unsafe bool bUseComboIncCue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bLieutenantStrikeHelp
    /// </summary>
    public unsafe bool bLieutenantStrikeHelp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bDisallowCombat
    /// </summary>
    public unsafe bool bDisallowCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bDisallowEvade
    /// </summary>
    public unsafe bool bDisallowEvade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5056); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5056); }
    }

    /// <summary>
    /// BoolProperty: bCapeStunDisabled
    /// </summary>
    public unsafe bool bCapeStunDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5060) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5060); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5060); }
    }

    /// <summary>
    /// BoolProperty: bInSuperComboMode
    /// </summary>
    public unsafe bool bInSuperComboMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5060) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5060); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5060); }
    }

    /// <summary>
    /// BoolProperty: bAllowSuperComboModePP
    /// </summary>
    public unsafe bool bAllowSuperComboModePP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5060) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5060); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5060); }
    }

    /// <summary>
    /// BoolProperty: bAllowInteractionMidCombat
    /// </summary>
    public unsafe bool bAllowInteractionMidCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5060) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5060); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5060); }
    }

    /// <summary>
    /// BoolProperty: bNextCombatMoveClearsSuperComboMode
    /// </summary>
    public unsafe bool bNextCombatMoveClearsSuperComboMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5060) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5060); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5060); }
    }

    /// <summary>
    /// BoolProperty: bCouldDoCombatWhenCounterPressed
    /// </summary>
    public unsafe bool bCouldDoCombatWhenCounterPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5060) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5060); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5060); }
    }

    /// <summary>
    /// FloatProperty: StunnedTime
    /// </summary>
    public unsafe float StunnedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5064); }
    }

    /// <summary>
    /// FloatProperty: ZappedTime
    /// </summary>
    public unsafe float ZappedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5068); }
    }

    /// <summary>
    /// ObjectProperty: StunnedPostProcess
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess StunnedPostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 5072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5072); }
    }

    /// <summary>
    /// ObjectProperty: ElectroPostProcess
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess ElectroPostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 5076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5076); }
    }

    /// <summary>
    /// ObjectProperty: ImpactRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ImpactRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 5080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5080); }
    }

    /// <summary>
    /// IntProperty: ComboSize
    /// </summary>
    public unsafe int ComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5084); }
    }

    /// <summary>
    /// IntProperty: CurrMaxComboSize
    /// </summary>
    public unsafe int CurrMaxComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5088); }
    }

    /// <summary>
    /// IntProperty: TotalMaxComboSize
    /// </summary>
    public unsafe int TotalMaxComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5092); }
    }

    /// <summary>
    /// IntProperty: NumTimesHit
    /// </summary>
    public unsafe int NumTimesHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5096); }
    }

    /// <summary>
    /// IntProperty: CombatScore
    /// </summary>
    public unsafe int CombatScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5100); }
    }

    /// <summary>
    /// ArrayProperty: TargettedBy
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> TargettedBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 5104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5104); }
    }

    /// <summary>
    /// StructProperty: LastStrikeDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastStrikeDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5116);

    /// <summary>
    /// FloatProperty: RunningTimer
    /// </summary>
    public unsafe float RunningTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5128); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceRunPressed
    /// </summary>
    public unsafe float TimeSinceRunPressed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5132); }
    }

    /// <summary>
    /// IntProperty: MovesSinceSpecial
    /// </summary>
    public unsafe int MovesSinceSpecial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5136); }
    }

    /// <summary>
    /// IntProperty: MovesSinceFirstSpecial
    /// </summary>
    public unsafe int MovesSinceFirstSpecial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5140); }
    }

    /// <summary>
    /// IntProperty: SpecialMoveTokens
    /// </summary>
    public unsafe int SpecialMoveTokens
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5144); }
    }

    /// <summary>
    /// IntProperty: PreviousSpecialMovesForComboTakedown
    /// </summary>
    public unsafe int PreviousSpecialMovesForComboTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5148); }
    }

    /// <summary>
    /// IntProperty: InstantTakeDownTokens
    /// </summary>
    public unsafe int InstantTakeDownTokens
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5152); }
    }

    /// <summary>
    /// IntProperty: CombosStarted
    /// </summary>
    public unsafe int CombosStarted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5156); }
    }

    /// <summary>
    /// IntProperty: CombosAchieved
    /// </summary>
    public unsafe int CombosAchieved
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5160); }
    }

    /// <summary>
    /// IntProperty: CummulativeComboAchieved
    /// </summary>
    public unsafe int CummulativeComboAchieved
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5164); }
    }

    /// <summary>
    /// IntProperty: HitCountDuringCombat
    /// </summary>
    public unsafe int HitCountDuringCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5168); }
    }

    /// <summary>
    /// IntProperty: CounterPrompt
    /// </summary>
    public unsafe int CounterPrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5172); }
    }

    /// <summary>
    /// FloatProperty: CounterPromptTimer
    /// </summary>
    public unsafe float CounterPromptTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5176); }
    }

    /// <summary>
    /// IntProperty: MaxComboSize
    /// </summary>
    public unsafe int MaxComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5180); }
    }

    /// <summary>
    /// IntProperty: MaxComboVariation
    /// </summary>
    public unsafe int MaxComboVariation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5184); }
    }

    /// <summary>
    /// IntProperty: MaxComboVariationInChallenge
    /// </summary>
    public unsafe int MaxComboVariationInChallenge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5188); }
    }

    /// <summary>
    /// IntProperty: StoredComboBonus
    /// </summary>
    public unsafe int StoredComboBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5192); }
    }

    /// <summary>
    /// IntProperty: StoredVariationBonus
    /// </summary>
    public unsafe int StoredVariationBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5196); }
    }

    /// <summary>
    /// IntProperty: StoredGadgetVariationBonus
    /// </summary>
    public unsafe int StoredGadgetVariationBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5200); }
    }

    /// <summary>
    /// IntProperty: StoredIntimidationTakedownsPerformed
    /// </summary>
    public unsafe int StoredIntimidationTakedownsPerformed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5204); }
    }

    /// <summary>
    /// IntProperty: StoredPredatorVariationBonus
    /// </summary>
    public unsafe int StoredPredatorVariationBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5208); }
    }

    /// <summary>
    /// ComponentProperty: XPBonusRoom
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState XPBonusRoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 5212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5212); }
    }

    /// <summary>
    /// IntProperty: HitsSinceCounter
    /// </summary>
    public unsafe int HitsSinceCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5216); }
    }

    /// <summary>
    /// IntProperty: SetComboFrames
    /// </summary>
    public unsafe int SetComboFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5220); }
    }

    /// <summary>
    /// IntProperty: ShowCriticalFrames
    /// </summary>
    public unsafe int ShowCriticalFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5224); }
    }

    /// <summary>
    /// FloatProperty: NotInCombatTimer
    /// </summary>
    public unsafe float NotInCombatTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5228); }
    }

    /// <summary>
    /// ComponentProperty: ComboIncAC
    /// </summary>
    public unsafe BmSDK.Engine.AudioComponent ComboIncAC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AudioComponent>(Ptr + 5232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5232); }
    }

    /// <summary>
    /// IntProperty: BlockedByArmouredSinceBeatdown
    /// </summary>
    public unsafe int BlockedByArmouredSinceBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5236); }
    }

    /// <summary>
    /// IntProperty: BlockedByShieldSinceAerial
    /// </summary>
    public unsafe int BlockedByShieldSinceAerial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5240); }
    }

    /// <summary>
    /// IntProperty: BlockedByTitanSinceSuperStun
    /// </summary>
    public unsafe int BlockedByTitanSinceSuperStun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5244); }
    }

    /// <summary>
    /// IntProperty: BlockedByArmouredLieutenant
    /// </summary>
    public unsafe int BlockedByArmouredLieutenant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5248); }
    }

    /// <summary>
    /// IntProperty: StunStickHits
    /// </summary>
    public unsafe int StunStickHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5252); }
    }

    /// <summary>
    /// IntProperty: BladeHits
    /// </summary>
    public unsafe int BladeHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5256); }
    }

    /// <summary>
    /// IntProperty: ChainAttackHits
    /// </summary>
    public unsafe int ChainAttackHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5260); }
    }

    /// <summary>
    /// IntProperty: ComboChainAttackHits
    /// </summary>
    public unsafe int ComboChainAttackHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5264); }
    }

    /// <summary>
    /// IntProperty: DeathstrokeCounterHits
    /// </summary>
    public unsafe int DeathstrokeCounterHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5268); }
    }

    /// <summary>
    /// ArrayProperty: ComboValueReachedActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_ComboValueReached> ComboValueReachedActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_ComboValueReached>>(Ptr + 5272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5272); }
    }

    /// <summary>
    /// ObjectProperty: HeadToHeadSpawner
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_HeadToHeadCombatSpawnerBase HeadToHeadSpawner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_HeadToHeadCombatSpawnerBase>(Ptr + 5284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5284); }
    }

    /// <summary>
    /// IntProperty: ConsecutiveBatarangsOrRedirects
    /// </summary>
    public unsafe int ConsecutiveBatarangsOrRedirects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5288); }
    }

    /// <summary>
    /// StructProperty: LastAttacked
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPlayerControllerCombat.FStruckInfo LastAttacked
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPlayerControllerCombat.FStruckInfo>(Ptr + 5292);

    /// <summary>
    /// ArrayProperty: ComboMoves
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerControllerCombat.FComboMoveInfo> ComboMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerControllerCombat.FComboMoveInfo>>(Ptr + 5300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5300); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: MoveTypeCount
    /// </summary>
    public InlineArray<int> MoveTypeCount => new(72, Ptr + 5312, 4, this);

    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5312); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5316); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5320); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5324); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5328); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5332); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5336); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5340); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5344); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5348); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5352); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5356); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5360); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5364); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5368); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5372); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5376); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5380); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5384); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5388); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5392); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5396); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5400); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5404); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5408); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5412); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5416); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5420); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5424); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5428); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5432); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5436); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5440); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5444); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5448); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5452); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5456); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5460); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5464); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5468); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5472); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5476); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5480); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5484); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5488); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5492); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5496); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5500); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5504); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5508); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5512); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5516); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5520); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5524); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5528); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5532); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5536); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5540); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5544); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5548); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5552); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5556); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5560); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5564); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5568); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5572); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5576); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5580); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5584); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5588); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5592); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_71
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5596); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: ComboMoveType
    /// </summary>
    public InlineArray<int> ComboMoveType => new(72, Ptr + 5600, 4, this);

    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5600); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5604); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5608); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5612); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5616); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5620); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5624); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5628); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5632); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5636); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5640); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5644); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5648); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5652); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5656); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5660); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5664); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5668); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5672); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5676); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5680); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5684); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5688); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5692); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5696); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5700); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5704); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5708); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5712); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5716); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5720); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5724); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5728); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5732); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5736); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5740); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5744); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5748); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5752); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5756); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5760); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5764); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5768); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5772); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5776); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5780); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5784); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5788); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5792); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5796); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5800); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5804); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5808); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5812); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5816); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5820); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5824); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5828); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5832); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5836); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5840); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5844); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5848); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5852); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5856); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5860); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5864); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5868); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5872); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5876); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5880); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_71
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5884); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: GadgetMoveType
    /// </summary>
    public InlineArray<int> GadgetMoveType => new(72, Ptr + 5888, 4, this);

    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5888); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5892); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5896); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5900); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5904); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5908); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5912); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5916); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5920); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5924); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5928); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5932); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5936); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5940); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5944); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5948); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5952); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5956); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5960); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5964); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5968); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5972); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5976); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5980); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5984); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5988); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5992); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5996); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6000); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6004); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6008); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6012); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6016); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6020); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6024); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6028); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6032); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6036); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6040); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6044); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6048); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6052); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6056); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6060); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6064); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6068); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6072); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6076); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6080); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6084); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6088); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6092); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6096); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6100); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6104); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6108); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6112); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6116); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6120); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6124); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6128); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6132); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6136); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6140); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6144); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6148); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6152); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6156); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6160); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6164); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6168); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_71
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6172); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: SavedComboMoveType
    /// </summary>
    public InlineArray<int> SavedComboMoveType => new(72, Ptr + 6176, 4, this);

    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6176); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6180); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6184); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6188); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6192); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6196); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6200); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6204); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6208); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6212); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6216); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6220); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6224); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6228); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6232); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6236); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6240); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6244); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6248); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6252); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6256); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6260); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6264); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6268); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6272); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6276); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6280); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6284); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6288); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6292); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6296); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6300); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6304); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6308); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6312); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6316); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6320); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6324); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6328); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6332); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6336); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6340); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6344); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6348); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6352); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6356); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6360); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6364); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6368); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6372); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6376); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6380); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6384); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6388); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6392); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6396); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6400); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6404); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6408); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6412); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6416); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6420); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6424); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6428); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6432); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6436); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6440); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6444); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6448); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6452); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6456); }
    }
    /// <summary>
    /// IntProperty: SavedComboMoveType
    /// </summary>
    public unsafe int SavedComboMoveType_71
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6460); }
    }

    /// <summary>
    /// IntProperty: SavedComboSize
    /// </summary>
    public unsafe int SavedComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6464); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLookAtTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat CurrentLookAtTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 6468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6468); }
    }

    /// <summary>
    /// FloatProperty: CurrentLookAtTargetTime
    /// </summary>
    public unsafe float CurrentLookAtTargetTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6472); }
    }

    /// <summary>
    /// IntProperty: FrontCounters
    /// </summary>
    public unsafe int FrontCounters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6476); }
    }

    /// <summary>
    /// IntProperty: BackCounters
    /// </summary>
    public unsafe int BackCounters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6480); }
    }

    /// <summary>
    /// IntProperty: SuperComboModeMin
    /// </summary>
    public unsafe int SuperComboModeMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6484); }
    }

    /// <summary>
    /// IntProperty: SuperComboModeMax
    /// </summary>
    public unsafe int SuperComboModeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6488); }
    }

    /// <summary>
    /// FloatProperty: SuperComboModeMinSpeed
    /// </summary>
    public unsafe float SuperComboModeMinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6492); }
    }

    /// <summary>
    /// FloatProperty: SuperComboModeMinDurationMulti
    /// </summary>
    public unsafe float SuperComboModeMinDurationMulti
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6496); }
    }

    /// <summary>
    /// FloatProperty: CurrCombatCamDistModifier
    /// </summary>
    public unsafe float CurrCombatCamDistModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6500); }
    }

    /// <summary>
    /// FloatProperty: CurrSuperComboPPAmount
    /// </summary>
    public unsafe float CurrSuperComboPPAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6504); }
    }

    /// <summary>
    /// FloatProperty: SuperComboModeVal1Multi
    /// </summary>
    public unsafe float SuperComboModeVal1Multi
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6508); }
    }

    /// <summary>
    /// FloatProperty: SuperComboModeVal2Multi
    /// </summary>
    public unsafe float SuperComboModeVal2Multi
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6512); }
    }

    /// <summary>
    /// ObjectProperty: SuperComboModePP
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess SuperComboModePP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 6516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6516); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastStrikeRequest
    /// </summary>
    public unsafe float TimeSinceLastStrikeRequest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6520); }
    }

    /// <summary>
    /// FloatProperty: fLastTimePressedRightTrigger
    /// </summary>
    public unsafe float fLastTimePressedRightTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6524); }
    }

    /// <summary>
    /// DelegateProperty: __TryCountering__Delegate
    /// </summary>
    public unsafe System.IntPtr __TryCountering__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 6528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6528); }
    }
}
