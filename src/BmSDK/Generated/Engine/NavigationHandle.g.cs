#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavigationHandle<br/>
/// (size = 412)
/// (flags = 134217874)
/// </summary>
public partial class NavigationHandle : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavigationHandle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as NavigationHandle.
    /// </summary>
    public static NavigationHandle DefaultObject => (NavigationHandle)StaticClass().DefaultObject;

    internal NavigationHandle() { }

    /// <summary>
    /// Constructs a new NavigationHandle
    /// </summary>
    public NavigationHandle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavigationHandle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavigationHandle(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NavigationHandle>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavigationHandle>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NavigationHandle>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavigationHandle>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavigationHandle>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavigationHandle>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NavigationHandle>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavigationHandle>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_StaticGetValidatedAnchorPosition;
    /// <summary>
    /// Function: StaticGetValidatedAnchorPosition
    /// </summary>
    public unsafe static bool StaticGetValidatedAnchorPosition(out System.Numerics.Vector3 out_NewAnchorLoc, System.Numerics.Vector3 StartCheckBaseLocation, System.Numerics.Vector3 Extent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StaticGetValidatedAnchorPosition, "Engine.NavigationHandle.StaticGetValidatedAnchorPosition");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_NewAnchorLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_NewAnchorLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCheckBaseLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_NewAnchorLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetValidatedAnchorPosition;
    /// <summary>
    /// Function: GetValidatedAnchorPosition
    /// </summary>
    public unsafe virtual bool GetValidatedAnchorPosition(out System.Numerics.Vector3 out_NewAnchorLoc, System.Numerics.Vector3 OverrideStartLoc = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetValidatedAnchorPosition, "Engine.NavigationHandle.GetValidatedAnchorPosition");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_NewAnchorLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_NewAnchorLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideStartLoc, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_NewAnchorLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_PopulatePathfindingParamCache;
    /// <summary>
    /// Function: PopulatePathfindingParamCache
    /// </summary>
    public unsafe virtual bool PopulatePathfindingParamCache()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulatePathfindingParamCache, "Engine.NavigationHandle.PopulatePathfindingParamCache");
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

    private static BmSDK.Function __fn_MoveToDesiredHeightAboveMesh;
    /// <summary>
    /// Function: MoveToDesiredHeightAboveMesh
    /// </summary>
    public unsafe static System.Numerics.Vector3 MoveToDesiredHeightAboveMesh(System.Numerics.Vector3 Point, float Height)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveToDesiredHeightAboveMesh, "Engine.NavigationHandle.MoveToDesiredHeightAboveMesh");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Point, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Height, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CalculatePathDistance;
    /// <summary>
    /// Function: CalculatePathDistance
    /// </summary>
    public unsafe virtual float CalculatePathDistance(System.Numerics.Vector3 FinalDest = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculatePathDistance, "Engine.NavigationHandle.CalculatePathDistance");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinalDest, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetFirstMoveLocation;
    /// <summary>
    /// Function: GetFirstMoveLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFirstMoveLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFirstMoveLocation, "Engine.NavigationHandle.GetFirstMoveLocation");
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

    private static BmSDK.Function __fn_IsAnchorInescapable;
    /// <summary>
    /// Function: IsAnchorInescapable
    /// </summary>
    public unsafe virtual bool IsAnchorInescapable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnchorInescapable, "Engine.NavigationHandle.IsAnchorInescapable");
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

    private static BmSDK.Function __fn_LimitPathCacheDistance;
    /// <summary>
    /// Function: LimitPathCacheDistance
    /// </summary>
    public unsafe virtual void LimitPathCacheDistance(float MaxDist)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LimitPathCacheDistance, "Engine.NavigationHandle.LimitPathCacheDistance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetValidPositionsForBox;
    /// <summary>
    /// Function: GetValidPositionsForBox
    /// </summary>
    public unsafe static void GetValidPositionsForBox(System.Numerics.Vector3 pos, float Radius, System.Numerics.Vector3 Extent, bool bMustBeReachableFromStartPos, out BmSDK.TArray<System.Numerics.Vector3> out_ValidPositions, int MaxPositions = default, float MinRadius = default, System.Numerics.Vector3 ValidBoxAroundStartPos = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetValidPositionsForBox, "Engine.NavigationHandle.GetValidPositionsForBox");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMustBeReachableFromStartPos, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxPositions, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinRadius, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValidBoxAroundStartPos, paramsPtr + 52);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_ValidPositions = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 32);
        return;
    }

    private static BmSDK.Function __fn_GetAllPolyCentersWithinBounds;
    /// <summary>
    /// Function: GetAllPolyCentersWithinBounds
    /// </summary>
    public unsafe static void GetAllPolyCentersWithinBounds(System.Numerics.Vector3 pos, System.Numerics.Vector3 Extent, out BmSDK.TArray<System.Numerics.Vector3> out_PolyCtrs)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAllPolyCentersWithinBounds, "Engine.NavigationHandle.GetAllPolyCentersWithinBounds");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_PolyCtrs = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_GetCurrentEdgeType;
    /// <summary>
    /// Function: GetCurrentEdgeType
    /// </summary>
    public unsafe virtual BmSDK.Engine.Pylon.ENavMeshEdgeType GetCurrentEdgeType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentEdgeType, "Engine.NavigationHandle.GetCurrentEdgeType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Pylon.ENavMeshEdgeType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearCurrentEdge;
    /// <summary>
    /// Function: ClearCurrentEdge
    /// </summary>
    public unsafe virtual void ClearCurrentEdge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCurrentEdge, "Engine.NavigationHandle.ClearCurrentEdge");
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

    private static BmSDK.Function __fn_GetCurrentEdgeDebugText;
    /// <summary>
    /// Function: GetCurrentEdgeDebugText
    /// </summary>
    public unsafe virtual BmSDK.FString GetCurrentEdgeDebugText()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentEdgeDebugText, "Engine.NavigationHandle.GetCurrentEdgeDebugText");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PrintPathCacheDebugText;
    /// <summary>
    /// Function: PrintPathCacheDebugText
    /// </summary>
    public unsafe virtual void PrintPathCacheDebugText()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrintPathCacheDebugText, "Engine.NavigationHandle.PrintPathCacheDebugText");
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

    private static BmSDK.Function __fn_DrawPathCache;
    /// <summary>
    /// Function: DrawPathCache
    /// </summary>
    public unsafe virtual void DrawPathCache(System.Numerics.Vector3 DrawOffset = default, bool bPersistent = default, BmSDK.GameObject.FColor DrawColor = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawPathCache, "Engine.NavigationHandle.DrawPathCache");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DrawOffset, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DrawColor, paramsPtr + 16);
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

    private static BmSDK.Function __fn_ActorReachable;
    /// <summary>
    /// Function: ActorReachable
    /// </summary>
    public unsafe virtual bool ActorReachable(BmSDK.Engine.Actor A)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActorReachable, "Engine.NavigationHandle.ActorReachable");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PointReachable;
    /// <summary>
    /// Function: PointReachable
    /// </summary>
    public unsafe virtual bool PointReachable(System.Numerics.Vector3 Point, System.Numerics.Vector3 OverrideStartPoint = default, bool bAllowHitsInEndCollisionBox = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointReachable, "Engine.NavigationHandle.PointReachable");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Point, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideStartPoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowHitsInEndCollisionBox, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_PointCheck;
    /// <summary>
    /// Function: PointCheck
    /// </summary>
    public unsafe virtual bool PointCheck(System.Numerics.Vector3 Pt, System.Numerics.Vector3 Extent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointCheck, "Engine.NavigationHandle.PointCheck");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_LineCheck;
    /// <summary>
    /// Function: LineCheck
    /// </summary>
    public unsafe static bool LineCheck(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 Extent, out System.Numerics.Vector3 out_HitLocation, out System.Numerics.Vector3 out_HitNormal, bool bGetFirstHit)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LineCheck, "Engine.NavigationHandle.LineCheck");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_HitLocation, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_HitNormal, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGetFirstHit, paramsPtr + 60);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        out_HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 64);
    }

    private static BmSDK.Function __fn_ObstaclePointCheck;
    /// <summary>
    /// Function: ObstaclePointCheck
    /// </summary>
    public unsafe static bool ObstaclePointCheck(System.Numerics.Vector3 Pt, System.Numerics.Vector3 Extent)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObstaclePointCheck, "Engine.NavigationHandle.ObstaclePointCheck");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ObstacleLineCheckIgnoreWalkable;
    /// <summary>
    /// Function: ObstacleLineCheckIgnoreWalkable
    /// </summary>
    public unsafe static bool ObstacleLineCheckIgnoreWalkable(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 Extent, out System.Numerics.Vector3 out_HitLoc, out System.Numerics.Vector3 out_HitNorm)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObstacleLineCheckIgnoreWalkable, "Engine.NavigationHandle.ObstacleLineCheckIgnoreWalkable");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_HitLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_HitLoc, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_HitNorm);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_HitNorm, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_HitLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        out_HitNorm = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_ObstacleLineCheck;
    /// <summary>
    /// Function: ObstacleLineCheck
    /// </summary>
    public unsafe static bool ObstacleLineCheck(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 Extent, out System.Numerics.Vector3 out_HitLoc, out System.Numerics.Vector3 out_HitNorm)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObstacleLineCheck, "Engine.NavigationHandle.ObstacleLineCheck");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_HitLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_HitLoc, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_HitNorm);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_HitNorm, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_HitLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        out_HitNorm = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_SuggestMovePreparation;
    /// <summary>
    /// Function: SuggestMovePreparation
    /// </summary>
    public unsafe virtual bool SuggestMovePreparation(out System.Numerics.Vector3 MovePt, BmSDK.Engine.Controller C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuggestMovePreparation, "Engine.NavigationHandle.SuggestMovePreparation");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MovePt);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovePt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        MovePt = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FindPath;
    /// <summary>
    /// Function: FindPath
    /// </summary>
    public unsafe virtual bool FindPath(out BmSDK.Engine.Actor out_DestActor, out int out_DestItem, out int PathRequestsUsed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPath, "Engine.NavigationHandle.FindPath");
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

    private static BmSDK.Function __fn_ComputeValidFinalDestination;
    /// <summary>
    /// Function: ComputeValidFinalDestination
    /// </summary>
    public unsafe virtual bool ComputeValidFinalDestination(out System.Numerics.Vector3 out_ComputedPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ComputeValidFinalDestination, "Engine.NavigationHandle.ComputeValidFinalDestination");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_ComputedPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_ComputedPosition, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_ComputedPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetFinalDestination;
    /// <summary>
    /// Function: SetFinalDestination
    /// </summary>
    public unsafe virtual bool SetFinalDestination(System.Numerics.Vector3 FinalDest)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFinalDestination, "Engine.NavigationHandle.SetFinalDestination");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinalDest, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetNextMoveLocation;
    /// <summary>
    /// Function: GetNextMoveLocation
    /// </summary>
    public unsafe virtual bool GetNextMoveLocation(out System.Numerics.Vector3 out_MoveDest, float ArrivalDistance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextMoveLocation, "Engine.NavigationHandle.GetNextMoveLocation");
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

    private static BmSDK.Function __fn_GetPylonFromPos;
    /// <summary>
    /// Function: GetPylonFromPos
    /// </summary>
    public unsafe static BmSDK.Engine.Pylon GetPylonFromPos(System.Numerics.Vector3 Position)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPylonFromPos, "Engine.NavigationHandle.GetPylonFromPos");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Pylon>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FindPylon;
    /// <summary>
    /// Function: FindPylon
    /// </summary>
    public unsafe virtual bool FindPylon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPylon, "Engine.NavigationHandle.FindPylon");
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

    private static BmSDK.Function __fn_GetBestUnfinishedPathPoint;
    /// <summary>
    /// Function: GetBestUnfinishedPathPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBestUnfinishedPathPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestUnfinishedPathPoint, "Engine.NavigationHandle.GetBestUnfinishedPathPoint");
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

    private static BmSDK.Function __fn_PathCache_RemoveIndex;
    /// <summary>
    /// Function: PathCache_RemoveIndex
    /// </summary>
    public unsafe virtual bool PathCache_RemoveIndex(int InIdx, int Count = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathCache_RemoveIndex, "Engine.NavigationHandle.PathCache_RemoveIndex");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIdx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PathCache_GetGoalPoint;
    /// <summary>
    /// Function: PathCache_GetGoalPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 PathCache_GetGoalPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathCache_GetGoalPoint, "Engine.NavigationHandle.PathCache_GetGoalPoint");
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

    private static BmSDK.Function __fn_PathCache_Empty;
    /// <summary>
    /// Function: PathCache_Empty
    /// </summary>
    public unsafe virtual bool PathCache_Empty()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathCache_Empty, "Engine.NavigationHandle.PathCache_Empty");
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

    private static BmSDK.Function __fn_CreatePathGoalEvaluator;
    /// <summary>
    /// Function: CreatePathGoalEvaluator
    /// </summary>
    public unsafe virtual BmSDK.Engine.NavMeshPathGoalEvaluator CreatePathGoalEvaluator(BmSDK.Class GoalEvalClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePathGoalEvaluator, "Engine.NavigationHandle.CreatePathGoalEvaluator");
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
    public unsafe virtual BmSDK.Engine.NavMeshPathConstraint CreatePathConstraint(BmSDK.Class ConstraintClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePathConstraint, "Engine.NavigationHandle.CreatePathConstraint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConstraintClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.NavMeshPathConstraint>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AddGoalEvaluator;
    /// <summary>
    /// Function: AddGoalEvaluator
    /// </summary>
    public unsafe virtual void AddGoalEvaluator(BmSDK.Engine.NavMeshPathGoalEvaluator Evaluator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGoalEvaluator, "Engine.NavigationHandle.AddGoalEvaluator");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Evaluator, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddPathConstraint;
    /// <summary>
    /// Function: AddPathConstraint
    /// </summary>
    public unsafe virtual void AddPathConstraint(BmSDK.Engine.NavMeshPathConstraint Constraint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPathConstraint, "Engine.NavigationHandle.AddPathConstraint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Constraint, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearConstraints;
    /// <summary>
    /// Function: ClearConstraints
    /// </summary>
    public unsafe virtual void ClearConstraints()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearConstraints, "Engine.NavigationHandle.ClearConstraints");
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

    private static BmSDK.Function __fn_GetNextBreadCrumb;
    /// <summary>
    /// Function: GetNextBreadCrumb
    /// </summary>
    public unsafe virtual bool GetNextBreadCrumb(out System.Numerics.Vector3 out_BreadCrumbLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextBreadCrumb, "Engine.NavigationHandle.GetNextBreadCrumb");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_BreadCrumbLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_BreadCrumbLoc, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_BreadCrumbLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_UpdateBreadCrumbs;
    /// <summary>
    /// Function: UpdateBreadCrumbs
    /// </summary>
    public unsafe virtual void UpdateBreadCrumbs(System.Numerics.Vector3 InLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBreadCrumbs, "Engine.NavigationHandle.UpdateBreadCrumbs");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLocation, paramsPtr + 0);
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
    /// Struct: FNavMeshPathParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FNavMeshPathParams
    {
        /// <summary>
        /// StructProperty: Interface
        /// </summary>
        public unsafe System.IntPtr Interface
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bCanMantle
        /// </summary>
        public unsafe bool bCanMantle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bNeedsMantleValidityTest
        /// </summary>
        public unsafe bool bNeedsMantleValidityTest
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bAbleToSearch
        /// </summary>
        public unsafe bool bAbleToSearch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bCanClimbHigh
        /// </summary>
        public unsafe bool bCanClimbHigh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bCanUseLadders
        /// </summary>
        public unsafe bool bCanUseLadders
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bUseCheapSupportCheck
        /// </summary>
        public unsafe bool bUseCheapSupportCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: SearchExtent
        /// </summary>
        public unsafe System.Numerics.Vector3 SearchExtent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: SearchLaneMultiplier
        /// </summary>
        public unsafe float SearchLaneMultiplier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// StructProperty: SearchStart
        /// </summary>
        public unsafe System.Numerics.Vector3 SearchStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: MaxDropHeight
        /// </summary>
        public unsafe float MaxDropHeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: MinWalkableZ
        /// </summary>
        public unsafe float MinWalkableZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: MaxHoverDistance
        /// </summary>
        public unsafe float MaxHoverDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StructProperty: PathSessionData
        /// </summary>
        public unsafe System.IntPtr PathSessionData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Struct: FNavMeshPathSessionData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public partial record struct FNavMeshPathSessionData
    {
        /// <summary>
        /// BoolProperty: IsSearching
        /// </summary>
        public unsafe bool IsSearching
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: OpenList
        /// </summary>
        public unsafe System.IntPtr OpenList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: GeneratedGoal
        /// </summary>
        public unsafe System.IntPtr GeneratedGoal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: MaxPathVisits
        /// </summary>
        public unsafe int MaxPathVisits
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: PathSessionID
        /// </summary>
        public unsafe int PathSessionID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: NumVisits
        /// </summary>
        public unsafe int NumVisits
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// MapProperty: NodeToPathSessionDataMap
        /// </summary>
        public unsafe BmSDK.TMap<object, object> /* TODO */ NodeToPathSessionDataMap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FPathStore
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FPathStore
    {
        /// <summary>
        /// ArrayProperty: EdgeList
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.NavigationHandle.FEdgePointer> EdgeList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavigationHandle.FEdgePointer>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FEdgePointer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FEdgePointer
    {
        /// <summary>
        /// StructProperty: Dummy
        /// </summary>
        public unsafe System.IntPtr Dummy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: AnchorPylon
    /// </summary>
    public unsafe BmSDK.Engine.Pylon AnchorPylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// StructProperty: AnchorPoly
    /// </summary>
    public unsafe System.IntPtr AnchorPoly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// StructProperty: PathCache
    /// </summary>
    public unsafe ref BmSDK.Engine.NavigationHandle.FPathStore PathCache
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.NavigationHandle.FPathStore>(Ptr + 52);

    /// <summary>
    /// StructProperty: BestUnfinishedPathPoint
    /// </summary>
    public unsafe System.IntPtr BestUnfinishedPathPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// StructProperty: CurrentEdge
    /// </summary>
    public unsafe System.IntPtr CurrentEdge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// StructProperty: SubGoal_DestPoly
    /// </summary>
    public unsafe System.IntPtr SubGoal_DestPoly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// StructProperty: FinalDestination
    /// </summary>
    public unsafe ref BmSDK.Engine.Actor.FBasedPosition FinalDestination
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.Actor.FBasedPosition>(Ptr + 76);

    /// <summary>
    /// BoolProperty: bSkipRouteCacheUpdates
    /// </summary>
    public unsafe bool bSkipRouteCacheUpdates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bUseORforEvaluateGoal
    /// </summary>
    public unsafe bool bUseORforEvaluateGoal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bDebugConstraintsAndGoalEvals
    /// </summary>
    public unsafe bool bDebugConstraintsAndGoalEvals
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bUltraVerbosePathDebugging
    /// </summary>
    public unsafe bool bUltraVerbosePathDebugging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bDebug_Breadcrumbs
    /// </summary>
    public unsafe bool bDebug_Breadcrumbs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// ObjectProperty: PathConstraintList
    /// </summary>
    public unsafe BmSDK.Engine.NavMeshPathConstraint PathConstraintList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathConstraint>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: PathGoalList
    /// </summary>
    public unsafe BmSDK.Engine.NavMeshPathGoalEvaluator PathGoalList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathGoalEvaluator>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// StructProperty: CachedPathParams
    /// </summary>
    public unsafe ref BmSDK.Engine.NavigationHandle.FNavMeshPathParams CachedPathParams
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.NavigationHandle.FNavMeshPathParams>(Ptr + 140);

    /// <summary>
    /// StructProperty: PathSessionData
    /// </summary>
    public unsafe ref BmSDK.Engine.NavigationHandle.FNavMeshPathSessionData PathSessionData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.NavigationHandle.FNavMeshPathSessionData>(Ptr + 192);

    /// <summary>
    /// ByteProperty: LastPathError
    /// </summary>
    public unsafe BmSDK.Engine.EngineTypes.EPathFindingError LastPathError
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.EngineTypes.EPathFindingError>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// FloatProperty: LastPathFailTime
    /// </summary>
    public unsafe float LastPathFailTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: Breadcrumbs
    /// </summary>
    public InlineArray<System.Numerics.Vector3> Breadcrumbs => new(10, Ptr + 284, 12, this);

    /// <summary>
    /// StructProperty: Breadcrumbs
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Breadcrumbs_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 284);
    /// <summary>
    /// StructProperty: Breadcrumbs
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Breadcrumbs_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 296);
    /// <summary>
    /// StructProperty: Breadcrumbs
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Breadcrumbs_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 308);
    /// <summary>
    /// StructProperty: Breadcrumbs
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Breadcrumbs_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 320);
    /// <summary>
    /// StructProperty: Breadcrumbs
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Breadcrumbs_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 332);
    /// <summary>
    /// StructProperty: Breadcrumbs
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Breadcrumbs_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 344);
    /// <summary>
    /// StructProperty: Breadcrumbs
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Breadcrumbs_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 356);
    /// <summary>
    /// StructProperty: Breadcrumbs
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Breadcrumbs_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 368);
    /// <summary>
    /// StructProperty: Breadcrumbs
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Breadcrumbs_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 380);
    /// <summary>
    /// StructProperty: Breadcrumbs
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Breadcrumbs_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 392);

    /// <summary>
    /// IntProperty: BreadCrumbMostRecentIdx
    /// </summary>
    public unsafe int BreadCrumbMostRecentIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// FloatProperty: BreadCrumbDistanceInterval
    /// </summary>
    public unsafe float BreadCrumbDistanceInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// Struct: FPolySegmentSpan
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FPolySegmentSpan
    {
        /// <summary>
        /// StructProperty: Poly
        /// </summary>
        public unsafe System.IntPtr Poly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: P1
        /// </summary>
        public unsafe System.Numerics.Vector3 P1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: P2
        /// </summary>
        public unsafe System.Numerics.Vector3 P2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}

