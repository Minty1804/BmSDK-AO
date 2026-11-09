#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Attack_Chase<br/>
/// (size = 592)
/// (flags = 8388626)
/// </summary>
public partial class RAEC_Attack_Chase : BmSDK.BmGame.RAEC_SubGroup, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Attack_Chase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_Attack_Chase.
    /// </summary>
    public static RAEC_Attack_Chase DefaultObject => (RAEC_Attack_Chase)StaticClass().DefaultObject;

    internal RAEC_Attack_Chase() { }

    /// <summary>
    /// Constructs a new RAEC_Attack_Chase
    /// </summary>
    public RAEC_Attack_Chase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Attack_Chase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Chase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Chase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Chase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Chase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Chase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Chase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Chase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Chase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetFenceNodeLockFor;
    /// <summary>
    /// Function: GetFenceNodeLockFor
    /// </summary>
    public unsafe virtual bool GetFenceNodeLockFor(BmSDK.BmGame.RBMAIController TestCon, BmSDK.BmGame.RBMPathNode_FenceJumpProxy TargetNode, System.Numerics.Vector3 LockPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFenceNodeLockFor, "BmGame.RAEC_Attack_Chase.GetFenceNodeLockFor");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestCon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetNode, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LockPos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_DoChaseInProgressBark;
    /// <summary>
    /// Function: DoChaseInProgressBark
    /// </summary>
    public unsafe virtual void DoChaseInProgressBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoChaseInProgressBark, "BmGame.RAEC_Attack_Chase.DoChaseInProgressBark");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopDistantRunners;
    /// <summary>
    /// Function: StopDistantRunners
    /// </summary>
    public unsafe virtual void StopDistantRunners()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopDistantRunners, "BmGame.RAEC_Attack_Chase.StopDistantRunners");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropPriorityDueToVantageEscape;
    /// <summary>
    /// Function: DropPriorityDueToVantageEscape
    /// </summary>
    public unsafe virtual void DropPriorityDueToVantageEscape()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropPriorityDueToVantageEscape, "BmGame.RAEC_Attack_Chase.DropPriorityDueToVantageEscape");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateSmokeAEC;
    /// <summary>
    /// Function: CreateSmokeAEC
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAEC_Attack_Smoke CreateSmokeAEC(BmSDK.BmGame.RSmokeScreen NewSmokeScreen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateSmokeAEC, "BmGame.RAEC_Attack_Chase.CreateSmokeAEC");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSmokeScreen, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAEC_Attack_Smoke>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AreOtherPawnsInRadius;
    /// <summary>
    /// Function: AreOtherPawnsInRadius
    /// </summary>
    public unsafe virtual bool AreOtherPawnsInRadius(System.Numerics.Vector3 ExplodePoint, float ExplodeRadius)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreOtherPawnsInRadius, "BmGame.RAEC_Attack_Chase.AreOtherPawnsInRadius");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExplodePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExplodeRadius, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsSafeToThrowGrenade;
    /// <summary>
    /// Function: IsSafeToThrowGrenade
    /// </summary>
    public unsafe virtual bool IsSafeToThrowGrenade(float ShortestDistToRunToTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSafeToThrowGrenade, "BmGame.RAEC_Attack_Chase.IsSafeToThrowGrenade");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShortestDistToRunToTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TryAssignVentThrower;
    /// <summary>
    /// Function: TryAssignVentThrower
    /// </summary>
    public unsafe virtual bool TryAssignVentThrower(out System.Numerics.Vector3 NewChasePos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryAssignVentThrower, "BmGame.RAEC_Attack_Chase.TryAssignVentThrower");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewChasePos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewChasePos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NewChasePos = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FindTunnelFunnelToGrenade;
    /// <summary>
    /// Function: FindTunnelFunnelToGrenade
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RTunnelFunnel FindTunnelFunnelToGrenade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindTunnelFunnelToGrenade, "BmGame.RAEC_Attack_Chase.FindTunnelFunnelToGrenade");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RTunnelFunnel>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryGrenadeThrow;
    /// <summary>
    /// Function: TryGrenadeThrow
    /// </summary>
    public unsafe virtual bool TryGrenadeThrow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryGrenadeThrow, "BmGame.RAEC_Attack_Chase.TryGrenadeThrow");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitThugEdgeSearch;
    /// <summary>
    /// Function: InitThugEdgeSearch
    /// </summary>
    public unsafe virtual void InitThugEdgeSearch(int TS_j)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitThugEdgeSearch, "BmGame.RAEC_Attack_Chase.InitThugEdgeSearch");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TS_j, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitEdgeSearchMultiNavHandleWrapper;
    /// <summary>
    /// Function: InitEdgeSearchMultiNavHandleWrapper
    /// </summary>
    public unsafe virtual void InitEdgeSearchMultiNavHandleWrapper()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitEdgeSearchMultiNavHandleWrapper, "BmGame.RAEC_Attack_Chase.InitEdgeSearchMultiNavHandleWrapper");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostLadderChaseAssign;
    /// <summary>
    /// Function: PostLadderChaseAssign
    /// </summary>
    public unsafe virtual void PostLadderChaseAssign(BmSDK.BmGame.RBMAIController C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostLadderChaseAssign, "BmGame.RAEC_Attack_Chase.PostLadderChaseAssign");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBestPushPastRootChild;
    /// <summary>
    /// Function: GetBestPushPastRootChild
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RChasePoint GetBestPushPastRootChild(BmSDK.BmGame.RChasePoint TestChasePoint, float TargetDepth, float DepthSoFar)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestPushPastRootChild, "BmGame.RAEC_Attack_Chase.GetBestPushPastRootChild");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestChasePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDepth, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DepthSoFar, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RChasePoint>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_MarkAssigned;
    /// <summary>
    /// Function: MarkAssigned
    /// </summary>
    public unsafe virtual void MarkAssigned(BmSDK.BmGame.RChasePoint LatestChildChasePoint, BmSDK.BmGame.RChasePoint AlreadyDoneChasePoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MarkAssigned, "BmGame.RAEC_Attack_Chase.MarkAssigned");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LatestChildChasePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlreadyDoneChasePoint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitChaser;
    /// <summary>
    /// Function: InitChaser
    /// </summary>
    public unsafe virtual void InitChaser(BmSDK.BmGame.RBMAIController C, bool bForceThroughChaseRoot = default, float RootDist = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitChaser, "BmGame.RAEC_Attack_Chase.InitChaser");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceThroughChaseRoot, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RootDist, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearChaseSearch;
    /// <summary>
    /// Function: ClearChaseSearch
    /// </summary>
    public unsafe virtual void ClearChaseSearch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearChaseSearch, "BmGame.RAEC_Attack_Chase.ClearChaseSearch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearThugEdgeRequests;
    /// <summary>
    /// Function: ClearThugEdgeRequests
    /// </summary>
    public unsafe virtual void ClearThugEdgeRequests()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearThugEdgeRequests, "BmGame.RAEC_Attack_Chase.ClearThugEdgeRequests");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearEdgeSearch;
    /// <summary>
    /// Function: ClearEdgeSearch
    /// </summary>
    public unsafe virtual void ClearEdgeSearch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearEdgeSearch, "BmGame.RAEC_Attack_Chase.ClearEdgeSearch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearGrenVentRequests;
    /// <summary>
    /// Function: ClearGrenVentRequests
    /// </summary>
    public unsafe virtual void ClearGrenVentRequests()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGrenVentRequests, "BmGame.RAEC_Attack_Chase.ClearGrenVentRequests");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearChaseRootRequests;
    /// <summary>
    /// Function: ClearChaseRootRequests
    /// </summary>
    public unsafe virtual void ClearChaseRootRequests()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearChaseRootRequests, "BmGame.RAEC_Attack_Chase.ClearChaseRootRequests");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAllNavRequests;
    /// <summary>
    /// Function: ClearAllNavRequests
    /// </summary>
    public unsafe virtual void ClearAllNavRequests()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAllNavRequests, "BmGame.RAEC_Attack_Chase.ClearAllNavRequests");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishChaseFor;
    /// <summary>
    /// Function: FinishChaseFor
    /// </summary>
    public unsafe virtual void FinishChaseFor(BmSDK.BmGame.RAEC_Attack_Sub_Chase FinishedSub)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishChaseFor, "BmGame.RAEC_Attack_Chase.FinishChaseFor");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedSub, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindInterceptMeetFollowerChasePoint;
    /// <summary>
    /// Function: FindInterceptMeetFollowerChasePoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RChasePoint FindInterceptMeetFollowerChasePoint(BmSDK.BmGame.RChasePoint TestCP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindInterceptMeetFollowerChasePoint, "BmGame.RAEC_Attack_Chase.FindInterceptMeetFollowerChasePoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestCP, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RChasePoint>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FindBestChildChasePoint;
    /// <summary>
    /// Function: FindBestChildChasePoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RChasePoint FindBestChildChasePoint(BmSDK.BmGame.RAEC_Attack_Sub_Chase Arrivee, BmSDK.BmGame.RChasePoint TestCP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindBestChildChasePoint, "BmGame.RAEC_Attack_Chase.FindBestChildChasePoint");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Arrivee, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestCP, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RChasePoint>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetScoreForBranchPoint;
    /// <summary>
    /// Function: GetScoreForBranchPoint
    /// </summary>
    public unsafe virtual float GetScoreForBranchPoint(BmSDK.BmGame.RAEC_Attack_Sub_Chase Arrivee, BmSDK.BmGame.RChasePoint TestCP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForBranchPoint, "BmGame.RAEC_Attack_Chase.GetScoreForBranchPoint");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Arrivee, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestCP, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetNextChasePointFor;
    /// <summary>
    /// Function: GetNextChasePointFor
    /// </summary>
    public unsafe virtual bool GetNextChasePointFor(BmSDK.BmGame.RAEC_Attack_Sub_Chase Arrivee, out BmSDK.BmGame.RChasePoint NextChasePoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextChasePointFor, "BmGame.RAEC_Attack_Chase.GetNextChasePointFor");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Arrivee, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NextChasePoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextChasePoint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NextChasePoint = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RChasePoint>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_InitUnreachableChaseHandling;
    /// <summary>
    /// Function: InitUnreachableChaseHandling
    /// </summary>
    public unsafe virtual void InitUnreachableChaseHandling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitUnreachableChaseHandling, "BmGame.RAEC_Attack_Chase.InitUnreachableChaseHandling");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CullBranchesHeadingAwayFromPlayer;
    /// <summary>
    /// Function: CullBranchesHeadingAwayFromPlayer
    /// </summary>
    public unsafe virtual void CullBranchesHeadingAwayFromPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CullBranchesHeadingAwayFromPlayer, "BmGame.RAEC_Attack_Chase.CullBranchesHeadingAwayFromPlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChaseSearchFailed;
    /// <summary>
    /// Function: ChaseSearchFailed
    /// </summary>
    public unsafe virtual void ChaseSearchFailed(BmSDK.BmGame.RChaseLocationSearch CompletedSearch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChaseSearchFailed, "BmGame.RAEC_Attack_Chase.ChaseSearchFailed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompletedSearch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChaseSearchDone;
    /// <summary>
    /// Function: ChaseSearchDone
    /// </summary>
    public unsafe virtual void ChaseSearchDone(BmSDK.BmGame.RChaseLocationSearch CompletedSearch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChaseSearchDone, "BmGame.RAEC_Attack_Chase.ChaseSearchDone");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompletedSearch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChaseFailAlert;
    /// <summary>
    /// Function: ChaseFailAlert
    /// </summary>
    public unsafe virtual void ChaseFailAlert()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChaseFailAlert, "BmGame.RAEC_Attack_Chase.ChaseFailAlert");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitVentPathSearch;
    /// <summary>
    /// Function: InitVentPathSearch
    /// </summary>
    public unsafe virtual void InitVentPathSearch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitVentPathSearch, "BmGame.RAEC_Attack_Chase.InitVentPathSearch");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitChaseRootSearch;
    /// <summary>
    /// Function: InitChaseRootSearch
    /// </summary>
    public unsafe virtual void InitChaseRootSearch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitChaseRootSearch, "BmGame.RAEC_Attack_Chase.InitChaseRootSearch");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindOverLookFences;
    /// <summary>
    /// Function: FindOverLookFences
    /// </summary>
    public unsafe virtual void FindOverLookFences(System.Numerics.Vector3 EstimatedPlayerPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindOverLookFences, "BmGame.RAEC_Attack_Chase.FindOverLookFences");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EstimatedPlayerPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitEdgeWatchFinder;
    /// <summary>
    /// Function: InitEdgeWatchFinder
    /// </summary>
    public unsafe virtual void InitEdgeWatchFinder()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitEdgeWatchFinder, "BmGame.RAEC_Attack_Chase.InitEdgeWatchFinder");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitChaseTreeFinder;
    /// <summary>
    /// Function: InitChaseTreeFinder
    /// </summary>
    public unsafe virtual void InitChaseTreeFinder(BmSDK.BmGame.RLadder DangerLadder = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitChaseTreeFinder, "BmGame.RAEC_Attack_Chase.InitChaseTreeFinder");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DangerLadder, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDangerLadder;
    /// <summary>
    /// Function: GetDangerLadder
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RLadder GetDangerLadder()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDangerLadder, "BmGame.RAEC_Attack_Chase.GetDangerLadder");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RLadder>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitCeilingWatchAndWait;
    /// <summary>
    /// Function: InitCeilingWatchAndWait
    /// </summary>
    public unsafe virtual void InitCeilingWatchAndWait()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitCeilingWatchAndWait, "BmGame.RAEC_Attack_Chase.InitCeilingWatchAndWait");
        byte* paramsPtr = stackalloc byte[28];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepChase, "BmGame.RAEC_Attack_Chase.PrepChase");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryDrawChaseState;
    /// <summary>
    /// Function: TryDrawChaseState
    /// </summary>
    public unsafe virtual void TryDrawChaseState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryDrawChaseState, "BmGame.RAEC_Attack_Chase.TryDrawChaseState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFinished;
    /// <summary>
    /// Function: NotifyFinished
    /// </summary>
    public unsafe override void NotifyFinished(BmSDK.BmGame.RBMAIController FinishedCon, BmSDK.BmGame.RBMAIAction FinishedAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFinished, "BmGame.RAEC_Attack_Chase.NotifyFinished");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedCon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedAction, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainStolen, "BmGame.RAEC_Attack_Chase.VillainStolen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stolen, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmGame.RAEC_Attack_Chase.GetThoughts");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AreAttackersActive;
    /// <summary>
    /// Function: AreAttackersActive
    /// </summary>
    public unsafe virtual bool AreAttackersActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreAttackersActive, "BmGame.RAEC_Attack_Chase.AreAttackersActive");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveChild;
    /// <summary>
    /// Function: RemoveChild
    /// </summary>
    public unsafe override void RemoveChild(BmSDK.BmGame.RAlertEventCoordinatorBase RemAEC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveChild, "BmGame.RAEC_Attack_Chase.RemoveChild");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RAEC_Attack_Chase.PreStreamOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTargetPlayer;
    /// <summary>
    /// Function: SetTargetPlayer
    /// </summary>
    public unsafe virtual void SetTargetPlayer(BmSDK.BmGame.RPawnPlayer NewTargetPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTargetPlayer, "BmGame.RAEC_Attack_Chase.SetTargetPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTargetPlayer, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RAEC_Attack_Chase.PostBeginPlay");
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
    /// BoolProperty: bChasingFromSighting
    /// </summary>
    public unsafe bool bChasingFromSighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bChaseTreeReady
    /// </summary>
    public unsafe bool bChaseTreeReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bChaseTreeGood
    /// </summary>
    public unsafe bool bChaseTreeGood
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bChaseAfterGrenade
    /// </summary>
    public unsafe bool bChaseAfterGrenade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// ObjectProperty: ChaseLocSearch
    /// </summary>
    public unsafe BmSDK.BmGame.RChaseLocationSearch ChaseLocSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChaseLocationSearch>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// StructProperty: LastChaseStart
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastChaseStart
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 492);

    /// <summary>
    /// ArrayProperty: ChaseRootRequest
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle> ChaseRootRequest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle>>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ObjectProperty: VentGrenadeTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelFunnel VentGrenadeTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelFunnel>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// ArrayProperty: GrenVentSearch
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper> GrenVentSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper>>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ObjectProperty: GrenadeCon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController GrenadeCon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ArrayProperty: OverLookFence
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPathNode_FenceJumpProxy> OverLookFence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPathNode_FenceJumpProxy>>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ArrayProperty: OverLookFencePos
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> OverLookFencePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSearch
    /// </summary>
    public unsafe BmSDK.BmGame.RAttackEdgeSearch EdgeSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAttackEdgeSearch>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// IntProperty: ThugEdgeSearchIndex
    /// </summary>
    public unsafe int ThugEdgeSearchIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ArrayProperty: ThugEdgeSearch
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper> ThugEdgeSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper>>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ObjectProperty: AEC_WatchAndWait
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_WatchAndWait AEC_WatchAndWait
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_WatchAndWait>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ObjectProperty: AEC_LadderChase
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_LadderChase AEC_LadderChase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_LadderChase>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// FloatProperty: LastChaseEndTime
    /// </summary>
    public unsafe float LastChaseEndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }
}
