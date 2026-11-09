#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RChaseLocationSearch<br/>
/// (size = 536)
/// (flags = 142606482)
/// </summary>
public partial class RChaseLocationSearch : BmSDK.BmGame.RSearchTreeFinder, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RChaseLocationSearch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RChaseLocationSearch.
    /// </summary>
    public static RChaseLocationSearch DefaultObject => (RChaseLocationSearch)StaticClass().DefaultObject;

    internal RChaseLocationSearch() { }

    /// <summary>
    /// Constructs a new RChaseLocationSearch
    /// </summary>
    public RChaseLocationSearch(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RChaseLocationSearch(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChaseLocationSearch>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChaseLocationSearch>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChaseLocationSearch>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChaseLocationSearch>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChaseLocationSearch>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChaseLocationSearch>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChaseLocationSearch>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChaseLocationSearch>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DebugShowChaseProgress;
    /// <summary>
    /// Function: DebugShowChaseProgress
    /// </summary>
    public unsafe virtual void DebugShowChaseProgress(float ChaseStartTime, BmSDK.Engine.Actor TestActor = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugShowChaseProgress, "BmGame.RChaseLocationSearch.DebugShowChaseProgress");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChaseStartTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThoughtString;
    /// <summary>
    /// Function: GetThoughtString
    /// </summary>
    public unsafe override BmSDK.FString GetThoughtString()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughtString, "BmGame.RChaseLocationSearch.GetThoughtString");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RecursiveGetFurthestVisible;
    /// <summary>
    /// Function: RecursiveGetFurthestVisible
    /// </summary>
    public unsafe virtual void RecursiveGetFurthestVisible(BmSDK.BmGame.RChasePoint TestSub, out BmSDK.TArray<BmSDK.BmGame.RChasePoint> UsableEnds)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecursiveGetFurthestVisible, "BmGame.RChaseLocationSearch.RecursiveGetFurthestVisible");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestSub, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        UsableEnds = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RChasePoint>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_RecursiveClearChecked;
    /// <summary>
    /// Function: RecursiveClearChecked
    /// </summary>
    public unsafe virtual void RecursiveClearChecked(BmSDK.BmGame.RChasePoint StartPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecursiveClearChecked, "BmGame.RChaseLocationSearch.RecursiveClearChecked");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RecursiveMarkCheckedIfBackwards;
    /// <summary>
    /// Function: RecursiveMarkCheckedIfBackwards
    /// </summary>
    public unsafe virtual bool RecursiveMarkCheckedIfBackwards(BmSDK.BmGame.RChasePoint TestSub, System.Numerics.Vector3 ForwardDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecursiveMarkCheckedIfBackwards, "BmGame.RChaseLocationSearch.RecursiveMarkCheckedIfBackwards");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestSub, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForwardDir, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_MarkCheckedIfBackwards;
    /// <summary>
    /// Function: MarkCheckedIfBackwards
    /// </summary>
    public unsafe virtual bool MarkCheckedIfBackwards(System.Numerics.Vector3 ForwardDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MarkCheckedIfBackwards, "BmGame.RChaseLocationSearch.MarkCheckedIfBackwards");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForwardDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_Cleanup;
    /// <summary>
    /// Function: Cleanup
    /// </summary>
    public unsafe override void Cleanup()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Cleanup, "BmGame.RChaseLocationSearch.Cleanup");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SearchPathsFailed;
    /// <summary>
    /// Function: SearchPathsFailed
    /// </summary>
    public unsafe virtual void SearchPathsFailed(BmSDK.BmGame.RNavigationHandle NavH)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SearchPathsFailed, "BmGame.RChaseLocationSearch.SearchPathsFailed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavH, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SearchPathsFound;
    /// <summary>
    /// Function: SearchPathsFound
    /// </summary>
    public unsafe virtual void SearchPathsFound(BmSDK.BmGame.RNavigationHandle NavH)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SearchPathsFound, "BmGame.RChaseLocationSearch.SearchPathsFound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavH, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSearch;
    /// <summary>
    /// Function: StartSearch
    /// </summary>
    public unsafe virtual void StartSearch(System.Numerics.Vector3 ChaseCenter, float ChaseDist, BmSDK.Engine.Actor AvoidActor = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSearch, "BmGame.RChaseLocationSearch.StartSearch");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChaseCenter, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChaseDist, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidActor, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInternalPolys;
    /// <summary>
    /// Function: GetInternalPolys
    /// </summary>
    public unsafe virtual void GetInternalPolys(out BmSDK.TArray<int> OutPolyList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInternalPolys, "BmGame.RChaseLocationSearch.GetInternalPolys");
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
        OutPolyList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_FindChaseStart;
    /// <summary>
    /// Function: FindChaseStart
    /// </summary>
    public unsafe virtual bool FindChaseStart(out System.Numerics.Vector3 ChaseStart)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindChaseStart, "BmGame.RChaseLocationSearch.FindChaseStart");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ChaseStart);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChaseStart, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ChaseStart = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ChaseSearchFailed;
    /// <summary>
    /// Function: ChaseSearchFailed
    /// </summary>
    public unsafe virtual void ChaseSearchFailed(BmSDK.BmGame.RChaseLocationSearch ChaseSearch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChaseSearchFailed, "BmGame.RChaseLocationSearch.ChaseSearchFailed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChaseSearch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChaseLocationsFound;
    /// <summary>
    /// Function: ChaseLocationsFound
    /// </summary>
    public unsafe virtual void ChaseLocationsFound(BmSDK.BmGame.RChaseLocationSearch ChaseSearch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChaseLocationsFound, "BmGame.RChaseLocationSearch.ChaseLocationsFound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChaseSearch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: ChaseState
    /// </summary>
    public unsafe BmSDK.BmGame.RChaseLocationSearch.ChaseSearchState ChaseState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChaseLocationSearch.ChaseSearchState>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// FloatProperty: FoundPathsTime
    /// </summary>
    public unsafe float FoundPathsTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// DelegateProperty: __ChaseLocationsFound__Delegate
    /// </summary>
    public unsafe System.IntPtr __ChaseLocationsFound__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// DelegateProperty: __ChaseSearchFailed__Delegate
    /// </summary>
    public unsafe System.IntPtr __ChaseSearchFailed__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// Enum: ChaseSearchState
    /// </summary>
    public enum ChaseSearchState : byte
    {
        ECSS_None = 0,
        ECSS_WaitingForPaths = 1,
        ECSS_ConnectVisitedEdges = 2,
        ECSS_AddingUnseenVerts = 3,
        ECSS_ReducingBranches = 4,
        ECSS_BuildingSearchPaths = 5,
        ECSS_RemoveDuplicateUnseenVerts = 6,
        ECSS_CountingBranchPoints = 7,
        ECSS_CalculatingBranchLengths = 8,
        ECSS_MAX = 9,
    }
}
