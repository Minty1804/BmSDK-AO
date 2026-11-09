#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPhysicsGrabber<br/>
/// (size = 1064)
/// (flags = 142606514)
/// </summary>
public partial class RPhysicsGrabber : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPhysicsGrabber", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPhysicsGrabber.
    /// </summary>
    public static RPhysicsGrabber DefaultObject => (RPhysicsGrabber)StaticClass().DefaultObject;

    internal RPhysicsGrabber() { }

    /// <summary>
    /// Constructs a new RPhysicsGrabber
    /// </summary>
    public RPhysicsGrabber(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPhysicsGrabber(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicsGrabber>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PhysObjectDetectorUpdate;
    /// <summary>
    /// Function: PhysObjectDetectorUpdate
    /// </summary>
    public unsafe virtual bool PhysObjectDetectorUpdate(System.Numerics.Vector3 GrabberLocation, BmSDK.Rotator GrabberRotation, out float OutUnrealHitDistance, out BmSDK.Engine.Actor OutHitActor, out BmSDK.Engine.RB_BodyInstance OutHitBodyInstance, out System.Numerics.Vector3 OutHitShapeBoundsCentre, out System.Numerics.Vector3 OutHitShapeBoundsExtents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PhysObjectDetectorUpdate, "BmGame.RPhysicsGrabber.PhysObjectDetectorUpdate");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrabberLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrabberRotation, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutUnrealHitDistance);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutUnrealHitDistance, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutHitActor);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutHitActor, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutHitBodyInstance);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutHitBodyInstance, paramsPtr + 32);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutHitShapeBoundsCentre);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutHitShapeBoundsCentre, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutHitShapeBoundsExtents);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutHitShapeBoundsExtents, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutUnrealHitDistance = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        OutHitActor = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 28);
        OutHitBodyInstance = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.RB_BodyInstance>(paramsPtr + 32);
        OutHitShapeBoundsCentre = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
        OutHitShapeBoundsExtents = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_PlayerTick;
    /// <summary>
    /// Function: PlayerTick
    /// </summary>
    public unsafe override void PlayerTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerTick, "BmGame.RPhysicsGrabber.PlayerTick");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopPhysicsDrag;
    /// <summary>
    /// Function: StopPhysicsDrag
    /// </summary>
    public unsafe virtual void StopPhysicsDrag()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopPhysicsDrag, "BmGame.RPhysicsGrabber.StopPhysicsDrag");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartPhysicsDrag;
    /// <summary>
    /// Function: StartPhysicsDrag
    /// </summary>
    public unsafe virtual void StartPhysicsDrag()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPhysicsDrag, "BmGame.RPhysicsGrabber.StartPhysicsDrag");
        byte* paramsPtr = stackalloc byte[188];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelGadget;
    /// <summary>
    /// Function: CancelGadget
    /// </summary>
    public unsafe override void CancelGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelGadget, "BmGame.RPhysicsGrabber.CancelGadget");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RPhysicsGrabber.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRBBodyInstancePointerString;
    /// <summary>
    /// Function: GetRBBodyInstancePointerString
    /// </summary>
    public unsafe virtual BmSDK.FString GetRBBodyInstancePointerString()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRBBodyInstancePointerString, "BmGame.RPhysicsGrabber.GetRBBodyInstancePointerString");
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

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe override void DrawHUD(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.RPhysicsGrabber.DrawHUD");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoSurfaceTypeRender;
    /// <summary>
    /// Function: DoSurfaceTypeRender
    /// </summary>
    public unsafe virtual void DoSurfaceTypeRender(BmSDK.Engine.Canvas Canvas)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoSurfaceTypeRender, "BmGame.RPhysicsGrabber.DoSurfaceTypeRender");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSurfaceType;
    /// <summary>
    /// Function: GetSurfaceType
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetSurfaceType(out BmSDK.Engine.Actor.FTraceHitInfo HitInfo, out float Dist)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSurfaceType, "BmGame.RPhysicsGrabber.GetSurfaceType");
        byte* paramsPtr = stackalloc byte[196];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Dist);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dist, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FTraceHitInfo>(paramsPtr + 0);
        Dist = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetStartEndTracePoints;
    /// <summary>
    /// Function: GetStartEndTracePoints
    /// </summary>
    public unsafe virtual void GetStartEndTracePoints(out System.Numerics.Vector3 TraceStart, out System.Numerics.Vector3 TraceEnd)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStartEndTracePoints, "BmGame.RPhysicsGrabber.GetStartEndTracePoints");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TraceStart);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceStart, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TraceEnd);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceEnd, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TraceStart = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        TraceEnd = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetFullName;
    /// <summary>
    /// Function: GetFullName
    /// </summary>
    public unsafe virtual BmSDK.FString GetFullName(BmSDK.GameObject Obj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFullName, "BmGame.RPhysicsGrabber.GetFullName");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SecondaryButtonPressed;
    /// <summary>
    /// Function: SecondaryButtonPressed
    /// </summary>
    public unsafe override void SecondaryButtonPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SecondaryButtonPressed, "BmGame.RPhysicsGrabber.SecondaryButtonPressed");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ButtonReleased;
    /// <summary>
    /// Function: ButtonReleased
    /// </summary>
    public unsafe override void ButtonReleased()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonReleased, "BmGame.RPhysicsGrabber.ButtonReleased");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ButtonPressed;
    /// <summary>
    /// Function: ButtonPressed
    /// </summary>
    public unsafe override void ButtonPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonPressed, "BmGame.RPhysicsGrabber.ButtonPressed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetName;
    /// <summary>
    /// Function: GetName
    /// </summary>
    public unsafe override BmSDK.FString GetName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetName, "BmGame.RPhysicsGrabber.GetName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// FloatProperty: WeaponImpulse
    /// </summary>
    public unsafe float WeaponImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// FloatProperty: ThrowImpulse
    /// </summary>
    public unsafe float ThrowImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// ComponentProperty: PhysicsGrabber
    /// </summary>
    public unsafe BmSDK.Engine.RB_Handle PhysicsGrabber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_Handle>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// FloatProperty: HoldDistance
    /// </summary>
    public unsafe float HoldDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// StructProperty: HoldOrientation
    /// </summary>
    public unsafe ref BmSDK.GameObject.FQuat HoldOrientation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FQuat>(Ptr + 1008);

    /// <summary>
    /// BoolProperty: IsPhysActorHit
    /// </summary>
    public unsafe bool IsPhysActorHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: PhysTestHitDistance
    /// </summary>
    public unsafe float PhysTestHitDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ObjectProperty: PhysTestHitRBBodyInstance
    /// </summary>
    public unsafe BmSDK.Engine.RB_BodyInstance PhysTestHitRBBodyInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ObjectProperty: PhysTestHitActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor PhysTestHitActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// StructProperty: PhysTestShapeBoundsCentre
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PhysTestShapeBoundsCentre
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1040);

    /// <summary>
    /// StructProperty: PhysTestShapeBoundsExtents
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PhysTestShapeBoundsExtents
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1052);
}
