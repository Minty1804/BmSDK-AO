#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MAnimNotify_CameraShake<br/>
/// (size = 208)
/// (flags = 134230162)
/// </summary>
public partial class MAnimNotify_CameraShake : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MAnimNotify_CameraShake", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MAnimNotify_CameraShake.
    /// </summary>
    public static MAnimNotify_CameraShake DefaultObject => (MAnimNotify_CameraShake)StaticClass().DefaultObject;

    internal MAnimNotify_CameraShake() { }

    /// <summary>
    /// Constructs a new MAnimNotify_CameraShake
    /// </summary>
    public MAnimNotify_CameraShake(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MAnimNotify_CameraShake Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MAnimNotify_CameraShake(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_CameraShake>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_CameraShake>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_CameraShake>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_CameraShake>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_CameraShake>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_CameraShake>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_CameraShake>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAnimNotify_CameraShake>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: SetPreMadeVals
    /// </summary>
    public unsafe virtual void SetPreMadeVals()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MAnimNotify_CameraShake.SetPreMadeVals", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: PreMadeSelection
    /// </summary>
    public unsafe BmSDK.BmGame.MAnimNotify_CameraShake.ECameraShakePreMades PreMadeSelection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MAnimNotify_CameraShake.ECameraShakePreMades>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// StructProperty: Shake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct Shake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 48);

    /// <summary>
    /// FloatProperty: Scale
    /// </summary>
    public unsafe float Scale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// ArrayProperty: PreMades
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct> PreMades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// Enum: ECameraShakePreMades
    /// </summary>
    public enum ECameraShakePreMades : byte
    {
        ECSPM_UseSpecifiedValues = 0,
        ECSPM_HitByBullet = 1,
        ECSPM_Shoved = 2,
        ECSPM_WeakExplosion = 3,
        ECSPM_StrongExplosion = 4,
        ECSPM_Earthquake = 5,
        ECSPM_Hammer = 6,
        ECSPM_Glide = 7,
        ECSPM_BoostGlide = 8,
        ECSPM_RegularImpact = 9,
        ECSPM_SuperImpact = 10,
        ECSPM_Lunatic = 11,
        ECSPM_Explosive = 12,
        ECSPM_ShotOnVantage = 13,
        ECSPM_FloatingRaft = 14,
        ECSPM_Helicopter = 15,
        ECSPM_MAX = 16,
    }
}
