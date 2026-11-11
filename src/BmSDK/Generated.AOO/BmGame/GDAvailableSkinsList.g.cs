#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDAvailableSkinsList<br/>
/// (size = 252)
/// (flags = 136347794)
/// </summary>
public partial class GDAvailableSkinsList : BmSDK.BmGame.GDDLCContentBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDAvailableSkinsList", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDAvailableSkinsList.
    /// </summary>
    public static GDAvailableSkinsList DefaultObject => (GDAvailableSkinsList)StaticClass().DefaultObject;

    internal GDAvailableSkinsList() { }

    /// <summary>
    /// Constructs a new GDAvailableSkinsList
    /// </summary>
    public GDAvailableSkinsList(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDAvailableSkinsList Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDAvailableSkinsList(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDAvailableSkinsList>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAvailableSkinsList>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDAvailableSkinsList>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAvailableSkinsList>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAvailableSkinsList>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAvailableSkinsList>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDAvailableSkinsList>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAvailableSkinsList>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetAllWeaponSkinsForWeapon;
    /// <summary>
    /// Function: GetAllWeaponSkinsForWeapon
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.GDWeaponSkin> GetAllWeaponSkinsForWeapon(BmSDK.BmGame.RGameInfo.WeaponId Weapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAllWeaponSkinsForWeapon, "BmGame.GDAvailableSkinsList.GetAllWeaponSkinsForWeapon");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDWeaponSkin>>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetWeaponSkinForWeapon;
    /// <summary>
    /// Function: GetWeaponSkinForWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDWeaponSkin GetWeaponSkinForWeapon(BmSDK.BmGame.RGameInfo.WeaponId Weapon, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponSkinForWeapon, "BmGame.GDAvailableSkinsList.GetWeaponSkinForWeapon");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDWeaponSkin>(paramsPtr + 8);
    }

    /// <summary>
    /// InlineArray{StructProperty}: AvailableSkins
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins> AvailableSkins => new(16, Ptr + 60, 12, this);

    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 60);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 72);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 84);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 96);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 108);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 120);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 132);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 144);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 156);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 168);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 180);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_11
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 192);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_12
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 204);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_13
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 216);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_14
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 228);
    /// <summary>
    /// StructProperty: AvailableSkins
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins AvailableSkins_15
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDAvailableSkinsList.FSAvailableSkins>(Ptr + 240);

    /// <summary>
    /// Struct: FSAvailableSkins
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSAvailableSkins
    {
        /// <summary>
        /// ArrayProperty: WeaponSkins
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDWeaponSkin> WeaponSkins
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDWeaponSkin>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }
}
