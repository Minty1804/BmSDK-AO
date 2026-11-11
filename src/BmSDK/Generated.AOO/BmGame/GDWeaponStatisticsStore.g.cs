#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDWeaponStatisticsStore<br/>
/// (size = 120)
/// (flags = 134250642)
/// </summary>
public partial class GDWeaponStatisticsStore : BmSDK.BmGame.GDStatisticsStore, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDWeaponStatisticsStore", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDWeaponStatisticsStore.
    /// </summary>
    public static GDWeaponStatisticsStore DefaultObject => (GDWeaponStatisticsStore)StaticClass().DefaultObject;

    internal GDWeaponStatisticsStore() { }

    /// <summary>
    /// Constructs a new GDWeaponStatisticsStore
    /// </summary>
    public GDWeaponStatisticsStore(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDWeaponStatisticsStore Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDWeaponStatisticsStore(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDWeaponStatisticsStore>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDWeaponStatisticsStore>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDWeaponStatisticsStore>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDWeaponStatisticsStore>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDWeaponStatisticsStore>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDWeaponStatisticsStore>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDWeaponStatisticsStore>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDWeaponStatisticsStore>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetMaxTypeCount;
    /// <summary>
    /// Function: GetMaxTypeCount
    /// </summary>
    public unsafe override int GetMaxTypeCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxTypeCount, "BmGame.GDWeaponStatisticsStore.GetMaxTypeCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMaxCategoryCount;
    /// <summary>
    /// Function: GetMaxCategoryCount
    /// </summary>
    public unsafe override int GetMaxCategoryCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxCategoryCount, "BmGame.GDWeaponStatisticsStore.GetMaxCategoryCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: EGDWeaponStatType
    /// </summary>
    public enum EGDWeaponStatType : byte
    {
        EGDWeaponStatType_AssaultRifle01 = 0,
        EGDWeaponStatType_AssaultRifle02 = 1,
        EGDWeaponStatType_AssaultRifle03 = 2,
        EGDWeaponStatType_Shotgun01 = 3,
        EGDWeaponStatType_Shotgun02 = 4,
        EGDWeaponStatType_Shotgun03 = 5,
        EGDWeaponStatType_SMG01 = 6,
        EGDWeaponStatType_SMG02 = 7,
        EGDWeaponStatType_Sniper01 = 8,
        EGDWeaponStatType_Sniper02 = 9,
        EGDWeaponStatType_Sidearm01 = 10,
        EGDWeaponStatType_JokerGun01 = 11,
        EGDWeaponStatType_JokerGun02 = 12,
        EGDWeaponStatType_BaneRocketLauncher = 13,
        EGDWeaponStatType_MAX = 14,
    }

    /// <summary>
    /// Enum: EGDWeaponStatCategory
    /// </summary>
    public enum EGDWeaponStatCategory : byte
    {
        EGDWeaponStatCategory_TimeEquipped = 0,
        EGDWeaponStatCategory_ShotsFired = 1,
        EGDWeaponStatCategory_ShotsHit = 2,
        EGDWeaponStatCategory_DamageDone = 3,
        EGDWeaponStatCategory_Kills = 4,
        EGDWeaponStatCategory_XPEarned = 5,
        EGDWeaponStatCategory_Assists = 6,
        EGDWeaponStatCategory_Deaths = 7,
        EGDWeaponStatCategory_Headshots = 8,
        EGDWeaponStatCategory_TotalHitDist = 9,
        EGDWeaponStatCategory_Reloads = 10,
        EGDWeaponStatCategory_TimeAvailable = 11,
        EGDWeaponStatCategory_TimeEmpty = 12,
        EGDWeaponStatCategory_MAX = 13,
    }
}
