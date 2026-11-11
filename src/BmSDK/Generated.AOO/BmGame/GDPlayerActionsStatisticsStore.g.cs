#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDPlayerActionsStatisticsStore<br/>
/// (size = 120)
/// (flags = 134250642)
/// </summary>
public partial class GDPlayerActionsStatisticsStore : BmSDK.BmGame.GDStatisticsStore, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDPlayerActionsStatisticsStore", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDPlayerActionsStatisticsStore.
    /// </summary>
    public static GDPlayerActionsStatisticsStore DefaultObject => (GDPlayerActionsStatisticsStore)StaticClass().DefaultObject;

    internal GDPlayerActionsStatisticsStore() { }

    /// <summary>
    /// Constructs a new GDPlayerActionsStatisticsStore
    /// </summary>
    public GDPlayerActionsStatisticsStore(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDPlayerActionsStatisticsStore Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDPlayerActionsStatisticsStore(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPlayerActionsStatisticsStore>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerActionsStatisticsStore>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPlayerActionsStatisticsStore>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerActionsStatisticsStore>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerActionsStatisticsStore>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerActionsStatisticsStore>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPlayerActionsStatisticsStore>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerActionsStatisticsStore>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetMaxTypeCount;
    /// <summary>
    /// Function: GetMaxTypeCount
    /// </summary>
    public unsafe override int GetMaxTypeCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxTypeCount, "BmGame.GDPlayerActionsStatisticsStore.GetMaxTypeCount");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxCategoryCount, "BmGame.GDPlayerActionsStatisticsStore.GetMaxCategoryCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: EGDPlayerActionsStatType
    /// </summary>
    public enum EGDPlayerActionsStatType : byte
    {
        EGDPlayerActionsStatType_Player = 0,
        EGDPlayerActionsStatType_MAX = 1,
    }

    /// <summary>
    /// Enum: EGDPlayerActionsStatCategory
    /// </summary>
    public enum EGDPlayerActionsStatCategory : byte
    {
        EGDPlayerActionsStatCategory_TimePlayed = 0,
        EGDPlayerActionsStatCategory_TimeIdle = 1,
        EGDPlayerActionsStatCategory_Kills = 2,
        EGDPlayerActionsStatCategory_Assists = 3,
        EGDPlayerActionsStatCategory_Deaths = 4,
        EGDPlayerActionsStatCategory_XPEarned = 5,
        EGDPlayerActionsStatCategory_RoundsPlayed = 6,
        EGDPlayerActionsStatCategory_RoundsPlayedAsJoker = 7,
        EGDPlayerActionsStatCategory_RoundsPlayedAsBane = 8,
        EGDPlayerActionsStatCategory_RoundsPlayedAsHero = 9,
        EGDPlayerActionsStatCategory_Wins = 10,
        EGDPlayerActionsStatCategory_Losses = 11,
        EGDPlayerActionsStatCategory_TimeAlive = 12,
        EGDPlayerActionsStatCategory_TimeDead = 13,
        EGDPlayerActionsStatCategory_TimeKnockedOut = 14,
        EGDPlayerActionsStatCategory_MAX = 15,
    }
}
