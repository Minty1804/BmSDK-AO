#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSearchRoutingWrapper<br/>
/// (size = 120)
/// (flags = 18)
/// </summary>
public partial class RSearchRoutingWrapper : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSearchRoutingWrapper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSearchRoutingWrapper.
    /// </summary>
    public static RSearchRoutingWrapper DefaultObject => (RSearchRoutingWrapper)StaticClass().DefaultObject;

    internal RSearchRoutingWrapper() { }

    /// <summary>
    /// Constructs a new RSearchRoutingWrapper
    /// </summary>
    public RSearchRoutingWrapper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSearchRoutingWrapper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSearchRoutingWrapper(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSearchRoutingWrapper>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSearchRoutingWrapper>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSearchRoutingWrapper>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSearchRoutingWrapper>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSearchRoutingWrapper>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSearchRoutingWrapper>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSearchRoutingWrapper>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSearchRoutingWrapper>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetFurthestVisibleDirs;
    /// <summary>
    /// Function: GetFurthestVisibleDirs
    /// </summary>
    public unsafe virtual void GetFurthestVisibleDirs(System.Numerics.Vector3 CentrePoint, out BmSDK.TArray<System.Numerics.Vector3> ValidDirList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFurthestVisibleDirs, "BmGame.RSearchRoutingWrapper.GetFurthestVisibleDirs");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CentrePoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ValidDirList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_Update;
    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe virtual bool Update()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Update, "BmGame.RSearchRoutingWrapper.Update");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitTestBranchEnds;
    /// <summary>
    /// Function: InitTestBranchEnds
    /// </summary>
    public unsafe virtual void InitTestBranchEnds()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitTestBranchEnds, "BmGame.RSearchRoutingWrapper.InitTestBranchEnds");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MarkBackPathsAsCheckedIfForwardPathExists;
    /// <summary>
    /// Function: MarkBackPathsAsCheckedIfForwardPathExists
    /// </summary>
    public unsafe virtual void MarkBackPathsAsCheckedIfForwardPathExists()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MarkBackPathsAsCheckedIfForwardPathExists, "BmGame.RSearchRoutingWrapper.MarkBackPathsAsCheckedIfForwardPathExists");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CollapseDeadEnds;
    /// <summary>
    /// Function: CollapseDeadEnds
    /// </summary>
    public unsafe virtual void CollapseDeadEnds(BmSDK.BmGame.RChasePoint TestNode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CollapseDeadEnds, "BmGame.RSearchRoutingWrapper.CollapseDeadEnds");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestNode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessUninformedSearchResults;
    /// <summary>
    /// Function: ProcessUninformedSearchResults
    /// </summary>
    public unsafe virtual void ProcessUninformedSearchResults()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessUninformedSearchResults, "BmGame.RSearchRoutingWrapper.ProcessUninformedSearchResults");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DirectFinished;
    /// <summary>
    /// Function: DirectFinished
    /// </summary>
    public unsafe virtual void DirectFinished(BmSDK.BmGame.RNavigationHandle NavHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DirectFinished, "BmGame.RSearchRoutingWrapper.DirectFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChaseSearchFailed, "BmGame.RSearchRoutingWrapper.ChaseSearchFailed");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChaseSearchDone, "BmGame.RSearchRoutingWrapper.ChaseSearchDone");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompletedSearch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSearch;
    /// <summary>
    /// Function: StartSearch
    /// </summary>
    public unsafe virtual void StartSearch(System.Numerics.Vector3 NewStartLoc, System.Numerics.Vector3 NewTargetLoc, System.Numerics.Vector3 NewLastArriveDir, float NewTreeSearchDist)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSearch, "BmGame.RSearchRoutingWrapper.StartSearch");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStartLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTargetLoc, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLastArriveDir, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTreeSearchDist, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShutDown;
    /// <summary>
    /// Function: ShutDown
    /// </summary>
    public unsafe virtual void ShutDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutDown, "BmGame.RSearchRoutingWrapper.ShutDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Cleanup;
    /// <summary>
    /// Function: Cleanup
    /// </summary>
    public unsafe virtual void Cleanup()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Cleanup, "BmGame.RSearchRoutingWrapper.Cleanup");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init(BmSDK.Engine.Actor NewOwningActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RSearchRoutingWrapper.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwningActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bWorking
    /// </summary>
    public unsafe bool bWorking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }
    }

    /// <summary>
    /// BoolProperty: bTestingBranchEnds
    /// </summary>
    public unsafe bool bTestingBranchEnds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }
    }

    /// <summary>
    /// BoolProperty: bTreeFinished
    /// </summary>
    public unsafe bool bTreeFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }
    }

    /// <summary>
    /// BoolProperty: bDirectPathFinished
    /// </summary>
    public unsafe bool bDirectPathFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }
    }

    /// <summary>
    /// BoolProperty: bResultIsDirect
    /// </summary>
    public unsafe bool bResultIsDirect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }
    }

    /// <summary>
    /// BoolProperty: bChainToUDest
    /// </summary>
    public unsafe bool bChainToUDest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }
    }

    /// <summary>
    /// ObjectProperty: ChaseLocSearch
    /// </summary>
    public unsafe BmSDK.BmGame.RChaseLocationSearch ChaseLocSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChaseLocationSearch>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ObjectProperty: EndPathWrapper
    /// </summary>
    public unsafe BmSDK.BmGame.RUninformedTreeEndPathWrapper EndPathWrapper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RUninformedTreeEndPathWrapper>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// ObjectProperty: DirectPath
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle DirectPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// StructProperty: StartLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StartLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 60);

    /// <summary>
    /// StructProperty: TargetLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TargetLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 72);

    /// <summary>
    /// StructProperty: LastArriveDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastArriveDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 84);

    /// <summary>
    /// FloatProperty: TreeSearchDist
    /// </summary>
    public unsafe float TreeSearchDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: ResultLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ResultLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 100);

    /// <summary>
    /// ObjectProperty: OwningActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor OwningActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ObjectProperty: BestTreeEnd
    /// </summary>
    public unsafe BmSDK.BmGame.RChasePoint BestTreeEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChasePoint>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
}
