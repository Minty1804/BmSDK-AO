#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavigationHandle<br/>
/// (size = 832)
/// (flags = 134217874)
/// </summary>
public partial class RNavigationHandle : BmSDK.Engine.NavigationHandle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RNavigationHandle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RNavigationHandle.
    /// </summary>
    public static RNavigationHandle DefaultObject => (RNavigationHandle)StaticClass().DefaultObject;

    internal RNavigationHandle() { }

    /// <summary>
    /// Constructs a new RNavigationHandle
    /// </summary>
    public RNavigationHandle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNavigationHandle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavigationHandle(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavigationHandle>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CacheStartStateForDebug;
    /// <summary>
    /// Function: CacheStartStateForDebug
    /// </summary>
    public unsafe virtual void CacheStartStateForDebug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheStartStateForDebug, "BmGame.RNavigationHandle.CacheStartStateForDebug");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThoughtString;
    /// <summary>
    /// Function: GetThoughtString
    /// </summary>
    public unsafe virtual BmSDK.FString GetThoughtString(bool bMaxVerbosity = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughtString, "BmGame.RNavigationHandle.GetThoughtString");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMaxVerbosity, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsEmpty;
    /// <summary>
    /// Function: IsEmpty
    /// </summary>
    public unsafe virtual bool IsEmpty()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsEmpty, "BmGame.RNavigationHandle.IsEmpty");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FollowPath;
    /// <summary>
    /// Function: FollowPath
    /// </summary>
    public unsafe virtual void FollowPath()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FollowPath, "BmGame.RNavigationHandle.FollowPath");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindPathToPoint;
    /// <summary>
    /// Function: FindPathToPoint
    /// </summary>
    public unsafe virtual void FindPathToPoint(System.Numerics.Vector3 NewDestPoint, int Priority = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPathToPoint, "BmGame.RNavigationHandle.FindPathToPoint");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDestPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindPathToActor;
    /// <summary>
    /// Function: FindPathToActor
    /// </summary>
    public unsafe virtual void FindPathToActor(BmSDK.Engine.Actor NewDestActor, int Priority = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPathToActor, "BmGame.RNavigationHandle.FindPathToActor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDestActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateAvoidPathObjectsConstraints;
    /// <summary>
    /// Function: CreateAvoidPathObjectsConstraints
    /// </summary>
    public unsafe void CreateAvoidPathObjectsConstraints()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateAvoidPathObjectsConstraints, "BmGame.RNavigationHandle.CreateAvoidPathObjectsConstraints");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateAvoidBlockedPolysConstraints;
    /// <summary>
    /// Function: CreateAvoidBlockedPolysConstraints
    /// </summary>
    public unsafe void CreateAvoidBlockedPolysConstraints()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateAvoidBlockedPolysConstraints, "BmGame.RNavigationHandle.CreateAvoidBlockedPolysConstraints");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateAvoidBlockedEdgesConstraints;
    /// <summary>
    /// Function: CreateAvoidBlockedEdgesConstraints
    /// </summary>
    public unsafe void CreateAvoidBlockedEdgesConstraints()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateAvoidBlockedEdgesConstraints, "BmGame.RNavigationHandle.CreateAvoidBlockedEdgesConstraints");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateAvoidDoublingBackConstraints;
    /// <summary>
    /// Function: CreateAvoidDoublingBackConstraints
    /// </summary>
    public unsafe void CreateAvoidDoublingBackConstraints()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateAvoidDoublingBackConstraints, "BmGame.RNavigationHandle.CreateAvoidDoublingBackConstraints");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateAvoidPlayersConstraints;
    /// <summary>
    /// Function: CreateAvoidPlayersConstraints
    /// </summary>
    public unsafe void CreateAvoidPlayersConstraints()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateAvoidPlayersConstraints, "BmGame.RNavigationHandle.CreateAvoidPlayersConstraints");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreatePathToSafetyContraints;
    /// <summary>
    /// Function: CreatePathToSafetyContraints
    /// </summary>
    public unsafe void CreatePathToSafetyContraints()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePathToSafetyContraints, "BmGame.RNavigationHandle.CreatePathToSafetyContraints");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreatePathToActorConstraints;
    /// <summary>
    /// Function: CreatePathToActorConstraints
    /// </summary>
    public unsafe void CreatePathToActorConstraints(BmSDK.Engine.Actor destActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePathToActorConstraints, "BmGame.RNavigationHandle.CreatePathToActorConstraints");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(destActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreatePathToPointConstraints;
    /// <summary>
    /// Function: CreatePathToPointConstraints
    /// </summary>
    public unsafe void CreatePathToPointConstraints(System.Numerics.Vector3 DestPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePathToPointConstraints, "BmGame.RNavigationHandle.CreatePathToPointConstraints");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableForcedPathShortening;
    /// <summary>
    /// Function: DisableForcedPathShortening
    /// </summary>
    public unsafe virtual void DisableForcedPathShortening()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableForcedPathShortening, "BmGame.RNavigationHandle.DisableForcedPathShortening");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceInstantPathShortening;
    /// <summary>
    /// Function: ForceInstantPathShortening
    /// </summary>
    public unsafe virtual void ForceInstantPathShortening(int ShortenAttempts = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceInstantPathShortening, "BmGame.RNavigationHandle.ForceInstantPathShortening");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShortenAttempts, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetUseCheapSupportCheck;
    /// <summary>
    /// Function: SetUseCheapSupportCheck
    /// </summary>
    public unsafe virtual void SetUseCheapSupportCheck(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetUseCheapSupportCheck, "BmGame.RNavigationHandle.SetUseCheapSupportCheck");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCanDoPathShortening;
    /// <summary>
    /// Function: SetCanDoPathShortening
    /// </summary>
    public unsafe virtual void SetCanDoPathShortening(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCanDoPathShortening, "BmGame.RNavigationHandle.SetCanDoPathShortening");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTraversal;
    /// <summary>
    /// Function: SetTraversal
    /// </summary>
    public unsafe virtual void SetTraversal(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTraversal, "BmGame.RNavigationHandle.SetTraversal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCanClimbHigh;
    /// <summary>
    /// Function: SetCanClimbHigh
    /// </summary>
    public unsafe virtual void SetCanClimbHigh(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCanClimbHigh, "BmGame.RNavigationHandle.SetCanClimbHigh");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetUseLadders;
    /// <summary>
    /// Function: SetUseLadders
    /// </summary>
    public unsafe virtual void SetUseLadders(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetUseLadders, "BmGame.RNavigationHandle.SetUseLadders");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGoal_Safety;
    /// <summary>
    /// Function: SetGoal_Safety
    /// </summary>
    public unsafe virtual void SetGoal_Safety()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoal_Safety, "BmGame.RNavigationHandle.SetGoal_Safety");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGoal_PathToActor;
    /// <summary>
    /// Function: SetGoal_PathToActor
    /// </summary>
    public unsafe virtual void SetGoal_PathToActor(BmSDK.Engine.Actor destActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoal_PathToActor, "BmGame.RNavigationHandle.SetGoal_PathToActor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(destActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGoal_AdditionalPathToPoint;
    /// <summary>
    /// Function: SetGoal_AdditionalPathToPoint
    /// </summary>
    public unsafe virtual void SetGoal_AdditionalPathToPoint(System.Numerics.Vector3 DestPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoal_AdditionalPathToPoint, "BmGame.RNavigationHandle.SetGoal_AdditionalPathToPoint");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGoal_PathToPoint;
    /// <summary>
    /// Function: SetGoal_PathToPoint
    /// </summary>
    public unsafe virtual void SetGoal_PathToPoint(System.Numerics.Vector3 DestPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoal_PathToPoint, "BmGame.RNavigationHandle.SetGoal_PathToPoint");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetConstraint_AvoidPathObject;
    /// <summary>
    /// Function: SetConstraint_AvoidPathObject
    /// </summary>
    public unsafe virtual void SetConstraint_AvoidPathObject(BmSDK.Engine.Actor PathObjectToAvoid)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetConstraint_AvoidPathObject, "BmGame.RNavigationHandle.SetConstraint_AvoidPathObject");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathObjectToAvoid, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetConstraint_AvoidDoublingBack;
    /// <summary>
    /// Function: SetConstraint_AvoidDoublingBack
    /// </summary>
    public unsafe virtual void SetConstraint_AvoidDoublingBack(float Strength, float Distance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetConstraint_AvoidDoublingBack, "BmGame.RNavigationHandle.SetConstraint_AvoidDoublingBack");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Distance, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetConstraint_AvoidPlayers;
    /// <summary>
    /// Function: SetConstraint_AvoidPlayers
    /// </summary>
    public unsafe virtual void SetConstraint_AvoidPlayers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetConstraint_AvoidPlayers, "BmGame.RNavigationHandle.SetConstraint_AvoidPlayers");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAdditionalSearch;
    /// <summary>
    /// Function: StartAdditionalSearch
    /// </summary>
    public unsafe virtual void StartAdditionalSearch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAdditionalSearch, "BmGame.RNavigationHandle.StartAdditionalSearch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSearch;
    /// <summary>
    /// Function: StartSearch
    /// </summary>
    public unsafe virtual void StartSearch(int Priority = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSearch, "BmGame.RNavigationHandle.StartSearch");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepareForSearch;
    /// <summary>
    /// Function: PrepareForSearch
    /// </summary>
    public unsafe virtual void PrepareForSearch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepareForSearch, "BmGame.RNavigationHandle.PrepareForSearch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPathFindParameters;
    /// <summary>
    /// Function: ClearPathFindParameters
    /// </summary>
    public unsafe void ClearPathFindParameters()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPathFindParameters, "BmGame.RNavigationHandle.ClearPathFindParameters");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreatePathGoalEvaluator;
    /// <summary>
    /// Function: CreatePathGoalEvaluator
    /// </summary>
    public unsafe override BmSDK.Engine.NavMeshPathGoalEvaluator CreatePathGoalEvaluator(BmSDK.Class GoalEvalClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePathGoalEvaluator, "BmGame.RNavigationHandle.CreatePathGoalEvaluator");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoalEvalClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.NavMeshPathGoalEvaluator>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CreatePathConstraint;
    /// <summary>
    /// Function: CreatePathConstraint
    /// </summary>
    public unsafe override BmSDK.Engine.NavMeshPathConstraint CreatePathConstraint(BmSDK.Class ConstraintClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePathConstraint, "BmGame.RNavigationHandle.CreatePathConstraint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConstraintClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.NavMeshPathConstraint>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Release;
    /// <summary>
    /// Function: Release
    /// </summary>
    public unsafe virtual void Release()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Release, "BmGame.RNavigationHandle.Release");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Claim;
    /// <summary>
    /// Function: Claim
    /// </summary>
    public unsafe virtual void Claim(BmSDK.FName NewClaimName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Claim, "BmGame.RNavigationHandle.Claim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewClaimName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_Deactivate;
    /// <summary>
    /// Function: Deactivate
    /// </summary>
    public unsafe virtual void Deactivate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Deactivate, "BmGame.RNavigationHandle.Deactivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleDebugCamera;
    /// <summary>
    /// Function: ToggleDebugCamera
    /// </summary>
    public unsafe virtual void ToggleDebugCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleDebugCamera, "BmGame.RNavigationHandle.ToggleDebugCamera");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe virtual void Initialise(BmSDK.Engine.Actor NewActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.RNavigationHandle.Initialise");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetReachableLocation;
    /// <summary>
    /// Function: GetReachableLocation
    /// </summary>
    public unsafe static bool GetReachableLocation(System.Numerics.Vector3 NearLocation, out System.Numerics.Vector3 ReachableLocation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetReachableLocation, "BmGame.RNavigationHandle.GetReachableLocation");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NearLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ReachableLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReachableLocation, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ReachableLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_SetBlockedPolyList;
    /// <summary>
    /// Function: SetBlockedPolyList
    /// </summary>
    public unsafe virtual void SetBlockedPolyList(BmSDK.Engine.Pylon ThisPylon, BmSDK.TArray<int> NewBlockedPolyList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBlockedPolyList, "BmGame.RNavigationHandle.SetBlockedPolyList");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThisPylon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBlockedPolyList, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetPylonAndVisibleVertsFromPos;
    /// <summary>
    /// Function: GetPylonAndVisibleVertsFromPos
    /// </summary>
    public unsafe static void GetPylonAndVisibleVertsFromPos(System.Numerics.Vector3 TestPos, out BmSDK.Engine.Pylon BasePylon, out BmSDK.TArray<int> VertIDList)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPylonAndVisibleVertsFromPos, "BmGame.RNavigationHandle.GetPylonAndVisibleVertsFromPos");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BasePylon);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BasePylon, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BasePylon = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Pylon>(paramsPtr + 12);
        VertIDList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_GetPathForNextXDist;
    /// <summary>
    /// Function: GetPathForNextXDist
    /// </summary>
    public unsafe virtual void GetPathForNextXDist(float LookAheadDist, System.Numerics.Vector3 TestExtents, out BmSDK.TArray<System.Numerics.Vector3> PathPoints, out int bHitSpecialMoveEdge)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPathForNextXDist, "BmGame.RNavigationHandle.GetPathForNextXDist");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAheadDist, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestExtents, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bHitSpecialMoveEdge);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHitSpecialMoveEdge, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PathPoints = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 16);
        bHitSpecialMoveEdge = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 28);
        return;
    }

    private static BmSDK.Function __fn_DrawBlockedEdges;
    /// <summary>
    /// Function: DrawBlockedEdges
    /// </summary>
    public unsafe virtual void DrawBlockedEdges()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawBlockedEdges, "BmGame.RNavigationHandle.DrawBlockedEdges");
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

    private static BmSDK.Function __fn_ClearBlockedPathLists;
    /// <summary>
    /// Function: ClearBlockedPathLists
    /// </summary>
    public unsafe virtual void ClearBlockedPathLists()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearBlockedPathLists, "BmGame.RNavigationHandle.ClearBlockedPathLists");
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

    private static BmSDK.Function __fn_CopyStoredPathCacheIntoPathCache;
    /// <summary>
    /// Function: CopyStoredPathCacheIntoPathCache
    /// </summary>
    public unsafe virtual void CopyStoredPathCacheIntoPathCache()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CopyStoredPathCacheIntoPathCache, "BmGame.RNavigationHandle.CopyStoredPathCacheIntoPathCache");
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

    private static BmSDK.Function __fn_AppendPathCacheToStoredPathCache;
    /// <summary>
    /// Function: AppendPathCacheToStoredPathCache
    /// </summary>
    public unsafe virtual void AppendPathCacheToStoredPathCache()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AppendPathCacheToStoredPathCache, "BmGame.RNavigationHandle.AppendPathCacheToStoredPathCache");
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

    private static BmSDK.Function __fn_StoredPathCache_Empty;
    /// <summary>
    /// Function: StoredPathCache_Empty
    /// </summary>
    public unsafe virtual void StoredPathCache_Empty()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoredPathCache_Empty, "BmGame.RNavigationHandle.StoredPathCache_Empty");
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

    private static BmSDK.Function __fn_ShowPathDebug;
    /// <summary>
    /// Function: ShowPathDebug
    /// </summary>
    public unsafe virtual void ShowPathDebug(bool bShowAll, bool bShowPolys, bool bShowTraversalHistory, int ShortenHistorySize, int EdgeHistorySize, bool bPermanent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowPathDebug, "BmGame.RNavigationHandle.ShowPathDebug");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowAll, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowPolys, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowTraversalHistory, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShortenHistorySize, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EdgeHistorySize, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPermanent, paramsPtr + 20);
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

    private static BmSDK.Function __fn_GetFinalEdgeIndex;
    /// <summary>
    /// Function: GetFinalEdgeIndex
    /// </summary>
    public unsafe virtual int GetFinalEdgeIndex()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFinalEdgeIndex, "BmGame.RNavigationHandle.GetFinalEdgeIndex");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PathContainsPathObject;
    /// <summary>
    /// Function: PathContainsPathObject
    /// </summary>
    public unsafe virtual bool PathContainsPathObject(BmSDK.Engine.Actor PathObject)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathContainsPathObject, "BmGame.RNavigationHandle.PathContainsPathObject");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathObject, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FindNarrowestPointOnPath;
    /// <summary>
    /// Function: FindNarrowestPointOnPath
    /// </summary>
    public unsafe virtual void FindNarrowestPointOnPath(float LookAheadDist, float MaxWidth, out float NarrowestOnLeft, out float NarrowestOnRight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindNarrowestPointOnPath, "BmGame.RNavigationHandle.FindNarrowestPointOnPath");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAheadDist, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxWidth, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NarrowestOnLeft);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NarrowestOnLeft, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NarrowestOnRight);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NarrowestOnRight, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NarrowestOnLeft = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        NarrowestOnRight = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_FindVantagePointOnPath;
    /// <summary>
    /// Function: FindVantagePointOnPath
    /// </summary>
    public unsafe virtual bool FindVantagePointOnPath(float DistToCheck, out BmSDK.BmGame.RHidePoint HidePoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindVantagePointOnPath, "BmGame.RNavigationHandle.FindVantagePointOnPath");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistToCheck, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HidePoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HidePoint, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HidePoint = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHidePoint>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindPredatorPointOnPath;
    /// <summary>
    /// Function: FindPredatorPointOnPath
    /// </summary>
    public unsafe virtual bool FindPredatorPointOnPath(float DistToCheck, out BmSDK.BmGame.RPredatorSpecialMovePointBase PredatorPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPredatorPointOnPath, "BmGame.RNavigationHandle.FindPredatorPointOnPath");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistToCheck, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PredatorPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PredatorPoint, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PredatorPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPredatorSpecialMovePointBase>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindRailingOnPath;
    /// <summary>
    /// Function: FindRailingOnPath
    /// </summary>
    public unsafe virtual bool FindRailingOnPath(float DistToCheck, out System.Numerics.Vector3 PeekPosition, out BmSDK.BmGame.RBMPathNode_FenceJump FenceJumpNode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindRailingOnPath, "BmGame.RNavigationHandle.FindRailingOnPath");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistToCheck, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PeekPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PeekPosition, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FenceJumpNode);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FenceJumpNode, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PeekPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        FenceJumpNode = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMPathNode_FenceJump>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_FindCornerPointOnPath;
    /// <summary>
    /// Function: FindCornerPointOnPath
    /// </summary>
    public unsafe virtual bool FindCornerPointOnPath(float DistToCheck, out BmSDK.BmGame.RCornerWallMarker StartPoint, out BmSDK.BmGame.RCornerWallMarker EndPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindCornerPointOnPath, "BmGame.RNavigationHandle.FindCornerPointOnPath");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistToCheck, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StartPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out EndPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        StartPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCornerWallMarker>(paramsPtr + 4);
        EndPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCornerWallMarker>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FindIntersectionInfo;
    /// <summary>
    /// Function: FindIntersectionInfo
    /// </summary>
    public unsafe virtual bool FindIntersectionInfo(BmSDK.BmGame.RNavigationHandle OtherNavHandle, out System.Numerics.Vector3 IntersectionStart, out int IntersectionStartID, out System.Numerics.Vector3 IntersectionEnd, out int IntersectionEndID, out float IntersectionStartDist, out float IntersectionLength)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindIntersectionInfo, "BmGame.RNavigationHandle.FindIntersectionInfo");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherNavHandle, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntersectionStart);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntersectionStart, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntersectionStartID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntersectionStartID, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntersectionEnd);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntersectionEnd, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntersectionEndID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntersectionEndID, paramsPtr + 32);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntersectionStartDist);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntersectionStartDist, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntersectionLength);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntersectionLength, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        IntersectionStart = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        IntersectionStartID = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        IntersectionEnd = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
        IntersectionEndID = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 32);
        IntersectionStartDist = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 36);
        IntersectionLength = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_IsHostOnPath;
    /// <summary>
    /// Function: IsHostOnPath
    /// </summary>
    public unsafe virtual bool IsHostOnPath()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHostOnPath, "BmGame.RNavigationHandle.IsHostOnPath");
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

    private static BmSDK.Function __fn_PathCache_Empty;
    /// <summary>
    /// Function: PathCache_Empty
    /// </summary>
    public unsafe override bool PathCache_Empty()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathCache_Empty, "BmGame.RNavigationHandle.PathCache_Empty");
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

    private static BmSDK.Function __fn_GetNextMoveLocation;
    /// <summary>
    /// Function: GetNextMoveLocation
    /// </summary>
    public unsafe override bool GetNextMoveLocation(out System.Numerics.Vector3 out_MoveDest, float ArrivalDistance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextMoveLocation, "BmGame.RNavigationHandle.GetNextMoveLocation");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_MoveDest);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_MoveDest, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrivalDistance, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_MoveDest = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetGoalDestination;
    /// <summary>
    /// Function: GetGoalDestination
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGoalDestination()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGoalDestination, "BmGame.RNavigationHandle.GetGoalDestination");
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

    private static BmSDK.Function __fn_GetPathDestination;
    /// <summary>
    /// Function: GetPathDestination
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPathDestination()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPathDestination, "BmGame.RNavigationHandle.GetPathDestination");
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

    private static BmSDK.Function __fn_GetFinalDestination;
    /// <summary>
    /// Function: GetFinalDestination
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFinalDestination()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFinalDestination, "BmGame.RNavigationHandle.GetFinalDestination");
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

    private static BmSDK.Function __fn_GetPathLength;
    /// <summary>
    /// Function: GetPathLength
    /// </summary>
    public unsafe virtual float GetPathLength()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPathLength, "BmGame.RNavigationHandle.GetPathLength");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanMoveToCurrDestinationFromPosition;
    /// <summary>
    /// Function: CanMoveToCurrDestinationFromPosition
    /// </summary>
    public unsafe virtual bool CanMoveToCurrDestinationFromPosition(System.Numerics.Vector3 NewPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanMoveToCurrDestinationFromPosition, "BmGame.RNavigationHandle.CanMoveToCurrDestinationFromPosition");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPos, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_UseNextPathObjectEdge;
    /// <summary>
    /// Function: UseNextPathObjectEdge
    /// </summary>
    public unsafe virtual void UseNextPathObjectEdge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UseNextPathObjectEdge, "BmGame.RNavigationHandle.UseNextPathObjectEdge");
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

    private static BmSDK.Function __fn_NextEdgeIsPathObject;
    /// <summary>
    /// Function: NextEdgeIsPathObject
    /// </summary>
    public unsafe virtual bool NextEdgeIsPathObject()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NextEdgeIsPathObject, "BmGame.RNavigationHandle.NextEdgeIsPathObject");
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

    private static BmSDK.Function __fn_CanDoPathShortening;
    /// <summary>
    /// Function: CanDoPathShortening
    /// </summary>
    public unsafe virtual bool CanDoPathShortening()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoPathShortening, "BmGame.RNavigationHandle.CanDoPathShortening");
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

    private static BmSDK.Function __fn_AdvancePathCache;
    /// <summary>
    /// Function: AdvancePathCache
    /// </summary>
    public unsafe virtual void AdvancePathCache()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdvancePathCache, "BmGame.RNavigationHandle.AdvancePathCache");
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

    private static BmSDK.Function __fn_AtPathGoal;
    /// <summary>
    /// Function: AtPathGoal
    /// </summary>
    public unsafe virtual bool AtPathGoal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AtPathGoal, "BmGame.RNavigationHandle.AtPathGoal");
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

    private static BmSDK.Function __fn_AtGoal;
    /// <summary>
    /// Function: AtGoal
    /// </summary>
    public unsafe virtual bool AtGoal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AtGoal, "BmGame.RNavigationHandle.AtGoal");
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

    private static BmSDK.Function __fn_PathNotFound;
    /// <summary>
    /// Function: PathNotFound
    /// </summary>
    public unsafe virtual bool PathNotFound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathNotFound, "BmGame.RNavigationHandle.PathNotFound");
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

    private static BmSDK.Function __fn_HasPath;
    /// <summary>
    /// Function: HasPath
    /// </summary>
    public unsafe virtual bool HasPath()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasPath, "BmGame.RNavigationHandle.HasPath");
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

    private static BmSDK.Function __fn_PathFound;
    /// <summary>
    /// Function: PathFound
    /// </summary>
    public unsafe virtual bool PathFound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathFound, "BmGame.RNavigationHandle.PathFound");
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

    private static BmSDK.Function __fn_IsSearching;
    /// <summary>
    /// Function: IsSearching
    /// </summary>
    public unsafe virtual bool IsSearching()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSearching, "BmGame.RNavigationHandle.IsSearching");
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

    private static BmSDK.Function __fn_IsAvailable;
    /// <summary>
    /// Function: IsAvailable
    /// </summary>
    public unsafe virtual bool IsAvailable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAvailable, "BmGame.RNavigationHandle.IsAvailable");
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

    private static BmSDK.Function __fn_ClearConstraints;
    /// <summary>
    /// Function: ClearConstraints
    /// </summary>
    public unsafe override void ClearConstraints()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearConstraints, "BmGame.RNavigationHandle.ClearConstraints");
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

    private static BmSDK.Function __fn_DoPathFinding;
    /// <summary>
    /// Function: DoPathFinding
    /// </summary>
    public unsafe virtual bool DoPathFinding(out BmSDK.Engine.Actor out_DestActor, out int out_DestItem, out int PathRequestsUsed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPathFinding, "BmGame.RNavigationHandle.DoPathFinding");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_DestActor);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_DestActor, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_DestItem);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_DestItem, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PathRequestsUsed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathRequestsUsed, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_DestActor = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
        out_DestItem = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        PathRequestsUsed = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FindPath;
    /// <summary>
    /// Function: FindPath
    /// </summary>
    public unsafe override bool FindPath(out BmSDK.Engine.Actor out_DestActor, out int out_DestItem, out int PathRequestsUsed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPath, "BmGame.RNavigationHandle.FindPath");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_DestActor);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_DestActor, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_DestItem);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_DestItem, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PathRequestsUsed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathRequestsUsed, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_DestActor = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
        out_DestItem = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        PathRequestsUsed = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ReachedEdge;
    /// <summary>
    /// Function: ReachedEdge
    /// </summary>
    public unsafe virtual void ReachedEdge(BmSDK.BmGame.RNavigationHandle NavHandle, int EdgeID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReachedEdge, "BmGame.RNavigationHandle.ReachedEdge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EdgeID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReachedGoal;
    /// <summary>
    /// Function: ReachedGoal
    /// </summary>
    public unsafe virtual void ReachedGoal(BmSDK.BmGame.RNavigationHandle NavHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReachedGoal, "BmGame.RNavigationHandle.ReachedGoal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PathFailure;
    /// <summary>
    /// Function: PathFailure
    /// </summary>
    public unsafe virtual void PathFailure(BmSDK.BmGame.RNavigationHandle NavHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathFailure, "BmGame.RNavigationHandle.PathFailure");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PathSuccess;
    /// <summary>
    /// Function: PathSuccess
    /// </summary>
    public unsafe virtual void PathSuccess(BmSDK.BmGame.RNavigationHandle NavHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathSuccess, "BmGame.RNavigationHandle.PathSuccess");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FStartStateDebugInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 108)]
    public partial record struct FStartStateDebugInfo
    {
        /// <summary>
        /// StructProperty: CachedPathParams
        /// </summary>
        public unsafe BmSDK.Engine.NavigationHandle.FNavMeshPathParams CachedPathParams
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavigationHandle.FNavMeshPathParams>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: ActorRot
        /// </summary>
        public unsafe BmSDK.Rotator ActorRot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// ObjectProperty: PathToActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor PathToActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// StructProperty: PathToPoint
        /// </summary>
        public unsafe System.Numerics.Vector3 PathToPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: bAvoidPlayers
        /// </summary>
        public unsafe bool bAvoidPlayers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 80); }; }
        }

        /// <summary>
        /// BoolProperty: bAvoidDoublingBack
        /// </summary>
        public unsafe bool bAvoidDoublingBack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: AvoidDoublingBackStrength
        /// </summary>
        public unsafe float AvoidDoublingBackStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// FloatProperty: AvoidDoublingBackDistance
        /// </summary>
        public unsafe float AvoidDoublingBackDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// BoolProperty: bCanUseLadders
        /// </summary>
        public unsafe bool bCanUseLadders
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }; }
        }

        /// <summary>
        /// BoolProperty: bCanClimbHigh
        /// </summary>
        public unsafe bool bCanClimbHigh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }; }
        }

        /// <summary>
        /// BoolProperty: bUseCheapSupportCheck
        /// </summary>
        public unsafe bool bUseCheapSupportCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }; }
        }

        /// <summary>
        /// BoolProperty: bCanTraverse
        /// </summary>
        public unsafe bool bCanTraverse
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }; }
        }

        /// <summary>
        /// BoolProperty: bPathToSafety
        /// </summary>
        public unsafe bool bPathToSafety
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }; }
        }

        /// <summary>
        /// ArrayProperty: AdditionalGoalList
        /// </summary>
        public unsafe BmSDK.TArray<System.Numerics.Vector3> AdditionalGoalList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }
    }

    /// <summary>
    /// Struct: FEdgeReachedInstance
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FEdgeReachedInstance
    {
        /// <summary>
        /// StructProperty: EdgeReachedLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 EdgeReachedLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: EdgeStart
        /// </summary>
        public unsafe System.Numerics.Vector3 EdgeStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: EdgeEnd
        /// </summary>
        public unsafe System.Numerics.Vector3 EdgeEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: NextEdgeLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 NextEdgeLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Struct: FPathShortenInstance
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FPathShortenInstance
    {
        /// <summary>
        /// StructProperty: ShortenStart
        /// </summary>
        public unsafe System.Numerics.Vector3 ShortenStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: ShortenEnd
        /// </summary>
        public unsafe System.Numerics.Vector3 ShortenEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: ShortenExtent
        /// </summary>
        public unsafe System.Numerics.Vector3 ShortenExtent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: ShortenPoints
        /// </summary>
        public unsafe BmSDK.TArray<System.Numerics.Vector3> ShortenPoints
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Enum: PathStatus
    /// </summary>
    public enum PathStatus : byte
    {
        PATH_None = 0,
        PATH_Waiting = 1,
        PATH_Claimed = 2,
        PATH_Searching = 3,
        PATH_Found = 4,
        PATH_NotFound = 5,
        PATH_Shortening = 6,
        PATH_MAX = 7,
    }

    /// <summary>
    /// BoolProperty: bCanPathFind
    /// </summary>
    public unsafe bool bCanPathFind
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bSettingUpPathFind
    /// </summary>
    public unsafe bool bSettingUpPathFind
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bBeenFollowed
    /// </summary>
    public unsafe bool bBeenFollowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bHasPath
    /// </summary>
    public unsafe bool bHasPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bAtPathGoal
    /// </summary>
    public unsafe bool bAtPathGoal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bAvoidPlayers
    /// </summary>
    public unsafe bool bAvoidPlayers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bAvoidDoublingBack
    /// </summary>
    public unsafe bool bAvoidDoublingBack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbHigh
    /// </summary>
    public unsafe bool bCanClimbHigh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bCanUseLadders
    /// </summary>
    public unsafe bool bCanUseLadders
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bCanTraverse
    /// </summary>
    public unsafe bool bCanTraverse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bPathToSafety
    /// </summary>
    public unsafe bool bPathToSafety
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bUseCheapSupportCheck
    /// </summary>
    public unsafe bool bUseCheapSupportCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bCanDoPathShortening
    /// </summary>
    public unsafe bool bCanDoPathShortening
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bCanDoRandomTeleport
    /// </summary>
    public unsafe bool bCanDoRandomTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bTimeSliceGetNextMoveLocation
    /// </summary>
    public unsafe bool bTimeSliceGetNextMoveLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bUseLastFramesPathTarget
    /// </summary>
    public unsafe bool bUseLastFramesPathTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bStuck
    /// </summary>
    public unsafe bool bStuck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bUsedPathObject
    /// </summary>
    public unsafe bool bUsedPathObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// ByteProperty: CurrState
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle.PathStatus CurrState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle.PathStatus>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ObjectProperty: HostActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor HostActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ObjectProperty: HostNavActor
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationActor HostNavActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationActor>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ObjectProperty: HostPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI HostPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// ObjectProperty: NavigationManager
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationManager NavigationManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationManager>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// NameProperty: ClaimName
    /// </summary>
    public unsafe BmSDK.FName ClaimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// IntProperty: PathFindPriority
    /// </summary>
    public unsafe int PathFindPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// IntProperty: CurrPathCacheID
    /// </summary>
    public unsafe int CurrPathCacheID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// FloatProperty: CachedPathLength
    /// </summary>
    public unsafe float CachedPathLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ObjectProperty: PathToActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor PathToActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// StructProperty: PathToPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PathToPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 460);

    /// <summary>
    /// FloatProperty: AvoidDoublingBackStrength
    /// </summary>
    public unsafe float AvoidDoublingBackStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// FloatProperty: AvoidDoublingBackDistance
    /// </summary>
    public unsafe float AvoidDoublingBackDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// IntProperty: ForcedShortenAttempts
    /// </summary>
    public unsafe int ForcedShortenAttempts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// StructProperty: TempMoveLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TempMoveLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 484);

    /// <summary>
    /// StructProperty: LastSafeLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSafeLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 496);

    /// <summary>
    /// ObjectProperty: LastSafeAnchorPylon
    /// </summary>
    public unsafe BmSDK.Engine.Pylon LastSafeAnchorPylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// IntProperty: LastSafeAnchorID
    /// </summary>
    public unsafe int LastSafeAnchorID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// FloatProperty: PathShortenProportion
    /// </summary>
    public unsafe float PathShortenProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// StructProperty: LastMoveLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastMoveLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 520);

    /// <summary>
    /// StructProperty: StuckTestLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StuckTestLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 532);

    /// <summary>
    /// FloatProperty: StuckTestTime
    /// </summary>
    public unsafe float StuckTestTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ArrayProperty: PathShortens
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FPathShortenInstance> PathShortens
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FPathShortenInstance>>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ArrayProperty: EdgesReached
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FEdgeReachedInstance> EdgesReached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle.FEdgeReachedInstance>>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ArrayProperty: PathTraversalHistory
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> PathTraversalHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// StructProperty: StoredPathCache
    /// </summary>
    public unsafe ref BmSDK.Engine.NavigationHandle.FPathStore StoredPathCache
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.NavigationHandle.FPathStore>(Ptr + 584);

    /// <summary>
    /// ArrayProperty: AdditionalGoalList
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> AdditionalGoalList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// StructProperty: PreviousPathLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPathLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 608);

    /// <summary>
    /// StructProperty: StoredAnchorPoly
    /// </summary>
    public unsafe System.IntPtr StoredAnchorPoly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ArrayProperty: AvoidPathObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> AvoidPathObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// StructProperty: HardBlockedEdges
    /// </summary>
    public unsafe ref BmSDK.Engine.NavigationHandle.FPathStore HardBlockedEdges
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.NavigationHandle.FPathStore>(Ptr + 636);

    /// <summary>
    /// StructProperty: SoftBlockedEdges
    /// </summary>
    public unsafe ref BmSDK.Engine.NavigationHandle.FPathStore SoftBlockedEdges
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.NavigationHandle.FPathStore>(Ptr + 648);

    /// <summary>
    /// ArrayProperty: BlockedPolyList
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> BlockedPolyList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// StructProperty: StartStateDebug
    /// </summary>
    public unsafe ref BmSDK.BmGame.RNavigationHandle.FStartStateDebugInfo StartStateDebug
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RNavigationHandle.FStartStateDebugInfo>(Ptr + 672);

    /// <summary>
    /// FloatProperty: AtGoalDistanceError
    /// </summary>
    public unsafe float AtGoalDistanceError
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// DelegateProperty: __PathSuccess__Delegate
    /// </summary>
    public unsafe System.IntPtr __PathSuccess__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// DelegateProperty: __PathFailure__Delegate
    /// </summary>
    public unsafe System.IntPtr __PathFailure__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// DelegateProperty: __ReachedGoal__Delegate
    /// </summary>
    public unsafe System.IntPtr __ReachedGoal__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// DelegateProperty: __ReachedEdge__Delegate
    /// </summary>
    public unsafe System.IntPtr __ReachedEdge__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }
}

/// <summary>
/// The static native functions of RNavigationHandle, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class RNavigationHandleStatics
{
    private static BmSDK.Function __fn_GetReachableLocation;
    /// <summary>
    /// Function: GetReachableLocation, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static bool GetReachableLocation(this BmSDK.BmGame.RNavigationHandle self, System.Numerics.Vector3 NearLocation, out System.Numerics.Vector3 ReachableLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetReachableLocation, "BmGame.RNavigationHandle.GetReachableLocation");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NearLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ReachableLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReachableLocation, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ReachableLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetPylonAndVisibleVertsFromPos;
    /// <summary>
    /// Function: GetPylonAndVisibleVertsFromPos, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void GetPylonAndVisibleVertsFromPos(this BmSDK.BmGame.RNavigationHandle self, System.Numerics.Vector3 TestPos, out BmSDK.Engine.Pylon BasePylon, out BmSDK.TArray<int> VertIDList)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPylonAndVisibleVertsFromPos, "BmGame.RNavigationHandle.GetPylonAndVisibleVertsFromPos");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BasePylon);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BasePylon, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BasePylon = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Pylon>(paramsPtr + 12);
        VertIDList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 16);
        return;
    }
}
