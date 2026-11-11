#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDPhysicalMaterialAltProperty<br/>
/// (size = 560)
/// (flags = 45074)
/// </summary>
public partial class GDPhysicalMaterialAltProperty : BmSDK.BmGame.RPhysicalMaterialProperty, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDPhysicalMaterialAltProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDPhysicalMaterialAltProperty.
    /// </summary>
    public static GDPhysicalMaterialAltProperty DefaultObject => (GDPhysicalMaterialAltProperty)StaticClass().DefaultObject;

    internal GDPhysicalMaterialAltProperty() { }

    /// <summary>
    /// Constructs a new GDPhysicalMaterialAltProperty
    /// </summary>
    public GDPhysicalMaterialAltProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDPhysicalMaterialAltProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDPhysicalMaterialAltProperty(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPhysicalMaterialAltProperty>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPhysicalMaterialAltProperty>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPhysicalMaterialAltProperty>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPhysicalMaterialAltProperty>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPhysicalMaterialAltProperty>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPhysicalMaterialAltProperty>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPhysicalMaterialAltProperty>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPhysicalMaterialAltProperty>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// StructProperty: AltBulletImpactInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo AltBulletImpactInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 416);

    /// <summary>
    /// StructProperty: AltBulletHeavyImpactInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo AltBulletHeavyImpactInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 464);

    /// <summary>
    /// StructProperty: AltBulletNailGunImpactInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo AltBulletNailGunImpactInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 512);
}