/// <summary>
/// The static native functions of NavigationHandle, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class NavigationHandleStatics
{
    private static BmSDK.Function __fn_StaticGetValidatedAnchorPosition;
    /// <summary>
    /// Function: StaticGetValidatedAnchorPosition, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static bool StaticGetValidatedAnchorPosition(this BmSDK.Engine.NavigationHandle self, out System.Numerics.Vector3 out_NewAnchorLoc, System.Numerics.Vector3 StartCheckBaseLocation, System.Numerics.Vector3 Extent)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StaticGetValidatedAnchorPosition, "Engine.NavigationHandle.StaticGetValidatedAnchorPosition");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_NewAnchorLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_NewAnchorLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCheckBaseLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_NewAnchorLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_MoveToDesiredHeightAboveMesh;
    /// <summary>
    /// Function: MoveToDesiredHeightAboveMesh, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static System.Numerics.Vector3 MoveToDesiredHeightAboveMesh(this BmSDK.Engine.NavigationHandle self, System.Numerics.Vector3 Point, float Height)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveToDesiredHeightAboveMesh, "Engine.NavigationHandle.MoveToDesiredHeightAboveMesh");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Point, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Height, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetValidPositionsForBox;
    /// <summary>
    /// Function: GetValidPositionsForBox, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void GetValidPositionsForBox(this BmSDK.Engine.NavigationHandle self, System.Numerics.Vector3 pos, float Radius, System.Numerics.Vector3 Extent, bool bMustBeReachableFromStartPos, out BmSDK.TArray<System.Numerics.Vector3> out_ValidPositions, int MaxPositions = default, float MinRadius = default, System.Numerics.Vector3 ValidBoxAroundStartPos = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetValidPositionsForBox, "Engine.NavigationHandle.GetValidPositionsForBox");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMustBeReachableFromStartPos, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxPositions, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinRadius, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValidBoxAroundStartPos, paramsPtr + 52);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_ValidPositions = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 32);
        return;
    }

    private static BmSDK.Function __fn_GetAllPolyCentersWithinBounds;
    /// <summary>
    /// Function: GetAllPolyCentersWithinBounds, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void GetAllPolyCentersWithinBounds(this BmSDK.Engine.NavigationHandle self, System.Numerics.Vector3 pos, System.Numerics.Vector3 Extent, out BmSDK.TArray<System.Numerics.Vector3> out_PolyCtrs)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAllPolyCentersWithinBounds, "Engine.NavigationHandle.GetAllPolyCentersWithinBounds");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_PolyCtrs = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_LineCheck;
    /// <summary>
    /// Function: LineCheck, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static bool LineCheck(this BmSDK.Engine.NavigationHandle self, System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 Extent, out System.Numerics.Vector3 out_HitLocation, out System.Numerics.Vector3 out_HitNormal, bool bGetFirstHit)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LineCheck, "Engine.NavigationHandle.LineCheck");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_HitLocation, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_HitNormal, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGetFirstHit, paramsPtr + 60);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        out_HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 64);
    }

    private static BmSDK.Function __fn_ObstaclePointCheck;
    /// <summary>
    /// Function: ObstaclePointCheck, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static bool ObstaclePointCheck(this BmSDK.Engine.NavigationHandle self, System.Numerics.Vector3 Pt, System.Numerics.Vector3 Extent)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObstaclePointCheck, "Engine.NavigationHandle.ObstaclePointCheck");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ObstacleLineCheckIgnoreWalkable;
    /// <summary>
    /// Function: ObstacleLineCheckIgnoreWalkable, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static bool ObstacleLineCheckIgnoreWalkable(this BmSDK.Engine.NavigationHandle self, System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 Extent, out System.Numerics.Vector3 out_HitLoc, out System.Numerics.Vector3 out_HitNorm)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObstacleLineCheckIgnoreWalkable, "Engine.NavigationHandle.ObstacleLineCheckIgnoreWalkable");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_HitLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_HitLoc, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_HitNorm);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_HitNorm, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_HitLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        out_HitNorm = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_ObstacleLineCheck;
    /// <summary>
    /// Function: ObstacleLineCheck, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static bool ObstacleLineCheck(this BmSDK.Engine.NavigationHandle self, System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 Extent, out System.Numerics.Vector3 out_HitLoc, out System.Numerics.Vector3 out_HitNorm)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObstacleLineCheck, "Engine.NavigationHandle.ObstacleLineCheck");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_HitLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_HitLoc, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_HitNorm);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_HitNorm, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_HitLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        out_HitNorm = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_GetPylonFromPos;
    /// <summary>
    /// Function: GetPylonFromPos, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static BmSDK.Engine.Pylon GetPylonFromPos(this BmSDK.Engine.NavigationHandle self, System.Numerics.Vector3 Position)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPylonFromPos, "Engine.NavigationHandle.GetPylonFromPos");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Pylon>(paramsPtr + 12);
    }
}
