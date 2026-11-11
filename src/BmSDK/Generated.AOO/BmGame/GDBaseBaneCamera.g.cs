#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDBaseBaneCamera<br/>
/// (size = 13320)
/// (flags = 10518550)
/// </summary>
public partial class GDBaseBaneCamera : BmSDK.BmGame.R3rdPersonCamera, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDBaseBaneCamera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDBaseBaneCamera.
    /// </summary>
    public static GDBaseBaneCamera DefaultObject => (GDBaseBaneCamera)StaticClass().DefaultObject;

    internal GDBaseBaneCamera() { }

    /// <summary>
    /// Constructs a new GDBaseBaneCamera
    /// </summary>
    public GDBaseBaneCamera(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDBaseBaneCamera(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDBaseBaneCamera>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDBaseBaneCamera>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDBaseBaneCamera>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDBaseBaneCamera>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDBaseBaneCamera>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDBaseBaneCamera>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDBaseBaneCamera>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDBaseBaneCamera>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetFreeCameraConfig;
    /// <summary>
    /// Function: SetFreeCameraConfig
    /// </summary>
    public unsafe override void SetFreeCameraConfig(BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig NewConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFreeCameraConfig, "BmGame.GDBaseBaneCamera.SetFreeCameraConfig");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: ChargeCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig ChargeCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 13152);

    /// <summary>
    /// StructProperty: ChargeOverShoulderOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChargeOverShoulderOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13276);

    /// <summary>
    /// FloatProperty: ChargeSmoothingConfigStrength
    /// </summary>
    public unsafe float ChargeSmoothingConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13288); }
    }

    /// <summary>
    /// FloatProperty: ChargeCameraPelvisFollowXY
    /// </summary>
    public unsafe float ChargeCameraPelvisFollowXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13292); }
    }

    /// <summary>
    /// FloatProperty: ChargeCameraPelvisFollowZ
    /// </summary>
    public unsafe float ChargeCameraPelvisFollowZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13296); }
    }

    /// <summary>
    /// FloatProperty: ChargeCameraPelvisSway
    /// </summary>
    public unsafe float ChargeCameraPelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13300); }
    }

    /// <summary>
    /// StructProperty: BaneRocketLauncherCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BaneRocketLauncherCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 13304);

    /// <summary>
    /// FloatProperty: BaneRocketLauncherCameraTransitionTime
    /// </summary>
    public unsafe float BaneRocketLauncherCameraTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13316); }
    }
}
