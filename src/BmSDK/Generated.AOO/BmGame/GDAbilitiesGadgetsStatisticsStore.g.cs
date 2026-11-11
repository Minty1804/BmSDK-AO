#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDAbilitiesGadgetsStatisticsStore<br/>
/// (size = 120)
/// (flags = 134250642)
/// </summary>
public partial class GDAbilitiesGadgetsStatisticsStore : BmSDK.BmGame.GDStatisticsStore, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDAbilitiesGadgetsStatisticsStore", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDAbilitiesGadgetsStatisticsStore.
    /// </summary>
    public static GDAbilitiesGadgetsStatisticsStore DefaultObject => (GDAbilitiesGadgetsStatisticsStore)StaticClass().DefaultObject;

    internal GDAbilitiesGadgetsStatisticsStore() { }

    /// <summary>
    /// Constructs a new GDAbilitiesGadgetsStatisticsStore
    /// </summary>
    public GDAbilitiesGadgetsStatisticsStore(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDAbilitiesGadgetsStatisticsStore Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDAbilitiesGadgetsStatisticsStore(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStatisticsStore>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStatisticsStore>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStatisticsStore>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStatisticsStore>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStatisticsStore>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStatisticsStore>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStatisticsStore>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStatisticsStore>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetMaxTypeCount;
    /// <summary>
    /// Function: GetMaxTypeCount
    /// </summary>
    public unsafe override int GetMaxTypeCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxTypeCount, "BmGame.GDAbilitiesGadgetsStatisticsStore.GetMaxTypeCount");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxCategoryCount, "BmGame.GDAbilitiesGadgetsStatisticsStore.GetMaxCategoryCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: EGDAbiltiesStatType
    /// </summary>
    public enum EGDAbiltiesStatType : byte
    {
        EGDAbiltiesStatType_FragGrenade = 0,
        EGDAbiltiesStatType_Melee = 1,
        EGDAbiltiesStatType_DualWield01 = 2,
        EGDAbiltiesStatType_DualWield02 = 3,
        EGDAbiltiesStatType_DualWield03 = 4,
        EGDAbiltiesStatType_DualWield04 = 5,
        EGDAbiltiesStatType_DualWield05 = 6,
        EGDAbiltiesStatType_RCHelicopter01 = 7,
        EGDAbiltiesStatType_RCHelicopter02 = 8,
        EGDAbiltiesStatType_RCHelicopter03 = 9,
        EGDAbiltiesStatType_RCHelicopter04 = 10,
        EGDAbiltiesStatType_RCHelicopter05 = 11,
        EGDAbiltiesStatType_SurpriseYoureDead01 = 12,
        EGDAbiltiesStatType_SurpriseYoureDead02 = 13,
        EGDAbiltiesStatType_SurpriseYoureDead03 = 14,
        EGDAbiltiesStatType_SurpriseYoureDead04 = 15,
        EGDAbiltiesStatType_SurpriseYoureDead05 = 16,
        EGDAbiltiesStatType_UltrasonicPulse01 = 17,
        EGDAbiltiesStatType_UltrasonicPulse02 = 18,
        EGDAbiltiesStatType_UltrasonicPulse03 = 19,
        EGDAbiltiesStatType_UltrasonicPulse04 = 20,
        EGDAbiltiesStatType_UltrasonicPulse05 = 21,
        EGDAbiltiesStatType_UAV01 = 22,
        EGDAbiltiesStatType_UAV02 = 23,
        EGDAbiltiesStatType_UAV03 = 24,
        EGDAbiltiesStatType_UAV04 = 25,
        EGDAbiltiesStatType_UAV05 = 26,
        EGDAbiltiesStatType_TacDart01 = 27,
        EGDAbiltiesStatType_TacDart02 = 28,
        EGDAbiltiesStatType_TacDart03 = 29,
        EGDAbiltiesStatType_TacDart04 = 30,
        EGDAbiltiesStatType_TacDart05 = 31,
        EGDAbiltiesStatType_ExplosiveGel = 32,
        EGDAbiltiesStatType_SmokePellet = 33,
        EGDAbiltiesStatType_Batarang = 34,
        EGDAbiltiesStatType_ExplosiveBatarang = 35,
        EGDAbiltiesStatType_ClusterBatarang = 36,
        EGDAbiltiesStatType_ZipKick = 37,
        EGDAbiltiesStatType_BulletShield = 38,
        EGDAbiltiesStatType_HangingTakedown = 39,
        EGDAbiltiesStatType_FloorTakedown = 40,
        EGDAbiltiesStatType_TunnelTakedown = 41,
        EGDAbiltiesStatType_VentTakedown = 42,
        EGDAbiltiesStatType_GlassTakedown = 43,
        EGDAbiltiesStatType_DoubleTakedown = 44,
        EGDAbiltiesStatType_KnockoutSmashTakedown = 45,
        EGDAbiltiesStatType_SneakyTakedown = 46,
        EGDAbiltiesStatType_DoubleLedgeTakedown = 47,
        EGDAbiltiesStatType_RailingTakedown = 48,
        EGDAbiltiesStatType_LedgeTakedown = 49,
        EGDAbiltiesStatType_ReverseChokeTakedown = 50,
        EGDAbiltiesStatType_CornerTakedown = 51,
        EGDAbiltiesStatType_MAX = 52,
    }

    /// <summary>
    /// Enum: EGDAbilitiesStatCategory
    /// </summary>
    public enum EGDAbilitiesStatCategory : byte
    {
        EGDAbilitiesStatCategory_TimeAvailable = 0,
        EGDAbilitiesStatCategory_TimeEquipped = 1,
        EGDAbilitiesStatCategory_TimesUsed = 2,
        EGDAbilitiesStatCategory_Hits = 3,
        EGDAbilitiesStatCategory_Kills = 4,
        EGDAbilitiesStatCategory_Assists = 5,
        EGDAbilitiesStatCategory_Damage = 6,
        EGDAbilitiesStatCategory_Deaths = 7,
        EGDAbilitiesStatCategory_MAX = 8,
    }
}
