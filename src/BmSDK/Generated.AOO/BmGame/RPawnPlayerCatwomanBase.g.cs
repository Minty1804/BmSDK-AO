#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayerCatwomanBase<br/>
/// (size = 7252)
/// (flags = 144736438)
/// </summary>
public partial class RPawnPlayerCatwomanBase : BmSDK.BmGame.RPawnPlayer, BmSDK.BmGame.RXrayInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerCatwomanBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayerCatwomanBase.
    /// </summary>
    public static RPawnPlayerCatwomanBase DefaultObject => (RPawnPlayerCatwomanBase)StaticClass().DefaultObject;

    internal RPawnPlayerCatwomanBase() { }

    /// <summary>
    /// Constructs a new RPawnPlayerCatwomanBase
    /// </summary>
    public RPawnPlayerCatwomanBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerCatwomanBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe virtual void SetInXrayMode(bool On, bool bForceOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmGame.RPawnPlayerCatwomanBase.SetInXrayMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanJumpOffWallStick;
    /// <summary>
    /// Function: CanJumpOffWallStick
    /// </summary>
    public unsafe virtual bool CanJumpOffWallStick(BmSDK.BmGame.RSpecialMoveConfig Config, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanJumpOffWallStick, "BmGame.RPawnPlayerCatwomanBase.CanJumpOffWallStick");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 116);
    }

    private static BmSDK.Function __fn_FlushDebugDraws;
    /// <summary>
    /// Function: FlushDebugDraws
    /// </summary>
    public unsafe virtual void FlushDebugDraws(bool bOnlyOncePerFrame = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushDebugDraws, "BmGame.RPawnPlayerCatwomanBase.FlushDebugDraws");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyOncePerFrame, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnHelicopterHit;
    /// <summary>
    /// Function: OnHelicopterHit
    /// </summary>
    public unsafe virtual void OnHelicopterHit(BmSDK.BmGame.RHelicopterBase Heli, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnHelicopterHit, "BmGame.RPawnPlayerCatwomanBase.OnHelicopterHit");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heli, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClampPointToCeilingVolumes;
    /// <summary>
    /// Function: ClampPointToCeilingVolumes
    /// </summary>
    public unsafe virtual bool ClampPointToCeilingVolumes(out System.Numerics.Vector3 Point, float ExtraShiftInwards = default, bool bDebugDraw = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClampPointToCeilingVolumes, "BmGame.RPawnPlayerCatwomanBase.ClampPointToCeilingVolumes");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Point);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Point, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraShiftInwards, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Point = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_UpdateTouchingCeilingVolume;
    /// <summary>
    /// Function: UpdateTouchingCeilingVolume
    /// </summary>
    public unsafe virtual void UpdateTouchingCeilingVolume()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTouchingCeilingVolume, "BmGame.RPawnPlayerCatwomanBase.UpdateTouchingCeilingVolume");
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

    private static BmSDK.Function __fn_ButtonMashPenalty;
    /// <summary>
    /// Function: ButtonMashPenalty
    /// </summary>
    public unsafe virtual void ButtonMashPenalty()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonMashPenalty, "BmGame.RPawnPlayerCatwomanBase.ButtonMashPenalty");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetAutoSwing;
    /// <summary>
    /// Function: ResetAutoSwing
    /// </summary>
    public unsafe virtual void ResetAutoSwing()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetAutoSwing, "BmGame.RPawnPlayerCatwomanBase.ResetAutoSwing");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerAerialWhipPounce;
    /// <summary>
    /// Function: TriggerAerialWhipPounce
    /// </summary>
    public unsafe virtual bool TriggerAerialWhipPounce()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerAerialWhipPounce, "BmGame.RPawnPlayerCatwomanBase.TriggerAerialWhipPounce");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEdgeSwingGrappleLocation;
    /// <summary>
    /// Function: GetEdgeSwingGrappleLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingGrappleLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingGrappleLocation, "BmGame.RPawnPlayerCatwomanBase.GetEdgeSwingGrappleLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEdgeSwingWallLocation;
    /// <summary>
    /// Function: GetEdgeSwingWallLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingWallLocation(out System.Numerics.Vector3 WallNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingWallLocation, "BmGame.RPawnPlayerCatwomanBase.GetEdgeSwingWallLocation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WallNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        WallNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetEdgeSwingStartLocation;
    /// <summary>
    /// Function: GetEdgeSwingStartLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingStartLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingStartLocation, "BmGame.RPawnPlayerCatwomanBase.GetEdgeSwingStartLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAutoSwingToGargoyle;
    /// <summary>
    /// Function: IsAutoSwingToGargoyle
    /// </summary>
    public unsafe virtual bool IsAutoSwingToGargoyle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAutoSwingToGargoyle, "BmGame.RPawnPlayerCatwomanBase.IsAutoSwingToGargoyle");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAutoSwing;
    /// <summary>
    /// Function: IsAutoSwing
    /// </summary>
    public unsafe virtual bool IsAutoSwing()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAutoSwing, "BmGame.RPawnPlayerCatwomanBase.IsAutoSwing");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsConcealedDuringSwing;
    /// <summary>
    /// Function: IsConcealedDuringSwing
    /// </summary>
    public unsafe virtual bool IsConcealedDuringSwing()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsConcealedDuringSwing, "BmGame.RPawnPlayerCatwomanBase.IsConcealedDuringSwing");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetAutoSwingState;
    /// <summary>
    /// Function: SetAutoSwingState
    /// </summary>
    public unsafe virtual void SetAutoSwingState(BmSDK.BmGame.RPawnPlayerCatwomanBase.EAutoSwingState State)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAutoSwingState, "BmGame.RPawnPlayerCatwomanBase.SetAutoSwingState");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsValidClimbStartPoint;
    /// <summary>
    /// Function: IsValidClimbStartPoint
    /// </summary>
    public unsafe virtual bool IsValidClimbStartPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidClimbStartPoint, "BmGame.RPawnPlayerCatwomanBase.IsValidClimbStartPoint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFirstClimbPoint;
    /// <summary>
    /// Function: GetFirstClimbPoint
    /// </summary>
    public unsafe virtual void GetFirstClimbPoint(out System.Numerics.Vector3 Position, out System.Numerics.Vector3 Normal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFirstClimbPoint, "BmGame.RPawnPlayerCatwomanBase.GetFirstClimbPoint");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Position);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Normal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Normal, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Position = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        Normal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_RecalculatePath;
    /// <summary>
    /// Function: RecalculatePath
    /// </summary>
    public unsafe virtual void RecalculatePath()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecalculatePath, "BmGame.RPawnPlayerCatwomanBase.RecalculatePath");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasPath;
    /// <summary>
    /// Function: HasPath
    /// </summary>
    public unsafe virtual bool HasPath()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasPath, "BmGame.RPawnPlayerCatwomanBase.HasPath");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearPath;
    /// <summary>
    /// Function: ClearPath
    /// </summary>
    public unsafe virtual void ClearPath()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPath, "BmGame.RPawnPlayerCatwomanBase.ClearPath");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAllowAerialWhipPounce;
    /// <summary>
    /// Function: SetAllowAerialWhipPounce
    /// </summary>
    public unsafe virtual void SetAllowAerialWhipPounce(bool bAllow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllowAerialWhipPounce, "BmGame.RPawnPlayerCatwomanBase.SetAllowAerialWhipPounce");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerHitAndDropFromCeilingMove;
    /// <summary>
    /// Function: TriggerHitAndDropFromCeilingMove
    /// </summary>
    public unsafe virtual void TriggerHitAndDropFromCeilingMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerHitAndDropFromCeilingMove, "BmGame.RPawnPlayerCatwomanBase.TriggerHitAndDropFromCeilingMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWhipTargetPose;
    /// <summary>
    /// Function: SetWhipTargetPose
    /// </summary>
    public unsafe virtual void SetWhipTargetPose(System.Numerics.Vector3 NewPosition, BmSDK.Rotator NewRotation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWhipTargetPose, "BmGame.RPawnPlayerCatwomanBase.SetWhipTargetPose");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 12);
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

    private static BmSDK.Function __fn_GetWhipTargetPose;
    /// <summary>
    /// Function: GetWhipTargetPose
    /// </summary>
    public unsafe virtual void GetWhipTargetPose(out System.Numerics.Vector3 OutPosition, out BmSDK.Rotator OutRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWhipTargetPose, "BmGame.RPawnPlayerCatwomanBase.GetWhipTargetPose");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutPosition, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutRotation, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        OutRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_FindNearbyLedgeFromCeiling;
    /// <summary>
    /// Function: FindNearbyLedgeFromCeiling
    /// </summary>
    public unsafe virtual bool FindNearbyLedgeFromCeiling(System.Numerics.Vector3 PlayerLocation, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Locator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindNearbyLedgeFromCeiling, "BmGame.RPawnPlayerCatwomanBase.FindNearbyLedgeFromCeiling");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Locator);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Locator, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Locator = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 124);
    }

    private static BmSDK.Function __fn_AddEdgeCollisionNormals;
    /// <summary>
    /// Function: AddEdgeCollisionNormals
    /// </summary>
    public unsafe virtual void AddEdgeCollisionNormals(System.Numerics.Vector3 Delta)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddEdgeCollisionNormals, "BmGame.RPawnPlayerCatwomanBase.AddEdgeCollisionNormals");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SlideOffCeilingVolumeBorders;
    /// <summary>
    /// Function: SlideOffCeilingVolumeBorders
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 SlideOffCeilingVolumeBorders(System.Numerics.Vector3 Delta)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlideOffCeilingVolumeBorders, "BmGame.RPawnPlayerCatwomanBase.SlideOffCeilingVolumeBorders");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RestrictMoveToCeiling;
    /// <summary>
    /// Function: RestrictMoveToCeiling
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 RestrictMoveToCeiling(System.Numerics.Vector3 Delta)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestrictMoveToCeiling, "BmGame.RPawnPlayerCatwomanBase.RestrictMoveToCeiling");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmGame.RPawnPlayerCatwomanBase.GetThoughts");
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
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DrawSwingSpot;
    /// <summary>
    /// Function: DrawSwingSpot
    /// </summary>
    public unsafe virtual void DrawSwingSpot()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawSwingSpot, "BmGame.RPawnPlayerCatwomanBase.DrawSwingSpot");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawSwingLastFrame;
    /// <summary>
    /// Function: DrawSwingLastFrame
    /// </summary>
    public unsafe virtual void DrawSwingLastFrame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawSwingLastFrame, "BmGame.RPawnPlayerCatwomanBase.DrawSwingLastFrame");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopSwingFallSound;
    /// <summary>
    /// Function: StopSwingFallSound
    /// </summary>
    public unsafe virtual void StopSwingFallSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSwingFallSound, "BmGame.RPawnPlayerCatwomanBase.StopSwingFallSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSwingFallSound;
    /// <summary>
    /// Function: StartSwingFallSound
    /// </summary>
    public unsafe virtual void StartSwingFallSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSwingFallSound, "BmGame.RPawnPlayerCatwomanBase.StartSwingFallSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: ESwingDirection
    /// </summary>
    public enum ESwingDirection : byte
    {
        SWD_Default = 0,
        SWD_Left = 1,
        SWD_Right = 2,
        SWD_LeftFar = 3,
        SWD_RightFar = 4,
        SWD_MAX = 5,
    }

    /// <summary>
    /// Enum: EAutoSwingState
    /// </summary>
    public enum EAutoSwingState : byte
    {
        ASS_None = 0,
        ASS_InitialJump = 1,
        ASS_Swing = 2,
        ASS_JumpToWall = 3,
        ASS_WallStick = 4,
        ASS_MAX = 5,
    }

    /// <summary>
    /// Struct: FWhipTrailData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FWhipTrailData
    {
        /// <summary>
        /// ComponentProperty: ParticleSystemComp
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent ParticleSystemComp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: BoneAttachName
        /// </summary>
        public unsafe BmSDK.FName BoneAttachName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bCurrentlyActive
        /// </summary>
        public unsafe bool bCurrentlyActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: LastUpdatePosition
        /// </summary>
        public unsafe System.Numerics.Vector3 LastUpdatePosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: CachedBoneAttachIndex
        /// </summary>
        public unsafe int CachedBoneAttachIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
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
    /// BoolProperty: bPhysUseCeilingConstraints
    /// </summary>
    public unsafe bool bPhysUseCeilingConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7060); }
    }

    /// <summary>
    /// BoolProperty: bFlipCeilingCamera
    /// </summary>
    public unsafe bool bFlipCeilingCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7060); }
    }

    /// <summary>
    /// BoolProperty: bAllowAerialWhipPounce
    /// </summary>
    public unsafe bool bAllowAerialWhipPounce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7060); }
    }

    /// <summary>
    /// BoolProperty: bAutoSwingEarlyWhip
    /// </summary>
    public unsafe bool bAutoSwingEarlyWhip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7060); }
    }

    /// <summary>
    /// BoolProperty: bAutoSwingTriggeredFromEdge
    /// </summary>
    public unsafe bool bAutoSwingTriggeredFromEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7060); }
    }

    /// <summary>
    /// BoolProperty: bDebugSwingAllowEarlyWhipIn
    /// </summary>
    public unsafe bool bDebugSwingAllowEarlyWhipIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7060); }
    }

    /// <summary>
    /// BoolProperty: bDebugSwingForceEarlyWhipIn
    /// </summary>
    public unsafe bool bDebugSwingForceEarlyWhipIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7060); }
    }

    /// <summary>
    /// BoolProperty: bDebugCeilingVisibility
    /// </summary>
    public unsafe bool bDebugCeilingVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7060); }
    }

    /// <summary>
    /// BoolProperty: bDebugCeilingEdgeDetection
    /// </summary>
    public unsafe bool bDebugCeilingEdgeDetection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7060); }
    }

    /// <summary>
    /// BoolProperty: bPlayingSwingFallSound
    /// </summary>
    public unsafe bool bPlayingSwingFallSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7060); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawFallSwingSound
    /// </summary>
    public unsafe bool bDebugDrawFallSwingSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7060); }
    }

    /// <summary>
    /// BoolProperty: bDebugJumpOffWalls
    /// </summary>
    public unsafe bool bDebugJumpOffWalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7060); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7060); }
    }

    /// <summary>
    /// NameProperty: WhipSkelControlName
    /// </summary>
    public unsafe BmSDK.FName WhipSkelControlName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7064); }
    }

    /// <summary>
    /// FloatProperty: MaxDirectPounceHeightToCeilings
    /// </summary>
    public unsafe float MaxDirectPounceHeightToCeilings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7072); }
    }

    /// <summary>
    /// ComponentProperty: WhipMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent WhipMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7076); }
    }

    /// <summary>
    /// FloatProperty: WhipTrailMinAppearSpeed
    /// </summary>
    public unsafe float WhipTrailMinAppearSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7080); }
    }

    /// <summary>
    /// FloatProperty: MinTrailsWhipExtent
    /// </summary>
    public unsafe float MinTrailsWhipExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7084); }
    }

    /// <summary>
    /// ArrayProperty: WhipTrails
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCatwomanBase.FWhipTrailData> WhipTrails
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCatwomanBase.FWhipTrailData>>(Ptr + 7088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7088); }
    }

    /// <summary>
    /// ByteProperty: AutoSwingState
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCatwomanBase.EAutoSwingState AutoSwingState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCatwomanBase.EAutoSwingState>(Ptr + 7100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7100); }
    }

    /// <summary>
    /// ByteProperty: SwingDirection
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCatwomanBase.ESwingDirection SwingDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCatwomanBase.ESwingDirection>(Ptr + 7101); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7101); }
    }

    /// <summary>
    /// ObjectProperty: WhipCrackFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WhipCrackFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 7104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7104); }
    }

    /// <summary>
    /// ClassProperty: CauseTitanBeserkClass
    /// </summary>
    public unsafe BmSDK.Class CauseTitanBeserkClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7108); }
    }

    /// <summary>
    /// ObjectProperty: TouchingCeilingVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RCeilingClimbVolume TouchingCeilingVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCeilingClimbVolume>(Ptr + 7112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7112); }
    }

    /// <summary>
    /// FloatProperty: CeilingSuspiciousBodyRange
    /// </summary>
    public unsafe float CeilingSuspiciousBodyRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7116); }
    }

    /// <summary>
    /// FloatProperty: CeilingSuspiciousPredThugsRange
    /// </summary>
    public unsafe float CeilingSuspiciousPredThugsRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7120); }
    }

    /// <summary>
    /// ObjectProperty: SwingStartEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SwingStartEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 7124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7124); }
    }

    /// <summary>
    /// ObjectProperty: SwingStopEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SwingStopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 7128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7128); }
    }

    /// <summary>
    /// StructProperty: LastSwingSoundLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSwingSoundLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7132);

    /// <summary>
    /// FloatProperty: FallSoundStartSpeed
    /// </summary>
    public unsafe float FallSoundStartSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7144); }
    }

    /// <summary>
    /// FloatProperty: BolasRadius
    /// </summary>
    public unsafe float BolasRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7148); }
    }

    /// <summary>
    /// FloatProperty: BolasHeight
    /// </summary>
    public unsafe float BolasHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7152); }
    }

    /// <summary>
    /// StructProperty: BolasShift
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BolasShift
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7156);

    /// <summary>
    /// FloatProperty: BolasRBSpeedFactor
    /// </summary>
    public unsafe float BolasRBSpeedFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7168); }
    }

    /// <summary>
    /// FloatProperty: BolasRBMaxSpeed
    /// </summary>
    public unsafe float BolasRBMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7172); }
    }

    /// <summary>
    /// StructProperty: BolasAngularSpeed
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BolasAngularSpeed
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7176);

    /// <summary>
    /// FloatProperty: LastFlushPersistentLinesFrame
    /// </summary>
    public unsafe float LastFlushPersistentLinesFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7188); }
    }

    /// <summary>
    /// StructProperty: CeilingNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CeilingNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7192);

    /// <summary>
    /// FloatProperty: GrateClimbUpStartCheckDistance
    /// </summary>
    public unsafe float GrateClimbUpStartCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7204); }
    }

    /// <summary>
    /// FloatProperty: GrateClimbUpTargetCheckDistance
    /// </summary>
    public unsafe float GrateClimbUpTargetCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7208); }
    }

    /// <summary>
    /// FloatProperty: GrateClimbUpTargetFloorCheckDistance
    /// </summary>
    public unsafe float GrateClimbUpTargetFloorCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7212); }
    }

    /// <summary>
    /// FloatProperty: GrateClimbDownTargetCheckDistance
    /// </summary>
    public unsafe float GrateClimbDownTargetCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7216); }
    }

    /// <summary>
    /// FloatProperty: JumpOffWallCheckDistance
    /// </summary>
    public unsafe float JumpOffWallCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7220); }
    }

    /// <summary>
    /// ObjectProperty: JammerTakedownPlayerAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet JammerTakedownPlayerAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 7224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7224); }
    }

    /// <summary>
    /// ObjectProperty: JammerTakedownVictimAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet JammerTakedownVictimAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 7228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7228); }
    }

    /// <summary>
    /// FloatProperty: MaxPullFromCatwalkDistance
    /// </summary>
    public unsafe float MaxPullFromCatwalkDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7232); }
    }

    /// <summary>
    /// StructProperty: PullFromCatwalkEdgeCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PullFromCatwalkEdgeCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7236);

    /// <summary>
    /// FloatProperty: PullFromCatwalkEdgeCheckShift
    /// </summary>
    public unsafe float PullFromCatwalkEdgeCheckShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7248); }
    }
}
