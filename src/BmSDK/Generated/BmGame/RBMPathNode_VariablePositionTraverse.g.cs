#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RBMPathNode_VariablePositionTraverse<br/>
/// (size = 768)
/// (flags = 142606995)
/// </summary>
public partial class RBMPathNode_VariablePositionTraverse : BmSDK.BmGame.RBMPathNode_SpecialMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMPathNode_VariablePositionTraverse", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMPathNode_VariablePositionTraverse.
    /// </summary>
    public static RBMPathNode_VariablePositionTraverse DefaultObject => (RBMPathNode_VariablePositionTraverse)StaticClass().DefaultObject;

    internal RBMPathNode_VariablePositionTraverse() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMPathNode_VariablePositionTraverse(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_VariablePositionTraverse>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_VariablePositionTraverse>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_VariablePositionTraverse>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_VariablePositionTraverse>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_VariablePositionTraverse>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_VariablePositionTraverse>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_VariablePositionTraverse>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPathNode_VariablePositionTraverse>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_TryUpwards;
    /// <summary>
    /// Function: TryUpwards
    /// </summary>
    public unsafe virtual float TryUpwards(float StartPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryUpwards, "BmGame.RBMPathNode_VariablePositionTraverse.TryUpwards");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TryDownwards;
    /// <summary>
    /// Function: TryDownwards
    /// </summary>
    public unsafe virtual float TryDownwards(float StartPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryDownwards, "BmGame.RBMPathNode_VariablePositionTraverse.TryDownwards");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsFree;
    /// <summary>
    /// Function: IsFree
    /// </summary>
    public unsafe virtual bool IsFree(float TestPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFree, "BmGame.RBMPathNode_VariablePositionTraverse.IsFree");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNearestEdgeUp;
    /// <summary>
    /// Function: GetNearestEdgeUp
    /// </summary>
    public unsafe virtual float GetNearestEdgeUp(float TestPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNearestEdgeUp, "BmGame.RBMPathNode_VariablePositionTraverse.GetNearestEdgeUp");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNearestEdgeDown;
    /// <summary>
    /// Function: GetNearestEdgeDown
    /// </summary>
    public unsafe virtual float GetNearestEdgeDown(float TestPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNearestEdgeDown, "BmGame.RBMPathNode_VariablePositionTraverse.GetNearestEdgeDown");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AttemptLockForProxy;
    /// <summary>
    /// Function: AttemptLockForProxy
    /// </summary>
    public unsafe virtual bool AttemptLockForProxy(BmSDK.BmGame.RPawn User, System.Numerics.Vector3 DestPoint, BmSDK.BmGame.RBMPathNode_VariablePositionTraverseProxy Proxy, out System.Numerics.Vector3 SlotLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttemptLockForProxy, "BmGame.RBMPathNode_VariablePositionTraverse.AttemptLockForProxy");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestPoint, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proxy, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SlotLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotLocation, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SlotLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetClosestPoint;
    /// <summary>
    /// Function: GetClosestPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetClosestPoint(BmSDK.BmGame.RPawn User, BmSDK.BmGame.RBMPathNode_VariablePositionTraverseProxy Proxy, out System.Numerics.Vector3 PreferredLocVect, out float DistAlongLine)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestPoint, "BmGame.RBMPathNode_VariablePositionTraverse.GetClosestPoint");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proxy, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PreferredLocVect);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreferredLocVect, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DistAlongLine);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistAlongLine, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PreferredLocVect = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        DistAlongLine = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetJumpLockLocation;
    /// <summary>
    /// Function: GetJumpLockLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetJumpLockLocation(BmSDK.BmGame.RPawn User)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJumpLockLocation, "BmGame.RBMPathNode_VariablePositionTraverse.GetJumpLockLocation");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsInJumpLockList;
    /// <summary>
    /// Function: IsInJumpLockList
    /// </summary>
    public unsafe virtual bool IsInJumpLockList(BmSDK.BmGame.RPawn User)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInJumpLockList, "BmGame.RBMPathNode_VariablePositionTraverse.IsInJumpLockList");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_JumpUnlock;
    /// <summary>
    /// Function: JumpUnlock
    /// </summary>
    public unsafe virtual void JumpUnlock(BmSDK.BmGame.RPawn User)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JumpUnlock, "BmGame.RBMPathNode_VariablePositionTraverse.JumpUnlock");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawDebugInfo;
    /// <summary>
    /// Function: DrawDebugInfo
    /// </summary>
    public unsafe virtual void DrawDebugInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugInfo, "BmGame.RBMPathNode_VariablePositionTraverse.DrawDebugInfo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsNaN;
    /// <summary>
    /// Function: IsNaN
    /// </summary>
    public unsafe virtual bool IsNaN(System.Numerics.Vector3 TestVector)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNaN, "BmGame.RBMPathNode_VariablePositionTraverse.IsNaN");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestVector, paramsPtr + 0);
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

    /// <summary>
    /// Enum: FenceJumpEdgeType
    /// </summary>
    public enum FenceJumpEdgeType : byte
    {
        FENCEEDGE_Drop = 0,
        FENCEEDGE_Climb = 1,
        FENCEEDGE_ClimbHigh384 = 2,
        FENCEEDGE_ClimbHigh512 = 3,
        FENCEEDGE_Level = 4,
        STEPEDGE_Drop = 5,
        STEPEDGE_Climb = 6,
        FenceJumpEdgeType_MAX = 7,
    }

    /// <summary>
    /// Struct: FJumperAssignment
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FJumperAssignment
    {
        /// <summary>
        /// FloatProperty: Start
        /// </summary>
        public unsafe float Start
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: End
        /// </summary>
        public unsafe float End
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: refPoint
        /// </summary>
        public unsafe System.Numerics.Vector3 refPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: Jumper
        /// </summary>
        public unsafe BmSDK.BmGame.RPawn Jumper
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// StructProperty: LandLoc
        /// </summary>
        public unsafe System.Numerics.Vector3 LandLoc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: Proxy1
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPathNode_VariablePositionTraverseProxy Proxy1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPathNode_VariablePositionTraverseProxy>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: Proxy2
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPathNode_VariablePositionTraverseProxy Proxy2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPathNode_VariablePositionTraverseProxy>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ClassProperty: ProxyClass
    /// </summary>
    public unsafe BmSDK.Class ProxyClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: EndPoint1
    /// </summary>
    public unsafe BmSDK.BmGame.REndPointMarker EndPoint1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REndPointMarker>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: EndPoint2
    /// </summary>
    public unsafe BmSDK.BmGame.REndPointMarker EndPoint2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REndPointMarker>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// StructProperty: JumpNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 JumpNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 732);

    /// <summary>
    /// ArrayProperty: JumpLockList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPathNode_VariablePositionTraverse.FJumperAssignment> JumpLockList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPathNode_VariablePositionTraverse.FJumperAssignment>>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: ExtentSize
    /// </summary>
    public unsafe float ExtentSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: bUseClosestPoint
    /// </summary>
    public unsafe bool bUseClosestPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: DistBetweenProxys
    /// </summary>
    public unsafe float DistBetweenProxys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }
}
