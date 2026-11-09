#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MPinWheelProjectileBase<br/>
/// (size = 612)
/// (flags = 142606994)
/// </summary>
public partial class MPinWheelProjectileBase : BmSDK.BmGame.RGadgetProjectileBase, BmSDK.BmGame.RSpotableInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MPinWheelProjectileBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPinWheelProjectileBase.
    /// </summary>
    public static MPinWheelProjectileBase DefaultObject => (MPinWheelProjectileBase)StaticClass().DefaultObject;

    internal MPinWheelProjectileBase() { }

    /// <summary>
    /// Constructs a new MPinWheelProjectileBase
    /// </summary>
    public MPinWheelProjectileBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPinWheelProjectileBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPinWheelProjectileBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPinWheelProjectileBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPinWheelProjectileBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPinWheelProjectileBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPinWheelProjectileBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPinWheelProjectileBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPinWheelProjectileBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPinWheelProjectileBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_AttractTarget;
    /// <summary>
    /// Function: AttractTarget
    /// </summary>
    public unsafe virtual void AttractTarget(BmSDK.BmGame.RBMAIController C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttractTarget, "BmGame.MPinWheelProjectileBase.AttractTarget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsStompped;
    /// <summary>
    /// Function: IsStompped
    /// </summary>
    public unsafe virtual bool IsStompped()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStompped, "BmGame.MPinWheelProjectileBase.IsStompped");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsExploding;
    /// <summary>
    /// Function: IsExploding
    /// </summary>
    public unsafe virtual bool IsExploding()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsExploding, "BmGame.MPinWheelProjectileBase.IsExploding");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAttracting;
    /// <summary>
    /// Function: IsAttracting
    /// </summary>
    public unsafe virtual bool IsAttracting()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAttracting, "BmGame.MPinWheelProjectileBase.IsAttracting");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsUnnoticed;
    /// <summary>
    /// Function: IsUnnoticed
    /// </summary>
    public unsafe virtual bool IsUnnoticed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsUnnoticed, "BmGame.MPinWheelProjectileBase.IsUnnoticed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_LocationReached;
    /// <summary>
    /// Function: LocationReached
    /// </summary>
    public unsafe virtual void LocationReached()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LocationReached, "BmGame.MPinWheelProjectileBase.LocationReached");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitWall;
    /// <summary>
    /// Function: HitWall
    /// </summary>
    public unsafe override void HitWall(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor Wall, BmSDK.Engine.PrimitiveComponent WallComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitWall, "BmGame.MPinWheelProjectileBase.HitWall");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Wall, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallComp, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Touch;
    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe override void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Touch, "BmGame.MPinWheelProjectileBase.Touch");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Fire;
    /// <summary>
    /// Function: Fire
    /// </summary>
    public unsafe override void Fire(System.Numerics.Vector3 LaunchLocation, System.Numerics.Vector3 TargetLocation, System.Numerics.Vector3 StartSpeed, bool bSecondary, BmSDK.Engine.Actor Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Fire, "BmGame.MPinWheelProjectileBase.Fire");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartSpeed, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSecondary, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAttractNum;
    /// <summary>
    /// Function: GetAttractNum
    /// </summary>
    public unsafe virtual int GetAttractNum()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAttractNum, "BmGame.MPinWheelProjectileBase.GetAttractNum");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAttractDistance;
    /// <summary>
    /// Function: GetAttractDistance
    /// </summary>
    public unsafe virtual float GetAttractDistance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAttractDistance, "BmGame.MPinWheelProjectileBase.GetAttractDistance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGlanceScore;
    /// <summary>
    /// Function: GetGlanceScore
    /// </summary>
    public unsafe virtual int GetGlanceScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlanceScore, "BmGame.MPinWheelProjectileBase.GetGlanceScore");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    /// <summary>
    /// StructProperty: VfTable_IRSpotableInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRSpotableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// FloatProperty: AttractDistance
    /// </summary>
    public unsafe float AttractDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// FloatProperty: AttractNumber
    /// </summary>
    public unsafe float AttractNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }
}
