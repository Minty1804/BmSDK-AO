#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDAbilitiesGadgetsStats<br/>
/// (size = 1712)
/// (flags = 32786)
/// </summary>
public partial class GDAbilitiesGadgetsStats : BmSDK.SDEngine.SDFireteamObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDAbilitiesGadgetsStats", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDAbilitiesGadgetsStats.
    /// </summary>
    public static GDAbilitiesGadgetsStats DefaultObject => (GDAbilitiesGadgetsStats)StaticClass().DefaultObject;

    internal GDAbilitiesGadgetsStats() { }

    /// <summary>
    /// Constructs a new GDAbilitiesGadgetsStats
    /// </summary>
    public GDAbilitiesGadgetsStats(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDAbilitiesGadgetsStats Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDAbilitiesGadgetsStats(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStats>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStats>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStats>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStats>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStats>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStats>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStats>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDAbilitiesGadgetsStats>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// IntProperty: FragGrenade_TimeAvailable
    /// </summary>
    public unsafe int FragGrenade_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// IntProperty: FragGrenade_TimeEquipped
    /// </summary>
    public unsafe int FragGrenade_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// IntProperty: FragGrenade_TimesUsed
    /// </summary>
    public unsafe int FragGrenade_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// IntProperty: FragGrenade_Hits
    /// </summary>
    public unsafe int FragGrenade_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// IntProperty: FragGrenade_Kills
    /// </summary>
    public unsafe int FragGrenade_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// IntProperty: FragGrenade_Assists
    /// </summary>
    public unsafe int FragGrenade_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// IntProperty: FragGrenade_Damage
    /// </summary>
    public unsafe int FragGrenade_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// IntProperty: FragGrenade_Deaths
    /// </summary>
    public unsafe int FragGrenade_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// IntProperty: Melee_TimeAvailable
    /// </summary>
    public unsafe int Melee_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// IntProperty: Melee_TimeEquipped
    /// </summary>
    public unsafe int Melee_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: Melee_TimesUsed
    /// </summary>
    public unsafe int Melee_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// IntProperty: Melee_Hits
    /// </summary>
    public unsafe int Melee_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// IntProperty: Melee_Kills
    /// </summary>
    public unsafe int Melee_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// IntProperty: Melee_Assists
    /// </summary>
    public unsafe int Melee_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// IntProperty: Melee_Damage
    /// </summary>
    public unsafe int Melee_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// IntProperty: Melee_Deaths
    /// </summary>
    public unsafe int Melee_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// IntProperty: DualWield01_TimeAvailable
    /// </summary>
    public unsafe int DualWield01_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// IntProperty: DualWield01_TimeEquipped
    /// </summary>
    public unsafe int DualWield01_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// IntProperty: DualWield01_TimesUsed
    /// </summary>
    public unsafe int DualWield01_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// IntProperty: DualWield01_Hits
    /// </summary>
    public unsafe int DualWield01_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// IntProperty: DualWield01_Kills
    /// </summary>
    public unsafe int DualWield01_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// IntProperty: DualWield01_Assists
    /// </summary>
    public unsafe int DualWield01_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// IntProperty: DualWield01_Damage
    /// </summary>
    public unsafe int DualWield01_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// IntProperty: DualWield01_Deaths
    /// </summary>
    public unsafe int DualWield01_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// IntProperty: DualWield02_TimeAvailable
    /// </summary>
    public unsafe int DualWield02_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// IntProperty: DualWield02_TimeEquipped
    /// </summary>
    public unsafe int DualWield02_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// IntProperty: DualWield02_TimesUsed
    /// </summary>
    public unsafe int DualWield02_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// IntProperty: DualWield02_Hits
    /// </summary>
    public unsafe int DualWield02_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// IntProperty: DualWield02_Kills
    /// </summary>
    public unsafe int DualWield02_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// IntProperty: DualWield02_Assists
    /// </summary>
    public unsafe int DualWield02_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// IntProperty: DualWield02_Damage
    /// </summary>
    public unsafe int DualWield02_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// IntProperty: DualWield02_Deaths
    /// </summary>
    public unsafe int DualWield02_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// IntProperty: DualWield03_TimeAvailable
    /// </summary>
    public unsafe int DualWield03_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// IntProperty: DualWield03_TimeEquipped
    /// </summary>
    public unsafe int DualWield03_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: DualWield03_TimesUsed
    /// </summary>
    public unsafe int DualWield03_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// IntProperty: DualWield03_Hits
    /// </summary>
    public unsafe int DualWield03_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// IntProperty: DualWield03_Kills
    /// </summary>
    public unsafe int DualWield03_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// IntProperty: DualWield03_Assists
    /// </summary>
    public unsafe int DualWield03_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// IntProperty: DualWield03_Damage
    /// </summary>
    public unsafe int DualWield03_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// IntProperty: DualWield03_Deaths
    /// </summary>
    public unsafe int DualWield03_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// IntProperty: DualWield04_TimeAvailable
    /// </summary>
    public unsafe int DualWield04_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// IntProperty: DualWield04_TimeEquipped
    /// </summary>
    public unsafe int DualWield04_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// IntProperty: DualWield04_TimesUsed
    /// </summary>
    public unsafe int DualWield04_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// IntProperty: DualWield04_Hits
    /// </summary>
    public unsafe int DualWield04_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// IntProperty: DualWield04_Kills
    /// </summary>
    public unsafe int DualWield04_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// IntProperty: DualWield04_Assists
    /// </summary>
    public unsafe int DualWield04_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// IntProperty: DualWield04_Damage
    /// </summary>
    public unsafe int DualWield04_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// IntProperty: DualWield04_Deaths
    /// </summary>
    public unsafe int DualWield04_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// IntProperty: DualWield05_TimeAvailable
    /// </summary>
    public unsafe int DualWield05_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// IntProperty: DualWield05_TimeEquipped
    /// </summary>
    public unsafe int DualWield05_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// IntProperty: DualWield05_TimesUsed
    /// </summary>
    public unsafe int DualWield05_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// IntProperty: DualWield05_Hits
    /// </summary>
    public unsafe int DualWield05_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// IntProperty: DualWield05_Kills
    /// </summary>
    public unsafe int DualWield05_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// IntProperty: DualWield05_Assists
    /// </summary>
    public unsafe int DualWield05_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// IntProperty: DualWield05_Damage
    /// </summary>
    public unsafe int DualWield05_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// IntProperty: DualWield05_Deaths
    /// </summary>
    public unsafe int DualWield05_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter01_TimeAvailable
    /// </summary>
    public unsafe int RCHelicopter01_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter01_TimeEquipped
    /// </summary>
    public unsafe int RCHelicopter01_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter01_TimesUsed
    /// </summary>
    public unsafe int RCHelicopter01_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter01_Hits
    /// </summary>
    public unsafe int RCHelicopter01_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter01_Kills
    /// </summary>
    public unsafe int RCHelicopter01_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter01_Assists
    /// </summary>
    public unsafe int RCHelicopter01_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter01_Damage
    /// </summary>
    public unsafe int RCHelicopter01_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter01_Deaths
    /// </summary>
    public unsafe int RCHelicopter01_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter02_TimeAvailable
    /// </summary>
    public unsafe int RCHelicopter02_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter02_TimeEquipped
    /// </summary>
    public unsafe int RCHelicopter02_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter02_TimesUsed
    /// </summary>
    public unsafe int RCHelicopter02_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter02_Hits
    /// </summary>
    public unsafe int RCHelicopter02_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter02_Kills
    /// </summary>
    public unsafe int RCHelicopter02_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter02_Assists
    /// </summary>
    public unsafe int RCHelicopter02_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter02_Damage
    /// </summary>
    public unsafe int RCHelicopter02_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter02_Deaths
    /// </summary>
    public unsafe int RCHelicopter02_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter03_TimeAvailable
    /// </summary>
    public unsafe int RCHelicopter03_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter03_TimeEquipped
    /// </summary>
    public unsafe int RCHelicopter03_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter03_TimesUsed
    /// </summary>
    public unsafe int RCHelicopter03_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter03_Hits
    /// </summary>
    public unsafe int RCHelicopter03_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter03_Kills
    /// </summary>
    public unsafe int RCHelicopter03_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter03_Assists
    /// </summary>
    public unsafe int RCHelicopter03_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter03_Damage
    /// </summary>
    public unsafe int RCHelicopter03_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter03_Deaths
    /// </summary>
    public unsafe int RCHelicopter03_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter04_TimeAvailable
    /// </summary>
    public unsafe int RCHelicopter04_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter04_TimeEquipped
    /// </summary>
    public unsafe int RCHelicopter04_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter04_TimesUsed
    /// </summary>
    public unsafe int RCHelicopter04_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter04_Hits
    /// </summary>
    public unsafe int RCHelicopter04_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter04_Kills
    /// </summary>
    public unsafe int RCHelicopter04_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter04_Assists
    /// </summary>
    public unsafe int RCHelicopter04_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter04_Damage
    /// </summary>
    public unsafe int RCHelicopter04_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter04_Deaths
    /// </summary>
    public unsafe int RCHelicopter04_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter05_TimeAvailable
    /// </summary>
    public unsafe int RCHelicopter05_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter05_TimeEquipped
    /// </summary>
    public unsafe int RCHelicopter05_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter05_TimesUsed
    /// </summary>
    public unsafe int RCHelicopter05_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter05_Hits
    /// </summary>
    public unsafe int RCHelicopter05_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter05_Kills
    /// </summary>
    public unsafe int RCHelicopter05_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter05_Assists
    /// </summary>
    public unsafe int RCHelicopter05_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter05_Damage
    /// </summary>
    public unsafe int RCHelicopter05_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// IntProperty: RCHelicopter05_Deaths
    /// </summary>
    public unsafe int RCHelicopter05_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead01_TimeAvailable
    /// </summary>
    public unsafe int SurpriseYoureDead01_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead01_TimeEquipped
    /// </summary>
    public unsafe int SurpriseYoureDead01_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead01_TimesUsed
    /// </summary>
    public unsafe int SurpriseYoureDead01_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead01_Hits
    /// </summary>
    public unsafe int SurpriseYoureDead01_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead01_Kills
    /// </summary>
    public unsafe int SurpriseYoureDead01_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead01_Assists
    /// </summary>
    public unsafe int SurpriseYoureDead01_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead01_Damage
    /// </summary>
    public unsafe int SurpriseYoureDead01_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead01_Deaths
    /// </summary>
    public unsafe int SurpriseYoureDead01_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead02_TimeAvailable
    /// </summary>
    public unsafe int SurpriseYoureDead02_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead02_TimeEquipped
    /// </summary>
    public unsafe int SurpriseYoureDead02_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead02_TimesUsed
    /// </summary>
    public unsafe int SurpriseYoureDead02_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead02_Hits
    /// </summary>
    public unsafe int SurpriseYoureDead02_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead02_Kills
    /// </summary>
    public unsafe int SurpriseYoureDead02_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead02_Assists
    /// </summary>
    public unsafe int SurpriseYoureDead02_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead02_Damage
    /// </summary>
    public unsafe int SurpriseYoureDead02_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead02_Deaths
    /// </summary>
    public unsafe int SurpriseYoureDead02_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead03_TimeAvailable
    /// </summary>
    public unsafe int SurpriseYoureDead03_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead03_TimeEquipped
    /// </summary>
    public unsafe int SurpriseYoureDead03_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead03_TimesUsed
    /// </summary>
    public unsafe int SurpriseYoureDead03_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead03_Hits
    /// </summary>
    public unsafe int SurpriseYoureDead03_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead03_Kills
    /// </summary>
    public unsafe int SurpriseYoureDead03_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead03_Assists
    /// </summary>
    public unsafe int SurpriseYoureDead03_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead03_Damage
    /// </summary>
    public unsafe int SurpriseYoureDead03_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead03_Deaths
    /// </summary>
    public unsafe int SurpriseYoureDead03_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead04_TimeAvailable
    /// </summary>
    public unsafe int SurpriseYoureDead04_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead04_TimeEquipped
    /// </summary>
    public unsafe int SurpriseYoureDead04_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead04_TimesUsed
    /// </summary>
    public unsafe int SurpriseYoureDead04_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead04_Hits
    /// </summary>
    public unsafe int SurpriseYoureDead04_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead04_Kills
    /// </summary>
    public unsafe int SurpriseYoureDead04_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead04_Assists
    /// </summary>
    public unsafe int SurpriseYoureDead04_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead04_Damage
    /// </summary>
    public unsafe int SurpriseYoureDead04_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead04_Deaths
    /// </summary>
    public unsafe int SurpriseYoureDead04_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead05_TimeAvailable
    /// </summary>
    public unsafe int SurpriseYoureDead05_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead05_TimeEquipped
    /// </summary>
    public unsafe int SurpriseYoureDead05_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead05_TimesUsed
    /// </summary>
    public unsafe int SurpriseYoureDead05_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead05_Hits
    /// </summary>
    public unsafe int SurpriseYoureDead05_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead05_Kills
    /// </summary>
    public unsafe int SurpriseYoureDead05_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead05_Assists
    /// </summary>
    public unsafe int SurpriseYoureDead05_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead05_Damage
    /// </summary>
    public unsafe int SurpriseYoureDead05_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// IntProperty: SurpriseYoureDead05_Deaths
    /// </summary>
    public unsafe int SurpriseYoureDead05_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse01_TimeAvailable
    /// </summary>
    public unsafe int UltrasonicPulse01_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse01_TimeEquipped
    /// </summary>
    public unsafe int UltrasonicPulse01_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse01_TimesUsed
    /// </summary>
    public unsafe int UltrasonicPulse01_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse01_Hits
    /// </summary>
    public unsafe int UltrasonicPulse01_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse01_Kills
    /// </summary>
    public unsafe int UltrasonicPulse01_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse01_Assists
    /// </summary>
    public unsafe int UltrasonicPulse01_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse01_Damage
    /// </summary>
    public unsafe int UltrasonicPulse01_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse01_Deaths
    /// </summary>
    public unsafe int UltrasonicPulse01_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse02_TimeAvailable
    /// </summary>
    public unsafe int UltrasonicPulse02_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse02_TimeEquipped
    /// </summary>
    public unsafe int UltrasonicPulse02_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse02_TimesUsed
    /// </summary>
    public unsafe int UltrasonicPulse02_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse02_Hits
    /// </summary>
    public unsafe int UltrasonicPulse02_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse02_Kills
    /// </summary>
    public unsafe int UltrasonicPulse02_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse02_Assists
    /// </summary>
    public unsafe int UltrasonicPulse02_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse02_Damage
    /// </summary>
    public unsafe int UltrasonicPulse02_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse02_Deaths
    /// </summary>
    public unsafe int UltrasonicPulse02_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse03_TimeAvailable
    /// </summary>
    public unsafe int UltrasonicPulse03_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse03_TimeEquipped
    /// </summary>
    public unsafe int UltrasonicPulse03_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse03_TimesUsed
    /// </summary>
    public unsafe int UltrasonicPulse03_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse03_Hits
    /// </summary>
    public unsafe int UltrasonicPulse03_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse03_Kills
    /// </summary>
    public unsafe int UltrasonicPulse03_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse03_Assists
    /// </summary>
    public unsafe int UltrasonicPulse03_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse03_Damage
    /// </summary>
    public unsafe int UltrasonicPulse03_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse03_Deaths
    /// </summary>
    public unsafe int UltrasonicPulse03_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse04_TimeAvailable
    /// </summary>
    public unsafe int UltrasonicPulse04_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse04_TimeEquipped
    /// </summary>
    public unsafe int UltrasonicPulse04_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse04_TimesUsed
    /// </summary>
    public unsafe int UltrasonicPulse04_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse04_Hits
    /// </summary>
    public unsafe int UltrasonicPulse04_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse04_Kills
    /// </summary>
    public unsafe int UltrasonicPulse04_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse04_Assists
    /// </summary>
    public unsafe int UltrasonicPulse04_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse04_Damage
    /// </summary>
    public unsafe int UltrasonicPulse04_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse04_Deaths
    /// </summary>
    public unsafe int UltrasonicPulse04_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse05_TimeAvailable
    /// </summary>
    public unsafe int UltrasonicPulse05_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse05_TimeEquipped
    /// </summary>
    public unsafe int UltrasonicPulse05_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse05_TimesUsed
    /// </summary>
    public unsafe int UltrasonicPulse05_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse05_Hits
    /// </summary>
    public unsafe int UltrasonicPulse05_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse05_Kills
    /// </summary>
    public unsafe int UltrasonicPulse05_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse05_Assists
    /// </summary>
    public unsafe int UltrasonicPulse05_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse05_Damage
    /// </summary>
    public unsafe int UltrasonicPulse05_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// IntProperty: UltrasonicPulse05_Deaths
    /// </summary>
    public unsafe int UltrasonicPulse05_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// IntProperty: UAV01_TimeAvailable
    /// </summary>
    public unsafe int UAV01_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// IntProperty: UAV01_TimeEquipped
    /// </summary>
    public unsafe int UAV01_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// IntProperty: UAV01_TimesUsed
    /// </summary>
    public unsafe int UAV01_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// IntProperty: UAV01_Hits
    /// </summary>
    public unsafe int UAV01_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// IntProperty: UAV01_Kills
    /// </summary>
    public unsafe int UAV01_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// IntProperty: UAV01_Assists
    /// </summary>
    public unsafe int UAV01_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// IntProperty: UAV01_Damage
    /// </summary>
    public unsafe int UAV01_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// IntProperty: UAV01_Deaths
    /// </summary>
    public unsafe int UAV01_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// IntProperty: UAV02_TimeAvailable
    /// </summary>
    public unsafe int UAV02_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// IntProperty: UAV02_TimeEquipped
    /// </summary>
    public unsafe int UAV02_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// IntProperty: UAV02_TimesUsed
    /// </summary>
    public unsafe int UAV02_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// IntProperty: UAV02_Hits
    /// </summary>
    public unsafe int UAV02_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// IntProperty: UAV02_Kills
    /// </summary>
    public unsafe int UAV02_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// IntProperty: UAV02_Assists
    /// </summary>
    public unsafe int UAV02_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// IntProperty: UAV02_Damage
    /// </summary>
    public unsafe int UAV02_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// IntProperty: UAV02_Deaths
    /// </summary>
    public unsafe int UAV02_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// IntProperty: UAV03_TimeAvailable
    /// </summary>
    public unsafe int UAV03_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// IntProperty: UAV03_TimeEquipped
    /// </summary>
    public unsafe int UAV03_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// IntProperty: UAV03_TimesUsed
    /// </summary>
    public unsafe int UAV03_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// IntProperty: UAV03_Hits
    /// </summary>
    public unsafe int UAV03_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// IntProperty: UAV03_Kills
    /// </summary>
    public unsafe int UAV03_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// IntProperty: UAV03_Assists
    /// </summary>
    public unsafe int UAV03_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// IntProperty: UAV03_Damage
    /// </summary>
    public unsafe int UAV03_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// IntProperty: UAV03_Deaths
    /// </summary>
    public unsafe int UAV03_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// IntProperty: UAV04_TimeAvailable
    /// </summary>
    public unsafe int UAV04_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// IntProperty: UAV04_TimeEquipped
    /// </summary>
    public unsafe int UAV04_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// IntProperty: UAV04_TimesUsed
    /// </summary>
    public unsafe int UAV04_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// IntProperty: UAV04_Hits
    /// </summary>
    public unsafe int UAV04_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// IntProperty: UAV04_Kills
    /// </summary>
    public unsafe int UAV04_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// IntProperty: UAV04_Assists
    /// </summary>
    public unsafe int UAV04_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// IntProperty: UAV04_Damage
    /// </summary>
    public unsafe int UAV04_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// IntProperty: UAV04_Deaths
    /// </summary>
    public unsafe int UAV04_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// IntProperty: UAV05_TimeAvailable
    /// </summary>
    public unsafe int UAV05_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// IntProperty: UAV05_TimeEquipped
    /// </summary>
    public unsafe int UAV05_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// IntProperty: UAV05_TimesUsed
    /// </summary>
    public unsafe int UAV05_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// IntProperty: UAV05_Hits
    /// </summary>
    public unsafe int UAV05_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// IntProperty: UAV05_Kills
    /// </summary>
    public unsafe int UAV05_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// IntProperty: UAV05_Assists
    /// </summary>
    public unsafe int UAV05_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// IntProperty: UAV05_Damage
    /// </summary>
    public unsafe int UAV05_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// IntProperty: UAV05_Deaths
    /// </summary>
    public unsafe int UAV05_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// IntProperty: TacDart01_TimeAvailable
    /// </summary>
    public unsafe int TacDart01_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// IntProperty: TacDart01_TimeEquipped
    /// </summary>
    public unsafe int TacDart01_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// IntProperty: TacDart01_TimesUsed
    /// </summary>
    public unsafe int TacDart01_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// IntProperty: TacDart01_Hits
    /// </summary>
    public unsafe int TacDart01_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// IntProperty: TacDart01_Kills
    /// </summary>
    public unsafe int TacDart01_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// IntProperty: TacDart01_Assists
    /// </summary>
    public unsafe int TacDart01_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// IntProperty: TacDart01_Damage
    /// </summary>
    public unsafe int TacDart01_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// IntProperty: TacDart01_Deaths
    /// </summary>
    public unsafe int TacDart01_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// IntProperty: TacDart02_TimeAvailable
    /// </summary>
    public unsafe int TacDart02_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// IntProperty: TacDart02_TimeEquipped
    /// </summary>
    public unsafe int TacDart02_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// IntProperty: TacDart02_TimesUsed
    /// </summary>
    public unsafe int TacDart02_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// IntProperty: TacDart02_Hits
    /// </summary>
    public unsafe int TacDart02_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// IntProperty: TacDart02_Kills
    /// </summary>
    public unsafe int TacDart02_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// IntProperty: TacDart02_Assists
    /// </summary>
    public unsafe int TacDart02_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// IntProperty: TacDart02_Damage
    /// </summary>
    public unsafe int TacDart02_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// IntProperty: TacDart02_Deaths
    /// </summary>
    public unsafe int TacDart02_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// IntProperty: TacDart03_TimeAvailable
    /// </summary>
    public unsafe int TacDart03_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// IntProperty: TacDart03_TimeEquipped
    /// </summary>
    public unsafe int TacDart03_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// IntProperty: TacDart03_TimesUsed
    /// </summary>
    public unsafe int TacDart03_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// IntProperty: TacDart03_Hits
    /// </summary>
    public unsafe int TacDart03_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// IntProperty: TacDart03_Kills
    /// </summary>
    public unsafe int TacDart03_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// IntProperty: TacDart03_Assists
    /// </summary>
    public unsafe int TacDart03_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// IntProperty: TacDart03_Damage
    /// </summary>
    public unsafe int TacDart03_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// IntProperty: TacDart03_Deaths
    /// </summary>
    public unsafe int TacDart03_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// IntProperty: TacDart04_TimeAvailable
    /// </summary>
    public unsafe int TacDart04_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// IntProperty: TacDart04_TimeEquipped
    /// </summary>
    public unsafe int TacDart04_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// IntProperty: TacDart04_TimesUsed
    /// </summary>
    public unsafe int TacDart04_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// IntProperty: TacDart04_Hits
    /// </summary>
    public unsafe int TacDart04_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// IntProperty: TacDart04_Kills
    /// </summary>
    public unsafe int TacDart04_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// IntProperty: TacDart04_Assists
    /// </summary>
    public unsafe int TacDart04_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// IntProperty: TacDart04_Damage
    /// </summary>
    public unsafe int TacDart04_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// IntProperty: TacDart04_Deaths
    /// </summary>
    public unsafe int TacDart04_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// IntProperty: TacDart05_TimeAvailable
    /// </summary>
    public unsafe int TacDart05_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// IntProperty: TacDart05_TimeEquipped
    /// </summary>
    public unsafe int TacDart05_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// IntProperty: TacDart05_TimesUsed
    /// </summary>
    public unsafe int TacDart05_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// IntProperty: TacDart05_Hits
    /// </summary>
    public unsafe int TacDart05_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// IntProperty: TacDart05_Kills
    /// </summary>
    public unsafe int TacDart05_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// IntProperty: TacDart05_Assists
    /// </summary>
    public unsafe int TacDart05_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// IntProperty: TacDart05_Damage
    /// </summary>
    public unsafe int TacDart05_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// IntProperty: TacDart05_Deaths
    /// </summary>
    public unsafe int TacDart05_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// IntProperty: ExplosiveGel_TimeAvailable
    /// </summary>
    public unsafe int ExplosiveGel_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: ExplosiveGel_TimeEquipped
    /// </summary>
    public unsafe int ExplosiveGel_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// IntProperty: ExplosiveGel_TimesUsed
    /// </summary>
    public unsafe int ExplosiveGel_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// IntProperty: ExplosiveGel_Hits
    /// </summary>
    public unsafe int ExplosiveGel_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// IntProperty: ExplosiveGel_Kills
    /// </summary>
    public unsafe int ExplosiveGel_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// IntProperty: ExplosiveGel_Assists
    /// </summary>
    public unsafe int ExplosiveGel_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// IntProperty: ExplosiveGel_Damage
    /// </summary>
    public unsafe int ExplosiveGel_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// IntProperty: ExplosiveGel_Deaths
    /// </summary>
    public unsafe int ExplosiveGel_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// IntProperty: SmokePellet_TimeAvailable
    /// </summary>
    public unsafe int SmokePellet_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// IntProperty: SmokePellet_TimeEquipped
    /// </summary>
    public unsafe int SmokePellet_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// IntProperty: SmokePellet_TimesUsed
    /// </summary>
    public unsafe int SmokePellet_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// IntProperty: SmokePellet_Hits
    /// </summary>
    public unsafe int SmokePellet_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// IntProperty: SmokePellet_Kills
    /// </summary>
    public unsafe int SmokePellet_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// IntProperty: SmokePellet_Assists
    /// </summary>
    public unsafe int SmokePellet_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// IntProperty: SmokePellet_Damage
    /// </summary>
    public unsafe int SmokePellet_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// IntProperty: SmokePellet_Deaths
    /// </summary>
    public unsafe int SmokePellet_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// IntProperty: Batarang_TimeAvailable
    /// </summary>
    public unsafe int Batarang_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// IntProperty: Batarang_TimeEquipped
    /// </summary>
    public unsafe int Batarang_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// IntProperty: Batarang_TimesUsed
    /// </summary>
    public unsafe int Batarang_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: Batarang_Hits
    /// </summary>
    public unsafe int Batarang_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// IntProperty: Batarang_Kills
    /// </summary>
    public unsafe int Batarang_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: Batarang_Assists
    /// </summary>
    public unsafe int Batarang_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// IntProperty: Batarang_Damage
    /// </summary>
    public unsafe int Batarang_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// IntProperty: Batarang_Deaths
    /// </summary>
    public unsafe int Batarang_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// IntProperty: ExplosiveBatarang_TimeAvailable
    /// </summary>
    public unsafe int ExplosiveBatarang_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// IntProperty: ExplosiveBatarang_TimeEquipped
    /// </summary>
    public unsafe int ExplosiveBatarang_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// IntProperty: ExplosiveBatarang_TimesUsed
    /// </summary>
    public unsafe int ExplosiveBatarang_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// IntProperty: ExplosiveBatarang_Hits
    /// </summary>
    public unsafe int ExplosiveBatarang_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// IntProperty: ExplosiveBatarang_Kills
    /// </summary>
    public unsafe int ExplosiveBatarang_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// IntProperty: ExplosiveBatarang_Assists
    /// </summary>
    public unsafe int ExplosiveBatarang_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// IntProperty: ExplosiveBatarang_Damage
    /// </summary>
    public unsafe int ExplosiveBatarang_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// IntProperty: ExplosiveBatarang_Deaths
    /// </summary>
    public unsafe int ExplosiveBatarang_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// IntProperty: ClusterBatarang_TimeAvailable
    /// </summary>
    public unsafe int ClusterBatarang_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// IntProperty: ClusterBatarang_TimeEquipped
    /// </summary>
    public unsafe int ClusterBatarang_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// IntProperty: ClusterBatarang_TimesUsed
    /// </summary>
    public unsafe int ClusterBatarang_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// IntProperty: ClusterBatarang_Hits
    /// </summary>
    public unsafe int ClusterBatarang_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// IntProperty: ClusterBatarang_Kills
    /// </summary>
    public unsafe int ClusterBatarang_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// IntProperty: ClusterBatarang_Assists
    /// </summary>
    public unsafe int ClusterBatarang_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// IntProperty: ClusterBatarang_Damage
    /// </summary>
    public unsafe int ClusterBatarang_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// IntProperty: ClusterBatarang_Deaths
    /// </summary>
    public unsafe int ClusterBatarang_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// IntProperty: ZipKick_TimeAvailable
    /// </summary>
    public unsafe int ZipKick_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// IntProperty: ZipKick_TimeEquipped
    /// </summary>
    public unsafe int ZipKick_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// IntProperty: ZipKick_TimesUsed
    /// </summary>
    public unsafe int ZipKick_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// IntProperty: ZipKick_Hits
    /// </summary>
    public unsafe int ZipKick_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// IntProperty: ZipKick_Kills
    /// </summary>
    public unsafe int ZipKick_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// IntProperty: ZipKick_Assists
    /// </summary>
    public unsafe int ZipKick_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// IntProperty: ZipKick_Damage
    /// </summary>
    public unsafe int ZipKick_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// IntProperty: ZipKick_Deaths
    /// </summary>
    public unsafe int ZipKick_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// IntProperty: BulletShield_TimeAvailable
    /// </summary>
    public unsafe int BulletShield_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// IntProperty: BulletShield_TimeEquipped
    /// </summary>
    public unsafe int BulletShield_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// IntProperty: BulletShield_TimesUsed
    /// </summary>
    public unsafe int BulletShield_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// IntProperty: BulletShield_Hits
    /// </summary>
    public unsafe int BulletShield_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// IntProperty: BulletShield_Kills
    /// </summary>
    public unsafe int BulletShield_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// IntProperty: BulletShield_Assists
    /// </summary>
    public unsafe int BulletShield_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// IntProperty: BulletShield_Damage
    /// </summary>
    public unsafe int BulletShield_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// IntProperty: BulletShield_Deaths
    /// </summary>
    public unsafe int BulletShield_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// IntProperty: HangingTakedown_TimeAvailable
    /// </summary>
    public unsafe int HangingTakedown_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// IntProperty: HangingTakedown_TimeEquipped
    /// </summary>
    public unsafe int HangingTakedown_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// IntProperty: HangingTakedown_TimesUsed
    /// </summary>
    public unsafe int HangingTakedown_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// IntProperty: HangingTakedown_Hits
    /// </summary>
    public unsafe int HangingTakedown_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// IntProperty: HangingTakedown_Kills
    /// </summary>
    public unsafe int HangingTakedown_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// IntProperty: HangingTakedown_Assists
    /// </summary>
    public unsafe int HangingTakedown_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// IntProperty: HangingTakedown_Damage
    /// </summary>
    public unsafe int HangingTakedown_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// IntProperty: HangingTakedown_Deaths
    /// </summary>
    public unsafe int HangingTakedown_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// IntProperty: FloorTakedown_TimeAvailable
    /// </summary>
    public unsafe int FloorTakedown_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// IntProperty: FloorTakedown_TimeEquipped
    /// </summary>
    public unsafe int FloorTakedown_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// IntProperty: FloorTakedown_TimesUsed
    /// </summary>
    public unsafe int FloorTakedown_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// IntProperty: FloorTakedown_Hits
    /// </summary>
    public unsafe int FloorTakedown_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// IntProperty: FloorTakedown_Kills
    /// </summary>
    public unsafe int FloorTakedown_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// IntProperty: FloorTakedown_Assists
    /// </summary>
    public unsafe int FloorTakedown_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// IntProperty: FloorTakedown_Damage
    /// </summary>
    public unsafe int FloorTakedown_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// IntProperty: FloorTakedown_Deaths
    /// </summary>
    public unsafe int FloorTakedown_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// IntProperty: TunnelTakedown_TimeAvailable
    /// </summary>
    public unsafe int TunnelTakedown_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// IntProperty: TunnelTakedown_TimeEquipped
    /// </summary>
    public unsafe int TunnelTakedown_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// IntProperty: TunnelTakedown_TimesUsed
    /// </summary>
    public unsafe int TunnelTakedown_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// IntProperty: TunnelTakedown_Hits
    /// </summary>
    public unsafe int TunnelTakedown_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// IntProperty: TunnelTakedown_Kills
    /// </summary>
    public unsafe int TunnelTakedown_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// IntProperty: TunnelTakedown_Assists
    /// </summary>
    public unsafe int TunnelTakedown_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// IntProperty: TunnelTakedown_Damage
    /// </summary>
    public unsafe int TunnelTakedown_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// IntProperty: TunnelTakedown_Deaths
    /// </summary>
    public unsafe int TunnelTakedown_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// IntProperty: VentTakedown_TimeAvailable
    /// </summary>
    public unsafe int VentTakedown_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// IntProperty: VentTakedown_TimeEquipped
    /// </summary>
    public unsafe int VentTakedown_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// IntProperty: VentTakedown_TimesUsed
    /// </summary>
    public unsafe int VentTakedown_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// IntProperty: VentTakedown_Hits
    /// </summary>
    public unsafe int VentTakedown_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// IntProperty: VentTakedown_Kills
    /// </summary>
    public unsafe int VentTakedown_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// IntProperty: VentTakedown_Assists
    /// </summary>
    public unsafe int VentTakedown_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// IntProperty: VentTakedown_Damage
    /// </summary>
    public unsafe int VentTakedown_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// IntProperty: VentTakedown_Deaths
    /// </summary>
    public unsafe int VentTakedown_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// IntProperty: GlassTakedown_TimeAvailable
    /// </summary>
    public unsafe int GlassTakedown_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// IntProperty: GlassTakedown_TimeEquipped
    /// </summary>
    public unsafe int GlassTakedown_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// IntProperty: GlassTakedown_TimesUsed
    /// </summary>
    public unsafe int GlassTakedown_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// IntProperty: GlassTakedown_Hits
    /// </summary>
    public unsafe int GlassTakedown_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// IntProperty: GlassTakedown_Kills
    /// </summary>
    public unsafe int GlassTakedown_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// IntProperty: GlassTakedown_Assists
    /// </summary>
    public unsafe int GlassTakedown_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// IntProperty: GlassTakedown_Damage
    /// </summary>
    public unsafe int GlassTakedown_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// IntProperty: GlassTakedown_Deaths
    /// </summary>
    public unsafe int GlassTakedown_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// IntProperty: DoubleTakedown_TimeAvailable
    /// </summary>
    public unsafe int DoubleTakedown_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// IntProperty: DoubleTakedown_TimeEquipped
    /// </summary>
    public unsafe int DoubleTakedown_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// IntProperty: DoubleTakedown_TimesUsed
    /// </summary>
    public unsafe int DoubleTakedown_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// IntProperty: DoubleTakedown_Hits
    /// </summary>
    public unsafe int DoubleTakedown_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// IntProperty: DoubleTakedown_Kills
    /// </summary>
    public unsafe int DoubleTakedown_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// IntProperty: DoubleTakedown_Assists
    /// </summary>
    public unsafe int DoubleTakedown_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// IntProperty: DoubleTakedown_Damage
    /// </summary>
    public unsafe int DoubleTakedown_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// IntProperty: DoubleTakedown_Deaths
    /// </summary>
    public unsafe int DoubleTakedown_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// IntProperty: KnockoutSmashTakedown_TimeAvailable
    /// </summary>
    public unsafe int KnockoutSmashTakedown_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// IntProperty: KnockoutSmashTakedown_TimeEquipped
    /// </summary>
    public unsafe int KnockoutSmashTakedown_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// IntProperty: KnockoutSmashTakedown_TimesUsed
    /// </summary>
    public unsafe int KnockoutSmashTakedown_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// IntProperty: KnockoutSmashTakedown_Hits
    /// </summary>
    public unsafe int KnockoutSmashTakedown_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// IntProperty: KnockoutSmashTakedown_Kills
    /// </summary>
    public unsafe int KnockoutSmashTakedown_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// IntProperty: KnockoutSmashTakedown_Assists
    /// </summary>
    public unsafe int KnockoutSmashTakedown_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// IntProperty: KnockoutSmashTakedown_Damage
    /// </summary>
    public unsafe int KnockoutSmashTakedown_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// IntProperty: KnockoutSmashTakedown_Deaths
    /// </summary>
    public unsafe int KnockoutSmashTakedown_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// IntProperty: SneakyTakedown_TimeAvailable
    /// </summary>
    public unsafe int SneakyTakedown_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// IntProperty: SneakyTakedown_TimeEquipped
    /// </summary>
    public unsafe int SneakyTakedown_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// IntProperty: SneakyTakedown_TimesUsed
    /// </summary>
    public unsafe int SneakyTakedown_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// IntProperty: SneakyTakedown_Hits
    /// </summary>
    public unsafe int SneakyTakedown_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// IntProperty: SneakyTakedown_Kills
    /// </summary>
    public unsafe int SneakyTakedown_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// IntProperty: SneakyTakedown_Assists
    /// </summary>
    public unsafe int SneakyTakedown_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// IntProperty: SneakyTakedown_Damage
    /// </summary>
    public unsafe int SneakyTakedown_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// IntProperty: SneakyTakedown_Deaths
    /// </summary>
    public unsafe int SneakyTakedown_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// IntProperty: DoubleLedgeTakedown_TimeAvailable
    /// </summary>
    public unsafe int DoubleLedgeTakedown_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }

    /// <summary>
    /// IntProperty: DoubleLedgeTakedown_TimeEquipped
    /// </summary>
    public unsafe int DoubleLedgeTakedown_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// IntProperty: DoubleLedgeTakedown_TimesUsed
    /// </summary>
    public unsafe int DoubleLedgeTakedown_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// IntProperty: DoubleLedgeTakedown_Hits
    /// </summary>
    public unsafe int DoubleLedgeTakedown_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// IntProperty: DoubleLedgeTakedown_Kills
    /// </summary>
    public unsafe int DoubleLedgeTakedown_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// IntProperty: DoubleLedgeTakedown_Assists
    /// </summary>
    public unsafe int DoubleLedgeTakedown_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// IntProperty: DoubleLedgeTakedown_Damage
    /// </summary>
    public unsafe int DoubleLedgeTakedown_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// IntProperty: DoubleLedgeTakedown_Deaths
    /// </summary>
    public unsafe int DoubleLedgeTakedown_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// IntProperty: RailingTakedown_TimeAvailable
    /// </summary>
    public unsafe int RailingTakedown_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// IntProperty: RailingTakedown_TimeEquipped
    /// </summary>
    public unsafe int RailingTakedown_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// IntProperty: RailingTakedown_TimesUsed
    /// </summary>
    public unsafe int RailingTakedown_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// IntProperty: RailingTakedown_Hits
    /// </summary>
    public unsafe int RailingTakedown_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// IntProperty: RailingTakedown_Kills
    /// </summary>
    public unsafe int RailingTakedown_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }

    /// <summary>
    /// IntProperty: RailingTakedown_Assists
    /// </summary>
    public unsafe int RailingTakedown_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }

    /// <summary>
    /// IntProperty: RailingTakedown_Damage
    /// </summary>
    public unsafe int RailingTakedown_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// IntProperty: RailingTakedown_Deaths
    /// </summary>
    public unsafe int RailingTakedown_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// IntProperty: LedgeTakedown_TimeAvailable
    /// </summary>
    public unsafe int LedgeTakedown_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// IntProperty: LedgeTakedown_TimeEquipped
    /// </summary>
    public unsafe int LedgeTakedown_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// IntProperty: LedgeTakedown_TimesUsed
    /// </summary>
    public unsafe int LedgeTakedown_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// IntProperty: LedgeTakedown_Hits
    /// </summary>
    public unsafe int LedgeTakedown_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }

    /// <summary>
    /// IntProperty: LedgeTakedown_Kills
    /// </summary>
    public unsafe int LedgeTakedown_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }

    /// <summary>
    /// IntProperty: LedgeTakedown_Assists
    /// </summary>
    public unsafe int LedgeTakedown_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// IntProperty: LedgeTakedown_Damage
    /// </summary>
    public unsafe int LedgeTakedown_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1640); }
    }

    /// <summary>
    /// IntProperty: LedgeTakedown_Deaths
    /// </summary>
    public unsafe int LedgeTakedown_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1644); }
    }

    /// <summary>
    /// IntProperty: ReverseChokeTakedown_TimeAvailable
    /// </summary>
    public unsafe int ReverseChokeTakedown_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }
    }

    /// <summary>
    /// IntProperty: ReverseChokeTakedown_TimeEquipped
    /// </summary>
    public unsafe int ReverseChokeTakedown_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1652); }
    }

    /// <summary>
    /// IntProperty: ReverseChokeTakedown_TimesUsed
    /// </summary>
    public unsafe int ReverseChokeTakedown_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }
    }

    /// <summary>
    /// IntProperty: ReverseChokeTakedown_Hits
    /// </summary>
    public unsafe int ReverseChokeTakedown_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// IntProperty: ReverseChokeTakedown_Kills
    /// </summary>
    public unsafe int ReverseChokeTakedown_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// IntProperty: ReverseChokeTakedown_Assists
    /// </summary>
    public unsafe int ReverseChokeTakedown_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// IntProperty: ReverseChokeTakedown_Damage
    /// </summary>
    public unsafe int ReverseChokeTakedown_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// IntProperty: ReverseChokeTakedown_Deaths
    /// </summary>
    public unsafe int ReverseChokeTakedown_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// IntProperty: CornerTakedown_TimeAvailable
    /// </summary>
    public unsafe int CornerTakedown_TimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }

    /// <summary>
    /// IntProperty: CornerTakedown_TimeEquipped
    /// </summary>
    public unsafe int CornerTakedown_TimeEquipped
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// IntProperty: CornerTakedown_TimesUsed
    /// </summary>
    public unsafe int CornerTakedown_TimesUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1688); }
    }

    /// <summary>
    /// IntProperty: CornerTakedown_Hits
    /// </summary>
    public unsafe int CornerTakedown_Hits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// IntProperty: CornerTakedown_Kills
    /// </summary>
    public unsafe int CornerTakedown_Kills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }

    /// <summary>
    /// IntProperty: CornerTakedown_Assists
    /// </summary>
    public unsafe int CornerTakedown_Assists
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// IntProperty: CornerTakedown_Damage
    /// </summary>
    public unsafe int CornerTakedown_Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// IntProperty: CornerTakedown_Deaths
    /// </summary>
    public unsafe int CornerTakedown_Deaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }
}
