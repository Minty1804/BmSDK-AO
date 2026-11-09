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

    private static BmSDK.Function __fn_NotifyCombatFinished;
    /// <summary>
    /// Function: NotifyCombatFinished
    /// </summary>
    public unsafe override void NotifyCombatFinished(bool BatmanWasVictorious)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyCombatFinished, "BmGame.RPlayerControllerCombat.NotifyCombatFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanWasVictorious, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyCombatStarted;
    /// <summary>
    /// Function: NotifyCombatStarted
    /// </summary>
    public unsafe override void NotifyCombatStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyCombatStarted, "BmGame.RPlayerControllerCombat.NotifyCombatStarted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetProjectileHelpPrompt;
    /// <summary>
    /// Function: GetProjectileHelpPrompt
    /// </summary>
    public unsafe override void GetProjectileHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProjectileHelpPrompt, "BmGame.RPlayerControllerCombat.GetProjectileHelpPrompt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceDodgeProjectile;
    /// <summary>
    /// Function: ForceDodgeProjectile
    /// </summary>
    public unsafe virtual bool ForceDodgeProjectile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceDodgeProjectile, "BmGame.RPlayerControllerCombat.ForceDodgeProjectile");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoQuickFireSpecialMove;
    /// <summary>
    /// Function: DoQuickFireSpecialMove
    /// </summary>
    public unsafe override void DoQuickFireSpecialMove(int QuickSpecialMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoQuickFireSpecialMove, "BmGame.RPlayerControllerCombat.DoQuickFireSpecialMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QuickSpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickGadgetB;
    /// <summary>
    /// Function: QuickGadgetB
    /// </summary>
    public unsafe virtual void QuickGadgetB()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickGadgetB, "BmGame.RPlayerControllerCombat.QuickGadgetB");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickGadgetX;
    /// <summary>
    /// Function: QuickGadgetX
    /// </summary>
    public unsafe virtual void QuickGadgetX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickGadgetX, "BmGame.RPlayerControllerCombat.QuickGadgetX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickGadgetY;
    /// <summary>
    /// Function: QuickGadgetY
    /// </summary>
    public unsafe virtual void QuickGadgetY()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickGadgetY, "BmGame.RPlayerControllerCombat.QuickGadgetY");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickGadgetA;
    /// <summary>
    /// Function: QuickGadgetA
    /// </summary>
    public unsafe virtual void QuickGadgetA()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickGadgetA, "BmGame.RPlayerControllerCombat.QuickGadgetA");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetThumbLeft;
    /// <summary>
    /// Function: GadgetThumbLeft
    /// </summary>
    public unsafe virtual void GadgetThumbLeft()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetThumbLeft, "BmGame.RPlayerControllerCombat.GadgetThumbLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetThumbRight;
    /// <summary>
    /// Function: GadgetThumbRight
    /// </summary>
    public unsafe virtual void GadgetThumbRight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetThumbRight, "BmGame.RPlayerControllerCombat.GadgetThumbRight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickGadgetRTFire;
    /// <summary>
    /// Function: QuickGadgetRTFire
    /// </summary>
    public unsafe override void QuickGadgetRTFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickGadgetRTFire, "BmGame.RPlayerControllerCombat.QuickGadgetRTFire");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanQuickFireSpecialMove;
    /// <summary>
    /// Function: CanQuickFireSpecialMove
    /// </summary>
    public unsafe virtual bool CanQuickFireSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanQuickFireSpecialMove, "BmGame.RPlayerControllerCombat.CanQuickFireSpecialMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanQuickFireGadget;
    /// <summary>
    /// Function: CanQuickFireGadget
    /// </summary>
    public unsafe virtual bool CanQuickFireGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanQuickFireGadget, "BmGame.RPlayerControllerCombat.CanQuickFireGadget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerDamagePawn;
    /// <summary>
    /// Function: ServerDamagePawn
    /// </summary>
    public unsafe virtual void ServerDamagePawn(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerDamagePawn, "BmGame.RPlayerControllerCombat.ServerDamagePawn");
        byte* paramsPtr = stackalloc byte[276];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerDoHitPawn;
    /// <summary>
    /// Function: ServerDoHitPawn
    /// </summary>
    public unsafe virtual void ServerDoHitPawn(BmSDK.BmGame.RPawnCombat DamageReceiver, float DmgAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerDoHitPawn, "BmGame.RPlayerControllerCombat.ServerDoHitPawn");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnRegisterComboValueReachedAction;
    /// <summary>
    /// Function: UnRegisterComboValueReachedAction
    /// </summary>
    public unsafe virtual void UnRegisterComboValueReachedAction(BmSDK.BmGame.RSeqAct_ComboValueReached OldAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnRegisterComboValueReachedAction, "BmGame.RPlayerControllerCombat.UnRegisterComboValueReachedAction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterComboValueReachedAction;
    /// <summary>
    /// Function: RegisterComboValueReachedAction
    /// </summary>
    public unsafe virtual void RegisterComboValueReachedAction(BmSDK.BmGame.RSeqAct_ComboValueReached NewAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterComboValueReachedAction, "BmGame.RPlayerControllerCombat.RegisterComboValueReachedAction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LunaticBreakoutFinished;
    /// <summary>
    /// Function: LunaticBreakoutFinished
    /// </summary>
    public unsafe virtual void LunaticBreakoutFinished(System.Numerics.Vector3 NewThrowDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LunaticBreakoutFinished, "BmGame.RPlayerControllerCombat.LunaticBreakoutFinished");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewThrowDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableCapeStun;
    /// <summary>
    /// Function: EnableCapeStun
    /// </summary>
    public unsafe virtual void EnableCapeStun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableCapeStun, "BmGame.RPlayerControllerCombat.EnableCapeStun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableCapeStun;
    /// <summary>
    /// Function: DisableCapeStun
    /// </summary>
    public unsafe override void DisableCapeStun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableCapeStun, "BmGame.RPlayerControllerCombat.DisableCapeStun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanStagger;
    /// <summary>
    /// Function: CanStagger
    /// </summary>
    public unsafe override bool CanStagger()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanStagger, "BmGame.RPlayerControllerCombat.CanStagger");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MakeBatmanLookAtEnemy;
    /// <summary>
    /// Function: MakeBatmanLookAtEnemy
    /// </summary>
    public unsafe override bool MakeBatmanLookAtEnemy(bool bReset = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeBatmanLookAtEnemy, "BmGame.RPlayerControllerCombat.MakeBatmanLookAtEnemy");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReset, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ReadyGadgetOrCounterReleased;
    /// <summary>
    /// Function: ReadyGadgetOrCounterReleased
    /// </summary>
    public unsafe virtual void ReadyGadgetOrCounterReleased()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadyGadgetOrCounterReleased, "BmGame.RPlayerControllerCombat.ReadyGadgetOrCounterReleased");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MouseReadyGadget;
    /// <summary>
    /// Function: MouseReadyGadget
    /// </summary>
    public unsafe virtual void MouseReadyGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MouseReadyGadget, "BmGame.RPlayerControllerCombat.MouseReadyGadget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadyGadgetOrCounterPressed;
    /// <summary>
    /// Function: ReadyGadgetOrCounterPressed
    /// </summary>
    public unsafe override void ReadyGadgetOrCounterPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadyGadgetOrCounterPressed, "BmGame.RPlayerControllerCombat.ReadyGadgetOrCounterPressed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetOrQuickStrikePressed;
    /// <summary>
    /// Function: GadgetOrQuickStrikePressed
    /// </summary>
    public unsafe virtual void GadgetOrQuickStrikePressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetOrQuickStrikePressed, "BmGame.RPlayerControllerCombat.GadgetOrQuickStrikePressed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GrappleOrStrikeGadgetPressed;
    /// <summary>
    /// Function: GrappleOrStrikeGadgetPressed
    /// </summary>
    public unsafe virtual void GrappleOrStrikeGadgetPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrappleOrStrikeGadgetPressed, "BmGame.RPlayerControllerCombat.GrappleOrStrikeGadgetPressed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterGameAction;
    /// <summary>
    /// Function: RegisterGameAction
    /// </summary>
    public unsafe override void RegisterGameAction(BmSDK.BmGame.RGameInfo.EGameAction Action, BmSDK.Engine.Actor XPTarget = default, int XPAmount = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterGameAction, "BmGame.RPlayerControllerCombat.RegisterGameAction");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAmount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RPlayerControllerCombat.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayImpactRumble;
    /// <summary>
    /// Function: PlayImpactRumble
    /// </summary>
    public unsafe virtual void PlayImpactRumble(float LeftAmp = default, float RightAmp = default, float Duration = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayImpactRumble, "BmGame.RPlayerControllerCombat.PlayImpactRumble");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftAmp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightAmp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NavManWTF;
    /// <summary>
    /// Function: NavManWTF
    /// </summary>
    public unsafe virtual void NavManWTF()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavManWTF, "BmGame.RPlayerControllerCombat.NavManWTF");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AIWTF;
    /// <summary>
    /// Function: AIWTF
    /// </summary>
    public unsafe virtual void AIWTF()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AIWTF, "BmGame.RPlayerControllerCombat.AIWTF");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TutorialWTF;
    /// <summary>
    /// Function: TutorialWTF
    /// </summary>
    public unsafe virtual void TutorialWTF()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TutorialWTF, "BmGame.RPlayerControllerCombat.TutorialWTF");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PairedAnimWTF;
    /// <summary>
    /// Function: PairedAnimWTF
    /// </summary>
    public unsafe virtual void PairedAnimWTF()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PairedAnimWTF, "BmGame.RPlayerControllerCombat.PairedAnimWTF");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StrikeWTF;
    /// <summary>
    /// Function: StrikeWTF
    /// </summary>
    public unsafe virtual void StrikeWTF()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrikeWTF, "BmGame.RPlayerControllerCombat.StrikeWTF");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatWTF;
    /// <summary>
    /// Function: CombatWTF
    /// </summary>
    public unsafe virtual void CombatWTF()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatWTF, "BmGame.RPlayerControllerCombat.CombatWTF");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuppressVenomCamera;
    /// <summary>
    /// Function: SuppressVenomCamera
    /// </summary>
    public unsafe override bool SuppressVenomCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuppressVenomCamera, "BmGame.RPlayerControllerCombat.SuppressVenomCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SuppressCombatCamera;
    /// <summary>
    /// Function: SuppressCombatCamera
    /// </summary>
    public unsafe override bool SuppressCombatCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuppressCombatCamera, "BmGame.RPlayerControllerCombat.SuppressCombatCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldGoSlowMoOnNextHit;
    /// <summary>
    /// Function: ShouldGoSlowMoOnNextHit
    /// </summary>
    public unsafe virtual bool ShouldGoSlowMoOnNextHit(int ComboInc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldGoSlowMoOnNextHit, "BmGame.RPlayerControllerCombat.ShouldGoSlowMoOnNextHit");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboInc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateCombatCameraSuppression;
    /// <summary>
    /// Function: UpdateCombatCameraSuppression
    /// </summary>
    public unsafe virtual void UpdateCombatCameraSuppression()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCombatCameraSuppression, "BmGame.RPlayerControllerCombat.UpdateCombatCameraSuppression");
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

    private static BmSDK.Function __fn_CombatTick;
    /// <summary>
    /// Function: CombatTick
    /// </summary>
    public unsafe override void CombatTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatTick, "BmGame.RPlayerControllerCombat.CombatTick");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnFinishedCombatMove;
    /// <summary>
    /// Function: SpawnFinishedCombatMove
    /// </summary>
    public unsafe override void SpawnFinishedCombatMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFinishedCombatMove, "BmGame.RPlayerControllerCombat.SpawnFinishedCombatMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueFinishedCombatMove;
    /// <summary>
    /// Function: QueueFinishedCombatMove
    /// </summary>
    public unsafe virtual void QueueFinishedCombatMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueFinishedCombatMove, "BmGame.RPlayerControllerCombat.QueueFinishedCombatMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateComboTokenHUD;
    /// <summary>
    /// Function: UpdateComboTokenHUD
    /// </summary>
    public unsafe virtual void UpdateComboTokenHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateComboTokenHUD, "BmGame.RPlayerControllerCombat.UpdateComboTokenHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetComboOnHUD;
    /// <summary>
    /// Function: SetComboOnHUD
    /// </summary>
    public unsafe virtual void SetComboOnHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetComboOnHUD, "BmGame.RPlayerControllerCombat.SetComboOnHUD");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateComboOnHUD;
    /// <summary>
    /// Function: UpdateComboOnHUD
    /// </summary>
    public unsafe virtual void UpdateComboOnHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateComboOnHUD, "BmGame.RPlayerControllerCombat.UpdateComboOnHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActualClearLastStrikeDir;
    /// <summary>
    /// Function: ActualClearLastStrikeDir
    /// </summary>
    public unsafe virtual void ActualClearLastStrikeDir()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActualClearLastStrikeDir, "BmGame.RPlayerControllerCombat.ActualClearLastStrikeDir");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLastStrikeDir;
    /// <summary>
    /// Function: ClearLastStrikeDir
    /// </summary>
    public unsafe virtual void ClearLastStrikeDir()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLastStrikeDir, "BmGame.RPlayerControllerCombat.ClearLastStrikeDir");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLastStrikeDir;
    /// <summary>
    /// Function: SetLastStrikeDir
    /// </summary>
    public unsafe virtual void SetLastStrikeDir(System.Numerics.Vector3 StrikeDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastStrikeDir, "BmGame.RPlayerControllerCombat.SetLastStrikeDir");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Untargetted;
    /// <summary>
    /// Function: Untargetted
    /// </summary>
    public unsafe virtual void Untargetted(BmSDK.BmGame.RPawnCombat Targetter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Untargetted, "BmGame.RPlayerControllerCombat.Untargetted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Targetter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Targetted;
    /// <summary>
    /// Function: Targetted
    /// </summary>
    public unsafe virtual void Targetted(BmSDK.BmGame.RPawnCombat Targetter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Targetted, "BmGame.RPlayerControllerCombat.Targetted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Targetter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Zapped;
    /// <summary>
    /// Function: Zapped
    /// </summary>
    public unsafe virtual void Zapped()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Zapped, "BmGame.RPlayerControllerCombat.Zapped");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Stunned;
    /// <summary>
    /// Function: Stunned
    /// </summary>
    public unsafe virtual void Stunned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Stunned, "BmGame.RPlayerControllerCombat.Stunned");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckDodge;
    /// <summary>
    /// Function: CheckDodge
    /// </summary>
    public unsafe virtual void CheckDodge(BmSDK.BmGame.RPawnCombat Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDodge, "BmGame.RPlayerControllerCombat.CheckDodge");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnRunningStun;
    /// <summary>
    /// Function: SpawnRunningStun
    /// </summary>
    public unsafe virtual void SpawnRunningStun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnRunningStun, "BmGame.RPlayerControllerCombat.SpawnRunningStun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnRunningStrike;
    /// <summary>
    /// Function: SpawnRunningStrike
    /// </summary>
    public unsafe virtual void SpawnRunningStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnRunningStrike, "BmGame.RPlayerControllerCombat.SpawnRunningStrike");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldShowSpecialPrompt;
    /// <summary>
    /// Function: ShouldShowSpecialPrompt
    /// </summary>
    public unsafe virtual bool ShouldShowSpecialPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldShowSpecialPrompt, "BmGame.RPlayerControllerCombat.ShouldShowSpecialPrompt");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoSecondaryGroupCombatMove;
    /// <summary>
    /// Function: CanDoSecondaryGroupCombatMove
    /// </summary>
    public unsafe virtual bool CanDoSecondaryGroupCombatMove(bool bDoComboCountCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoSecondaryGroupCombatMove, "BmGame.RPlayerControllerCombat.CanDoSecondaryGroupCombatMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanDoPrimaryGroupCombatMove;
    /// <summary>
    /// Function: CanDoPrimaryGroupCombatMove
    /// </summary>
    public unsafe virtual bool CanDoPrimaryGroupCombatMove(bool bDoComboCountCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoPrimaryGroupCombatMove, "BmGame.RPlayerControllerCombat.CanDoPrimaryGroupCombatMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanDoWeaponDestroy;
    /// <summary>
    /// Function: CanDoWeaponDestroy
    /// </summary>
    public unsafe virtual bool CanDoWeaponDestroy(bool bDoComboCountCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoWeaponDestroy, "BmGame.RPlayerControllerCombat.CanDoWeaponDestroy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanDoCombatTakedown;
    /// <summary>
    /// Function: CanDoCombatTakedown
    /// </summary>
    public unsafe virtual bool CanDoCombatTakedown(bool bDoComboCountCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoCombatTakedown, "BmGame.RPlayerControllerCombat.CanDoCombatTakedown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanDoThrow;
    /// <summary>
    /// Function: CanDoThrow
    /// </summary>
    public unsafe virtual bool CanDoThrow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoThrow, "BmGame.RPlayerControllerCombat.CanDoThrow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerSpawnFailMove;
    /// <summary>
    /// Function: ServerSpawnFailMove
    /// </summary>
    public unsafe virtual void ServerSpawnFailMove(BmSDK.FName FailAnim, bool bCanBecomeThrow, bool bCanBecomeTakedown, bool bCanBecomeFloorTakedown, BmSDK.FName FailCapeState, System.Numerics.Vector3 MoveDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSpawnFailMove, "BmGame.RPlayerControllerCombat.ServerSpawnFailMove");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeThrow, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeTakedown, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeFloorTakedown, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailCapeState, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnInterrogation;
    /// <summary>
    /// Function: SpawnInterrogation
    /// </summary>
    public unsafe virtual bool SpawnInterrogation(BmSDK.BmGame.RPawnVillain NewTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnInterrogation, "BmGame.RPlayerControllerCombat.SpawnInterrogation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnTakedown;
    /// <summary>
    /// Function: SpawnTakedown
    /// </summary>
    public unsafe virtual bool SpawnTakedown(bool bOverrideCurrentMove = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnTakedown, "BmGame.RPlayerControllerCombat.SpawnTakedown");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsValidThrowTarget;
    /// <summary>
    /// Function: IsValidThrowTarget
    /// </summary>
    public unsafe virtual bool IsValidThrowTarget(BmSDK.BmGame.RPawnVillain Target, System.Numerics.Vector3 MoveDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidThrowTarget, "BmGame.RPlayerControllerCombat.IsValidThrowTarget");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SpawnWeaponDestroy;
    /// <summary>
    /// Function: SpawnWeaponDestroy
    /// </summary>
    public unsafe virtual bool SpawnWeaponDestroy(bool bOverrideCurrentMove = default, BmSDK.BmGame.RPawnVillain NewTarget = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnWeaponDestroy, "BmGame.RPlayerControllerCombat.SpawnWeaponDestroy");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ServerCounterPressedSimulated;
    /// <summary>
    /// Function: ServerCounterPressedSimulated
    /// </summary>
    public unsafe virtual void ServerCounterPressedSimulated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerCounterPressedSimulated, "BmGame.RPlayerControllerCombat.ServerCounterPressedSimulated");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerStartSimultaneousCounterSimulated;
    /// <summary>
    /// Function: ServerStartSimultaneousCounterSimulated
    /// </summary>
    public unsafe virtual void ServerStartSimultaneousCounterSimulated(BmSDK.BmGame.RPawnCombat.SimultaneousCounterFormation FormationType, int InfoIndex, System.Numerics.Vector3 AnimLocation, BmSDK.Rotator CounterRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerStartSimultaneousCounterSimulated, "BmGame.RPlayerControllerCombat.ServerStartSimultaneousCounterSimulated");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FormationType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InfoIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterRotation, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRequestFailedPairedAnimMove;
    /// <summary>
    /// Function: ServerRequestFailedPairedAnimMove
    /// </summary>
    public unsafe virtual void ServerRequestFailedPairedAnimMove(BmSDK.BmGame.RPawnVillain Target, BmSDK.FName AnimName, System.Numerics.Vector3 AnimPos, BmSDK.Rotator ThrowDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestFailedPairedAnimMove, "BmGame.RPlayerControllerCombat.ServerRequestFailedPairedAnimMove");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRequestThrow;
    /// <summary>
    /// Function: ServerRequestThrow
    /// </summary>
    public unsafe virtual void ServerRequestThrow(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnPlayerCombat.FThrowInfo ThrowInfo, System.Numerics.Vector3 AnimPos, BmSDK.Rotator ThrowDir, bool bSetCapeState, bool bDirectThrow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestThrow, "BmGame.RPlayerControllerCombat.ServerRequestThrow");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowInfo, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetCapeState, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDirectThrow, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRequestIntoThrow;
    /// <summary>
    /// Function: ServerRequestIntoThrow
    /// </summary>
    public unsafe virtual void ServerRequestIntoThrow(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargetResponse, BmSDK.Rotator MoveDir, float TargetDist, System.Numerics.Vector3 AnimPos, float AnimRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestIntoThrow, "BmGame.RPlayerControllerCombat.ServerRequestIntoThrow");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetResponse, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDist, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRot, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnThrow;
    /// <summary>
    /// Function: SpawnThrow
    /// </summary>
    public unsafe virtual bool SpawnThrow(bool bOverrideCurrentMove = default, BmSDK.BmGame.RPawnVillain NewTarget = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnThrow, "BmGame.RPlayerControllerCombat.SpawnThrow");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ServerRequestFloorTakedownSimulated;
    /// <summary>
    /// Function: ServerRequestFloorTakedownSimulated
    /// </summary>
    public unsafe virtual void ServerRequestFloorTakedownSimulated(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge ChallengeActionToTriggerIfSuccessful, float TargetDist, System.Numerics.Vector3 AnimPos, System.Numerics.Vector3 FacingDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestFloorTakedownSimulated, "BmGame.RPlayerControllerCombat.ServerRequestFloorTakedownSimulated");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeActionToTriggerIfSuccessful, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDist, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryFloorTakedown;
    /// <summary>
    /// Function: TryFloorTakedown
    /// </summary>
    public unsafe virtual bool TryFloorTakedown(bool bOverrideCurrentMove = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryFloorTakedown, "BmGame.RPlayerControllerCombat.TryFloorTakedown");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ServerRequestProjectileCounter;
    /// <summary>
    /// Function: ServerRequestProjectileCounter
    /// </summary>
    public unsafe virtual void ServerRequestProjectileCounter(BmSDK.BmGame.RBMCombatThrownObject ThrownObject)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestProjectileCounter, "BmGame.RPlayerControllerCombat.ServerRequestProjectileCounter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryBossCounter;
    /// <summary>
    /// Function: TryBossCounter
    /// </summary>
    public unsafe virtual bool TryBossCounter(BmSDK.BmGame.RPawnVillain targ)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryBossCounter, "BmGame.RPlayerControllerCombat.TryBossCounter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(targ, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TryProjectileCounter;
    /// <summary>
    /// Function: TryProjectileCounter
    /// </summary>
    public unsafe virtual bool TryProjectileCounter(bool bSpawnCounter = default, BmSDK.BmGame.RBMCombatThrownObject CombatObject = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryProjectileCounter, "BmGame.RPlayerControllerCombat.TryProjectileCounter");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpawnCounter, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatObject, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TryCounter;
    /// <summary>
    /// Function: TryCounter
    /// </summary>
    public unsafe virtual bool TryCounter(bool bCanFail, float TimeInitiatedByPlayer = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryCounter, "BmGame.RPlayerControllerCombat.TryCounter");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFail, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TryBeatdownCounter;
    /// <summary>
    /// Function: TryBeatdownCounter
    /// </summary>
    public unsafe virtual bool TryBeatdownCounter(bool bCanStartMove, float TimeInitiatedByPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryBeatdownCounter, "BmGame.RPlayerControllerCombat.TryBeatdownCounter");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanStartMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TryCounteringDeathstroke;
    /// <summary>
    /// Function: TryCounteringDeathstroke
    /// </summary>
    public unsafe virtual bool TryCounteringDeathstroke(bool bCanStartMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryCounteringDeathstroke, "BmGame.RPlayerControllerCombat.TryCounteringDeathstroke");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanStartMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TrySimultaneousCounter;
    /// <summary>
    /// Function: TrySimultaneousCounter
    /// </summary>
    public unsafe virtual bool TrySimultaneousCounter(bool bCanStartMove, float TimeInitiatedByPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrySimultaneousCounter, "BmGame.RPlayerControllerCombat.TrySimultaneousCounter");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanStartMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TryStun;
    /// <summary>
    /// Function: TryStun
    /// </summary>
    public unsafe virtual bool TryStun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryStun, "BmGame.RPlayerControllerCombat.TryStun");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStunMove;
    /// <summary>
    /// Function: GetStunMove
    /// </summary>
    public unsafe virtual BmSDK.Class GetStunMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStunMove, "BmGame.RPlayerControllerCombat.GetStunMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerSpawnSpecialMove;
    /// <summary>
    /// Function: ServerSpawnSpecialMove
    /// </summary>
    public unsafe virtual void ServerSpawnSpecialMove(BmSDK.Class MoveClass, System.Numerics.Vector3 AnimPos, BmSDK.Rotator AnimRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSpawnSpecialMove, "BmGame.RPlayerControllerCombat.ServerSpawnSpecialMove");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRot, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInBeatdown;
    /// <summary>
    /// Function: IsInBeatdown
    /// </summary>
    public unsafe virtual bool IsInBeatdown(BmSDK.BmGame.RPawnVillain testVillain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInBeatdown, "BmGame.RPlayerControllerCombat.IsInBeatdown");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(testVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TryStrike;
    /// <summary>
    /// Function: TryStrike
    /// </summary>
    public unsafe virtual bool TryStrike(float TimeInitiatedByPlayer = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryStrike, "BmGame.RPlayerControllerCombat.TryStrike");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBatclawSlamTarget;
    /// <summary>
    /// Function: GetBatclawSlamTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetBatclawSlamTarget(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatclawSlamTarget, "BmGame.RPlayerControllerCombat.GetBatclawSlamTarget");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetQuickStrikeDamageType;
    /// <summary>
    /// Function: GetQuickStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetQuickStrikeDamageType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetQuickStrikeDamageType, "BmGame.RPlayerControllerCombat.GetQuickStrikeDamageType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetQuickStrikeType;
    /// <summary>
    /// Function: GetQuickStrikeType
    /// </summary>
    public unsafe virtual BmSDK.Class GetQuickStrikeType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetQuickStrikeType, "BmGame.RPlayerControllerCombat.GetQuickStrikeType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHeavyStrikeType;
    /// <summary>
    /// Function: GetHeavyStrikeType
    /// </summary>
    public unsafe virtual BmSDK.Class GetHeavyStrikeType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeavyStrikeType, "BmGame.RPlayerControllerCombat.GetHeavyStrikeType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHeavyStrikeDamageType;
    /// <summary>
    /// Function: GetHeavyStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetHeavyStrikeDamageType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeavyStrikeDamageType, "BmGame.RPlayerControllerCombat.GetHeavyStrikeDamageType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCriticalStrikeDamageType;
    /// <summary>
    /// Function: GetCriticalStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetCriticalStrikeDamageType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCriticalStrikeDamageType, "BmGame.RPlayerControllerCombat.GetCriticalStrikeDamageType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCounterCriticalStrikeDamageType;
    /// <summary>
    /// Function: GetCounterCriticalStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetCounterCriticalStrikeDamageType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterCriticalStrikeDamageType, "BmGame.RPlayerControllerCombat.GetCounterCriticalStrikeDamageType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_VenomFailedCounter;
    /// <summary>
    /// Function: VenomFailedCounter
    /// </summary>
    public unsafe virtual void VenomFailedCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VenomFailedCounter, "BmGame.RPlayerControllerCombat.VenomFailedCounter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VenomDismountOrStunCounter;
    /// <summary>
    /// Function: VenomDismountOrStunCounter
    /// </summary>
    public unsafe virtual void VenomDismountOrStunCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VenomDismountOrStunCounter, "BmGame.RPlayerControllerCombat.VenomDismountOrStunCounter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VenomCounter;
    /// <summary>
    /// Function: VenomCounter
    /// </summary>
    public unsafe virtual void VenomCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VenomCounter, "BmGame.RPlayerControllerCombat.VenomCounter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VenomAttack;
    /// <summary>
    /// Function: VenomAttack
    /// </summary>
    public unsafe virtual void VenomAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VenomAttack, "BmGame.RPlayerControllerCombat.VenomAttack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChargeVenomReleased;
    /// <summary>
    /// Function: ChargeVenomReleased
    /// </summary>
    public unsafe virtual void ChargeVenomReleased()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChargeVenomReleased, "BmGame.RPlayerControllerCombat.ChargeVenomReleased");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChargeVenomPressed;
    /// <summary>
    /// Function: ChargeVenomPressed
    /// </summary>
    public unsafe virtual void ChargeVenomPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChargeVenomPressed, "BmGame.RPlayerControllerCombat.ChargeVenomPressed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VenomShockwave;
    /// <summary>
    /// Function: VenomShockwave
    /// </summary>
    public unsafe virtual void VenomShockwave()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VenomShockwave, "BmGame.RPlayerControllerCombat.VenomShockwave");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartRun;
    /// <summary>
    /// Function: StartRun
    /// </summary>
    public unsafe override void StartRun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRun, "BmGame.RPlayerControllerCombat.StartRun");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerRideVenom;
    /// <summary>
    /// Function: TriggerRideVenom
    /// </summary>
    public unsafe virtual bool TriggerRideVenom()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerRideVenom, "BmGame.RPlayerControllerCombat.TriggerRideVenom");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerGroundTakedown;
    /// <summary>
    /// Function: TriggerGroundTakedown
    /// </summary>
    public unsafe override bool TriggerGroundTakedown(bool bOverrideCurrentMove = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGroundTakedown, "BmGame.RPlayerControllerCombat.TriggerGroundTakedown");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TriggerCounter;
    /// <summary>
    /// Function: TriggerCounter
    /// </summary>
    public unsafe virtual bool TriggerCounter(bool bCanFail)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCounter, "BmGame.RPlayerControllerCombat.TriggerCounter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFail, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RejectStealthTakeDown;
    /// <summary>
    /// Function: RejectStealthTakeDown
    /// </summary>
    public unsafe override void RejectStealthTakeDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RejectStealthTakeDown, "BmGame.RPlayerControllerCombat.RejectStealthTakeDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToStartCombatInterrogation;
    /// <summary>
    /// Function: TryToStartCombatInterrogation
    /// </summary>
    public unsafe virtual bool TryToStartCombatInterrogation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToStartCombatInterrogation, "BmGame.RPlayerControllerCombat.TryToStartCombatInterrogation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryToStartCombatTakeDown;
    /// <summary>
    /// Function: TryToStartCombatTakeDown
    /// </summary>
    public unsafe override bool TryToStartCombatTakeDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToStartCombatTakeDown, "BmGame.RPlayerControllerCombat.TryToStartCombatTakeDown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BankPoints;
    /// <summary>
    /// Function: BankPoints
    /// </summary>
    public unsafe virtual void BankPoints()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BankPoints, "BmGame.RPlayerControllerCombat.BankPoints");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BankPointsInternal;
    /// <summary>
    /// Function: BankPointsInternal
    /// </summary>
    public unsafe virtual void BankPointsInternal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BankPointsInternal, "BmGame.RPlayerControllerCombat.BankPointsInternal");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GrabReleased;
    /// <summary>
    /// Function: GrabReleased
    /// </summary>
    public unsafe override void GrabReleased()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrabReleased, "BmGame.RPlayerControllerCombat.GrabReleased");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GrabHeld;
    /// <summary>
    /// Function: GrabHeld
    /// </summary>
    public unsafe virtual void GrabHeld()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrabHeld, "BmGame.RPlayerControllerCombat.GrabHeld");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TrySecondaryGroupCombatMove;
    /// <summary>
    /// Function: TrySecondaryGroupCombatMove
    /// </summary>
    public unsafe virtual bool TrySecondaryGroupCombatMove(bool bOverrideCurrentMove = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrySecondaryGroupCombatMove, "BmGame.RPlayerControllerCombat.TrySecondaryGroupCombatMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TryPrimaryGroupCombatMove;
    /// <summary>
    /// Function: TryPrimaryGroupCombatMove
    /// </summary>
    public unsafe virtual bool TryPrimaryGroupCombatMove(bool bOverrideCurrentMove = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryPrimaryGroupCombatMove, "BmGame.RPlayerControllerCombat.TryPrimaryGroupCombatMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GrabPressed;
    /// <summary>
    /// Function: GrabPressed
    /// </summary>
    public unsafe override void GrabPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrabPressed, "BmGame.RPlayerControllerCombat.GrabPressed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FloorTakedownModifierPressed;
    /// <summary>
    /// Function: FloorTakedownModifierPressed
    /// </summary>
    public unsafe virtual void FloorTakedownModifierPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FloorTakedownModifierPressed, "BmGame.RPlayerControllerCombat.FloorTakedownModifierPressed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlockBreakerReleased;
    /// <summary>
    /// Function: BlockBreakerReleased
    /// </summary>
    public unsafe virtual void BlockBreakerReleased()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlockBreakerReleased, "BmGame.RPlayerControllerCombat.BlockBreakerReleased");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerBlockBreaker;
    /// <summary>
    /// Function: TriggerBlockBreaker
    /// </summary>
    public unsafe virtual void TriggerBlockBreaker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerBlockBreaker, "BmGame.RPlayerControllerCombat.TriggerBlockBreaker");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSecondaryGroupCombatMove;
    /// <summary>
    /// Function: TriggerSecondaryGroupCombatMove
    /// </summary>
    public unsafe virtual void TriggerSecondaryGroupCombatMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSecondaryGroupCombatMove, "BmGame.RPlayerControllerCombat.TriggerSecondaryGroupCombatMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerPrimaryGroupCombatMove;
    /// <summary>
    /// Function: TriggerPrimaryGroupCombatMove
    /// </summary>
    public unsafe virtual void TriggerPrimaryGroupCombatMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPrimaryGroupCombatMove, "BmGame.RPlayerControllerCombat.TriggerPrimaryGroupCombatMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCombatTakedown;
    /// <summary>
    /// Function: TriggerCombatTakedown
    /// </summary>
    public unsafe virtual void TriggerCombatTakedown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCombatTakedown, "BmGame.RPlayerControllerCombat.TriggerCombatTakedown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerWeaponDestroy;
    /// <summary>
    /// Function: TriggerWeaponDestroy
    /// </summary>
    public unsafe virtual void TriggerWeaponDestroy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWeaponDestroy, "BmGame.RPlayerControllerCombat.TriggerWeaponDestroy");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerThrow;
    /// <summary>
    /// Function: TriggerThrow
    /// </summary>
    public unsafe virtual void TriggerThrow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerThrow, "BmGame.RPlayerControllerCombat.TriggerThrow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerQuickStrike;
    /// <summary>
    /// Function: TriggerQuickStrike
    /// </summary>
    public unsafe override void TriggerQuickStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerQuickStrike, "BmGame.RPlayerControllerCombat.TriggerQuickStrike");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NewComboMoveStarted;
    /// <summary>
    /// Function: NewComboMoveStarted
    /// </summary>
    public unsafe virtual void NewComboMoveStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NewComboMoveStarted, "BmGame.RPlayerControllerCombat.NewComboMoveStarted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateRunningTimers;
    /// <summary>
    /// Function: UpdateRunningTimers
    /// </summary>
    public unsafe virtual void UpdateRunningTimers(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRunningTimers, "BmGame.RPlayerControllerCombat.UpdateRunningTimers");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRoomChange;
    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe override void OnRoomChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRoomChange, "BmGame.RPlayerControllerCombat.OnRoomChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyTakeDamage;
    /// <summary>
    /// Function: NotifyTakeDamage
    /// </summary>
    public unsafe override void NotifyTakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyTakeDamage, "BmGame.RPlayerControllerCombat.NotifyTakeDamage");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_UpdateCombatHitVars;
    /// <summary>
    /// Function: UpdateCombatHitVars
    /// </summary>
    public unsafe virtual void UpdateCombatHitVars(BmSDK.Engine.Controller InstigatedBy, int Damage, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCombatHitVars, "BmGame.RPlayerControllerCombat.UpdateCombatHitVars");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScoreOnHud;
    /// <summary>
    /// Function: SetScoreOnHud
    /// </summary>
    public unsafe virtual void SetScoreOnHud()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScoreOnHud, "BmGame.RPlayerControllerCombat.SetScoreOnHud");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddScore;
    /// <summary>
    /// Function: AddScore
    /// </summary>
    public unsafe virtual void AddScore(int Amount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddScore, "BmGame.RPlayerControllerCombat.AddScore");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddScoreForMove;
    /// <summary>
    /// Function: AddScoreForMove
    /// </summary>
    public unsafe virtual void AddScoreForMove(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType, int ComboMultiplier, BmSDK.BmGame.RPawnCombat Target, int numTargets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddScoreForMove, "BmGame.RPlayerControllerCombat.AddScoreForMove");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboMultiplier, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(numTargets, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffKnifeComboAttackPrompt;
    /// <summary>
    /// Function: TurnOffKnifeComboAttackPrompt
    /// </summary>
    public unsafe virtual void TurnOffKnifeComboAttackPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffKnifeComboAttackPrompt, "BmGame.RPlayerControllerCombat.TurnOffKnifeComboAttackPrompt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnKnifeComboAttackPrompt;
    /// <summary>
    /// Function: TurnOnKnifeComboAttackPrompt
    /// </summary>
    public unsafe virtual void TurnOnKnifeComboAttackPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnKnifeComboAttackPrompt, "BmGame.RPlayerControllerCombat.TurnOnKnifeComboAttackPrompt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffMAComboChainPrompt;
    /// <summary>
    /// Function: TurnOffMAComboChainPrompt
    /// </summary>
    public unsafe virtual void TurnOffMAComboChainPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffMAComboChainPrompt, "BmGame.RPlayerControllerCombat.TurnOffMAComboChainPrompt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnMAComboChainPrompt;
    /// <summary>
    /// Function: TurnOnMAComboChainPrompt
    /// </summary>
    public unsafe virtual void TurnOnMAComboChainPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnMAComboChainPrompt, "BmGame.RPlayerControllerCombat.TurnOnMAComboChainPrompt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffMADoubleCounterPrompt;
    /// <summary>
    /// Function: TurnOffMADoubleCounterPrompt
    /// </summary>
    public unsafe virtual void TurnOffMADoubleCounterPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffMADoubleCounterPrompt, "BmGame.RPlayerControllerCombat.TurnOffMADoubleCounterPrompt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnMADoubleCounterPrompt;
    /// <summary>
    /// Function: TurnOnMADoubleCounterPrompt
    /// </summary>
    public unsafe virtual void TurnOnMADoubleCounterPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnMADoubleCounterPrompt, "BmGame.RPlayerControllerCombat.TurnOnMADoubleCounterPrompt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffCounterPrompt;
    /// <summary>
    /// Function: TurnOffCounterPrompt
    /// </summary>
    public unsafe virtual void TurnOffCounterPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffCounterPrompt, "BmGame.RPlayerControllerCombat.TurnOffCounterPrompt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnCounterPrompt;
    /// <summary>
    /// Function: TurnOnCounterPrompt
    /// </summary>
    public unsafe virtual void TurnOnCounterPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnCounterPrompt, "BmGame.RPlayerControllerCombat.TurnOnCounterPrompt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetComboLevel;
    /// <summary>
    /// Function: GetComboLevel
    /// </summary>
    public unsafe virtual int GetComboLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboLevel, "BmGame.RPlayerControllerCombat.GetComboLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoSpecialMove;
    /// <summary>
    /// Function: CanDoSpecialMove
    /// </summary>
    public unsafe virtual bool CanDoSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoSpecialMove, "BmGame.RPlayerControllerCombat.CanDoSpecialMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearSpecialMove;
    /// <summary>
    /// Function: ClearSpecialMove
    /// </summary>
    public unsafe virtual void ClearSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearSpecialMove, "BmGame.RPlayerControllerCombat.ClearSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DecrementSpecialMove;
    /// <summary>
    /// Function: DecrementSpecialMove
    /// </summary>
    public unsafe virtual void DecrementSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DecrementSpecialMove, "BmGame.RPlayerControllerCombat.DecrementSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasSpecialMoveToken;
    /// <summary>
    /// Function: HasSpecialMoveToken
    /// </summary>
    public unsafe virtual bool HasSpecialMoveToken()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasSpecialMoveToken, "BmGame.RPlayerControllerCombat.HasSpecialMoveToken");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpecialMoveTargetInRange;
    /// <summary>
    /// Function: SpecialMoveTargetInRange
    /// </summary>
    public unsafe virtual bool SpecialMoveTargetInRange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialMoveTargetInRange, "BmGame.RPlayerControllerCombat.SpecialMoveTargetInRange");
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

    private static BmSDK.Function __fn_GetComboLength;
    /// <summary>
    /// Function: GetComboLength
    /// </summary>
    public unsafe virtual int GetComboLength()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboLength, "BmGame.RPlayerControllerCombat.GetComboLength");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumAwayFromCombo;
    /// <summary>
    /// Function: GetNumAwayFromCombo
    /// </summary>
    public unsafe virtual int GetNumAwayFromCombo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumAwayFromCombo, "BmGame.RPlayerControllerCombat.GetNumAwayFromCombo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInComboForSuper;
    /// <summary>
    /// Function: IsInComboForSuper
    /// </summary>
    public unsafe virtual bool IsInComboForSuper()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInComboForSuper, "BmGame.RPlayerControllerCombat.IsInComboForSuper");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInCombo;
    /// <summary>
    /// Function: IsInCombo
    /// </summary>
    public unsafe virtual bool IsInCombo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInCombo, "BmGame.RPlayerControllerCombat.IsInCombo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetComboMinLength;
    /// <summary>
    /// Function: GetComboMinLength
    /// </summary>
    public unsafe virtual int GetComboMinLength()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboMinLength, "BmGame.RPlayerControllerCombat.GetComboMinLength");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanContinueCombo;
    /// <summary>
    /// Function: CanContinueCombo
    /// </summary>
    public unsafe virtual bool CanContinueCombo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanContinueCombo, "BmGame.RPlayerControllerCombat.CanContinueCombo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DisableCombo;
    /// <summary>
    /// Function: DisableCombo
    /// </summary>
    public unsafe virtual void DisableCombo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableCombo, "BmGame.RPlayerControllerCombat.DisableCombo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ContinueComboTimerComplete;
    /// <summary>
    /// Function: ContinueComboTimerComplete
    /// </summary>
    public unsafe virtual void ContinueComboTimerComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ContinueComboTimerComplete, "BmGame.RPlayerControllerCombat.ContinueComboTimerComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetContinueComboTimer;
    /// <summary>
    /// Function: SetContinueComboTimer
    /// </summary>
    public unsafe virtual void SetContinueComboTimer(float ComboWindow = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetContinueComboTimer, "BmGame.RPlayerControllerCombat.SetContinueComboTimer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboWindow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearCombo;
    /// <summary>
    /// Function: ClearCombo
    /// </summary>
    public unsafe virtual void ClearCombo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCombo, "BmGame.RPlayerControllerCombat.ClearCombo");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetServerCombo;
    /// <summary>
    /// Function: SetServerCombo
    /// </summary>
    public unsafe virtual void SetServerCombo(int NewAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetServerCombo, "BmGame.RPlayerControllerCombat.SetServerCombo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatMoveDurationMulti;
    /// <summary>
    /// Function: GetCombatMoveDurationMulti
    /// </summary>
    public unsafe virtual float GetCombatMoveDurationMulti()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatMoveDurationMulti, "BmGame.RPlayerControllerCombat.GetCombatMoveDurationMulti");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetSuperComboMode;
    /// <summary>
    /// Function: ResetSuperComboMode
    /// </summary>
    public unsafe virtual void ResetSuperComboMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetSuperComboMode, "BmGame.RPlayerControllerCombat.ResetSuperComboMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSuperComboMode;
    /// <summary>
    /// Function: SetSuperComboMode
    /// </summary>
    public unsafe virtual void SetSuperComboMode(int NewComboAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSuperComboMode, "BmGame.RPlayerControllerCombat.SetSuperComboMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewComboAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitSuperCombo;
    /// <summary>
    /// Function: ExitSuperCombo
    /// </summary>
    public unsafe virtual void ExitSuperCombo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitSuperCombo, "BmGame.RPlayerControllerCombat.ExitSuperCombo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterSuperCombo;
    /// <summary>
    /// Function: EnterSuperCombo
    /// </summary>
    public unsafe virtual void EnterSuperCombo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterSuperCombo, "BmGame.RPlayerControllerCombat.EnterSuperCombo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSuperComboModeProportion;
    /// <summary>
    /// Function: GetSuperComboModeProportion
    /// </summary>
    public unsafe virtual float GetSuperComboModeProportion(int TestComboSize)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSuperComboModeProportion, "BmGame.RPlayerControllerCombat.GetSuperComboModeProportion");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestComboSize, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetSuperComboModePostProcess;
    /// <summary>
    /// Function: SetSuperComboModePostProcess
    /// </summary>
    public unsafe virtual void SetSuperComboModePostProcess(float ComboProportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSuperComboModePostProcess, "BmGame.RPlayerControllerCombat.SetSuperComboModePostProcess");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboProportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatFOVModifier;
    /// <summary>
    /// Function: GetCombatFOVModifier
    /// </summary>
    public unsafe virtual int GetCombatFOVModifier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatFOVModifier, "BmGame.RPlayerControllerCombat.GetCombatFOVModifier");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateSuperComboModeFX;
    /// <summary>
    /// Function: UpdateSuperComboModeFX
    /// </summary>
    public unsafe virtual void UpdateSuperComboModeFX(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSuperComboModeFX, "BmGame.RPlayerControllerCombat.UpdateSuperComboModeFX");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncCombo;
    /// <summary>
    /// Function: IncCombo
    /// </summary>
    public unsafe virtual void IncCombo(BmSDK.BmGame.RPawnCombat PawnAttacked = default, int IncAmount = default, int IncSpecialMoveCount = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncCombo, "BmGame.RPlayerControllerCombat.IncCombo");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnAttacked, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncAmount, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncSpecialMoveCount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetComboIncCue;
    /// <summary>
    /// Function: SetComboIncCue
    /// </summary>
    public unsafe virtual void SetComboIncCue(BmSDK.Engine.SoundCue NewCue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetComboIncCue, "BmGame.RPlayerControllerCombat.SetComboIncCue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetPerFightStats;
    /// <summary>
    /// Function: ResetPerFightStats
    /// </summary>
    public unsafe virtual void ResetPerFightStats()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPerFightStats, "BmGame.RPlayerControllerCombat.ResetPerFightStats");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetMaxComboSize;
    /// <summary>
    /// Function: ResetMaxComboSize
    /// </summary>
    public unsafe virtual void ResetMaxComboSize()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetMaxComboSize, "BmGame.RPlayerControllerCombat.ResetMaxComboSize");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMaxComboSize;
    /// <summary>
    /// Function: GetMaxComboSize
    /// </summary>
    public unsafe virtual int GetMaxComboSize()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxComboSize, "BmGame.RPlayerControllerCombat.GetMaxComboSize");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncCombosStarted;
    /// <summary>
    /// Function: IncCombosStarted
    /// </summary>
    public unsafe virtual void IncCombosStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncCombosStarted, "BmGame.RPlayerControllerCombat.IncCombosStarted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAverageCombo;
    /// <summary>
    /// Function: GetAverageCombo
    /// </summary>
    public unsafe virtual int GetAverageCombo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAverageCombo, "BmGame.RPlayerControllerCombat.GetAverageCombo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumCombosStarted;
    /// <summary>
    /// Function: GetNumCombosStarted
    /// </summary>
    public unsafe virtual int GetNumCombosStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumCombosStarted, "BmGame.RPlayerControllerCombat.GetNumCombosStarted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetCombosStarted;
    /// <summary>
    /// Function: ResetCombosStarted
    /// </summary>
    public unsafe virtual void ResetCombosStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetCombosStarted, "BmGame.RPlayerControllerCombat.ResetCombosStarted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitComboFlow;
    /// <summary>
    /// Function: ExitComboFlow
    /// </summary>
    public unsafe virtual void ExitComboFlow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitComboFlow, "BmGame.RPlayerControllerCombat.ExitComboFlow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterComboFlow;
    /// <summary>
    /// Function: EnterComboFlow
    /// </summary>
    public unsafe virtual void EnterComboFlow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterComboFlow, "BmGame.RPlayerControllerCombat.EnterComboFlow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OutputComboMoves;
    /// <summary>
    /// Function: OutputComboMoves
    /// </summary>
    public unsafe virtual void OutputComboMoves()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OutputComboMoves, "BmGame.RPlayerControllerCombat.OutputComboMoves");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearComboMoves;
    /// <summary>
    /// Function: ClearComboMoves
    /// </summary>
    public unsafe virtual void ClearComboMoves()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearComboMoves, "BmGame.RPlayerControllerCombat.ClearComboMoves");
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

    private static BmSDK.Function __fn_SetMaxVariation;
    /// <summary>
    /// Function: SetMaxVariation
    /// </summary>
    public unsafe virtual void SetMaxVariation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMaxVariation, "BmGame.RPlayerControllerCombat.SetMaxVariation");
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

    private static BmSDK.Function __fn_ComputeComboVariation;
    /// <summary>
    /// Function: ComputeComboVariation
    /// </summary>
    public unsafe virtual int ComputeComboVariation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ComputeComboVariation, "BmGame.RPlayerControllerCombat.ComputeComboVariation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMaxComboVariationInChallenge;
    /// <summary>
    /// Function: GetMaxComboVariationInChallenge
    /// </summary>
    public unsafe virtual int GetMaxComboVariationInChallenge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxComboVariationInChallenge, "BmGame.RPlayerControllerCombat.GetMaxComboVariationInChallenge");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetComboMoveTypes;
    /// <summary>
    /// Function: ResetComboMoveTypes
    /// </summary>
    public unsafe virtual void ResetComboMoveTypes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetComboMoveTypes, "BmGame.RPlayerControllerCombat.ResetComboMoveTypes");
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

    private static BmSDK.Function __fn_ResetMaxComboVariation;
    /// <summary>
    /// Function: ResetMaxComboVariation
    /// </summary>
    public unsafe virtual void ResetMaxComboVariation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetMaxComboVariation, "BmGame.RPlayerControllerCombat.ResetMaxComboVariation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SaveComboScore;
    /// <summary>
    /// Function: SaveComboScore
    /// </summary>
    public unsafe virtual void SaveComboScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveComboScore, "BmGame.RPlayerControllerCombat.SaveComboScore");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetGadgetVariation;
    /// <summary>
    /// Function: ResetGadgetVariation
    /// </summary>
    public unsafe virtual void ResetGadgetVariation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetGadgetVariation, "BmGame.RPlayerControllerCombat.ResetGadgetVariation");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetComboGadgetVariationScore;
    /// <summary>
    /// Function: GetComboGadgetVariationScore
    /// </summary>
    public unsafe virtual int GetComboGadgetVariationScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboGadgetVariationScore, "BmGame.RPlayerControllerCombat.GetComboGadgetVariationScore");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetComboVariationScore;
    /// <summary>
    /// Function: GetComboVariationScore
    /// </summary>
    public unsafe virtual int GetComboVariationScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboVariationScore, "BmGame.RPlayerControllerCombat.GetComboVariationScore");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MovePerformed;
    /// <summary>
    /// Function: MovePerformed
    /// </summary>
    public unsafe virtual void MovePerformed(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType, BmSDK.BmGame.RPawnCombat Target, bool bAddScore = default, int ComboForScore = default, int NumOfTargets = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MovePerformed, "BmGame.RPlayerControllerCombat.MovePerformed");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddScore, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboForScore, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumOfTargets, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncTutorialProgressForMove;
    /// <summary>
    /// Function: IncTutorialProgressForMove
    /// </summary>
    public unsafe virtual void IncTutorialProgressForMove(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType, BmSDK.BmGame.RPawnCombat Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncTutorialProgressForMove, "BmGame.RPlayerControllerCombat.IncTutorialProgressForMove");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlockedBy;
    /// <summary>
    /// Function: BlockedBy
    /// </summary>
    public unsafe virtual void BlockedBy(BmSDK.BmGame.RPawnVillain Villain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlockedBy, "BmGame.RPlayerControllerCombat.BlockedBy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldShowAutoCombatHints;
    /// <summary>
    /// Function: ShouldShowAutoCombatHints
    /// </summary>
    public unsafe virtual bool ShouldShowAutoCombatHints()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldShowAutoCombatHints, "BmGame.RPlayerControllerCombat.ShouldShowAutoCombatHints");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearHitsSinceCounter;
    /// <summary>
    /// Function: ClearHitsSinceCounter
    /// </summary>
    public unsafe virtual void ClearHitsSinceCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearHitsSinceCounter, "BmGame.RPlayerControllerCombat.ClearHitsSinceCounter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncHitsSinceCounter;
    /// <summary>
    /// Function: IncHitsSinceCounter
    /// </summary>
    public unsafe virtual void IncHitsSinceCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncHitsSinceCounter, "BmGame.RPlayerControllerCombat.IncHitsSinceCounter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanDoComboProjectileGadget;
    /// <summary>
    /// Function: CanDoComboProjectileGadget
    /// </summary>
    public unsafe virtual bool CanDoComboProjectileGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoComboProjectileGadget, "BmGame.RPlayerControllerCombat.CanDoComboProjectileGadget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoComboWhip;
    /// <summary>
    /// Function: CanDoComboWhip
    /// </summary>
    public unsafe virtual bool CanDoComboWhip()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoComboWhip, "BmGame.RPlayerControllerCombat.CanDoComboWhip");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoComboBatarang;
    /// <summary>
    /// Function: CanDoComboBatarang
    /// </summary>
    public unsafe virtual bool CanDoComboBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoComboBatarang, "BmGame.RPlayerControllerCombat.CanDoComboBatarang");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryRedirect;
    /// <summary>
    /// Function: TryRedirect
    /// </summary>
    public unsafe virtual bool TryRedirect(BmSDK.BmGame.RPawnVillain TargetPawn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryRedirect, "BmGame.RPlayerControllerCombat.TryRedirect");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ServerLockProjectileThrowTarget;
    /// <summary>
    /// Function: ServerLockProjectileThrowTarget
    /// </summary>
    public unsafe virtual void ServerLockProjectileThrowTarget(BmSDK.BmGame.RPawnVillain ThrowTarget, BmSDK.Rotator ThrowDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerLockProjectileThrowTarget, "BmGame.RPlayerControllerCombat.ServerLockProjectileThrowTarget");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRequestEvade;
    /// <summary>
    /// Function: ServerRequestEvade
    /// </summary>
    public unsafe virtual void ServerRequestEvade(System.Numerics.Vector3 EvadeDir, BmSDK.FName EvadeName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRequestEvade, "BmGame.RPlayerControllerCombat.ServerRequestEvade");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnEvade;
    /// <summary>
    /// Function: SpawnEvade
    /// </summary>
    public unsafe override void SpawnEvade(bool bCanQueue = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnEvade, "BmGame.RPlayerControllerCombat.SpawnEvade");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanQueue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToQueueEvade;
    /// <summary>
    /// Function: TryToQueueEvade
    /// </summary>
    public unsafe virtual void TryToQueueEvade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToQueueEvade, "BmGame.RPlayerControllerCombat.TryToQueueEvade");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWallEvadeInfo;
    /// <summary>
    /// Function: GetWallEvadeInfo
    /// </summary>
    public unsafe virtual bool GetWallEvadeInfo(System.Numerics.Vector3 Dir, out System.Numerics.Vector3 WallLocation, out System.Numerics.Vector3 WallNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWallEvadeInfo, "BmGame.RPlayerControllerCombat.GetWallEvadeInfo");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WallLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WallNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        WallLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        WallNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_DialogueModeTimeout;
    /// <summary>
    /// Function: DialogueModeTimeout
    /// </summary>
    public unsafe virtual void DialogueModeTimeout()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DialogueModeTimeout, "BmGame.RPlayerControllerCombat.DialogueModeTimeout");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryingToSetDialogueMode;
    /// <summary>
    /// Function: TryingToSetDialogueMode
    /// </summary>
    public unsafe virtual void TryingToSetDialogueMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryingToSetDialogueMode, "BmGame.RPlayerControllerCombat.TryingToSetDialogueMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoubleTapRun;
    /// <summary>
    /// Function: DoubleTapRun
    /// </summary>
    public unsafe override void DoubleTapRun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoubleTapRun, "BmGame.RPlayerControllerCombat.DoubleTapRun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLastTarget;
    /// <summary>
    /// Function: ClearLastTarget
    /// </summary>
    public unsafe virtual void ClearLastTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLastTarget, "BmGame.RPlayerControllerCombat.ClearLastTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatMoveFinished;
    /// <summary>
    /// Function: CombatMoveFinished
    /// </summary>
    public unsafe virtual void CombatMoveFinished(BmSDK.BmGame.RCombatMove FinishedMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatMoveFinished, "BmGame.RPlayerControllerCombat.CombatMoveFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatMoveInitialised;
    /// <summary>
    /// Function: CombatMoveInitialised
    /// </summary>
    public unsafe virtual void CombatMoveInitialised()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatMoveInitialised, "BmGame.RPlayerControllerCombat.CombatMoveInitialised");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RPlayerControllerCombat.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowTutorial;
    /// <summary>
    /// Function: ShowTutorial
    /// </summary>
    public unsafe virtual void ShowTutorial(BmSDK.BmGame.RHUDPrompt HelpPrompt, BmSDK.BmGame.RPersistentData.ETutorialType TutorialToShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowTutorial, "BmGame.RPlayerControllerCombat.ShowTutorial");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TutorialToShow, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHighestPriorityTutorial;
    /// <summary>
    /// Function: GetHighestPriorityTutorial
    /// </summary>
    public unsafe virtual void GetHighestPriorityTutorial(out BmSDK.BmGame.RPersistentData.ETutorialType BestTutorial, out BmSDK.FString BestTutorialPrompt, out BmSDK.BmGame.RHUDPrompt.EControlIcon BestControlIcon, out int bShowTutorial)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHighestPriorityTutorial, "BmGame.RPlayerControllerCombat.GetHighestPriorityTutorial");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestTutorial);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestTutorial, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestControlIcon);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestControlIcon, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bShowTutorial);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowTutorial, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BestTutorial = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPersistentData.ETutorialType>(paramsPtr + 0);
        BestTutorialPrompt = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
        BestControlIcon = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 16);
        bShowTutorial = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_CheckTutorial;
    /// <summary>
    /// Function: CheckTutorial
    /// </summary>
    public unsafe virtual bool CheckTutorial(BmSDK.BmGame.RPersistentData.ETutorialType CheckTutorialType, out int BestPriority, out BmSDK.BmGame.RPersistentData.ETutorialType BestTutorial, out BmSDK.FString BestPrompt, out int bShowTutorial)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckTutorial, "BmGame.RPlayerControllerCombat.CheckTutorial");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckTutorialType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestPriority);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestPriority, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestTutorial);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestTutorial, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bShowTutorial);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowTutorial, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BestPriority = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        BestTutorial = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPersistentData.ETutorialType>(paramsPtr + 8);
        BestPrompt = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
        bShowTutorial = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_IsInCombat;
    /// <summary>
    /// Function: IsInCombat
    /// </summary>
    public unsafe override bool IsInCombat(bool bForceCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInCombat, "BmGame.RPlayerControllerCombat.IsInCombat");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCM;
    /// <summary>
    /// Function: GetCM
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMCombatManager GetCM()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCM, "BmGame.RPlayerControllerCombat.GetCM");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatManager>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindFloorTakedownTarget;
    /// <summary>
    /// Function: FindFloorTakedownTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain FindFloorTakedownTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindFloorTakedownTarget, "BmGame.RPlayerControllerCombat.FindFloorTakedownTarget");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InputHeading;
    /// <summary>
    /// Function: InputHeading
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 InputHeading(bool bCanBeZero = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InputHeading, "BmGame.RPlayerControllerCombat.InputHeading");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBeZero, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasMovementInput;
    /// <summary>
    /// Function: HasMovementInput
    /// </summary>
    public unsafe virtual bool HasMovementInput()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasMovementInput, "BmGame.RPlayerControllerCombat.HasMovementInput");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBatarangPrimed;
    /// <summary>
    /// Function: IsBatarangPrimed
    /// </summary>
    public unsafe virtual bool IsBatarangPrimed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatarangPrimed, "BmGame.RPlayerControllerCombat.IsBatarangPrimed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetZapTime;
    /// <summary>
    /// Function: GetZapTime
    /// </summary>
    public unsafe virtual float GetZapTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetZapTime, "BmGame.RPlayerControllerCombat.GetZapTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStunTime;
    /// <summary>
    /// Function: GetStunTime
    /// </summary>
    public unsafe virtual float GetStunTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStunTime, "BmGame.RPlayerControllerCombat.GetStunTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoCombatWhileMoveInputIsIgnored;
    /// <summary>
    /// Function: CanDoCombatWhileMoveInputIsIgnored
    /// </summary>
    public unsafe virtual bool CanDoCombatWhileMoveInputIsIgnored()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoCombatWhileMoveInputIsIgnored, "BmGame.RPlayerControllerCombat.CanDoCombatWhileMoveInputIsIgnored");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoCombat;
    /// <summary>
    /// Function: CanDoCombat
    /// </summary>
    public unsafe virtual bool CanDoCombat(bool CheckForEvade = default, bool bDebugOutput = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoCombat, "BmGame.RPlayerControllerCombat.CanDoCombat");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckForEvade, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugOutput, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsZapped;
    /// <summary>
    /// Function: IsZapped
    /// </summary>
    public unsafe virtual bool IsZapped()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsZapped, "BmGame.RPlayerControllerCombat.IsZapped");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsStunned;
    /// <summary>
    /// Function: IsStunned
    /// </summary>
    public unsafe virtual bool IsStunned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStunned, "BmGame.RPlayerControllerCombat.IsStunned");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasBeenHit;
    /// <summary>
    /// Function: HasBeenHit
    /// </summary>
    public unsafe virtual bool HasBeenHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBeenHit, "BmGame.RPlayerControllerCombat.HasBeenHit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartBeenHitCheck;
    /// <summary>
    /// Function: StartBeenHitCheck
    /// </summary>
    public unsafe virtual void StartBeenHitCheck()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartBeenHitCheck, "BmGame.RPlayerControllerCombat.StartBeenHitCheck");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasEverBeenHit;
    /// <summary>
    /// Function: HasEverBeenHit
    /// </summary>
    public unsafe virtual bool HasEverBeenHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasEverBeenHit, "BmGame.RPlayerControllerCombat.HasEverBeenHit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartEverBeenHitCheck;
    /// <summary>
    /// Function: StartEverBeenHitCheck
    /// </summary>
    public unsafe virtual void StartEverBeenHitCheck()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartEverBeenHitCheck, "BmGame.RPlayerControllerCombat.StartEverBeenHitCheck");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInCombatForDialogue;
    /// <summary>
    /// Function: IsInCombatForDialogue
    /// </summary>
    public unsafe virtual bool IsInCombatForDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInCombatForDialogue, "BmGame.RPlayerControllerCombat.IsInCombatForDialogue");
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

    private static BmSDK.Function __fn_IsValidStrikeTarget;
    /// <summary>
    /// Function: IsValidStrikeTarget
    /// </summary>
    public unsafe virtual bool IsValidStrikeTarget(System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType, BmSDK.BmGame.RPawnVillain TestPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidStrikeTarget, "BmGame.RPlayerControllerCombat.IsValidStrikeTarget");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_FindStrikeTarget;
    /// <summary>
    /// Function: FindStrikeTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain FindStrikeTarget(System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindStrikeTarget, "BmGame.RPlayerControllerCombat.FindStrikeTarget");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetLookAtEnemy;
    /// <summary>
    /// Function: GetLookAtEnemy
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat GetLookAtEnemy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLookAtEnemy, "BmGame.RPlayerControllerCombat.GetLookAtEnemy");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMovesToUnlockSpecial;
    /// <summary>
    /// Function: GetMovesToUnlockSpecial
    /// </summary>
    public unsafe virtual int GetMovesToUnlockSpecial()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMovesToUnlockSpecial, "BmGame.RPlayerControllerCombat.GetMovesToUnlockSpecial");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveCounterListener;
    /// <summary>
    /// Function: RemoveCounterListener
    /// </summary>
    public unsafe virtual void RemoveCounterListener(System.IntPtr del)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCounterListener, "BmGame.RPlayerControllerCombat.RemoveCounterListener");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(del, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCounterListener;
    /// <summary>
    /// Function: AddCounterListener
    /// </summary>
    public unsafe virtual void AddCounterListener(System.IntPtr del)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCounterListener, "BmGame.RPlayerControllerCombat.AddCounterListener");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(del, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickGadgetThumbLeftTimeout;
    /// <summary>
    /// Function: QuickGadgetThumbLeftTimeout
    /// </summary>
    public unsafe virtual void QuickGadgetThumbLeftTimeout()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickGadgetThumbLeftTimeout, "BmGame.RPlayerControllerCombat.QuickGadgetThumbLeftTimeout");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickGadgetThumbRightTimeout;
    /// <summary>
    /// Function: QuickGadgetThumbRightTimeout
    /// </summary>
    public unsafe virtual void QuickGadgetThumbRightTimeout()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickGadgetThumbRightTimeout, "BmGame.RPlayerControllerCombat.QuickGadgetThumbRightTimeout");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryCountering;
    /// <summary>
    /// Function: TryCountering
    /// </summary>
    public unsafe virtual bool TryCountering(BmSDK.BmGame.RPlayerControllerCombat Controller, bool bCanStartMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryCountering, "BmGame.RPlayerControllerCombat.TryCountering");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Controller, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanStartMove, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
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
