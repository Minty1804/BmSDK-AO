#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: TextureRenderTarget2D<br/>
/// (size = 256)
/// (flags = 134250642)
/// </summary>
public partial class TextureRenderTarget2D : BmSDK.Engine.TextureRenderTarget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.TextureRenderTarget2D", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as TextureRenderTarget2D.
    /// </summary>
    public static TextureRenderTarget2D DefaultObject => (TextureRenderTarget2D)StaticClass().DefaultObject;

    internal TextureRenderTarget2D() { }

    /// <summary>
    /// Constructs a new TextureRenderTarget2D
    /// </summary>
    public TextureRenderTarget2D(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TextureRenderTarget2D Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TextureRenderTarget2D(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<TextureRenderTarget2D>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<TextureRenderTarget2D>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<TextureRenderTarget2D>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<TextureRenderTarget2D>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<TextureRenderTarget2D>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<TextureRenderTarget2D>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<TextureRenderTarget2D>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<TextureRenderTarget2D>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_Create;
    /// <summary>
    /// Function: Create
    /// </summary>
    public unsafe static BmSDK.Engine.TextureRenderTarget2D Create(int InSizeX, int InSizeY, BmSDK.Engine.Texture.EPixelFormat InFormat = default, BmSDK.GameObject.FLinearColor InClearColor = default, bool bOnlyRenderOnce = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Create, "Engine.TextureRenderTarget2D.Create");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSizeX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSizeY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFormat, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InClearColor, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyRenderOnce, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.TextureRenderTarget2D>(paramsPtr + 32);
    }

    /// <summary>
    /// IntProperty: SizeX
    /// </summary>
    public unsafe int SizeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// IntProperty: SizeY
    /// </summary>
    public unsafe int SizeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ByteProperty: Format
    /// </summary>
    public unsafe BmSDK.Engine.Texture.EPixelFormat Format
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture.EPixelFormat>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// ByteProperty: AddressX
    /// </summary>
    public unsafe BmSDK.Engine.Texture.TextureAddress AddressX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture.TextureAddress>(Ptr + 233); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 233); }
    }

    /// <summary>
    /// ByteProperty: AddressY
    /// </summary>
    public unsafe BmSDK.Engine.Texture.TextureAddress AddressY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture.TextureAddress>(Ptr + 234); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 234); }
    }

    /// <summary>
    /// StructProperty: ClearColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor ClearColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 236);

    /// <summary>
    /// BoolProperty: bForceLinearGamma
    /// </summary>
    public unsafe bool bForceLinearGamma
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 252); }
    }
}

/// <summary>
/// The static native functions of TextureRenderTarget2D, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class TextureRenderTarget2DStatics
{
    private static BmSDK.Function __fn_Create;
    /// <summary>
    /// Function: Create, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static BmSDK.Engine.TextureRenderTarget2D Create(this BmSDK.Engine.TextureRenderTarget2D self, int InSizeX, int InSizeY, BmSDK.Engine.Texture.EPixelFormat InFormat = default, BmSDK.GameObject.FLinearColor InClearColor = default, bool bOnlyRenderOnce = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Create, "Engine.TextureRenderTarget2D.Create");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSizeX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSizeY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFormat, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InClearColor, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyRenderOnce, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.TextureRenderTarget2D>(paramsPtr + 32);
    }
}
