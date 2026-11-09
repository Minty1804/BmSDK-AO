#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMAIController<br/>
/// (size = 1104)
/// (flags = 142606482)
/// </summary>
public partial class RBMAIController : BmSDK.Engine.AIController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMAIController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMAIController.
    /// </summary>
    public static RBMAIController DefaultObject => (RBMAIController)StaticClass().DefaultObject;

    internal RBMAIController() { }

    /// <summary>
    /// Constructs a new RBMAIController
    /// </summary>
    public RBMAIController(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMAIController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIController>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_NotifyDestroyAttractor;
    /// <summary>
    /// Function: NotifyDestroyAttractor
    /// </summary>
    public unsafe virtual void NotifyDestroyAttractor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyDestroyAttractor, "BmGame.RBMAIController.NotifyDestroyAttractor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartRictus;
    /// <summary>
    /// Function: StartRictus
    /// </summary>
    public unsafe virtual void StartRictus()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRictus, "BmGame.RBMAIController.StartRictus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IdleConfigIsBlockingLowPriorityPred;
    /// <summary>
    /// Function: IdleConfigIsBlockingLowPriorityPred
    /// </summary>
    public unsafe virtual bool IdleConfigIsBlockingLowPriorityPred()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IdleConfigIsBlockingLowPriorityPred, "BmGame.RBMAIController.IdleConfigIsBlockingLowPriorityPred");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TakedownCancelled;
    /// <summary>
    /// Function: TakedownCancelled
    /// </summary>
    public unsafe virtual void TakedownCancelled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakedownCancelled, "BmGame.RBMAIController.TakedownCancelled");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyGunJamDiscovered;
    /// <summary>
    /// Function: NotifyGunJamDiscovered
    /// </summary>
    public unsafe virtual void NotifyGunJamDiscovered()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyGunJamDiscovered, "BmGame.RBMAIController.NotifyGunJamDiscovered");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPredThugInSmoke;
    /// <summary>
    /// Function: IsPredThugInSmoke
    /// </summary>
    public unsafe virtual bool IsPredThugInSmoke()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPredThugInSmoke, "BmGame.RBMAIController.IsPredThugInSmoke");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyPathEdgeReached;
    /// <summary>
    /// Function: NotifyPathEdgeReached
    /// </summary>
    public unsafe virtual void NotifyPathEdgeReached(BmSDK.BmGame.RBMAIAction NotifyAction, BmSDK.BmGame.RNavigationHandle NotifyHandle, int EdgeID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPathEdgeReached, "BmGame.RBMAIController.NotifyPathEdgeReached");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyHandle, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EdgeID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPathFound;
    /// <summary>
    /// Function: NotifyPathFound
    /// </summary>
    public unsafe virtual void NotifyPathFound(BmSDK.BmGame.RBMAIAction NotifyAction, BmSDK.BmGame.RNavigationHandle NotifyHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPathFound, "BmGame.RBMAIController.NotifyPathFound");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyHandle, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyEvent;
    /// <summary>
    /// Function: NotifyEvent
    /// </summary>
    public unsafe virtual void NotifyEvent(BmSDK.BmGame.RBMAIAction NotifyAction, BmSDK.FString EventType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyEvent, "BmGame.RBMAIController.NotifyEvent");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFailed;
    /// <summary>
    /// Function: NotifyFailed
    /// </summary>
    public unsafe virtual void NotifyFailed(BmSDK.BmGame.RBMAIAction FinishedAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFailed, "BmGame.RBMAIController.NotifyFailed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyStopped;
    /// <summary>
    /// Function: NotifyStopped
    /// </summary>
    public unsafe virtual void NotifyStopped(BmSDK.BmGame.RBMAIAction FinishedAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyStopped, "BmGame.RBMAIController.NotifyStopped");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFinished;
    /// <summary>
    /// Function: NotifyFinished
    /// </summary>
    public unsafe virtual void NotifyFinished(BmSDK.BmGame.RBMAIAction FinishedAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFinished, "BmGame.RBMAIController.NotifyFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SeenAnotherThug;
    /// <summary>
    /// Function: SeenAnotherThug
    /// </summary>
    public unsafe virtual void SeenAnotherThug(BmSDK.BmGame.RPawnVillain SeenPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SeenAnotherThug, "BmGame.RBMAIController.SeenAnotherThug");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeenPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishGlance;
    /// <summary>
    /// Function: FinishGlance
    /// </summary>
    public unsafe virtual void FinishGlance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishGlance, "BmGame.RBMAIController.FinishGlance");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGlanceTarget;
    /// <summary>
    /// Function: UpdateGlanceTarget
    /// </summary>
    public unsafe virtual void UpdateGlanceTarget(BmSDK.BmGame.AlertInstance NewBestGlanceable, int NewGlancePriority)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGlanceTarget, "BmGame.RBMAIController.UpdateGlanceTarget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBestGlanceable, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGlancePriority, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnBumpedByPlayer;
    /// <summary>
    /// Function: PawnBumpedByPlayer
    /// </summary>
    public unsafe virtual void PawnBumpedByPlayer(BmSDK.BmGame.RPawnPlayer Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnBumpedByPlayer, "BmGame.RBMAIController.PawnBumpedByPlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndPredator;
    /// <summary>
    /// Function: EndPredator
    /// </summary>
    public unsafe virtual void EndPredator()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndPredator, "BmGame.RBMAIController.EndPredator");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsClaimedBy;
    /// <summary>
    /// Function: IsClaimedBy
    /// </summary>
    public unsafe virtual bool IsClaimedBy(BmSDK.BmGame.RAlertEventCoordinatorBase TestCoord)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsClaimedBy, "BmGame.RBMAIController.IsClaimedBy");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestCoord, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_LowerCurrentPriority;
    /// <summary>
    /// Function: LowerCurrentPriority
    /// </summary>
    public unsafe virtual void LowerCurrentPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LowerCurrentPriority, "BmGame.RBMAIController.LowerCurrentPriority");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePriority;
    /// <summary>
    /// Function: UpdatePriority
    /// </summary>
    public unsafe virtual void UpdatePriority(int NewPriority)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePriority, "BmGame.RBMAIController.UpdatePriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPriority, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuccessfullyClaimedBy;
    /// <summary>
    /// Function: SuccessfullyClaimedBy
    /// </summary>
    public unsafe virtual bool SuccessfullyClaimedBy(BmSDK.BmGame.RAlertEventCoordinatorBase NewCoord, int NewPriority, bool bForceClaim = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuccessfullyClaimedBy, "BmGame.RBMAIController.SuccessfullyClaimedBy");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCoord, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPriority, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceClaim, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CanBeClaimedBy;
    /// <summary>
    /// Function: CanBeClaimedBy
    /// </summary>
    public unsafe virtual bool CanBeClaimedBy(int NewPriority)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeClaimedBy, "BmGame.RBMAIController.CanBeClaimedBy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPriority, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsStunnedOrLaughing;
    /// <summary>
    /// Function: IsStunnedOrLaughing
    /// </summary>
    public unsafe virtual bool IsStunnedOrLaughing()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStunnedOrLaughing, "BmGame.RBMAIController.IsStunnedOrLaughing");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateShootingBark;
    /// <summary>
    /// Function: UpdateShootingBark
    /// </summary>
    public unsafe virtual void UpdateShootingBark(float fireTimer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateShootingBark, "BmGame.RBMAIController.UpdateShootingBark");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fireTimer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsLitePredThug;
    /// <summary>
    /// Function: IsLitePredThug
    /// </summary>
    public unsafe virtual bool IsLitePredThug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLitePredThug, "BmGame.RBMAIController.IsLitePredThug");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyGunEmpty;
    /// <summary>
    /// Function: NotifyGunEmpty
    /// </summary>
    public unsafe virtual void NotifyGunEmpty()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyGunEmpty, "BmGame.RBMAIController.NotifyGunEmpty");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUpNotify;
    /// <summary>
    /// Function: GetUpNotify
    /// </summary>
    public unsafe virtual void GetUpNotify()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUpNotify, "BmGame.RBMAIController.GetUpNotify");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinalBlowFinished;
    /// <summary>
    /// Function: FinalBlowFinished
    /// </summary>
    public unsafe virtual void FinalBlowFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinalBlowFinished, "BmGame.RBMAIController.FinalBlowFinished");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinalBlowTarget;
    /// <summary>
    /// Function: FinalBlowTarget
    /// </summary>
    public unsafe virtual void FinalBlowTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinalBlowTarget, "BmGame.RBMAIController.FinalBlowTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBeingTakenDown;
    /// <summary>
    /// Function: IsBeingTakenDown
    /// </summary>
    public unsafe virtual void IsBeingTakenDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBeingTakenDown, "BmGame.RBMAIController.IsBeingTakenDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFallEmote;
    /// <summary>
    /// Function: PlayFallEmote
    /// </summary>
    public unsafe virtual void PlayFallEmote()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFallEmote, "BmGame.RBMAIController.PlayFallEmote");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHangAttackScream;
    /// <summary>
    /// Function: PlayHangAttackScream
    /// </summary>
    public unsafe virtual void PlayHangAttackScream()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHangAttackScream, "BmGame.RBMAIController.PlayHangAttackScream");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBatmanGrab;
    /// <summary>
    /// Function: CanBatmanGrab
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController.BatmanGrabType CanBatmanGrab()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBatmanGrab, "BmGame.RBMAIController.CanBatmanGrab");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController.BatmanGrabType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BroadcastBatmanSpottedToSnipers;
    /// <summary>
    /// Function: BroadcastBatmanSpottedToSnipers
    /// </summary>
    public unsafe virtual void BroadcastBatmanSpottedToSnipers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BroadcastBatmanSpottedToSnipers, "BmGame.RBMAIController.BroadcastBatmanSpottedToSnipers");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PredThugDisarmed;
    /// <summary>
    /// Function: PredThugDisarmed
    /// </summary>
    public unsafe virtual void PredThugDisarmed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PredThugDisarmed, "BmGame.RBMAIController.PredThugDisarmed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupNoisyTakedownWithNoReaction;
    /// <summary>
    /// Function: SetupNoisyTakedownWithNoReaction
    /// </summary>
    public unsafe virtual void SetupNoisyTakedownWithNoReaction(BmSDK.BmGame.RBMAIController.CasualtyScreamReason ScreamReason)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupNoisyTakedownWithNoReaction, "BmGame.RBMAIController.SetupNoisyTakedownWithNoReaction");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreamReason, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoNoisyTakedown;
    /// <summary>
    /// Function: DoNoisyTakedown
    /// </summary>
    public unsafe virtual void DoNoisyTakedown(BmSDK.BmGame.RBMAIController.CasualtyScreamReason ScreamReason)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoNoisyTakedown, "BmGame.RBMAIController.DoNoisyTakedown");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreamReason, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAlerts;
    /// <summary>
    /// Function: ClearAlerts
    /// </summary>
    public unsafe virtual void ClearAlerts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAlerts, "BmGame.RBMAIController.ClearAlerts");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddAlert;
    /// <summary>
    /// Function: AddAlert
    /// </summary>
    public unsafe virtual void AddAlert(BmSDK.Engine.Actor NewActor, System.Numerics.Vector3 NewLocation, BmSDK.BmGame.AlertInstance.InterruptType NewType, bool bAddIfNew = default, float BackDateTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddAlert, "BmGame.RBMAIController.AddAlert");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddIfNew, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BackDateTime, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveAlertActor;
    /// <summary>
    /// Function: RemoveAlertActor
    /// </summary>
    public unsafe virtual void RemoveAlertActor(BmSDK.Engine.Actor ExAlertActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAlertActor, "BmGame.RBMAIController.RemoveAlertActor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExAlertActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddNewAlertActor;
    /// <summary>
    /// Function: AddNewAlertActor
    /// </summary>
    public unsafe virtual void AddNewAlertActor(BmSDK.Engine.Actor NewAlertActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddNewAlertActor, "BmGame.RBMAIController.AddNewAlertActor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAlertActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireSeenEvents;
    /// <summary>
    /// Function: FireSeenEvents
    /// </summary>
    public unsafe virtual void FireSeenEvents()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireSeenEvents, "BmGame.RBMAIController.FireSeenEvents");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldIgnoreSilentPredator;
    /// <summary>
    /// Function: ShouldIgnoreSilentPredator
    /// </summary>
    public unsafe virtual bool ShouldIgnoreSilentPredator()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldIgnoreSilentPredator, "BmGame.RBMAIController.ShouldIgnoreSilentPredator");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RoomFearChanged;
    /// <summary>
    /// Function: RoomFearChanged
    /// </summary>
    public unsafe virtual void RoomFearChanged(BmSDK.BmGame.RBMRoomAIState.VillainFearLevel NewLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RoomFearChanged, "BmGame.RBMAIController.RoomFearChanged");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAnimationFearLevel;
    /// <summary>
    /// Function: GetAnimationFearLevel
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMRoomAIState.VillainFearLevel GetAnimationFearLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimationFearLevel, "BmGame.RBMAIController.GetAnimationFearLevel");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMRoomAIState.VillainFearLevel>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDialogueFearLevel;
    /// <summary>
    /// Function: GetDialogueFearLevel
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMRoomAIState.VillainFearLevel GetDialogueFearLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDialogueFearLevel, "BmGame.RBMAIController.GetDialogueFearLevel");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMRoomAIState.VillainFearLevel>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBarkPriority;
    /// <summary>
    /// Function: GetBarkPriority
    /// </summary>
    public unsafe virtual int GetBarkPriority(BmSDK.BmGame.RBMAIController.BarkType BarkIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBarkPriority, "BmGame.RBMAIController.GetBarkPriority");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnStopSpeech;
    /// <summary>
    /// Function: OnStopSpeech
    /// </summary>
    public unsafe virtual void OnStopSpeech(BmSDK.BmGame.RBMSeqAct_StopSpeech SpeechAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnStopSpeech, "BmGame.RBMAIController.OnStopSpeech");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeechAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySpeechCombined;
    /// <summary>
    /// Function: PlaySpeechCombined
    /// </summary>
    public unsafe virtual void PlaySpeechCombined(BmSDK.BmGame.RSeqAct_PlaySpeechCombined SpeechAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpeechCombined, "BmGame.RBMAIController.PlaySpeechCombined");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeechAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPlaySpeech;
    /// <summary>
    /// Function: OnPlaySpeech
    /// </summary>
    public unsafe virtual void OnPlaySpeech(BmSDK.BmGame.RBMSeqAct_PlaySpeech SpeechAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlaySpeech, "BmGame.RBMAIController.OnPlaySpeech");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeechAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySpeechGeneric;
    /// <summary>
    /// Function: PlaySpeechGeneric
    /// </summary>
    public unsafe virtual void PlaySpeechGeneric(BmSDK.Engine.RDialogueLine DialogueLine, bool bInterruptCurrentSpeech, BmSDK.BmGame.RSeqAct_PlaySpeechBase SpeechAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpeechGeneric, "BmGame.RBMAIController.PlaySpeechGeneric");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInterruptCurrentSpeech, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeechAction, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFlagsForNumberOfGargs;
    /// <summary>
    /// Function: AddFlagsForNumberOfGargs
    /// </summary>
    public unsafe virtual void AddFlagsForNumberOfGargs(out BmSDK.BmGame.RBarkFlagBase ContextFlags)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFlagsForNumberOfGargs, "BmGame.RBMAIController.AddFlagsForNumberOfGargs");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ContextFlags);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContextFlags = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkFlagBase>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetEnvironmentFlags;
    /// <summary>
    /// Function: SetEnvironmentFlags
    /// </summary>
    public unsafe virtual void SetEnvironmentFlags(out BmSDK.BmGame.RBarkFlagBase FB)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEnvironmentFlags, "BmGame.RBMAIController.SetEnvironmentFlags");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FB);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FB, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FB = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkFlagBase>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_PlayExclaimBark;
    /// <summary>
    /// Function: PlayExclaimBark
    /// </summary>
    public unsafe virtual bool PlayExclaimBark(int TestPriority)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayExclaimBark, "BmGame.RBMAIController.PlayExclaimBark");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPriority, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayBarkFromIndex;
    /// <summary>
    /// Function: PlayBarkFromIndex
    /// </summary>
    public unsafe virtual bool PlayBarkFromIndex(BmSDK.BmGame.RBMAIController.BarkType CueIndex, BmSDK.Engine.Actor BarkSubject = default, BmSDK.TArray<BmSDK.BmGame.RBarkFlagBase.FBarkFlag> ExtraFlags = default, bool bIsFollowOn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBarkFromIndex, "BmGame.RBMAIController.PlayBarkFromIndex");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CueIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkSubject, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraFlags, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsFollowOn, paramsPtr + 20);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_PlayBarkFromIndexIfQuiet;
    /// <summary>
    /// Function: PlayBarkFromIndexIfQuiet
    /// </summary>
    public unsafe virtual void PlayBarkFromIndexIfQuiet(BmSDK.BmGame.RBMAIController.BarkType CueIndex, BmSDK.TArray<BmSDK.BmGame.RBarkFlagBase.FBarkFlag> ExtraFlags = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBarkFromIndexIfQuiet, "BmGame.RBMAIController.PlayBarkFromIndexIfQuiet");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CueIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraFlags, paramsPtr + 4);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_PlayTannoyResponseBark;
    /// <summary>
    /// Function: PlayTannoyResponseBark
    /// </summary>
    public unsafe virtual void PlayTannoyResponseBark(BmSDK.BmGame.RGameInfo.ThugResponseType ResponseType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayTannoyResponseBark, "BmGame.RBMAIController.PlayTannoyResponseBark");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResponseType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayRandomBark;
    /// <summary>
    /// Function: PlayRandomBark
    /// </summary>
    public unsafe virtual bool PlayRandomBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRandomBark, "BmGame.RBMAIController.PlayRandomBark");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DrawViewCone;
    /// <summary>
    /// Function: DrawViewCone
    /// </summary>
    public unsafe virtual void DrawViewCone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawViewCone, "BmGame.RBMAIController.DrawViewCone");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe virtual void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmGame.RBMAIController.GetThoughts");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddThought;
    /// <summary>
    /// Function: AddThought
    /// </summary>
    public unsafe virtual void AddThought(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList, BmSDK.FString ThoughtText, int R = default, int G = default, int B = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddThought, "BmGame.RBMAIController.AddThought");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThoughtText, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveFromAIManager;
    /// <summary>
    /// Function: RemoveFromAIManager
    /// </summary>
    public unsafe override void RemoveFromAIManager()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveFromAIManager, "BmGame.RBMAIController.RemoveFromAIManager");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCheckFalling;
    /// <summary>
    /// Function: CanCheckFalling
    /// </summary>
    public unsafe virtual bool CanCheckFalling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCheckFalling, "BmGame.RBMAIController.CanCheckFalling");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DodgeLineLaunchKick;
    /// <summary>
    /// Function: DodgeLineLaunchKick
    /// </summary>
    public unsafe virtual bool DodgeLineLaunchKick(BmSDK.BmGame.RPawnPlayer Attacker, System.Numerics.Vector3 KickDirection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DodgeLineLaunchKick, "BmGame.RBMAIController.DodgeLineLaunchKick");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KickDirection, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_DodgeDropAttack;
    /// <summary>
    /// Function: DodgeDropAttack
    /// </summary>
    public unsafe virtual bool DodgeDropAttack(BmSDK.BmGame.RPawnPlayer Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DodgeDropAttack, "BmGame.RBMAIController.DodgeDropAttack");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckDodgeProjectile;
    /// <summary>
    /// Function: CheckDodgeProjectile
    /// </summary>
    public unsafe virtual bool CheckDodgeProjectile(BmSDK.BmGame.RPawn Thrower, BmSDK.FName TargetBone, System.Numerics.Vector3 ProjPos, int BatarangID, bool bForceDodge = default, bool bSteerableProj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDodgeProjectile, "BmGame.RBMAIController.CheckDodgeProjectile");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBone, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangID, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDodge, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSteerableProj, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetDodgeClass;
    /// <summary>
    /// Function: GetDodgeClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetDodgeClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDodgeClass, "BmGame.RBMAIController.GetDodgeClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDodgeProjectile;
    /// <summary>
    /// Function: CanDodgeProjectile
    /// </summary>
    public unsafe virtual bool CanDodgeProjectile(System.Numerics.Vector3 ThrownFromPos, int CheckBatarangID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDodgeProjectile, "BmGame.RBMAIController.CanDodgeProjectile");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckBatarangID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_BlockAttack;
    /// <summary>
    /// Function: BlockAttack
    /// </summary>
    public unsafe virtual void BlockAttack(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlockAttack, "BmGame.RBMAIController.BlockAttack");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepareToBlockAttack;
    /// <summary>
    /// Function: PrepareToBlockAttack
    /// </summary>
    public unsafe virtual void PrepareToBlockAttack(BmSDK.BmGame.RPawnCombat Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepareToBlockAttack, "BmGame.RBMAIController.PrepareToBlockAttack");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RepelAttack;
    /// <summary>
    /// Function: RepelAttack
    /// </summary>
    public unsafe virtual void RepelAttack(BmSDK.BmGame.RPawnCombat Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RepelAttack, "BmGame.RBMAIController.RepelAttack");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleClusterGrenadeHitInternal;
    /// <summary>
    /// Function: HandleClusterGrenadeHitInternal
    /// </summary>
    public unsafe bool HandleClusterGrenadeHitInternal(BmSDK.BmGame.RPawnPlayer Player, System.Numerics.Vector3 HitNormal, BmSDK.BmGame.MPawnVillain_FundamentalGrenadeGadget Fundamental)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleClusterGrenadeHitInternal, "BmGame.RBMAIController.HandleClusterGrenadeHitInternal");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fundamental, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_HandleGlueClusterGrenadeHit;
    /// <summary>
    /// Function: HandleGlueClusterGrenadeHit
    /// </summary>
    public unsafe virtual bool HandleGlueClusterGrenadeHit(BmSDK.BmGame.RPawnPlayer Player, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleGlueClusterGrenadeHit, "BmGame.RBMAIController.HandleGlueClusterGrenadeHit");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_HandleGrenadeHitInternal;
    /// <summary>
    /// Function: HandleGrenadeHitInternal
    /// </summary>
    public unsafe bool HandleGrenadeHitInternal(BmSDK.BmGame.RPawnPlayer Player, System.Numerics.Vector3 HitNormal, BmSDK.BmGame.RGadgetProjectileBase Projectile, bool bInstantFreeze, BmSDK.BmGame.MPawnVillain_FundamentalGrenadeGadget Fundamental)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleGrenadeHitInternal, "BmGame.RBMAIController.HandleGrenadeHitInternal");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Projectile, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstantFreeze, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fundamental, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ShouldEnterCombatWhenGrenadeHit;
    /// <summary>
    /// Function: ShouldEnterCombatWhenGrenadeHit
    /// </summary>
    public unsafe virtual bool ShouldEnterCombatWhenGrenadeHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldEnterCombatWhenGrenadeHit, "BmGame.RBMAIController.ShouldEnterCombatWhenGrenadeHit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HandleGlueGrenadeHit;
    /// <summary>
    /// Function: HandleGlueGrenadeHit
    /// </summary>
    public unsafe virtual bool HandleGlueGrenadeHit(BmSDK.BmGame.RPawnPlayer Player, System.Numerics.Vector3 HitNormal, BmSDK.BmGame.RGadgetProjectileBase Projectile, bool bInstantFreeze)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleGlueGrenadeHit, "BmGame.RBMAIController.HandleGlueGrenadeHit");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Projectile, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstantFreeze, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_TakeElectricityDamage;
    /// <summary>
    /// Function: TakeElectricityDamage
    /// </summary>
    public unsafe virtual void TakeElectricityDamage(System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor HitActor = default, bool bKill = default, BmSDK.Class dmgType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeElectricityDamage, "BmGame.RBMAIController.TakeElectricityDamage");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GoRagdoll;
    /// <summary>
    /// Function: GoRagdoll
    /// </summary>
    public unsafe virtual void GoRagdoll(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, BmSDK.BmGame.RGameInfo.RagdollStunType NewStunType = default, bool bKill = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoRagdoll, "BmGame.RBMAIController.GoRagdoll");
        byte* paramsPtr = stackalloc byte[308];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStunType, paramsPtr + 256);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 260);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetStunnedRagdoll;
    /// <summary>
    /// Function: SetStunnedRagdoll
    /// </summary>
    public unsafe virtual void SetStunnedRagdoll(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStunnedRagdoll, "BmGame.RBMAIController.SetStunnedRagdoll");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Redirected;
    /// <summary>
    /// Function: Redirected
    /// </summary>
    public unsafe virtual void Redirected()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Redirected, "BmGame.RBMAIController.Redirected");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeHitInCombat;
    /// <summary>
    /// Function: CanBeHitInCombat
    /// </summary>
    public unsafe virtual bool CanBeHitInCombat(BmSDK.BmGame.RDamageType DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeHitInCombat, "BmGame.RBMAIController.CanBeHitInCombat");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CombatMoveInitialised;
    /// <summary>
    /// Function: CombatMoveInitialised
    /// </summary>
    public unsafe virtual void CombatMoveInitialised(BmSDK.BmGame.RCombatMove NewMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatMoveInitialised, "BmGame.RBMAIController.CombatMoveInitialised");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCM;
    /// <summary>
    /// Function: GetCM
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatManager GetCM()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCM, "BmGame.RBMAIController.GetCM");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatManager>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DemoteBehaviour;
    /// <summary>
    /// Function: DemoteBehaviour
    /// </summary>
    public unsafe virtual void DemoteBehaviour(BmSDK.BmGame.RBMBehaviour BehaviourToDemote)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DemoteBehaviour, "BmGame.RBMAIController.DemoteBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourToDemote, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InstantExitBehaviour;
    /// <summary>
    /// Function: InstantExitBehaviour
    /// </summary>
    public unsafe virtual void InstantExitBehaviour(BmSDK.BmGame.RBMBehaviour BehaviourToExit, bool bCallEndInterrupt = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstantExitBehaviour, "BmGame.RBMAIController.InstantExitBehaviour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourToExit, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCallEndInterrupt, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickBehaviour;
    /// <summary>
    /// Function: TickBehaviour
    /// </summary>
    public unsafe virtual void TickBehaviour(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickBehaviour, "BmGame.RBMAIController.TickBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PointIsValidLookatPos;
    /// <summary>
    /// Function: PointIsValidLookatPos
    /// </summary>
    public unsafe virtual bool PointIsValidLookatPos(System.Numerics.Vector3 TestPos, bool bDoTrace = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointIsValidLookatPos, "BmGame.RBMAIController.PointIsValidLookatPos");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoTrace, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetDirectionOfFocus;
    /// <summary>
    /// Function: GetDirectionOfFocus
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDirectionOfFocus()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDirectionOfFocus, "BmGame.RBMAIController.GetDirectionOfFocus");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnDefaultBehaviour;
    /// <summary>
    /// Function: SpawnDefaultBehaviour
    /// </summary>
    public unsafe virtual void SpawnDefaultBehaviour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDefaultBehaviour, "BmGame.RBMAIController.SpawnDefaultBehaviour");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEntryAnim;
    /// <summary>
    /// Function: GetEntryAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetEntryAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEntryAnim, "BmGame.RBMAIController.GetEntryAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEntryAnimSet;
    /// <summary>
    /// Function: GetEntryAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetEntryAnimSet()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEntryAnimSet, "BmGame.RBMAIController.GetEntryAnimSet");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsValidSpeaker;
    /// <summary>
    /// Function: IsValidSpeaker
    /// </summary>
    public unsafe virtual bool IsValidSpeaker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidSpeaker, "BmGame.RBMAIController.IsValidSpeaker");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ProcessWeaponChange;
    /// <summary>
    /// Function: ProcessWeaponChange
    /// </summary>
    public unsafe virtual void ProcessWeaponChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessWeaponChange, "BmGame.RBMAIController.ProcessWeaponChange");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponChanged;
    /// <summary>
    /// Function: WeaponChanged
    /// </summary>
    public unsafe virtual void WeaponChanged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponChanged, "BmGame.RBMAIController.WeaponChanged");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldCombatantForceCombatCamera;
    /// <summary>
    /// Function: ShouldCombatantForceCombatCamera
    /// </summary>
    public unsafe virtual bool ShouldCombatantForceCombatCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldCombatantForceCombatCamera, "BmGame.RBMAIController.ShouldCombatantForceCombatCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldCombatantLockDoors;
    /// <summary>
    /// Function: ShouldCombatantLockDoors
    /// </summary>
    public unsafe virtual bool ShouldCombatantLockDoors()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldCombatantLockDoors, "BmGame.RBMAIController.ShouldCombatantLockDoors");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearCombatBehaviour;
    /// <summary>
    /// Function: ClearCombatBehaviour
    /// </summary>
    public unsafe virtual void ClearCombatBehaviour(BmSDK.BmGame.RBMBehaviour_Combat CombatBehaviourToClear)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCombatBehaviour, "BmGame.RBMAIController.ClearCombatBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatBehaviourToClear, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombatBehaviour;
    /// <summary>
    /// Function: SetCombatBehaviour
    /// </summary>
    public unsafe virtual void SetCombatBehaviour(BmSDK.BmGame.RBMBehaviour_Combat NewCombatBehaviour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombatBehaviour, "BmGame.RBMAIController.SetCombatBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCombatBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindAndUseWanderPoint;
    /// <summary>
    /// Function: FindAndUseWanderPoint
    /// </summary>
    public unsafe virtual bool FindAndUseWanderPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAndUseWanderPoint, "BmGame.RBMAIController.FindAndUseWanderPoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNextWanderPoint;
    /// <summary>
    /// Function: GetNextWanderPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWanderPoint GetNextWanderPoint(BmSDK.BmGame.RWanderPoint.WanderPointType pointType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextWanderPoint, "BmGame.RBMAIController.GetNextWanderPoint");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pointType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWanderPoint>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnPostFleeIdleBehaviour;
    /// <summary>
    /// Function: SpawnPostFleeIdleBehaviour
    /// </summary>
    public unsafe virtual void SpawnPostFleeIdleBehaviour(bool bInstant = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnPostFleeIdleBehaviour, "BmGame.RBMAIController.SpawnPostFleeIdleBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstant, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnVillainFleeBehaviour;
    /// <summary>
    /// Function: SpawnVillainFleeBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour_Flee SpawnVillainFleeBehaviour(bool bInstant = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnVillainFleeBehaviour, "BmGame.RBMAIController.SpawnVillainFleeBehaviour");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstant, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMBehaviour_Flee>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnFleeBehaviour;
    /// <summary>
    /// Function: SpawnFleeBehaviour
    /// </summary>
    public unsafe virtual void SpawnFleeBehaviour(bool bInstant = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFleeBehaviour, "BmGame.RBMAIController.SpawnFleeBehaviour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstant, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Flee;
    /// <summary>
    /// Function: Flee
    /// </summary>
    public unsafe virtual void Flee(BmSDK.BmGame.RBMBehaviour_Flee FleeBehaviour, bool bInstant = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Flee, "BmGame.RBMAIController.Flee");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FleeBehaviour, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstant, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnCombatBehaviour;
    /// <summary>
    /// Function: SpawnCombatBehaviour
    /// </summary>
    public unsafe virtual void SpawnCombatBehaviour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnCombatBehaviour, "BmGame.RBMAIController.SpawnCombatBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitCombat;
    /// <summary>
    /// Function: ExitCombat
    /// </summary>
    public unsafe virtual void ExitCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitCombat, "BmGame.RBMAIController.ExitCombat");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterCombat;
    /// <summary>
    /// Function: EnterCombat
    /// </summary>
    public unsafe virtual void EnterCombat(bool bCanReactFirst = default, bool bForceIntoCombat = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterCombat, "BmGame.RBMAIController.EnterCombat");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanReactFirst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceIntoCombat, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterCombatWithDefaults;
    /// <summary>
    /// Function: EnterCombatWithDefaults
    /// </summary>
    public unsafe virtual void EnterCombatWithDefaults()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterCombatWithDefaults, "BmGame.RBMAIController.EnterCombatWithDefaults");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DelayedEnterCombat;
    /// <summary>
    /// Function: DelayedEnterCombat
    /// </summary>
    public unsafe virtual void DelayedEnterCombat(float Delay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DelayedEnterCombat, "BmGame.RBMAIController.DelayedEnterCombat");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayEnterCombatCue;
    /// <summary>
    /// Function: PlayEnterCombatCue
    /// </summary>
    public unsafe virtual void PlayEnterCombatCue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayEnterCombatCue, "BmGame.RBMAIController.PlayEnterCombatCue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleNoise;
    /// <summary>
    /// Function: HandleNoise
    /// </summary>
    public unsafe virtual void HandleNoise(BmSDK.BmGame.RPawnPlayer PlayerInstigator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleNoise, "BmGame.RBMAIController.HandleNoise");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerInstigator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBehaviourCustomEyeLocation;
    /// <summary>
    /// Function: GetBehaviourCustomEyeLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBehaviourCustomEyeLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBehaviourCustomEyeLocation, "BmGame.RBMAIController.GetBehaviourCustomEyeLocation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AdjustAnimatedAimDir;
    /// <summary>
    /// Function: AdjustAnimatedAimDir
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 AdjustAnimatedAimDir(System.Numerics.Vector3 AnimatedDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustAnimatedAimDir, "BmGame.RBMAIController.AdjustAnimatedAimDir");
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimatedDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DoPlayerLookAt;
    /// <summary>
    /// Function: DoPlayerLookAt
    /// </summary>
    public unsafe virtual void DoPlayerLookAt(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPlayerLookAt, "BmGame.RBMAIController.DoPlayerLookAt");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanLookAtPlayer;
    /// <summary>
    /// Function: CanLookAtPlayer
    /// </summary>
    public unsafe virtual bool CanLookAtPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanLookAtPlayer, "BmGame.RBMAIController.CanLookAtPlayer");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateNotVisibleAlert;
    /// <summary>
    /// Function: UpdateNotVisibleAlert
    /// </summary>
    public unsafe virtual void UpdateNotVisibleAlert(float DeltaTime, BmSDK.BmGame.AlertInstance A)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateNotVisibleAlert, "BmGame.RBMAIController.UpdateNotVisibleAlert");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetAlertText;
    /// <summary>
    /// Function: GetAlertText
    /// </summary>
    public unsafe virtual BmSDK.FString GetAlertText(BmSDK.BmGame.AlertInstance Al)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAlertText, "BmGame.RBMAIController.GetAlertText");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Al, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetLOSText;
    /// <summary>
    /// Function: GetLOSText
    /// </summary>
    public unsafe virtual bool GetLOSText(BmSDK.Engine.Actor TestActor, out BmSDK.FString LOSString, out byte R, out byte G, out byte B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLOSText, "BmGame.RBMAIController.GetLOSText");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out R);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out G);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 17);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out B);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 18);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        LOSString = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
        R = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 16);
        G = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 17);
        B = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 18);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_TriggerPawnActivatedEvent;
    /// <summary>
    /// Function: TriggerPawnActivatedEvent
    /// </summary>
    public unsafe virtual void TriggerPawnActivatedEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPawnActivatedEvent, "BmGame.RBMAIController.TriggerPawnActivatedEvent");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerPawnEvent;
    /// <summary>
    /// Function: TriggerPawnEvent
    /// </summary>
    public unsafe virtual bool TriggerPawnEvent(BmSDK.Class EventClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPawnEvent, "BmGame.RBMAIController.TriggerPawnEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OutputBehaviourStack;
    /// <summary>
    /// Function: OutputBehaviourStack
    /// </summary>
    public unsafe virtual void OutputBehaviourStack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OutputBehaviourStack, "BmGame.RBMAIController.OutputBehaviourStack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitConditionActivated;
    /// <summary>
    /// Function: ExitConditionActivated
    /// </summary>
    public unsafe virtual void ExitConditionActivated(BmSDK.FString ExitConditionString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitConditionActivated, "BmGame.RBMAIController.ExitConditionActivated");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExitConditionString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddToBehaviourHistory;
    /// <summary>
    /// Function: AddToBehaviourHistory
    /// </summary>
    public unsafe virtual void AddToBehaviourHistory(BmSDK.FString BehaviourInfoString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToBehaviourHistory, "BmGame.RBMAIController.AddToBehaviourHistory");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourInfoString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBehaviourOfClass;
    /// <summary>
    /// Function: GetBehaviourOfClass
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour GetBehaviourOfClass(BmSDK.Class TestClass, bool bExact = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBehaviourOfClass, "BmGame.RBMAIController.GetBehaviourOfClass");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExact, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMBehaviour>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_HasBehaviourOfClass;
    /// <summary>
    /// Function: HasBehaviourOfClass
    /// </summary>
    public unsafe virtual bool HasBehaviourOfClass(BmSDK.Class TestClass, bool bExact = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBehaviourOfClass, "BmGame.RBMAIController.HasBehaviourOfClass");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExact, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RemoveBehaviourFromList;
    /// <summary>
    /// Function: RemoveBehaviourFromList
    /// </summary>
    public unsafe virtual void RemoveBehaviourFromList(BmSDK.BmGame.RBMBehaviour BehaviourToRemove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveBehaviourFromList, "BmGame.RBMAIController.RemoveBehaviourFromList");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPreviousBehaviour;
    /// <summary>
    /// Function: GetPreviousBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour GetPreviousBehaviour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPreviousBehaviour, "BmGame.RBMAIController.GetPreviousBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMBehaviour>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLastBehaviour;
    /// <summary>
    /// Function: GetLastBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour GetLastBehaviour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLastBehaviour, "BmGame.RBMAIController.GetLastBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMBehaviour>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryClearSpecialMoves;
    /// <summary>
    /// Function: TryClearSpecialMoves
    /// </summary>
    public unsafe virtual void TryClearSpecialMoves()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryClearSpecialMoves, "BmGame.RBMAIController.TryClearSpecialMoves");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearSpawnedBehaviours;
    /// <summary>
    /// Function: ClearSpawnedBehaviours
    /// </summary>
    public unsafe virtual void ClearSpawnedBehaviours()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearSpawnedBehaviours, "BmGame.RBMAIController.ClearSpawnedBehaviours");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearBehavioursOfClass;
    /// <summary>
    /// Function: ClearBehavioursOfClass
    /// </summary>
    public unsafe virtual void ClearBehavioursOfClass(BmSDK.Class TestClass, bool bExact = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearBehavioursOfClass, "BmGame.RBMAIController.ClearBehavioursOfClass");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExact, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearInterruptBehaviours;
    /// <summary>
    /// Function: ClearInterruptBehaviours
    /// </summary>
    public unsafe virtual void ClearInterruptBehaviours(bool bCallEndInterrupt = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearInterruptBehaviours, "BmGame.RBMAIController.ClearInterruptBehaviours");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCallEndInterrupt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearNonInterruptBehaviours;
    /// <summary>
    /// Function: ClearNonInterruptBehaviours
    /// </summary>
    public unsafe virtual void ClearNonInterruptBehaviours()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearNonInterruptBehaviours, "BmGame.RBMAIController.ClearNonInterruptBehaviours");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearBehaviourList;
    /// <summary>
    /// Function: ClearBehaviourList
    /// </summary>
    public unsafe virtual void ClearBehaviourList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearBehaviourList, "BmGame.RBMAIController.ClearBehaviourList");
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

    private static BmSDK.Function __fn_RemoveExitCondition;
    /// <summary>
    /// Function: RemoveExitCondition
    /// </summary>
    public unsafe virtual void RemoveExitCondition(BmSDK.BmGame.RBMExitCondition ToRemove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveExitCondition, "BmGame.RBMAIController.RemoveExitCondition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddExitCondition;
    /// <summary>
    /// Function: AddExitCondition
    /// </summary>
    public unsafe virtual void AddExitCondition(BmSDK.BmGame.RBMExitCondition NewExitCondition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddExitCondition, "BmGame.RBMAIController.AddExitCondition");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewExitCondition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnBehaviour;
    /// <summary>
    /// Function: SpawnBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour SpawnBehaviour(BmSDK.Class BehaviourClass, BmSDK.BmGame.RBMBehaviour ParentBehaviour = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBehaviour, "BmGame.RBMAIController.SpawnBehaviour");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParentBehaviour, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMBehaviour>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ActivateSpawnedBehaviour;
    /// <summary>
    /// Function: ActivateSpawnedBehaviour
    /// </summary>
    public unsafe virtual void ActivateSpawnedBehaviour(BmSDK.BmGame.RBMBehaviour SpawnedBehaviour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateSpawnedBehaviour, "BmGame.RBMAIController.ActivateSpawnedBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnedBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateSpawnedBehaviour;
    /// <summary>
    /// Function: CreateSpawnedBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour CreateSpawnedBehaviour(BmSDK.Class BehaviourClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateSpawnedBehaviour, "BmGame.RBMAIController.CreateSpawnedBehaviour");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMBehaviour>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RegisterSpawnedBehaviour;
    /// <summary>
    /// Function: RegisterSpawnedBehaviour
    /// </summary>
    public unsafe virtual void RegisterSpawnedBehaviour(BmSDK.BmGame.RBMBehaviour NewBehaviour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterSpawnedBehaviour, "BmGame.RBMAIController.RegisterSpawnedBehaviour");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PriorityIsGreaterThan;
    /// <summary>
    /// Function: PriorityIsGreaterThan
    /// </summary>
    public unsafe virtual bool PriorityIsGreaterThan(BmSDK.BmGame.RBMBehaviour BehA, BmSDK.BmGame.RBMBehaviour BehB)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PriorityIsGreaterThan, "BmGame.RBMAIController.PriorityIsGreaterThan");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehA, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehB, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RegisterNewBehaviour;
    /// <summary>
    /// Function: RegisterNewBehaviour
    /// </summary>
    public unsafe virtual void RegisterNewBehaviour(BmSDK.BmGame.RBMBehaviour NewBehaviour, bool bInsertAtEnd = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterNewBehaviour, "BmGame.RBMAIController.RegisterNewBehaviour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBehaviour, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInsertAtEnd, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleNewBehaviour;
    /// <summary>
    /// Function: HandleNewBehaviour
    /// </summary>
    public unsafe virtual void HandleNewBehaviour(BmSDK.BmGame.RBMBehaviour NewBehaviour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleNewBehaviour, "BmGame.RBMAIController.HandleNewBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CleanUpBeforeRemove;
    /// <summary>
    /// Function: CleanUpBeforeRemove
    /// </summary>
    public unsafe virtual void CleanUpBeforeRemove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanUpBeforeRemove, "BmGame.RBMAIController.CleanUpBeforeRemove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnDied;
    /// <summary>
    /// Function: PawnDied
    /// </summary>
    public unsafe override void PawnDied(BmSDK.Engine.Pawn inPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnDied, "BmGame.RBMAIController.PawnDied");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnPossess;
    /// <summary>
    /// Function: UnPossess
    /// </summary>
    public unsafe override void UnPossess()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnPossess, "BmGame.RBMAIController.UnPossess");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe virtual void PostInitCharacter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmGame.RBMAIController.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReRegisterController;
    /// <summary>
    /// Function: ReRegisterController
    /// </summary>
    public unsafe virtual void ReRegisterController()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReRegisterController, "BmGame.RBMAIController.ReRegisterController");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Possess;
    /// <summary>
    /// Function: Possess
    /// </summary>
    public unsafe override void Possess(BmSDK.Engine.Pawn inPawn, bool bVehicleTransition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Possess, "BmGame.RBMAIController.Possess");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickMe;
    /// <summary>
    /// Function: TickMe
    /// </summary>
    public unsafe virtual void TickMe()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickMe, "BmGame.RBMAIController.TickMe");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RBMAIController.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBatarangable;
    /// <summary>
    /// Function: IsBatarangable
    /// </summary>
    public unsafe virtual bool IsBatarangable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatarangable, "BmGame.RBMAIController.IsBatarangable");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStunned, "BmGame.RBMAIController.IsStunned");
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

    private static BmSDK.Function __fn_SetTickIsDisabled;
    /// <summary>
    /// Function: SetTickIsDisabled
    /// </summary>
    public unsafe override void SetTickIsDisabled(bool bInDisabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTickIsDisabled, "BmGame.RBMAIController.SetTickIsDisabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInDisabled, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FindRailingForPoint;
    /// <summary>
    /// Function: FindRailingForPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMPathNode_FenceJump FindRailingForPoint(System.Numerics.Vector3 LockPoint, out System.Numerics.Vector3 LockPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindRailingForPoint, "BmGame.RBMAIController.FindRailingForPoint");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LockPoint, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out LockPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LockPosition, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LockPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMPathNode_FenceJump>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CalcVisibilityFor;
    /// <summary>
    /// Function: CalcVisibilityFor
    /// </summary>
    public unsafe virtual BmSDK.BmGame.AlertInstance.VisibilityCategory CalcVisibilityFor(BmSDK.Engine.Actor A, System.Numerics.Vector3 Checkpoint = default, float CanSeePercent = default, System.Numerics.Vector3 LookDir = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalcVisibilityFor, "BmGame.RBMAIController.CalcVisibilityFor");
        byte* paramsPtr = stackalloc byte[49];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Checkpoint, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanSeePercent, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookDir, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.AlertInstance.VisibilityCategory>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_FindAlertFor;
    /// <summary>
    /// Function: FindAlertFor
    /// </summary>
    public unsafe virtual BmSDK.BmGame.AlertInstance FindAlertFor(BmSDK.Engine.Actor A)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAlertFor, "BmGame.RBMAIController.FindAlertFor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.AlertInstance>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FindAlertForPlayer;
    /// <summary>
    /// Function: FindAlertForPlayer
    /// </summary>
    public unsafe virtual BmSDK.BmGame.AlertInstance FindAlertForPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAlertForPlayer, "BmGame.RBMAIController.FindAlertForPlayer");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.AlertInstance>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PawnInStasis;
    /// <summary>
    /// Function: PawnInStasis
    /// </summary>
    public unsafe virtual bool PawnInStasis()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnInStasis, "BmGame.RBMAIController.PawnInStasis");
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

    private static BmSDK.Function __fn_ShutDownBehaviour;
    /// <summary>
    /// Function: ShutDownBehaviour
    /// </summary>
    public unsafe virtual void ShutDownBehaviour(BmSDK.BmGame.RBMBehaviour BehaviourToExit, bool bCallEndInterrupt = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutDownBehaviour, "BmGame.RBMAIController.ShutDownBehaviour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourToExit, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCallEndInterrupt, paramsPtr + 4);
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

    private static BmSDK.Function __fn_TickBehaviourState;
    /// <summary>
    /// Function: TickBehaviourState
    /// </summary>
    public unsafe virtual void TickBehaviourState(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickBehaviourState, "BmGame.RBMAIController.TickBehaviourState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetAIManager;
    /// <summary>
    /// Function: GetAIManager
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIManager GetAIManager()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAIManager, "BmGame.RBMAIController.GetAIManager");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIManager>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoFaceFXForFear;
    /// <summary>
    /// Function: DoFaceFXForFear
    /// </summary>
    public unsafe virtual void DoFaceFXForFear()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoFaceFXForFear, "BmGame.RBMAIController.DoFaceFXForFear");
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

    private static BmSDK.Function __fn_GetSilentPredatorGlanceStanceName;
    /// <summary>
    /// Function: GetSilentPredatorGlanceStanceName
    /// </summary>
    public unsafe virtual BmSDK.FName GetSilentPredatorGlanceStanceName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSilentPredatorGlanceStanceName, "BmGame.RBMAIController.GetSilentPredatorGlanceStanceName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSilentPredatorStanceName;
    /// <summary>
    /// Function: GetSilentPredatorStanceName
    /// </summary>
    public unsafe virtual BmSDK.FName GetSilentPredatorStanceName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSilentPredatorStanceName, "BmGame.RBMAIController.GetSilentPredatorStanceName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ProcessSpottableAlerts;
    /// <summary>
    /// Function: ProcessSpottableAlerts
    /// </summary>
    public unsafe virtual void ProcessSpottableAlerts(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessSpottableAlerts, "BmGame.RBMAIController.ProcessSpottableAlerts");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetVisionCheckEyeLoc;
    /// <summary>
    /// Function: GetVisionCheckEyeLoc
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetVisionCheckEyeLoc()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVisionCheckEyeLoc, "BmGame.RBMAIController.GetVisionCheckEyeLoc");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetViewDir;
    /// <summary>
    /// Function: GetViewDir
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetViewDir(bool bFixUpAnimAimDir = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetViewDir, "BmGame.RBMAIController.GetViewDir");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFixUpAnimAimDir, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsPointInFOVWithLookDir;
    /// <summary>
    /// Function: IsPointInFOVWithLookDir
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController.FOVcategory IsPointInFOVWithLookDir(System.Numerics.Vector3 TestPos, System.Numerics.Vector3 LookDir, bool bUseActualAimDirForCloseCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPointInFOVWithLookDir, "BmGame.RBMAIController.IsPointInFOVWithLookDir");
        byte* paramsPtr = stackalloc byte[45];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseActualAimDirForCloseCheck, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController.FOVcategory>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_IsPointInFOV;
    /// <summary>
    /// Function: IsPointInFOV
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController.FOVcategory IsPointInFOV(System.Numerics.Vector3 TestPos, bool bFixUpAnimAimDir = default, bool bUseActualAimDirForCloseCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPointInFOV, "BmGame.RBMAIController.IsPointInFOV");
        byte* paramsPtr = stackalloc byte[37];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFixUpAnimAimDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseActualAimDirForCloseCheck, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController.FOVcategory>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_IsInFOV;
    /// <summary>
    /// Function: IsInFOV
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController.FOVcategory IsInFOV(BmSDK.Engine.Actor TestActor, bool bFixUpAnimAimDir = default, bool bUseActualAimDirForCloseCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInFOV, "BmGame.RBMAIController.IsInFOV");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFixUpAnimAimDir, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseActualAimDirForCloseCheck, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController.FOVcategory>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsRunningBehaviour;
    /// <summary>
    /// Function: IsRunningBehaviour
    /// </summary>
    public unsafe virtual bool IsRunningBehaviour(BmSDK.BmGame.RBMBehaviour TestBehaviour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRunningBehaviour, "BmGame.RBMAIController.IsRunningBehaviour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestBehaviour, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBehaviour;
    /// <summary>
    /// Function: GetBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour GetBehaviour(int Index = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBehaviour, "BmGame.RBMAIController.GetBehaviour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMBehaviour>(paramsPtr + 4);
    }

    /// <summary>
    /// Enum: CasualtyScreamReason
    /// </summary>
    public enum CasualtyScreamReason : byte
    {
        CSR_Generic = 0,
        CSR_Fell = 1,
        CSR_WallExplode = 2,
        CSR_ThroughWall = 3,
        CSR_FromGrate = 4,
        CSR_Shocked = 5,
        CSR_MAX = 6,
    }

    /// <summary>
    /// Enum: BRAECReactionType
    /// </summary>
    public enum BRAECReactionType : byte
    {
        BRAEC_Batarang = 0,
        BRAEC_SteerableBatarang = 1,
        BRAEC_ShockBatarang = 2,
        BRAEC_BreakingGlass = 3,
        BRAEC_Generator = 4,
        BRAEC_MAX = 5,
    }

    /// <summary>
    /// Enum: FOVcategory
    /// </summary>
    public enum FOVcategory : byte
    {
        FOV_None = 0,
        FOV_Peripheral = 1,
        FOV_Central = 2,
        FOV_MAX = 3,
    }

    /// <summary>
    /// Enum: BarkType
    /// </summary>
    public enum BarkType : byte
    {
        BARK_SPOTTED = 0,
        BARK_SPOTTEDCHASE = 1,
        BARK_POSTBATARANG = 2,
        BARK_WATCHBATARANG = 3,
        BARK_WATCHBATARANGEND = 4,
        BARK_CHASEBATMAN = 5,
        BARK_BATMANVANTAGEESCAPE = 6,
        BARK_BATMANVANTAGEESCAPEREPLY = 7,
        BARK_SCREAM = 8,
        BARK_GUNFIRE = 9,
        BARK_GUNRELOAD = 10,
        BARK_BATINVANTAGE = 11,
        BARK_BATINVENT = 12,
        BARK_PANICKING = 13,
        BARK_GUARDPANICKING = 14,
        BARK_LETMEDOWN = 15,
        BARK_MANDOWN_DISCOVER = 16,
        BARK_MANDOWN_CONSOLE = 17,
        BARK_MANDOWN_CONVERSE = 18,
        BARK_MANDOWN_DISPERSE = 19,
        BARK_MANUP_DISCOVER = 20,
        BARK_MANUP_CONSOLE = 21,
        BARK_MANUP_DISPERSE = 22,
        BARK_MANDOWN_REFUSE = 23,
        BARK_CHECKWALL_DISCOVER_FLOOR = 24,
        BARK_CHECKWALL_DISCOVER_WALL = 25,
        BARK_CHECKWALL_DISCOVER_CEILING = 26,
        BARK_CHECKWALL_DISCOVER_NEARMISS = 27,
        BARK_CHECKWALL_INVESTIGATE = 28,
        BARK_CHECKWALL_CONVERSE = 29,
        BARK_CHECKWALL_DISPERSE = 30,
        BARK_CALLBUDDY = 31,
        BARK_EXCLAIM = 32,
        BARK_CHECKSONICBATARANG = 33,
        BARK_WHATISITSONICBATARANG = 34,
        BARK_FOUNDSONICBATARANG = 35,
        BARK_IMPATIENTSONICBATARANG = 36,
        BARK_FOLLOWUPSONICBATARANG = 37,
        BARK_BATARANGNEARMISS = 38,
        BARK_POSTJOKERTANNOY = 39,
        BARK_STARTGUARD = 40,
        BARK_HANGTAKEDOWN = 41,
        BARK_STRUNGUP = 42,
        BARK_STRUNGABANDONED = 43,
        BARK_GUNSTARTLE_START = 44,
        BARK_GUNSTARTLE_END = 45,
        BARK_HEARDTAKEDOWN = 46,
        BARK_POSTTAKEDOWNTANNOY = 47,
        BARK_DEADENDCHECKED = 48,
        BARK_BATMANDEAD = 49,
        BARK_FLANK = 50,
        BARK_GRAPPLENOVANTAGE = 51,
        BARK_BMJUMPEDDOWN = 52,
        BARK_NERVOUSCHATSTART = 53,
        BARK_NERVOUSCHATREPLY = 54,
        BARK_LOSTBATMAN = 55,
        BARK_THROWGRENADE = 56,
        BARK_VENTGRENADE = 57,
        BARK_STARTGARGSMASH = 58,
        BARK_STARTGARGSMASHWITHHANGCAS = 59,
        BARK_DOINGGARGSMASH = 60,
        BARK_THERMALCHECK = 61,
        BARK_THERMALCHECKFAIL = 62,
        BARK_PLACEMINE = 63,
        BARK_MINEDISABLED = 64,
        BARK_TURNOFFBOOTH_FIRST = 65,
        BARK_TURNOFFBOOTH_REPEAT = 66,
        BARK_IGNOREBOOTH = 67,
        BARK_GRABHOSTAGE = 68,
        BARK_HOSTAGEMISSING_NOGROUP = 69,
        BARK_HOSTAGEMISSING_ONE = 70,
        BARK_HOSTAGEMISSING_TWO = 71,
        BARK_HOSTAGEMISSING_THREE = 72,
        BARK_LASTMANHOSTAGE = 73,
        BARK_HOSTAGECHATTER = 74,
        BARK_MANDOWN_ARMOURED_DISCOVER = 75,
        BARK_MANDOWN_ARMOURED_BRAG = 76,
        BARK_MANDOWN_ARMOURED_DISPERSE = 77,
        BARK_MANDOWN_REFUSE_ARMOURED = 78,
        BARK_MANDOWN_ARMOURED_MOCKTERRORTHUG = 79,
        BARK_MANDOWN_DISCOVER_KICK = 80,
        BARK_MANDOWN_KICKCAS = 81,
        BARK_LITEPREDCALM = 82,
        BARK_FIXJAMMER = 83,
        BARK_FIXMINE = 84,
        BARK_FIXGOGGLES = 85,
        BARK_HEARDJAMMEREXPLODE = 86,
        BARK_SAWTHUGFROMCORNER = 87,
        BARK_SAWTHUGFROMCORNERREPLY = 88,
        BARK_SEARCHLIGHTCOWER = 89,
        BARK_HOSTAGETAKERSEENGADGET = 90,
        BARK_TANNOYJAMFIRST = 91,
        BARK_TANNOYJAMREPEAT = 92,
        BARK_TANNOYJAMREPLY = 93,
        BARK_EXTINGUISHEREXPLODE_FIRST = 94,
        BARK_EXTINGUISHEREXPLODE_REPEAT = 95,
        BARK_CAUGHTINSMOKE = 96,
        BARK_SMOKEESCAPE = 97,
        BARK_SMOKEDISMISS = 98,
        BARK_SPOTFROZENTHUG = 99,
        BARK_RESCUEDFROMICE = 100,
        BARK_MINEEXPLODE = 101,
        BARK_MINEEXPLODECHECKED = 102,
        BARK_GUNJAM = 103,
        BARK_DRONESCANSTART = 104,
        BARK_DRONESCANNOTHREAT = 105,
        BARK_DRONESCANTHUGTHREAT = 106,
        BARK_DRONETAKEDOWN = 107,
        BARK_DRONEDESTROYEDBYTHUG = 108,
        BARK_DRONEACTIVEALERT = 109,
        BARK_DRONEALERTCANCELEDNOBATMAN = 110,
        BARK_DRONETARGETNEUTRALIZED = 111,
        BARK_DRONEENGAGEENEMYTARGET = 112,
        BARK_DRONESYSTEMFAILURE = 113,
        BARK_DRONEALERTCANCELED = 114,
        BARK_DRONEREBOOTING = 115,
        BARK_DRONESYSTEMONLINE = 116,
        BARK_DRONETARGETLOST = 117,
        BARK_STARTLED = 118,
        BARK_STARTLEDTAKEDOWNLCHOKE = 119,
        BARK_STARTLEDTAKEDOWNLEDGE = 120,
        BARK_STARTLEDTAKEDOWNREPLY = 121,
        BARK_DEADSHOTTAKENDOWN = 122,
        BARK_DEADSHOTLOSTSIGHT = 123,
        BARK_DEADSHOTLOSTSIGHT_GRAPPLE = 124,
        BARK_DEADSHOTSPOTBM = 125,
        BARK_DEADSHOTHITBYOBJECT = 126,
        BARK_DEADSHOTSHOOTINGBM = 127,
        BARK_DEADSHOTONFLOOR = 128,
        BARK_DEADSHOTHITBYSMOKE = 129,
        BARK_DEADSHOT_HEARSONICBATARANG = 130,
        BARK_DEADSHOT_STARTLEBYOJECT = 131,
        BARK_DEADSHOT_ORDERFINDBM = 132,
        BARK_DEADSHOT_EXTINGUISHER_FIRST = 133,
        BARK_DEADSHOT_EXTINGUISHER_SECOND = 134,
        BARK_DEADSHOT_WALLEXPLODE = 135,
        BARK_DEADSHOT_THUGHITREACTION = 136,
        BARK_NONE = 137,
        BARK_MAX = 138,
    }

    /// <summary>
    /// Enum: BatmanGrabType
    /// </summary>
    public enum BatmanGrabType : byte
    {
        BGT_NoGrab = 0,
        BGT_Grab = 1,
        BGT_FailedGrab = 2,
        BGT_MAX = 3,
    }

    /// <summary>
    /// Enum: PoseMirroredBehaviour
    /// </summary>
    public enum PoseMirroredBehaviour : byte
    {
        PMB_DontCare = 0,
        PMB_NotMirrored = 1,
        PMB_Mirrored = 2,
        PMB_MAX = 3,
    }

    /// <summary>
    /// ObjectProperty: PawnAI
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI PawnAI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: PawnVillain
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain PawnVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ObjectProperty: PawnCombat
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat PawnCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ArrayProperty: BehaviourList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour> BehaviourList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour>>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ArrayProperty: ExitConditionList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMExitCondition> ExitConditionList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMExitCondition>>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// BoolProperty: bDeactivatingBehaviour
    /// </summary>
    public unsafe bool bDeactivatingBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bRegistered
    /// </summary>
    public unsafe bool bRegistered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bHasHadBehaviour
    /// </summary>
    public unsafe bool bHasHadBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bInCombat
    /// </summary>
    public unsafe bool bInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bWeaponChanged
    /// </summary>
    public unsafe bool bWeaponChanged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bHadCombatBehaviour
    /// </summary>
    public unsafe bool bHadCombatBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bUseCombatAreas
    /// </summary>
    public unsafe bool bUseCombatAreas
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bStoreIdleConfig
    /// </summary>
    public unsafe bool bStoreIdleConfig
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bFinalBlowFaceFX
    /// </summary>
    public unsafe bool bFinalBlowFaceFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bCachedSeenSeqEvents
    /// </summary>
    public unsafe bool bCachedSeenSeqEvents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bPlayedEnterCombatSound
    /// </summary>
    public unsafe bool bPlayedEnterCombatSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bBehaviourControlledTick
    /// </summary>
    public unsafe bool bBehaviourControlledTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bCachedIsStunned
    /// </summary>
    public unsafe bool bCachedIsStunned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bVisionIsBlocked
    /// </summary>
    public unsafe bool bVisionIsBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bDeliberateLookAway
    /// </summary>
    public unsafe bool bDeliberateLookAway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bStunnedRagdoll
    /// </summary>
    public unsafe bool bStunnedRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bLookedAtPlayer
    /// </summary>
    public unsafe bool bLookedAtPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bUseHeadBoneAsViewDir
    /// </summary>
    public unsafe bool bUseHeadBoneAsViewDir
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bForceShortenPathCheck
    /// </summary>
    public unsafe bool bForceShortenPathCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bBehaviourCustomEyeLocation
    /// </summary>
    public unsafe bool bBehaviourCustomEyeLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bBumpedLastPawnMoveTick
    /// </summary>
    public unsafe bool bBumpedLastPawnMoveTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bHaveCachedAnimatedAimDir
    /// </summary>
    public unsafe bool bHaveCachedAnimatedAimDir
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bBehaviourIsRunningAEC
    /// </summary>
    public unsafe bool bBehaviourIsRunningAEC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// IntProperty: TriggerActivationEventFrames
    /// </summary>
    public unsafe int TriggerActivationEventFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ClassProperty: DefaultBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class DefaultBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ObjectProperty: CombatBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_Combat CombatBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_Combat>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ObjectProperty: mCombatArea
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatArea mCombatArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatArea>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ObjectProperty: StoredIdleConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour StoredIdleConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ArrayProperty: SeenSeqEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceObject> SeenSeqEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceObject>>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceActivatedSeenEvents
    /// </summary>
    public unsafe float TimeSinceActivatedSeenEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: CachedPlayerAlert
    /// </summary>
    public unsafe BmSDK.BmGame.AlertInstance CachedPlayerAlert
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.AlertInstance>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ObjectProperty: InterruptingBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour InterruptingBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: SuspectLimit
    /// </summary>
    public unsafe float SuspectLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: SpottedLimit
    /// </summary>
    public unsafe float SpottedLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: MinCanSeePercent
    /// </summary>
    public unsafe float MinCanSeePercent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// FloatProperty: SimpleFOVCheckRange
    /// </summary>
    public unsafe float SimpleFOVCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// FloatProperty: Attack360AwarenessRange
    /// </summary>
    public unsafe float Attack360AwarenessRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ArrayProperty: CurrentAlert
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.AlertInstance> CurrentAlert
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.AlertInstance>>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: AlertPriorityTime
    /// </summary>
    public unsafe float AlertPriorityTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: LastBarkTime
    /// </summary>
    public unsafe float LastBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// IntProperty: LastBarkPriority
    /// </summary>
    public unsafe int LastBarkPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ArrayProperty: NeighbourList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIController> NeighbourList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIController>>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// FloatProperty: LookAtPlayerTime
    /// </summary>
    public unsafe float LookAtPlayerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: LookAtPlayerDistance
    /// </summary>
    public unsafe float LookAtPlayerDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: LastSearchInvestigateMoveTime
    /// </summary>
    public unsafe float LastSearchInvestigateMoveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// NameProperty: HeadBone
    /// </summary>
    public unsafe BmSDK.FName HeadBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// NameProperty: NervousIdleVariantName
    /// </summary>
    public unsafe BmSDK.FName NervousIdleVariantName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ObjectProperty: SpecialWatchVPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint SpecialWatchVPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// NameProperty: NoStateName
    /// </summary>
    public unsafe BmSDK.FName NoStateName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: BumpedTimer
    /// </summary>
    public unsafe float BumpedTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// StructProperty: CachedAnimatedAimDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CachedAnimatedAimDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1068);

    /// <summary>
    /// FloatProperty: LastCheckUnconsciousThugTime
    /// </summary>
    public unsafe float LastCheckUnconsciousThugTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: PredQueue
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_ActionQueue PredQueue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_ActionQueue>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: CurrentEvent
    /// </summary>
    public unsafe BmSDK.BmGame.RAlertEventCoordinatorBase CurrentEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlertEventCoordinatorBase>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// IntProperty: CurrentPriority
    /// </summary>
    public unsafe int CurrentPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ObjectProperty: AIManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIManager AIManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIManager>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ObjectProperty: mTopBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour mTopBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }
}
