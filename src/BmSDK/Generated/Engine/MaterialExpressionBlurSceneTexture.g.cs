#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionBlurSceneTexture<br/>
/// (size = 220)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionBlurSceneTexture : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionBlurSceneTexture", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MaterialExpressionBlurSceneTexture.
    /// </summary>
    public static MaterialExpressionBlurSceneTexture DefaultObject => (MaterialExpressionBlurSceneTexture)StaticClass().DefaultObject;

    internal MaterialExpressionBlurSceneTexture() { }

    /// <summary>
    /// Constructs a new MaterialExpressionBlurSceneTexture
    /// </summary>
    public MaterialExpressionBlurSceneTexture(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionBlurSceneTexture Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionBlurSceneTexture(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionBlurSceneTexture>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionBlurSceneTexture>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionBlurSceneTexture>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionBlurSceneTexture>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionBlurSceneTexture>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionBlurSceneTexture>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionBlurSceneTexture>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionBlurSceneTexture>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Enum: ESampleBlurSceneType
    /// </summary>
    public enum ESampleBlurSceneType : byte
    {
        SampleBlurScene_PoissonDisc = 0,
        SampleBlurScene_MAX = 1,
    }

    /// <summary>
    /// Enum: EBlurSceneTextureType
    /// </summary>
    public enum EBlurSceneTextureType : byte
    {
        BlurSceneTex_Lighting = 0,
        BlurSceneTex_MAX = 1,
    }

    /// <summary>
    /// StructProperty: Coordinates
    /// </summary>
    public unsafe ref BmSDK.Engine.MaterialExpression.FExpressionInput Coordinates
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 116);

    /// <summary>
    /// StructProperty: SampleRadius
    /// </summary>
    public unsafe ref BmSDK.Engine.MaterialExpression.FExpressionInput SampleRadius
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 160);

    /// <summary>
    /// ByteProperty: BlurSceneTextureType
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionBlurSceneTexture.EBlurSceneTextureType BlurSceneTextureType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionBlurSceneTexture.EBlurSceneTextureType>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ByteProperty: SampleBlurSceneType
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionBlurSceneTexture.ESampleBlurSceneType SampleBlurSceneType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionBlurSceneTexture.ESampleBlurSceneType>(Ptr + 205); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 205); }
    }

    /// <summary>
    /// BoolProperty: ScreenAlign
    /// </summary>
    public unsafe bool ScreenAlign
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// IntProperty: SampleNum
    /// </summary>
    public unsafe int SampleNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// FloatProperty: SampleRadiusDefault
    /// </summary>
    public unsafe float SampleRadiusDefault
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
}
