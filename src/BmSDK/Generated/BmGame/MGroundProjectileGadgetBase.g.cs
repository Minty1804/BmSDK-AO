#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MGroundProjectileGadgetBase<br/>
/// (size = 1380)
/// (flags = 142606514)
/// </summary>
public partial class MGroundProjectileGadgetBase : BmSDK.BmGame.RProjectileGadgetBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MGroundProjectileGadgetBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGroundProjectileGadgetBase.
    /// </summary>
    public static MGroundProjectileGadgetBase DefaultObject => (MGroundProjectileGadgetBase)StaticClass().DefaultObject;

    internal MGroundProjectileGadgetBase() { }

    /// <summary>
    /// Constructs a new MGroundProjectileGadgetBase
    /// </summary>
    public MGroundProjectileGadgetBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGroundProjectileGadgetBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGroundProjectileGadgetBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGroundProjectileGadgetBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGroundProjectileGadgetBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGroundProjectileGadgetBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGroundProjectileGadgetBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGroundProjectileGadgetBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGroundProjectileGadgetBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGroundProjectileGadgetBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpdateTrajectory;
    /// <summary>
    /// Function: UpdateTrajectory
    /// </summary>
    public unsafe override bool UpdateTrajectory(out System.Numerics.Vector3 InitVelocity, bool bLockOnEnemy = default, bool bKeepTargetLocation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTrajectory, "BmGame.MGroundProjectileGadgetBase.UpdateTrajectory");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InitVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitVelocity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLockOnEnemy, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKeepTargetLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        InitVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_AimAndDrawHUD;
    /// <summary>
    /// Function: AimAndDrawHUD
    /// </summary>
    public unsafe override void AimAndDrawHUD(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimAndDrawHUD, "BmGame.MGroundProjectileGadgetBase.AimAndDrawHUD");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateAutoTarget;
    /// <summary>
    /// Function: UpdateAutoTarget
    /// </summary>
    public unsafe override void UpdateAutoTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAutoTarget, "BmGame.MGroundProjectileGadgetBase.UpdateAutoTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveCollisionActor;
    /// <summary>
    /// Function: MoveCollisionActor
    /// </summary>
    public unsafe virtual void MoveCollisionActor(System.Numerics.Vector3 StartLoc, System.Numerics.Vector3 EndLoc, out System.Numerics.Vector3 ResultLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveCollisionActor, "BmGame.MGroundProjectileGadgetBase.MoveCollisionActor");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLoc, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ResultLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResultLocation, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ResultLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_DrawGroundTrajectory;
    /// <summary>
    /// Function: DrawGroundTrajectory
    /// </summary>
    public unsafe virtual void DrawGroundTrajectory(System.Numerics.Vector3 StartLoc, System.Numerics.Vector3 EndLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawGroundTrajectory, "BmGame.MGroundProjectileGadgetBase.DrawGroundTrajectory");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLoc, paramsPtr + 12);
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

    private static BmSDK.Function __fn_GetThrowStartLocation;
    /// <summary>
    /// Function: GetThrowStartLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetThrowStartLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThrowStartLocation, "BmGame.MGroundProjectileGadgetBase.GetThrowStartLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CalculateThrowStartLocation;
    /// <summary>
    /// Function: CalculateThrowStartLocation
    /// </summary>
    public unsafe void CalculateThrowStartLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateThrowStartLocation, "BmGame.MGroundProjectileGadgetBase.CalculateThrowStartLocation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: CollisionActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor CollisionActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// StructProperty: RenderTargetStartLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RenderTargetStartLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1368);
}
