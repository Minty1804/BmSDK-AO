#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayerNightwingBase<br/>
/// (size = 7116)
/// (flags = 144736438)
/// </summary>
public partial class RPawnPlayerNightwingBase : BmSDK.BmGame.RPawnPlayer, BmSDK.BmGame.RXrayInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerNightwingBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayerNightwingBase.
    /// </summary>
    public static RPawnPlayerNightwingBase DefaultObject => (RPawnPlayerNightwingBase)StaticClass().DefaultObject;

    internal RPawnPlayerNightwingBase() { }

    /// <summary>
    /// Constructs a new RPawnPlayerNightwingBase
    /// </summary>
    public RPawnPlayerNightwingBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerNightwingBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerNightwingBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe virtual void SetInXrayMode(bool On, bool bForceOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmGame.RPawnPlayerNightwingBase.SetInXrayMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RicochetRayTest;
    /// <summary>
    /// Function: RicochetRayTest
    /// </summary>
    public unsafe virtual void RicochetRayTest(System.Numerics.Vector3 Start, System.Numerics.Vector3 Dir, float Length)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RicochetRayTest, "BmGame.RPawnPlayerNightwingBase.RicochetRayTest");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Length, paramsPtr + 24);
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

    private static BmSDK.Function __fn_UpdateGetRicochetTarget;
    /// <summary>
    /// Function: UpdateGetRicochetTarget
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor UpdateGetRicochetTarget(int maxIterations, BmSDK.BmGame.RInventoryGadget Gadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGetRicochetTarget, "BmGame.RPawnPlayerNightwingBase.UpdateGetRicochetTarget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(maxIterations, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gadget, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_StartGetRicochetTarget;
    /// <summary>
    /// Function: StartGetRicochetTarget
    /// </summary>
    public unsafe virtual void StartGetRicochetTarget(System.Numerics.Vector3 CameraLoc, BmSDK.Rotator CameraRot, System.Numerics.Vector3 launchPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGetRicochetTarget, "BmGame.RPawnPlayerNightwingBase.StartGetRicochetTarget");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(launchPos, paramsPtr + 24);
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
    /// Struct: FNwStickBouncePoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FNwStickBouncePoint
    {
        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Normal
        /// </summary>
        public unsafe System.Numerics.Vector3 Normal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: Pawn
        /// </summary>
        public unsafe BmSDK.Engine.Pawn Pawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// StructProperty: VfTable_IRXrayInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRXrayInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 7056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7056); }
    }

    /// <summary>
    /// NameProperty: TargetClass
    /// </summary>
    public unsafe BmSDK.FName TargetClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7060); }
    }

    /// <summary>
    /// BoolProperty: GettingTarget
    /// </summary>
    public unsafe bool GettingTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7068) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7068); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7068); }
    }

    /// <summary>
    /// IntProperty: RicochetRay
    /// </summary>
    public unsafe int RicochetRay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7072); }
    }

    /// <summary>
    /// IntProperty: RicochetNumRays
    /// </summary>
    public unsafe int RicochetNumRays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7076); }
    }

    /// <summary>
    /// FloatProperty: RicochetMaxRange
    /// </summary>
    public unsafe float RicochetMaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7080); }
    }

    /// <summary>
    /// IntProperty: RicochetMaxBounces
    /// </summary>
    public unsafe int RicochetMaxBounces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7084); }
    }

    /// <summary>
    /// FloatProperty: RicochetMaxAngle
    /// </summary>
    public unsafe float RicochetMaxAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7088); }
    }

    /// <summary>
    /// IntProperty: RicochetMaxExtraTargets
    /// </summary>
    public unsafe int RicochetMaxExtraTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7092); }
    }

    /// <summary>
    /// FloatProperty: RicochetExtraTargetMaxDist
    /// </summary>
    public unsafe float RicochetExtraTargetMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7096); }
    }

    /// <summary>
    /// ArrayProperty: RicochetBouncePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerNightwingBase.FNwStickBouncePoint> RicochetBouncePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerNightwingBase.FNwStickBouncePoint>>(Ptr + 7100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7100); }
    }

    /// <summary>
    /// IntProperty: RicochetNumTargets
    /// </summary>
    public unsafe int RicochetNumTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7112); }
    }
}
