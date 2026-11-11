#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDThugWeaponsContentWrapper<br/>
/// (size = 252)
/// (flags = 134250642)
/// </summary>
public partial class GDThugWeaponsContentWrapper : BmSDK.BmGame.GDDLCContentBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDThugWeaponsContentWrapper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDThugWeaponsContentWrapper.
    /// </summary>
    public static GDThugWeaponsContentWrapper DefaultObject => (GDThugWeaponsContentWrapper)StaticClass().DefaultObject;

    internal GDThugWeaponsContentWrapper() { }

    /// <summary>
    /// Constructs a new GDThugWeaponsContentWrapper
    /// </summary>
    public GDThugWeaponsContentWrapper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDThugWeaponsContentWrapper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDThugWeaponsContentWrapper(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDThugWeaponsContentWrapper>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDThugWeaponsContentWrapper>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDThugWeaponsContentWrapper>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDThugWeaponsContentWrapper>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDThugWeaponsContentWrapper>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDThugWeaponsContentWrapper>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDThugWeaponsContentWrapper>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDThugWeaponsContentWrapper>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetBestUpgradeLevelForWeapon;
    /// <summary>
    /// Function: GetBestUpgradeLevelForWeapon
    /// </summary>
    public unsafe virtual int GetBestUpgradeLevelForWeapon(BmSDK.BmGame.RGameInfo.WeaponId WeaponIdentifier, bool bCheckShowInMenu = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestUpgradeLevelForWeapon, "BmGame.GDThugWeaponsContentWrapper.GetBestUpgradeLevelForWeapon");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponIdentifier, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckShowInMenu, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetWeaponByWeaponId;
    /// <summary>
    /// Function: GetWeaponByWeaponId
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RInventoryGadget GetWeaponByWeaponId(BmSDK.BmGame.RGameInfo.WeaponId WeaponIdentifier, int SpecificUpgradeLevel = default, bool bCheckUnlocked = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponByWeaponId, "BmGame.GDThugWeaponsContentWrapper.GetWeaponByWeaponId");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponIdentifier, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecificUpgradeLevel, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckUnlocked, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_WeaponLevelToUpgradeLevel;
    /// <summary>
    /// Function: WeaponLevelToUpgradeLevel
    /// </summary>
    public unsafe virtual int WeaponLevelToUpgradeLevel(BmSDK.BmGame.RGameInfo.WeaponId WeaponIdentifier, int WeaponLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponLevelToUpgradeLevel, "BmGame.GDThugWeaponsContentWrapper.WeaponLevelToUpgradeLevel");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponIdentifier, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponLevel, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    /// <summary>
    /// InlineArray{StructProperty}: ThugUseableWeapons
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent> ThugUseableWeapons => new(16, Ptr + 60, 12, this);

    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 60);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 72);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 84);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 96);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 108);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 120);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 132);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 144);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 156);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 168);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 180);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_11
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 192);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_12
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 204);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_13
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 216);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_14
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 228);
    /// <summary>
    /// StructProperty: ThugUseableWeapons
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent ThugUseableWeapons_15
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDThugWeaponsContentWrapper.FSWeaponContent>(Ptr + 240);

    /// <summary>
    /// Struct: FSWeaponContent
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSWeaponContent
    {
        /// <summary>
        /// ArrayProperty: WeaponsByUpgradeLevel
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDBaseGunGadget> WeaponsByUpgradeLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDBaseGunGadget>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }
}
